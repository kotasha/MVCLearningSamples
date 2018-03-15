using Kotacs.Libraries.SOA.Contracts.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Kotacs.Libraries.Business.Interfaces
{
    public interface IOrderBusinessService : IBusinessService
    {
        IEnumerable<Order> GetOrders(string customerId = default(string));
    }
}
