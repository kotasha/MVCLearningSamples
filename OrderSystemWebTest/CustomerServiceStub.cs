using Kotacs.Libraries.SOA.Contracts.Data;
using Kotacs.Libraries.SOA.Contracts.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OrderSystemWebTest
{

public class CustomerServiceStub : ICustomerService
    {
        public IEnumerable<Customer> GetAllCustomers()
        {
            var customerList = new List<Customer> {new Customer{Customerid="C1",CustomerName="NorthWind",Address="Hyderabad",EmailId="info@nwt.com",PhoneNumber="040-67323661",ActiveStatus=true, CreditLimit=2300} };
            return customerList;
        }
    public IEnumerable<Customer> GetCustomers(string customerName)
    {
        var customerList = new List<Customer> { new Customer { Customerid = "C1", CustomerName = "NorthWind", Address = "Hyderabad", EmailId = "info@nwt.com", PhoneNumber = "040-67323661", ActiveStatus = true, CreditLimit = 2300 } };
        return customerList;
    }
    public void InsertCustomer(Customer customer)
    { 
    }

    }
}
