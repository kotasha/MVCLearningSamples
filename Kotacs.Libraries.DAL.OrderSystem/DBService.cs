using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Practices.EnterpriseLibrary.Data;
using Microsoft.Practices.EnterpriseLibrary.Data.Sql;
using Microsoft.Practices.Unity;
using System.Data.Common;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Diagnostics;
using System.Globalization;
using Kotacs.Libraries.Common.Exceptions;
using Kotacs.Libraries.Common;
using Kotacs.Libraries.Common.Logging;
using Kotacs.Libraries.DAL.OrderSystem.Wrappers.Databases;
namespace Kotacs.Libraries.DAL.OrderSystem
{
    public class DBService : Database
    {
        /// 
        private ILogger Logger;
        private IExceptionHandler ExceptionHandler;
        private static TimeSpan totalTime = new TimeSpan(0);
        private static int totalStatements = 0;
        private static PerformanceCounter counterTotalStatements = null;
        private static PerformanceCounter counterTotalTime = null;
        private CplDatabase cplDatabase;

        /// <summary>
        /// Constructor of DBservice
        /// </summary>
        /// <param name="connectionString">string</param>
        /// <param name="providerFactory">DbProviderFactory</param>
        /// <param name="logger">ILogger</param>
        /// <param name="exceptionHandler">IExceptionHandler</param>
        public DBService(string connectionString, DbProviderFactory providerFactory, Kotacs.Libraries.Common.Logging.ILogger logger, IExceptionHandler exceptionHandler)
            : base(connectionString, providerFactory)
        {
            this.Logger = logger;
            this.ExceptionHandler = exceptionHandler;
            this.cplDatabase = new CplDatabase();
            //CreatePerformanceCounters();
        }

        /// <summary>
        /// TotalTime of DBservice
        /// </summary>
        public static TimeSpan TotalTime
        {
            get { return totalTime; }
            set
            {
                totalTime = value;
                if (counterTotalTime != null) counterTotalTime.RawValue = value.Milliseconds;
            }
        }

