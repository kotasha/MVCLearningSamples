using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;

namespace Kotacs.Libraries.Web.Extensibility
{
    public class KotacsFilterProvider : IFilterProvider
    {
        public IEnumerable<Filter> GetFilters(ControllerContext controllerContext, ActionDescriptor actionDescriptor)
        {
            var validControllers = new string[] { "Redirect" };
            var validActions = new string[] { "Index" };

            var controllerName = actionDescriptor.ControllerDescriptor.ControllerName;
            var actionName = actionDescriptor.ActionName;

            if (validControllers.Contains(controllerName) && validActions.Contains(actionName))
            {
                var filter = new Filter(new KotacsLogActionFilterAttribute { LogFormat = @"{0}-{1}-{2}", Message = @"FILTER PROVIDER", LogToResponseBuffer = true }, FilterScope.Controller, 1);

                yield return filter;
            }


        }
    }
}
