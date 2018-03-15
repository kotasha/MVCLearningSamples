using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Kotacs.Libraries.DAL.OrderSystem.Wrappers
{
    public class SqlTable : SqlTableBase
    {
        // The tableName
        private string tableName;
        // The alias
        private string alias;
        /// <summary>
        /// The TableName of SqlTable
        /// </summary>
        public override string TableName { get { return tableName; } }
        public override string Alias { get { return alias; } }

        public SqlTable(string tableName)
            : this(tableName, tableName)
        {

        }
        /// <summary>
        /// constructor of SqlTable.Takes tableName and the alias via parameters
        /// </summary>
        /// <param name="tableName">string</param>
        /// <param name="alias">string</param>
        public SqlTable(string tableName, string alias)
        {
            this.tableName = tableName;
            this.alias = alias;
        }
    }
}
