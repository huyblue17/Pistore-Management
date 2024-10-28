using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PiStoreManagement.Control
{
    public partial class OrderControl : UserControl
    {
        PiStoreEntities db = new PiStoreEntities();

        public OrderControl()
        {
            InitializeComponent();
            loadComboBox();
            controlDefault();
            viewData();
            rtbClient.Enabled = false;
            rtbEmployee.Enabled = false;
            dtpOrder.Enabled = false;
        }

        private void controlDefault()
        {
            cbEmployee.Enabled = false;
            cbClient.Enabled = false;
            
            btnODelete.Enabled = false;
            btnOEdit.Enabled = false;
            btnOSave.Enabled = false;

            dtpOrder.Value = DateTime.Now;
        }

        private string idGenerator()
        {
            var orderList = db.Porders
                .Where(ord => ord.OID.StartsWith("O") && ord.OID.Length > 1)
                .ToList();


            int maxIdNumber = orderList
                .Select(ord => int.Parse(ord.OID.Substring(1)))
                .DefaultIfEmpty(0)
                .Max() + 1;


            string newId = $"O{maxIdNumber:D3}";

            return newId;
        }

        private string BidGenerator()
        {
            // Get the existing Bill IDs from the database
            var billList = db.Bills
                .Where(b => b.BID.StartsWith("B") && b.BID.Length > 1)
                .ToList();

            // Extract the numeric part and find the maximum number
            int maxIdNumber = billList
                .Select(b => int.Parse(b.BID.Substring(1))) // Remove the 'B' prefix and parse the number
                .DefaultIfEmpty(0) // If no existing bills, start from 0
                .Max() + 1; // Increment by 1 for the new ID

            // Generate the new ID with leading zeroes
            string newId = $"B{maxIdNumber:D3}";

            return newId;
        }

        private void loadComboBox()
        {
            var empList = db.Employees.Select(emp => new {emp.EID, emp.Ename}).ToList();
            empList.Insert(0, new {EID = "", Ename = "Select employee" });

            cbEmployee.DataSource = empList;
            cbEmployee.DisplayMember = "Ename";
            cbEmployee.ValueMember = "EID"; //Store EID

            var cliList = db.Clients.Select(cli => new {cli.CID, cli.Cname}).ToList();
            cliList.Insert(0, new {CID = "", Cname = "Select client" });

            cbClient.DataSource = cliList;
            cbClient.DisplayMember = "Cname";
            cbClient.ValueMember = "CID"; //Store CID
        }

        private void cbEmployee_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbEmployee.SelectedIndex > 0) // Ensures a valid selection
            {
                string selectedEmpID = cbEmployee.SelectedValue.ToString();
                var empDisplay = db.Employees.FirstOrDefault(emp => emp.EID == selectedEmpID);

                if (empDisplay != null)
                {
                    rtbEmployee.Text = $"ID: {empDisplay.EID}\n";
                }
            }
            else
            {
                rtbEmployee.Clear();
            }
        }


        private void cbClient_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbClient.SelectedIndex > 0)
            {
                string selectedCliID = cbClient.SelectedValue.ToString();

                var cliDisplay = db.Clients.FirstOrDefault(cli => cli.CID == selectedCliID);

                if (cliDisplay != null)
                {
                    rtbClient.Text = $"ID: {cliDisplay.CID}\n";
                }
            }
            else
            {
                rtbClient.Clear();
            }
        }

        private void btnOCancel_Click(object sender, EventArgs e)
        {
            controlDefault();
            viewData();
            loadComboBox();
            btnOAdd.Enabled = true;
        }

        private void btnOAdd_Click(object sender, EventArgs e)
        {
            cbEmployee.Enabled = true;
            cbClient.Enabled = true;
            btnODelete.Enabled = false;
            btnOEdit.Enabled = false;
            btnOSave.Enabled = true;
        }

        private void btnOSave_Click(object sender, EventArgs e)
        {
            if (cbClient.SelectedIndex <= 0 || cbEmployee.SelectedIndex <= 0)
            {
                MessageBox.Show("Please select both employee and client.", "Input error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string selectedEmpID = cbEmployee.SelectedValue.ToString();
            var selectedEmp = db.Employees.FirstOrDefault(emp => emp.EID == selectedEmpID);

            string selectedCliID = cbClient.SelectedValue.ToString();
            var selectedCli = db.Clients.FirstOrDefault(cli => cli.CID == selectedCliID);

            if (selectedEmp == null || selectedCli == null)
            {
                MessageBox.Show("Invalid employee or client.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string orderId = idGenerator();

            // Check if a Bill already exists for this Order ID
            var existingBill = db.Bills.FirstOrDefault(bil => bil.OID == orderId);
            if (existingBill != null)
            {
                MessageBox.Show("A bill already exists for this order.", "Duplicate Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var newOrder = new Porder
            {
                OID = orderId,
                EID = selectedEmp.EID,
                CID = selectedCli.CID,
                OrderDate = DateTime.Now,
                TotalPrice = 0
            };

            db.Porders.Add(newOrder);
            db.SaveChanges();

            // Create a new Bill entry with a unique BID
            var newBill = new Bill
            {
                BID = BidGenerator(), 
                OID = orderId,
                CID = selectedCli.CID,
                EID = selectedEmp.EID,
                BillDate = DateTime.Now,
                BTotalPrice = 0
            };

            db.Bills.Add(newBill);
            db.SaveChanges();

            MessageBox.Show("Save successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            viewData();
        }



        private void viewData()
        {
            var order = db.Porders.Select(ord => new
            {
                ord.OID,
                ord.CID,
                ord.EID,
                ord.OrderDate,
                ord.TotalPrice
            }).ToList();

            dgvOrder.DataSource = order;

            dgvOrder.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dgvOrder.Columns[0].HeaderText = "ID";
            dgvOrder.Columns[1].HeaderText = "Client ID";
            dgvOrder.Columns[2].HeaderText = "Employee ID";
            dgvOrder.Columns[3].HeaderText = "Order date";
            dgvOrder.Columns[4].HeaderText = "Total price";
        }

        private void dgvOrder_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string selectedClientId = dgvOrder.CurrentRow.Cells[1].Value.ToString();
            string selectedEmployeeId = dgvOrder.CurrentRow.Cells[2].Value.ToString();
            DateTime selectedOrderDate = Convert.ToDateTime(dgvOrder.CurrentRow.Cells[3].Value);

            var selectedClient = db.Clients.FirstOrDefault(cli => cli.CID == selectedClientId);
            if (selectedClient != null)
            {
                cbClient.SelectedItem = selectedClient.Cname;
                rtbClient.Text = $"ID: {selectedClient.CID}\n";
            }

            var selectedEmployee = db.Employees.FirstOrDefault(emp => emp.EID == selectedEmployeeId);
            if (selectedEmployee != null)
            {
                cbEmployee.SelectedItem = selectedEmployee.Ename;
                rtbEmployee.Text = $"ID: {selectedEmployee.EID}\n";
            }

            dtpOrder.Value = selectedOrderDate;

            btnOEdit.Enabled = true;
            btnODelete.Enabled = true;
            cbClient.Enabled = true;
            cbEmployee.Enabled = true;
            btnOAdd.Enabled = false;
        }

        private void btnOEdit_Click(object sender, EventArgs e)
        {
            if (dgvOrder.CurrentRow == null)
            {
                MessageBox.Show("Please select an order to edit.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (cbClient.SelectedIndex <= 0 || cbEmployee.SelectedIndex <= 0)
            {
                MessageBox.Show("Please select both an employee and a client.", "Input error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string selectedOrderId = dgvOrder.CurrentRow.Cells[0].Value.ToString();

            var orderToUpdate = db.Porders.FirstOrDefault(ord => ord.OID == selectedOrderId);
            if (orderToUpdate == null)
            {
                MessageBox.Show("Order not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string selectedEmpName = cbEmployee.SelectedItem.ToString();
            var selectedEmp = db.Employees.FirstOrDefault(emp => emp.Ename == selectedEmpName);

            string selectedCliName = cbClient.SelectedItem.ToString();
            var selectedCli = db.Clients.FirstOrDefault(cli => cli.Cname == selectedCliName);

            orderToUpdate.EID = selectedEmp.EID;
            orderToUpdate.CID = selectedCli.CID;
            orderToUpdate.OrderDate = DateTime.Now;

            db.SaveChanges();

            // Update the Bill associated with the Order
            var billToUpdate = db.Bills.FirstOrDefault(b => b.OID == selectedOrderId);
            if (billToUpdate != null)
            {
                billToUpdate.BillDate = DateTime.Now;
                billToUpdate.BTotalPrice = orderToUpdate.TotalPrice; // Update with the latest Order Total
                db.SaveChanges();
            }

            MessageBox.Show("Updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            viewData();
            controlDefault();
            rtbClient.Clear();
            rtbEmployee.Clear();
        }


        private void btnODelete_Click(object sender, EventArgs e)
        {
            if (dgvOrder.CurrentRow == null)
            {
                MessageBox.Show("Please select an order to delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string selectedOrderId = dgvOrder.CurrentRow.Cells[0].Value.ToString();

            // Find the associated bill and delete it first
            var billToDelete = db.Bills.FirstOrDefault(b => b.OID == selectedOrderId);
            if (billToDelete != null)
            {
                db.Bills.Remove(billToDelete);
            }

            // Now delete the order
            var orderToDelete = db.Porders.FirstOrDefault(ord => ord.OID == selectedOrderId);
            if (orderToDelete != null)
            {
                db.Porders.Remove(orderToDelete);
                db.SaveChanges();
                MessageBox.Show("Deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Refresh the data grid view
                viewData();
                controlDefault();
                loadComboBox();
                rtbClient.Clear();
                rtbEmployee.Clear();
            }
            else
            {
                MessageBox.Show("Order not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btnOSearch_Click(object sender, EventArgs e)
        {
            string searchText = txtOSearch.Text.Trim();

            DateTime searchDate;

            // Check if the input is a date
            bool isDate = DateTime.TryParse(searchText, out searchDate);

            var filteredOrders = db.Porders.AsQueryable();

            // Filter based on EID, CID or OrderDate
            if (!string.IsNullOrEmpty(searchText))
            {
                filteredOrders = filteredOrders.Where(ord =>
                    ord.EID.Contains(searchText) ||
                    ord.CID.Contains(searchText));
            }

            var orderList = filteredOrders.Select(ord => new
            {
                ord.OID,
                ord.CID,
                ord.EID,
                ord.OrderDate,
                ord.TotalPrice
            }).ToList();

            dgvOrder.DataSource = orderList;

            dgvOrder.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dgvOrder.Columns[0].HeaderText = "ID";
            dgvOrder.Columns[1].HeaderText = "Client ID";
            dgvOrder.Columns[2].HeaderText = "Employee ID";
            dgvOrder.Columns[3].HeaderText = "Order date";
        }
    }
}
