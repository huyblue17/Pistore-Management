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
    public partial class ItemControl : UserControl
    {
        PiStoreEntities db = new PiStoreEntities();

        public ItemControl()
        {
            InitializeComponent();
            loadComboBox();
            viewData();
            controlDefault();
            rtbClientName.Enabled = false;
            rtbProductName.Enabled = false;
        }

        private void controlDefault()
        {
            txtIID.Enabled = false;
            cbOrderID.Enabled = false;
            cbProductID.Enabled = false;
            txtQuantity.Enabled = false;

            btnISave.Enabled = false;
            btnIDelete.Enabled = false;
            btnIEdit.Enabled = false;
        }

        private void viewData()
        {
            var item = db.OrderItems.Select(itm => new
            {
                itm.IID,
                itm.OID,
                itm.PID,
                itm.Quantity
            }).ToList();

            dgvOrderItem.DataSource = item;
            dgvOrderItem.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dgvOrderItem.Columns[0].HeaderText = "ID";
            dgvOrderItem.Columns[1].HeaderText = "Oder ID";
            dgvOrderItem.Columns[2].HeaderText = "Product ID";
            dgvOrderItem.Columns[3].HeaderText = "Quantity";
        }

        private string idGenerator()
        {
            var itemList = db.OrderItems
                .Where(itm => itm.IID.StartsWith("I") && itm.IID.Length > 1)
                .ToList();


            int maxIdNumber = itemList
                .Select(itm => int.Parse(itm.IID.Substring(1)))
                .DefaultIfEmpty(0)
                .Max() + 1;


            string newId = $"I{maxIdNumber:D3}";

            return newId;
        }

        private void loadComboBox()
        {
            var ordList = db.Porders.Select(ord => ord.OID).ToList();
            ordList.Insert(0, "Select order ID");

            cbOrderID.DataSource = ordList;

            var proList = db.Products.Select(pro => pro.PID).ToList();
            proList.Insert(0, "Select product ID");

            cbProductID.DataSource = proList;
        }

        private void cbOrderID_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbOrderID.SelectedIndex > 0)
            {
                string selectedOrdID = cbOrderID.SelectedItem.ToString();
                var oderDisplay = db.Porders.FirstOrDefault(ord => ord.OID == selectedOrdID);

                if (oderDisplay != null)
                {
                    rtbClientName.Text = $"Client: {oderDisplay.Client.Cname}\n";
                }
            }
        }

        private void cbProductID_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbProductID.SelectedIndex > 0) 
            {
                string selectedProID = cbProductID.SelectedItem.ToString();
                var proDisplay = db.Products.FirstOrDefault(pro => pro.PID == selectedProID);

                if (proDisplay != null)
                {
                    rtbProductName.Text = $"Product: {proDisplay.Pname}\n"; 
                }
            }
        }

        private void btnIAdd_Click(object sender, EventArgs e)
        {
            cbOrderID.Enabled = true;
            cbProductID.Enabled = true;
            txtQuantity.Enabled = true;
            btnIEdit.Enabled = false;
            btnISave.Enabled = true;
        }

        private void btnISave_Click(object sender, EventArgs e)
        {
            if (cbOrderID.SelectedIndex <= 0 || cbProductID.SelectedIndex <= 0)
            {
                MessageBox.Show("Please select both an order and a product.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string selectedOrderID = cbOrderID.SelectedItem.ToString();
            string selectedProductID = cbProductID.SelectedItem.ToString();

            if (!int.TryParse(txtQuantity.Text, out int quantity) || quantity <= 0)
            {
                MessageBox.Show("Please enter a valid quantity.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var existingOrderItem = db.OrderItems
                .FirstOrDefault(oi => oi.OID == selectedOrderID && oi.PID == selectedProductID);

            var product = db.Products.FirstOrDefault(pro => pro.PID == selectedProductID);

            if (existingOrderItem != null)
            {
                existingOrderItem.Quantity += quantity;

                // Decrease product quantity
                if (product != null)
                {
                    product.PQuantity -= quantity; 
                }

                MessageBox.Show("Product already exists in this order. Quantity updated!", "Update Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                string newItemID = idGenerator();

                var newItem = new OrderItem
                {
                    IID = newItemID,
                    OID = selectedOrderID,
                    PID = selectedProductID,
                    Quantity = quantity
                };

                db.OrderItems.Add(newItem);

                if (product != null)
                {
                    product.PQuantity -= quantity; 
                }

                MessageBox.Show("New order item added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            db.SaveChanges();
            UpdateTotalPrice(selectedOrderID);
            viewData();
        }


        private void UpdateTotalPrice(string orderId)
        {
            // Get all order items for the given order ID
            var orderItems = db.OrderItems
                .Where(itm => itm.OID == orderId)
                .ToList();

            decimal totalPrice = 0;

            // Calculate the total price by summing the product of Price and Quantity for each item
            foreach (var item in orderItems)
            {
                // Find the corresponding product to get the price
                var product = db.Products.FirstOrDefault(pro => pro.PID == item.PID);

                if (product != null && product.Price.HasValue)
                {
                    totalPrice += product.Price.Value * (int)item.Quantity;
                }
            }

            // Update the total price in the order
            var order = db.Porders.FirstOrDefault(ord => ord.OID == orderId);
            if (order != null)
            {
                order.TotalPrice = totalPrice;

                // Assuming that the Bill is linked to the Order, update or create the Bill
                var bill = db.Bills.FirstOrDefault(b => b.OID == orderId);
                if (bill != null)
                {
                    bill.BTotalPrice = totalPrice;
                    bill.CID = order.CID;  // Assuming ClientID is available in the Order
                    bill.EID = order.EID; // Assuming EmployeeID is available in the Order
                }
                else
                {
                    // Create a new Bill if it doesn't exist
                    bill = new Bill
                    {
                        OID = orderId,
                        BTotalPrice = totalPrice,
                        CID = order.CID,
                        EID= order.EID
                    };
                    db.Bills.Add(bill);
                }

                db.SaveChanges();
            }

            lblPrice.Text = $"{totalPrice:C}";
        }


        private void dgvOrderItem_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtIID.Text = dgvOrderItem.CurrentRow.Cells[0].Value?.ToString() ?? string.Empty;
            cbOrderID.Text = dgvOrderItem.CurrentRow.Cells[1].Value?.ToString() ?? string.Empty;
            cbProductID.Text = dgvOrderItem.CurrentRow.Cells[2].Value?.ToString() ?? string.Empty;
            txtQuantity.Text = dgvOrderItem.CurrentRow.Cells[3].Value?.ToString() ?? string.Empty;

            UpdateTotalPrice(cbOrderID.SelectedItem.ToString());

            btnIEdit.Enabled = true;
            btnIDelete.Enabled = true;

            cbOrderID.Enabled = true;
            cbProductID.Enabled = true;
            txtQuantity.Enabled = true;
        }

        private void btnICancel_Click(object sender, EventArgs e)
        {
            controlDefault();
            loadComboBox();
        }

        private void btnIEdit_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtIID.Text))
            {
                MessageBox.Show("Please select an order item to edit.", "Selection Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validate inputs
            if (cbOrderID.SelectedIndex <= 0 || cbProductID.SelectedIndex <= 0)
            {
                MessageBox.Show("Please select both an order and a product.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(txtQuantity.Text, out int newQuantity) || newQuantity <= 0)
            {
                MessageBox.Show("Please enter a valid quantity.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string selectedItemID = txtIID.Text;
            var existingOrderItem = db.OrderItems.FirstOrDefault(oi => oi.IID == selectedItemID);

            if (existingOrderItem != null)
            {
                var product = db.Products.FirstOrDefault(pro => pro.PID == existingOrderItem.PID);

                if (product != null)
                {
                    product.PQuantity += existingOrderItem.Quantity;
                }

                existingOrderItem.OID = cbOrderID.SelectedItem.ToString();
                existingOrderItem.PID = cbProductID.SelectedItem.ToString();
                existingOrderItem.Quantity = newQuantity;

               
                if (product != null)
                {
                    product.PQuantity -= newQuantity;
                }

                db.SaveChanges();
                MessageBox.Show("Order item updated successfully!", "Update Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);

                UpdateTotalPrice(existingOrderItem.OID);
                controlDefault();
                viewData();
            }
            else
            {
                MessageBox.Show("Order item not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnIDelete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtIID.Text))
            {
                MessageBox.Show("Please select an order item to delete.", "Selection Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string selectedItemID = txtIID.Text;
            var existingOrderItem = db.OrderItems.FirstOrDefault(oi => oi.IID == selectedItemID);

            if (existingOrderItem != null)
            {
                var product = db.Products.FirstOrDefault(pro => pro.PID == existingOrderItem.PID);

                if (product != null)
                {
                    // Return the product quantity back to inventory
                    product.PQuantity += existingOrderItem.Quantity;
                }

                // Save the order ID to update the total price later
                string orderId = existingOrderItem.OID;

                // Remove the order item
                db.OrderItems.Remove(existingOrderItem);
                db.SaveChanges();

                MessageBox.Show("Order item deleted successfully!", "Delete Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Update the total price in the order and bill
                UpdateTotalPrice(orderId); // This method already handles bill updating

                controlDefault();
                viewData();
                loadComboBox();
            }
            else
            {
                MessageBox.Show("Order item not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
