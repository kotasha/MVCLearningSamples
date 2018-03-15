using System;
using System.Globalization;
using System.Text;
using System.Collections.ObjectModel;
using System.Collections.Generic;

namespace Kotacs.Libraries.Common
{
    public static class DataHelper
    {
        #region Public Methods
        /// <summary>
        /// Create SQL LIKE operation surrounding passed in value
        /// </summary>
        /// <param name="table">table or table-alias name</param>
        /// <param name="field">field name</param>
        /// <param name="value">string to be compared(in SQL)</param>
        /// <returns>fully formed string with SQL LIKE operation</returns>
        public static string Like(string table, string field, string value)
        {
            return string.Concat(table, ".", field, " LIKE ", value);
        }

        /// <summary>
        /// Create SQL IN clause when passed a Select Query
        /// </summary>
        /// <param name="field">field name</param>
        /// <param name="value">subquery to be added to in clause </param>
        /// <returns>fully formed string with SQL IN clause and query</returns>
        public static string In(string field, string value)
        {
            return string.Concat(field, " IN ( ", value, ")");
        }

        /// <summary>
        /// Create SQL NOT IN clause when passed a Select Query
        /// </summary>
        /// <param name="field">field name</param>
        /// <param name="value">subquery to be added to not in clause</param>
        /// <returns>fully formed string with SQL NOT IN clause and query</returns>
        public static string NotIn(string field, string value)
        {
            return string.Concat(field, " NOT IN ( ", value, ")");
        }

        /// <summary>
        /// Create SQL IN clause when passed a Select Query
        /// </summary>
        /// <param name="table">table or table-alias name</param>
        /// <param name="field">field name</param>
        /// <param name="value">subquery to be added to in clause </param>
        /// <returns>fully formed string with SQL IN clause and query</returns>
        public static string In(string table, string field, string value)
        {
            return string.Concat(table, ".", field, " IN ( ", value, ")");
        }

        /// <summary>
        /// Create SQL BETWEEN clause for passed in values
        /// </summary>
        /// <param name="table">table or table-alias name</param>
        /// <param name="field">field name</param>
        /// <returns>fully formed string with SQL LIKE operation</returns>
        public static string Between(string table, string field, string fromValue, string toValue)
        {
            return string.Concat(table, ".", field, " BETWEEN ( ", fromValue, " ) AND ( ", toValue, ")");
        }

        /// <summary>
        /// Create SQL BETWEEN clause for passed in values
        /// </summary>
        /// <param name="table">table or table-alias name</param>
        /// <param name="field">field name</param>
        /// <returns>fully formed string with SQL LIKE operation</returns>
        public static string Between(string field, string fromValue, string toValue)
        {
            return string.Concat(field, " BETWEEN ( ", fromValue, " ) AND ( ", toValue, ")");
        }

        /// <summary>
        /// Create SQL ROWNUMBER when passed table/alias and a field
        /// </summary>
        /// <param name="table">table or table-alias name</param>
        /// <param name="field">field name</param>
        /// <returns>fully formed string with row-number function</returns>
        public static string RowNumber(string table, string field)
        {
            return string.Concat("ROW_NUMBER() OVER (ORDER BY ", table, ".", field, ") AS ", DataConstants.RowNumberAlias);
        }

        public static string RowNumber(string field)
        {
            return string.Concat("ROW_NUMBER() OVER (ORDER BY ", field, ") AS ", DataConstants.RowNumberAlias);
        }

        public static string RowNumber(string field, SortDirection sortDirection)
        {
            return string.Concat("ROW_NUMBER() OVER (ORDER BY ", field, " ", Enum.GetName(typeof(SortDirection), sortDirection), " ) AS ", DataConstants.RowNumberAlias);
        }

        public static string RowNumber(string table, string field, SortDirection sortDirection)
        {
            return string.Concat("ROW_NUMBER() OVER (ORDER BY ", table, ".", field, " ", Enum.GetName(typeof(SortDirection), sortDirection), " ) AS ", DataConstants.RowNumberAlias);
        }

