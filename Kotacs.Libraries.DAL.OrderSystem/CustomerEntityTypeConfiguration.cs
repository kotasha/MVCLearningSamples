using Kotacs.Libraries.SOA.Contracts.Data;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;

namespace Kotacs.Libraries.DAL.OrderSystem
{
    class CustomerEntityTypeConfiguration : EntityTypeConfiguration<Customer>
    {
        public CustomerEntityTypeConfiguration()
        {
            this.HasKey(model=>model.Customerid);
            this.ToTable("Customers");
        }


    }
}
