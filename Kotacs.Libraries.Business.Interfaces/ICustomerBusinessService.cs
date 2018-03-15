using Kotacs.Libraries.SOA.Contracts.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Kotacs.Libraries.Business.Interfaces
{
    public interface ICustomerBusinessService: IBusinessService
    {
        IEnumerable<Customer> GetCustomers(string customerName = default(string));
        void InsertCustomer(Customer customer);
    }
}
