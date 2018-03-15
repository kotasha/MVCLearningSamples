using System;
using System.Collections.Generic;
using System.Collections;
using System.Text;
using System.Data.Common;
using System.Data;
using System.Collections.Specialized;
using System.Collections.ObjectModel;
using System.Globalization;
using Kotacs.Libraries.Common.Exceptions;
using Kotacs.Libraries.Common;
using Kotacs.Libraries.Utility;

namespace Kotacs.Libraries.DAL.OrderSystem
{
    public enum SQLType
    {
        SelectSQL,
        InsertSQL,
        UpdateSQL,
        DeleteSQL,
        StoredProcedure,
    };

    /// <summary>
    /// ExcludeIncludeIndicator Enum
    /// </summary>
    public enum ExcludeIncludeIndicator
    {
        ExcludeListFields = 0,
        IncludeListFields = 1
    }
    /// <summary>
    /// Table JoinType Enum
    /// </summary>
    public enum JoinType
    {
        RegularJoin = 0,
        OuterJoin = 1,
        InnerJoin = 3
    };

    public enum SqlOperators : int
    {
        None = 0,
        EqualTo = 1,
        LessThan = 2,
        GreaterThan = 3,
        LessThanOrEqualTo = 4,
        GreaterThanOrEqualTo = 5,
        NotEqualTo = 6,
        StartsWith = 7,
        Contains = 8,
        IsNull = 9,
        Found = 10,
        NotFound = 11,
        IsNotNull = 12,
        Between = 13,
        NotBetween = 14,
        In = 15,
        NotIn = 16,
        Before = 17,
        After = 18,
        OPNotAssigned = 19,
        OPAssigned = 20,
        OPSetTo = 21,
        OPIncrementBy = 22,
        OPDecrementBy = 23,
        OPOneOfTheFollowing = 24,
        OPNoneOfTheFollowing = 25,
        OPAllOfTheFollowing = 26,
        OPChecked = 27,
        OPUnchecked = 28,
        OPClear = 29,
        OPAppend = 30,
        OPInExternalData = 33,
        OPNotInExternalData = 34,
        EqualToWithoutTrim = 35

    }
    public enum SQLDataTypes : int
    {

        String = 0,
        DateTime = 3,
        TimeOnly = 5,
        IntegerLong = 8,
        SingleDouble = 9,
        LongText = 12
    }


    public enum ColumnFormatting : int
    {

        None = 0,
        CheckMark = 1,
        Percentage = 2,
        URL = 3,
        Email = 4,
        DateOnly = 5,
        TimeOnly = 6
    }
    public enum SortOrderTypes : int
    {
        Asc = 0,
        Desc = 1,
        GroupBy = 2,
        GroupByDesc = 3
    }
    /// <summary>
    /// QueryBuilders Class
    /// </summary>
    [Serializable()]
    public class QueryBuilders : Object
    {
        private Collection<QueryBuilder> list;
        private string name;
        /// <summary>
        /// QueryBuilders Contructor
        /// </summary>
        public QueryBuilders(string name)
        {
            list = new Collection<QueryBuilder>();
            this.name = name;
        }
        /// <summary>
        ///
        public string Name
        {
            set { name = value; }
            get { return name; }
        }

