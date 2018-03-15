using Kotacs.Libraries.SOA.Contracts.Data;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;

namespace Kotacs.Libraries.DAL.OrderSystem
{
    class OrderEntityTypeConfiguration: EntityTypeConfiguration<Order>
    {
        public OrderEntityTypeConfiguration()
        {
            this.HasKey(model=>model.OrderId);
            this.ToTable("Orders");

        }

    }
}
