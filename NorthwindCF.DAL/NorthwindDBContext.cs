using NorthwindCF.DAL.Mapping;
using NorthwindCF.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthwindCF.DAL
{
    public class NorthwindDBContext : DbContext
    {
        public NorthwindDBContext() : base("NorthwindDBContext")
        {
            Database.SetInitializer<NorthwindDBContext>(new CreateDatabaseIfNotExists<NorthwindDBContext>());
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new CustomerMapping());
            modelBuilder.Configurations.Add(new OrdersMapping());
        }

        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<Orders> Orders { get; set; }
    }
}
