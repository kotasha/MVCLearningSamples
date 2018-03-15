using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Web.Mvc;

namespace Kotacs.Libraries.Web.Extensibility
{
    [AttributeUsage(AttributeTargets.Class|AttributeTargets.Method, AllowMultiple =true)]
    public class KotacsLogActionFilterAttribute : ActionFilterAttribute
    {
        public string LogFormat { get; set; }
        public string Message { get; set; }
        public bool LogToResponseBuffer { get; set; }

        public override void OnActionExecuted(ActionExecutedContext filterContext)
        {
            base.OnActionExecuted(filterContext);
            var messageToLog = string.Format(LogFormat,Environment.MachineName,DateTime.Now.ToString(),Message);
            if (LogToResponseBuffer)
            {
                var response = filterContext.HttpContext.Response;
                response.Write(string.Format(@"<div><b>[Action Executed]</b></div><br/>"));
            }
            else
                EventLog.WriteEntry("Application",messageToLog,EventLogEntryType.Information);
        }

        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            base.OnActionExecuting(filterContext);
            var messageToLog = string.Format(LogFormat,Environment.MachineName,DateTime.Now.ToString(),Message);
            if (LogToResponseBuffer)
            {
                var response = filterContext.HttpContext.Response;
                response.Write(string.Format(@"<div><b>[Action Executing]</b></div><br/>"));
            }
            else
                EventLog.WriteEntry("Application",messageToLog,EventLogEntryType.Information);
        }
        public override void OnResultExecuting(ResultExecutingContext filterContext)
            {
 	            base.OnResultExecuting(filterContext);
                var messageToLog = string.Format(LogFormat,Environment.MachineName,DateTime.Now.ToString(),Message);
                if (LogToResponseBuffer)
                {
                    var response = filterContext.HttpContext.Response;
                    response.Write(string.Format(@"<div><b>[Result Executing]</b></div><br/>"));
                }
                else
                    EventLog.WriteEntry("Application",messageToLog,EventLogEntryType.Information);
        }
        public override void OnResultExecuted(ResultExecutedContext filterContext)
            {
 	             base.OnResultExecuted(filterContext);
                var messageToLog = string.Format(LogFormat,Environment.MachineName,DateTime.Now.ToString(),Message);
                if (LogToResponseBuffer)
                {
                    var response = filterContext.HttpContext.Response;
                    response.Write(string.Format(@"<div><b>[Result Executed]</b></div><br/>"));
                }
                else
                    EventLog.WriteEntry("Application",messageToLog,EventLogEntryType.Information);
        
            }
        }
}
