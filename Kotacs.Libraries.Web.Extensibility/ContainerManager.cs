using Microsoft.Practices.Unity;
using Microsoft.Practices.Unity.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Kotacs.Libraries.Web.Extensibility
{
    public class ContainerManager
    {
        private IUnityContainer container = default(IUnityContainer);
        public ContainerManager()
        {
            this.container = new UnityContainer().LoadConfiguration();
        }
        public object Resolve(Type resolverType)
        {
            return this.container.Resolve(resolverType);
        }
        public T Resolve<T>()
        {
            return this.container.Resolve<T>();
        }
        public IEnumerable<object> ResolveAll(Type serviceType)
        {
            return this.container.ResolveAll(serviceType);
        }
        #region Singleton Implementation
        private static ContainerManager containerManager = default(ContainerManager);
        static ContainerManager()
        {
            containerManager = new ContainerManager();
        }

        public static ContainerManager Current
        {
            get
            {
                return containerManager; 
            }
        }
        #endregion

    }
}
