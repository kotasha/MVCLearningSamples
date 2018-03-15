using Kotacs.Libraries.SOA.Contracts.Data;
using Kotacs.Libraries.SOA.Contracts.Services;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.ServiceModel;
using System.Text;

namespace Kotacs.Libraries.SOA.Proxies
{
    public class OrderServiceProxy: IOrderService
    {
        private IOrderService orderServiceProxy= default(IOrderService);
        public OrderServiceProxy()
        {
            var orderserviceurl = ConfigurationManager.AppSettings["OrderServiceUrl"];
           this.orderServiceProxy = ChannelFactory<IOrderService>.CreateChannel(new BasicHttpBinding(BasicHttpSecurityMode.None), new EndpointAddress(orderserviceurl));
        }
        public IEnumerable<Order> GetAllOrders()
        {
            return this.orderServiceProxy.GetAllOrders();
        }
        public IEnumerable<Order> GetOrders(string customerid)
        {
            return this.orderServiceProxy.GetOrders(customerid);
        }

    }
}
