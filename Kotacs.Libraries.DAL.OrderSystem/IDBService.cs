using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.Common;

namespace Kotacs.Libraries.DAL.OrderSystem
{
    public interface IDBService
    {
        // interface for DB service
        DbCommand GetSqlStringCommand(string sqlQuery);
        DataSet ExecuteDataSet(DbCommand dbCommand);
        DbCommand GetStoredProcCommand(string sqlQuery);
    }
}