using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Practices.Unity;
using Microsoft.Practices.Unity.Configuration;
using System.Configuration;

namespace Kotacs.Libraries.Common
{
    public class UnityFactory : IDisposable
    {
        private static UnityFactory instance;
        private UnityContainer container = new UnityContainer();

        // Track whether Dispose has been called.
        private bool disposed = false;

        private UnityFactory()
        {
            container = new UnityContainer();
        }
        public static UnityFactory Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new UnityFactory();
                    instance.Configure();
                }
                return instance;
            }
        }
        public T Resolve<T>()
        {
            try
            {
                return container.Resolve<T>();
            }
            catch
            {
                throw;
            }
        }
        public T Resolve<T>(string name)
        {
            try
            {
                return container.Resolve<T>(name);
            }
            catch
            {
                throw;
            }
        }
        public UnityContainer GetContainer()
        {
            return container;
        }
        public void Configure()
        {
            UnityConfigurationSection section
              = (UnityConfigurationSection)ConfigurationManager.GetSection(GlobalConstants.UnityConfiguration);
            //section.Containers[GlobalConstants.UnityWebContainer].Configure(container);
        }

        #region IDisposable Members

        protected virtual void Dispose(bool disposing)
        {
            if (!disposed)
            {
                // Dispose of resources held by this instance (if any).

                // Set the sentinel.
                disposed = true;

                // Suppress finalization of this disposed instance.
                if (disposing)
                {
                    GC.SuppressFinalize(this);
                }
            }

        }

        public void Dispose()
        {
            Dispose(true);
        }

        #endregion
    }
}
