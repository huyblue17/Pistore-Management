using System;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp.text.pdf.draw;

namespace PiStoreManagement.Control
{
    public partial class BillControl : UserControl
    {
        PiStoreEntities db = new PiStoreEntities();
        private string BillID = "-1";

        public BillControl()
        {
            InitializeComponent();
            viewData();
        }

        private void viewData()
        {
            var billList = db.Bills
                .Select(bill => new
                {
                    bill.BID,
                    bill.OID,
                    bill.CID,
                    bill.EID,
                    bill.BillDate,
                    bill.BTotalPrice
                })
                .ToList();

            dgvBill.DataSource = billList;

            dgvBill.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dgvBill.Columns[0].HeaderText = "Bill ID";
            dgvBill.Columns[1].HeaderText = "Order ID";
            dgvBill.Columns[2].HeaderText = "Client ID";
            dgvBill.Columns[3].HeaderText = "Employee ID";
            dgvBill.Columns[4].HeaderText = "Bill Date";
            dgvBill.Columns[5].HeaderText = "Total Price";
        }



        private void btnBSearch_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(txtSearch.Text))
            {
                viewData();
                return;
            }

            if (!DateTime.TryParseExact(txtSearch.Text, "MM/dd/yyyy", null, System.Globalization.DateTimeStyles.None, out DateTime searchDate))
            {
                MessageBox.Show("Please enter a valid date in DD/MM/YYYY format.", "Invalid Date", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var searchResults = db.Bills
                .Where(b => b.BillDate == searchDate.Date)
                .Select(bill => new
                {
                    bill.BID,
                    bill.OID,
                    bill.CID,
                    bill.EID,
                    bill.BillDate,
                    bill.BTotalPrice
                })
                .ToList();

            if (searchResults.Count == 0)
            {
                MessageBox.Show("No bills found for the given date.", "No Results", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            dgvBill.DataSource = searchResults;

            dgvBill.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void dgvBill_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvBill.Rows[e.RowIndex];
                BillID = row.Cells[0].Value.ToString();
            }
        }

        private void btnBill_Click(object sender, EventArgs e)
        {
            if (BillID == "-1")
            {
                MessageBox.Show("Please select a bill to export.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Fetch bill details along with related data
            var billDetails = (from bill in db.Bills
                               join order in db.Porders on bill.OID equals order.OID
                               join client in db.Clients on order.CID equals client.CID
                               join employee in db.Employees on order.EID equals employee.EID
                               join orderItem in db.OrderItems on order.OID equals orderItem.OID
                               join product in db.Products on orderItem.PID equals product.PID
                               where bill.BID == BillID
                               select new
                               {
                                   bill.BID,
                                   OrderID = order.OID,
                                   EmployeeName = employee.Ename,
                                   ClientName = client.Cname,
                                   BillDate = bill.BillDate,
                                   ProductName = product.Pname,
                                   Price = product.Price,
                                   Quantity = orderItem.Quantity
                               }).ToList();

            if (billDetails.Count == 0)
            {
                MessageBox.Show("No bill data found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                Filter = "PDF File|*.pdf",
                RestoreDirectory = true,
            };

            if (saveFileDialog.ShowDialog() != DialogResult.OK)
                return;

            try
            {
                using (FileStream stream = new FileStream(saveFileDialog.FileName, FileMode.Create))
                {
                    Document pdfDoc = new Document(PageSize.A4, 10f, 10f, 10f, 10f);
                    PdfWriter.GetInstance(pdfDoc, stream);
                    pdfDoc.Open();

                    iTextSharp.text.Font storeFont = FontFactory.GetFont("Times New Roman", 20, iTextSharp.text.Font.BOLD);
                    Paragraph storeName = new Paragraph("PiStore", storeFont)
                    {
                        Alignment = Element.ALIGN_CENTER,
                        SpacingAfter = 10f
                    };
                    pdfDoc.Add(storeName);

                    iTextSharp.text.Font infoFont = FontFactory.GetFont("Times New Roman", 12);
                    string formattedBillDate = billDetails.First().BillDate.Value.ToString("dd/MM/yyyy"); // Format the date as needed

                    Paragraph billInfo = new Paragraph
                    {
                        Alignment = Element.ALIGN_LEFT,
                        SpacingAfter = 20f
                    };

                    billInfo.Add($"Bill ID: {BillID}");
                    billInfo.Add(new Chunk(new VerticalPositionMark())); 
                    billInfo.Add($"Bill Date: {formattedBillDate}\n");

                    billInfo.Add($"Employee Name: {billDetails.First().EmployeeName}    Client Name: {billDetails.First().ClientName}\n");

                    pdfDoc.Add(billInfo);



                    PdfPTable pdfTable = new PdfPTable(3) 
                    {
                        WidthPercentage = 100,
                        HorizontalAlignment = Element.ALIGN_LEFT
                    };

                    pdfTable.AddCell("Product Name");
                    pdfTable.AddCell("Price");
                    pdfTable.AddCell("Quantity");

                    decimal grandTotal = 0;
                    foreach (var item in billDetails)
                    {
                        // Add cells to the PDF table
                        pdfTable.AddCell(item.ProductName);
                        pdfTable.AddCell(item.Price.ToString()); 
                        pdfTable.AddCell(item.Quantity.ToString());

                        grandTotal += (int)item.Price * (int)item.Quantity; 
                    }

                    pdfDoc.Add(pdfTable);

                    Paragraph totalParagraph = new Paragraph($"Grand Total: {grandTotal:C}", infoFont)
                    {
                        Alignment = Element.ALIGN_RIGHT,
                        SpacingBefore = 20f
                    };
                    pdfDoc.Add(totalParagraph);

                    Paragraph footer = new Paragraph("********** Thank you so much! **********")
                    {
                        Alignment = Element.ALIGN_CENTER,
                        SpacingBefore = 40f
                    };
                    pdfDoc.Add(footer);

                    pdfDoc.Close();
                    stream.Close();
                }

                MessageBox.Show("Bill exported successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error exporting bill: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        // Call this method when creating a new bill
        public void CreateNewBill(string orderId, string clientId, string employeeId, DateTime billDate, decimal totalPrice)
        {
            // Generate a new BillID

            // Create and add a new Bill to the database
            var newBill = new Bill
            {
                BID = BillID,
                OID = orderId,
                CID = clientId,
                EID = employeeId,
                BillDate = billDate,
                BTotalPrice = totalPrice
            };

            db.Bills.Add(newBill);
            db.SaveChanges();

            // Refresh the DataGridView
            viewData();
        }
    }
}
