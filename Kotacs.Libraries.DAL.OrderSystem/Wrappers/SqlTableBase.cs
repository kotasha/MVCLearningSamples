using System;
using System.Collections.Generic;
using System.Text;

namespace Kotacs.Libraries.DAL.OrderSystem.Wrappers
{
    public abstract class SqlTableBase
    {
        /// <summary>
        /// abstract TableName
        /// </summary>
        public abstract string TableName { get; }
        /// <summary>
        /// abstract Alias
        /// </summary>
        public abstract string Alias { get; }

        /// <summary>
        /// SqlField 
        /// </summary>
        /// <param name="fieldName">string</param>
        /// <returns>SqlField</returns>
        public SqlField this[string fieldName]
        {
            get
            {
                return new SqlField(this.Alias, fieldName);
            }
        }
        /// <summary>
        /// method override
        /// </summary>
        /// <returns>TableName</returns>
        public override string ToString()
        {
            return TableName;
        }
    }
}

