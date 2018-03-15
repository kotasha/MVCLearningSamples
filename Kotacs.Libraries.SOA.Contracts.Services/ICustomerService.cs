using Kotacs.Libraries.SOA.Contracts.Data;
using Kotacs.Libraries.SOA.Contracts.Faults;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;

namespace Kotacs.Libraries.SOA.Contracts.Services
{
    [ServiceContract(Name="ICustomerService",
        Namespace=@"http://schemas.kotacs.com/contracts")]
    public interface ICustomerService
    {
        [OperationContract]
        [FaultContract(typeof(ServiceError))]
        IEnumerable<Customer> GetAllCustomers();
        [OperationContract]
        [FaultContract(typeof(ServiceError))]
        IEnumerable<Customer> GetCustomers(string customerNamme);
        [OperationContract]
        [FaultContract(typeof(ServiceError))]
        void InsertCustomer(Customer customer);
    }
}
