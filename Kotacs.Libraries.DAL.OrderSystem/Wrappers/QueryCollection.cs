using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Kotacs.Libraries.DAL.OrderSystem.Wrappers
{
    public class QueryCollection
    {
        private const string defaultName = "Default";

        private QueryBuilders queryBuilders;
        /// <summary>
        /// QueryCollection Constructor of QueryCollection Class.
        /// create new instance of QueryBuilder
        /// </summary>
        /// <param name="name">string</param>

        public QueryCollection(string name)
        {
            queryBuilders = new QueryBuilders(name);
        }

        public QueryCollection()
            : this(defaultName)
        {

        }

        /// <summary>
        /// Add method.
        /// </summary>
        /// <param name="query">QueryBase</param>
        public void Add(QueryBase query)
        {
            queryBuilders.AddSQL(query.QueryBuilder);
        }

        /// <summary>
        /// Return QueryBuilders object that represent this query collection
        /// </summary>
        /// <returns>a query builders object</returns>
        public QueryBuilders ToQueryBuilders()
        {
            return queryBuilders;
        }

        /// <summary>
        /// Takes Collection as a parameter and returns queryBuilsers
        /// </summary>
        /// <param name="collection">QueryCollection </param>
        /// <returns>queryBuilders</returns>
        public static implicit operator QueryBuilders(QueryCollection collection)
        {
            return collection.ToQueryBuilders();
        }
    }
}

