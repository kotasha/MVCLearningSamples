using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Security.Permissions;
using System.Xml;
using Microsoft.Practices.EnterpriseLibrary.Caching;
using Kotacs.Libraries.Utility;


namespace Kotacs.Libraries.Common
{
    public class ResourceCache
    {
        private const string REPLACEMENT_STRING_CACHE = "ReplacementStrings";
        private const string LOG_MESSAGES_CACHE = "LogMessages";
        private const string ERROR_MESSAGES_CACHE = "ErrorMessages";
        private const string LANDING_PAGE_CACHE = "LandingPages";
        private static ICacheManager replacemntStringCache, logMessageCache, errorMessageCache, landingPageCache;
        private static MessageStringProvider resourceStringProvider;
        private static FileSystemWatcher _xmlFileWatcher;
        private static ResourceCache instance;

        [PermissionSetAttribute(SecurityAction.LinkDemand, Name = "FullTrust")]
        private ResourceCache()
        {
            replacemntStringCache = CacheFactory.GetCacheManager(REPLACEMENT_STRING_CACHE);
            logMessageCache = CacheFactory.GetCacheManager(LOG_MESSAGES_CACHE);
            errorMessageCache = CacheFactory.GetCacheManager(ERROR_MESSAGES_CACHE);
            landingPageCache = CacheFactory.GetCacheManager(LANDING_PAGE_CACHE);
            resourceStringProvider = new MessageStringProvider();
            LoadCache();
            if (Directory.Exists(resourceStringProvider.Path))
            {
                _xmlFileWatcher = new FileSystemWatcher();
                _xmlFileWatcher.Path = resourceStringProvider.Path;
                _xmlFileWatcher.Filter = "*.xml";
                _xmlFileWatcher.IncludeSubdirectories = true;
                _xmlFileWatcher.EnableRaisingEvents = true;
                _xmlFileWatcher.Changed += new System.IO.FileSystemEventHandler(xmlFileWatcher_Changed);
            }
            else if (Directory.Exists(resourceStringProvider.SEMPath))
            {
                _xmlFileWatcher = new FileSystemWatcher();
                _xmlFileWatcher.Path = resourceStringProvider.SEMPath;
                _xmlFileWatcher.Filter = "*.xml";
                _xmlFileWatcher.IncludeSubdirectories = true;
                _xmlFileWatcher.EnableRaisingEvents = true;
                _xmlFileWatcher.Changed += new System.IO.FileSystemEventHandler(xmlFileWatcher_Changed);
            }
        }

        private void xmlFileWatcher_Changed(object sender, System.IO.FileSystemEventArgs e)
        {
            this.FlushCache();
        }

        public static ResourceCache Instance
        {
            get
            {

                try
                {
                    if (instance == null)
                    {
                        instance = new ResourceCache();
                    }

                    return instance;
                }
                catch (DirectoryNotFoundException ex)
                {
                    if (ex.Message != "Could not find Resoruce path")
                        throw;
                }
                return instance;
            }
        }

        public void LoadCache()
        {
            LoadCache(resourceStringProvider.ReplacmentStringsXmlFile,
                resourceStringProvider.ReplacmentStringsXmlNode, replacemntStringCache);
            LoadCache(resourceStringProvider.LogMessagesXmlFile,
                resourceStringProvider.LogMessagesXmlNode, logMessageCache);
            LoadCache(resourceStringProvider.ErrorMessagesXmlFile,
                resourceStringProvider.ErrorMessagesXmlNode, errorMessageCache);
            LoadCache(resourceStringProvider.LandingPageXmlFile,
                resourceStringProvider.LandingPageXmlNode, landingPageCache);
        }

        public void LoadCache(string filename, string xmlNode, ICacheManager cacheManager)
        {
            Collection<MessageString> list = null;
            Collection<LandingPageMessageString> landingList = null;

            if (xmlNode == GlobalConstants.LandingPage)
            {
                landingList = resourceStringProvider.GetLandingPageReplacementStrings(filename);
                for (int index = 0; index < landingList.Count; index++)
                {
                    LandingPageMessageString messageString = landingList[index];
                    cacheManager.Add(messageString.StringPageID, messageString);
                }
            }
            else
            {
                list = resourceStringProvider.GetAllReplacementStrings(filename, xmlNode);
                for (int index = 0; index < list.Count; index++)
                {
                    MessageString messageString = list[index];
                    cacheManager.Add(messageString.StringID, messageString);
                }
            }
        }

        public string GetLogMessage(string logID)
        {
            MessageString messageString = (MessageString)logMessageCache.GetData(logID);
            if (messageString == null)
                return getMessageString(logID, resourceStringProvider.LogMessagesXmlFile,

              resourceStringProvider.LogMessagesXmlNode, logMessageCache).ToString();
            return messageString.ToString();
        }

