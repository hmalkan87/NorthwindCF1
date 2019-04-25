using NorthwindCF.BLL;
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void btn_GetCustomers_Click(object sender, EventArgs e)
        {
            dgv_CustomersList.DataSource =  CustomerBLL.GetCustomers();
        }

        private void showOrdersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Orders frm = new frm_Orders();
            frm.customerID = dgv_CustomersList.SelectedRows[0].Cells["CustomerID"].Value.ToString();
            frm.ShowDialog();
        }

        private void dgv_CustomersList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_AddCustomer_Click(object sender, EventArgs e)
        {
            frm_AddCustomer frm = new frm_AddCustomer();
            frm.ShowDialog();
        }

        private void btn_OrderList_Click(object sender, EventArgs e)
        {
            frm_OrderList frm = new frm_OrderList();
            frm.ShowDialog();
        }
    }
}
