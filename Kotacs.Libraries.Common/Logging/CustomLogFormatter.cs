using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Practices.EnterpriseLibrary.Common.Configuration;
using Microsoft.Practices.EnterpriseLibrary.Logging.Configuration;
using Microsoft.Practices.EnterpriseLibrary.Logging.Formatters;
using Microsoft.Practices.EnterpriseLibrary.Logging;
using System.Globalization;
using System.Collections.Specialized;
namespace Kotacs.Libraries.Common.Logging
{
    [ConfigurationElementType(typeof(CustomFormatterData))]
    public class CustomLogFormatter : ILogFormatter
    {
        public CustomLogFormatter(NameValueCollection attributes)
        {

        }

        #region ILogFormatter Members

        public string Format(LogEntry log)
        {
            StringBuilder outputMessageBuilder = new StringBuilder();
            outputMessageBuilder.Append("TimeStamp: ");
            outputMessageBuilder.AppendLine(DateTime.Now.ToString(CultureInfo.InvariantCulture.DateTimeFormat));
            outputMessageBuilder.Append("Message:");
            outputMessageBuilder.AppendLine(log.Message);
            return outputMessageBuilder.ToString();
        }

        #endregion
    }
}