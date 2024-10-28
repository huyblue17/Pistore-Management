using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PiStoreManagement.Control
{
    public partial class ProductControl : UserControl
    {
        private PiStoreEntities db = new PiStoreEntities();

        public ProductControl()
        {
            InitializeComponent();
            controlDefault();
            clearText();
            viewData();
        }

        private void viewData()
        {
            var product = db.Products.Select(pro => new
            {
                pro.PID,
                pro.Pname,
                pro.Description,
                pro.Price,
                pro.PQuantity
            }).ToList();

            dgvProduct.DataSource = product;

            dgvProduct.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dgvProduct.Columns[0].HeaderText = "ID";
            dgvProduct.Columns[1].HeaderText = "Name";
            dgvProduct.Columns[2].HeaderText = "Description";
            dgvProduct.Columns[3].HeaderText = "Price";
            dgvProduct.Columns[4].HeaderText = "Quantity";
        }

        private void controlDefault()
        {
            txtPID.Enabled = false;
            txtPname.Enabled = false;
            txtPdes.Enabled = false;
            txtPrice.Enabled = false;
            txtQuan.Enabled = false;
          
            btnPSave.Enabled = false;
            btnPDelete.Enabled = false;
            btnPEdit.Enabled = false;
        }

        private void clearText()
        {
            txtPname.Clear();
            txtPdes.Clear();
            txtPrice.Clear();
            txtQuan.Clear();
            txtSearch.Clear();
        }

        private bool checkField()
        {

            return !string.IsNullOrWhiteSpace(txtPname.Text)
                && !string.IsNullOrWhiteSpace(txtPdes.Text)
                && !string.IsNullOrWhiteSpace(txtPrice.Text)
                && !string.IsNullOrWhiteSpace(txtQuan.Text);
        }

        private string idGenerator()
        {
            var productList = db.Products
                .Where(pro => pro.PID.StartsWith("P") && pro.PID.Length > 1)
                .ToList();


            int maxIdNumber = productList
                .Select(pro => int.Parse(pro.PID.Substring(1)))
                .DefaultIfEmpty(0)
                .Max() + 1;


            string newId = $"P{maxIdNumber:D3}";

            return newId;
        }

        private bool checkPrice()
        {
            if (decimal.TryParse(txtPrice.Text, out _))
            {
                return true;
            }
            else
            {
                MessageBox.Show("Invalid price.");
                return false;
            }
        }

        private bool checkQuan() 
        {
            if (int.TryParse(txtPrice.Text, out int number))
            {
                return true;
            }
            else
            {
                MessageBox.Show("Invalid number.");
                return false;
            }
        }

        private void btnCAdd_Click(object sender, EventArgs e)
        {
            txtPID.Text = idGenerator();

            txtPname.Enabled = true;
            txtPdes.Enabled = true;
            txtPrice.Enabled = true;
            txtQuan.Enabled = true;

            clearText();

            btnPSave.Enabled = true;
            btnPDelete.Enabled = false;
            btnPEdit.Enabled = false;
        }

        private void btnPCancel_Click(object sender, EventArgs e)
        {
            controlDefault();
            clearText();
            viewData();
            txtPID.Clear();
        }

        private void btnPSave_Click(object sender, EventArgs e)
        {
            if (!checkField())
            {
                MessageBox.Show("Please fill in all fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!checkPrice())
            {
                return;
            }

            if (!checkQuan())
            {
                return;
            }

            var newPro = new Product()
            {
                PID = txtPID.Text,
                Pname = txtPname.Text,
                Description = txtPdes.Text,
                Price = decimal.Parse(txtPrice.Text),
                PQuantity = int.Parse(txtPrice.Text)

            };

            db.Products.Add(newPro);
            db.SaveChanges();

            MessageBox.Show("Save Successfully!", "Success Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            viewData();
            controlDefault();
            clearText();
            txtPID.Clear();

        }

        private void btnPEdit_Click(object sender, EventArgs e)
        {
            var proToUpd = db.Products.FirstOrDefault(emp => emp.PID == txtPID.Text);
            if (proToUpd != null)
            {
                if (!checkField())
                {
                    MessageBox.Show("Please fill in all fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (!checkPrice())
                {
                    return;
                }

                if (!checkQuan())
                {
                    return;
                }

                proToUpd.Pname = txtPname.Text;
                proToUpd.Description = txtPdes.Text;
                proToUpd.Price = decimal.Parse(txtPrice.Text);
                proToUpd.PQuantity = int.Parse(txtQuan.Text);

                db.SaveChanges();
                MessageBox.Show("Updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                viewData();
                controlDefault();
                clearText();
                txtPID.Clear();
            }
            else
            {
                MessageBox.Show("Product not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnPDelete_Click(object sender, EventArgs e)
        {
            var proToDel = db.Products.FirstOrDefault(pro => pro.PID == txtPID.Text);

            if (proToDel != null)
            {
                db.Products.Remove(proToDel);
                db.SaveChanges();

                MessageBox.Show("Deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                viewData();
                controlDefault();
                clearText();
                txtPID.Clear();
            }
            else
            {
                MessageBox.Show("Product not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvProduct_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtPID.Text = dgvProduct.CurrentRow.Cells[0].Value.ToString();
            txtPname.Text = dgvProduct.CurrentRow.Cells[1].Value.ToString();
            txtPdes.Text = dgvProduct.CurrentRow.Cells[2].Value.ToString();
            txtPrice.Text = dgvProduct.CurrentRow.Cells[3].Value.ToString();
            txtQuan.Text = dgvProduct.CurrentRow.Cells[4].Value.ToString();
            

            btnPEdit.Enabled = true;
            btnPDelete.Enabled = true;

            txtPname.Enabled = true;
            txtPdes.Enabled = true;
            txtPrice.Enabled = true;
            txtQuan.Enabled = true;
        }

        private void btnPExport_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                sfd.Filter = "CSV files (*.csv)|*.csv";
                sfd.Title = "Save a Product File";
                sfd.FileName = "Products.csv";

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    using (var writer = new StreamWriter(sfd.FileName))
                    {
                        // Write the header
                        writer.WriteLine("ID,Name,Description,Price,Quantity");

                        // Write the data
                        foreach (DataGridViewRow row in dgvProduct.Rows)
                        {
                            if (row.IsNewRow) continue; // Skip the new row placeholder
                            writer.WriteLine($"{row.Cells[0].Value}," +
                                             $"{row.Cells[1].Value}," +
                                             $"{row.Cells[2].Value}," +
                                             $"{row.Cells[3].Value}," +
                                             $"{row.Cells[4].Value}");
                        }
                    }

                    MessageBox.Show("Exported successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}