        /// </summary>
        public QueryBuilder this[int index]
        {
            get
            {
                return list[index];
            }
        }
        public QueryBuilder this[string name]
        {
            get
            {
                foreach (QueryBuilder sql in list)
                {
                    if (sql.Name == name)
                        return sql;
                }
                return null;
            }
        }
        public Collection<QueryBuilder> GetQueryBuilders()
        {
            return list;
        }
        /// <summary>
        /// 
        /// </summary>
        public int Count
        {
            get
            {
                return list.Count;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="QueryBuilder"></param>
        public void AddSQL(QueryBuilder queryBuilder)
        {
            if (!list.Contains(queryBuilder)) // SQL already exist, do not add another one
                list.Add(queryBuilder);
        }

        public string BuildCompoundSql(string withExpression)
        {
            string SQL = "";
            try
            {
                string whereCondition = withExpression;
                QueryBuilder mainBuilder = new QueryBuilder(SQLType.SelectSQL, "mainBuilder");
                foreach (QueryBuilder b in list)
                {


                    foreach (string fieldName in b.Fields)
                    {
                        mainBuilder.AddField(fieldName);
                    }

                    foreach (SQLTable t in b.Tables)
                    {
                        mainBuilder.AddTable(t.Name, t.Alias);
                    }
                    if (b.JoinItems != null)
                    {
                        foreach (JoinItem j in b.JoinItems)
                        {
                            mainBuilder.AddJoin(j.Table1, j.Field1, j.Table2, j.Field2);
                        }
                        b.JoinItems.Clear();
                    }
                    if (b.OuterJoinItems != null)
                    {
                        foreach (JoinItem j in b.OuterJoinItems)
                        {
                            mainBuilder.AddOuterJoin(j.Table1, j.Field1, j.Table2, j.Field2);
                        }
                        b.OuterJoinItems.Clear();
                    }

                    whereCondition = whereCondition.Replace(b.Name, b.BuildWhereClause());
                }

                if (whereCondition != "")
                {
                    if (mainBuilder.JoinItems == null || mainBuilder.JoinItems.Count == 0)
                        SQL = mainBuilder.ToSQL() + " WHERE (" + whereCondition + ")";
                    else
                        SQL = mainBuilder.ToSQL() + " AND (" + whereCondition + ")";
                }
                else
                {
                    SQL = mainBuilder.ToSQL();
                }

            }
            catch (Exception err)
            {
                throw new DataLayerException(err.Message, err);
                //throw new Exception(err.Message, err); /*Replaced automatically*/
            }
            return SQL;
        }

        public QueryBuilder CombineSQLBuilders()
        {
            try
            {
                QueryBuilder mainBuilder = new QueryBuilder(SQLType.SelectSQL, "mainBuilder");
                foreach (QueryBuilder b in list)
                {
                    foreach (string fieldName in b.Fields)
                    {
                        mainBuilder.AddField(fieldName);
                    }

                    foreach (SQLTable t in b.Tables)
                    {
                        mainBuilder.AddTable(t.Name, t.Alias);
                    }

                    if (b.WhereClauseItems != null)
                    {
                        foreach (WhereClauseItem wi in b.WhereClauseItems)
                        {
                            mainBuilder.AddWhereClauseItem(wi.Field, wi.Operator, wi.Value, wi.DataType);
                        }
                    }

                    if (b.JoinItems != null)
                    {
                        foreach (JoinItem j in b.JoinItems)
                        {
                            mainBuilder.AddJoin(j.Table1, j.Field1, j.Table2, j.Field2);
                        }
                        b.JoinItems.Clear();
                    }

                    if (b.OuterJoinItems != null)
                    {
                        foreach (JoinItem j in b.OuterJoinItems)
                        {
                            mainBuilder.AddOuterJoin(j.Table1, j.Field1, j.Table2, j.Field2);
                        }
                        b.OuterJoinItems.Clear();
                    }

                    if (b.FieldSubSelect != null)
                    {
                        foreach (string fieldAlias in b.FieldSubSelect.Keys)
                        {
                            QueryBuilder subSelect = (QueryBuilder)b.FieldSubSelect[fieldAlias];
                            mainBuilder.AddFieldSubSelect(subSelect, fieldAlias);
                        }
                    }

                }

                return mainBuilder;
            }
            catch (Exception err)
            {
                throw new DataLayerException(err.Message, err); /*Replaced automatically*/
                //throw new Exception(err.Message, err); /*Replaced automatically*/
            }
        }
    }
    #region QueryBuilder
    [Serializable()]
    public class QueryBuilder : object
    {
        private const string ParameterPrefix = "@";
        private const string OracleParameterPrefix = ":";
        private string name;
        private Collection<SQLTable> tables;
        private Collection<string> fields;
        private Collection<JoinItem> joinItems;
        private Collection<JoinItem> outerJoinItems;
        private Collection<JoinItem> innerJoinItems;
        private Collection<WhereClauseItem> whereClauseItems;
        private SortedList orderClauseItems;
        private IDictionary<string, SetClauseItem> setClauseItems;
        private QueryBuilder insertSubSelect;
        private Hashtable fieldSubSelect;
        private ArrayList unionSql;// store appended sql builder
        private Hashtable existSubSQL;
        private Hashtable notExistSubSQL;
        private string groupBy;
        private string having;
        private int maxCount;
        private int pageNumber;
        private SQLType sqlType;
        private SQLCommand command = null;
        private bool isDistinct = false;
        private IDictionary<string, ParameterItem> parameters;

        public static readonly DateTime NullDate = new DateTime(1800, 12, 30);
        public static readonly string ItemDelimiter = "~~@~~";

        // For use of Stored procedures
        public string StoredProcedureName { get; private set; }
        public bool IsStoredProcedure { get { return !string.IsNullOrEmpty(StoredProcedureName); } }

        public IDictionary<string, ParameterItem> Parameters
        {
            get { return parameters; }
        }

        public SortedList OrderClauseItems
        {
            get { return orderClauseItems; }
        }

        /// <summary>
        /// Property used to maintain whether identity columns value
        /// required to return to the user
        /// </summary>
        public bool ReturnIdentity { get; set; }

        public int? RequiredRecordCount { get; set; }

        /// <summary>
        /// SQLType Name		
        /// <param name="type">SQLType (SELECT, DELETE, UPDATE, INSERT)</param>		
        /// </summary>
        public QueryBuilder(SQLType type)
        {
            InitializeQueryBuilder(type, null);
        }

        /// <summary>
        /// SQLType Name	
        /// <param name="type">SQLType (SELECT, DELETE, UPDATE, INSERT)</param>
        /// <param name="name">Name of the SQL (will be the DataTable Name in the return DataSet once the query is executed</param>		
        /// </summary>
        public QueryBuilder(SQLType type, string name)
        {
            InitializeQueryBuilder(type, name);
        }

        private void InitializeQueryBuilder(SQLType type, string name)
        {
            sqlType = type;
            this.name = name;
            parameters = new Dictionary<string, ParameterItem>();
        }

        public static string OperatorToSQLString(SqlOperators sqlOperator)
        {
            switch (sqlOperator)
            {
                case SqlOperators.EqualTo:
                case SqlOperators.EqualToWithoutTrim:
                    return " = ";
                case SqlOperators.GreaterThan:
                case SqlOperators.After:
                    return " > ";
                case SqlOperators.GreaterThanOrEqualTo:
                    return " >= ";
                case SqlOperators.LessThan:
                case SqlOperators.Before:
                    return " < ";
                case SqlOperators.LessThanOrEqualTo:
                    return " <= ";
                case SqlOperators.In:
                case SqlOperators.OPInExternalData:
                    return " IN ";
                case SqlOperators.NotIn:
                case SqlOperators.OPNotInExternalData:
                    return " NOT IN ";
                case SqlOperators.Contains:
                    return " Like ";
                case SqlOperators.StartsWith:
                    return " Like ";
                case SqlOperators.IsNull:
                case SqlOperators.OPUnchecked:
                    return " Is NULL ";
                case SqlOperators.OPChecked:
                    return " = 'checked'";
                case SqlOperators.IsNotNull:
                    return " Is Not NULL ";
                case SqlOperators.NotEqualTo:
                    return " <> ";
                case SqlOperators.Between:
                    return " Between ";
                case SqlOperators.NotBetween:
                    return " Not Between ";
                case SqlOperators.OPAllOfTheFollowing:
                    return " = ";
                case SqlOperators.OPNoneOfTheFollowing:
                    return " <> ";
                case SqlOperators.OPOneOfTheFollowing:
                    return " = ";
                default:
                    return " = ";
            }
        }
        public Hashtable FieldSubSelect
        {
            get { return fieldSubSelect; }
        }

        public Hashtable ExistSubSQLs
        {
            get { return existSubSQL; }
        }

        public Hashtable NotExistSubSQLs
        {
            get { return notExistSubSQL; }
        }

        public Collection<WhereClauseItem> WhereClauseItems
        {
            get { return whereClauseItems; }
        }
        public Collection<JoinItem> JoinItems
        {
            get { return joinItems; }
        }
        public Collection<JoinItem> OuterJoinItems
        {
            get { return outerJoinItems; }
        }

        /// <summary>
        /// This is a specialty function that will add the supplied SQL Builder's table and where information to the current SQL Builder.  
        /// Note, it will overwrite most of the collections, but will merge the joins.  However, it could be changed to merge all of the collections.
        /// </summary>
        /// <param name="appendFromSQL">The SQL Builder to Append to</param>
        public void AppendSpecial(QueryBuilder appendFromSql)
        {
            if (appendFromSql.tables != null)
                this.tables = new Collection<SQLTable>(appendFromSql.tables);

            if (appendFromSql.joinItems != null)
            {
                if (this.joinItems == null)
                {
                    this.joinItems = new Collection<JoinItem>(appendFromSql.joinItems);
                }
                else
                {
                    foreach (JoinItem ji in appendFromSql.joinItems)
                    {
                        if (!this.joinItems.Contains(ji))
                            this.joinItems.Add(ji);
                    }
                }
            }
            if (appendFromSql.outerJoinItems != null)
            {
                if (this.outerJoinItems == null)
                {
                    this.outerJoinItems = new Collection<JoinItem>(appendFromSql.outerJoinItems);
                }
                else
                {
                    foreach (JoinItem ji in appendFromSql.outerJoinItems)
                    {
                        if (!this.outerJoinItems.Contains(ji))
                            this.outerJoinItems.Add(ji);
                    }
                }
            }

            if (appendFromSql.existSubSQL != null)
                this.existSubSQL = new Hashtable(appendFromSql.existSubSQL);
            if (appendFromSql.notExistSubSQL != null)
                this.notExistSubSQL = new Hashtable(appendFromSql.notExistSubSQL);
            if (appendFromSql.whereClauseItems != null)
                this.whereClauseItems = new Collection<WhereClauseItem>(appendFromSql.whereClauseItems);
        }

        public string Name
        {
            set { name = value; }
            get { return name; }
        }

        public Collection<SQLTable> Tables
        {
            get { return this.tables; }
        }

        public Collection<string> Fields
        {
            get
            {
                if (fields == null)
                    fields = new Collection<string>();

                return fields;
            }
        }


        public SQLCommand Command
        {
            get
            {
                if (command == null)
                    ToCommand();
                return command;
            }
            set
            {
                command = value;
            }
        }

        public int PageNumber
        {
            get
            {
                return pageNumber;
            }
            set
            {
                pageNumber = value;
            }
        }

        public int MaxCount
        {
            get
            {
                return maxCount;
            }
            set
            {
                maxCount = value;
            }
        }

        public SQLType SQLType
        {
            set
            {
                sqlType = value;
            }
            get
            {
                return sqlType;
            }
        }

        public string GroupBy
        {
            set
            {
                groupBy = value;
            }
            get
            {
                return groupBy;
            }
        }


        public string Having
        {
            set
            {
                having = value;
            }
            get
            {
                return having;
            }
        }

        public bool IsDistinct
        {
            set
            {
                isDistinct = value;
            }
            get
            {
                return isDistinct;
            }
        }


        public void AddField(Collection<string> fieldNames)
        {
            if (fields == null)
                fields = new Collection<String>();
            foreach (string field in fieldNames)
            {
                fields.Add(field);
            }
        }

        public void AddField(string tableName, Collection<string> fieldNames)
        {
            if (fields == null)
                fields = new Collection<String>();
            foreach (string field in fieldNames)
            {
                fields.Add(tableName + "." + field.Trim());
            }
        }
        public void AddField(Dictionary<string, string> fieldnamesWithAlias)
        {
            Collection<string> fieldNames = new Collection<string>();
            foreach (KeyValuePair<string, string> kvp in fieldnamesWithAlias)
            {
                fieldNames.Add(kvp.Key + " AS " + kvp.Value);
            }
            AddField(fieldNames);
        }
        public void AddField(string tableName, Dictionary<string, string> fieldNamesWithAlias)
        {

            Collection<string> fieldNames = new Collection<string>();
            foreach (KeyValuePair<string, string> kvp in fieldNamesWithAlias)
            {
                fieldNames.Add(kvp.Key + " AS " + kvp.Value);
            }
            AddField(tableName, fieldNames);
        }

        /// <summary>
        /// AddField		
        /// <param name="fieldNames">Field name in the table, can be a list of fields come fome the table with the TableName in the first parameter separated by comma ","</param>
        /// </summary>
        public void AddField(string fieldnames)
        {
            if (fields == null)
                fields = new Collection<String>();

            //If FieldNames contains a "(", then it is a Sub-Select and should be used as is
            if (fieldnames.IndexOf("(", StringComparison.Ordinal) > -1)
            {
                if (!fields.Contains(fieldnames.Trim()))
                    fields.Add(fieldnames.Trim());
            }
            else
            {
                string[] s = fieldnames.Split(',');
                foreach (string name in s)
                {
                    if (!fields.Contains(name.Trim()))
                        fields.Add(name.Trim());
                }
            }
        }

        public void AddValue(string value)
        {
            if (fields == null)
                fields = new Collection<String>();

            fields.Add(value.Trim());
        }

        /// <summary>
        /// AddField
        /// <param name="tableName">Table name</param>
        /// <param name="fieldNames">Field name in the table, can be a list of fields come fome the table with the TableName in the first parameter separated by comma ","</param>
        /// </summary>
        public void AddField(string tableName, string fieldnames)
        {
            string[] s = fieldnames.Split(',');
            foreach (string name in s)
            {
                string sName = tableName + "." + name.Trim();
                AddField(tableName + "." + name.Trim());
            }
        }
        /// <summary>
        /// AddField
        /// <param name="tableName">Table name</param>
        /// <param name="fieldname">one field name in the table</param>
        /// <param name="alias">field alias</param>
        /// </summary>
        public void AddField(string tableName, string fieldname, string alias)
        {
            //If this string contains the Alias Token, replace it

            if (fieldname.IndexOf("%&ALIAS%", StringComparison.Ordinal) > -1)
            {
                AddField(fieldname.Replace("%&ALIAS%", tableName + ".") + " as " + alias);
            }
            else
            {
                AddField(tableName + "." + fieldname + " as " + alias);
            }
        }

        /// <summary>
        /// This will add a function
        /// </summary>
        /// <param name="function">function</param>
        /// <param name="fieldAlias">field alias</param>
        public void AddFunction(string function, string fieldAlias)
        {
            AddField(function + " as " + fieldAlias);
        }

        public void AddFieldSubSelect(QueryBuilder subSql, string fieldAlias)
        {
            if (fieldSubSelect == null)
                fieldSubSelect = new Hashtable();

            if (!fieldSubSelect.ContainsKey(fieldAlias))
                fieldSubSelect.Add(fieldAlias, subSql);
        }

        /// <summary>
        /// Add a parameter to the dictionary of parameters
        /// </summary>
        public void AddParameter(string name, DbType sqlType, object value)
        {
            ParameterItem parameter = new ParameterItem();
            parameter.Name = name;
            parameter.SqlType = sqlType;
            parameter.Value = value;

            parameters.Add(name, parameter);
        }

        /// <summary>
        /// Add a parameter to the dictionary of parameters
        /// </summary>
        public void AddParameter(string name, SqlDbType sqlType, object value)
        {
            SqlServerParameterItem parameter = new SqlServerParameterItem();
            parameter.Name = name;
            parameter.Type = sqlType;
            parameter.Value = value;

            parameters.Add(name, parameter);
        }

        /// <summary>
        /// Change the value of a parameter 
        /// </summary>
        public void SetParameter(string name, object value)
        {
            if (parameters != null)
            {
                parameters[name].Value = value;
            }
        }

        /// <summary>
        /// Change the value of a parameter (appends @ to the field automatically)
        /// </summary>
        public void SetParameterField(string field, object value)
        {
            if (parameters != null)
            {
                parameters[ParameterPrefix + field].Value = value;
            }
        }

        /// <summary>
        /// AddTable to the table collection in the builder
        /// <param name="tableName">Table name</param>
        /// </summary>
        public void AddTable(string tableName)
        {
            AddTable(tableName, tableName);
        }
        /// <summary>
        /// Add Table to the table collection in the builder
        /// <param name="tableName">Table Name</param>
        /// <param name="tableAlias">Table Alias</param>
        /// </summary>
        public void AddTable(string tableName, string tableAlias)
        {
            if (tables == null)
                tables = new Collection<SQLTable>();

            foreach (SQLTable t in tables)
            {
                if (t.Alias == tableAlias)
                {
                    if (t.Name == tableName)// table alias already exist			
                        return;
                    else
                        throw new DataLayerException("Table alias " + tableAlias + " already exist for table " + t.Name);
                    //throw new Exception("Table alias " + tableAlias + " already exist for table " + t.Name);
                }
            }
            tables.Add(new SQLTable(tableName, tableAlias));
            if (name == null)// DataSet name will be using the first table name if none is given
                name = tableName;
        }

        /// <summary>
        /// Add Table to the table collection in the builder
        /// <param name="tableName">Table Name</param>
        /// <param name="tableAlias">Table Alias</param>
        /// </summary>
        public void AddTable(QueryBuilder subSql, string tableAlias)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("(");
            sb.Append(subSql.ToSQL());
            sb.Append(")");
            AddTable(sb.ToString(), tableAlias);
        }

        /// <summary>
        /// Set the stored procedure name
        /// </summary>
        /// <param name="storedProcedureName">the stored procedure to be executed</param>
        public void AddStoredProcedure(string storedProcedureName)
        {
            this.StoredProcedureName = storedProcedureName;
        }

        /// <summary>
        /// Add where clause item
        /// <param name="field">Field Name or Field Alias</param>
        /// <param name="sqlOperator">Filter Operator</param>
        /// <param name="value">Value of the field</param>
        /// <param name="dataType">Data Type</param>
        /// </summary> 
        public void AddWhereClauseItem(string field, SqlOperators sqlOperator, object value, SQLDataTypes dataType)
        {
            AddWhereClauseItem(field, sqlOperator, value, dataType, ColumnFormatting.None);
        }
        public void AddWhereClauseItem(string tableAlias, string field, SqlOperators sqlOperator, object value, SQLDataTypes dataType)
        {
            AddWhereClauseItem(GetFieldName(tableAlias, field), sqlOperator, value, dataType, ColumnFormatting.None);
        }


        /// <summary>
        /// Add where clause item
        /// <param name="field">Field Name or Field Alias</param>
        /// <param name="sqlOperator">Filter Operator</param>
        /// <param name="value">Value of the field</param>
        /// <param name="dataType">Data Type</param>
        /// <param name="formatType">Format Type (used for Time Only Fields)</param>
        /// </summary> 
        public void AddWhereClauseItem(string field, SqlOperators sqlOperator, object value, SQLDataTypes dataType, ColumnFormatting formatType)
        {
            AddWhereClauseItem(field, sqlOperator, value, dataType, formatType, false);
        }
        public void AddWhereClauseItem(string tableAlias, string field, SqlOperators sqlOperator, object value, SQLDataTypes dataType, ColumnFormatting formatType)
        {
            AddWhereClauseItem(GetFieldName(tableAlias, field), sqlOperator, value, dataType, formatType, false);
        }

        public void AddWhereClauseItem(string field, SqlOperators sqlOperator, object value, SQLDataTypes dataType, bool valueIsExpression)
        {
            AddWhereClauseItem(field, sqlOperator, value, dataType, ColumnFormatting.None, valueIsExpression);
        }
        public void AddWhereClauseItem(string tableAlias, string field, SqlOperators sqlOperator, object value, SQLDataTypes dataType, bool valueIsExpression)
        {
            AddWhereClauseItem(GetFieldName(tableAlias, field), sqlOperator, value, dataType, ColumnFormatting.None, valueIsExpression);
        }

        public void AddWhereClauseItem(string field, SqlOperators sqlOperator, object value, SQLDataTypes dataType, ColumnFormatting formatType, bool valueIsExpression)
        {
            if ((sqlOperator != SqlOperators.IsNull) && (sqlOperator != SqlOperators.IsNotNull) &&
                (sqlOperator != SqlOperators.OPChecked) && (sqlOperator != SqlOperators.OPUnchecked) && (value == null))
                return;

            if (whereClauseItems == null)
                whereClauseItems = new Collection<WhereClauseItem>();

            WhereClauseItem wi = new WhereClauseItem(field, sqlOperator, value, dataType, formatType, valueIsExpression);
            if (whereClauseItems.Contains(wi))
                return;

            whereClauseItems.Add(wi);
        }
        public void AddWhereClauseItem(string tableAlias, string field, SqlOperators sqlOperator, object value, SQLDataTypes dataType, ColumnFormatting formatType, bool valueIsExpression)
        {
            AddWhereClauseItem(GetFieldName(tableAlias, field), sqlOperator, value, dataType, formatType, valueIsExpression);
        }
        private string GetFieldName(string tableAlias, string field)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(tableAlias);
            sb.Append(".");
            sb.Append(field);
            return sb.ToString();
        }
        public void AddWhereClauseItem(string tableAlias, string field, int value)
        {
            AddWhereClauseItem(GetFieldName(tableAlias, field), SqlOperators.EqualTo, value.ToString(CultureInfo.InvariantCulture), SQLDataTypes.IntegerLong);
        }
        public void AddWhereClauseItem(string tableAlias, string field, double value)
        {
            AddWhereClauseItem(GetFieldName(tableAlias, field), SqlOperators.EqualTo, value.ToString(CultureInfo.InvariantCulture), SQLDataTypes.SingleDouble);
        }
        public void AddWhereClauseItem(string tableAlias, string field, string value)
        {
            AddWhereClauseItem(GetFieldName(tableAlias, field), SqlOperators.EqualTo, value, SQLDataTypes.String);
        }
        public void AddWhereClauseItem(string tableAlias, string field, DateTime value)
        {
            AddWhereClauseItem(GetFieldName(tableAlias, field), SqlOperators.EqualTo, value.ToString(), SQLDataTypes.DateTime);
        }

