using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Kotacs.Libraries.DAL.OrderSystem.Wrappers;
namespace Kotacs.Libraries.DAL.OrderSystem.Wrappers
{
    public class DeleteQuery : QueryBase
    {
        /// <summary>
        /// This is the Constructor of the DeleteQuery
        /// </summary>
        /// <param name="name"></param>

        public DeleteQuery(string name)
            : base(name, SQLType.DeleteSQL)
        {

        }

        /// <summary>
        /// This is the Override method of the AddTable.
        /// </summary>
        /// <param name="table"></param>

        public override void AddTable(SqlTableBase table)
        {
            this.QueryBuilder.AddTable(table.TableName, table.Alias);
        }
    }
}
