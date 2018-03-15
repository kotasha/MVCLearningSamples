using Kotacs.Libraries.Business.Impl;
using Kotacs.Libraries.Business.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Kotacs.Libraries.Business.Factories
{
    public class BusinessServiceFactory
    {

        public static T Create<T>(BusinessType businessType)
            where T : IBusinessService
        {
            var businessService= default(IBusinessService);
            switch(businessType)
            {
                case BusinessType.Customers:
                    businessService = new CustomerBusinessService();
                    break;
                case BusinessType.Orders:
                    businessService = new OrderBusinessService();
                    break;
                default:
                    throw new ArgumentException("Invalid business service type");
            }
            return (T)businessService;
        }
    }
}
