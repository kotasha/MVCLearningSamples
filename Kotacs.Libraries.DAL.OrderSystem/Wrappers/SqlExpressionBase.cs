using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Globalization;
using System.Data;
using Kotacs.Libraries.Common;
namespace Kotacs.Libraries.DAL.OrderSystem.Wrappers
{
    public abstract class SqlExpressionBase
    {
        protected abstract string ExpressionString { get; }

        public override string ToString()
        {
            return ExpressionString;
        }

        /// <summary>
        /// Equals to 
        /// </summary>
        /// <param name="expresion">sql expression </param>
        /// <returns>an instance of SqlExpression</returns>

        public SqlExpressionBase EqualsTo(SqlExpressionBase expression)
        {
            return new SqlExpression("(" + ExpressionString + " = " + expression.ToString() + ")");
        }

        /// <summary>
        /// Greater than
        /// </summary>
        /// <param name="expresion">sql expression</param>
        /// <returns>instance of SqlExpression</returns>

        public SqlExpressionBase GreaterThan(SqlExpressionBase expression)
        {
            return new SqlExpression("(" + ExpressionString + " > " + expression.ToString() + ")");
        }

        /// <summary>
        /// GreaterThanOreEqualTo
        /// </summary>
        /// <param name="expresion">sql expression</param>
        /// <returns>instance of SqlExpression</returns>

        public SqlExpressionBase GreaterThanOrEqualTo(SqlExpressionBase expression)
        {
            return new SqlExpression("(" + ExpressionString + " >= " + expression.ToString() + ")");
        }



        /// <summary>
        /// LessThan
        /// </summary>
        /// <param name="expresion">Sql expression</param>
        /// <returns>instance of SqlExpression</returns>

        public SqlExpressionBase LessThan(SqlExpressionBase expression)
        {
            return new SqlExpression("(" + ExpressionString + " < " + expression.ToString() + ")");
        }

        /// <summary>
        /// LessThanOreEqualTo
        /// </summary>
        /// <param name="expresion">sql expression</param>
        /// <returns>instance fo SqlExpression</returns>

        public SqlExpressionBase LessThanOrEqualTo(SqlExpressionBase expression)
        {
            return new SqlExpression("(" + ExpressionString + " <= " + expression.ToString() + ")");
        }

        /// <summary>
        /// NotEqualsTo
        /// </summary>
        /// <param name="expresion">sql expression</param>
        /// <returns>instance of SqlExpression</returns>

        public SqlExpressionBase NotEqualsTo(SqlExpressionBase expression)
        {
            return new SqlExpression("(" + ExpressionString + " <> " + expression.ToString() + ")");
        }

        /// <summary>
        /// Like
        /// </summary>
        /// <param name="expresion">sql expression</param>
        /// <returns>instance of SqlExpression</returns>

        public SqlExpressionBase Like(SqlExpressionBase expression)
        {
            return new SqlExpression("(" + ExpressionString + " LIKE " + expression.ToString() + ")");
        }

        /// <summary>
        /// IsNull
        /// </summary>
        /// <returns>instance of SqlExpression</returns>

        public SqlExpressionBase IsNull()
        {
            return new SqlExpression("(" + ExpressionString + " IS NULL" + ")");
        }



        /// <summary>
        /// IsNotNull
        /// </summary>
        /// <returns>instance of SqlExpression</returns>

        public SqlExpressionBase IsNotNull()
        {
            return new SqlExpression("(" + ExpressionString + " IS NOT NULL" + ")");
        }

        public SqlExpressionBase IsNull(int replacementValue)
        {
            return new SqlExpression("ISNULL(" + ExpressionString + "," + replacementValue + ")");
        }

        /// <summary>
        /// Sum
        /// </summary>
        /// <returns>instance of SqlExpression</returns>

        public SqlExpressionBase Sum()
        {
            return new SqlExpression("SUM(" + ExpressionString + ")");
        }



        /// <summary>
        /// Count
        /// </summary>
        /// <returns>instance of SqlExpression</returns>
        public SqlExpressionBase Count()
        {
            return new SqlExpression("Count(" + ExpressionString + ")");
        }

