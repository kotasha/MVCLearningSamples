using Kotacs.Libraries.SOA.Contracts.Data;
using Kotacs.Libraries.SOA.Contracts.Services;
using Kotacs.Libraries.SOA.Proxies;
using Kotacs.Libraries.Web.Extensibility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Web;
using System.Web.Mvc;

namespace OrderSystemWeb.Controllers
{
    public class CustomerController : KotacsControllerBase
    {
        //
        // GET: /Customer/
        private ICustomerService customerservice= default(ICustomerService);
        public CustomerController(ICustomerService customerservice)
        {
            this.customerservice = customerservice;
            //customerservice = new CustomerServiceProxy();
        }
        public ActionResult Index()
        {
            if (customerservice != default(ICustomerService))
            {
                var customers = customerservice.GetAllCustomers();
                return View(model: customers);
            }
            return View(viewName: "Error");
        }
        [ActionName("Details")]
        public ActionResult GetCustomerDetails(string customerid)
        {
            if (customerservice != default(ICustomerService))
            {
                var customers = customerservice.GetAllCustomers();
                var filteredCustomer = customers.Where(customer => customer.Customerid.Equals(customerid)).FirstOrDefault();
                if (filteredCustomer != default(Customer))
                {
                    ViewBag.customerid = customerid;
                    return View(model: filteredCustomer);
                }

            }
            return View(viewName:"Error");
        }
        [ActionName("Search")]
        public ActionResult GetFilteredCustomers(string customerName)
        {
            if (customerservice != default(ICustomerService) &&
                !string.IsNullOrEmpty(customerName))
            {
                var filteredCustomers = customerservice.GetCustomers(customerName);

                return View(viewName: "Index", model: filteredCustomers);
            }

            return View(viewName: "Error");
        }
        [ActionName("New")]
        public ActionResult InitializeCustomer()
        {
            var customer = new Customer { Customerid = "C" + new Random().Next(2000000).ToString() };
            return View(model: customer);

        }

        //[ActionName("SaveCustomer")]
        [ActionName("New")]
        [HttpPost]
        public ActionResult SaveCustomer(
            ////[Bind(Prefix="Thomson")]// if we are maintain a same prefix of all controls in form
            //[ModelBinder(typeof(CustomerModelBinder))]
            Customer customer)
        {
            customerservice.InsertCustomer(customer);
            //return View(viewName: "SaveCustomer");

            if (customer.CustomerName.Length <= 5)
                ModelState.AddModelError("CustomerName", "Customer name is not valid");
            return View(model: customer);

        }
        public ActionResult AjaxIndex()
        {
            return View();
        }

        [ActionName("LoadCustomers")]
        public ActionResult GetCustomers()
        {
            if (customerservice != default(ICustomerService))
            {
                var customers = customerservice.GetAllCustomers();
                ViewData.Model = customers;
                if (Request.IsAjaxRequest())
                    return PartialView();
                return View();
            }
                return View(viewName: "Error");
        }

        public ActionResult CustomerDetails(string customerId)
        {
            if (customerservice != default(ICustomerService))
            {
                var customers = customerservice.GetAllCustomers();
                var filteredCustomer = customers.Where(customer => customer.Customerid.Equals(customerId)).FirstOrDefault();
                if (filteredCustomer != default(Customer))
                {
                    ViewData.Model = filteredCustomer;
                    Thread.Sleep(200);
                    if (Request.IsAjaxRequest())
                        return PartialView();

                    return View();
                }
            }
            return View(viewName: "Error");            
        }
        [ActionName("Stock")]
        public ActionResult GetCurrentStock(string customerId)
        {
            var data = string.Format(@"Customer {0} Stock Value {1}",
                customerId, new Random().Next(200));

            var scriptOutput = string.Format(
                "javascript:processResult('{0}')", data);

            return JavaScript(scriptOutput);
        }
        public ActionResult AllCustomers()
        {
            if (customerservice != default(ICustomerService))
            {
                var customers = customerservice.GetAllCustomers();
                return Json(customers, JsonRequestBehavior.AllowGet);
            }
            return View(viewName: "Error");
        }
    }
}