        /// <summary>
        /// TotalStatements of Dbservice
        /// </summary>
        public static int TotalStatements
        {
            get { return totalStatements; }
            set
            {
                totalStatements = value;
                if (counterTotalStatements != null) counterTotalStatements.RawValue = value;
            }
        }
        /// <summary>
        /// Cpl of DBsevice
        /// </summary>
        public CplDatabase Cpl
        {
            get { return cplDatabase; }
        }
        /// <summary>
        /// method override  of DeriveParameters
        /// </summary>
        /// <param name="discoveryCommand"></param>
        protected override void DeriveParameters(System.Data.Common.DbCommand discoveryCommand)
        {
        }
        protected DbConnection OpenConnection()
        {
            throw new NotSupportedException();
        }
        /// <summary>
        /// ExecuteDataSet method
        /// </summary>
        /// <param name="queryBuilders">QueryBuilders</param>
        /// <returns>null</returns>
        public DataSet ExecuteDataSet(QueryBuilders queryBuilders)
        {
            Logger.Info(LogMessageResID.DBServiceExecuteDataSet);
            try
            {
                DateTime BatchStartTime = DateTime.Now;
                DataSet dsCollection = new DataSet(queryBuilders.Name);
                dsCollection.Locale = CultureInfo.InvariantCulture;
                DbCommand dbCommand = null;
                string sqlQuery = string.Empty;
                foreach (QueryBuilder queryBuilder in queryBuilders.GetQueryBuilders())
                {
                    sqlQuery = queryBuilder.ToSQL();
                    if (queryBuilder.IsStoredProcedure)
                    {
                        dbCommand = GetStoredProcCommand(sqlQuery);
                    }
                    else
                    {
                        dbCommand = GetSqlStringCommand(sqlQuery);
                    }
                    dbCommand.CommandTimeout = GlobalConstants.DBCommandTimeout;
                    AssignParameters(queryBuilder, dbCommand);

                    LoadDataSet(dbCommand, dsCollection, queryBuilder.Name);
                    LogSQL(queryBuilder.Name, sqlQuery);

                    //loop to get values of out parameters
                    foreach (KeyValuePair<string, ParameterItem> parameter in queryBuilder.Parameters)
                    {
                        if (parameter.Value.IsOutParameter)
                            queryBuilder.SetOutParameterValue(parameter.Value.Name, GetParameterValue(dbCommand, parameter.Value.Name));
                    }

                }
                LogDataSetXML(queryBuilders.Name, dsCollection);
                TimeSpan BatchTime = DateTime.Now - BatchStartTime;
                UpdatePerformanceCounter(queryBuilders.Count, BatchTime, BatchStartTime);
                return dsCollection;
            }
            catch (Exception exp)
            {
                Logger.Error(ErrorMessageResID.DBServiceExecuteDataSetFailed, exp);
                bool rethrow = ExceptionHandler.HandleDataExcception(exp);
                if (rethrow)
                    throw;
            }
            return null;
        }
        /// <summary>
        /// ExecuteDataSet
        /// </summary>
        /// <param name="queryBuilder"></param>
        /// <returns>ExecuteDataSet</returns>
        public DataSet ExecuteDataSet(QueryBuilder queryBuilder)
        {
            QueryBuilders queryBuilders = new QueryBuilders(DataConstants.NewDataSet);
            queryBuilders.AddSQL(queryBuilder);
            return ExecuteDataSet(queryBuilders);
        }
        public DataSet ExecuteDataSet(QueryBuilder queryBuilder, string dataSetName)
        {
            QueryBuilders queryBuilders = new QueryBuilders(dataSetName);
            queryBuilders.AddSQL(queryBuilder);
            return ExecuteDataSet(queryBuilders);
        }
        /// <summary>
        /// ExecuteNonQuery method
        /// </summary>
        /// <param name="queryBuilder">QueryBuilder</param>
        /// <returns>0</returns>
        public int ExecuteNonQuery(QueryBuilder queryBuilder)
        {
            Logger.Info(LogMessageResID.DBServiceExecuteNonQuery);
            try
            {
                DateTime BatchStartTime = DateTime.Now;
                string sqlQuery = queryBuilder.ToSQL();
                LogSQL(queryBuilder.Name, sqlQuery);
                DbCommand dbCommand;

                if (queryBuilder.IsStoredProcedure)
                {
                    dbCommand = GetStoredProcCommand(sqlQuery);
                }
                else
                {
                    dbCommand = GetSqlStringCommand(sqlQuery);
                }
                dbCommand.CommandTimeout = GlobalConstants.DBCommandTimeout;
                AssignParameters(queryBuilder, dbCommand);

                int status = ExecuteNonQuery(dbCommand);

                //loop to get values of out parameters
                foreach (KeyValuePair<string, ParameterItem> parameter in queryBuilder.Parameters)
                {
                    if (parameter.Value.IsOutParameter)
                        queryBuilder.SetOutParameterValue(parameter.Value.Name, GetParameterValue(dbCommand, parameter.Value.Name));
                }
                TimeSpan BatchTime = DateTime.Now - BatchStartTime;
                UpdatePerformanceCounter(1, BatchTime, BatchStartTime);
                return status;
            }
            catch (Exception exp)
            {
                Logger.Error(ErrorMessageResID.DBServiceExecuteNonQueryFailed, exp);
                bool rethrow = ExceptionHandler.HandleDataExcception(exp);
                if (rethrow)
                    throw;
            }
            return 0;
        }

