using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Kotacs.Libraries.DAL.OrderSystem.Wrappers
{
    public class InsertQuery : QueryBase
    {
        /// <summary>
        /// The constructor of the InsertQuery
        /// </summary>
        /// <param name="name"></param>
        public InsertQuery(string name)
            : base(name, SQLType.InsertSQL)
        {

        }
        /// <summary>
        /// Constructor of the InsertQuery
        /// </summary>
        /// <param name="name">string</param>
        /// <param name="isReturnIdentityRequired">bool type value</param>

        public InsertQuery(string name, bool isReturnIdentityRequired)
            : base(name, SQLType.InsertSQL, isReturnIdentityRequired)
        {

        }

        public void AddSelectQueryToRetrieveData(QueryBase query)
        {
            this.QueryBuilder.AddInsertSubSelect(query.QueryBuilder);
        }

        /// <summary>
        /// the override method of the AddTable
        /// </summary>
        /// <param name="table">SqlTableBase</param>
        public override void AddTable(SqlTableBase table)
        {
            this.QueryBuilder.AddTable(table.TableName);
        }
    }
}