        public void AddWhereClauseItem(string field, int value)
        {
            AddWhereClauseItem(field, SqlOperators.EqualTo, value.ToString(CultureInfo.InvariantCulture), SQLDataTypes.IntegerLong);
        }
        public void AddWhereClauseItem(string field, double value)
        {
            AddWhereClauseItem(field, SqlOperators.EqualTo, value.ToString(CultureInfo.InvariantCulture), SQLDataTypes.SingleDouble);
        }
        public void AddWhereClauseItem(string field, string value)
        {
            AddWhereClauseItem(field, SqlOperators.EqualTo, value, SQLDataTypes.String);
        }
        public void AddWhereClauseItem(string field, DateTime value)
        {
            AddWhereClauseItem(field, SqlOperators.EqualTo, value.ToString(), SQLDataTypes.DateTime);
        }

        public void AddWhereClauseItem(string whereClause)
        {
            WhereClauseItem wi = new WhereClauseItem(whereClause);
            if (whereClauseItems == null)
                whereClauseItems = new Collection<WhereClauseItem>();
            if (whereClauseItems.Contains(wi))
                return;
            whereClauseItems.Add(wi);
        }

        public void AddWhereClauseItem(string field, SqlOperators sqlOperator, QueryBuilder valueSql)
        {
            WhereClauseItem wi = new WhereClauseItem(field, sqlOperator, valueSql);
            if (whereClauseItems == null)
                whereClauseItems = new Collection<WhereClauseItem>();
            if (whereClauseItems.Contains(wi))
                return;
            whereClauseItems.Add(wi);
        }
        public void AddWhereClauseItem(string tableAlias, string field, SqlOperators sqlOperator, QueryBuilder valueSql)
        {
            AddWhereClauseItem(GetFieldName(tableAlias, field), sqlOperator, valueSql);
        }
        /// <summary>
        /// Add where clause item
        /// <param name="field">field name or field alias</param>
        /// <param name="sqlOperator">operator</param>
        /// <param name="value">string value</param>
        /// </summary>
        public void AddWhereClauseItem(string field, SqlOperators sqlOperator, string value)
        {
            AddWhereClauseItem(field, sqlOperator, value, SQLDataTypes.String);
        }

        public void AddWhereClauseItem(string tableAlias, string field, SqlOperators sqlOperator, string value)
        {
            AddWhereClauseItem(GetFieldName(tableAlias, field), sqlOperator, value, SQLDataTypes.String);
        }

        /// <summary>
        /// Add where clause item
        /// <param name="field">field name or field alias</param>
        /// <param name="sqlOperator">operator</param>
        /// <param name="value">integer value</param>
        /// </summary>
        public void AddWhereClauseItem(string field, SqlOperators sqlOperator, int value)
        {
            AddWhereClauseItem(field, sqlOperator, value.ToString(CultureInfo.InvariantCulture), SQLDataTypes.IntegerLong);
        }

        public void AddWhereClauseItem(string tableAlias, string field, SqlOperators sqlOperator, int value)
        {
            AddWhereClauseItem(GetFieldName(tableAlias, field), sqlOperator, value.ToString(CultureInfo.InvariantCulture), SQLDataTypes.IntegerLong);
        }
        /// <summary>
        /// Add where clause item
        /// <param name="field">field name or field alias</param>
        /// <param name="sqlOperator">operator</param>
        /// <param name="value">double value</param>
        /// </summary>
        public void AddWhereClauseItem(string field, SqlOperators sqlOperator, double value)
        {
            AddWhereClauseItem(field, sqlOperator, value.ToString(CultureInfo.InvariantCulture), SQLDataTypes.SingleDouble);
        }

        public void AddWhereClauseItem(string tableAlias, string field, SqlOperators sqlOperator, double value)
        {
            AddWhereClauseItem(GetFieldName(tableAlias, field), sqlOperator, value.ToString(CultureInfo.InvariantCulture), SQLDataTypes.SingleDouble);
        }
        /// <summary>
        /// Add where clause item
        /// </summary>
        /// <param name="field">field name or field alias</param>
        /// <param name="sqlOperator">operator</param>
        /// <param name="value">DateTime value</param>
        public void AddWhereClauseItem(string field, SqlOperators sqlOperator, DateTime value)
        {
            AddWhereClauseItem(field, sqlOperator, value.ToString(), SQLDataTypes.DateTime);
        }
        public void AddWhereClauseItem(string tableAlias, string field, SqlOperators sqlOperator, DateTime value)
        {
            AddWhereClauseItem(GetFieldName(tableAlias, field), sqlOperator, value.ToString(), SQLDataTypes.DateTime);
        }

        /// <summary>
        /// Add Table Join
        /// </summary>
        /// <param name="table1"></param>
        /// <param name="field1"></param>
        /// <param name="table2"></param>
        /// <param name="field2"></param>
        public void AddJoin(string table1, string field1, string table2, string field2)
        {
            if (joinItems == null)
                joinItems = new Collection<JoinItem>();
            JoinItem item = new JoinItem(table1, field1, table2, field2, JoinType.RegularJoin);
            if (!joinItems.Contains(item))
                joinItems.Add(item);
        }
        /// <summary>
        /// Add Table Outer Join
        /// </summary>
        /// <param name="table1"></param>
        /// <param name="field1"></param>
        /// <param name="table2"></param>
        /// <param name="field2"></param>
        public void AddOuterJoin(string table1, string field1, string table2, string field2)
        {
            if (outerJoinItems == null)
                outerJoinItems = new Collection<JoinItem>();
            JoinItem item = new JoinItem(table1, field1, table2, field2, JoinType.OuterJoin);
            if (!outerJoinItems.Contains(item))
                outerJoinItems.Add(item);
        }

        /// <summary>
        /// Add Outer Join overloaded method: Added to have a condition with outer join query
        /// Fix for 36216
        /// </summary>
        /// <param name="table1">Name/Alias of first table</param>
        /// <param name="field1">Field of first table</param>
        /// <param name="table2">Name/Alias of second table</param>
        /// <param name="field2">Field fo second table</param>
        /// <param name="conditionClause">Sql condition clause to append with join</param>
        public void AddOuterJoin(string table1, string field1, string table2, string field2, string conditionClause)
        {
            if (outerJoinItems == null)
                outerJoinItems = new Collection<JoinItem>();
            JoinItem item = new JoinItem(table1, field1, table2, field2, JoinType.OuterJoin, conditionClause);
            if (!outerJoinItems.Contains(item))
                outerJoinItems.Add(item);
        }

        /// <summary>
        /// Add Inner Join
        /// </summary>
        /// <param name="table1">Name/Alias of first table</param>
        /// <param name="field1">Field of first table</param>
        /// <param name="table2">Name/Alias of second table</param>
        /// <param name="field2">Field for second table</param>
        public void AddInnerJoin(string table1, string field1, string table2, string field2)
        {
            if (innerJoinItems == null)
                innerJoinItems = new Collection<JoinItem>();
            JoinItem item = new JoinItem(table1, field1, table2, field2, JoinType.InnerJoin);
            if (!innerJoinItems.Contains(item))
                innerJoinItems.Add(item);
        }

        /// <summary>
        /// Add sort item to the filter
        /// </summary>
        /// <param name="field">field name or alias name</param>
        /// <param name="order">sorting order</param>
        public void AddOrderClauseItem(string field, SortOrderTypes order)
        {
            AddOrderClauseItem(field, order, 0);
        }

        public void AddOrderClauseItem(string field, SortOrderTypes order, int sequence)
        {
            if (orderClauseItems == null)
                orderClauseItems = new SortedList();

            OrderClauseItem item = new OrderClauseItem(field, order);
            if (orderClauseItems.ContainsValue(item)) // field exist alerady
                return;

            while (orderClauseItems.ContainsKey(sequence))
                sequence++;

            orderClauseItems.Add(sequence, new OrderClauseItem(field, order));

        }

        /// <summary>
        /// ass sort item to the filter
        /// </summary>
        /// <param name="table">table name</param>
        /// <param name="field">field name</param>
        /// <param name="order">sorting order</param>
        public void AddOrderClauseItem(string table, string field, SortOrderTypes order)
        {
            //If this string contains the Alias Token, replace it
            if (field.IndexOf("%&ALIAS%", StringComparison.Ordinal) > -1)
            {
                AddOrderClauseItem(field.Replace("%&ALIAS%", table + "."), order, 0);
            }
            else
            {
                AddOrderClauseItem(table + "." + field, order, 0);
            }
        }

        /// <summary>
        /// AddOrderClauseItem
        /// </summary>
        /// <param name="table">Table Name</param>
        /// <param name="field">Field Name</param>
        /// <param name="order">Order(ASC or DESC)</param>
        /// <param name="sequence">Sequence</param>
        public void AddOrderClauseItem(string table, string field, SortOrderTypes order, int sequence)
        {
            AddOrderClauseItem(table + "." + field, order, sequence);
        }

        public void AddSetClauseItemsWithDataRow(DataRow drRow)
        {
            AddSetClauseItemsWithDataRow(drRow, null, false);
        }

