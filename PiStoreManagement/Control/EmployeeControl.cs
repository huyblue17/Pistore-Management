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
    public partial class EmployeeControl : UserControl
    {
        private PiStoreEntities db = new PiStoreEntities();

        public EmployeeControl()
        {
            InitializeComponent();
            viewData();
            controlDefault();
            clearText();
            dtpHiredate.MinDate = new DateTime(2020, 1, 1);
        }

        private void viewData()
        {
            var employee = db.Employees.Select(emp => new
            {
                emp.EID,
                emp.Ename,
                emp.Email,
                emp.Ephone,
                emp.Eaddress,
                emp.Salary,
                emp.HireDate
            }).ToList();

            dgvEmployee.DataSource = employee;

            dgvEmployee.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dgvEmployee.Columns[0].HeaderText = "ID";
            dgvEmployee.Columns[1].HeaderText = "Name";
            dgvEmployee.Columns[2].HeaderText = "Email";
            dgvEmployee.Columns[3].HeaderText = "Phone number";
            dgvEmployee.Columns[4].HeaderText = "Address";
            dgvEmployee.Columns[5].HeaderText = "Salary";
            dgvEmployee.Columns[6].HeaderText = "Hire date";
        }

        private void controlDefault()
        {
            txtEID.Enabled = false;
            txtEname.Enabled = false;
            txtEmail.Enabled = false;
            txtEPhone.Enabled = false;
            txtEaddress.Enabled = false;
            txtSalary.Enabled = false;
            dtpHiredate.Enabled = false;
            
            btnESave.Enabled = false;
            btnEDelete.Enabled = false;
            btnEEdit.Enabled = false;
        }

        private void clearText()
        {
            txtEname.Clear();
            txtEmail.Clear();
            txtEPhone.Clear();
            txtEaddress.Clear();
            txtSalary.Clear();
            dtpHiredate.Refresh();
            txtSearch.Clear();
        }

        private bool checkField()
        {
            
            return !string.IsNullOrWhiteSpace(txtEname.Text)
                && !string.IsNullOrWhiteSpace(txtEmail.Text)
                && !string.IsNullOrWhiteSpace(txtEPhone.Text)
                && !string.IsNullOrWhiteSpace(txtSalary.Text)
                && !string.IsNullOrWhiteSpace(txtEaddress.Text)
                && dtpHiredate.Value != null;
        }

        private string idGenerator()
        {
            var employeeList = db.Employees
                .Where(emp => emp.EID.StartsWith("E") && emp.EID.Length > 1)
                .ToList();

            
            int maxIdNumber = employeeList
                .Select(emp => int.Parse(emp.EID.Substring(1))) 
                .DefaultIfEmpty(0) 
                .Max() + 1;

            
            string newId = $"E{maxIdNumber:D3}"; 

            return newId;
        }


        private bool checkMail()
        {
            string regex = @"[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?";

            if (Regex.IsMatch(txtEmail.Text.Trim(), regex))
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
            string regex = @"^\d{10}$";

            if (Regex.IsMatch(txtEPhone.Text.Trim(), regex))
            {
                return true;
            }
            else
            {
                MessageBox.Show("Invalid phone number.");
                return false;
            }
        }

        private bool checkSalary()
        {
            if (decimal.TryParse(txtSalary.Text, out _))
            {
                return true;
            }
            else
            {
                MessageBox.Show("Invalid salary.");
                return false;
            }
        }

        private bool checkHireDate()
        {
            if (dtpHiredate.Value <= DateTime.Today.AddDays(1))
            {
                return true;
            }
            else
            {
                MessageBox.Show("Hire date cannot be in the future.");
                return false;
            }
        }



        private void btnECancel_Click(object sender, EventArgs e)
        {
            controlDefault();
            clearText();
            viewData();
            txtEID.Clear();
        }

        private void btnEAdd_Click(object sender, EventArgs e)
        {
            txtEID.Text = idGenerator();

            txtEname.Enabled = true;
            txtEmail.Enabled = true;
            txtEPhone.Enabled = true;
            txtEaddress.Enabled = true;
            txtSalary.Enabled = true;
            dtpHiredate.Enabled = true;

            clearText();

            btnESave.Enabled = true;
            btnEDelete.Enabled = false;
            btnEEdit.Enabled = false;
        }

        private void btnESave_Click(object sender, EventArgs e)
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

            if (!checkSalary())
            {
                
                return; 
            }

            if (!checkHireDate())
            {
                return; 
            }

            var newEmp = new Employee()
            {
                EID = txtEID.Text,
                Ename = txtEname.Text,
                Email = txtEmail.Text,
                Eaddress = txtEaddress.Text,
                Ephone = int.Parse(txtEPhone.Text),
                Salary = decimal.Parse(txtSalary.Text),
                HireDate = dtpHiredate.Value
            };

            db.Employees.Add(newEmp);
            db.SaveChanges();

            MessageBox.Show("Save Successfully!", "Success Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            viewData();
            controlDefault();
            clearText();
            txtEID.Clear();
        }

        private void dgvEmployee_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtEID.Text = dgvEmployee.CurrentRow.Cells[0].Value.ToString();
            txtEname.Text = dgvEmployee.CurrentRow.Cells[1].Value.ToString();
            txtEmail.Text = dgvEmployee.CurrentRow.Cells[2].Value.ToString();
            txtEPhone.Text = dgvEmployee.CurrentRow.Cells[3].Value.ToString();
            txtEaddress.Text = dgvEmployee.CurrentRow.Cells[4].Value.ToString();
            txtSalary.Text = dgvEmployee.CurrentRow.Cells[5].Value.ToString();
            dtpHiredate.Text = dgvEmployee.CurrentRow.Cells[6].Value.ToString();

            btnEEdit.Enabled = true;
            btnEDelete.Enabled = true;

            txtEname.Enabled = true;
            txtEmail.Enabled = true;
            txtEPhone.Enabled = true;
            txtEaddress.Enabled = true;
            txtSalary.Enabled = true;
            dtpHiredate.Enabled = true;
        }

        private void btnEEdit_Click(object sender, EventArgs e)
        {
            var empToUpd = db.Employees.FirstOrDefault(emp => emp.EID == txtEID.Text);
            if (empToUpd != null)
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

                if (!checkSalary())
                {

                    return;
                }

                if (!checkHireDate())
                {
                    return;
                }


                empToUpd.Ename = txtEname.Text;
                empToUpd.Email = txtEmail.Text;
                empToUpd.Ephone = int.Parse(txtEPhone.Text);
                empToUpd.Eaddress = txtEaddress.Text;
                empToUpd.Salary = decimal.Parse(txtSalary.Text);
                empToUpd.HireDate = dtpHiredate.Value;

                db.SaveChanges();
                MessageBox.Show("Updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                viewData(); 
                controlDefault();
                clearText();
                txtEID.Clear();
            }
            else
            {
                MessageBox.Show("Employee not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEDelete_Click(object sender, EventArgs e)
        {
            var empToDel = db.Employees.FirstOrDefault(emp => emp.EID == txtEID.Text);

            if (empToDel != null)
            {
                db.Employees.Remove(empToDel); 
                db.SaveChanges(); 

                MessageBox.Show("Deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                viewData(); 
                controlDefault(); 
                clearText();
                txtEID.Clear();
            }
            else
            {
                MessageBox.Show("Employee not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnESearch_Click(object sender, EventArgs e)
        {
            string searchTerm = txtSearch.Text.Trim();

            var searchResults = db.Employees.AsQueryable();

            if (string.IsNullOrEmpty(searchTerm))
            {
                viewData();
                return;
            }

            searchResults = searchResults.Where(emp =>
                emp.Ename.Contains(searchTerm)
                || emp.EID.Contains(searchTerm)
            );

            var resultsList = searchResults
                .Select(emp => new
                {
                    emp.EID,
                    emp.Ename,
                    emp.Email,
                    emp.Ephone,
                    emp.Eaddress,
                    emp.Salary,
                    emp.HireDate
                })
                .ToList();

            if (resultsList.Any())
            {
                dgvEmployee.DataSource = resultsList;
            }
            else
            {
                MessageBox.Show(
                    "No employees found.",
                    "Information",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
            }
        }

        private void btnEExport_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                sfd.Filter = "CSV files (*.csv)|*.csv";
                sfd.Title = "Save an Employee File";
                sfd.FileName = "Employees.csv";

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    using (var writer = new StreamWriter(sfd.FileName))
                    {
                        // Write the header
                        writer.WriteLine("ID,Name,Email,Phone number,Address,Salary,Hire date");

                        // Write the data
                        foreach (DataGridViewRow row in dgvEmployee.Rows)
                        {
                            if (row.IsNewRow) continue; // Skip the new row placeholder
                            writer.WriteLine($"{row.Cells[0].Value}," +
                                             $"{row.Cells[1].Value}," +
                                             $"{row.Cells[2].Value}," +
                                             $"{row.Cells[3].Value}," +
                                             $"{row.Cells[4].Value}," +
                                             $"{row.Cells[5].Value}," +
                                             $"{row.Cells[6].Value}");
                        }
                    }

                    MessageBox.Show("Exported successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}
