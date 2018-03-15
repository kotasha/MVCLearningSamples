using Kotacs.Libraries.Business.Interfaces;
using Kotacs.Libraries.SOA.Contracts.Data;
using Kotacs.Libraries.DAL.OrderSystem;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace Kotacs.Libraries.Business.Impl
{
    public class CustomerBusinessService : ICustomerBusinessService
    {
        public IEnumerable<Customer> GetCustomers(string customerName= default(string))
        {
            var customersList = default(IEnumerable<Customer>);
            try 
                {
                    using (var context = new Kotacs.Libraries.DAL.OrderSystem.OrderSystemContext())
                    {
                        if (string.IsNullOrEmpty(customerName))
                            customersList = context.Customers.ToList();
                        else
                        {
                            var procedureName = @"dbo.uspGetCustomers @customerName";
                            var parameter = new SqlParameter("@customerName", customerName);

                            customersList = context.Database.SqlQuery<Customer>(procedureName, parameter).ToList();
                        }
                    }
                }
            catch
            {
                throw;
            }

            return customersList;
        }
        public void InsertCustomer(Customer customer)
        {
            ////var context = new OrderSystemContext();
            //context.Customers.Add(customer);
            //context.SaveChanges();
        }
 
    }
}