        public void AddSetClauseItemsWithDataRowInclude(DataRow drRow, string includeFieldsInCommaDelimitedValue)
        {
            AddSetClauseItemsWithDataRow(drRow, includeFieldsInCommaDelimitedValue, false);
        }

        public void AddSetClauseItemsWithDataRowExclude(DataRow drRow, string excludeFieldsInCommaDelimitedValue)
        {
            AddSetClauseItemsWithDataRow(drRow, excludeFieldsInCommaDelimitedValue, true);
        }

        private void AddSetClauseItemsWithDataRow(DataRow drRow, string fieldsInCommaDelimitedValue, bool excludeFields)
        {
            StringCollection Fields = null;

            if (fieldsInCommaDelimitedValue != null)
            {
                Fields = new StringCollection();
                string[] fields = fieldsInCommaDelimitedValue.Split(',');
                foreach (string field in fields)
                {
                    Fields.Add(field.ToUpper(CultureInfo.InvariantCulture));
                }
            }
            foreach (DataColumn column in drRow.Table.Columns)
            {
                if ((Fields == null) ||  //Inclcude All Fields
                        (excludeFields && Fields != null && !Fields.Contains(column.ColumnName.ToUpper(CultureInfo.InvariantCulture))) || //Not in the Exclude Field List
                        (!excludeFields && Fields != null && Fields.Contains(column.ColumnName.ToUpper(CultureInfo.InvariantCulture)))) //In the Include Field List
                {
                    if (drRow[column] == System.DBNull.Value)
                        AddSetNullClauseItem(column.ColumnName);
                    else
                    {
                        switch (column.DataType.Name)
                        {
                            case "Int16":
                            case "Int32":
                            case "Int64":
                            case "Decimal":
                            case "Double":
                                AddSetClauseItem(column.ColumnName, Convert.ToDouble(drRow[column], CultureInfo.InvariantCulture));
                                break;
                            case "DateTime":
                                AddSetClauseItem(column.ColumnName, Convert.ToDateTime(drRow[column], CultureInfo.InvariantCulture));
                                break;
                            case "String":
                                AddSetClauseItem(column.ColumnName, drRow[column].ToString());
                                break;
                        }
                    }
                }
            }
        }

        /// <summary>
        /// Add Set Clause Item
        /// </summary>
        /// <param name="field">table field</param>
        /// <param name="value">set value</param>
        /// <param name="dataType">datatype</param>
        private void AddSetClauseItem(string field, string value, SQLDataTypes dataType)
        {
            if (setClauseItems == null)
                setClauseItems = new Dictionary<string, SetClauseItem>();
            if (setClauseItems.ContainsKey(field)) // field exist alerady
                return;
            setClauseItems.Add(field, new SetClauseItem(field, value, dataType));
        }
        /// <summary>
        /// AddSetFieldValue. this is for building update SQL that has field.value = field.value + 1 etc.
        /// </summary>
        /// <param name="field">FieldName</param>
        /// <param name="fieldValueString">New Field Value</param>
        public void AddSetClauseItemWithFieldValueString(string field, string fieldValue)
        {
            if (setClauseItems == null)
                setClauseItems = new Dictionary<string, SetClauseItem>();
            if (setClauseItems.ContainsKey(field)) // field exist alerady
                return;
            setClauseItems.Add(field, new SetClauseItem(field, fieldValue));
        }

        /// <summary>
        /// AddSetClauseItemParameterized. this is for building update SQL with Parameters
        /// </summary>
        /// <param name="Field">FieldName</param>
        /// <param name="FieldValueString">New Field Value</param>
        public void AddSetClauseItemParameterized(string field, DbType parameterType, object value)
        {
            string ParameterName = ParameterPrefix + field;

            if (setClauseItems == null)
                setClauseItems = new Dictionary<string, SetClauseItem>();

            if (setClauseItems.ContainsKey(field)) // field exist alerady
                return;

            setClauseItems.Add(field, new SetClauseItem(field, ParameterName));
            AddParameter(ParameterName, parameterType, value);
        }

        /// <summary>
        /// Add Set Clause Item Parameterized for Oracle. this is for building update/insert queries with Parameters
        /// </summary>
        /// <param name="field">field name</param>
        /// <param name="parameterType">Parameter type</param>
        /// <param name="value">Parametr value</param>
        public void AddOracleSetClauseItemParameterized(string field, DbType parameterType, object value)
        {
            string ParameterName = OracleParameterPrefix + field;

            if (setClauseItems == null)
                setClauseItems = new Dictionary<string, SetClauseItem>();

            if (setClauseItems.ContainsKey(field)) // field exist alerady
                return;

            setClauseItems.Add(field, new SetClauseItem(field, ParameterName));
            AddParameter(ParameterName, parameterType, value);
        }

        /// <summary>
        /// This will add input parameters to a stored procedure
        /// </summary>
        /// <param name="field">the parameter field</param>
        /// <param name="parameterType">the type of the parameter field</param>
        /// <param name="value">the value of the parameter</param>
        public void AddStoredProcInParameter(string field, DbType parameterType, object value)
        {
            string parameterName = ParameterPrefix + field;
            AddParameter(parameterName, parameterType, value);
        }

        /// <summary>
        /// This will add input parameters to a stored procedure
        /// </summary>
        /// <param name="field">the parameter field</param>
        /// <param name="parameterType">the type of the parameter field</param>
        /// <param name="value">the value of the parameter</param>
        public void AddStoredProcInParameter(string field, SqlDbType parameterType, object value)
        {
            string parameterName = ParameterPrefix + field;
            AddParameter(parameterName, parameterType, value);
        }

        /// <summary>
        /// This will add output parameters to a stored procedure
        /// </summary>
        /// <param name="field">the parameter field</param>
        /// <param name="parameterType">the type of the parameter type</param>
        /// <param name="outputSize">the size of the output parameter field</param>
        public void AddStoredProcOutParameter(string field, DbType parameterType, int outputSize)
        {
            string parameterName = ParameterPrefix + field;
            ParameterItem parameter = new ParameterItem();
            parameter.Name = parameterName;
            parameter.SqlType = parameterType;
            parameter.IsOutParameter = true;
            parameter.OutputSize = outputSize;

            parameters.Add(parameterName, parameter);
        }

        /// <summary>
        /// This will assign a value for the given parameter
        /// </summary>
        /// <param name="parameterName">the name of the parameter field</param>
        /// <param name="value">the value to be assigned</param>
        public void SetOutParameterValue(string parameterName, object value)
        {
            parameters[parameterName].Value = value;
        }

        /// <summary>
        /// Retrives output parameter value 
        /// </summary>
        /// <param name="field">the output parameter field name</param>
        /// <returns>An object with the parameter field value</returns>
        public object GetOutParameterValue(string field)
        {
            string parameterName = ParameterPrefix + field;
            return parameters[parameterName].Value;
        }

        /// <summary>
        /// Add Set Clause Item
        /// </summary>
        /// <param name="field">table field</param>
        /// <param name="value">set string value</param>
        public void AddSetClauseItem(string field, string value)
        {
            AddSetClauseItem(field, value, SQLDataTypes.String);
        }
        /// <summary>
        /// Add Set Clause Item
        /// </summary>
        /// <param name="field">table field</param>
        /// <param name="value">set string value</param>
        public void AddSetClauseItem(string field, int value)
        {
            AddSetClauseItem(field, value.ToString(CultureInfo.InvariantCulture), SQLDataTypes.IntegerLong);
        }
        /// <summary>
        /// Add Set Clause Item
        /// </summary>
        /// <param name="field">table field</param>
        /// <param name="value">set integer value</param>
        public void AddSetClauseItem(string field, double value)
        {
            AddSetClauseItem(field, value.ToString(CultureInfo.InvariantCulture), SQLDataTypes.SingleDouble);
        }
        /// <summary>
        /// Add Set Clause Item
        /// </summary>
        /// <param name="field">table field</param>
        /// <param name="value">set non integer nemeric value</param>
        public void AddSetClauseItem(string field, DateTime value)
        {
            AddSetClauseItem(field, value.ToString(), SQLDataTypes.DateTime);
        }

        public void AddSetNullClauseItem(string field)
        {
            if (setClauseItems == null)
                setClauseItems = new Dictionary<string, SetClauseItem>();
            if (setClauseItems.ContainsKey(field)) // field exist alerady
                return;
            setClauseItems.Add(field, new SetClauseItem(field, null, SQLDataTypes.String));
        }

        public void AddInsertSubSelect(QueryBuilder subSql)
        {
            insertSubSelect = subSql;
        }

        public void AddUnion(QueryBuilder unionSqlParameter)
        {
            if (unionSql == null)
                unionSql = new ArrayList();
            unionSql.Add(unionSqlParameter);
        }

        public void AddExist(string existSql)
        {
            if (existSubSQL == null)
                existSubSQL = new Hashtable();

            string key = "sqltext_" + existSubSQL.Keys.Count.ToString(CultureInfo.InvariantCulture);
            while (existSubSQL.ContainsKey(key))
                key = key + "1";
            existSubSQL.Add(key, existSql);
        }

        public void AddExist(QueryBuilder existSql)
        {
            if (existSubSQL == null)
                existSubSQL = new Hashtable();
            string key = existSql.Name;
            if (key == null && key == "")
            {
                key = "sqlbuilder_" + existSubSQL.Keys.Count.ToString(CultureInfo.InvariantCulture);
                while (existSubSQL.ContainsKey(key))
                    key = key + "1";
            }
            existSubSQL.Add(key, existSql);
        }

        public void AddNotExist(string notExistSql)
        {
            if (notExistSubSQL == null)
                notExistSubSQL = new Hashtable();

            string key = "sqltext_" + notExistSubSQL.Keys.Count.ToString(CultureInfo.InvariantCulture);
            while (notExistSubSQL.ContainsKey(key))
                key = key + "1";
            notExistSubSQL.Add(key, notExistSql);
        }

        public void AddNotExist(QueryBuilder notExistSql)
        {
            if (notExistSubSQL == null)
                notExistSubSQL = new Hashtable();
            string key = notExistSql.Name;
            if (key == null && key == "")
            {
                key = "sqlbuilder_" + notExistSubSQL.Keys.Count.ToString(CultureInfo.InvariantCulture);
                while (notExistSubSQL.ContainsKey(key))
                    key = key + "1";
            }
            notExistSubSQL.Add(key, notExistSql);
        }

        public string ToSQL()
        {
            return ToSQL(false);
        }