        public static string RowNumber(string[] field, SortDirection[] sortDirection)
        {
            string orderBySring = "ROW_NUMBER() OVER (ORDER BY ";
            for (int i = 0; i < field.Length; i++)
            {
                if (sortDirection.Length >= i)
                {
                    orderBySring = string.Concat(orderBySring, field[i], " ", sortDirection[i]);
                }
                else
                {
                    orderBySring = string.Concat(orderBySring, field[i], " ", SortDirection.Asc);
                }

                if (field.Length > i + 1)
                {
                    orderBySring = string.Concat(orderBySring, ",");
                }
                else
                {
                    orderBySring = string.Concat(orderBySring, ") AS ", DataConstants.RowNumberAlias);
                }
            }
            return orderBySring;
        }


        /// <summary>
        /// Create SQL ORDER BY - FOR XML statment when passed a table/alias and a field
        /// </summary>
        /// <param name="table">table or table-alias name</param>
        /// <param name="field">field name</param>
        /// <returns>fully formed string with ORDER BY alias.field and FOR XML </returns>
        public static string OrderByForXml(string table, string field)
        {
            return string.Concat(" ORDER BY ", table, ".", field, " FOR XML PATH('') ");
        }

        /// <summary>
        /// Create SQL function call to pad numeric values 
        /// </summary>
        /// <param name="table">table or alias of the field to be padded</param>
        /// <param name="field">field to be padded</param>
        /// <param name="totalLength">length to be padded to</param>
        /// <param name="decimalLenght">number of decimal places supported</param>
        /// <returns></returns>
        public static string PadNumber(string table, string field, int totalLength, int decimalLength)
        {
            return string.Concat("REPLACE( STR( ", table, ".",
              field, ", ", totalLength.ToString(CultureInfo.InvariantCulture), ", ", decimalLength.ToString(CultureInfo.InvariantCulture), "), ' ', '0')");
        }

        /// <summary>
        /// Create SQL SUM function call
        /// </summary>
        /// <param name="table">table or alias of the field to be summed</param>
        /// <param name="field">field to be summed</param>
        public static string Sum(string table, string field)
        {
            return string.Concat(" SUM ( ", table, ".", field, " ) ");
        }

        /// <summary>
        /// Create SQL SUM function call
        /// </summary>	
        /// <param name="field">field to be summed</param>
        public static string Sum(string field)
        {
            return string.Concat(" SUM ( ", field, " ) ");
        }

        /// <summary>
        /// Create SQL COUNT function call
        /// </summary>	
        /// <param name="field">field to be counted</param>
        public static string Count(string field)
        {
            return string.Concat(" COUNT ( ", field, " ) ");
        }


        /// <summary>
        /// Surround the string with brackets
        /// </summary>
        /// <param name="query">query builder to be bracketed</param>
        /// <returns>bracketed querys string </returns>
        public static string Bracket(string value)
        {
            return string.Concat(" ( ", value, " ) ");
        }

        /// <summary>
        /// Create SQL WHERE clause for matching fields in within the query 
        /// </summary>
        public static string WhereEqual(string table1, string field1, string table2, string field2)
        {
            return string.Concat(table1, ".", field1, " = ", table2, ".", field2);
        }

        /// <summary>
        /// Create SQL ISNULL for checking fields with NULL values
        /// </summary>
        /// <param name="field">Field to be checked for NULL</param>
        /// <returns></returns>
        public static string IsColumnValueNull(string field)
        {
            return string.Concat(" ISNULL ( ", field, ",'') ");
            //switch (dataType) 
            //{

            //  case DataType.Integer:
            //   return string.Concat(" ISNULL ( ", field, ",0) ");
            //   break;
            //  case DataType.String:
            //   return string.Concat(" ISNULL ( ", field, ", 0) ");
            //    break;
            //  case DataType.DateTime:
            //    return string.Concat(" ISNULL ( ", field, ",0) ");
            //    break;
            //  default:
            //    break;
            //}

        }

