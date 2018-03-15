using Kotacs.Libraries.Business.Interfaces;
using Kotacs.Libraries.SOA.Contracts.Data;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using Kotacs.Libraries.DAL.OrderSystem;

namespace Kotacs.Libraries.Business.Impl
{
    public class OrderBusinessService : IOrderBusinessService
    {
        public IEnumerable<Order> GetOrders(string customerId = default(string))
        {
            var ordersList = default(IEnumerable<Order>);

            try
            {
                using (var context = new Kotacs.Libraries.DAL.OrderSystem.OrderSystemContext())
                {
                    if (string.IsNullOrEmpty(customerId))
                        ordersList = context.Orders.ToList();
                    else
                    {
                        var procedureName = @"dbo.uspGetOrders @customerId";
                        var parameter = new SqlParameter("@customerId", customerId);

                        ordersList = context.Database.SqlQuery<Order>(procedureName, parameter).ToList();
                    }
                }
            }
            catch { throw; }

            return ordersList;
        }

    }
}
