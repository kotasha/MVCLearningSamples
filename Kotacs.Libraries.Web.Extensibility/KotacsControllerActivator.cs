using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;
using System.Web.Routing;
using System.Web;
using System.Diagnostics;
namespace Kotacs.Libraries.Web.Extensibility
{
    class KotacsControllerActivator : IControllerActivator
    {
        public IController Create(RequestContext requestContext, Type controllerType)
        {
            var controllerObject = default(IController);
            try 
            {
                controllerObject = ContainerManager.Current.Resolve(controllerType) as IController;

            }
            catch(Exception exceptionObject)
            {
                EventLog.WriteEntry("Application","Error (Creating Controllers): "+exceptionObject.Message,EventLogEntryType.Error);
            }
            return controllerObject;
        }
    }
}