        /// <summary>
        /// build the SQL string
        /// </summary>
        /// <param name="isParameterized">boolean, indicate the SQL is parameterized or not</param>
        /// <returns>SQL string</returns>
        private string ToSQL(bool isParameterized)
        {
            string sql = "";
            switch (sqlType)
            {
                case SQLType.SelectSQL:
                    sql = BuildSelectSQL(isParameterized);
                    break;
                case SQLType.InsertSQL:
                    sql = BuildInsertSQL(isParameterized);
                    break;
                case SQLType.UpdateSQL:
                    sql = BuildUpdateSQL(isParameterized);
                    break;
                case SQLType.DeleteSQL:
                    sql = BuildDeleteSQL(isParameterized);
                    break;
                case SQLType.StoredProcedure:
                    sql = BuildStoredProcedureSQL();
                    break;
            }
            if (isParameterized) // parse out user defined parameterized sql and build the parameters
            {
                for (int loop = 0; loop < 4; loop++)
                {
                    string parmTag = "";
                    string parmEndTag = "";
                    switch (loop)
                    {
                        case 0:
                            parmTag = "<parmint>";
                            parmEndTag = "</parmint>";
                            break;
                        case 1:
                            parmTag = "<parmnumber>";
                            parmEndTag = "</parmnumber>";
                            break;
                        case 2:
                            parmTag = "<parmstring>";
                            parmEndTag = "</parmstring>";
                            break;
                        case 3:
                            parmTag = "<parmdatetime>";
                            parmEndTag = "</parmdatetime>";
                            break;

                    }
                    int parmStart = sql.IndexOf(parmTag, StringComparison.Ordinal);
                    int parmEnd = sql.IndexOf(parmEndTag, StringComparison.Ordinal);
                    while (parmStart > -1 && parmEnd > parmStart)
                    {
                        string head = sql.Substring(0, parmStart);
                        string tail = sql.Substring(parmEnd + parmEndTag.Length);

                        string val = sql.Substring(parmStart + parmTag.Length, parmEnd - parmStart - parmTag.Length).Trim();
                        string param = "param_" + (Command.Parameters.Count + 1).ToString("000", CultureInfo.InvariantCulture);

                        switch (parmTag)
                        {
                            case "<parmint>":
                                Command.Parameters.Add(new SQLParameter(param, Convert.ToInt32(val, CultureInfo.InvariantCulture)));
                                break;
                            case "<parmnumber>":
                                Command.Parameters.Add(new SQLParameter(param, Convert.ToDouble(val, CultureInfo.InvariantCulture)));
                                break;
                            case "<parmstring>":
                                Command.Parameters.Add(new SQLParameter(param, val));
                                break;
                            case "<parmdatetime>":
                                Command.Parameters.Add(new SQLParameter(param, Convert.ToDateTime(val, CultureInfo.InvariantCulture)));
                                break;
                        }
                        sql = head + ":@" + param + tail;

                        parmStart = sql.IndexOf(parmTag, StringComparison.Ordinal);
                        parmEnd = sql.IndexOf(parmEndTag, StringComparison.Ordinal);
                    }
                }
            }
            return sql;
        }

        public SQLCommand ToCommand()
        {
            switch (sqlType)
            {
                case SQLType.SelectSQL:

                    command = new SQLSelectCommand(name, "");
                    if (PageNumber == 0)
                        ((SQLSelectCommand)command).StartRecord = 0;
                    else
                        ((SQLSelectCommand)command).StartRecord = (PageNumber - 1) * MaxCount;

                    ((SQLSelectCommand)command).MaxCount = MaxCount;

                    break;
                case SQLType.InsertSQL:
                    command = new SQLInsertCommand(name, "");
                    break;
                case SQLType.UpdateSQL:
                    command = new SQLUpdateCommand(name, "");
                    break;
                case SQLType.DeleteSQL:
                    command = new SQLDeleteCommand(name, "");
                    break;
            }

            command.SQL = ToSQL(true);

            return command;
        }

        internal string BuildSelectSQL(bool isParameterized)
        {
            StringBuilder sb = new StringBuilder();
            string s;
            sb.Append("SELECT ");
            if (isDistinct)
                sb.Append("DISTINCT ");
            if (RequiredRecordCount.HasValue)
                sb.Append("TOP " + APConvert.ToString(RequiredRecordCount.Value) + " ");
            if (fields == null && fieldSubSelect == null)
                sb.Append("*");
            int i = 0;
            if (fields != null)
            {
                foreach (string field in fields)
                {
                    if (i > 0)
                        sb.Append(", ");
                    sb.Append(field);
                    i++;
                }
            }
            int j = 0;
            if (fieldSubSelect != null)
            {
                foreach (string fieldAlias in fieldSubSelect.Keys)
                {

                    if (i > 0)
                        sb.Append(", ");
                    sb.Append("(");
                    QueryBuilder subSelect = (QueryBuilder)fieldSubSelect[fieldAlias];

                    if (isParameterized)
                    {
                        subSelect.Command = this.command;
                        sb.Append(" " + subSelect.BuildSelectSQL(isParameterized));
                    }
                    else
                        sb.Append(" " + subSelect.ToSQL());

                    sb.Append(") as " + fieldAlias);
                    j++;
                }
            }
            sb.Append(" FROM ");
            ArrayList tempTables = new ArrayList();
            int index = 0;
            if (this.outerJoinItems != null)
            {
                index = AddJoins(sb, tempTables, index, JoinType.OuterJoin);
            }
            if (this.innerJoinItems != null)
            {
                index = AddJoins(sb, tempTables, index, JoinType.InnerJoin);
            }
            foreach (SQLTable table in this.tables)
            {
                if (!tempTables.Contains(table))
                {
                    if (index > 0)
                        sb.Append(", ");
                    index++;
                    if (table.Alias != table.Name)
                        sb.Append(table.Name + " " + table.Alias);
                    else
                        sb.Append(table.Name);
                }
            }

            s = BuildWhereClause(isParameterized);

            if (s.Length > 0)
            {
                sb.Append(" WHERE ");
                sb.Append(s);
            }

            if (groupBy != null)
            {
                sb.Append(" Group BY " + groupBy);
                if (having != null)
                    sb.Append(" Having " + having);
            }

            s = BuildOrderByClause();
            if (s.Length > 0)
            {
                sb.Append(" ORDER BY ");
                sb.Append(s);
            }

            if (unionSql != null) // use UNION
            {
                foreach (QueryBuilder sql in unionSql)
                {
                    sb.Append(" UNION "); // Append each UNION sql
                    sql.Command = this.command;
                    sb.Append(sql.BuildSelectSQL(isParameterized));
                }
            }
            return sb.ToString();
        }

        private int AddJoins(StringBuilder sb, ArrayList tempTables, int index, JoinType joineType)
        {
            ArrayList tempOuterJoins = new ArrayList();
            Collection<JoinItem> joinItems = null;
            if (joineType == JoinType.OuterJoin)
            {
                joinItems = outerJoinItems;
            }
            else if (joineType == JoinType.InnerJoin)
            {
                joinItems = innerJoinItems;
            }

            while (true)
            {
                string currentTable = "";
                foreach (JoinItem join in joinItems)
                {
                    if (!tempOuterJoins.Contains(join) && (currentTable == "" || currentTable == join.Table1)) // new outer join
                    {
                        foreach (SQLTable table in this.tables)
                        {
                            if (join.Table1 == table.Alias && !tempTables.Contains(table))
                            {
                                if (index > 0)
                                    sb.Append(", ");

                                if (table.Alias != table.Name)
                                    sb.Append(table.Name + " " + table.Alias);
                                else
                                    sb.Append(table.Name);
                                tempTables.Add(table);
                                currentTable = join.Table1;
                                break;
                            }
                        }
                        if (joineType == JoinType.OuterJoin)
                        {
                            sb.Append(" LEFT JOIN ");
                        }
                        else if (joineType == JoinType.InnerJoin)
                        {
                            sb.Append(" INNER JOIN ");
                        }
                        foreach (SQLTable table in this.tables)
                        {
                            if (join.Table2 == table.Alias)
                            {
                                if (table.Alias != table.Name && !tempTables.Contains(table))
                                    sb.Append(table.Name + " " + table.Alias);
                                else
                                    sb.Append(table.Name);
                                sb.Append(" ON ");
                                sb.Append(join.ToSQL());
                                // if ConditionClause is available then append with the join query.
                                if (!String.IsNullOrEmpty(join.ConditionClause))
                                {
                                    sb.Append(join.ConditionClause);
                                }
                                tempTables.Add(table);
                                tempOuterJoins.Add(join);
                                break;
                            }
                        }
                        index++;
                    }
                }
                if (tempOuterJoins.Count == joinItems.Count) //all outer joins have been converted to SQL
                    break;
            }
            return index;
        }

        private string BuildDeleteSQL(bool isParameterized)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("DELETE ");
            sb.Append(tables[0].Name);
            sb.Append(" FROM ");
            int i = 0;
            foreach (SQLTable table in tables)
            {
                if (i > 0)
                    sb.Append(", ");
                if (table.Alias != table.Name)
                    sb.Append(table.Name + " " + table.Alias);
                else
                    sb.Append(table.Name);
                i++;
            }
            string s = BuildWhereClause(isParameterized);
            if (s.Length > 0)
            {
                sb.Append(" WHERE ");
                sb.Append(s);
            }
            return sb.ToString();
        }

        private string BuildInsertSQL(bool isParameterized)
        {
            StringBuilder sbSQL = new StringBuilder();
            sbSQL.Append("INSERT INTO ");
            int i = 0;
            foreach (SQLTable table in tables)
            {
                if (i > 0)
                    sbSQL.Append(", ");
                if (table.Alias != table.Name)
                    sbSQL.Append(table.Name + " " + table.Alias);
                else
                    sbSQL.Append(table.Name);
                i++;
            }

            string fields = string.Empty;
            string values = string.Empty;
            string subSelectQuery = string.Empty;

            if (insertSubSelect != null)
            {
                if (isParameterized)
                {
                    insertSubSelect.Command = this.command;
                    subSelectQuery = insertSubSelect.BuildSelectSQL(isParameterized);
                }
                else
                    subSelectQuery = insertSubSelect.ToSQL();
            }

            if (setClauseItems != null)
            {
                foreach (SetClauseItem si in setClauseItems.Values)
                {
                    if (fields != "")
                    {
                        fields += ", ";
                        values += ", ";
                    }
                    fields += si._field;
                    if (!isParameterized || si._isfieldvalue)
                        values += si.ValueToSQLString(si._value, isParameterized);
                    else
                    {
                        string param = "param_" + (Command.Parameters.Count + 1).ToString("000", CultureInfo.InvariantCulture);
                        values += ":@" + param;
                        if (si._value == null)
                            command.Add(new SQLParameter(param, System.DBNull.Value));
                        else
                        {
                            switch (si._datatype)
                            {
                                case SQLDataTypes.String:
                                    command.Add(new SQLParameter(param, si.ValueToSQLString(si._value, true)));
                                    break;
                                case SQLDataTypes.IntegerLong:
                                    command.Add(new SQLParameter(param, Convert.ToInt32(si._value, CultureInfo.InvariantCulture)));
                                    break;
                                case SQLDataTypes.SingleDouble:
                                    command.Add(new SQLParameter(param, Convert.ToDouble(si._value, CultureInfo.InvariantCulture)));
                                    break;
                                case SQLDataTypes.DateTime:
                                    command.Add(new SQLParameter(param, Convert.ToDateTime(si._value, CultureInfo.InvariantCulture)));
                                    break;
                            }
                        }
                    }
                }

                if (string.IsNullOrEmpty(subSelectQuery))
                {
                    sbSQL.Append("(" + fields + ") Values (" + values + ")");
                }
                else
                {
                    sbSQL.Append("(" + fields + ") (" + subSelectQuery + ")");
                }

            }
            else
            {
                if (!string.IsNullOrEmpty(subSelectQuery))
                    sbSQL.Append(" " + subSelectQuery);
            }

            //Append the scope identity selection is a user set this property to true
            if (ReturnIdentity)
                sbSQL.Append(" Select Scope_Identity() ");

            return sbSQL.ToString();
        }

        private string BuildUpdateSQL(bool isParameterzied)
        {
            StringBuilder sbSQL = new StringBuilder();
            sbSQL.Append("UPDATE ");
            sbSQL.Append(tables[0].Name);
            sbSQL.Append(" SET ");
            int i = 0;
            foreach (SetClauseItem si in setClauseItems.Values)
            {
                if (i > 0)
                    sbSQL.Append(", ");
                sbSQL.Append(si.ToSQL(isParameterzied, ref command));
                i++;
            }

            sbSQL.Append(" FROM ");
            i = 0;
            foreach (SQLTable table in tables)
            {
                if (i > 0)
                    sbSQL.Append(", ");
                if (table.Alias != table.Name)
                    sbSQL.Append(table.Name + " " + table.Alias);
                else
                    sbSQL.Append(table.Name);
                i++;
            }

            string s = BuildWhereClause(isParameterzied);
            if (s.Length > 0)
            {
                sbSQL.Append(" WHERE ");
                sbSQL.Append(s);
            }
            return sbSQL.ToString();
        }

