using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kotacs.Libraries.DAL.OrderSystem.Wrappers.Tables.Cuas
{
    public class AccountTable : SqlTable
    {
        #region Construstor

        /// <summary>
        /// Constructor of Account Table 
        /// </summary>
        public AccountTable()
            : base("CHECKPOINT.ACCOUNT", "ACC")
        {
        }

        #endregion

        #region Public Properties

        /// <summary>
        /// Account Id of Account table
        /// </summary>
        public SqlField AccountId
        {
            get { return this["ACCOUNT_ID"]; }
        }

        /// <summary>
        /// Ria Customer Number of Account table
        /// </summary>
        public SqlField RiaCustomerNumber
        {
            get { return this["RIACUSTOMER_NUM"]; }
        }

        #endregion

        #region Public Methods

        /// <summary>
        /// Joins Account table with Order table
        /// </summary>
        /// <param name="query">Select query</param>
        /// <returns>Instance of OrderTable</returns>
        //public OrderTable JoinOrderTable(QueryBase query)
        //{
        //    OrderTable orderTable = new OrderTable();
        //    query.InnerJoin(orderTable, this.AccountId, orderTable.AccountId);
        //    return orderTable;
        //}

        #endregion
    }
}
