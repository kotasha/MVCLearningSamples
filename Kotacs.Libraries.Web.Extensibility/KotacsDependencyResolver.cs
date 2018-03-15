using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;

namespace Kotacs.Libraries.Web.Extensibility
{
    public class KotacsDependencyResolver : IDependencyResolver
    {
        public object GetService(Type serviceType)
        {
            var resolvedServiceObject = default(object);
            if(serviceType == typeof(IControllerActivator))
                resolvedServiceObject = new KotacsControllerActivator();
            return resolvedServiceObject;
        }
        public IEnumerable<object> GetServices(Type serviceType)
        {
            var resolvedServiceObjects = default(IEnumerable<object>);
            try
            {
                resolvedServiceObjects = ContainerManager.Current.ResolveAll(serviceType);
            }
            catch { }
            return resolvedServiceObjects;
        }
    }
}