        /// <summary>
        /// Create SQL ISNULL for checking fields with NULL values and return another field
        /// </summary>
        /// <param name="field">Field to be checked for NULL</param>
        /// <returns></returns>
        public static string IsColumnValueNull(string field, string returnField)
        {
            return string.Concat(" ISNULL ( ", field, ",", returnField, ") ");

        }

        //public static string IsNull(string field)
        //{
        //  return string.Concat(" ISNULL ( ", field, ",0) ");
        //}
        public static string IsNull(string field)
        {
            return string.Concat(" ISNULL ( ", field, ",0) ");
        }


        /// <summary>
        /// Create SQL to check IS NULL for fields 
        /// </summary>
        /// <param name="field">Field to be checked for NULL</param>
        /// <returns></returns>
        public static string CheckIsNull(string field)
        {
            return string.Concat(field, " IS NULL ");
        }

        /// <summary>
        /// Create SQL to check IS NOT NULL for fields 
        /// </summary>
        /// <param name="field">Field to be checked for NOT NULL</param>
        /// <returns></returns>
        public static string CheckIsNotNull(string table, string field)
        {
            return string.Concat(table, ".", field, " IS NOT NULL ");
        }

        /// <summary>
        /// Get month from a Date
        /// </summary>
        /// <param name="date">Date to get the month</param>
        /// <returns>Month</returns>
        public static string Month(string date)
        {
            return string.Concat(" MONTH ( ", date, " ) ");
        }


        /// <summary>
        /// Get year from a Date
        /// </summary>
        /// <param name="date">Date to get the Year</param>
        /// <returns>Year</returns>
        public static string Year(string date)
        {
            return string.Concat(" YEAR ( ", date, " ) ");
        }

        public static string YearMonth(string date)
        {
            return string.Concat(" CONVERT(varchar(4),", Year(date), ")+ '/' +CONVERT(varchar(4),", Month(date), ")");
        }

        public static string Sysdate()
        {
            return string.Concat(" sysdate");
        }


        /// <summary>
        /// Create SQL qualified field when passed table/alias and a field
        /// </summary>
        /// <param name="table">table or table-alias name</param>
        /// <param name="fieldname">field name</param>
        /// <returns>fully formed string with alias.field </returns>
        public static string Field(string table, string fieldname)
        {
            return string.Concat(table, ".", fieldname);
        }

        /// <summary>
        /// Create SQL string to get difference between Dates in minutes
        /// </summary>
        /// <param name="startTime">Start Time</param>
        /// <param name="endTime">End Time</param>
        /// <returns>Sql DateDiff string</returns>
        public static string DateDifference(string startTime, string endTime)
        {
            return string.Concat(" DATEDIFF (minute, ", startTime, ", ", endTime, ") ");
        }

        public static string DateDifference(string interval, string startTime, string endTime)
        {
            return string.Concat(" DATEDIFF (", interval, ",", startTime, ", ", endTime, ") ");
        }

        /// <summary>
        /// Create SQL MAX function call
        /// </summary>	
        /// <param name="field">field to be counted</param>
        public static string Max(string field)
        {
            return string.Concat(" MAX(", field, ") ");
        }

        /// <summary>
        /// Create Oracle To_DATE function call
        /// </summary>	
        /// <param name="field">field to be counted</param>
        public static string OracleToDate(string field)
        {
            return string.Concat(" TO_DATE(", field, ") ");
        }

        /// <summary>
        /// Create SQL Top # for rows
        /// </summary>	
        /// <param name="topRows">number of rows to be rerurned</param>
        /// <param name="table">table or table-alias name</param>
        /// <param name="field">field name</param>
        public static string Top(int topRows, string table, string field)
        {
            return string.Concat(" TOP ", topRows.ToString(CultureInfo.InvariantCulture), " ", table, ".", field);
        }