        /// <summary>
        /// Construct stored procedure sql 
        /// </summary>
        /// <returns></returns>
        private string BuildStoredProcedureSQL()
        {
            return StoredProcedureName;
        }

        /// <summary>
        /// Build Where Clause
        /// </summary>
        /// <returns>Where Clause</returns>
        private string BuildWhereClause(bool isParameterized)
        {
            StringBuilder sbWhere = new StringBuilder();
            int i = 0;
            if (joinItems != null)
            {
                foreach (JoinItem join in joinItems)
                {
                    if (i > 0)
                        sbWhere.Append(" AND ");
                    sbWhere.Append(join.ToSQL());
                    i++;
                }
            }
            if (whereClauseItems != null)
            {
                foreach (WhereClauseItem wi in whereClauseItems)
                {
                    if (i > 0)
                        sbWhere.Append(" AND ");
                    sbWhere.Append(wi.ToSQL(isParameterized, ref command));
                    i++;
                }
            }
            if (existSubSQL != null)
            {
                foreach (object o in existSubSQL.Values)
                {
                    if (i > 0)
                        sbWhere.Append(" AND ");
                    sbWhere.Append(" EXISTS (");
                    if (o.GetType().Name == "string")
                        sbWhere.Append(o.ToString());
                    else
                    {
                        if (isParameterized)
                        {
                            ((QueryBuilder)o).Command = this.command;
                            sbWhere.Append(((QueryBuilder)o).BuildSelectSQL(isParameterized));
                        }
                        else
                            sbWhere.Append(((QueryBuilder)o).ToSQL());
                    }
                    sbWhere.Append(")");
                    i++;
                }
            }
            if (notExistSubSQL != null)
            {
                foreach (object o in notExistSubSQL.Values)
                {
                    if (i > 0)
                        sbWhere.Append(" AND ");
                    sbWhere.Append(" Not EXISTS (");
                    if (o.GetType().Name == "string")
                        sbWhere.Append(o.ToString());
                    else
                    {
                        if (isParameterized)
                        {
                            ((QueryBuilder)o).Command = this.command;
                            sbWhere.Append(((QueryBuilder)o).BuildSelectSQL(isParameterized));
                        }
                        else
                            sbWhere.Append(((QueryBuilder)o).ToSQL());
                    }
                    sbWhere.Append(")");
                    i++;
                }
            }
            return sbWhere.ToString();
        }

