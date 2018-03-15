using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Kotacs.Libraries.DAL.OrderSystem.Wrappers
{
    public class SelectSubQuery : SqlTableBase
    {

        private SelectQuery selectQuery;
        /// <summary>
        /// An override method for Alias
        /// </summary>

        public override string Alias
        {
            get { return selectQuery.Name; }
        }

        /// <summary>
        /// override TableName
        /// </summary>
        public override string TableName
        {
            get { return "(" + selectQuery.ToString() + ")"; }
        }
        /// <summary>
        /// SelectSubQuery Constructor 
        /// </summary>
        /// <param name="selectQuery">SelectQuery</param>
        public SelectSubQuery(SelectQuery selectQuery)
        {
            this.selectQuery = selectQuery;
        }

    }
}

