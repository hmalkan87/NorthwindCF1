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
    public partial class frm_Orders : Form
    {
        public frm_Orders()
        {
            InitializeComponent();
        }
        public string customerID;
        private void frm_Orders_Load(object sender, EventArgs e)
        {
            dgv_OrderList.DataSource = OrderBLL.GetOrders(customerID);
        }
    }
}