        public string BuildWhereClause()
        {
            return BuildWhereClause(false);
        }
        /// <summary>
        /// Build Order By Clause
        /// </summary>
        /// <returns>Order By Clause</returns>
        private string BuildOrderByClause()
        {
            string sOrderBy = "";
            if (orderClauseItems == null)
                return sOrderBy;
            foreach (OrderClauseItem oi in orderClauseItems.Values)
            {
                if (sOrderBy != "")
                    sOrderBy += ", ";
                sOrderBy += ((OrderClauseItem)oi).ToSQL();
            }
            return sOrderBy;
        }
    }
    #endregion

    #region Table
    public struct SQLTable
    {
        private string _name;
        private string _alias;
        internal SQLTable(string Name, string Alias)
        {
            _name = Name;
            if (Alias != null)
                _alias = Alias;
            else
                _alias = Name;
        }
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public string Alias
        {
            get { return _alias; }
            set { _alias = value; }
        }
    }
    #endregion

    #region WhereClauseItem
    public struct WhereClauseItem
    {
        private string _field;
        private SqlOperators _operator;
        private object _value;
        private SQLDataTypes _datatype;
        private ColumnFormatting _formatType;
        private string _whereClause;
        private QueryBuilder _valueSql;
        private bool _valueIsExpression;

        public string Field
        {
            get { return _field; }
        }

        public SqlOperators Operator
        {
            get { return _operator; }
        }

        public object Value
        {
            get { return _value; }
        }

        public SQLDataTypes DataType
        {
            get { return _datatype; }
        }

        public ColumnFormatting FormatType
        {
            get { return _formatType; }
        }

        public QueryBuilder ValueSQL
        {
            get { return _valueSql; }
        }

        /// <summary>
        /// WhereClauseItem constructor
        /// </summary>
        /// <param name="field">Field Name</param>
        /// <param name="operator">Filter Operator</param>
        /// <param name="value">Field Value</param>
        /// <param name="dataType">Data Type</param>
        public WhereClauseItem(string field, SqlOperators sqlOperator, object value, SQLDataTypes dataType) : this(field, sqlOperator, value, dataType, false) { }

        public WhereClauseItem(string field, SqlOperators sqlOperator, object value, SQLDataTypes dataType, bool valueIsExpression) :
            this(field, sqlOperator, value, dataType, ColumnFormatting.None, valueIsExpression) { }


        public WhereClauseItem(string field, SqlOperators sqlOperator, object value, SQLDataTypes dataType, ColumnFormatting formatType, bool valueIsExpression)
        {
            _field = field;
            _operator = sqlOperator;
            _value = value;
            _datatype = dataType;
            _formatType = formatType;
            _whereClause = "";
            _valueSql = null;
            _valueIsExpression = valueIsExpression;

            // Handle Date and Date/Time Values (not Time Only Values)
            if (!valueIsExpression && DataType == SQLDataTypes.DateTime &&
                FormatType != ColumnFormatting.TimeOnly &&
                (Operator == SqlOperators.EqualTo || Operator == SqlOperators.NotEqualTo ||
                 Operator == SqlOperators.Between || Operator == SqlOperators.NotBetween ||
                 Operator == SqlOperators.LessThanOrEqualTo || Operator == SqlOperators.GreaterThan))
            {
                // If the operator is Equal/Not Equal
                if (Operator == SqlOperators.EqualTo || Operator == SqlOperators.NotEqualTo)
                {
                    string[] sVals = System.Text.RegularExpressions.Regex.Split(Value.ToString(), QueryBuilder.ItemDelimiter);
                    int index = 0;
                    _value = "";
                    foreach (string v in sVals)
                    {
                        if (index > 0)
                            _value += QueryBuilder.ItemDelimiter;
                        _value += System.DateTime.Parse(v.ToString(), CultureInfo.InvariantCulture).Date + ";" + System.DateTime.Parse(v.ToString(), CultureInfo.InvariantCulture).Date.AddDays(1).AddSeconds(-1);
                        index++;
                    }
                    if (Operator == SqlOperators.EqualTo)
                        _operator = SqlOperators.Between;
                    else
                        _operator = SqlOperators.NotBetween;
                }
                else if (Operator == SqlOperators.LessThanOrEqualTo || Operator == SqlOperators.GreaterThan)
                {
                    // Before or On (Less Than or Equal To) or After (Greater Than)
                    string[] sVals = System.Text.RegularExpressions.Regex.Split(Value.ToString(), QueryBuilder.ItemDelimiter);
                    int index = 0;
                    _value = "";
                    foreach (string v in sVals)
                    {
                        if (index > 0)
                            _value += QueryBuilder.ItemDelimiter;
                        _value += System.DateTime.Parse(v.ToString(), CultureInfo.InvariantCulture).Date.AddDays(1).AddSeconds(-1).ToString();
                        index++;
                    }
                }
                else   // Between/Not Between
                {
                    // Split by Mini Rows
                    string[] sVals = System.Text.RegularExpressions.Regex.Split(Value.ToString(), QueryBuilder.ItemDelimiter);
                    int index = 0;
                    string[] sBetweenVals = null;
                    _value = "";
                    foreach (string v in sVals)
                    {
                        // Split by between separator
                        if (index > 0)
                            _value += QueryBuilder.ItemDelimiter;

                        sBetweenVals = v.Split(';');

                        if (sBetweenVals.Length == 2)
                            _value = System.DateTime.Parse(sBetweenVals[0].ToString(), CultureInfo.InvariantCulture).Date + ";" +
                                System.DateTime.Parse(sBetweenVals[1].ToString(), CultureInfo.InvariantCulture).Date.AddDays(1).AddSeconds(-1);
                        else
                            _value += v;

                        index++;
                    }
                }
            }
        }

        /// <summary>
        /// WhereClauseItem constructor
        /// </summary>
        /// <param name="field">Field Name</param>
        /// <param name="operator">Filter Operator</param>
        /// <param name="sql">Another SQL Builder that build a select SQL returns a value </param>
        public WhereClauseItem(string field, SqlOperators sqlOperator, QueryBuilder sql)
        {
            _field = field;
            _operator = sqlOperator;
            _value = null;
            _datatype = SQLDataTypes.String;
            _formatType = ColumnFormatting.None;
            _whereClause = "";
            _valueSql = sql;
            _valueIsExpression = false;
        }

        public WhereClauseItem(string whereClause)
        {
            _field = "";
            _operator = SqlOperators.EqualTo;
            _value = null;
            _datatype = SQLDataTypes.String;
            _formatType = ColumnFormatting.None;
            _whereClause = whereClause;
            _valueSql = null;
            _valueIsExpression = false;
        }

        private string sOperator
        {
            get { return QueryBuilder.OperatorToSQLString(_operator); }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="isParameterized"></param>
        /// <param name="Command"></param>
        /// <returns></returns>
        public string ToSQL(bool isParameterized, ref SQLCommand Command)
        {
            DateTime dateVal;

            string SQL = "( ";
            if (_whereClause != "") // user override by providing where clause
            {
                SQL += _whereClause;
                SQL += ")";
                return SQL;
            }
            if (_operator == SqlOperators.IsNull || _operator == SqlOperators.IsNotNull ||
                 _operator == SqlOperators.OPChecked || _operator == SqlOperators.OPUnchecked)
                SQL += _field + " " + sOperator;
            else if (_operator == SqlOperators.In || _operator == SqlOperators.NotIn)
            {
                SQL += _field + " " + sOperator + "(";
                if (this._value != null)
                {
                    if (isParameterized)
                    {
                        string[] sVals = _value.ToString().Split(',');
                        string param;

                        for (int i = 0; i < sVals.Length; i++)
                        {
                            param = "param_" + (Command.Parameters.Count + 1).ToString("000", CultureInfo.InvariantCulture);
                            if (i > 0)
                                SQL += ",";
                            SQL += " :@" + param;
                            Command.Add(new SQLParameter(param, sVals[i].Trim()));
                        }
                    }
                    else
                        SQL += _value;
                }
                if (this._valueSql != null)
                {
                    if (isParameterized)
                    {
                        _valueSql.Command = Command;
                        SQL += _valueSql.BuildSelectSQL(isParameterized);
                    }
                    else
                        SQL += _valueSql.ToSQL();
                }
                SQL += ")";
            }
            else // other operators
            {
                if (this._valueSql != null)
                {
                    SQL += _field + " " + sOperator + "(";
                    if (isParameterized)
                    {
                        _valueSql.Command = Command;
                        SQL += _valueSql.BuildSelectSQL(isParameterized) + ")";
                    }
                    else
                        SQL += _valueSql.ToSQL() + ")";
                }
                else
                {
                    string[] sVals;
                    sVals = System.Text.RegularExpressions.Regex.Split(_value.ToString(), QueryBuilder.ItemDelimiter);

                    string param;
                    for (int i = 0; i < sVals.Length; i++)
                    {
                        if (i > 0)
                        {
                            if (_operator == SqlOperators.NotEqualTo ||
                                _operator == SqlOperators.NotBetween ||
                                _operator == SqlOperators.OPNoneOfTheFollowing)
                                SQL += " AND ";
                            else
                                SQL += " OR ";
                        }
                        if (isParameterized && !_valueIsExpression)
                        {
                            if (_operator == SqlOperators.Between || _operator == SqlOperators.NotBetween)
                            {
                                string param1 = "param_" + (Command.Parameters.Count + 1).ToString("000", CultureInfo.InvariantCulture);
                                string param2 = "param_" + (Command.Parameters.Count + 2).ToString("000", CultureInfo.InvariantCulture);
                                string[] betweenVal = sVals[i].Split(';');
                                if (betweenVal.Length == 2)
                                {
                                    SQL += _field + " " + sOperator + ":@" + param1 + " AND " + ":@" + param2;
                                    switch (_datatype)
                                    {
                                        case SQLDataTypes.String:
                                            Command.Add(new SQLParameter(param1, ValueToSQLString(betweenVal[0].Trim(), true)));
                                            Command.Add(new SQLParameter(param2, ValueToSQLString(betweenVal[2].Trim(), true)));
                                            break;
                                        case SQLDataTypes.IntegerLong:
                                            Command.Add(new SQLParameter(param1, Convert.ToInt32(betweenVal[0].Trim(), CultureInfo.InvariantCulture)));
                                            Command.Add(new SQLParameter(param2, Convert.ToInt32(betweenVal[1].Trim(), CultureInfo.InvariantCulture)));
                                            break;
                                        case SQLDataTypes.SingleDouble:
                                            Command.Add(new SQLParameter(param1, Convert.ToDouble(betweenVal[0].Trim(), CultureInfo.InvariantCulture)));
                                            Command.Add(new SQLParameter(param2, Convert.ToDouble(betweenVal[1].Trim(), CultureInfo.InvariantCulture)));
                                            break;
                                        case SQLDataTypes.DateTime:
                                            if (_formatType == ColumnFormatting.TimeOnly)
                                            {
                                                // Create a new date using the time portion of the date passed
                                                // in, and use the date portion of the null date (12/30/1899)
                                                dateVal = Convert.ToDateTime(betweenVal[0].Trim(), CultureInfo.InvariantCulture);
                                                Command.Add(new SQLParameter(param1, new DateTime(QueryBuilder.NullDate.Year,
                                                                QueryBuilder.NullDate.Month, QueryBuilder.NullDate.Day,
                                                                dateVal.Hour, dateVal.Minute, dateVal.Second, dateVal.Millisecond)));

                                                dateVal = Convert.ToDateTime(betweenVal[1].Trim(), CultureInfo.InvariantCulture);
                                                Command.Add(new SQLParameter(param2, new DateTime(QueryBuilder.NullDate.Year,
                                                    QueryBuilder.NullDate.Month, QueryBuilder.NullDate.Day,
                                                    dateVal.Hour, dateVal.Minute, dateVal.Second, dateVal.Millisecond)));
                                            }
                                            else
                                            {
                                                Command.Add(new SQLParameter(param1, Convert.ToDateTime(betweenVal[0].Trim(), CultureInfo.InvariantCulture)));
                                                Command.Add(new SQLParameter(param2, Convert.ToDateTime(betweenVal[1].Trim(), CultureInfo.InvariantCulture)));
                                            }
                                            break;
                                    }
                                }
                            }
                            else
                            {
                                param = "param_" + (Command.Parameters.Count + 1).ToString("000", CultureInfo.InvariantCulture);
                                if (_operator == SqlOperators.In)
                                    SQL += _field + "=" + " :@" + param;
                                else if (_operator == SqlOperators.OPNoneOfTheFollowing)
                                    SQL += _field + "<>" + " :@" + param;
                                else
                                    SQL += _field + " " + sOperator + " :@" + param;

                                switch (_datatype)
                                {
                                    case SQLDataTypes.String:
                                        string parmVal = ValueToSQLString(sVals[i].Trim(), true);
                                        Command.Add(new SQLParameter(param, parmVal));
                                        if (parmVal.IndexOf("[", StringComparison.Ordinal) > -1 && (_operator == SqlOperators.StartsWith || _operator == SqlOperators.Contains))
                                            SQL += " ESCAPE '[' ";
                                        break;
                                    case SQLDataTypes.IntegerLong:
                                        Command.Add(new SQLParameter(param, Convert.ToInt32(sVals[i].Trim(), CultureInfo.InvariantCulture)));
                                        break;
                                    case SQLDataTypes.SingleDouble:
                                        Command.Add(new SQLParameter(param, Convert.ToDouble(sVals[i].Trim(), CultureInfo.InvariantCulture)));
                                        break;
                                    case SQLDataTypes.DateTime:
                                        if (_formatType == ColumnFormatting.TimeOnly)
                                        {
                                            // Create a new date using the time portion of the date passed
                                            // in, and use the date portion of the null date (12/30/1899)
                                            dateVal = Convert.ToDateTime(sVals[i].Trim(), CultureInfo.InvariantCulture);
                                            Command.Add(new SQLParameter(param, new DateTime(QueryBuilder.NullDate.Year,
                                                QueryBuilder.NullDate.Month, QueryBuilder.NullDate.Day,
                                                dateVal.Hour, dateVal.Minute, dateVal.Second, dateVal.Millisecond)));
                                        }
                                        else
                                            Command.Add(new SQLParameter(param, Convert.ToDateTime(sVals[i].Trim(), CultureInfo.InvariantCulture)));
                                        break;
                                }
                            }
                        }
                        else
                        {
                            if (_operator == SqlOperators.Between || _operator == SqlOperators.NotBetween)
                            {
                                string[] betweenVal = sVals[i].Split(';');
                                if (betweenVal.Length == 2)
                                {
                                    SQL += _field + " " + sOperator + ValueToSQLString(betweenVal[0].Trim(), false) + " AND " + ValueToSQLString(betweenVal[1].Trim(), false);
                                }
                            }
                            else if (_operator.Equals(SqlOperators.EqualToWithoutTrim))
                            {
                                SQL += _field + " " + sOperator + ValueToSQLString(sVals[i], false);
                            }
                            else
                                SQL += _field + " " + sOperator + ValueToSQLString(sVals[i].Trim(), false);
                        }
                    }
                }
            }
            SQL += " )";
            return SQL;
        }
        /// <summary>
        /// Used to Return a WhereclauseItem string that is not Parameterized and has no SQLCommandContext
        /// </summary>
        /// <returns></returns>
        public string ToSQL()
        {
            string SQL = "( ";
            if (_whereClause != "") // user override by providing where clause
            {
                SQL += _whereClause;
                SQL += ")";
                return SQL;
            }
            if (_operator == SqlOperators.IsNull || _operator == SqlOperators.IsNotNull ||
                 _operator == SqlOperators.OPChecked || _operator == SqlOperators.OPUnchecked)
                SQL += _field + " " + sOperator;
            else if (_operator == SqlOperators.In || _operator == SqlOperators.NotIn)
            {
                SQL += _field + " " + sOperator + "(";
                SQL += _value;
                SQL += ")";
            }
            else
            {
                string[] sVals;
                sVals = System.Text.RegularExpressions.Regex.Split(_value.ToString(), QueryBuilder.ItemDelimiter);

                for (int i = 0; i < sVals.Length; i++)
                {
                    if (i > 0)
                    {
                        if (_operator == SqlOperators.NotEqualTo ||
                            _operator == SqlOperators.NotBetween ||
                            _operator == SqlOperators.OPNoneOfTheFollowing)
                            SQL += " AND ";
                        else
                            SQL += " OR ";
                    }
                    if (_operator == SqlOperators.Between || _operator == SqlOperators.NotBetween)
                    {
                        string[] betweenVal = sVals[i].Split(';');
                        if (betweenVal.Length == 2)
                        {
                            SQL += _field + " " + sOperator + ValueToSQLString(betweenVal[0].Trim(), false) + " AND " + ValueToSQLString(betweenVal[1].Trim(), false);
                        }
                    }
                    else
                        SQL += _field + " " + sOperator + ValueToSQLString(sVals[i].Trim(), false);
                }
            }
            SQL += " )";
            return SQL;
        }
        /// <summary>
        /// ValueToSQLString
        /// </summary>
        /// <param name="val">value</param>
        /// <returns>SQL string</returns>
        private string ValueToSQLString(string val, bool isParameterized)
        {
            if (_valueIsExpression)
                return val;

            string Value = "";
            if (val == null)
                Value = "NULL";
            else if (_operator == SqlOperators.IsNull || _operator == SqlOperators.IsNotNull ||
                         _operator == SqlOperators.OPChecked || _operator == SqlOperators.OPUnchecked)
                Value = "";
            else
            {
                switch (_datatype)
                {
                    case SQLDataTypes.SingleDouble:
                    case SQLDataTypes.IntegerLong:
                        Value = val;
                        break;
                    case SQLDataTypes.String:
                    case SQLDataTypes.LongText:
                        if (!isParameterized)
                            Value = val.Replace("'", "''");
                        else
                            Value = val;

                        switch (_operator)
                        {
                            case SqlOperators.Contains:
                                Value = Value.Replace("[", "[[");
                                Value = Value.Replace("%", "[%");
                                Value = Value.Replace("_", "[_");
                                Value = "%" + Value + "%";
                                break;
                            case SqlOperators.StartsWith:
                                Value = Value.Replace("[", "[[");
                                Value = Value.Replace("%", "[%");
                                Value = Value.Replace("_", "[_");
                                Value = Value + "%";
                                break;
                        }
                        if (!isParameterized)
                        {
                            Value = "'" + Value + "'";
                            if ((_operator == SqlOperators.Contains || _operator == SqlOperators.StartsWith) && Value.IndexOf("[", StringComparison.Ordinal) > -1)
                                Value += " ESCAPE '['";
                        }
                        break;
                    case SQLDataTypes.DateTime:
                        if (!isParameterized)
                        {
                            Value = "%&SQLFormatDateTime(" + val + ")%";
                        }
                        else
                            Value = val;
                        break;
                }
            }
            return Value;
        }
    }
    #endregion

    #region JoinItem
    public class JoinItem
    {
        private string _table1;
        private string _field1;
        private string _table2;
        private string _field2;
        private JoinType _joinType;
        private string _conditionClause;

        public string Table1
        {
            get { return _table1; }
        }

        public string Field1
        {
            get { return _field1; }
        }

        public string Table2
        {
            get { return _table2; }
        }

        public string Field2
        {
            get { return _field2; }
        }

        public JoinType JoinType
        {
            get { return _joinType; }
        }

        public string ConditionClause
        {
            get { return _conditionClause; }
        }

        /// <summary>
        /// JoinItem contructor, build a regular join
        /// </summary>
        /// <param name="table1">Table 1</param>
        /// <param name="field1">Field 1</param>
        /// <param name="table2">Table 2</param>
        /// <param name="field2">Field 2</param>
        /// <param name="joinType">Join Type (can be regular join, outer join)</param>
        internal JoinItem(string table1, string field1, string table2, string field2, JoinType joinType)
        {
            _table1 = table1;
            _table2 = table2;
            _field1 = field1;
            _field2 = field2;
            _joinType = joinType;
        }

        /// <summary>
        /// JoinItem overloaded contructor, build a regular join 
        /// Added to have a condition with outer join query. fix for 36216
        /// </summary>
        /// <param name="table1"></param>
        /// <param name="field1"></param>
        /// <param name="table2"></param>
        /// <param name="field2"></param>
        /// <param name="joinType"></param>
        /// <param name="conditionClause"></param>
        internal JoinItem(string table1, string field1, string table2, string field2, JoinType joinType, string conditionClause)
        {
            _table1 = table1;
            _table2 = table2;
            _field1 = field1;
            _field2 = field2;
            _joinType = joinType;
            _conditionClause = conditionClause;
        }

        internal string ToSQL()
        {
            string s = "";
            if (_table1 != "")
                s += _table1 + ".";
            s += _field1 + " = ";
            if (_table2 != "")
                s += _table2 + ".";
            s += _field2;
            return s;
        }
    }
    #endregion


    #region OrderClauseItem
    internal struct OrderClauseItem
    {
        private string _field;
        private SortOrderTypes _order;

        internal OrderClauseItem(string fieldName, SortOrderTypes order)
        {
            _field = fieldName;
            _order = order;
        }

        internal string ToSQL()
        {
            if (_order == SortOrderTypes.Asc)
                return _field + " " + "ASC";
            else
                return _field + " " + "DESC";
        }
    }
    #endregion

    #region SetClauseItem
    internal struct SetClauseItem
    {
        internal string _field;
        internal object _value;
        internal bool _isfieldvalue;
        internal SQLDataTypes _datatype;
        internal SetClauseItem(string field, object value, SQLDataTypes dataType)
        {
            _field = field;
            _value = value;
            _datatype = dataType;
            _isfieldvalue = false;
        }

        internal SetClauseItem(string field, string fieldValue)
        {
            _field = field;
            _value = fieldValue;
            _datatype = SQLDataTypes.String;
            _isfieldvalue = true;
        }

        /// <summary>
        /// ValueToSQLString
        /// </summary>
        /// <param name="val">value</param>
        /// <returns>SQL string</returns>
        internal string ValueToSQLString(object val, bool isParameterized)
        {
            string Value = "";
            if (val == null)
                Value = "NULL";
            else
            {
                if (_isfieldvalue)
                {
                    Value = val.ToString();
                }
                else
                {
                    switch (_datatype)
                    {
                        case SQLDataTypes.SingleDouble:
                        case SQLDataTypes.IntegerLong:
                            Value = val.ToString();
                            break;
                        case SQLDataTypes.String:
                        case SQLDataTypes.LongText:
                            if (!isParameterized)
                                Value = "'" + val.ToString().Replace("'", "''") + "'";
                            else
                                Value = val.ToString();
                            break;
                        case SQLDataTypes.DateTime:
                            if (!isParameterized)
                                Value = "%&SQLFormatDateTime(" + val.ToString() + ")%";
                            else
                                Value = val.ToString();
                            break;
                    }
                }
            }
            return Value;
        }
        internal string ToSQL(bool isParameterized, ref SQLCommand Command)
        {
            string SQL = "";
            if (!isParameterized || _isfieldvalue)
                SQL += _field + " = " + ValueToSQLString(_value, false);
            else
            {
                string param = "param_" + (Command.Parameters.Count + 1).ToString("000", CultureInfo.InvariantCulture);

                SQL += _field + " = :@" + param;
                if (_value == null)
                    Command.Add(new SQLParameter(param, System.DBNull.Value));
                else
                {
                    switch (_datatype)
                    {
                        case SQLDataTypes.String:
                            Command.Add(new SQLParameter(param, ValueToSQLString(_value, true)));
                            break;
                        case SQLDataTypes.IntegerLong:
                            Command.Add(new SQLParameter(param, Convert.ToInt32(_value, CultureInfo.InvariantCulture)));
                            break;
                        case SQLDataTypes.SingleDouble:
                            Command.Add(new SQLParameter(param, Convert.ToDouble(_value, CultureInfo.InvariantCulture)));
                            break;
                        case SQLDataTypes.DateTime:
                            Command.Add(new SQLParameter(param, Convert.ToDateTime(_value, CultureInfo.InvariantCulture)));
                            break;
                    }
                }
            }
            return SQL;
        }
    }
    #endregion

    [Serializable()]
    public class ParameterItem
    {
        public string Name { get; set; }
        public DbType SqlType { get; set; }
        public object Value { get; set; }
        public bool IsOutParameter { get; set; }
        public int OutputSize { get; set; }

        public ParameterItem()
        {
            IsOutParameter = false;
        }
    }

    [Serializable()]
    public class SqlServerParameterItem : ParameterItem
    {
        public SqlDbType Type { get; set; }
    }

    [Serializable()]
    public class SQLParameter : object
    {
        private string m_Name = "";
        private object m_Value = null;

        public SQLParameter(string name, object value)
        {
            if (name.Length > 30)
                //throw new Exception("Parameter name too long (" + name + ").  Maximum length is 30 characters.");
                throw new DataLayerException("Parameter name too long (" + name + ").  Maximum length is 30 characters.");
            else
                m_Name = name;

            m_Value = value;
        }

        public string Name
        {
            get { return m_Name; }
            set
            {
                if (Name.Length > 30)
                    throw new DataLayerException("Parameter name too long (" + Name + ").  Maximum length is 30 characters.");
                //throw new Exception("Parameter name too long (" + Name + ").  Maximum length is 30 characters.");
                else
                    m_Name = value;
            }
        }


        public object Value
        {
            get { return m_Value; }
            set { m_Value = value; }
        }
    }
    [Serializable()]
    public class SQLCommand : object
    {
        private string m_Name = "";
        private string m_SQL = "";
        private string m_FormattedSQL = "";
        private TimeSpan m_CommandTime = new TimeSpan(0);
        private SQLType m_Type = SQLType.SelectSQL;
        private ArrayList m_ParameterGroups = new ArrayList();
        private SQLParameterGroup m_CurrentGroup = null;
        private Int32 m_CmdTimeout = m_defaultCmdTimeout;
        protected static Int32 m_defaultCmdTimeout = 60;

        protected static void InitTimeout()
        {
        }

        static SQLCommand()
        {
            InitTimeout();
        }

        public SQLCommand(string name, string sql, SQLType type)
            : base()
        {
            m_Name = name;
            m_SQL = sql;
            m_Type = type;
            AddGroup(new SQLParameterGroup());
        }
        public SQLCommand(string name, string sql, SQLType type, Int32 commandTimeout)
            : base()
        {
            m_Name = name;
            m_SQL = sql;
            m_Type = type;
            m_CmdTimeout = commandTimeout;
            AddGroup(new SQLParameterGroup());
        }

        public SQLCommand(string name, SQLCommand template)
        {
            m_Name = name;
            m_SQL = template.SQL;
            m_Type = template.CommandType;

            foreach (SQLParameterGroup Group in template.m_ParameterGroups)
            {

                AddGroup(new SQLParameterGroup());

                foreach (SQLParameter Parm in Group)
                {
                    Add(new SQLParameter(Parm.Name, Parm.Value));
                }
            }

            m_CurrentGroup = (SQLParameterGroup)m_ParameterGroups[0];
        }

        public string CommandName
        {
            get { return m_Name; }
            set { m_Name = value; }
        }

        public SQLType CommandType
        {
            get { return m_Type; }
            set { m_Type = value; }
        }


        public string SQL
        {
            get { return m_SQL; }
            set { m_SQL = value; }
        }

        public string FormattedSQL
        {
            get { return m_FormattedSQL; }
            set { m_FormattedSQL = value; }
        }

        public TimeSpan CommandTime
        {
            get { return m_CommandTime; }
            set { m_CommandTime = value; }
        }

        public ArrayList ParameterGroups
        {
            get { return m_ParameterGroups; }
            set { m_ParameterGroups = value; }
        }

        public Collection<SQLParameter> Parameters
        {
            get { return m_CurrentGroup; }
        }

        public Int32 CommandTimeout
        {
            get { return m_CmdTimeout; }
            set { m_CmdTimeout = value; }
        }



        public void Add(SQLParameter newParm)
        {
            m_CurrentGroup.Add(newParm);
        }

        public void Insert(int index, SQLParameter newParm)
        {
            m_CurrentGroup.Insert(index, newParm);
        }

        public void AddGroup(SQLParameterGroup newGroup)
        {
            if (m_CurrentGroup == null || m_CurrentGroup.Count > 0) // only add the new group when the current group already has parameters, we do not want leave an empty group
            {
                m_CurrentGroup = newGroup;
                m_ParameterGroups.Add(newGroup);
            }
        }
    }
    [Serializable()]
    public class SQLSelectCommand : SQLCommand
    {
        private int m_StartRecord = 0;
        private int m_MaxCount = 0;
        private bool m_DirtyRead = false;

        static SQLSelectCommand()
        {
            InitTimeout();
        }
        public SQLSelectCommand(string name, SQLCommand template) : base(name, template) { }

        public SQLSelectCommand(string name, string sql) : base(name, sql, SQLType.SelectSQL) { }

        public SQLSelectCommand(string name, string sql, Int32 commandTimeout) : base(name, sql, SQLType.SelectSQL, commandTimeout) { }

        public SQLSelectCommand(string name, string sql, int startRecord, int maxCount)
            : base(name, sql, SQLType.SelectSQL)
        {
            m_StartRecord = startRecord;
            m_MaxCount = maxCount;
        }

        public int StartRecord
        {
            get { return m_StartRecord; }
            set { m_StartRecord = value; }
        }

        public int MaxCount
        {
            get { return m_MaxCount; }
            set { m_MaxCount = value; }
        }

        public bool DirtyRead
        {
            get { return m_DirtyRead; }
            set { m_DirtyRead = value; }
        }
    }
    [Serializable()]
    public class SQLInsertCommand : SQLCommand
    {
        static SQLInsertCommand()
        {
            InitTimeout();
        }
        public SQLInsertCommand(string name, string sql) : base(name, sql, SQLType.InsertSQL) { }

        public SQLInsertCommand(string name, string sql, Int32 commandTimeout) : base(name, sql, SQLType.InsertSQL, commandTimeout) { }

        public SQLInsertCommand(string name, SQLCommand template) : base(name, template) { }
    }
    [Serializable()]
    public class SQLUpdateCommand : SQLCommand
    {
        static SQLUpdateCommand()
        {
            InitTimeout();
        }
        public SQLUpdateCommand(string name, string sql) : base(name, sql, SQLType.UpdateSQL) { }

        public SQLUpdateCommand(string name, string sql, Int32 commandTimeout) : base(name, sql, SQLType.UpdateSQL, commandTimeout) { }

        public SQLUpdateCommand(string name, SQLCommand template) : base(name, template) { }
    }
    [Serializable()]
    public class SQLDeleteCommand : SQLCommand
    {
        static SQLDeleteCommand()
        {
            InitTimeout();
        }
        public SQLDeleteCommand(string name, string sql) : base(name, sql, SQLType.DeleteSQL) { }

        public SQLDeleteCommand(string name, string sql, Int32 commandTimeout) : base(name, sql, SQLType.DeleteSQL, commandTimeout) { }

        public SQLDeleteCommand(string name, SQLCommand template) : base(name, template) { }
    }



    [Serializable()]
    public class SQLParameterGroup : Collection<SQLParameter>
    {
        public SQLParameterGroup()
            : base()
        {
        }


        //public void Add(SQLParameter newParm)
        //{
        //    base.Add(newParm);
        //}

        //public void Insert(int index, SQLParameter newParm)
        //{
        //    base.Insert(index, newParm);
        //}

        public int GetIndexOfName(string name)
        {
            int val = 0;
            foreach (SQLParameter p in this)
            {
                if (p.Name.ToUpperInvariant() == name.ToUpperInvariant())
                    return val;
                else
                    val++;
            }
            return -1;
        }

        //public bool Contains(object item)
        //{
        //    foreach (SQLParameter p in this)
        //    {
        //        if (p.Name == item.ToString())
        //            return true;
        //    }
        //    return false;
        //}

        //public bool Contains(SQLParameter item)
        //{
        //    foreach (SQLParameter p in this)
        //    {
        //        if (p.Name == item.Name)
        //            return true;
        //    }
        //    return false;
        //}

        //public void Remove(SQLParameter value)
        //{
        //    ((IList)this).Remove((object)value);
        //}




    }
}