        /// <summary>
        /// Min
        /// </summary>
        /// <returns>instance of SqlExpression</returns>

        public SqlExpressionBase Min()
        {
            return new SqlExpression("Min(" + ExpressionString + ")");
        }

        /// <summary>
        /// Max
        /// </summary>
        /// <returns>instance of SqlExpression</returns>

        public SqlExpressionBase Max()
        {
            return new SqlExpression("Max(" + ExpressionString + ")");
        }

        /// <summary>
        /// Average
        /// </summary>
        /// <returns>instance of SqlExpression</returns>

        public SqlExpressionBase Average()
        {
            return new SqlExpression("Average(" + ExpressionString + ")");
        }

        /// <summary>
        /// Between
        /// </summary>
        /// <param name="startValue">int value</param>
        /// <param name="endValue">int value</param>
        /// <returns>instance of SqlExpression</returns>

        public SqlExpressionBase Between(int startValue, int endValue)
        {
            return new SqlExpression("(" + ExpressionString + " BETWEEN " + startValue + " AND " + endValue + ")");
        }

        /// <summary>
        /// Between
        /// </summary>
        /// <param name="startValue">SQL expression returning a single value</param>
        /// <param name="endValue">SQL expression returning a single value</param>
        /// <returns></returns>
        public SqlExpressionBase Between(QueryBase startValue, QueryBase endValue)
        {
            return new SqlExpression("(" + ExpressionString + " BETWEEN (" + startValue.ToString() + ") AND (" + endValue.ToString() + "))");
        }

        /// <summary>
        /// StartsWith
        /// </summary>
        /// <param name="parameter">Sql parameter</param>
        /// <returns>instance of SqlExpression<</returns>

        public SqlExpressionBase StartsWith(SqlParameter parameter)
        {
            return new SqlExpression("(" + ExpressionString + " LIKE '" + parameter.Name + "%')");
        }
        /// <summary>
        /// EndsWith
        /// </summary>
        /// <param name="parameter">SqlParameter</param>
        /// <returns>instance of SqlExpression</returns>
        public SqlExpressionBase EndsWith(SqlParameter parameter)
        {
            return new SqlExpression("(" + ExpressionString + " LIKE '%" + parameter.Name + "')");
        }


        /// <summary>
        /// Contains
        /// </summary>
        /// <param name="parameter">SqlParameter</param>
        /// <returns>instance of SqlExpression</returns>

        public SqlExpressionBase Contains(SqlParameter parameter)
        {
            return new SqlExpression("(" + ExpressionString + " LIKE '%'+" + parameter.Name + "+'%')");
        }

        /// <summary>
        /// EscapeLikeUnderscor
        /// </summary>
        /// <param name="parameter">SqlParameter</param>
        /// <returns>instance of SqlExpression</returns>
        public SqlExpressionBase EscapeLikeUnderscore(SqlParameter parameter)
        {
            return new SqlExpression("(" + ExpressionString + " LIKE '%'+" + parameter.Name + "+'%' ESCAPE " + "'|')");
        }


        /// <summary>
        /// Get the given no of top records
        /// </summary>
        /// <param name="noOfrecords">the given number of records</param>
        /// <returns>instance of SqlExpression</returns>
        public SqlExpressionBase Top(int noOfrecords)
        {
            return new SqlExpression(" Top " + noOfrecords + " " + ExpressionString);
        }

        /// <summary>
        /// Create SQL  EXISTS for WHERE clause when passed a Select Query
        /// </summary>
        /// <param name="expression">Select Query</param>
        /// <returns>SQL  EXISTS for WHERE clause</returns>
        public static SqlExpressionBase Exists(SelectQuery subQuery)
        {
            return new SqlExpression(" EXISTS (" + subQuery.ToString() + ")");
        }

        /// <summary>
        /// Create SQL  EXISTS for WHERE clause when passed a Select Query
        /// </summary>
        /// <param name="expression">Select Query</param>
        /// <returns>SQL  EXISTS for WHERE clause</returns>
        public static SqlExpressionBase NotExists(SelectQuery subQuery)
        {
            return new SqlExpression(" NOT EXISTS (" + subQuery.ToString() + ")");
        }

