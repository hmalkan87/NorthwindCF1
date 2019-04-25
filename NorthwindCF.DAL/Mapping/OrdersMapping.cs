using NorthwindCF.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthwindCF.DAL.Mapping
{
    public class OrdersMapping : EntityTypeConfiguration<Orders>
    {
        public OrdersMapping()
        {
            ToTable("Orders");
            HasKey(o => o.OrderID);
        }
    }
}
