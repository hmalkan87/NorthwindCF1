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
    public partial class frm_OrderList : Form
    {
        public frm_OrderList()
        {
            InitializeComponent();
        }

        private void frm_OrderList_Load(object sender, EventArgs e)
        {
            dgv_OrderList.DataSource =  OrderBLL.GetOrderList(txt_SearchOrder.Text);
        }

        private void txt_SearchOrder_TextChanged(object sender, EventArgs e)
        {
            dgv_OrderList.DataSource = OrderBLL.GetOrderList(txt_SearchOrder.Text);
        }
    }
}
