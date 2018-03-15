using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Text;
using Kotacs.Libraries.Common;
using Microsoft.Practices.EnterpriseLibrary.Logging;
using Microsoft.Practices.EnterpriseLibrary.Logging.Configuration;
using Microsoft.Practices.EnterpriseLibrary.Logging.ExtraInformation;
using Microsoft.Practices.EnterpriseLibrary.Logging.Filters;

namespace Kotacs.Libraries.Common.Logging
{
    public static class LogManager
    {
        public static ILogger GetLogger()
        {
            return new BasicLogger();
        }
    }
    public class BasicLogger : ILogger
    {

        public BasicLogger()
        {
        }

        #region ILogger Members

        public void Error(ErrorMessageResID resID)
        {
            LogError(resID, string.Empty, null);
        }

        public void Error(ErrorMessageResID resID, params object[] args)
        {
            LogError(resID, string.Empty, null, args);
        }

        public void Error(ErrorMessageResID resID, LogSource source)
        {
            LogError(resID, source.ToString(), null);
        }

        public void Error(ErrorMessageResID resID, Exception exp)
        {
            LogError(resID, string.Empty, exp);
        }

        public void Error(ErrorMessageResID resID, LogSource source, Exception exp)
        {
            LogError(resID, source.ToString(), exp);
        }

        public void Info(LogMessageResID resID)
        {
            LogInfo(resID, string.Empty);
        }

        public void Info(LogMessageResID resID, params object[] args)
        {
            LogInfo(resID, string.Empty, args);
        }

        public void Info(LogMessageResID resID, LogSource source)
        {
            LogInfo(resID, source.ToString());
        }

        public void Info(LogMessageResID resID, LogSource source, params object[] args)
        {
            LogInfo(resID, source.ToString(), args);
        }

        public void Warning(LogMessageResID resID)
        {
            LogWarning(resID, string.Empty);
        }

        public void Warning(LogMessageResID resID, params object[] args)
        {
            LogWarning(resID, string.Empty, args);
        }

        public void Warning(LogMessageResID resID, LogSource source)
        {
            LogWarning(resID, source.ToString());
        }

        public void Warning(LogMessageResID resID, LogSource source, params object[] args)
        {
            LogWarning(resID, source.ToString(), args);
        }

        public void Debug(string message, LogSource source)
        {
            LogDebug(message, source.ToString(), null);
        }

        public void Debug(string message)
        {
            LogDebug(message, string.Empty, null);
        }
        public void Debug(string message, LogSource source, params object[] args)
        {
            LogDebug(message, source.ToString(), args);
        }
        private void LogError(ErrorMessageResID resID, string logSource, Exception exp, params object[] args)
        {
            try
            {
                StringBuilder messageBuilder = new StringBuilder();
                if (args != null && args.Length > 0)
                {
                    //messageBuilder.AppendLine(string.Format(CultureInfo.InvariantCulture, ResourceManager.GetErrorMessage(resID), args));
                }
                else
                {
                    //messageBuilder.AppendLine(ResourceManager.GetErrorMessage(resID));
                }
                if (!logSource.Equals(string.Empty))
                    messageBuilder.AppendLine("Log Source : " + logSource);

                messageBuilder.AppendLine(GetExceptionMessage(exp));
                LogEntry log = new LogEntry();
                log.Message = messageBuilder.ToString();
                log.Priority = 5;
                log.EventId = resID.GetHashCode();
                log.Categories.Clear();
                log.Categories.Add("Error Log");
                log.Categories.Add("Debug");
                Logger.Write(log);
            }
            catch (Exception ex)
            {
                NotifyLoggingFailure(ex);
            }
        }
        public static string GetExceptionMessage(Exception exp)
        {
            StringBuilder messageBuilder = new StringBuilder();
            while (exp != null)
            {
                messageBuilder.AppendLine("Error: " + exp.Message + exp.StackTrace);
                messageBuilder.AppendLine("Source: " + exp.Source);
                AppendStackTrace(new StackTrace(exp, true), messageBuilder);
                exp = exp.InnerException;
            }
            return messageBuilder.ToString();

        }
        private static void AppendStackTrace(StackTrace stackTrace, StringBuilder messageBuilder)
        {

            for (int i = 0; i < stackTrace.FrameCount; i++)
            {
                StackFrame sf = stackTrace.GetFrame(i);

                Type t = sf.GetMethod().ReflectedType;
                if (t != null)
                {
                    messageBuilder.Append("\n\t" + t.ToString() + " " + sf.GetMethod().ToString() + "(" + sf.GetFileLineNumber() + "): " + sf.GetFileName());
                }
            }
        }

