using System;
using System.Linq;
using System.Windows.Forms;

namespace PiStoreManagement
{
    public partial class Login : Form
    {
        private PiStoreEntities db = new PiStoreEntities();

        public Login()
        {
            InitializeComponent();

            txtPassword.PasswordChar = '*';

            // Subscribe to the KeyDown event
            txtUsername.KeyDown += TextBox_KeyDown;
            txtPassword.KeyDown += TextBox_KeyDown;
        }

        private void TextBox_KeyDown(object sender, KeyEventArgs e)
        {
            // Check if the Enter key is pressed
            if (e.KeyCode == Keys.Enter)
            {
                btnLogin.PerformClick(); // Simulate a click on the login button
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUsername.Text) || string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                MessageBox.Show("Please enter your account to log in", "Login error");
                return;
            }

            string user = txtUsername.Text;
            string pass = txtPassword.Text;

            var checkAccount = db.Accounts.FirstOrDefault(temp => temp.Uname == user);

            if (checkAccount != null)
            {
                if (checkAccount.Pword == pass)
                {
                    MessageBox.Show("Login successful", "Welcome", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    Main adminForm = new Main(checkAccount.Uname);
                    this.Hide();
                    adminForm.Show();
                }
                else
                {
                    MessageBox.Show("Incorrect password, try again.", "Login error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtPassword.Clear();
                    txtUsername.Clear();
                }
            }
            else
            {
                MessageBox.Show("Incorrect username, try again.", "Login error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPassword.Clear();
                txtUsername.Clear();
            }
        }

        private void chkShowpass_CheckedChanged(object sender, EventArgs e)
        {
            if (chkShowpass.Checked)
            {
                txtPassword.PasswordChar = '\0';
            }
            else
            {
                txtPassword.PasswordChar = '*';
            }
        }

        private void lblExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