        /// <summary>
        /// Create SQL Top PERCENT for rows
        /// </summary>
        /// <param name="rowsPercent">percentage of rows to be rerurned</param>
        /// <param name="table">table or table-alias name</param>
        /// <param name="field">field name</param>
        /// <param name="alias">field alias</param>
        /// <returns></returns>
        public static string TopPercent(int rowsPercent, string table, string field, string alias)
        {
            return string.Concat(" TOP ", rowsPercent.ToString(CultureInfo.InvariantCulture), " PERCENT ", table, ".", field, " AS ", alias);
        }

        /// <summary>
        /// Create SQL Begin with clause when passed a Select Query
        /// </summary>	
        /// <param name="value">Value</param>
        /// <param name="field">field name</param>
        public static string BeginWith(string field, string value)
        {
            return string.Concat(field, " LIKE '", value, "%'");
        }

        /// <summary>
        /// Create SQL Does Not Begin with clause when passed a Select Query
        /// </summary>	
        /// <param name="value">Value</param>
        /// <param name="field">field name</param>
        public static string DoesNotBeginWith(string field, string value)
        {
            return string.Concat(field, " NOT LIKE '", value, "%'");
        }

        /// <summary>
        /// Create SQL End with clause when passed a Select Query
        /// </summary>	
        /// <param name="value">Value</param>
        /// <param name="field">field name</param>
        public static string EndWith(string field, string value)
        {
            return string.Concat(field, " LIKE '%", value, "'");
        }

        /// <summary>
        /// Create SQL Does Not End with clause when passed a Select Query
        /// </summary>	
        /// <param name="value">Value</param>
        /// <param name="field">field name</param>
        public static string DoesNotEndWith(string field, string value)
        {
            return string.Concat(field, " NOT LIKE '%", value, "'");
        }

        /// <summary>
        /// Create SQL Does Not Equal clause when passed a Select Query
        /// </summary>	
        /// <param name="value">Value</param>
        /// <param name="field">field name</param>
        public static string DoesNotEqualTo(string field, string value)
        {
            return string.Concat(field, " <> ", value);
        }

        /// <summary>
        /// Create SQL  Equal clause when passed a Select Query
        /// </summary>	
        /// <param name="value">Value</param>
        /// <param name="field">field name</param>
        public static string EqualTo(string field, string value)
        {
            return string.Concat(field, " = ", value);
        }

        /// <summary>
        /// Create SQL contains with clause when passed a Select Query
        /// </summary>	
        /// <param name="value">Value</param>
        /// <param name="field">field name</param>
        public static string Contain(string field, string value)
        {
            return string.Concat(field, " LIKE '%", value, "%'");
        }

        /// <summary>
        /// Create SQL Does Not contains with clause when passed a Select Query
        /// </summary>	
        /// <param name="value">Value</param>
        /// <param name="field">field name</param>
        public static string DoesNotContain(string field, string value)
        {
            return string.Concat(field, " NOT LIKE '%", value, "%'");
        }

        /// <summary>
        /// Create SQL greater than clause when passed a Select Query
        /// </summary>	
        /// <param name="value">Value</param>
        /// <param name="field">field name</param>
        public static string GreaterThan(string field, string value)
        {
            return string.Concat(field, " > ", value);
        }

        /// <summary>
        /// Create SQL greater than or equal clause when passed a Select Query
        /// </summary>	
        /// <param name="value">Value</param>
        /// <param name="field">field name</param>
        public static string GreaterThanOrEqualTo(string field, string value)
        {
            return string.Concat(field, " >= ", value);
        }

        /// <summary>
        /// Create SQL less than clause when passed a Select Query
        /// </summary>	
        /// <param name="value">Value</param>
        /// <param name="field">field name</param>
        public static string LessThan(string field, string value)
        {
            return string.Concat(field, " < ", value);
        }