        /// <summary>
        /// Ceiling
        /// </summary>
        /// <returns>instance of SqlExpression</returns>

        public SqlExpressionBase Ceiling()
        {
            return new SqlExpression("CEILING(" + ExpressionString + ")");
        }

        /// <summary>
        /// In
        /// </summary>
        /// <param name="parameters">ICollection parameter</param>
        /// <returns>In</returns>

        public SqlExpressionBase In(ICollection<int> parameters)
        {
            StringBuilder expressionBuilder = new StringBuilder();

            int i = 0;
            int paramCount = parameters.Count();
            foreach (var param in parameters)
            {
                expressionBuilder.Append(param);
                if (i < paramCount - 1)
                    expressionBuilder.Append(",");
                i++;
            }

            return In(expressionBuilder.ToString());
        }

        /// <summary>
        /// In
        /// </summary>
        /// <param name="parameters">ICollection parameter</param>
        /// <returns>In</returns>

        public SqlExpressionBase In(ICollection<string> parameters)
        {
            StringBuilder expressionBuilder = new StringBuilder();

            int i = 0;
            int paramCount = parameters.Count();
            expressionBuilder.Append("'");
            foreach (var param in parameters)
            {
                //This will remove all ' marks in the input param
                string safeParam = param.Replace("'", "");

                expressionBuilder.Append(safeParam);
                if (i < paramCount - 1)
                    expressionBuilder.Append("','");
                i++;
            }
            expressionBuilder.Append("'");
            return In(expressionBuilder.ToString());
        }

        /// <summary>
        /// In
        /// </summary>
        /// <param name="parameters">string parameter</param>
        /// <returns>instance of SqlExpression</returns>

        public SqlExpressionBase In(string parameters)
        {
            return new SqlExpression("(" + ExpressionString + " IN (" + parameters + "))");
        }

        /// <summary>
        /// in
        /// </summary>
        /// <param name="parameters">Query expression with a single field selected</param>
        /// <returns>instance of SqlExpression</returns>
        public SqlExpressionBase In(QueryBase parameters)
        {
            return new SqlExpression("(" + ExpressionString + " IN (" + parameters.ToString() + "))");
        }


        /// <summary>
        /// Not In
        /// </summary>
        /// <param name="parameters">string parameter</param>
        /// <returns>instance of SqlExpression</returns>
        public SqlExpressionBase NotIn(string parameters)
        {
            return new SqlExpression("(" + ExpressionString + " NOT IN (" + parameters + "))");
        }

        /// <summary>
        /// Convert the provided value into an SQL Expression
        /// </summary>
        /// <param name="value">value to convert</param>
        /// <returns>the SQL expression that represents the value</returns>
        public SqlExpressionBase Constant(int value)
        {
            return new SqlExpression(value.ToString(CultureInfo.InvariantCulture.NumberFormat));
        }

        /// <summary>
        /// Convert the provided value into an SQL Expression
        /// </summary>
        /// <param name="value">value to convert</param>
        /// <returns>the SQL expression that represents the value</returns>
        public SqlExpressionBase Constant(short value)
        {
            return new SqlExpression(value.ToString(CultureInfo.InvariantCulture.NumberFormat));
        }

        /// <summary>
        /// Convert the provided value into an SQL Expression
        /// </summary>
        /// <param name="value">value to convert</param>
        /// <returns>the SQL expression that represents the value</returns>
        public SqlExpressionBase Constant(long value)
        {
            return new SqlExpression(value.ToString(CultureInfo.InvariantCulture.NumberFormat));
        }

        /// <summary>
        /// Convert the provided value into an SQL Expression
        /// </summary>
        /// <param name="value">value to convert</param>
        /// <returns>the SQL expression that represents the value</returns>
        public SqlExpressionBase Constant(float value)
        {
            return new SqlExpression(value.ToString(CultureInfo.InvariantCulture.NumberFormat));
        }


        /// <summary>
        /// Convert the provided value into an SQL Expression
        /// </summary>
        /// <param name="value">value to convert</param>
        /// <returns>the SQL expression that represents the value</returns>
        public SqlExpressionBase Constant(double value)
        {
            return new SqlExpression(value.ToString(CultureInfo.InvariantCulture.NumberFormat));
        }

