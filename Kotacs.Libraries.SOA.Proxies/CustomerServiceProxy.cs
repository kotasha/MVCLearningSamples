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
    public class CustomerServiceProxy:ICustomerService
    {
        private ICustomerService customerServiceProxy = default(ICustomerService);
        public CustomerServiceProxy()
        {
            var customerServiceUrl= ConfigurationManager.AppSettings["CustomerServiceUrl"];
            this.customerServiceProxy = ChannelFactory<ICustomerService>.CreateChannel(new BasicHttpBinding(BasicHttpSecurityMode.None), new EndpointAddress(customerServiceUrl));
        }
        public IEnumerable<Customer> GetAllCustomers()
        {
            return this.customerServiceProxy.GetAllCustomers();
        }
        public IEnumerable<Customer> GetCustomers(string customerName)
        {
            return this.customerServiceProxy.GetCustomers(customerName);
        }
        public void InsertCustomer(Customer customer)
        {
             this.customerServiceProxy.InsertCustomer(customer);
        }

    }
}
