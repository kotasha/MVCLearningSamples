using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kotacs.Libraries.Common.Logging
{
    public interface ILogger
    {
        void Error(ErrorMessageResID resID);
        void Error(ErrorMessageResID resID, params object[] args);
        void Error(ErrorMessageResID resID, LogSource source);
        void Error(ErrorMessageResID resID, Exception exp);
        void Error(ErrorMessageResID resID, LogSource source, Exception exp);
        void Info(LogMessageResID resID);
        void Info(LogMessageResID resID, params object[] args);
        void Info(LogMessageResID resID, LogSource source);
        void Info(LogMessageResID resID, LogSource source, params object[] args);
        void Warning(LogMessageResID resID);
        void Warning(LogMessageResID resID, params object[] args);
        void Warning(LogMessageResID resID, LogSource source);
        void Warning(LogMessageResID resID, LogSource source, params object[] args);
        void Debug(string message, LogSource source);
        void Debug(string message);
    }	
}
