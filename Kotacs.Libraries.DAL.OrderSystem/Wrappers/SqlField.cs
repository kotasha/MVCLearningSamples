using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace Kotacs.Libraries.DAL.OrderSystem.Wrappers
{
    public class SqlField : SqlExpressionBase
    {
        /// <summary>
        /// Alias of SqlField
        /// </summary>
        public string Alias { get; private set; }

        /// <summary>
        /// FieldName of SqlField
        /// </summary>
        public string FieldName { get; private set; }

        /// <summary>
        /// SqlField constructor
        /// </summary>
        /// <param name="alias">string</param>
        /// <param name="fieldName">string</param>
        public SqlField(string alias, string fieldName)
        {
            this.Alias = alias;
            this.FieldName = fieldName;
        }
        /// <summary>
        /// override ExpressionString
        /// </summary>
        protected override string ExpressionString
        {
            get { return this.Alias + "." + this.FieldName; }
        }
    }
}

