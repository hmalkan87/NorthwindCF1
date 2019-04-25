using NorthwindCF.DAL;
using NorthwindCF.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthwindCF.BLL
{
    public static class CustomerBLL
    {
        public static List<Customer> GetCustomers()
        {
            NorthwindDBContext dBContext = new NorthwindDBContext();
            return dBContext.Customers.ToList();
        }

        public static int AddCustomer(Customer customer)
        {
            NorthwindDBContext dBContext = new NorthwindDBContext();

            dBContext.Customers.Add(customer);
            return dBContext.SaveChanges();
        }
    }
}
