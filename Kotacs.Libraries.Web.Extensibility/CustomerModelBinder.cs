using Kotacs.Libraries.SOA.Contracts.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;

namespace Kotacs.Libraries.Web.Extensibility
{
   public class CustomerModelBinder :IModelBinder
    {
        public object BindModel(ControllerContext controllerContext, ModelBindingContext bindingContext) 
        {
            var modelObject = default(object);
            if(bindingContext.ModelType ==typeof(Customer))
            {
                var request = controllerContext.HttpContext.Request;
                var customerId = request["KotacsFormCustomerId"];
                var customerName = request["KotacsFormCustomerName"];
                var address = request["KotacsFormAddress"];
                var creditLimit =int.Parse(request["KotacsFormCreditLimit"]);
                var activestatus = bool.Parse(request["KotacsFormActiveStatus"]);
                var email = request["KotacsFormEmailId"];
                modelObject = new Customer { Customerid = customerId, CustomerName = customerName, Address = address, CreditLimit = creditLimit, ActiveStatus = activestatus, EmailId = email };
            }

            return modelObject;
        }
    }
}
