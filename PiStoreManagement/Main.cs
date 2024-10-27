using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PiStoreManagement.Control;

namespace PiStoreManagement
{
    public partial class Main : Form
    { 
        private PiStoreEntities db = new PiStoreEntities();
        private string logInName;
        private Button currentActiveBtn;
        private bool isChartDisplayed = false;

        public Main(string username)
        {
            InitializeComponent();
            logInName = username;
            lblName.Text = logInName;
            DashboardControl dashboard = new DashboardControl();
            panelFill(dashboard);

            resetColor(currentActiveBtn);
            changeColor(btnDashboard);
            currentActiveBtn = btnDashboard;

            NextButton.Visible = true;
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            Login loginForm = new Login();
            this.Hide();
            loginForm.Show();
        }

        private void panelFill(UserControl ctrl)
        {
            controller.Controls.Clear();

            ctrl.Dock = DockStyle.Fill;
            controller.Controls.Add(ctrl);
        }

        private void resetColor(Button btn)
        {
            if (btn != null)
            {
                btn.BackColor = Color.FromArgb(124, 147, 195);
            }
            return;
        }

        private void changeColor(Button btn)
        {
            btn.BackColor = Color.FromArgb(30, 42, 94);
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            resetColor(currentActiveBtn);
            changeColor(btnDashboard);
            currentActiveBtn = btnDashboard;

            DashboardControl dashboard = new DashboardControl();
            panelFill(dashboard);

            NextButton.Visible = true;
        }

        private void btnEmployee_Click(object sender, EventArgs e)
        {
            resetColor(currentActiveBtn);
            changeColor(btnEmployee);
            currentActiveBtn = btnEmployee;
            
            EmployeeControl employee = new EmployeeControl();
            panelFill(employee);

            NextButton.Visible = false;
        }

        private void btnClient_Click(object sender, EventArgs e)
        {
            resetColor(currentActiveBtn);
            changeColor(btnClient);
            currentActiveBtn = btnClient;

            ClientControl client = new ClientControl();
            panelFill(client);

            NextButton.Visible = false;
        }

        private void btnProduct_Click(object sender, EventArgs e)
        {
            resetColor(currentActiveBtn);
            changeColor(btnProduct);
            currentActiveBtn = btnProduct;

            ProductControl product = new ProductControl();
            panelFill(product);

            NextButton.Visible = false;
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            resetColor(currentActiveBtn);
            changeColor(btnOrder);
            currentActiveBtn = btnOrder;

            OrderControl order = new OrderControl();
            panelFill(order);

            NextButton.Visible = false;
        }

        private void btnManageOrder_Click(object sender, EventArgs e)
        {
            resetColor(currentActiveBtn);
            changeColor(btnManageOrder);
            currentActiveBtn = btnManageOrder;

            ItemControl item = new ItemControl();
            panelFill(item);

            NextButton.Visible = false;
        }

        private void btnBill_Click(object sender, EventArgs e)
        {
            resetColor(currentActiveBtn);
            changeColor(btnBill);
            currentActiveBtn = btnBill;

            BillControl bill = new BillControl();
            panelFill(bill);
        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            if (isChartDisplayed)
            {
                // If ChartControl is displayed, go back to DashboardControl
                DashboardControl dashboard = new DashboardControl();
                panelFill(dashboard);
                isChartDisplayed = false;
            }
            else
            {
                // If DashboardControl is displayed, switch to ChartControl
                ChartControl chart = new ChartControl();
                panelFill(chart);
                isChartDisplayed = true;
            }
        }

        private void lblExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
