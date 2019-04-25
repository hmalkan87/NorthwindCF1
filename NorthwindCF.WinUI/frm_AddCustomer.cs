using NorthwindCF.BLL;
using NorthwindCF.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NorthwindCF.WinUI
{
    public partial class frm_AddCustomer : Form
    {
        public frm_AddCustomer()
        {
            InitializeComponent();
        }

        private void btn_AddCustomer_Click(object sender, EventArgs e)
        {
            string company = txt_CompanyName.Text;
            string CustomerID = company.Substring(0, 5).ToUpper();

            Customer customer = new Customer
            {
                CustomerID = CustomerID,
                CompanyName = txt_CompanyName.Text,
                ContactName = txt_ContactName.Text,
                ContactTitle = txt_ContactTitle.Text,
                Country = txt_Country.Text,
                Phone = txt_Phone.Text
            };

            int eklendiMi = CustomerBLL.AddCustomer(customer);

            if (eklendiMi > 0)
            {
                MessageBox.Show("Success!");
            }
            else
            {
                MessageBox.Show("Failed!");
            }
        }
    }
}