        public string GetErrorMessage(string errorID)
        {
            MessageString messageString = (MessageString)errorMessageCache.GetData(errorID);
            if (messageString == null)
                return getMessageString(errorID, resourceStringProvider.ErrorMessagesXmlFile,
          resourceStringProvider.ErrorMessagesXmlNode, errorMessageCache).ToString();
            return messageString.ToString();

        }
        public string GetReplacementString(string replacementStringId)
        {
            MessageString messageString = (MessageString)replacemntStringCache.GetData(replacementStringId);
            if (messageString == null)
                return getMessageString(replacementStringId, resourceStringProvider.ReplacmentStringsXmlFile,
          resourceStringProvider.ReplacmentStringsXmlNode, replacemntStringCache).ToString();
            return messageString.ToString();

        }

        public string GetExceptionPolicy(string policyID)
        {
            MessageString messageString = (MessageString)replacemntStringCache.GetData(policyID);
            if (messageString == null)
                return getMessageString(policyID, resourceStringProvider.ExceptionPoliciesXmlFile,
          resourceStringProvider.ExceptionPoliciesXmlNode, replacemntStringCache).ToString();
            return messageString.ToString();

        }

        private MessageString getMessageString(string messageID, string xmlFile, string xmlNode, ICacheManager cacheManager)
        {
            // Does our cache already have the requested object?
            // Requested object is not cached, so let's retrieve it from
            // data provider and cache it for further requests.
            MessageString messageString = resourceStringProvider.GetReplacementString(messageID, xmlFile, xmlNode);

            if (messageString != null)
            {
                cacheManager.Add(messageID, messageString);
                return messageString;
            }

            return new MessageString();
        }

        public string GetLandingPage(string value)
        {
            LandingPageMessageString messageString = (LandingPageMessageString)landingPageCache.GetData(value);
            if (messageString == null)
                return getMessageString(value, resourceStringProvider.LandingPageXmlFile,
          resourceStringProvider.LandingPageXmlNode, landingPageCache).ToString();
            return APConvert.ToString(messageString.StringPageAddress);

        }

        public string GetControllerName(string controllerID)
        {
            LandingPageMessageString messageString = (LandingPageMessageString)landingPageCache.GetData(controllerID);
            if (messageString == null)
                return getMessageString(controllerID, resourceStringProvider.LandingPageXmlFile,
          resourceStringProvider.LandingPageXmlNode, landingPageCache).ToString();
            return APConvert.ToString(messageString.StringPageController);

        }

        public Dictionary<string, string> GetParameterList(string value)
        {
            LandingPageMessageString messageString = (LandingPageMessageString)landingPageCache.GetData(value);
            return messageString.StringPageParameters;
        }
        public void FlushCache()
        {
            replacemntStringCache.Flush();
            logMessageCache.Flush();
            errorMessageCache.Flush();
            landingPageCache.Flush();
        }
    }


