using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace Kotacs.Libraries.DAL.OrderSystem.Wrappers
{
    public abstract class QueryBase
    {
        QueryBuilder queryBuilder;

        private List<string> fieldNames;
        private string name;
        int orderBySequance;

        #region public Properties
        /// <summary>
        /// QueryBuilder of the QueryBase
        /// </summary>
        public QueryBuilder QueryBuilder
        {
            get { return queryBuilder; }
            protected set { queryBuilder = value; }
        }

        /// <summary>
        /// FieldNames of the QueryBase
        /// </summary>
        public IList<string> FieldNames
        {
            get { return fieldNames; }
        }

        /// <summary>
        /// Name of the QueryBase
        /// </summary>
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        /// <summary>
        /// sql of the QueryBase
        /// </summary>
        public string Sql
        {
            get { return ToString(); }
        }
        /// <summary>
        /// getdistinctRowsOnly of the QueryBase
        /// </summary>
        public bool GetDistinctRowsOnly
        {
            get { return queryBuilder.IsDistinct; }
            set { queryBuilder.IsDistinct = value; }
        }
        #endregion

        #region Constructors
        /// <summary>
        ///  this is the QueryBase constructor 
        /// this takes name and type as parameters
        ///
        /// </summary>
        /// <param name="name">parameter name</param>
        /// <param name="type">SQLType</param>
        protected QueryBase(string name, SQLType type)
        {
            this.name = name;
            fieldNames = new List<string>();
            queryBuilder = new QueryBuilder(type, name);

        }

        /// <summary>
        /// this is the QueryBase constructor
        /// Takes name and type as parameters and
        ///  sets RetuenIdentity to true.
        /// </summary>
        /// <param name="name">parameter name</param>
        /// <param name="type"></param>
        /// <param name="isReturnIdentityRequired"> isReturnIdentityRequired as boolean value</param>

        protected QueryBase(string name, SQLType type, bool isReturnIdentityRequired)
        {
            this.name = name;
            fieldNames = new List<string>();
            queryBuilder = new QueryBuilder(type, name);

            if (isReturnIdentityRequired)
                queryBuilder.ReturnIdentity = true;
        }
        #endregion

        /// <summary>
        /// This is the AddFeild method.Takes filed and alias as parameters
        /// 
        /// 
        /// </summary>
        /// <param name="filed">SqlExpressionBase</param>
        /// <param name="alias">string</param>

        public void AddField(SqlExpressionBase filed, string alias)
        {
            this.fieldNames.Add(alias);
            this.QueryBuilder.AddFunction(filed.ToString(), alias);
        }

        /// <summary>
        /// This is the AddParameter method for the short type value.
        /// Gets values for the parameterName and value Parameters,
        /// & returns an instance of the SqlParameter
        /// </summary>
        /// <param name="parameterName"></param>
        /// <param name="value"></param>
        /// <returns>int16 type of SqlParameter</returns>
        public SqlParameter AddParameter(string parameterName, short value)
        {
            this.QueryBuilder.AddParameter(parameterName, DbType.Int16, value);
            return new SqlParameter(parameterName, DbType.Int16);
        }
        /// <summary>
        /// AddParameter method for an integer type value.
        /// gets values to the parameters and returns an instance of the SqlParameter
        /// </summary>
        /// <param name="parameterName"></param>
        /// <param name="value"></param>
        /// <returns>int type of SqlParameter</returns>

        public SqlParameter AddParameter(string parameterName, int value)
        {
            this.QueryBuilder.AddParameter(parameterName, DbType.Int32, value);
            return new SqlParameter(parameterName, DbType.Int32);
        }

        /// <summary>
        /// AddParameter method for long type value.
        /// </summary>
        /// <param name="parameterName">string type</param>
        /// <param name="value">long type</param>
        /// <returns>long type of SqlParameter</returns>

        public SqlParameter AddParameter(string parameterName, long value)
        {
            this.QueryBuilder.AddParameter(parameterName, DbType.Int64, value);
            return new SqlParameter(parameterName, DbType.Int64);
        }

        /// <summary>
        /// AddParameter method for a float value
        /// </summary>
        /// <param name="parameterName">string</param>
        /// <param name="value">float</param>
        /// <returns>float type of SqlParameter</returns>
        public SqlParameter AddParameter(string parameterName, float value)
        {
            this.QueryBuilder.AddParameter(parameterName, DbType.Single, value);
            return new SqlParameter(parameterName, DbType.Single);
        }

        /// <summary>
        /// The AddParameter method for a double type value
        /// </summary>
        /// <param name="parameterName">string</param>
        /// <param name="value">double type</param>
        /// <returns>double type of SqlParameter</returns>
        public SqlParameter AddParameter(string parameterName, double value)
        {
            this.QueryBuilder.AddParameter(parameterName, DbType.Double, value);
            return new SqlParameter(parameterName, DbType.Double);
        }

        /// <summary>
        /// AddParameter method for a decimal type value
        /// </summary>
        /// <param name="parameterName">string</param>
        /// <param name="value">decimal</param>
        /// <returns>decimal type SqlParameter</returns>

        public SqlParameter AddParameter(string parameterName, decimal value)
        {
            this.QueryBuilder.AddParameter(parameterName, DbType.Decimal, value);
            return new SqlParameter(parameterName, DbType.Decimal);
        }
        /// <summary>
        /// The AddParameter method for string type value
        /// </summary>
        /// <param name="parameterName">string</param>
        /// <param name="value">string</param>
        /// <returns>string type of SqlParameter</returns>
        public SqlParameter AddParameter(string parameterName, string value)
        {
            this.QueryBuilder.AddParameter(parameterName, DbType.String, value);
            return new SqlParameter(parameterName, DbType.String);
        }
        /// <summary>
        /// The AddParameter method for Datetime type value
        /// </summary>
        /// <param name="parameterName">string</param>
        /// <param name="value">DateTime</param>
        /// <returns>DateTime type SQLParameter</returns>
        public SqlParameter AddParameter(string parameterName, DateTime value)
        {
            this.QueryBuilder.AddParameter(parameterName, DbType.DateTime, value);
            return new SqlParameter(parameterName, DbType.DateTime);
        }

        //public SqlParameter AddParameter(string parameterName, DateTime value)
        //{
        //    this.QueryBuilder.AddParameter(parameterName, DbType.DateTime, value);
        //    return new SqlParameter(parameterName, DbType.DateTime);
        //}

        public SqlParameter AddParameter(string parameterName, short? value)
        {
            this.QueryBuilder.AddParameter(parameterName, DbType.Int16, value);
            return new SqlParameter(parameterName, DbType.Int16);
        }

        public SqlParameter AddParameter(string parameterName, int? value)
        {
            this.QueryBuilder.AddParameter(parameterName, DbType.Int32, value);
            return new SqlParameter(parameterName, DbType.Int32);
        }

        public SqlParameter AddParameter(string parameterName, long? value)
        {
            this.QueryBuilder.AddParameter(parameterName, DbType.Int64, value);
            return new SqlParameter(parameterName, DbType.Int64);
        }

        public SqlParameter AddParameter(string parameterName, float? value)
        {
            this.QueryBuilder.AddParameter(parameterName, DbType.Single, value);
            return new SqlParameter(parameterName, DbType.Single);
        }

        public SqlParameter AddParameter(string parameterName, double? value)
        {
            this.QueryBuilder.AddParameter(parameterName, DbType.Double, value);
            return new SqlParameter(parameterName, DbType.Double);
        }

        public SqlParameter AddParameter(string parameterName, decimal? value)
        {
            this.QueryBuilder.AddParameter(parameterName, DbType.Decimal, value);
            return new SqlParameter(parameterName, DbType.Decimal);
        }

        public SqlParameter AddParameter(string parameterName, DateTime? value)
        {
            this.QueryBuilder.AddParameter(parameterName, DbType.DateTime, value);
            return new SqlParameter(parameterName, DbType.DateTime);
        }

        /// <summary>
        /// Get boolean type SQLParameter by giving parameter name
        /// </summary>
        /// <param name="parameterName">Parameter name</param>
        /// <param name="value">boolean type value</param>
        /// <returns>boolean type SQLParameter</returns>
        public SqlParameter AddParameter(string parameterName, bool value)
        {
            this.QueryBuilder.AddParameter(parameterName, DbType.Boolean, value);
            return new SqlParameter(parameterName, DbType.Boolean);
        }


        /// <summary>
        /// Adds the stored proc out parameter.
        /// </summary>
        /// <param name="parameterName">Name of the parameter.</param>
        /// <param name="parameterType">Type of the parameter.</param>
        /// <param name="outputSize">Size of the output.</param>
        public void AddStoredProcOutParameter(string parameterName, DbType parameterType, int outputSize)
        {
            this.QueryBuilder.AddStoredProcOutParameter(parameterName, parameterType, outputSize);
        }


        /// <summary>
        /// Gets the out parameter value.
        /// </summary>
        /// <param name="field">The field.</param>
        /// <returns></returns>
        public object GetOutParameterValue(string field)
        {
            return this.QueryBuilder.Parameters[field].Value;
        }

        /// <summary>
        /// SetFeild method.
        /// </summary>
        /// <param name="field">SqlFeild</param>
        /// <param name="value">SqlExpressionBase</param>

        public void SetField(SqlField field, SqlExpressionBase value)
        {
            this.QueryBuilder.AddSetClauseItemWithFieldValueString(field.FieldName, value.ToString());
        }

        /// <summary>
        /// SetFeild method.
        /// </summary>
        /// <param name="field">SqlFeild</param>    
        public void SetField(SqlField field)
        {
            this.QueryBuilder.AddSetClauseItemWithFieldValueString(field.FieldName, string.Empty);
        }


        /// <summary>
        /// This methode is obsolete, Please use "SQLInnerJoin" Instead
        /// method for the innerjoining of tables.joining the tables by taking a field from each tables with there ailias.
        /// </summary>
        /// <param name="table">SqlTableBase</param>
        /// <param name="mainTableField">SqlField </param>
        /// <param name="joinTableField">SqlField</param>
        [Obsolete("Use SqlInnerJoin instead.")]
        public void InnerJoin(SqlTableBase table, SqlField mainTableField, SqlField joinTableField)
        {
            queryBuilder.AddTable(table.TableName, table.Alias);
            queryBuilder.AddJoin(
                mainTableField.Alias, mainTableField.FieldName, joinTableField.Alias, joinTableField.FieldName);
        }

        /// <summary>
        /// method for the innerjoining of tables. joining the tables by taking a field from each tables with there ailias.
        /// </summary>
        /// <param name="table">SqlTableBase</param>
        /// <param name="mainTableField">SqlField </param>
        /// <param name="joinTableField">SqlField</param>
        public void SqlInnerJoin(SqlTableBase table, SqlField mainTableField, SqlField joinTableField)
        {
            queryBuilder.AddTable(table.TableName, table.Alias);
            queryBuilder.AddInnerJoin(
               mainTableField.Alias, mainTableField.FieldName, joinTableField.Alias, joinTableField.FieldName);
        }


        /// <summary>
        /// Method for the LeftOuterjoining of Tables.Takes a field from each tables, with there alians to join.
        /// </summary>
        /// <param name="table">SqlTableBase</param>
        /// <param name="mainTableField">SqlField </param>
        /// <param name="joinTableField">SqlField </param>

        public void LeftOuterJoin(SqlTableBase table, SqlField mainTableField, SqlField joinTableField)
        {
            queryBuilder.AddTable(table.TableName, table.Alias);
            queryBuilder.AddOuterJoin(
                mainTableField.Alias, mainTableField.FieldName, joinTableField.Alias, joinTableField.FieldName);
        }

        /// <summary>
        /// Takes expression from the parameter and Add to Where clause
        /// </summary>
        /// <param name="expression">SqlExpressionBase</param>

        public void AddWhereClause(SqlExpressionBase expression)
        {
            queryBuilder.AddWhereClauseItem(expression.ToString());
        }

        /// <summary>
        /// Gets the expression and the sortorder from the two Parameters to set the expression and the order for the OrderBy Clause
        /// </summary>
        /// <param name="expression">SqlExpressionBase</param>
        /// <param name="sortOrder">SortOrderTypes</param>

        public void AddOrderByClause(SqlExpressionBase expression, SortOrderTypes sortOrder)
        {
            queryBuilder.AddOrderClauseItem(expression.ToString(), sortOrder, orderBySequance);
            orderBySequance++;
        }

        /// <summary>
        /// Sets the Expression for the GroupBy Clause via the Expression parameter
        /// </summary>
        /// <param name="expression">SqlExpressionBase</param>

        public void SetGroupByClause(SqlExpressionBase expression)
        {
            queryBuilder.GroupBy = expression.ToString();
        }
        /// <summary>
        /// An overload method of AddOrderByClause method.Gets Expression as SqlExpression type and the sortOder to set the OrderBy clause 
        /// </summary>
        /// <param name="expression">SqlExpression </param>
        /// <param name="sortOrder">SortOrderTypes</param>
        public void AddOrderByClause(SqlExpression expression, SortOrderTypes sortOrder)
        {
            queryBuilder.AddOrderClauseItem(expression.ToString(), sortOrder, orderBySequance);
            orderBySequance++;
        }
        /// <summary>
        /// Method to Set Having Clause.Use SqlExpressionBase type expression to set the having clause. 
        /// </summary>
        /// <param name="expression">SqlExpressionBase</param>

        public void SetHavingClause(SqlExpressionBase expression)
        {
            queryBuilder.Having = expression.ToString();
        }

        /// <summary>
        /// An Abstract method.
        /// </summary>
        /// <param name="table">SqlTableBase</param>

        public abstract void AddTable(SqlTableBase table);

        /// <summary>
        /// method Overriding.
        /// </summary>
        /// <returns>queryBuilder</returns>
        public override string ToString()
        {
            return queryBuilder.ToSQL();
        }

        /// <summary>
        /// AddS tored Procedure
        /// </summary>
        /// <param name="storedProcedureName">name of the stored procedure</param>
        public void AddStoredProcedure(string storedProcedureName)
        {
            queryBuilder.AddStoredProcedure(storedProcedureName);
        }
    }
}
