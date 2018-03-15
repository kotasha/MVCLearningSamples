using Kotacs.Libraries.SOA.Contracts.Faults;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.ServiceModel;
using System.Text;

namespace Kotacs.Libraries.SOA.Impl
{
    public static class ExceptionExtensions
    {
        public static void Log(this Exception exceptionobject)
        {
            var messageToLog = string.Format(@"",Environment.UserName,DateTime.Now.ToString(),exceptionobject.Message);
            EventLog.WriteEntry("Application",messageToLog,EventLogEntryType.Error);
        }
        public static FaultException<ServiceError> Transform(this Exception exceptionObject,int errorId=default(int))
        {
            var faultException = new FaultException<ServiceError>(new ServiceError { ErrorId=errorId,Message=exceptionObject.Message,Source=exceptionObject.Source},new FaultReason(exceptionObject.Message));
            return faultException;
        }

    }
}
