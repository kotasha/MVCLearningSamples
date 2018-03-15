using Kotacs.Libraries.SOA.Contracts.Data;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Entity;
using System.Linq;
using System.Text;

namespace Kotacs.Libraries.DAL.OrderSystem
{
    public class OrderSystemContext: DbContext 
    {
        private static string CONNECTION_STRING=
        ConfigurationManager.ConnectionStrings["ThomsonTrainingDB"].ConnectionString;
        public OrderSystemContext():base(CONNECTION_STRING)
        {

        }
        public DbSet<Customer>  Customers{get;set;}
        public DbSet<Order> Orders{get;set;}

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
            {
 	             base.OnModelCreating(modelBuilder);
                 modelBuilder.Configurations.Add<Customer>(new CustomerEntityTypeConfiguration());
            modelBuilder.Configurations.Add<Order>(new OrderEntityTypeConfiguration());

            }
        public void Insert(Customer c) 
        {
            this.Customers.Add(c);

        }


    }       
}
