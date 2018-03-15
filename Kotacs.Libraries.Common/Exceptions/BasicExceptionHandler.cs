using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.Serialization;
using Microsoft.Practices.EnterpriseLibrary.ExceptionHandling;
using Microsoft.Practices.EnterpriseLibrary.ExceptionHandling.Logging;
using Kotacs.Libraries.Common.Logging;

namespace Kotacs.Libraries.Common.Exceptions
{
    public static class ExceptionManager
    {
        public static IExceptionHandler GetExceptionHandler()
        {
            return new BasicExceptionHandler();
        }
    }

    public class BasicExceptionHandler : IExceptionHandler
    {

        public BasicExceptionHandler()
        {

        }
        #region IExceptionHandler Members

        public bool HandleExcception(Exception exception)
        {
            return ExceptionPolicy.HandleException(exception, GlobalConstants.PolicyException);
        }
        public bool HandlePresentationExcception(Exception exception)
        {
            return ExceptionPolicy.HandleException(exception, GlobalConstants.PolicyPresentationException);
        }
        public bool HandleDeliveryFrameworkExcception(Exception exception)
        {
            return ExceptionPolicy.HandleException(exception, GlobalConstants.PolicyDeliveryFrameworkException);
        }
        public bool HandleServiceExcception(Exception exception)
        {
            return ExceptionPolicy.HandleException(exception, GlobalConstants.PolicyServiceException);
        }
        public bool HandleBusinessExcception(Exception exception)
        {
            return ExceptionPolicy.HandleException(exception, GlobalConstants.PolicyBusinessException);
        }
        public bool HandleDataExcception(Exception exception)
        {
            return ExceptionPolicy.HandleException(exception, GlobalConstants.PolicyDataException);
        }
        #endregion
    }

    [Serializable]
    public class BusinessLayerException : Exception
    {
        /// <summary>
        /// Default constructor
        /// </summary>
        public BusinessLayerException()
            : base()
        {
        }

        /// <summary>
        /// Initializes with a specified error message.
        /// </summary>
        /// <param name="message">A message that describes the error.</param>
        public BusinessLayerException(string message)
            : base(message)
        {
        }

        /// <summary>
        /// Initializes with a specified error 
        /// message and a reference to the inner exception that is the cause of this exception.
        /// </summary>
        /// <param name="message">The error message that explains the reason for the exception.
        /// </param>
        /// <param name="exception">The exception that is the cause of the current exception. 
        /// If the innerException parameter is not a null reference, the current exception 
        /// is raised in a catch block that handles the inner exception.
        /// </param>
        public BusinessLayerException(string message, Exception exception) :
            base(message, exception)
        {
        }

        /// <summary>
        /// Initializes with serialized data.
        /// </summary>
        /// <param name="info">The object that holds the serialized object data.</param>
        /// <param name="context">The contextual information about the source or destination.
        /// </param>
        protected BusinessLayerException(SerializationInfo info, StreamingContext context) :
            base(info, context)
        {
        }
    }
    [Serializable]
    public class DataLayerException : Exception
    {
        /// <summary>
        /// Default constructor
        /// </summary>
        public DataLayerException()
            : base()
        {
        }

        /// <summary>
        /// Initializes with a specified error message.
        /// </summary>
        /// <param name="message">A message that describes the error.</param>
        public DataLayerException(string message)
            : base(message)
        {
        }

        /// <summary>
        /// Initializes with a specified error 
        /// message and a reference to the inner exception that is the cause of this exception.
        /// </summary>
        /// <param name="message">The error message that explains the reason for the exception.
        /// </param>
        /// <param name="exception">The exception that is the cause of the current exception. 
        /// If the innerException parameter is not a null reference, the current exception 
        /// is raised in a catch block that handles the inner exception.
        /// </param>
        public DataLayerException(string message, Exception exception) :
            base(message, exception)
        {
        }

        /// <summary>
        /// Initializes with serialized data.
        /// </summary>
        /// <param name="info">The object that holds the serialized object data.</param>
        /// <param name="context">The contextual information about the source or destination.
        /// </param>
        protected DataLayerException(SerializationInfo info, StreamingContext context) :
            base(info, context)
        {
        }
    }
    [Serializable]
    public class ServiceLayerException : Exception
    {
        /// <summary>
        /// Default constructor
        /// </summary>
        public ServiceLayerException()
            : base()
        {
        }

        /// <summary>
        /// Initializes with a specified error message.
        /// </summary>
        /// <param name="message">A message that describes the error.</param>
        public ServiceLayerException(string message)
            : base(message)
        {
        }

        /// <summary>
        /// Initializes with a specified error 
        /// message and a reference to the inner exception that is the cause of this exception.
        /// </summary>
        /// <param name="message">The error message that explains the reason for the exception.
        /// </param>
        /// <param name="exception">The exception that is the cause of the current exception. 
        /// If the innerException parameter is not a null reference, the current exception 
        /// is raised in a catch block that handles the inner exception.
        /// </param>
        public ServiceLayerException(string message, Exception exception) :
            base(message, exception)
        {
        }

        /// <summary>
        /// Initializes with serialized data.
        /// </summary>
        /// <param name="info">The object that holds the serialized object data.</param>
        /// <param name="context">The contextual information about the source or destination.
        /// </param>
        protected ServiceLayerException(SerializationInfo info, StreamingContext context) :
            base(info, context)
        {
        }
    }
    [Serializable]
    public class PresentationLayerException : Exception
    {
        /// <summary>
        /// Default constructor
        /// </summary>
        public PresentationLayerException()
            : base()
        {
        }

        /// <summary>
        /// Initializes with a specified error message.
        /// </summary>
        /// <param name="message">A message that describes the error.</param>
        public PresentationLayerException(string message)
            : base(message)
        {
        }

        /// <summary>
        /// Initializes with a specified error 
        /// message and a reference to the inner exception that is the cause of this exception.
        /// </summary>
        /// <param name="message">The error message that explains the reason for the exception.
        /// </param>
        /// <param name="exception">The exception that is the cause of the current exception. 
        /// If the innerException parameter is not a null reference, the current exception 
        /// is raised in a catch block that handles the inner exception.
        /// </param>
        public PresentationLayerException(string message, Exception exception) :
            base(message, exception)
        {
        }

        /// <summary>
        /// Initializes with serialized data.
        /// </summary>
        /// <param name="info">The object that holds the serialized object data.</param>
        /// <param name="context">The contextual information about the source or destination.
        /// </param>
        protected PresentationLayerException(SerializationInfo info, StreamingContext context) :
            base(info, context)
        {
        }
    }

}
