using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PiStoreManagement.Control
{
    public partial class ClientControl : UserControl
    {
        private PiStoreEntities db = new PiStoreEntities();

        public ClientControl()
        {
            InitializeComponent();
            viewData();
            controlDefault();
            clearText();
        }

        private void viewData()
        {
            var client = db.Clients.Select(cli => new
            {
                cli.CID,
                cli.Cname,
                cli.Cmail,
                cli.Cphone,
                cli.Caddress
            }).ToList();

            dgvClient.DataSource = client;

            dgvClient.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dgvClient.Columns[0].HeaderText = "ID";
            dgvClient.Columns[1].HeaderText = "Name";
            dgvClient.Columns[2].HeaderText = "Email";
            dgvClient.Columns[3].HeaderText = "Phone number";
            dgvClient.Columns[4].HeaderText = "Address";
        }

        private void controlDefault()
        {
            txtCID.Enabled = false;
            txtCName.Enabled = false;
            txtCmail.Enabled = false;
            txtCPhone.Enabled = false;
            txtCAddress.Enabled = false;

            btnCSave.Enabled = false;
            btnCDelete.Enabled = false;
            btnCEdit.Enabled = false;
        }

        private void clearText()
        {
            txtCName.Clear();
            txtCmail.Clear();
            txtCPhone.Clear();
            txtCAddress.Clear();
            txtSearch.Clear();
        }

        private bool checkField()
        {

            return !string.IsNullOrWhiteSpace(txtCName.Text)
                && !string.IsNullOrWhiteSpace(txtCmail.Text)
                && !string.IsNullOrWhiteSpace(txtCPhone.Text)
                && !string.IsNullOrWhiteSpace(txtCAddress.Text);
        }

        private string idGenerator()
        {
            var clientList = db.Clients
                .Where(cli => cli.CID.StartsWith("C") && cli.CID.Length > 1)
                .ToList();


            int maxIdNumber = clientList
                .Select(cli => int.Parse(cli.CID.Substring(1)))
                .DefaultIfEmpty(0)
                .Max() + 1;


            string newId = $"C{maxIdNumber:D3}";

            return newId;
        }

        private bool checkMail()
        {
            string regex = @"[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?";

            if (Regex.IsMatch(txtCmail.Text.Trim(), regex))
            {
                return true;
            }
            else
            {
                MessageBox.Show("Invalid email format.");
                return false;
            }

        }


        private bool checkPhone()
        {
            string regex = @"^\d+$";

            if (Regex.IsMatch(txtCPhone.Text.Trim(), regex))
            {
                return true;
            }
            else
            {
                MessageBox.Show("Invalid phone number.");
                return false;
            }
        }

        private void btnCCancel_Click(object sender, EventArgs e)
        {
            controlDefault();
            clearText();
            viewData();
            txtCID.Clear();
        }

        private void btnCAdd_Click(object sender, EventArgs e)
        {
            txtCID.Text = idGenerator();

            txtCName.Enabled = true;
            txtCmail.Enabled = true;
            txtCPhone.Enabled = true;
            txtCAddress.Enabled = true;

            clearText();

            btnCSave.Enabled = true;
            btnCDelete.Enabled = false;
            btnCEdit.Enabled = false;
        }

        private void btnCSave_Click(object sender, EventArgs e)
        {
            if (!checkField())
            {
                MessageBox.Show("Please fill in all fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!checkMail())
            {

                return;
            }

            if (!checkPhone())
            {
                return;
            }

            var newCli = new Client()
            {
                CID = txtCID.Text,
                Cname = txtCName.Text,
                Cmail = txtCmail.Text,
                Caddress = txtCAddress.Text,
                Cphone = int.Parse(txtCPhone.Text)
            };

            db.Clients.Add(newCli);
            db.SaveChanges();

            MessageBox.Show("Save Successfully!", "Success Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            viewData();
            controlDefault();
            clearText();
            txtCID.Clear();
        }

        private void dgvClient_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtCID.Text = dgvClient.CurrentRow.Cells[0].Value.ToString();
            txtCName.Text = dgvClient.CurrentRow.Cells[1].Value.ToString();
            txtCmail.Text = dgvClient.CurrentRow.Cells[2].Value.ToString();
            txtCPhone.Text = dgvClient.CurrentRow.Cells[3].Value.ToString();
            txtCAddress.Text = dgvClient.CurrentRow.Cells[4].Value.ToString();

            btnCEdit.Enabled = true;
            btnCDelete.Enabled = true;

            txtCName.Enabled = true;
            txtCmail.Enabled = true;
            txtCPhone.Enabled = true;
            txtCAddress.Enabled = true;
        }

        private void btnCDelete_Click(object sender, EventArgs e)
        {
            var cliToDel = db.Clients.FirstOrDefault(emp => emp.CID == txtCID.Text);

            if (cliToDel != null)
            {
                db.Clients.Remove(cliToDel);
                db.SaveChanges();

                MessageBox.Show("Deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                viewData();
                controlDefault();
                clearText();
                txtCID.Clear();
            }
            else
            {
                MessageBox.Show("Client not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCEdit_Click(object sender, EventArgs e)
        {
            var cliToUpd = db.Clients.FirstOrDefault(emp => emp.CID == txtCID.Text);
            if (cliToUpd != null)
            {
                cliToUpd.Cname = txtCName.Text;
                cliToUpd.Cmail = txtCmail.Text;
                cliToUpd.Cphone = int.Parse(txtCPhone.Text);
                cliToUpd.Caddress = txtCAddress.Text;

                db.SaveChanges();
                MessageBox.Show("Updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                viewData();
                controlDefault();
                clearText();

            }
            else
            {
                MessageBox.Show("Client not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCSearch_Click(object sender, EventArgs e)
        {
            string searchTerm = txtSearch.Text.Trim();

            var searchResults = db.Clients.AsQueryable();

            if (string.IsNullOrEmpty(searchTerm))
            {
                viewData();
                return;
            }

            searchResults = searchResults.Where(cli =>
                cli.Cname.Contains(searchTerm)
                || cli.CID.Contains(searchTerm)
            );

            var resultsList = searchResults
                .Select(cli => new
                {
                    cli.CID,
                    cli.Cname,
                    cli.Cmail,
                    cli.Cphone,
                    cli.Caddress,
                })
                .ToList();

            if (resultsList.Any())
            {
                dgvClient.DataSource = resultsList;
            }
            else
            {
                MessageBox.Show(
                    "No clients found.",
                    "Information",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
            }
        }

        private void btnCExport_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "CSV files (*.csv)|*.csv";
                saveFileDialog.Title = "Save as CSV File";
                saveFileDialog.FileName = "Clients_" + DateTime.Now.ToString("yyyyMMdd") + ".csv";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        using (StreamWriter writer = new StreamWriter(saveFileDialog.FileName))
                        {
                            // Write header
                            writer.WriteLine("ID,Name,Email,Phone Number,Address");

                            // Write data
                            foreach (DataGridViewRow row in dgvClient.Rows)
                            {
                                if (!row.IsNewRow) // Skip new row placeholder
                                {
                                    var clientData = new List<string>
                            {
                                row.Cells[0].Value.ToString(),
                                row.Cells[1].Value.ToString(),
                                row.Cells[2].Value.ToString(),
                                row.Cells[3].Value.ToString(),
                                row.Cells[4].Value.ToString()
                            };

                                    writer.WriteLine(string.Join(",", clientData));
                                }
                            }
                        }

                        MessageBox.Show("Exported successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error exporting data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}