        /// <summary>
        /// Create SQL less than or equal clause when passed a Select Query
        /// </summary>	
        /// <param name="value">Value</param>
        /// <param name="field">field name</param>
        public static string LessThanOrEqualTo(string field, string value)
        {
            return string.Concat(field, " <= ", value);
        }


        /// <summary>
        /// Create SQL string clause when passed a value
        /// </summary>	
        /// <param name="value">Value</param>
        public static string String(string value)
        {
            return string.Concat("'", value, "'");
        }


        /// <summary>
        /// Create SQL string clause when passed a value
        /// </summary>
        /// <param name="values"></param>
        /// <returns></returns>
        public static string String(string[] values)
        {
            StringBuilder sqlClause = new StringBuilder();
            foreach (string value in values)
            {
                sqlClause.Append("'");
                sqlClause.Append(value);
                sqlClause.Append("',");
            }
            // remove last added string "," from the constructed string.
            sqlClause.Remove(sqlClause.Length - 1, 1);
            return sqlClause.ToString();
        }

        /// <summary>
        /// Create SQL field enclosed with [] clause when field name
        /// </summary>	
        /// <param name="value">Value</param>
        /// <param name="field">field name</param>
        public static string FieldName(string field)
        {
            return string.Concat("[", field, "]");
        }

        public static string FieldName(string field, string extension)
        {
            return string.Concat("[", field, extension, "]");
        }


        /// <summary>
        /// Create SQL for extracting the datepart from date-time 
        /// </summary>	
        /// <param name="field">field name</param>
        public static string DatePartOnly(string field)
        {
            return string.Concat("DATEADD(dd, 0, DATEDIFF(dd, 0, ", field, "))");
        }

        public static String DateToString(string dateFieldName)
        {
            return string.Concat("Convert(varchar(20),", dateFieldName, ",101)");
        }

        //To fix the Defect#: 132560
        public static String DateTimeToString(string dateFieldName)
        {
            return string.Concat("CONVERT(VARCHAR(20), ", dateFieldName, ", 22)");
        }


        /// <summary>
        /// Used to convert the columnn in to case sensitive 
        /// </summary>
        /// <param name="field"></param>
        /// <returns></returns>
        public static string ConvertToCaseSensitive(string field)
        {
            return string.Concat(field, DataConstants.SqlSpace, "COLLATE", DataConstants.SqlSpace, "SQL_Latin1_General_CP1_CS_AS");
        }

        /// <summary>
        /// Create SQL string clause to create CASE statement
        /// </summary>
        /// <param name="condition"></param>
        /// <param name="trueValue"></param>
        /// <param name="falseValue"></param>
        /// <param name="alias"></param>
        /// <returns>SQL Clause</returns>
        public static string Case(string condition, string trueValue, string falseValue, string alias)
        {
            return string.Concat("CASE WHEN ", condition, " THEN ", trueValue, " ELSE ", falseValue, " END AS ", alias);
        }

        /// <summary>
        /// Create SQL string clause to create CASE statement without alias
        /// </summary>
        /// <param name="condition"></param>
        /// <param name="trueValue"></param>
        /// <param name="falseValue"></param>
        /// <param name="alias"></param>
        /// <returns>SQL Clause</returns>
        public static string CountIf(string condition)
        {
            return string.Concat("SUM(CASE WHEN ", condition, " THEN 1 ELSE 0 END) ");
        }

        /// <summary>
        /// Create SQL string clause to create Multiple CASE statement 
        /// </summary>
        /// <param name="conditions">conditions</param>
        /// <param name="falseValue">negative clause</param>
        /// <param name="alias">column name</param>
        /// <returns></returns>
        public static string CaseMultiple(Dictionary<string, string> conditions, string falseValue, string alias)
        {
            StringBuilder queryText = new StringBuilder();
            queryText.AppendLine("CASE ");

            foreach (var pair in conditions)
            {
                queryText.AppendLine(string.Concat("WHEN ", pair.Key, " THEN ", pair.Value));
            }

            if (conditions.Count > 0)
            {
                queryText.AppendLine(string.Concat(" ELSE ", falseValue));
            }
            queryText.AppendLine(string.Concat(" END AS ", alias));

            return queryText.ToString();

        }