        /// <summary>
        /// Use to Execute Multiple Database operations with Transactions
        /// </summary>
        /// <param name="queryBuilders"></param>
        /// <param name="Name"></param>
        /// <returns></returns>
        public int ExecuteNonQuery(QueryBuilders queryBuilders)
        {
            Logger.Info(LogMessageResID.DBServiceExecuteNonQuery);

            DbConnection dbConnection = null;
            DbTransaction dbTransaction = null;


            try
            {
                //open the connection
                using (dbConnection = this.CreateConnection())
                {
                    dbConnection.Open();
                    //Create the database transaction
                    dbTransaction = dbConnection.BeginTransaction();

                    foreach (QueryBuilder queryBuilder in queryBuilders.GetQueryBuilders())
                    {

                        string sqlQuery = queryBuilder.ToSQL();

                        LogSQL(queryBuilder.Name, sqlQuery);
                        DateTime BatchStartTime = DateTime.Now;
                        DbCommand dbCommand;

                        if (queryBuilder.IsStoredProcedure)
                        {
                            dbCommand = GetStoredProcCommand(sqlQuery);
                        }
                        else
                        {
                            dbCommand = GetSqlStringCommand(sqlQuery);
                        }
                        dbCommand.CommandTimeout = GlobalConstants.DBCommandTimeout;
                        AssignParameters(queryBuilder, dbCommand);

                        //Execute the query
                        int status = ExecuteNonQuery(dbCommand, dbTransaction);

                        //loop to get values of out parameters
                        foreach (KeyValuePair<string, ParameterItem> parameter in queryBuilder.Parameters)
                        {
                            if (parameter.Value.IsOutParameter)
                                queryBuilder.SetOutParameterValue(parameter.Value.Name, GetParameterValue(dbCommand, parameter.Value.Name));
                        }

                        TimeSpan BatchTime = DateTime.Now - BatchStartTime;
                        UpdatePerformanceCounter(1, BatchTime, BatchStartTime);
                    }

                    //commit the transaction started
                    dbTransaction.Commit();

                }
            }
            catch (Exception exp)
            {
                //Roll back the transaction
                if (dbConnection.State == ConnectionState.Open)
                    dbTransaction.Rollback();

                Logger.Error(ErrorMessageResID.DBServiceExecuteNonQueryFailed, exp);
                bool rethrow = ExceptionHandler.HandleDataExcception(exp);
                if (rethrow)
                    throw;
            }
            return 0;
        }

        /// <summary>
        /// This Method is used to execute a query and return 
        /// the identity column value back
        /// </summary>
        /// <param name="queryBuilder"></param>
        /// <returns></returns>
        public int ExecuteScalar(QueryBuilder queryBuilder)
        {
            Logger.Info(LogMessageResID.DBServiceExecuteScalar);

            try
            {
                DateTime BatchStartTime = DateTime.Now;
                string sqlQuery = queryBuilder.ToSQL();
                LogSQL(queryBuilder.Name, sqlQuery);

                DbCommand dbCommand;
                if (queryBuilder.IsStoredProcedure)
                    dbCommand = GetStoredProcCommand(sqlQuery);
                else
                    dbCommand = GetSqlStringCommand(sqlQuery);

                dbCommand.CommandTimeout = GlobalConstants.DBCommandTimeout;
                AssignParameters(queryBuilder, dbCommand);

                int status = Convert.ToInt32(ExecuteScalar(dbCommand), CultureInfo.InvariantCulture);

                //loop to get values of out parameters
                foreach (KeyValuePair<string, ParameterItem> parameter in queryBuilder.Parameters)
                {
                    if (parameter.Value.IsOutParameter)
                        queryBuilder.SetOutParameterValue(parameter.Value.Name, GetParameterValue(dbCommand, parameter.Value.Name));
                }

                TimeSpan BatchTime = DateTime.Now - BatchStartTime;
                UpdatePerformanceCounter(1, BatchTime, BatchStartTime);
                return status;
            }
            catch (Exception exp)
            {
                Logger.Error(ErrorMessageResID.DBServiceExecuteNonQueryFailed, exp);
                bool rethrow = ExceptionHandler.HandleDataExcception(exp);
                if (rethrow)
                    throw;
            }
            return 0;
        }

