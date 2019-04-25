using NorthwindCF.DAL;
using NorthwindCF.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthwindCF.BLL
{
    public static class OrderBLL
    {
        public static List<Orders> GetOrders(string customerID)
        {
            NorthwindDBContext dBContext = new NorthwindDBContext();
            return dBContext.Orders.Where(c => c.CustomerID == customerID).ToList();
        }

        public static List<Orders> GetOrderList(string searchText)
        {
            NorthwindDBContext dBContext = new NorthwindDBContext();
            return dBContext.Orders.Where(x => x.ShipName.Contains(searchText)).ToList();
        }
    }
}
