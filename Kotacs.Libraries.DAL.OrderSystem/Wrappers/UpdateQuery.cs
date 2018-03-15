using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Kotacs.Libraries.DAL.OrderSystem.Wrappers
{
    public class UpdateQuery : QueryBase
    {
        /// <summary>
        /// The constructor of UpdateQuery
        /// </summary>
        /// <param name="name">string type</param>
        public UpdateQuery(string name)
            : base(name, SQLType.UpdateSQL)
        {

        }
        /// <summary>
        /// override the method AddTable
        /// </summary>
        /// <param name="table">Sql TableBase</param>
        public override void AddTable(SqlTableBase table)
        {
            this.QueryBuilder.AddTable(table.TableName, table.Alias);
        }
    }
}

