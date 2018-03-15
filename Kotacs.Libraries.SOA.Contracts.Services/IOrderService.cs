using Kotacs.Libraries.SOA.Contracts.Data;
using Kotacs.Libraries.SOA.Contracts.Faults;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;

namespace Kotacs.Libraries.SOA.Contracts.Services
{
    [ServiceContract(Name=@"IOrderService",Namespace=@"http://schemas.kotacs.com/contracts")]
    public interface IOrderService
    {
        [OperationContract]
        [FaultContract(typeof(ServiceError))]
        IEnumerable<Order> GetAllOrders();
        [OperationContract]
        [FaultContract(typeof(ServiceError))]
        IEnumerable<Order> GetOrders(string customerid);
        //[OperationContract]
        //[FaultContract(typeof(ServiceError))]
        //void InsertCustomer(Customer customer);

    }
}