        /// <summary>
        /// Convert the provided value into an SQL Expression
        /// </summary>
        /// <param name="value">value to convert</param>
        /// <returns>the SQL expression that represents the value</returns>
        public SqlExpressionBase Constant(decimal value)
        {
            return new SqlExpression(value.ToString(CultureInfo.InvariantCulture.NumberFormat));
        }

        /// <summary>
        /// Convert the provided value into an SQL Expression
        /// </summary>
        /// <param name="value">value to convert</param>
        /// <returns>the SQL expression that represents the value</returns>
        public SqlExpressionBase Constant(string value)
        {
            string safeString = value.Replace("'", "''"); //replace singal quate with two single quates
            return new SqlExpression("N'" + safeString + "'");
        }



        /// <summary>
        /// RowNumber
        /// </summary>
        /// <param name="sortOrder">SqlExpressionBase</param>
        /// <param name="sortDirection">SortDirection</param>
        /// <returns>SqlExpression</returns>
        public static SqlExpressionBase RowNumber(SqlExpressionBase sortOrder, SortDirection sortDirection)
        {
            return new SqlExpression("ROW_NUMBER() OVER (ORDER BY " + sortOrder.ToString() + " " + Enum.GetName(typeof(SortDirection), sortDirection) + " ) ");
        }

        /// <summary>
        /// RowNumber
        /// </summary>
        /// <param name="sortOrder">SqlExpressionBase</param>
        /// <param name="sortDirection">SortDirection</param>
        /// <returns>SqlExpression</returns>
        public static SqlExpressionBase RowNumber(SqlExpressionBase partitionField, SqlExpressionBase sortOrder, SortDirection sortDirection)
        {
            return new SqlExpression("ROW_NUMBER() OVER (PARTITION BY " + partitionField.ToString() + " ORDER BY " + sortOrder.ToString() + " " + Enum.GetName(typeof(SortDirection), sortDirection) + " ) ");
        }


        /// <summary>
        /// And
        /// </summary>
        /// <param name="expressions">SqlExpressionBase</param>
        /// <returns>AddOperator</returns>

        public static SqlExpressionBase And(params SqlExpressionBase[] expressions)
        {
            return AddOperator("AND", expressions);
        }

        /// <summary>
        /// Or
        /// </summary>
        /// <param name="expressions">SqlExpressionBase</param>
        /// <returns>AddOperator</returns>

        public static SqlExpressionBase Or(params SqlExpressionBase[] expressions)
        {
            return AddOperator("OR", expressions);
        }

        /// <summary>
        /// Null
        /// </summary>
        /// <returns>SqlExpression</returns>

        public static SqlExpressionBase Null()
        {
            return new SqlExpression("NULL");
        }
        /// <summary>
        /// CountAll
        /// </summary>
        /// <returns>SqlExpression</returns>
        public static SqlExpressionBase CountAll()
        {
            return new SqlExpression("Count(*)");
        }

        /// <summary>
        /// GetDate
        /// </summary>
        /// <returns></returns>
        public static SqlExpressionBase GetSqlDate()
        {
            return new SqlExpression("GetDate()");
        }

        /// <summary>
        /// SqlExpressionBase
        /// </summary>
        /// <param name="stringConstant">string</param>
        /// <returns>SqlExpression</returns>
        public static implicit operator SqlExpressionBase(string valueConstant)
        {
            return new SqlExpression(valueConstant);
        }

        /// <summary>
        /// Create new SQL expression that will add two given SQL expressions
        /// </summary>
        /// <param name="expression1">SQL expression 1</param>
        /// <param name="expression2">SQL expression 2</param>
        /// <returns>Return SQL expression</returns>
        public static SqlExpressionBase Add(SqlExpressionBase expression1, SqlExpressionBase expression2)
        {
            return new SqlExpression("(" + expression1.ToString() + " + " + expression2.ToString() + ")");
        }



