using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;
using System.Data;

namespace Kotacs.Libraries.DAL.OrderSystem.Wrappers
{

    public class SqlExpression : SqlExpressionBase
    {
        private string expressionString;
        /// <summary>
        /// SqlExpression Constructor
        /// </summary>
        /// <param name="expression">string</param>
        public SqlExpression(string expression)
        {
            this.expressionString = expression;
        }



        /// <summary>
        /// Override of ExpressionString
        /// </summary>

        protected override string ExpressionString
        {
            get { return expressionString; }
        }

        /// <summary>
        /// FromString
        /// </summary>
        /// <param name="expressionValue">string</param>
        /// <returns>instance of SqlExpression</returns>
        public static SqlExpression FromString(string expressionValue)
        {
            return new SqlExpression(expressionValue);
        }
    }
}
