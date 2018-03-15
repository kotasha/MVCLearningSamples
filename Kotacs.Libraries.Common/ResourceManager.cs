using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Kotacs.Libraries.Utility;

namespace Kotacs.Libraries.Common
{
    public interface IResourceManager
    {
        string GetResourceStringInstance(int resourceStringID);
        string GetResourceStringInstance(ActionLinkResID resourceStringID);
        string GetResourceStringInstance(PageResourceID resourceStringID);
        string GetLogMessageInstance(LogMessageResID logMessageID);
        string GetErrorMessageInstance(ErrorMessageResID errorMessageID);
        string GetExceptionPolicyInstance(ExceptionPolicyId policyID);
        string GetLandingPageInstance(string value);
        string GetControllerNameInstance(string value);
        Dictionary<string, string> GetParameterListInstance(string value);
        string GetResourceValidationMessageInstant(string value);
    }



    public class ResourceManager : IResourceManager
    {
        private static IResourceManager resourceManager = new ResourceManager();

        private ResourceCache cache = ResourceCache.Instance;


        #region Static Methods
        /// <summary>
        /// Setting ResourceManager object. Need for mocking resource manager for unit 
        /// testing purpose. 
        /// </summary>
        /// <param name="externalResourceManager"></param>
        public static void SetResourceManager(IResourceManager externalResourceManager)
        {
            resourceManager = externalResourceManager;
        }

        /// <summary>
        /// Referenced to GetResourceStringInstance in the non-static method
        /// </summary>
        /// <param name="resourceStringID"></param>
        /// <returns></returns>
        public static string GetResourceString(int resourceStringID)
        {
            return resourceManager.GetResourceStringInstance(resourceStringID);
        }

        /// <summary>
        ///  Referenced to GetResourceStringInstance in the non-static method
        /// </summary>
        /// <param name="resourceStringID"></param>
        /// <returns></returns>
        public static string GetResourceString(ActionLinkResID resourceStringID)
        {
            return resourceManager.GetResourceStringInstance(resourceStringID);
        }

        /// <summary>
        /// Referenced to GetResourceStringInstance in the non-static method
        /// </summary>
        /// <param name="resourceStringID"></param>
        /// <returns></returns>
        public static string GetResourceString(PageResourceID resourceStringID)
        {
            return resourceManager.GetResourceStringInstance(resourceStringID);
        }

        /// <summary>
        /// Referenced to GetLogMessageInstance in the non-static method
        /// </summary>
        /// <param name="errorMessageID"></param>
        /// <returns></returns>
        public static string GetLogMessage(LogMessageResID errorMessageID)
        {
            return resourceManager.GetLogMessageInstance(errorMessageID);
        }

        /// <summary>
        /// Referenced to GetErrorMessageInstance in the non-static method
        /// </summary>
        /// <param name="errorMessageID"></param>
        /// <returns></returns>
        public static string GetErrorMessage(ErrorMessageResID errorMessageID)
        {
            return resourceManager.GetErrorMessageInstance(errorMessageID);
        }
        /// <summary>
        /// Referenced to GetExceptionPolicyInstance in the non-static method
        /// </summary>
        /// <param name="policyID"></param>
        /// <returns></returns>
        public static string GetExceptionPolicy(ExceptionPolicyId policyID)
        {
            return resourceManager.GetExceptionPolicyInstance(policyID);
        }

        /// <summary>
        /// Referenced to GetLandingPageInstance in the non-static method
        /// </summary>
        /// <param name="landingPageID"></param>
        /// <returns></returns>
        public static string GetLandingPage(string landingPageID)
        {
            return resourceManager.GetLandingPageInstance(landingPageID);
        }

        /// <summary>
        /// Referenced to GetControllerNameInstance in the non-static method
        /// </summary>
        /// <param name="controllerID"></param>
        /// <returns></returns>
        public static string GetControllerName(string controllerID)
        {
            return resourceManager.GetControllerNameInstance(controllerID);
        }

