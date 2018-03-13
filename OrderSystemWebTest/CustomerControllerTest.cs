using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OrderSystemWeb.Controllers;
using System.Web.Mvc;
using System.Collections.Generic;
using Kotacs.Libraries.SOA.Contracts.Data;
using System.Linq;
using Moq;
using Kotacs.Libraries.SOA.Contracts.Services;
namespace OrderSystemWebTest
{
    [TestClass]
    public class CustomerControllerTest
    {
        [TestMethod]
        public void ValidIndexText()
        {
            var customerServiceStub = new CustomerServiceStub();
            var customerController = new CustomerController(customerServiceStub);
            var result = customerController.Index() as ViewResult;
            var viewName = string.Empty;
            var model = result.ViewData.Model as IEnumerable<Customer>;

            var customer = model.First();

            Assert.IsNotNull(result,"Expected View Result Not Valid");
            Assert.AreEqual<string>(viewName,result.ViewName,"Expected View Name is not valid");
            Assert.AreEqual<int>(expected:1,actual: model.Count(),message:"Invalid number of Customers");
            Assert.AreEqual<string>("C1",customer.Customerid,"Expected Customer Id not Found");
        
        }
        [TestMethod]
        public void ValidIndexTestWithMocking() 
        {
            var mockRepository = new MockRepository(MockBehavior.Default);
            var customerServiceMock = mockRepository.Create<ICustomerService>();
            customerServiceMock.Setup(service => service.GetAllCustomers()).Returns(new List<Customer> { new Customer { Customerid = "C1", CustomerName = "NorthWind", Address = "Hyderabad", EmailId = "info@nwt.com", PhoneNumber = "040-67323661", ActiveStatus = true, CreditLimit = 2300 } });
            
            var customerservice = customerServiceMock.Object;
            var customerController = new CustomerController(customerservice);
            var result = customerController.Index() as ViewResult;
            var viewName = string.Empty;
            var model = result.ViewData.Model as IEnumerable<Customer>;
            var customer = model.First();

            Assert.IsNotNull(result, "Expected View Result Not Valid");
            Assert.AreEqual<string>(viewName, result.ViewName, "Expected View Name is not valid");
            Assert.AreEqual<int>(expected: 1, actual: model.Count(), message: "Invalid number of Customers");
            Assert.AreEqual<string>("C1", customer.Customerid, "Expected Customer Id not Found");
        

        }
    }
}