        /// <summary>
        /// Create SQL string clause to create CASE statment with boolean result
        /// </summary>
        /// <param name="condition"></param>
        /// <param name="alias"></param>
        /// <returns></returns>
        public static string CaseBoolean(string condition, string alias)
        {
            return Case(condition, "1", "0", alias);
        }

        public static string DatePart(string field, string datePart)
        {
            return string.Concat("DATEPART(", datePart, ",", field, ")");
        }

        /// <summary>
        /// Create SQL string clause to create date boundary check
        /// </summary>
        /// <param name="startingDate"></param>
        /// <param name="endingDate"></param>
        /// <param name="difference"></param>
        /// <returns></returns>
        public static string VerifyDateBoundry(string startingDate, string endingDate, int difference)
        {
            return string.Concat(DateDifference("d", startingDate, endingDate), "<=", difference.ToString(CultureInfo.InvariantCulture));
        }

        /// <summary>
        /// Create SQL string clause to remove last character from a field
        /// </summary>
        /// <param name="field"></param>
        /// <returns></returns>
        public static string RemoveLastCharacter(string field)
        {
            return string.Concat(" LEFT(", field, ", LEN(", field, ")-1)");
        }

        /// <summary>
        /// Create SQL string clause to check a given date field contains a past date
        /// </summary>
        /// <param name="dateField"></param>
        /// <returns></returns>
        public static string IsPastDate(string dateField)
        {
            return string.Concat(" DATEDIFF ( dd , GETDATE(),DATEADD(dd, 1, DATEDIFF(dd, 0,", dateField, "))) > 0 ");
        }

        /// <summary>
        /// Create SQL contains with full text searrch contains query
        /// </summary>	
        /// <param name="value">Value</param>
        /// <param name="field">field name</param>
        public static string FullTextSearchContains(string table, string field, string searchParameter)
        {
            return string.Concat(" CONTAINS(", table, ".", field, ",", searchParameter, ") ");
        }

        public static string FullTextSearchFormOf(string searchParameter)
        {
            return string.Concat(" FORMSOF (INFLECTIONAL,", searchParameter, ") ");
        }

        public static string FullTextSearchFreeText(string table, string field, string searchParameter)
        {
            return string.Concat(" FREETEXT(", table, ".", field, ",", searchParameter, ") ");
        }

        public static string FullTextSearchPrefixTerm(string searchParameter)
        {
            return string.Concat("\"", searchParameter, "*", "\"");
        }

        /// <summary>
        /// Get a string replaced with % if a string contains * else add % by the side 
        /// </summary>
        /// <param name="originalString">Original string</param>
        /// <returns>% added string</returns>
        public static string GetSqlWildCardedString(string originalString)
        {
            if (originalString.Contains(DataConstants.Asterisk))
                return originalString.Replace(DataConstants.Asterisk, DataConstants.SqlLikeAny);
            else
                return string.Concat(DataConstants.SqlLikeAny, originalString, DataConstants.SqlLikeAny);
        }

        public static string Floor(string ailas, string field)
        {
            return string.Concat("FLOOR(", ailas, ".", field, ")");
        }

        /// <summary>
        /// Create SQL  EXISTS for WHERE clause when passed a Select Query
        /// </summary>
        /// <param name="query">Select Query</param>
        /// <returns>SQL  EXISTS for WHERE clause</returns>
        public static string Exists(string query)
        {
            return " EXISTS ( " + query + ")";
        }

        public static string Intersect()
        {
            return " INTERSECT ";
        }

        #endregion

    }

    public enum SortDirection
    {
        Asc = 0,
        Desc = 1,
    }
}
