using Kotacs.Libraries.Business.Factories;
using Kotacs.Libraries.Business.Interfaces;
using Kotacs.Libraries.SOA.Contracts.Data;
using Kotacs.Libraries.SOA.Contracts.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;

namespace Kotacs.Libraries.SOA.Impl
{
    [ServiceBehavior(Name=@"OrderService", Namespace=@"http://schemas.kotacs.com/behaviors")]
    public class OrderService: IOrderService
    {
        private IOrderBusinessService orderBusinessService= default(IOrderBusinessService);
        public OrderService()
        {
            this.orderBusinessService= BusinessServiceFactory.Create<IOrderBusinessService>(BusinessType.Orders);
        }
        [OperationBehavior]
        public IEnumerable<Order> GetAllOrders()
        {
            var orderList = default(IEnumerable<Order>);
            try
            {
                orderList = orderBusinessService.GetOrders(customerId: default(string));
            }
            catch (Exception exceptionobject)
            {
                exceptionobject.Log();
                exceptionobject.Transform(errorId: 3);
            }
            return orderList;
        }
        [OperationBehavior]
        public IEnumerable<Order> GetOrders(string customerId)
        {
            var orderList = default(IEnumerable<Order>);
            try
            {
                orderList = orderBusinessService.GetOrders(customerId);
            }
            catch (Exception exceptionobject)
            {
                exceptionobject.Log();
                exceptionobject.Transform(errorId: 3);
            }
            return orderList;
        }



    }
}