        private void LogInfo(LogMessageResID resID, string logSource, params object[] args)
        {
            try
            {
                if (WebConfig.DeveloperMode == DeveloperMode.Disabled.GetHashCode())
                    return;
                StringBuilder messageBuilder = new StringBuilder();

                if (args != null && args.Length > 0)
                {
                    //messageBuilder.AppendLine(string.Format(CultureInfo.InvariantCulture, ResourceManager.GetLogMessage(resID), args));
                }
                else
                {
                    //messageBuilder.AppendLine(ResourceManager.GetLogMessage(resID));
                }
                if (!logSource.Equals(string.Empty))
                    messageBuilder.AppendLine("Log Source : " + logSource);

                LogEntry log = new LogEntry();
                log.Message = messageBuilder.ToString();
                log.Priority = 2;
                log.EventId = resID.GetHashCode();
                log.Categories.Clear();
                log.Categories.Add("General");
                Logger.Write(log);
            }
            catch (Exception ex)
            {
                NotifyLoggingFailure(ex);
            }
        }

        private void LogWarning(LogMessageResID resID, string logSource, params object[] args)
        {
            try
            {
                StringBuilder messageBuilder = new StringBuilder();

                if (args != null && args.Length > 0)
                {
                    //messageBuilder.AppendLine(string.Format(CultureInfo.InvariantCulture, ResourceManager.GetLogMessage(resID), args));
                }
                else
                {
                    //messageBuilder.AppendLine("Warning ::: " + ResourceManager.GetLogMessage(resID));
                }
                if (!logSource.Equals(string.Empty))
                    messageBuilder.AppendLine("Log Source : " + logSource);

                LogEntry log = new LogEntry();
                log.Message = messageBuilder.ToString();
                log.Priority = 3;
                log.EventId = resID.GetHashCode();
                log.Categories.Clear();
                log.Categories.Add("Error Log");
                Logger.Write(log);
            }
            catch (Exception ex)
            {
                NotifyLoggingFailure(ex);
            }
        }
        private void LogDebug(string message, string logSource, params object[] args)
        {
            if (WebConfig.DeveloperMode == DeveloperMode.Disabled.GetHashCode())
                return;
            try
            {
                StringBuilder messageBuilder = new StringBuilder();
                if (args != null && args.Length > 0)
                    messageBuilder.AppendLine(string.Format(CultureInfo.InvariantCulture, message, args));
                else
                    messageBuilder.AppendLine("Debug ::: " + message);
                if (!logSource.Equals(string.Empty))
                    messageBuilder.AppendLine("Log Source : " + logSource);
                LogEntry log = new LogEntry();
                log.Message = messageBuilder.ToString();
                log.Priority = 1;
                log.EventId = 100;
                log.Categories.Clear();
                log.Categories.Add("Debug");
                Logger.Write(log);

            }
            catch (Exception ex)
            {
                NotifyLoggingFailure(ex);
            }
        }

        private void NotifyLoggingFailure(Exception ex)
        {
            try
            {
                EventLog.WriteEntry("Application", "Error while logging message" + ex.Message, EventLogEntryType.Error);
            }
            catch
            {
                //Swallow Exception
            }
        }

        #endregion

        #region ILogger Members




        #endregion
    }
}