        private void AssignParameters(QueryBuilder queryBuilder, DbCommand dbCommand)
        {
            //loop and add any parameters found
            foreach (KeyValuePair<string, ParameterItem> parameter in queryBuilder.Parameters)
            {
                if (parameter.Value.IsOutParameter)
                {
                    //Add out parameters
                    if (parameter.Value is SqlServerParameterItem)
                    {
                        //If this is an SQL Server Specific Type
                        SqlCommand command = (SqlCommand)dbCommand;
                        command.Parameters.Add(new SqlParameter(parameter.Value.Name, parameter.Value.Value) { Direction = ParameterDirection.Output });
                    }
                    else
                    {
                        //IF ths is a general db typ
                        AddOutParameter(dbCommand, parameter.Value.Name, parameter.Value.SqlType, parameter.Value.OutputSize);
                    }
                }
                else
                {
                    //Add In paramters
                    if (parameter.Value is SqlServerParameterItem)
                    {
                        //If this is an SQL Server Specific Type
                        SqlCommand command = (SqlCommand)dbCommand;
                        command.Parameters.AddWithValue(parameter.Value.Name, parameter.Value.Value);
                    }
                    else
                    {
                        //IF ths is a general db typ
                        AddInParameter(dbCommand, parameter.Value.Name, parameter.Value.SqlType, parameter.Value.Value);
                    }
                }
            }
        }

        /// <summary>
        /// 
        /// </summary>
        private void CreatePerformanceCounters()
        {
            try
            {
                if (PerformanceCounterCategory.Exists(WebConfig.PerformanceCounterCategoryName))
                {
                    PerformanceCounterCategory.Delete(WebConfig.PerformanceCounterCategoryName);
                }
                CounterCreationDataCollection Counters = new CounterCreationDataCollection();

                CounterCreationData CounterData = new CounterCreationData();
                CounterData.CounterName = "Total SQL Statements";
                CounterData.CounterHelp = "";
                CounterData.CounterType = PerformanceCounterType.NumberOfItems64;

                Counters.Add(CounterData);

                CounterData = new CounterCreationData();
                CounterData.CounterName = "Total Milliseconds";
                CounterData.CounterHelp = "";
                CounterData.CounterType = PerformanceCounterType.NumberOfItems64;

                Counters.Add(CounterData);

                PerformanceCounterCategory.Create(WebConfig.PerformanceCounterCategoryName, WebConfig.PerformanceCounterCategoryName, PerformanceCounterCategoryType.Unknown, Counters);

                counterTotalStatements = new PerformanceCounter(WebConfig.PerformanceCounterCategoryName, "Total SQL Statements", false);
                counterTotalTime = new PerformanceCounter(WebConfig.PerformanceCounterCategoryName, "Total Milliseconds", false);

                counterTotalStatements.RawValue = 0;
                counterTotalTime.RawValue = 0;
            }
            catch (Exception exp)
            {
                Logger.Error(ErrorMessageResID.DBServiceCreatePerformanceCountersFailed, exp);
            }
        }
        /// <summary>
        /// UpdatePerformanceCounter
        /// </summary>
        /// <param name="count"></param>
        /// <param name="BatchTime"></param>
        /// <param name="BatchStartTime"></param>
        private void UpdatePerformanceCounter(int count, TimeSpan BatchTime, DateTime BatchStartTime)
        {
            try
            {
                LogSQL("Start Time :" + BatchStartTime.ToLocalTime() + " Time Span in Milliseconds  : " + BatchTime.Milliseconds + " Total No Of Statements : " + count);
                //if (counterTotalStatements != null) counterTotalStatements.IncrementBy(count);
                //if (counterTotalTime != null) counterTotalTime.RawValue += System.Convert.ToInt32(BatchTime.Milliseconds);
                //TotalTime += BatchTime;
                //TotalStatements += count;
            }
            catch (Exception exp)
            {
                Logger.Error(ErrorMessageResID.DBServiceUpdatePerformanceCounterFailed, exp);
            }
        }

        private void LogSQL(string name, string sql)
        {
            Logger.Debug(name + " SQL ::  " + sql);
        }
        private void LogSQL(string sql)
        {
            LogSQL(string.Empty, sql);
        }
        private void LogDataSetXML(string name, DataSet dataSet)
        {
            //if (WebConfig.DeveloperMode == DeveloperMode.Enabled.GetHashCode())
            //  Logger.Debug(name + "  XML Format ::  " + dataSet.GetXml());
        }

    }

}