        /// <summary>
        /// Referenced to GetParameterListInstance in the non-static method
        /// </summary>
        /// <param name="parameterListID"></param>
        /// <returns></returns>
        public static Dictionary<string, string> GetParameterList(string parameterListID)
        {
            return resourceManager.GetParameterListInstance(parameterListID);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="stringId"></param>
        public static string GetResourceValidationMessages(string stringId)
        {
            return resourceManager.GetResourceValidationMessageInstant(stringId);
        }

        #endregion

        #region Non-Static Method

        /// <summary>
        /// Get Resource string based on the param
        /// </summary>
        /// <param name="resourceStringInstanceValue"></param>
        /// <returns></returns>
        public string GetResourceStringInstance(int resourceStringInstanceValue)
        {
            return cache.GetReplacementString(APConvert.ToString(resourceStringInstanceValue));
        }

        /// <summary>
        /// Get Resource string based on the param
        /// </summary>
        /// <param name="resourceStringInstanceValue"></param>
        /// <returns></returns>
        public string GetResourceStringInstance(ActionLinkResID resourceStringInstanceValue)
        {
            return cache.GetReplacementString(APConvert.ToString(resourceStringInstanceValue.GetHashCode()));
        }

        /// <summary>
        /// Get Resource string based on the param
        /// </summary>
        /// <param name="resValue"></param>
        /// <returns></returns>
        public string GetResourceStringInstance(PageResourceID resValue)
        {
            return cache.GetReplacementString(APConvert.ToString(resValue.GetHashCode()));
        }

        /// <summary>
        /// Get Log message based on the param
        /// </summary>
        /// <param name="resValue"></param>
        /// <returns></returns>
        public string GetLogMessageInstance(LogMessageResID resValue)
        {
            return cache.GetLogMessage(APConvert.ToString(resValue.GetHashCode()));
        }

        /// <summary>
        /// Get Error message based on the param
        /// </summary>
        /// <param name="resValue"></param>
        /// <returns></returns>
        public string GetErrorMessageInstance(ErrorMessageResID resValue)
        {
            return cache.GetErrorMessage(APConvert.ToString(resValue.GetHashCode()));
        }

        /// <summary>
        /// Get Exception Policy message based on the param
        /// </summary>
        /// <param name="PolicyNo"></param>
        /// <returns></returns>
        public string GetExceptionPolicyInstance(ExceptionPolicyId PolicyNo)
        {
            return cache.GetErrorMessage(APConvert.ToString(PolicyNo.GetHashCode()));
        }

        /// <summary>
        /// Get GetLanding Page message based on the param
        /// </summary>
        /// <param name="landingPageNo"></param>
        /// <returns></returns>
        public string GetLandingPageInstance(string landingPageNo)
        {
            return cache.GetLandingPage(APConvert.ToString(landingPageNo));
        }

        /// <summary>
        /// Get GetController Name message based on the param
        /// </summary>
        /// <param name="controllerValue"></param>
        /// <returns></returns>
        public string GetControllerNameInstance(string controllerValue)
        {
            return cache.GetControllerName(APConvert.ToString(controllerValue));
        }

        /// <summary>
        /// Get GetParameterLists based on the param
        /// </summary>
        /// <param name="parameterListValue"></param>
        /// <returns></returns>
        public Dictionary<string, string> GetParameterListInstance(string parameterListValue)
        {
            return cache.GetParameterList(APConvert.ToString(parameterListValue));
        }

        /// <summary>
        /// GetResourceValidationMessages
        /// </summary>
        /// <param name="stringValue"></param>
        /// <returns></returns>
        public string GetResourceValidationMessageInstant(string stringValue)
        {
            return null;
            //return cache.GetResourceValidationMessage(APConvert.ToString(stringValue)); 
        }

        #endregion
    }
}
