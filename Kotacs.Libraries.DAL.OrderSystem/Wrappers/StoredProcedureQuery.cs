using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Kotacs.Libraries.DAL.OrderSystem.Wrappers
{
    public class StoredProcedureQuery : QueryBase
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="StoredProcedureQuery"/> class.
        /// </summary>
        /// <param name="name">The name.</param>
        public StoredProcedureQuery(string name)
            : base(name, SQLType.StoredProcedure)
        {
        }

        /// <summary>
        /// Add Table to the query
        /// </summary>
        /// <param name="table">SqlTableBase</param>
        public override void AddTable(SqlTableBase table)
        {
            this.QueryBuilder.AddStoredProcedure(table.TableName);
        }
    }
}
