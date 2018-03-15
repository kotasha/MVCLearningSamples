using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace Kotacs.Libraries.DAL.OrderSystem.Wrappers
{
   public class SqlParameter: SqlExpressionBase
	{
        /// <summary>
        /// Name of SqlParameter
        /// </summary>
		public string Name { get; private set; }

        /// <summary>
        /// Type of SqlParameter
        /// </summary>
		public DbType Type { get; private set; }
        /// <summary>
        /// overriding ExpressionString
        /// </summary>
		protected override string ExpressionString
		{
			get { return Name; }
		}

        /// <summary>
        /// The SqlParameter Constructor.Takes to Parameters
        /// </summary>
        /// <param name="name">string</param>
        /// <param name="type">DbType</param>
		public SqlParameter(string name, DbType type)
		{
			this.Name = name;
			this.Type = type;
		}
	}
}

