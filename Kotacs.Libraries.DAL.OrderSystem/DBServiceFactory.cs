using System;
using Kotacs.Libraries.Common;
using Kotacs.Libraries.Common.Exceptions;
using Microsoft.Practices.Unity;
using Kotacs.Libraries.Common.Logging;
using System.Configuration;
using System.Data.SqlClient;
using System.Data.OracleClient;
using System.Data.Common;
namespace Kotacs.Libraries.DAL.OrderSystem
{
    public interface IDBServiceFactory
    {
        T Resolve<T>();
    }

    public class DBServiceFactory : IDBServiceFactory
    {
        [Dependency]
        public ILogger Logger { get; set; }

        [Dependency]
        public IExceptionHandler ExceptionHandler { get; set; }

        private IUnityContainer container;
        /// <summary>
        /// Constructor
        /// </summary>
        public DBServiceFactory()
        {
            try
            {
                UnityFactory unityFactory = UnityFactory.Instance;
                container = unityFactory.GetContainer();
                container.Configure<InjectedMembers>().ConfigureInjectionFor<DBService>(
                                 new InjectionConstructor(DataSource.ConnectionString, DataSource.ProviderFactory,
                                                new ResolvedParameter<ILogger>(), new ResolvedParameter<IExceptionHandler>()));

                //container.Configure<InjectedMembers>().ConfigureInjectionFor<DBService>("Oracle",
                //                 new InjectionConstructor(OracleDataSource.ConnectionString, OracleDataSource.ProviderFactory,
                //                                new ResolvedParameter<ILogger>(), new ResolvedParameter<IExceptionHandler>()));
            }
            catch (Exception ex)
            {
                Logger.Error(ErrorMessageResID.UnableToResolveService, ex);
            }
        }

        public T Resolve<T>()
        {
            return container.Resolve<T>();
        }

        public T Resolve<T>(string name)
        {
            return container.Resolve<T>(name);
        }

        /// <summary>
        /// Create a database service instance
        /// </summary>
        /// <param name="connnectionStringName">The connection string name as in configuration file</param>
        /// <returns>An DbService instance</returns>
        public static DBService CreateDbService(string connnectionStringName)
        {
            //Read connection string details from configuratino file
            string connectionString = ConfigurationManager.ConnectionStrings[connnectionStringName].ConnectionString;
            string providerName = ConfigurationManager.ConnectionStrings[connnectionStringName].ProviderName;

            //Create dependencies
            DbProviderFactory factory = DbProviderFactories.GetFactory(providerName);
            ILogger logger = UnityFactory.Instance.Resolve<ILogger>();
            IExceptionHandler exceptionHandler = UnityFactory.Instance.Resolve<IExceptionHandler>();

            //Create and return the database service instance
            return new DBService(connectionString, factory, logger, exceptionHandler);
        }
    }

    public static class DataSource
    {
        const string sapphireDBUserSection = "SapphireDBConnection";
        const string sapphireDBWebConfigSection = "ThomsonTrainingDB";

        const string sapphireControlDbWebConfitSection = "SapphireDB";
        const string sapphireStagingDbWebConfigSection = "SapphireStagingDB";
        const string sapphireProductionDbWebConfigSection = "SapphireProductionDB";
        const string sapphirePreProductionDbWebConfigSection = "SapphirePreProductionDB";

        /// <summary>
        /// Connection String Name for Data Migration Conroll Db
        /// </summary>
        public static string ControlDbConnectionStringName
        {
            get { return sapphireControlDbWebConfitSection; }
        }

        /// <summary>
        /// Connection String Name for Data Migration Conroll Db
        /// </summary>
        public static string StagingDbConnectionStringName
        {
            get { return sapphireStagingDbWebConfigSection; }
        }

        /// <summary>
        /// Connection String Name for Data Migration Conroll Db
        /// </summary>
        public static string ProductionDbConnectionStringName
        {
            get { return sapphireProductionDbWebConfigSection; }
        }

        /// <summary>
        /// Connection String Name for pre production Database
        /// </summary>
        public static string PreProductionDbConnectionStringName
        {
            get { return sapphirePreProductionDbWebConfigSection; }
        }

        public static string SapphireDbConnectionStringName
        {
            get { return SapphireDBWebConfigSection; }
        }

        private static string connectionString;

        public static string ConnectionString
        {
            get { return connectionString; }
            set { connectionString = value; }
        }

        private static DbProviderFactory providerFactory;
        /// <summary>
        /// ProviderFactory of DbserviceFactory
        /// </summary>
        public static DbProviderFactory ProviderFactory
        {
            get { return providerFactory; }
            set { providerFactory = value; }
        }

        public static string SapphireDBWebConfigSection
        {
            get { return sapphireDBWebConfigSection; }
        }

        static DataSource()
        {
            try
            {
                //
                // First check to see if a connection string is defined in the app settings section
                //

                if (ConfigurationManager.AppSettings[sapphireDBUserSection] != null &&
                        !string.IsNullOrEmpty(ConfigurationManager.AppSettings[sapphireDBUserSection].ToString()))
                {
                    ConnectionString = ConfigurationManager.AppSettings[sapphireDBUserSection].ToString();
                }
                else
                {
                    ConnectionString = ConfigurationManager.ConnectionStrings[sapphireDBWebConfigSection].ConnectionString;
                }

                ProviderFactory = SqlClientFactory.Instance;

            }
            catch (Exception exp)
            {
                LogManager.GetLogger().Error(ErrorMessageResID.UnableToDBService, exp);
            }
        }

    }

    public static class OracleDataSource
    {
        const string cuasDBUserSection = "CuasDBConnection";
        const string cuasDBWebConfigSection = "CuasDB";

        private static string connectionString;
        public static string ConnectionString
        {
            get { return connectionString; }
            set { connectionString = value; }
        }

        private static DbProviderFactory providerFactory;

        public static DbProviderFactory ProviderFactory
        {
            get { return providerFactory; }
            set { providerFactory = value; }
        }

        static OracleDataSource()
        {
            try
            {
                //
                // First check to see if a connection string is defined in the app settings section
                //

                if (ConfigurationManager.AppSettings[cuasDBUserSection] != null &&
                        !string.IsNullOrEmpty(ConfigurationManager.AppSettings[cuasDBUserSection].ToString()))
                {
                    ConnectionString = ConfigurationManager.AppSettings[cuasDBUserSection].ToString();
                }
                else
                {
                    ConnectionString = ConfigurationManager.ConnectionStrings[cuasDBWebConfigSection].ConnectionString;
                }

                //ProviderFactory = OracleClientFactory.Instance;

            }
            catch (Exception exp)
            {
                LogManager.GetLogger().Error(ErrorMessageResID.UnableToDBService, exp);
            }
        }
    }
}