    public class MessageStringProvider
    {
        private string xmlPath;
        private string xmlFile = string.Empty;
        public string Path
        {
            get
            {
                if (xmlPath != null)
                    return xmlPath;

                DirectoryInfo d = Directory.GetParent(System.AppDomain.CurrentDomain.BaseDirectory);

                if (Directory.Exists(d.FullName + @"\Resources\"))
                {
                    xmlPath = d.FullName + @"\Resources\";
                }
                if (xmlPath == null)
                    throw new DirectoryNotFoundException("Could not find Resoruce path");
                return xmlPath;
            }
        }
        public string SEMPath
        {
            get
            {
                string semxmlPath = string.Empty;

                DirectoryInfo semDir = Directory.GetParent(System.AppDomain.CurrentDomain.BaseDirectory);

                if (Directory.Exists(semDir.FullName + @"\Views\Sem\"))
                {
                    semxmlPath = semDir.FullName + @"\Views\Sem\";
                }
                if (semxmlPath == null)
                    throw new DirectoryNotFoundException("Could not find Resoruce path");
                return semxmlPath;
            }
        }
        public string ReplacmentStringsXmlFile
        {
            get
            {
                return Path + "ReplacementStrings.xml";
            }
        }
        public string LandingPageXmlFile
        {
            get
            {
                return SEMPath + "landingPage.xml";
            }
        }

        public string LogMessagesXmlFile
        {
            get
            {
                return Path + "LogMessages.xml";
            }
        }
        public string ErrorMessagesXmlFile
        {
            get
            {
                return Path + "ErrorMessages.xml";
            }
        }

        public string ExceptionPoliciesXmlFile
        {
            get
            {
                return Path + "ExceptionPolicies.xml";
            }
        }

        public string ReplacmentStringsXmlNode
        {
            get
            {
                return "ReplacementStrings/ReplacementString";
            }
        }
        public string LandingPageXmlNode
        {
            get
            {
                return GlobalConstants.LandingPage;
            }
        }
        public string LogMessagesXmlNode
        {
            get
            {
                return "LogMessages/LogMessage";
            }
        }
        public string ErrorMessagesXmlNode
        {
            get
            {
                return "ErrorMessages/ErrorMessage";
            }
        }

        public string ExceptionPoliciesXmlNode
        {
            get
            {
                return "ExceptionPolicies/ExceptionPolicy";
            }
        }

        public Collection<MessageString> GetAllReplacementStrings(string filename, string xmlNode)
        {
            Collection<MessageString> list = new Collection<MessageString>();
            XmlTextReader reader = new XmlTextReader(filename);
            reader.MoveToContent();
            XmlDocument doc = new XmlDocument();
            doc.LoadXml(reader.ReadOuterXml());
            XmlNodeList nodes = doc.SelectNodes(xmlNode);
            foreach (XmlNode node in nodes)
            {
                MessageString messageString = new MessageString(node.Attributes["id"].Value,
                                                node.Attributes["value"].Value);
                list.Add(messageString);
            }
            reader.Close();
            return list;
        }

        public Collection<LandingPageMessageString> GetLandingPageReplacementStrings(string filename)
        {
            Collection<LandingPageMessageString> list = new Collection<LandingPageMessageString>();
            Dictionary<string, string> listParameter = new Dictionary<string, string>();
            XmlDocument doc = new XmlDocument();
            doc.Load(filename);

            XmlNodeList landingPageList = doc.GetElementsByTagName("LandingPage");

            foreach (XmlNode node in landingPageList)
            {
                string controller = string.Empty;
                string parameter = string.Empty;
                listParameter = new Dictionary<string, string>();

                XmlElement landingPageElement = (XmlElement)node;

                string pageId = landingPageElement.GetElementsByTagName("PageId")[0].InnerText;
                string pageUrl = landingPageElement.GetElementsByTagName("PageUrl")[0].InnerText;

                //Element Controller is not a mandatory field, check the availability
                if (landingPageElement.GetElementsByTagName("Controller").Count != 0)
                {
                    controller = landingPageElement.GetElementsByTagName("Controller")[0].InnerText;
                }


                //Element Parameters is not a mandatory field, check the availability
                if (landingPageElement.GetElementsByTagName("Parameters").Count != 0)
                {
                    XmlNodeList landingPageParameterList = landingPageElement.GetElementsByTagName("Parameter");
                    foreach (XmlNode nodePara in landingPageParameterList)
                    {
                        XmlElement landingPageParaElement = (XmlElement)nodePara;
                        listParameter.Add(nodePara.Attributes["Name"].Value, nodePara.Attributes["Value"].Value);
                    }
                }

                LandingPageMessageString messageString = new LandingPageMessageString(pageId, pageUrl, controller, listParameter);
                list.Add(messageString);
            }
            return list;
        }

        public MessageString GetReplacementString(string value, string filename, string xmlNode)
        {
            MessageString messageString = null;
            XmlTextReader reader = new XmlTextReader(filename);
            reader.MoveToContent();
            XmlDocument doc = new XmlDocument();
            doc.LoadXml(reader.ReadOuterXml());
            XmlNode replacementStringNode = doc.SelectSingleNode(xmlNode + "[@id=" + value + "]");
            if (replacementStringNode != null)
            {
                messageString = new MessageString(replacementStringNode.Attributes["id"].Value,
                  replacementStringNode.Attributes["value"].Value);
            }
            reader.Close();
            return messageString;
        }


    }
    [Serializable()]
    public class MessageString
    {
        private string stringID;
        private string stringValue;

        public MessageString()
        {
        }
        public MessageString(string id, string value)
        {
            this.stringID = id;
            this.stringValue = value;
        }
        public string StringID
        {
            get { return this.stringID; }
            set { this.stringID = value; }
        }
        public string StringValue
        {
            get { return this.stringValue; }
            set { this.stringValue = value; }
        }
        public override string ToString()
        {
            return this.stringValue;
        }
    }
    [Serializable()]
    public class LandingPageMessageString
    {
        private string stringPageID;
        private string stringPageAddress;
        private string stringPageController;
        Dictionary<string, string> listPageParameters;

        public LandingPageMessageString()
        {
        }
        public LandingPageMessageString(string pageId, string pageUrl, string pageController, Dictionary<string, string> pageParameters)
        {
            this.stringPageID = pageId;
            this.stringPageAddress = pageUrl;
            this.stringPageController = pageController;
            this.listPageParameters = pageParameters;
        }
        public LandingPageMessageString(string pageId, Uri pageUrl, string pageController, Dictionary<string, string> pageParameters)
        {
            this.stringPageID = pageId;
            this.stringPageAddress = pageUrl.AbsolutePath;
            this.stringPageController = pageController;
            this.listPageParameters = pageParameters;
        }
        public string StringPageID
        {
            get { return this.stringPageID; }
            set { this.stringPageID = value; }
        }
        public string StringPageAddress
        {
            get { return this.stringPageAddress; }
            set { this.stringPageAddress = value; }
        }
        public string StringPageController
        {
            get { return this.stringPageController; }
            set { this.stringPageController = value; }
        }
        public Dictionary<string, string> StringPageParameters
        {
            get { return this.listPageParameters; }
            set { this.listPageParameters = value; }
        }
    }

}