        /// <summary>
        /// Create new SQL expression that will substract one given SQL expression from another (expression 1 - expression 2)
        /// </summary>
        /// <param name="expression1">SQL expression 1</param>
        /// <param name="expression2">SQL expression 2</param>
        /// <returns>Return SQL expression</returns>
        public static SqlExpressionBase Subtract(SqlExpressionBase expression1, SqlExpressionBase expression2)
        {
            return new SqlExpression("(" + expression1.ToString() + " - " + expression2.ToString() + ")");
        }

        /// <summary>
        /// Create new SQL expression that will multiply given SQL expressions
        /// </summary>
        /// <param name="expression1">SQL expression 1</param>
        /// <param name="expression2">SQL expression 2</param>
        /// <returns>Return SQL expression</returns>
        public static SqlExpressionBase Multiply(SqlExpressionBase expression1, SqlExpressionBase expression2)
        {
            return new SqlExpression("(" + expression1.ToString() + " * " + expression2.ToString() + ")");
        }



        /// <summary>
        /// Create new SQL expression that will divide one given SQL expression by another (Experssion 1 / Expression 2)
        /// </summary>
        /// <param name="expression1">SQL expression 1</param>
        /// <param name="expression2">SQL expression 2</param>
        /// <returns>Return SQL expression</returns>
        public static SqlExpressionBase Divide(SqlExpressionBase expression1, SqlExpressionBase expression2)
        {
            return new SqlExpression("(" + expression1.ToString() + " / " + expression2.ToString() + ")");
        }

        /// <summary>
        /// operator +
        /// </summary>
        /// <param name="expression1">SqlExpressionBase</param>
        /// <param name="expression2">SqlExpressionBase</param>
        /// <returns>SqlExpression</returns>
        public static SqlExpressionBase operator +(SqlExpressionBase expression1, SqlExpressionBase expression2)
        {
            return Add(expression1, expression2);
        }


        /// <summary>
        /// operator -
        /// </summary>
        /// <param name="expression1">SqlExpressionBase</param>
        /// <param name="expression2">SqlExpressionBase</param>
        /// <returns>SqlExpression</returns>
        public static SqlExpressionBase operator -(SqlExpressionBase expression1, SqlExpressionBase expression2)
        {
            return Subtract(expression1, expression2);
        }

        /// <summary>
        /// operator *
        /// </summary>
        /// <param name="expression1">SqlExpressionBase</param>
        /// <param name="expression2">SqlExpressionBase</param>
        /// <returns>SqlExpression</returns>
        public static SqlExpressionBase operator *(SqlExpressionBase expression1, SqlExpressionBase expression2)
        {
            return Multiply(expression1, expression2);
        }

        /// <summary>
        /// operator /
        /// </summary>
        /// <param name="expression1">SqlExpressionBase</param>
        /// <param name="expression2">SqlExpressionBase</param>
        /// <returns>SqlExpression</returns>
        public static SqlExpressionBase operator /(SqlExpressionBase expression1, SqlExpressionBase expression2)
        {
            return Divide(expression1, expression2);
        }

        /// <summary>
        /// AddOperator
        /// </summary>
        /// <param name="operatorName">string</param>
        /// <param name="expressions">SqlExpressionBase</param>
        /// <returns>SqlExpression</returns>
        private static SqlExpressionBase AddOperator(string operatorName, SqlExpressionBase[] expressions)
        {
            if (expressions == null)
                throw new ArgumentNullException("expressions");

            StringBuilder expressionBuilder = new StringBuilder();
            expressionBuilder.Append("(");
            for (int i = 0; i < expressions.Length; i++)
            {
                expressionBuilder.Append(expressions[i].ToString());
                if (i != expressions.Length - 1)
                {
                    expressionBuilder.Append(" " + operatorName + " ");
                }
            }
            expressionBuilder.Append(")");
            return new SqlExpression(expressionBuilder.ToString());
        }


        /// <summary>
        /// Create SQL for extracting the datepart from date-time 
        /// </summary>	
        /// <returns>instance of SqlExpression</returns>
        public SqlExpressionBase DatePartOnly()
        {
            return new SqlExpression(string.Concat("DATEADD(dd, 0, DATEDIFF(dd, 0, ", ExpressionString, "))"));
        }


    }
}

