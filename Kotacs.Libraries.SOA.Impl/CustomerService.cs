using Kotacs.Libraries.Business.Factories;
using Kotacs.Libraries.Business.Interfaces;
using Kotacs.Libraries.SOA.Contracts.Data;
using Kotacs.Libraries.SOA.Contracts.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using Kotacs.Libraries.Common;
using Kotacs.Libraries.Common.Logging;
namespace Kotacs.Libraries.SOA.Impl
{
    [ServiceBehavior(Name=@"",Namespace=@"http://schemas.kotacs.com/behaviors")]
    public class CustomerService : BaseService, ICustomerService
    {
        private ICustomerBusinessService customerBusinessService = default(ICustomerBusinessService);
        

        public CustomerService()
        {
            this.customerBusinessService = BusinessServiceFactory.Create<ICustomerBusinessService>(BusinessType.Customers);
        }
        [OperationBehavior]
        public IEnumerable<Customer> GetAllCustomers()
        {
            Logger.Info(LogMessageResID.ServiceGetAllCustomersCalled, LogSource.Integration); 
            var customersList = default(IEnumerable<Customer>);
          try
            {
                customersList = customerBusinessService.GetCustomers(customerName: default(string));
            }
            catch (Exception exceptionObject)
            {
                exceptionObject.Log();

                throw exceptionObject.Transform(errorId: 1);
            }
            return customersList;
        }
        [OperationBehavior]
        public IEnumerable<Customer> GetCustomers(string customerName)
        {
            var customersList = default( IEnumerable<Customer>);
        try
            {
                customersList = customerBusinessService.GetCustomers(customerName);
            }
            catch (Exception exceptionObject)
            {
                exceptionObject.Log();

                throw exceptionObject.Transform(errorId: 1);
            }
            return customersList;
              
        }
        public void InsertCustomer(Customer customer)
        {
            try
            {
                customerBusinessService.InsertCustomer(customer);

            }
            catch (Exception exceptionObject)
            {
                exceptionObject.Log();

                throw exceptionObject.Transform(errorId: 1);
            }

        }


    }
}
