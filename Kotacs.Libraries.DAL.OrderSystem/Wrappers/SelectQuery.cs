using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Kotacs.Libraries.Common;
using System.Globalization;
using System.Collections.ObjectModel;
namespace Kotacs.Libraries.DAL.OrderSystem.Wrappers
{

    public class SelectQuery : QueryBase
    {
        #region Private Constants

        private const string pagedTableName = "PagedTable";
        private const string newPagedTableName = "NewPagedTable";
        private const string rowNumberColumnName = "Row";
        private const string rowNumberColumnNameForOracle = "RowName";

        #endregion


        /// <summary>
        /// Constructor Method
        /// </summary>
        /// <param name="name">string</param>
        public SelectQuery(string name)
            : base(name, SQLType.SelectSQL)
        {

        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns>an instance of SelectSubQuery</returns>
        public SelectSubQuery AsSubQuery()
        {
            return new SelectSubQuery(this);
        }
        /// <summary>
        /// An Override Method
        /// </summary>
        /// <param name="table">SqlTableBase </param>
        public override void AddTable(SqlTableBase table)
        {
            this.QueryBuilder.AddTable(table.TableName, table.Alias);
        }

        public void ApplyPaginationForOracle(string orderByFieldAlias, SortOrderTypes sortDirection, int startRow, int endRow)
        {
            //add order by clause
            this.AddOrderByClause(orderByFieldAlias, sortDirection);

            //Create a new query builder for paged query
            QueryBuilder pagedQueryBuilder = new QueryBuilder(SQLType.SelectSQL, this.Name);

            //Add current query builder as an inner query to new query builder
            pagedQueryBuilder.AddTable(this.QueryBuilder, pagedTableName);

            //Add all columns to new query builder
            foreach (var fieldName in this.FieldNames)
            {
                pagedQueryBuilder.AddField(pagedTableName, fieldName, fieldName);
            }

            //Add row number column to the new query builder
            //TO DO:Add this to the Data Helper
            pagedQueryBuilder.AddField("ROWNUM AS " + rowNumberColumnNameForOracle);

            this.QueryBuilder = pagedQueryBuilder;

            //Add new query builder as an inner query to ANOTHER new query builder
            QueryBuilder newPagedQueryBuilder = new QueryBuilder(SQLType.SelectSQL, this.Name);
            newPagedQueryBuilder.AddTable(pagedQueryBuilder, newPagedTableName);

            foreach (var fieldName in this.FieldNames)
            {
                if (fieldName != rowNumberColumnNameForOracle)
                {
                    newPagedQueryBuilder.AddField(newPagedTableName, fieldName, fieldName);
                }
            }
            //Add pagination where clause to new query builder
            newPagedQueryBuilder.AddWhereClauseItem(DataHelper.Between(rowNumberColumnNameForOracle, startRow.ToString(CultureInfo.InvariantCulture), endRow.ToString(CultureInfo.InvariantCulture)));

            this.QueryBuilder = newPagedQueryBuilder;
        }

        /// <summary>
        /// Apply paginiation to the query
        /// </summary>
        /// <param name="orderByField">filed to sort the data, in order to get page numbers</param>
        /// <param name="sortDirection">sort direction</param>
        /// <param name="startRow">page start row</param>
        /// <param name="endRow">page end row</param>
        public void ApplyPagination(SqlExpressionBase orderByField, SortDirection sortDirection, SqlExpressionBase startRow, SqlExpressionBase endRow)
        {
            //Add row number column to the current query builder
            this.QueryBuilder.AddField(DataHelper.RowNumber(orderByField.ToString(), sortDirection));

            WrapInOuterQuery();

            //Add pagination where clause to new query builder
            this.QueryBuilder.AddWhereClauseItem(DataHelper.Between(rowNumberColumnName, startRow.ToString(), endRow.ToString()));
        }


        /// <summary>
        /// Wrapp the current Query Builder in an outer query
        /// </summary>
        public void WrapInOuterQuery()
        {
            //Create a new query builder for paged query
            QueryBuilder pagedQueryBuilder = new QueryBuilder(SQLType.SelectSQL, this.Name);

            //Add current query builder as an inner query to new query builder
            pagedQueryBuilder.AddTable(this.QueryBuilder, pagedTableName);

            //Add all columns to new query builder
            foreach (var fieldName in this.FieldNames)
            {
                pagedQueryBuilder.AddField(pagedTableName, fieldName, fieldName);
            }

            //Add all parameters to new query builder
            foreach (var parameter in this.QueryBuilder.Parameters)
            {
                pagedQueryBuilder.Parameters.Add(parameter);
            }

            //Replace curretn query builder with new query builder
            this.QueryBuilder = pagedQueryBuilder;
            this.Name = pagedTableName;
        }

        public void WrappWithoutColumns()
        {
            //Create a new query builder for paged query
            QueryBuilder pagedQueryBuilder = new QueryBuilder(SQLType.SelectSQL, this.Name);

            //Add current query builder as an inner query to new query builder
            pagedQueryBuilder.AddTable(this.QueryBuilder, pagedTableName);

            //Add all parameters to new query builder
            foreach (var parameter in this.QueryBuilder.Parameters)
            {
                pagedQueryBuilder.Parameters.Add(parameter);
            }

            //Replace curretn query builder with new query builder
            this.QueryBuilder = pagedQueryBuilder;
            this.Name = pagedTableName;
        }

        /// <summary>
        /// Apply paginiation to the query
        /// </summary>
        /// <param name="orderByField">Filed to sort the data, in order to get page numbers</param>
        /// <param name="startRow">page start row</param>
        /// <param name="endRow">page end row</param>
        public void ApplyPagination(SqlExpressionBase orderByField, SqlExpressionBase startRow, SqlExpressionBase endRow)
        {
            ApplyPagination(orderByField, SortDirection.Asc, startRow, endRow);
        }

        /// <summary>
        /// Apply paginiation to the query
        /// </summary>
        /// <param name="orderByFieldList">fileds to sort the data, in order to get page numbers</param>
        /// <param name="sortDirectionList">sort direction</param>
        /// <param name="startRow">page start row</param>
        /// <param name="endRow">page end row</param>
        public void ApplyPagination(Collection<SqlExpressionBase> orderByFieldList,
            Collection<SortDirection> sortDirectionList, SqlExpressionBase startRow, SqlExpressionBase endRow)
        {
            //Add row number column to the current query builder
            string[] fieldList = new string[orderByFieldList.Count];
            SortDirection[] sortDirectionArray = new SortDirection[sortDirectionList.Count];
            for (int i = 0; i < orderByFieldList.Count; i++)
            {
                fieldList.SetValue(orderByFieldList[i].ToString(), i);
            }
            for (int i = 0; i < sortDirectionList.Count; i++)
            {
                sortDirectionArray.SetValue(sortDirectionList[i], i);
            }

            this.QueryBuilder.AddField(DataHelper.RowNumber(fieldList, sortDirectionArray));

            //Create a new query builder for paged query
            QueryBuilder pagedQueryBuilder = new QueryBuilder(SQLType.SelectSQL, this.Name);

            //Add current query builder as an inner query to new query builder
            pagedQueryBuilder.AddTable(this.QueryBuilder, pagedTableName);

            //Add pagination where clause to new query builder
            pagedQueryBuilder.AddWhereClauseItem(DataHelper.Between(rowNumberColumnName, startRow.ToString(), endRow.ToString()));

            //Add all columns to new query builder
            foreach (var fieldName in this.FieldNames)
            {
                pagedQueryBuilder.AddField(pagedTableName, fieldName, fieldName);
            }

            //Add all parameters to new query builder
            foreach (var parameter in this.QueryBuilder.Parameters)
            {
                pagedQueryBuilder.Parameters.Add(parameter);
            }

            //Replace curretn query builder with new query builder
            this.QueryBuilder = pagedQueryBuilder;
        }

        public void Union(QueryBase secondQuery)
        {
            this.QueryBuilder.AddUnion(secondQuery.QueryBuilder);
        }
        public SelectQuery ShallowCopy()
        {
            return (SelectQuery)this.MemberwiseClone();
        }
    }

}
