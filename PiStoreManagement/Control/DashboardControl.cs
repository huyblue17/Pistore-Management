using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Core.Metadata.Edm;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PiStoreManagement.Control;

namespace PiStoreManagement
{
    public partial class DashboardControl : UserControl
    {
        PiStoreEntities db = new PiStoreEntities();

        public DashboardControl()
        {
            InitializeComponent();
            countEmployee();
            countClient();
            countBill();
            countProduct();

        }

        private void countEmployee()
        {
            int countEmp = db.Employees.Count();
            lblEmployee.Text = countEmp.ToString();
        }

        private void countClient()
        {
            int countCli = db.Clients.Count();
            lblClient.Text = countCli.ToString();
        }

        private void countProduct()
        {
            int countPro = db.Products.Count();
            lblProduct.Text = countPro.ToString();
        }

        private void countBill()
        {
            int countBill = db.Bills.Count();
            lblBill.Text = countBill.ToString();
        }

        

    }
}
