using Kotacs.Libraries.SOA.Proxies;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ServiceProxyTesting
{
    class Program
    {
        static void Main(string[] args)
        {
            var customerServiceProxy = new CustomerServiceProxy();
            var filteredCustomers = customerServiceProxy.GetCustomers("wind");
            foreach (var customer in filteredCustomers)
                Console.WriteLine(customer.ToString());
            Console.WriteLine();
            var orderServiceProxy = new OrderServiceProxy();
            var filteredOrders = orderServiceProxy.GetOrders("C100011");
            foreach (var order in filteredOrders)
                Console.WriteLine(order.ToString());
            Console.WriteLine();
            Console.WriteLine("End of App!");
            Console.ReadLine();
        }
    }
}
