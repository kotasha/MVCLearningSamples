using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Configuration;
using System.Text;
using System.Linq;
using Kotacs.Libraries.Utility;

namespace Kotacs.Libraries.Common
{
    public static class WebConfig
    {
        #region Public Properties



        public static NameValueCollection Settings
        {
            get { return settings; }
        }


        #endregion

        #region Public Static Methods

        ///////////////////////////////////////////////////////////////////////////
        /// <summary>
        /// Initializes the specified app settings.
        /// </summary>
        /// <param name="appSettings">The app settings.</param>
        ///////////////////////////////////////////////////////////////////////////
        public static void Initialize(Dictionary<string, string> appSettings)
        {
            WebConfig._appSettings = appSettings;

            //
            // Add the soon to be obsolete values from the sapphire config.
            //
            NameValueCollection section = (NameValueCollection)ConfigurationManager.GetSection(GlobalConstants.WebConfigSection);

            foreach (string setting in section.AllKeys)
            {
                appSettings.Add(setting, section["setting"]);
            }
        }

        ///////////////////////////////////////////////////////////////////////////
        /// <summary>
        /// Gets the name of the setting by key.
        /// </summary>
        /// <param name="keyName">Name of the key.</param>
        /// <returns>
        /// The value for the key if the key exists, otherwise string.Empty
        /// </returns>
        ///////////////////////////////////////////////////////////////////////////
        public static string GetSettingByKeyName(string keyName)
        {
            var settingValue = (from values in WebConfig._appSettings
                                where values.Key == keyName
                                select values).Single();

            return string.IsNullOrEmpty(settingValue.Value) ? string.Empty : settingValue.Value;
        }

        ///////////////////////////////////////////////////////////////////////////
        /// <summary>
        /// Determines whether [is key valid] [the specified key name].
        /// </summary>
        /// <param name="keyName">Name of the key.</param>
        /// <returns>
        /// 	<c>true</c> if [is key valid] [the specified key name]; otherwise, <c>false</c>.
        /// </returns>
        ///////////////////////////////////////////////////////////////////////////
        public static bool IsKeyValid(string keyName)
        {
            return WebConfig._appSettings.Keys.Contains(keyName);
        }

        #endregion

        #region Private Members

        private static Dictionary<string, object> settingsStore = new Dictionary<string, object>();

        public static T Get<T>()
        {
            return (T)settingsStore[typeof(T).FullName];
        }

        public static void Set<T>(T obj)
        {
            //Remove the item if exists
            settingsStore.Remove(typeof(T).FullName);
            settingsStore.Add(typeof(T).FullName, obj);
        }

        private static Dictionary<string, string> _appSettings = new Dictionary<string, string>();
        private static NameValueCollection settings;

        #endregion

        #region Application Settings

        private static bool _isRedeemedPromoEditable;
        public static bool IsRedeemedPromoEditable
        {
            get
            {
                return WebConfig._isRedeemedPromoEditable;
            }
        }

        private static string _receiptEmailSubjectFormat;
        public static string ReceiptEmailSubjectFormat
        {
            get
            {
                return WebConfig._receiptEmailSubjectFormat;
            }
        }

        private static bool _isCartInMaintenance;
        public static bool IsCartInMaintenance
        {
            get
            {
                return WebConfig._isCartInMaintenance;
            }
        }

        public static string GetPricesProfessionalID
        {
            get
            {
                return WebConfig._getPricesProfessionalID;
            }
        } static string _getPricesProfessionalID;

        public static string GetPricesUnisonShipTo
        {
            get
            {
                return WebConfig._getPricesUnisonShipTo;
            }
        } static string _getPricesUnisonShipTo;

        #region UrlHost

        private static string hostAddress;
        public static string HostAddress
        {
            get { return WebConfig.hostAddress; }
            set { WebConfig.hostAddress = value; }
        }

        #endregion UrlHost

        #region Author

        private static int roleIdAuthor;
        public static int RoleIdAuthor
        {
            get { return WebConfig.roleIdAuthor; }
            set { WebConfig.roleIdAuthor = value; }
        }

        #endregion Author

        //Global
        #region
        private static string smtpDeliveryMethod;

        public static string SmtpDeliveryMethod
        {
            get { return WebConfig.smtpDeliveryMethod; }
            set { WebConfig.smtpDeliveryMethod = value; }
        }

        private static string defaultUser;

        public static string DefaultUser
        {
            get { return WebConfig.defaultUser; }
            set { WebConfig.defaultUser = value; }
        }

        private static string onlineGroupId;

        public static string OnlineGroupId
        {
            get { return WebConfig.onlineGroupId; }
            set { WebConfig.onlineGroupId = value; }
        }


        public static string bundlePackageTypeIds;
        public static string BundlePackageTypeIds
        {
            get { return WebConfig.bundlePackageTypeIds; }
            set { WebConfig.bundlePackageTypeIds = value; }
        }

        //CETracking titles
        public static string cpeTrackingLawProductTitle;
        public static string CpeTrackingLawProductTitle
        {
            get { return WebConfig.cpeTrackingLawProductTitle; }
            set { WebConfig.cpeTrackingLawProductTitle = value; }
        }

        public static string cpeTrackingAccountingProductTitle;
        public static string CpeTrackingAccountingProductTitle
        {
            get { return WebConfig.cpeTrackingAccountingProductTitle; }
            set { WebConfig.cpeTrackingAccountingProductTitle = value; }
        }

        public static string cpeTrackingDualProductTitle;
        public static string CpeTrackingDualProductTitle
        {
            get { return WebConfig.cpeTrackingDualProductTitle; }
            set { WebConfig.cpeTrackingDualProductTitle = value; }
        }

        //CETracking titles
        public static string cpeTrackingLawProductDescription;
        public static string CpeTrackingLawProductDescription
        {
            get { return WebConfig.cpeTrackingLawProductDescription; }
            set { WebConfig.cpeTrackingLawProductDescription = value; }
        }

        public static string cpeTrackingAccountingProductDescription;
        public static string CpeTrackingAccountingProductDescription
        {
            get { return WebConfig.cpeTrackingAccountingProductDescription; }
            set { WebConfig.cpeTrackingAccountingProductDescription = value; }
        }

        public static string cpeTrackingDualProductDescription;
        public static string CpeTrackingDualProductDescription
        {
            get { return WebConfig.cpeTrackingDualProductDescription; }
            set { WebConfig.cpeTrackingDualProductDescription = value; }
        }
        private static string reconciliationReportLocation;

        public static string ReconciliationReportLocation
        {
            get { return WebConfig.reconciliationReportLocation; }
            set { WebConfig.reconciliationReportLocation = value; }
        }

        #endregion

        //Brand ID's
        #region Brands
        private static int microMashId;
        public static int MicroMashId
        {
            get { return WebConfig.microMashId; }
        }

        private static int passOnlineId;
        public static int PassOnlineId
        {
            get { return WebConfig.passOnlineId; }
        }

        private static int gearUpId;
        public static int GearUpId
        {
            get { return gearUpId; }
        }

        private static int bellLearningId;
        public static int BellLearningId
        {
            get { return bellLearningId; }
        }

        private static int ppcId;
        public static int PpcId
        {
            get { return ppcId; }
        }

        private static int webinarLearningNetworkId;
        public static int WebinarLearningNetworkId
        {
            get { return webinarLearningNetworkId; }
        }

        private static int auditWatchId;
        public static int AuditWatchId
        {
            get { return auditWatchId; }
        }

        private static int riaId;
        public static int RiaId
        {
            get { return riaId; }
        }

        private static int quickFinderId;
        public static int QuickFinderId
        {
            get { return quickFinderId; }
        }

        #endregion

        //Delivery Format ID's
        #region Delivery formats
        private static int onlineId;
        public static int OnlineId
        {
            get { return onlineId; }
        }

        private static int cdId;
        public static int CdId
        {
            get { return cdId; }
        }


        private static int fiveZeroEightId;
        public static int FiveZeroEightId
        {
            get { return fiveZeroEightId; }
        }


        private static int downloadId;
        public static int DownloadId
        {
            get { return downloadId; }
        }

        private static int seminarId;
        public static int SeminarId
        {
            get { return seminarId; }
            set { seminarId = value; }
        }

        private static int webinarId;
        public static int WebinarId
        {
            get { return webinarId; }
            set { webinarId = value; }
        }

        private static int printBasedSelfStudyId;
        public static int PrintBasedSelfStudyId
        {
            get { return printBasedSelfStudyId; }
        }

        private static int inHouseTrainingId;
        public static int InHouseTrainingId
        {
            get { return inHouseTrainingId; }
        }

        private static int conferenceId;
        public static int ConferenceId
        {
            get { return conferenceId; }
            set { conferenceId = value; }
        }
        #endregion

        //Delivery Format Group ID's
        #region Delivery format groups
        private static int groupOnlineLearningSelfStudyId;
        public static int GroupOnlineLearningSelfStudyId
        {
            get { return groupOnlineLearningSelfStudyId; }
        }

        private static int groupPrintBasedSelfStudyId;
        public static int GroupPrintBasedSelfStudyId
        {
            get { return groupPrintBasedSelfStudyId; }
        }
        #endregion

        public static int ServiceLocation { get; set; }

        private static int ethics;

        public static int Ethics
        {
            get { return WebConfig.ethics; }
            set { WebConfig.ethics = value; }
        }
        private static int yellowBook;

        public static int YellowBook
        {
            get { return WebConfig.yellowBook; }
            set { WebConfig.yellowBook = value; }
        }
        private static int webinarLocationId;
        public static int WebinarLocationId
        {
            get { return WebConfig.webinarLocationId; }
            set { WebConfig.webinarLocationId = value; }
        }
        private static string performanceCounterCategoryName;
        public static string PerformanceCounterCategoryName
        {
            get { return WebConfig.performanceCounterCategoryName; }
            set { WebConfig.performanceCounterCategoryName = value; }
        }
        private static int developerMode;
        public static int DeveloperMode
        {
            get { return WebConfig.developerMode; }
            set { WebConfig.developerMode = value; }
        }

        private static string activeDirectoryPath;
        public static string ActiveDirectoryPath
        {
            get { return WebConfig.activeDirectoryPath; }
            set { WebConfig.activeDirectoryPath = value; }
        }

        private static string sponsorLogo;
        public static string SponsorLogo
        {
            get { return string.Concat(rootFolderPath, WebConfig.sponsorLogo); }
            set { WebConfig.sponsorLogo = value; }
        }

        private static string royaltyFrequencies;
        public static string RoyaltyFrequencies
        {
            get { return WebConfig.royaltyFrequencies; }
            set { WebConfig.royaltyFrequencies = value; }
        }

        private static string activeDirectoryUserListFilter;
        public static string ADUserListFilter
        {
            get { return WebConfig.activeDirectoryUserListFilter; }
            set { WebConfig.activeDirectoryUserListFilter = value; }
        }

        private static string activeDirectoryUserDetails;
        public static string ActiveDirectoryUserDetails
        {
            get { return WebConfig.activeDirectoryUserDetails; }
            set { WebConfig.activeDirectoryUserDetails = value; }
        }

        private static string activeDirectoryFirstFilter;
        public static string ActiveDirectoryFirstFilter
        {
            get { return WebConfig.activeDirectoryFirstFilter; }
            set { WebConfig.activeDirectoryFirstFilter = value; }
        }

        private static string resourceImage;
        public static string ResourceImage
        {
            get { return string.Concat(rootFolderPath, WebConfig.resourceImage); }
            set { WebConfig.resourceImage = value; }
        }

        private static string emailSender;
        public static string EmailSender
        {
            get { return WebConfig.emailSender; }
            set { WebConfig.emailSender = value; }
        }

        private static string addNewUserEmailMessage;
        public static string AddNewUserEmailMessage
        {
            get { return WebConfig.addNewUserEmailMessage; }
            set { WebConfig.addNewUserEmailMessage = value; }
        }

        private static string addNewResourceEmailXSLTFile;
        public static string AddNewResourceEmailXSLTFile
        {
            get { return WebConfig.addNewResourceEmailXSLTFile; }
            set { WebConfig.addNewResourceEmailXSLTFile = value; }
        }

        private static string resourceRecordChangeXSLTFile;
        public static string ResourceRecordChangeXSLTFile
        {
            get { return WebConfig.resourceRecordChangeXSLTFile; }
            set { WebConfig.resourceRecordChangeXSLTFile = value; }
        }

        private static string addNewResourceEmailMessage;
        public static string AddNewResourceEmailMessage
        {
            get { return WebConfig.addNewResourceEmailMessage; }
            set { WebConfig.addNewResourceEmailMessage = value; }
        }

        private static string resourceOnlineGroupId;
        public static string ResourceOnlineGroupId
        {
            get { return WebConfig.resourceOnlineGroupId; }
            set { WebConfig.resourceOnlineGroupId = value; }
        }

        private static string certificateTypeResourceRoleId;
        public static string CertificateTypeResourceRoleId
        {
            get { return WebConfig.certificateTypeResourceRoleId; }
            set { WebConfig.certificateTypeResourceRoleId = value; }
        }

        private static string displayCredentialResourceRoleId;
        public static string DisplayCredentialResourceRoleId
        {
            get { return WebConfig.displayCredentialResourceRoleId; }
            set { WebConfig.displayCredentialResourceRoleId = value; }
        }

        private static string addNewUserXSLTFile;
        public static string AddNewUserXSLTFile
        {
            get { return WebConfig.addNewUserXSLTFile; }
            set { WebConfig.addNewUserXSLTFile = value; }

        }

        private static string recordChangeXSLTFile;
        public static string RecordChangeXSLTFile
        {
            get { return WebConfig.recordChangeXSLTFile; }
            set { WebConfig.recordChangeXSLTFile = value; }

        }

        private static string recordChangedEmailMessage;
        public static string RecordChangedEmailMessage
        {
            get { return WebConfig.recordChangedEmailMessage; }
            set { WebConfig.recordChangedEmailMessage = value; }

        }

        private static string displayCredentialAcronymRoleId;
        public static string DisplayCredentialAcronymRoleId
        {
            get { return WebConfig.displayCredentialAcronymRoleId; }
            set { WebConfig.displayCredentialAcronymRoleId = value; }

        }

        private static string pilotTestDeliveryFormats;
        public static string PilotTestDeliveryFormats
        {
            get { return WebConfig.pilotTestDeliveryFormats; }
            set { WebConfig.pilotTestDeliveryFormats = value; }

        }

        private static string pilotTestNasbaYearRange;
        public static string PilotTestNasbaYearRange
        {
            get { return WebConfig.pilotTestNasbaYearRange; }
            set { WebConfig.pilotTestNasbaYearRange = value; }
        }

        private static string onlineGradingYearRange;
        public static string OnlineGradingYearRange
        {
            get { return WebConfig.onlineGradingYearRange; }
            set { WebConfig.onlineGradingYearRange = value; }
        }

        private static string vendorImagesPath;
        public static string VendorImagesPath
        {
            get { return string.Concat(rootFolderPath, WebConfig.vendorImagesPath); }
            set { WebConfig.vendorImagesPath = value; }

        }


        private static string globalTextImagesPath;
        public static string GlobalTextImagesPath
        {
            get { return string.Concat(rootFolderPath, WebConfig.globalTextImagesPath); }
            set { WebConfig.globalTextImagesPath = value; }

        }

        private static string pilotTesterEmailMessage;
        public static string PilotTesterEmailMessage
        {
            get { return WebConfig.pilotTesterEmailMessage; }
            set { WebConfig.pilotTesterEmailMessage = value; }

        }

        private static string pilotTesterXSLTFile;
        public static string PilotTesterXSLTFile
        {
            get { return WebConfig.pilotTesterXSLTFile; }
            set { WebConfig.pilotTesterXSLTFile = value; }

        }

        private static int pilotTestMinutesPerCPECredit;
        public static int PilotTestMinutesPerCPECredit
        {
            get { return WebConfig.pilotTestMinutesPerCPECredit; }
            set { WebConfig.pilotTestMinutesPerCPECredit = value; }

        }

        private static int pilotTesterCompletedStatusId;
        public static int PilotTesterCompletedStatusId
        {
            get { return WebConfig.pilotTesterCompletedStatusId; }
            set { WebConfig.pilotTesterCompletedStatusId = value; }

        }

        private static string notificationSecretKeyPath;
        public static string NotificationSecretKeyPath
        {
            //get { return string.Concat(rootFolderPath, WebConfig.notificationSecretKeyPath); }
            get { return WebConfig.notificationSecretKeyPath; }
            set { WebConfig.notificationSecretKeyPath = value; }
        }

        private static string pilotTestDefaultEmailList;
        public static string PilotTestDefaultEmailList
        {
            get { return WebConfig.pilotTestDefaultEmailList; }
            set { WebConfig.pilotTestDefaultEmailList = value; }
        }


        private static int productPricingScheduleFrequency;

        public static int ProductPricingScheduleFrequency
        {
            get { return WebConfig.productPricingScheduleFrequency; }
            set { WebConfig.productPricingScheduleFrequency = value; }
        }
        private static int retireScheduleFrequency;

        public static int RetireScheduleFrequency
        {
            get { return WebConfig.retireScheduleFrequency; }
            set { WebConfig.retireScheduleFrequency = value; }
        }

        private static string productPricingNotificationEmail;

        public static string ProductPricingNotificationEmail
        {
            get { return WebConfig.productPricingNotificationEmail; }
            set { WebConfig.productPricingNotificationEmail = value; }
        }

        private static int pilotTesterInactiveStatusId;
        public static int PilotTesterInactiveStatusId
        {
            get { return WebConfig.pilotTesterInactiveStatusId; }
            set { WebConfig.pilotTesterInactiveStatusId = value; }
        }

        private static string organizationLogoPath;
        public static string OrganizationLogoPath
        {
            get { return string.Concat(WebConfig.requiredApplicationPath, WebConfig.organizationLogoPath); }
            set { WebConfig.organizationLogoPath = value; }
        }

        private static string pdfPath;
        public static string Pdfpath
        {
            get { return string.Concat(rootFolderPath, WebConfig.pdfPath); }
            set { WebConfig.pdfPath = value; }
        }


        #region Email Notifications

        private static string notificationSmtpServer;
        public static string NotificationSmtpServer
        {
            get { return WebConfig.notificationSmtpServer; }
            set { WebConfig.notificationSmtpServer = value; }
        }

        private static int notificationPortNumber;
        public static int NotificationPortNumber
        {
            get { return WebConfig.notificationPortNumber; }
            set { WebConfig.notificationPortNumber = value; }
        }

        private static string notificationDeliveryMethod;
        public static string NotificationDeliveryMethod
        {
            get { return WebConfig.notificationDeliveryMethod; }
            set { WebConfig.notificationDeliveryMethod = value; }
        }

        private static string notificationTemplatePath;
        public static string NotificationTemplatePath
        {
            get { return WebConfig.notificationTemplatePath; }
            set { WebConfig.notificationTemplatePath = value; }
        }

        private static string pilotTestImageLocation;
        public static string PilotTestImageLocation
        {
            get { return WebConfig.pilotTestImageLocation; }
            set { WebConfig.pilotTestImageLocation = value; }
        }

        private static string pilotTestAcceptButton;
        public static string PilotTestAcceptButton
        {
            get { return WebConfig.pilotTestAcceptButton; }
            set { WebConfig.pilotTestAcceptButton = value; }
        }

        private static string pilotTestRejectButton;
        public static string PilotTestRejectButton
        {
            get { return WebConfig.pilotTestRejectButton; }
            set { WebConfig.pilotTestRejectButton = value; }
        }

        private static int examSupervisorNotificationTemplateId;
        public static int ExamSupervisorNotificationTemplateId
        {
            get { return WebConfig.examSupervisorNotificationTemplateId; }
            set { WebConfig.examSupervisorNotificationTemplateId = value; }
        }

        private static int examCertificateNotificationTemplateId;
        public static int ExamCertificateNotificationTemplateId
        {
            get { return WebConfig.examCertificateNotificationTemplateId; }
            set { WebConfig.examCertificateNotificationTemplateId = value; }
        }

        private static int examFailureNotificationTemplateId;
        public static int ExamFailureNotificationTemplateId
        {
            get { return WebConfig.examFailureNotificationTemplateId; }
            set { WebConfig.examFailureNotificationTemplateId = value; }
        }

        private static int examOwnerNotificationTemplateId;
        public static int ExamOwnerNotificationTemplateId
        {
            get { return WebConfig.examOwnerNotificationTemplateId; }
            set { WebConfig.examOwnerNotificationTemplateId = value; }
        }

        private static int examFailureNoticeMaxTriesTemplateId;
        public static int ExamFailureNoticeMaxTriesTemplateId
        {
            get { return WebConfig.examFailureNoticeMaxTriesTemplateId; }
            set { WebConfig.examFailureNoticeMaxTriesTemplateId = value; }
        }

        private static int threeTimeFailureAdminNotificationTemplateId;
        public static int ThreeTimeFailureAdminNotificationTemplateId
        {
            get { return WebConfig.threeTimeFailureAdminNotificationTemplateId; }
            set { WebConfig.threeTimeFailureAdminNotificationTemplateId = value; }
        }

        private static int fivePeopleFailureAdminNotificationTemplateId;
        public static int FivePeopleFailureAdminNotificationTemplateId
        {
            get { return WebConfig.fivePeopleFailureAdminNotificationTemplateId; }
            set { WebConfig.fivePeopleFailureAdminNotificationTemplateId = value; }
        }
        #endregion

        #region Course/CourseInstance Integration with Metadata
        private static string courseActivityProfileTemplatePath;
        public static string CourseActivityProfileTemplatePath
        {
            get { return WebConfig.courseActivityProfileTemplatePath; }
            set { WebConfig.courseActivityProfileTemplatePath = value; }
        }
        #endregion

        #region Shared Session Management configuration
        private static int applicationId;
        public static int ApplicationId
        {
            get { return WebConfig.applicationId; }
        }

        private static string sessionTokenDomain;

        public static string SessionTokenDomain
        {
            get { return WebConfig.sessionTokenDomain; }
            set { WebConfig.sessionTokenDomain = value; }
        }


        private static int sessionTokenTimeOutValue;

        public static int SessionTokenTimeOutValue
        {
            get { return WebConfig.sessionTokenTimeOutValue; }
            set { WebConfig.sessionTokenTimeOutValue = value; }
        }

        private static string sharedSessionExcludedExtensions;

        public static string SharedSessionExcludedExtensions
        {
            get { return WebConfig.sharedSessionExcludedExtensions; }
            set { WebConfig.sharedSessionExcludedExtensions = value; }
        }

        private static int allowedLoginAttempts;

        public static int AllowedLoginAttempts
        {
            get { return WebConfig.allowedLoginAttempts; }
            set { WebConfig.allowedLoginAttempts = value; }
        }
        private static string requiredApplicationPath;
        public static string RequiredApplicationPath
        {
            get { return WebConfig.requiredApplicationPath; }
            set { WebConfig.requiredApplicationPath = value; }
        }
        private static string checkpointLearningAppPath;
        public static string CheckpointLearningAppPath
        {
            get { return WebConfig.checkpointLearningAppPath; }
            set { WebConfig.checkpointLearningAppPath = value; }
        }

        private static string checkpointApplicationPath;
        public static string CheckpointApplicationPath
        {
            get { return WebConfig.checkpointApplicationPath; }
            set { WebConfig.checkpointApplicationPath = value; }
        }

        private static string pingFederateServerAddress;

        public static string PingFederateServerAddress
        {
            get { return WebConfig.pingFederateServerAddress; }
            set { WebConfig.pingFederateServerAddress = value; }
        }


        private static string coursePlayerApplicationPath;
        public static string CoursePlayerApplicationPath
        {
            get { return WebConfig.coursePlayerApplicationPath; }
        }
        #endregion

        #region Professional /User registration

        private static string registeredSuccessEmailMessage;
        public static string RegisteredSuccessEmailMessage
        {
            get { return WebConfig.registeredSuccessEmailMessage; }
            set { WebConfig.registeredSuccessEmailMessage = value; }
        }

        private static string registeredSuccessEmailTemplate;
        public static string RegisteredSuccessEmailTemplate
        {
            get { return WebConfig.registeredSuccessEmailTemplate; }
            set { WebConfig.registeredSuccessEmailTemplate = value; }
        }

        private static string sendPasswordEmailTemplate;
        public static string SendPasswordEmailTemplate
        {
            get { return WebConfig.sendPasswordEmailTemplate; }
            set { WebConfig.sendPasswordEmailTemplate = value; }
        }

        private static string sendPasswordEmailMessage;
        public static string SendPasswordEmailMessage
        {
            get { return WebConfig.sendPasswordEmailMessage; }
            set { WebConfig.sendPasswordEmailMessage = value; }
        }

        private static string sendUsernameEmailTemplate;
        public static string SendUsernameEmailTemplate
        {
            get { return WebConfig.sendUsernameEmailTemplate; }
            set { WebConfig.sendUsernameEmailTemplate = value; }
        }

        private static string sendUsernameEmailMessage;
        public static string SendUsernameEmailMessage
        {
            get { return WebConfig.sendUsernameEmailMessage; }
            set { WebConfig.sendUsernameEmailMessage = value; }
        }

        private static int minValidSecurityAnswers;
        public static int MinValidSecurityAnswers
        {
            get { return WebConfig.minValidSecurityAnswers; }
            set { WebConfig.minValidSecurityAnswers = value; }
        }
        private static int defaultTimeZoneId;
        public static int DefaultTimeZoneId
        {
            get { return WebConfig.defaultTimeZoneId; }
            set { WebConfig.defaultTimeZoneId = value; }
        }

        private static string encryptionKeyPath;
        public static string EncryptionKeyPath
        {
            get { return WebConfig.encryptionKeyPath; }
            set { WebConfig.encryptionKeyPath = value; }
        }

        private static bool allowPasswordEncryption;
        public static bool AllowPasswordEncryption
        {
            get { return WebConfig.allowPasswordEncryption; }
            set { WebConfig.allowPasswordEncryption = value; }
        }

        private static int maximumForgotLoginAttempts;
        public static int MaximumForgotLoginAttempts
        {
            get { return WebConfig.maximumForgotLoginAttempts; }
            set { WebConfig.maximumForgotLoginAttempts = value; }
        }

        private static int professionalAddressTypeBusiness;
        public static int ProfessionalAddressTypeBusiness
        {
            get { return WebConfig.professionalAddressTypeBusiness; }
            set { WebConfig.professionalAddressTypeBusiness = value; }
        }

        private static string defaultTimeZoneCode;
        public static string DefaultTimeZoneCode
        {
            get { return WebConfig.defaultTimeZoneCode; }
            set { WebConfig.defaultTimeZoneCode = value; }
        }

        private static int defaultStateId;
        public static int DefaultStateId
        {
            get { return WebConfig.defaultStateId; }
            set { WebConfig.defaultStateId = value; }
        }

        private static int defaultCountryId;
        public static int DefaultCountryId
        {
            get { return WebConfig.defaultCountryId; }
            set { WebConfig.defaultCountryId = value; }
        }

        private static string resumesPath;
        public static string ResumesPath
        {
            get { return string.Concat(rootFolderPath, WebConfig.resumesPath); }
            set { WebConfig.resumesPath = value; }

        }

        private static string userRegistrationHelpFile;
        public static string UserRegistrationHelpFile
        {
            get
            {
                return WebConfig.userRegistrationHelpFile;
            }
        }

        #endregion

        private static string pilotTestMediaFormatIds;
        public static string PilotTestMediaFormatIds
        {
            get { return WebConfig.pilotTestMediaFormatIds; }
            set { WebConfig.pilotTestMediaFormatIds = value; }
        }

        private static int txId;
        public static int TXId
        {
            get { return WebConfig.txId; }
            set { WebConfig.txId = value; }
        }

        private static int nyId;
        public static int NYId
        {
            get { return WebConfig.nyId; }
            set { WebConfig.nyId = value; }
        }

        #region Online Grading ReqwiredActivityTypes

        private static string ogsReqwiredActivityTypeProvider;
        public static string OgsReqwiredActivityTypeProvider
        {
            get { return WebConfig.ogsReqwiredActivityTypeProvider; }
            set { WebConfig.ogsReqwiredActivityTypeProvider = value; }
        }

        private static string ogsReqwiredActivityTypeFormat;
        public static string OgsReqwiredActivityTypeFormat
        {
            get { return WebConfig.ogsReqwiredActivityTypeFormat; }
            set { WebConfig.ogsReqwiredActivityTypeFormat = value; }
        }

        #endregion

        #region Online Grading Media Format

        private static string ogsMediaFormatId;
        public static string OgsMediaFormatId
        {
            get { return WebConfig.ogsMediaFormatId; }
            set { WebConfig.ogsMediaFormatId = value; }
        }

        #endregion

        public static string CuasWsdl
        {
            get
            {
                return WebConfig._appSettings["cuasWsdl"];
            }
        }

        private static string _defaultTemplateLocation;
        public static string DefaultTemplateLocation
        {
            get
            {
                return WebConfig._defaultTemplateLocation;
            }
        }

        private static string courseGraphicsImagePath;
        public static string CourseGraphicsImagePath
        {

            get { return string.Concat(rootFolderPath, WebConfig.courseGraphicsImagePath); }
            set { WebConfig.courseGraphicsImagePath = value; }

        }

        private static string _coursePlayerContentDownloadPurchase;
        public static string CoursePlayerContentDownloadPurchase
        {
            get
            {
                return WebConfig._coursePlayerContentDownloadPurchase;
            }
        }

        private static string _coursePlayerContentDownloadPreview;
        public static string CoursePlayerContentDownloadPreview
        {
            get
            {
                return WebConfig._coursePlayerContentDownloadPreview;
            }
        }
        //Common server folder
        private static string rootFolderPath;
        public static string RootFolderPath
        {
            get { return WebConfig.rootFolderPath; }
        }

        #region MediaFormat Ids

        private static string inHouseId;
        public static string InHouseId
        {
            get { return WebConfig.inHouseId; }
            set { WebConfig.inHouseId = value; }
        }

        private static string liveSeminarsAndConferencesId;
        public static string LiveSeminarsAndConferencesId
        {
            get { return WebConfig.liveSeminarsAndConferencesId; }
            set { WebConfig.liveSeminarsAndConferencesId = value; }
        }

        private static string onlineLearningWebinarsId;
        public static string OnlineLearningWebinarsId
        {
            get { return WebConfig.onlineLearningWebinarsId; }
            set { WebConfig.onlineLearningWebinarsId = value; }
        }

        private static string onlineLearningSelfStudyId;
        public static string OnlineLearningSelfStudyId
        {
            get { return WebConfig.onlineLearningSelfStudyId; }
            set { WebConfig.onlineLearningSelfStudyId = value; }
        }

        private static string selfStudyPrintBasedId;
        public static string SelfStudyPrintBasedId
        {
            get { return WebConfig.selfStudyPrintBasedId; }
            set { WebConfig.selfStudyPrintBasedId = value; }
        }


        #endregion

        //Time out settings for Online Grading - Entittlement service calls
        private static double ogsTransactionTimeOutInSeconds;
        public static double OgsTransactionTimeOutInSeconds
        {
            get { return WebConfig.ogsTransactionTimeOutInSeconds; }
            set { WebConfig.ogsTransactionTimeOutInSeconds = value; }
        }

        private static bool showStackTrace;
        public static bool ShowStackTrace
        {
            get { return WebConfig.showStackTrace; }
        }

        // used to turn on/off the user registration functionality
        private static bool isUserRegistrationEnabled;
        public static bool IsUserRegistrationEnabled
        {
            get { return WebConfig.isUserRegistrationEnabled; }
        }

        // used to turn on/off the learning library functionality
        private static bool isLearningLibraryEnabled;
        public static bool IsLearningLibraryEnabled
        {
            get { return WebConfig.isLearningLibraryEnabled; }
        }

        #region Webservice Security

        private static string ssmWebServiceUsername;
        public static string SSMWebServiceUsername
        {
            get { return WebConfig.ssmWebServiceUsername; }
        }

        private static string ssmWebServicePassword;
        public static string SSMWebServicePassword
        {
            get { return WebConfig.ssmWebServicePassword; }
        }

        private static string entitlementWebServiceUsername;
        public static string EntitlementWebServiceUsername
        {
            get { return WebConfig.entitlementWebServiceUsername; }
        }

        private static string entitlementWebServicePassword;
        public static string EntitlementWebServicePassword
        {
            get { return WebConfig.entitlementWebServicePassword; }
        }

        private static string liveEventWebServiceUsername;
        public static string LiveEventWebServiceUsername
        {
            get { return WebConfig.liveEventWebServiceUsername; }
        }

        private static string liveEventWebServicePassword;
        public static string LiveEventWebServicePassword
        {
            get { return WebConfig.liveEventWebServicePassword; }
        }

        private static int ssoRequestTimeoutDurationInMinutes;
        public static int SsoRequestTimeoutDurationInMinutes
        {
            get { return WebConfig.ssoRequestTimeoutDurationInMinutes; }
        }

        #endregion

        private static string entitlementWebServiceAddress;
        public static string EntitlementWebServiceAddress
        {
            get { return WebConfig.entitlementWebServiceAddress; }
        }
        private static string pingAgentConfig;
        public static string PingAgentConfig
        {
            get { return WebConfig.pingAgentConfig; }
        }

        private static bool isMigrationInProgress;
        public static bool IsMigrationInProgress
        {
            get { return WebConfig.isMigrationInProgress; }
        }

        private static string liveEventUserRegistrationEmailTemplate;
        public static string LiveEventUserRegistrationEmailTemplate
        {
            get { return WebConfig.liveEventUserRegistrationEmailTemplate; }
            set { WebConfig.liveEventUserRegistrationEmailTemplate = value; }
        }

        private static string liveEventWebinarModeratorEmailTemplate;
        public static string LiveEventWebinarModeratorEmailTemplate
        {
            get { return WebConfig.liveEventWebinarModeratorEmailTemplate; }
            set { WebConfig.liveEventWebinarModeratorEmailTemplate = value; }
        }

        private static string liveEventOrderWebinarAttendeeEmailMessageTemplate;
        public static string LiveEventOrderWebinarAttendeeEmailMessageTemplate
        {
            get { return WebConfig.liveEventOrderWebinarAttendeeEmailMessageTemplate; }
            set { WebConfig.liveEventOrderWebinarAttendeeEmailMessageTemplate = value; }
        }

        private static string comprehensiveBundlesWebinarRegistrationEmailTemplate;
        public static string ComprehensiveBundlesWebinarRegistrationEmailTemplate
        {
            get { return WebConfig.comprehensiveBundlesWebinarRegistrationEmailTemplate; }
            set { WebConfig.comprehensiveBundlesWebinarRegistrationEmailTemplate = value; }
        }

        private static string liveEventAttendanceTicketNotificationEmaiTemlate;
        public static string LiveEventAttendanceTicketNotificationEmaiTemlate
        {
            get { return WebConfig.liveEventAttendanceTicketNotificationEmaiTemlate; }
            set { WebConfig.liveEventAttendanceTicketNotificationEmaiTemlate = value; }
        }

        private static string liveEventSendReceiptEmailTemplate;
        public static string LiveEventSendReceiptEmailTemplate
        {
            get { return WebConfig.liveEventSendReceiptEmailTemplate; }
            set { WebConfig.liveEventSendReceiptEmailTemplate = value; }
        }

        private static string liveEventAttendanceTicketNotificationOwnerEmailTemplate;
        public static string LiveEventAttendanceTicketNotificationOwnerEmailTemplate
        {
            get { return WebConfig.liveEventAttendanceTicketNotificationOwnerEmailTemplate; }
            set { WebConfig.liveEventAttendanceTicketNotificationOwnerEmailTemplate = value; }
        }

        private static string liveEventProfessionalRegistrationEmailMessage;
        public static string LiveEventProfessionalRegistrationEmailMessage
        {
            get { return WebConfig.liveEventProfessionalRegistrationEmailMessage; }
            set { WebConfig.liveEventProfessionalRegistrationEmailMessage = value; }
        }

        private static string liveEventWebinarModeratorEmailMessage;
        public static string LiveEventWebinarModeratorEmailMessage
        {
            get { return WebConfig.liveEventWebinarModeratorEmailMessage; }
            set { WebConfig.liveEventWebinarModeratorEmailMessage = value; }
        }

        private static string liveEventOrderWebinarAttendeeEmailMessage;
        public static string LiveEventOrderWebinarAttendeeEmailMessage
        {
            get { return WebConfig.liveEventOrderWebinarAttendeeEmailMessage; }
            set { WebConfig.liveEventOrderWebinarAttendeeEmailMessage = value; }
        }

        private static string comprehensiveBundlesWebinarRegistrationEmailMessage;
        public static string ComprehensiveBundlesWebinarRegistrationEmailMessage
        {
            get { return WebConfig.comprehensiveBundlesWebinarRegistrationEmailMessage; }
            set { WebConfig.comprehensiveBundlesWebinarRegistrationEmailMessage = value; }
        }

        private static string liveEventAttendanceWebinarDetailsEmailTemplate;
        public static string LiveEventAttendanceWebinarDetailsEmailTemplate
        {
            get { return WebConfig.liveEventAttendanceWebinarDetailsEmailTemplate; }
            set { WebConfig.liveEventAttendanceWebinarDetailsEmailTemplate = value; }
        }

        private static string fPAssignmentMailTemplateConference;
        public static string FpAssignmentMailTemplateConference
        {
            get { return WebConfig.fPAssignmentMailTemplateConference; }
            set { WebConfig.fPAssignmentMailTemplateConference = value; }
        }

        private static string fPAssignmentMailTemplateSeminarsWorkshops;
        public static string FpAssignmentMailTemplateSeminarsWorkshops
        {
            get { return WebConfig.fPAssignmentMailTemplateSeminarsWorkshops; }
            set { WebConfig.fPAssignmentMailTemplateSeminarsWorkshops = value; }
        }

        private static string fPAssignmentMailTemplateWebinarWebcast;
        public static string FpAssignmentMailTemplateWebinarWebcast
        {
            get { return WebConfig.fPAssignmentMailTemplateWebinarWebcast; }
            set { WebConfig.fPAssignmentMailTemplateWebinarWebcast = value; }
        }

        private static string fPUnAssignmentMailTemplate;
        public static string FpUnAssignmentMailTemplate
        {
            get { return WebConfig.fPUnAssignmentMailTemplate; }
            set { WebConfig.fPUnAssignmentMailTemplate = value; }
        }

        private static string fPAssignmentMailContentConference;
        public static string FpAssignmentMailContentConference
        {
            get { return WebConfig.fPAssignmentMailContentConference; }
            set { WebConfig.fPAssignmentMailContentConference = value; }
        }

        private static string fPAssignmentMailContentSeminarsWorkshops;
        public static string FpAssignmentMailContentSeminarsWorkshops
        {
            get { return WebConfig.fPAssignmentMailContentSeminarsWorkshops; }
            set { WebConfig.fPAssignmentMailContentSeminarsWorkshops = value; }
        }

        private static string fPAssignmentMailContentWebinarWebcast;
        public static string FpAssignmentMailContentWebinarWebcast
        {
            get { return WebConfig.fPAssignmentMailContentWebinarWebcast; }
            set { WebConfig.fPAssignmentMailContentWebinarWebcast = value; }
        }

        private static string fPUnAssignmentMailContent;
        public static string FpUnAssignmentMailContent
        {
            get { return WebConfig.fPUnAssignmentMailContent; }
            set { WebConfig.fPUnAssignmentMailContent = value; }
        }

        private static string fAOrderConfirmationMailTemplate;
        public static string FAOrderConfirmationMailTemplate
        {
            get { return WebConfig.fAOrderConfirmationMailTemplate; }
            set { WebConfig.fAOrderConfirmationMailTemplate = value; }
        }

        private static string fAOrderConfirmationMailContent;
        public static string FAOrderConfirmationMailContent
        {
            get { return WebConfig.fAOrderConfirmationMailContent; }
            set { WebConfig.fAOrderConfirmationMailContent = value; }
        }

        public static string BaseHelpURL
        {
            get
            {
                return WebConfig._baseHelpURL;
            }
        } static string _baseHelpURL;

        #region NAS Test

        private static string nasFolderPath;
        public static string NasFolderPath
        {
            get
            {
                return WebConfig.nasFolderPath;
            }
            set
            {
                WebConfig.nasFolderPath = value;
            }
        }

        private static string nasFolderName;
        public static string NasFolderName
        {
            get { return WebConfig.nasFolderName; }
            set { WebConfig.nasFolderName = value; }
        }

        private static string nasUsername;
        public static string NasUsername
        {
            get { return WebConfig.nasUsername; }
            set { WebConfig.nasUsername = value; }
        }

        private static string nasPassword;
        public static string NasPassword
        {
            get { return WebConfig.nasPassword; }
            set { WebConfig.nasPassword = value; }
        }

        private static string nasDomain;
        public static string NasDomain
        {
            get { return WebConfig.nasDomain; }
            set { WebConfig.nasDomain = value; }
        }

        private static string nasUploadPath;
        public static string NasUploadPath
        {
            get { return WebConfig.nasUploadPath; }
            set { WebConfig.nasUploadPath = value; }
        }

        public static string SponsorLogoNasFolderPath
        {
            get { return WebConfig.sponsorLogo; }
            set { WebConfig.sponsorLogo = value; }
        }

        public static string ResourceImageNasFolderPath
        {
            get { return WebConfig.resourceImage; }
            set { WebConfig.resourceImage = value; }
        }

        public static string VendorImagesNasFolderPath
        {
            get { return WebConfig.vendorImagesPath; }
            set { WebConfig.vendorImagesPath = value; }
        }

        public static string GlobalTextImagesNasFolderPath
        {
            get { return WebConfig.globalTextImagesPath; }
            set { WebConfig.globalTextImagesPath = value; }
        }

        public static string ResumesNasFolderPath
        {
            get { return WebConfig.resumesPath; }
            set { WebConfig.resumesPath = value; }
        }

        private static string brandImageNasFolderPath;
        public static string BrandImageNasFolderPath
        {
            get { return WebConfig.brandImageNasFolderPath; }
            set { WebConfig.brandImageNasFolderPath = value; }
        }
        #endregion

        #region Shopping Cart

        public static string EmailAdminSubjectLine
        {
            get
            {
                return WebConfig._emailAdminSubjectLine;
            }
        } static string _emailAdminSubjectLine;

        public static string PayOnAccountText
        {
            get
            {
                return WebConfig._payOnAccountText;
            }
        } static string _payOnAccountText;

        public static string TechSupportEmailAddress
        {
            get
            {
                return WebConfig._techSupportEmailAddress;
            }
        } static string _techSupportEmailAddress;

        public static string VisibleLineItemTypes
        {
            get
            {
                return WebConfig._visibleLineItemTypes;
            }
        } static string _visibleLineItemTypes;

        public static string DefaultPromoCode
        {
            get
            {
                return WebConfig._defaultPromoCode;
            }
        } static string _defaultPromoCode;

        public static string DefaultMailSource
        {
            get
            {
                return WebConfig._defaultMailSource;
            }
        } static string _defaultMailSource;

        public static string DefaultItemSet
        {
            get
            {
                return WebConfig._defaultItemSet;
            }
        } static string _defaultItemSet;

        public static string DefaultAddressCode
        {
            get
            {
                return WebConfig._defaultAddressCode;
            }
        } static string _defaultAddressCode;

        public static string DefaultOrderType
        {
            get
            {
                return WebConfig._defaultOrderType;
            }
        } static string _defaultOrderType;

        public static string DefaultGetPriceOrderType
        {
            get
            {
                return WebConfig._defaultGetPriceOrderType;
            }
        } static string _defaultGetPriceOrderType;

        public static string CuasOrderSource
        {
            get
            {
                return WebConfig._cuasOrderSource;
            }
        } static string _cuasOrderSource;

        public static string UnisonOperator
        {
            get
            {
                return WebConfig._unisonOperator;
            }
        } static string _unisonOperator;

        public static string AllowedCreditCardTypes
        {
            get
            {
                return WebConfig._allowedCreditCardTypes;
            }
        } static string _allowedCreditCardTypes;

        public static string ExpirationYears
        {
            get
            {
                return WebConfig._expirationYears;
            }
        } static string _expirationYears;

        public static string ExpirationMonths
        {
            get
            {
                return WebConfig._expirationMonths;
            }
        } static string _expirationMonths;

        public static string CcMerchantGUID
        {
            get
            {
                return WebConfig._ccMerchantGUID;
            }
        } static string _ccMerchantGUID;

        public static string DefaultOrderLineAdd
        {
            get
            {
                return WebConfig._defaultOrderLineAdd;
            }
        } static string _defaultOrderLineAdd;

        public static int UpsellDisplayItemsPerLineItem
        {
            get
            {
                return WebConfig._upsellDisplayItemsPerLineItem;
            }
        } static int _upsellDisplayItemsPerLineItem;

        public static int UpsellDisplayRowsPerOrder
        {
            get
            {
                return WebConfig._upsellDisplayRowsPerOrder;
            }
        } static int _upsellDisplayRowsPerOrder;

        public static string UpsellOnlineMediaIconPath
        {
            get
            {
                return WebConfig._upsellOnlineMediaIconPath;
            }
        } static string _upsellOnlineMediaIconPath;

        public static string UpsellPrintMediaIconPath
        {
            get
            {
                return WebConfig._upsellPrintMediaIconPath;
            }
        } static string _upsellPrintMediaIconPath;

        public static string UpsellDownloadMediaIconPath
        {
            get
            {
                return WebConfig._upsellDownloadMediaIconPath;
            }
        } static string _upsellDownloadMediaIconPath;

        public static string SalesPhoneNumber
        {
            get
            {
                return WebConfig._salesPhoneNumber;
            }
        } static string _salesPhoneNumber;

        public static string BillingStates
        {
            get
            {
                return WebConfig._billingStates;
            }
        } static string _billingStates;

        #endregion

        #region Content Management System

        public static string CmsWSDL
        {
            get
            {
                return WebConfig._cmsWSDL;
            }
        } static string _cmsWSDL;

        public static string CmsSite
        {
            get
            {
                return WebConfig._cmsSite;
            }
        } static string _cmsSite;

        public static string CmsContentType
        {
            get
            {
                return WebConfig._cmsContentType;
            }

        } static string _cmsContentType;

        public static string CmsWorkFlowState
        {
            get
            {
                return WebConfig._cmsWorkFlowState;
            }
        } static string _cmsWorkFlowState;

        #endregion

        #region CPL Data Migration

        /// <summary>
        /// Migration Sender Email Adreess
        /// </summary>
        private static string migrationSenderEmailAddress;
        public static string MigrationSenderEmailAddress
        {
            get { return WebConfig.migrationSenderEmailAddress; }
        }

        /// <summary>
        /// Migration failed XSLT File Name
        /// </summary>
        private static string migrationFailedEmailXsltFileName;
        public static string MigrationFailedEmailXsltFileName
        {
            get { return WebConfig.migrationFailedEmailXsltFileName; }
        }

        /// <summary>
        /// Migration success XSLT File Name
        /// </summary>
        private static string migrationSuccessEmailXsltFileName;
        public static string MigrationSuccessEmailXsltFileName
        {
            get { return WebConfig.migrationSuccessEmailXsltFileName; }
        }

        /// <summary>
        /// Migration Receiver Email Address
        /// </summary> 
        private static string migrationReceiverEmailAddress;
        public static string MigrationReceiverEmailAddress
        {
            get { return WebConfig.migrationReceiverEmailAddress; }
        }

        /// <summary>
        /// Migration Failed Email Subject
        /// </summary>
        private static string migrationFailedEmailSubject;
        public static string MigrationFailedEmailSubject
        {
            get { return WebConfig.migrationFailedEmailSubject; }
        }

        /// <summary>
        /// Migration Failed Email Subject
        /// </summary>
        private static string migrationSuccessEmailSubject;
        public static string MigrationSuccessEmailSubject
        {
            get { return WebConfig.migrationSuccessEmailSubject; }
        }

        /// <summary>
        /// Migration logger messege maximum length
        /// </summary>
        private static int maxLogMessageLength;
        public static int MaxLogMessageLength
        {
            get { return maxLogMessageLength; }
        }

        /// <summary>
        /// Migration logger techinical details maximum length
        /// </summary>
        private static int maxLogTechnicalDetailsLength;
        public static int MaxLogTechnicalDetailsLength
        {
            get { return maxLogTechnicalDetailsLength; }
        }

        /// <summary>
        /// Maximum number of simultenious jobs that the execution manager execute
        /// </summary>
        private static int maxSimulteniouslyExecutingJobCount;
        public static int MaxSimulteniouslyExecutingJobCount
        {
            get { return maxSimulteniouslyExecutingJobCount; }
        }

        /// <summary>
        /// Reqwired 3D web service user name
        /// </summary>
        private static string reqwired3DWebServiceUserName;
        public static string Reqwired3DWebServiceUserName
        {
            get { return reqwired3DWebServiceUserName; }
        }

        /// <summary>
        /// Reqwired 3D web service password
        /// </summary>
        private static string reqwired3DWebServicePassword;
        public static string Reqwired3DWebServicePassword
        {
            get { return reqwired3DWebServicePassword; }
        }

        /// <summary>
        /// Migration Online Grading IP WebService address
        /// </summary>
        private static string migrationOnlineGradingIPWebServiceAddress;
        public static string MigrationOnlineGradingIPWebServiceAddress
        {
            get { return migrationOnlineGradingIPWebServiceAddress; }
        }

        /// <summary>
        /// Migration Reqwired 3D IP WebService address
        /// </summary>
        private static string migrationReqwired3DIPWebServiceAddress;
        public static string MigrationReqwired3DIPWebServiceAddress
        {
            get { return migrationReqwired3DIPWebServiceAddress; }
        }

        /// <summary>
        /// Migration Micro Mash IP WebService address
        /// </summary>
        private static string migrationMicroMashIPWebServiceAddress;
        public static string MigrationMicroMashIPWebServiceAddress
        {
            get { return migrationMicroMashIPWebServiceAddress; }
        }

        /// <summary>
        /// Migration Pass Online IP WebService address
        /// </summary>
        private static string migrationPassOnlineIPWebServiceAddress;
        public static string MigrationPassOnlineIPWebServiceAddress
        {
            get { return migrationPassOnlineIPWebServiceAddress; }
        }

        /// <summary>
        /// IP data import web service address
        /// </summary>
        private static string migrationIpDataImportWebService;
        public static string MigrationIpDataImportWebService
        {
            get { return migrationIpDataImportWebService; }
        }

        /// <summary>
        /// Migration Queue Polling Interval
        /// </summary>
        private static int migrationQueuePollingInterval;
        public static int MigrationQueuePollingInterval
        {
            get { return migrationQueuePollingInterval; }
        }

        /// <summary>
        /// Migration technical handling note notification Subject
        /// </summary>
        private static string technicalHandlingNoteNotificationSubject;
        public static string TechnicalHandlingNoteNotificationSubject
        {
            get { return technicalHandlingNoteNotificationSubject; }
        }

        /// <summary>
        /// Migration technical handling note notification receiver email address
        /// </summary>
        private static string technicalHandlingNoteReceiverEmailAddress;
        public static string TechnicalHandlingNoteReceiverEmailAddress
        {
            get { return technicalHandlingNoteReceiverEmailAddress; }
        }

        /// <summary>
        /// Migration technical handling note notification XSLT file name
        /// </summary>
        private static string technicalHandlingNoteXsltFileName;
        public static string TechnicalHandlingNoteXsltFileName
        {
            get { return technicalHandlingNoteXsltFileName; }
        }

        /// <summary>
        /// Migration Default Item Set
        /// </summary>
        private static string migrationDefaultItemSet;
        public static string MigrationDefaultItemSet
        {
            get { return WebConfig.migrationDefaultItemSet; }
            set { WebConfig.migrationDefaultItemSet = value; }
        }

        /// <summary>
        /// Migration Default Promo Code
        /// </summary>
        private static string migrationDefaultPromoCode;
        public static string MigrationDefaultPromoCode
        {
            get { return WebConfig.migrationDefaultPromoCode; }
            set { WebConfig.migrationDefaultPromoCode = value; }
        }

        /// <summary>
        /// Migration Default Mail Source
        /// </summary>
        private static string migrationDefaultMailSource;
        public static string MigrationDefaultMailSource
        {
            get { return WebConfig.migrationDefaultMailSource; }
            set { WebConfig.migrationDefaultMailSource = value; }
        }

        /// <summary>
        /// MigrationDefaultOrderLineAdd
        /// </summary>
        private static string migrationDefaultOrderLineAdd;
        public static string MigrationDefaultOrderLineAdd
        {
            get { return WebConfig.migrationDefaultOrderLineAdd; }
            set { WebConfig.migrationDefaultOrderLineAdd = value; }
        }

        /// <summary>
        /// MigrationUnisonOperator
        /// </summary>
        private static string migrationUnisonOperator;
        public static string MigrationUnisonOperator
        {
            get { return WebConfig.migrationUnisonOperator; }
            set { WebConfig.migrationUnisonOperator = value; }
        }

        /// <summary>
        /// MigrationDefaultOrderType
        /// </summary>
        private static string migrationDefaultOrderType;
        public static string MigrationDefaultOrderType
        {
            get { return WebConfig.migrationDefaultOrderType; }
            set { WebConfig.migrationDefaultOrderType = value; }
        }

        /// <summary>
        /// Migration CuasOrderSource
        /// </summary>
        private static string migrationCuasOrderSource;
        public static string MigrationCuasOrderSource
        {
            get { return WebConfig.migrationCuasOrderSource; }
            set { WebConfig.migrationCuasOrderSource = value; }
        }

        /// <summary>
        /// Migration DefaultAddressCode
        /// </summary>
        private static string migrationDefaultAddressCode;
        public static string MigrationDefaultAddressCode
        {
            get { return WebConfig.migrationDefaultAddressCode; }
            set { WebConfig.migrationDefaultAddressCode = value; }
        }

        /// <summary>
        /// Migration ProductionDataTransfer Job
        /// </summary>
        private static string migrationProductionDataTransferJob;
        public static string MigrationProductionDataTransferJob
        {
            get { return WebConfig.migrationProductionDataTransferJob; }
            set { WebConfig.migrationProductionDataTransferJob = value; }
        }


        /// <summary>
        /// Used to Enable and Disable DataMigration Schedular
        /// </summary>
        private static bool datamigrationEnable;
        public static bool DatamigrationEnable
        {
            get { return WebConfig.datamigrationEnable; }
            set { WebConfig.datamigrationEnable = value; }
        }


        #endregion

        #region Order Processing

        /// <summary>
        /// Unison web service address
        /// </summary>
        private static string unisonWebServiceAddress;
        public static string UnisonWebServiceAddress
        {
            get { return WebConfig.unisonWebServiceAddress; }
            set { WebConfig.unisonWebServiceAddress = value; }
        }


        #endregion

        #region Help Settings

        /// <summary>
        /// Base Help Url
        /// </summary>
        private static string baseHelpUrl;
        public static string BaseHelpUrl
        {
            get { return WebConfig.baseHelpUrl; }
        }

        #endregion

        #region Entitlement
        /// <summary>
        /// A_Package Package type
        /// </summary>
        private static int bundlePackageType;
        public static int BundlePackageType
        {
            get { return WebConfig.bundlePackageType; }
            set { WebConfig.bundlePackageType = value; }
        }

        /// <summary>
        /// CPE Tracking Law Product Code
        /// </summary>
        private static string cpeTrackingLawProductCode;
        public static string CpeTrackingLawProductCode
        {
            get { return WebConfig.cpeTrackingLawProductCode; }
            set { WebConfig.cpeTrackingLawProductCode = value; }
        }

        /// <summary>
        /// CPE Tracking Accounting Product Code
        /// </summary>
        private static string cpeTrackingAccountingProductCode;
        public static string CpeTrackingAccountingProductCode
        {
            get { return WebConfig.cpeTrackingAccountingProductCode; }
            set { WebConfig.cpeTrackingAccountingProductCode = value; }
        }

        /// <summary>
        /// CPE Tracking Dual Product Code
        /// </summary>
        private static string cpeTrackingDualProductCode;
        public static string CpeTrackingDualProductCode
        {
            get { return WebConfig.cpeTrackingDualProductCode; }
            set { WebConfig.cpeTrackingDualProductCode = value; }
        }
        #endregion

        #region Auto Notification
        private static float autoNotificationEmailScheduleFrequency;
        public static float AutoNotificationEmailScheduleFrequency
        {
            get { return WebConfig.autoNotificationEmailScheduleFrequency; }
            set { WebConfig.autoNotificationEmailScheduleFrequency = value; }
        }

        private static string autoNotifyEmailFromAddress;
        public static string AutoNotificationEmailFromAddress
        {
            get { return WebConfig.autoNotifyEmailFromAddress; }
            set { WebConfig.autoNotifyEmailFromAddress = value; }
        }
        #endregion

        #region ProfilingOnline
        private static string profilingOnlineURL;
        public static string ProfilingOnlineURL
        {
            get { return WebConfig.profilingOnlineURL; }
            set { WebConfig.profilingOnlineURL = value; }
        }
        private static string pingAgentConfigForProfilingOnline;
        public static string PingAgentConfigForProfilingOnline
        {
            get { return WebConfig.pingAgentConfigForProfilingOnline; }
            //set { WebConfig.pingAgentConfigForProfilingOnline = value; }
        }
        private static string pingFederateServerAddressForProfilingOnline;
        public static string PingFederateServerAddressForProfilingOnline
        {
            get { return WebConfig.pingFederateServerAddressForProfilingOnline; }
            set { WebConfig.pingFederateServerAddressForProfilingOnline = value; }
        }
        private static string profilingOnlineMarketingPageAddress;
        public static string ProfilingOnlineMarketingPageAddress
        {
            get { return WebConfig.profilingOnlineMarketingPageAddress; }
            set { WebConfig.profilingOnlineMarketingPageAddress = value; }
        }
        private static string profilingOnlineConnectionId;
        public static string ProfilingOnlineConnectionId
        {
            get { return WebConfig.profilingOnlineConnectionId; }
            set { WebConfig.profilingOnlineConnectionId = value; }
        }
        #endregion

        #region Phone Numbers
        private static string cplSupportPhoneNo;
        public static string CplSupportPhoneNo
        {
            get { return WebConfig.cplSupportPhoneNo; }
            set { WebConfig.cplSupportPhoneNo = value; }
        }

        private static string cplSalesPhoneNo;
        public static string CplSalesPhoneNo
        {
            get { return WebConfig.cplSalesPhoneNo; }
            set { WebConfig.cplSalesPhoneNo = value; }
        }

        private static string bellPoliciesPhoneNo;
        public static string BellPoliciesPhoneNo
        {
            get { return WebConfig.bellPoliciesPhoneNo; }
            set { WebConfig.bellPoliciesPhoneNo = value; }
        }

        private static string courseDetailsPhoneNo;
        public static string CourseDetailsPhoneNo
        {
            get { return WebConfig.courseDetailsPhoneNo; }
            set { WebConfig.courseDetailsPhoneNo = value; }
        }

        private static string microMashPoliciesPhoneNo;
        public static string MicroMashPoliciesPhoneNo
        {
            get { return WebConfig.microMashPoliciesPhoneNo; }
            set { WebConfig.microMashPoliciesPhoneNo = value; }
        }

        private static string courseFinderPhoneNo;
        public static string CourseFinderPhoneNo
        {
            get { return WebConfig.courseFinderPhoneNo; }
            set { WebConfig.courseFinderPhoneNo = value; }
        }
        #endregion

        #region Coming Soon

        #region Email Template

        private static string comingSoonInquiryEmail;
        public static string ComingSoonInquiryEmail
        {
            get { return WebConfig.comingSoonInquiryEmail; }
            set { WebConfig.comingSoonInquiryEmail = value; }
        }

        private static string comingSoonInquirySubject;
        public static string ComingSoonInquirySubject
        {
            get { return WebConfig.comingSoonInquirySubject; }
            set { WebConfig.comingSoonInquirySubject = value; }
        }

        private static string comingSoonInquiryBody;
        public static string ComingSoonInquiryBody
        {
            get { return WebConfig.comingSoonInquiryBody; }
            set { WebConfig.comingSoonInquiryBody = value; }
        }

        #endregion


        private static string uploadDocumentPath;
        public static string UploadDocumentPath
        {
            get { return WebConfig.uploadDocumentPath; }
            set { WebConfig.uploadDocumentPath = value; }
        }
        private static string webinarReminderBccList;
        public static string WebinarReminderBccList
        {
            get { return WebConfig.webinarReminderBccList; }
            set { WebConfig.webinarReminderBccList = value; }
        }

        private static string webinarReminderUsername;
        public static string WebinarReminderUsername
        {
            get { return WebConfig.webinarReminderUsername; }
            set { WebConfig.webinarReminderUsername = value; }
        }
        private static string webinarReminderPassword;
        public static string WebinarReminderPassword
        {
            get { return WebConfig.webinarReminderPassword; }
            set { WebConfig.webinarReminderPassword = value; }
        }
        private static string webinarReminderDomain;
        public static string WebinarReminderDomain
        {
            get { return WebConfig.webinarReminderDomain; }
            set { WebConfig.webinarReminderDomain = value; }
        }

        private static string webinarEmailSender;
        public static string WebinarEmailSender
        {
            get { return WebConfig.webinarEmailSender; }
            set { WebConfig.webinarEmailSender = value; }
        }

        #endregion

        #region SSRS Reports

        private static string sSRSReprotServerUrl;
        public static string SSRSReprotServerUrl
        {
            get { return WebConfig.sSRSReprotServerUrl; }
            set { WebConfig.sSRSReprotServerUrl = value; }
        }
        private static string sSRSUserName;
        public static string SSRSUserName
        {
            get { return WebConfig.sSRSUserName; }
            set { WebConfig.sSRSUserName = value; }
        }
        private static string sSRSPassword;
        public static string SSRSPassword
        {
            get { return WebConfig.sSRSPassword; }
            set { WebConfig.sSRSPassword = value; }
        }
        private static string sSRSLmsUrl;
        public static string SSRSLmsUrl
        {
            get { return WebConfig.sSRSLmsUrl; }
            set { WebConfig.sSRSLmsUrl = value; }
        }
        private static string sSRSLmsOrganizationFilter;
        public static string SSRSLmsOrganizationFilter
        {
            get { return WebConfig.sSRSLmsOrganizationFilter; }
            set { WebConfig.sSRSLmsOrganizationFilter = value; }
        }




        #endregion

        #region CourseFinder

        private static string findCpeTopics;
        public static string FindCpeTopics
        {
            get { return WebConfig.findCpeTopics; }
            set { WebConfig.findCpeTopics = value; }
        }

        private static string findCpeBrands;
        public static string FindCpeBrands
        {
            get { return WebConfig.findCpeBrands; }
            set { WebConfig.findCpeBrands = value; }
        }

        private static string findCpeDeliveryFormats;
        public static string FindCpeDeliveryFormats
        {
            get { return WebConfig.findCpeDeliveryFormats; }
            set { WebConfig.findCpeDeliveryFormats = value; }
        }

        private static string findCpeMediaFormats;
        public static string FindCpeMediaFormats
        {
            get { return WebConfig.findCpeMediaFormats; }
            set { WebConfig.findCpeMediaFormats = value; }
        }

        #endregion

        #region MyCPE

        private static string myCpeTopics;
        public static string MyCpeTopics
        {
            get { return WebConfig.myCpeTopics; }
            set { WebConfig.myCpeTopics = value; }
        }

        private static string myCpeBrands;
        public static string MyCpeBrands
        {
            get { return WebConfig.myCpeBrands; }
            set { WebConfig.myCpeBrands = value; }
        }

        private static string myCpeDeliveryFormats;
        public static string MyCpeDeliveryFormats
        {
            get { return WebConfig.myCpeDeliveryFormats; }
            set { WebConfig.myCpeDeliveryFormats = value; }
        }

        private static string myCpeMediaFormats;
        public static string MyCpeMediaFormats
        {
            get { return WebConfig.myCpeMediaFormats; }
            set { WebConfig.myCpeMediaFormats = value; }
        }

        #endregion

        #region LiveEventDeliveryFormats

        private static string seminarConferenceDeliveryFormat;
        public static string SeminarConferenceDeliveryFormat
        {
            get { return WebConfig.seminarConferenceDeliveryFormat; }
            set { WebConfig.seminarConferenceDeliveryFormat = value; }
        }

        private static string nonLiveEventDeliveryFormat;
        public static string NonLiveEventDeliveryFormat
        {
            get { return WebConfig.nonLiveEventDeliveryFormat; }
            set { WebConfig.nonLiveEventDeliveryFormat = value; }
        }

        private static string liveEventMediaFormats;
        public static string LiveEventMediaFormats
        {
            get { return WebConfig.liveEventMediaFormats; }
            set { WebConfig.liveEventMediaFormats = value; }
        }

        private static string liveEventAttendanceManagmentBrands;
        public static string LiveEventAttendanceManagmentBrands
        {
            get { return WebConfig.liveEventAttendanceManagmentBrands; }
            set { WebConfig.liveEventAttendanceManagmentBrands = value; }
        }


        private static string liveEventConferenceCourseTypeId;
        public static string LiveEventConferenceCourseTypeId
        {
            get { return WebConfig.liveEventConferenceCourseTypeId; }
            set { WebConfig.liveEventConferenceCourseTypeId = value; }
        }

        private static string liveEventSeminarId;
        public static string LiveEventSeminarId
        {
            get { return WebConfig.liveEventSeminarId; }
            set { WebConfig.liveEventSeminarId = value; }
        }

        private static string liveEventConferenceId;
        public static string LiveEventConferenceId
        {
            get { return WebConfig.liveEventConferenceId; }
            set { WebConfig.liveEventConferenceId = value; }
        }

        private static string liveEventWorkshopId;
        public static string LiveEventWorkshopId
        {
            get { return WebConfig.liveEventWorkshopId; }
            set { WebConfig.liveEventWorkshopId = value; }
        }

        private static string liveEventWebinarId;
        public static string LiveEventWebinarId
        {
            get { return WebConfig.liveEventWebinarId; }
            set { WebConfig.liveEventWebinarId = value; }
        }
        #endregion

        #region IRS

        private static string irsSelfRegistrationRedirectUrl;
        public static string IrsSelfRegistrationRedirectUrl
        {
            get { return WebConfig.irsSelfRegistrationRedirectUrl; }
            set { WebConfig.irsSelfRegistrationRedirectUrl = value; }
        }

        private static string irsPrimeSiteId;
        public static string IrsPrimeSiteId
        {
            get { return WebConfig.irsPrimeSiteId; }
            set { WebConfig.irsPrimeSiteId = value; }
        }

        private static string irsMainSiteId;
        public static string IrsMainSiteId
        {
            get { return WebConfig.irsMainSiteId; }
            set { WebConfig.irsMainSiteId = value; }
        }

        private static string irsUserRegistrationEmailTemplate;
        public static string IrsUserRegistrationEmailTemplate
        {
            get { return WebConfig.irsUserRegistrationEmailTemplate; }
            set { WebConfig.irsUserRegistrationEmailTemplate = value; }
        }

        private static string irsUserRegistrationEmailContent;
        public static string IrsUserRegistrationEmailContent
        {
            get { return WebConfig.irsUserRegistrationEmailContent; }
            set { WebConfig.irsUserRegistrationEmailContent = value; }
        }

        private static string irsSponsorLandingPageUrl;
        public static string IrsSponsorLandingPageUrl
        {
            get { return WebConfig.irsSponsorLandingPageUrl; }
            set { WebConfig.irsSponsorLandingPageUrl = value; }
        }

        private static string irsForgotLoginEmailTemplate;
        public static string IRSForgotLoginEmailTemplate
        {
            get { return WebConfig.irsForgotLoginEmailTemplate; }
            set { WebConfig.irsForgotLoginEmailTemplate = value; }
        }
        private static string irsForgotLoginEmailContent;
        public static string IRSForgotLoginEmailContent
        {
            get { return WebConfig.irsForgotLoginEmailContent; }
            set { WebConfig.irsForgotLoginEmailContent = value; }
        }
        private static string irsForgotLoginRecievierEmailAddress;
        public static string IrsForgotLoginRecievierEmailAddress
        {
            get { return WebConfig.irsForgotLoginRecievierEmailAddress; }
            set { WebConfig.irsForgotLoginRecievierEmailAddress = value; }
        }

        #endregion
        #region Versioning
        private static string versionCategoryIdForNewAcronym;
        public static string VersionCategoryIdForNewAcronym
        {
            get { return WebConfig.versionCategoryIdForNewAcronym; }
            set { WebConfig.versionCategoryIdForNewAcronym = value; }
        }
        private static string onlineCourseStatusInitialId;
        public static string OnlineCourseStatusInitialId
        {
            get { return WebConfig.onlineCourseStatusInitialId; }
            set { WebConfig.onlineCourseStatusInitialId = value; }
        }

        private static string senderEmailAddressForCancelNotification;
        public static string SenderEmailAddressForCancelNotification
        {
            get { return WebConfig.senderEmailAddressForCancelNotification; }
            set { WebConfig.senderEmailAddressForCancelNotification = value; }
        }
        private static int retiredRetention;
        public static int RetiredRetention
        {
            get { return WebConfig.retiredRetention; }
            set { WebConfig.retiredRetention = value; }
        }
        private static int courseLaunchRestriction;
        public static int CourseLaunchRestriction
        {
            get { return WebConfig.courseLaunchRestriction; }
            set { WebConfig.courseLaunchRestriction = value; }
        }


        #endregion


        #region //CourseSponsor
        private static string liveEventCourseSponsors;
        public static string LiveEventCourseSponsors
        {
            get { return WebConfig.liveEventCourseSponsors; }
            set { WebConfig.liveEventCourseSponsors = value; }
        }

        private static string nonLiveEventCourseSponsors;
        public static string NonLiveEventCourseSponsors
        {
            get { return WebConfig.nonLiveEventCourseSponsors; }
            set { WebConfig.nonLiveEventCourseSponsors = value; }
        }

        private static string gearUpWorkshopSponsors;
        public static string GearUpWorkshopSponsors
        {
            get { return WebConfig.gearUpWorkshopSponsors; }
        }
        #endregion

        #region Pilot Test Attachments
        //Defect fix for #83375 :Pilot Testing: Add Autorespone Message when user registers to be a Pilot Tester
        //Attachment folder path
        private static string pilotTestRegistrationAttachmentFolderPath;
        public static string PilotTestRegistrationAttachmentFolderPath
        {
            get { return pilotTestRegistrationAttachmentFolderPath; }
            set { WebConfig.pilotTestRegistrationAttachmentFolderPath = value; }
        }
        //Attachmnet files
        private static string pilotTestRegistrationAttachmentFiles;
        public static string PilotTestRegistrationAttachmentFiles
        {
            get { return pilotTestRegistrationAttachmentFiles; }
            set { WebConfig.pilotTestRegistrationAttachmentFiles = value; }
        }

        //PilotTest Reply address
        private static string pilotTestReplyAddress;
        public static string PilotTestReplyAddress
        {
            get { return WebConfig.pilotTestReplyAddress; }
            set { WebConfig.pilotTestReplyAddress = value; }
        }

        #endregion

        #region Profiling Online Competency Model
        //Competency Model IP Product code
        private static string competencyModelIPProductCode;
        public static string CompetencyModelIPProductCode
        {
            get { return competencyModelIPProductCode; }
            set { WebConfig.competencyModelIPProductCode = value; }
        }
        //Competency Model IP Product title
        private static string competencyModelIPProductTitle;
        public static string CompetencyModelIPProductTitle
        {
            get { return competencyModelIPProductTitle; }
            set { WebConfig.competencyModelIPProductTitle = value; }
        }
        //Competency Models IP Product description
        private static string competencyModelIPProductDescription;
        public static string CompetencyModelIPProductDescription
        {
            get { return competencyModelIPProductDescription; }
            set { WebConfig.competencyModelIPProductDescription = value; }
        }
        #endregion

        /// <summary>
        /// Competency Model Product Code
        /// </summary>
        private static string competencyModelProductCode;
        public static string CompetencyModelProductCode
        {
            get { return WebConfig.competencyModelProductCode; }
            set { WebConfig.competencyModelProductCode = value; }
        }

        private static string certificateEmailSendingWebServiceAddress;

        /// <summary>
        /// Send certificate email web service address
        /// </summary>
        public static string CertificateEmailSendingWebServiceAddress
        {
            get { return WebConfig.certificateEmailSendingWebServiceAddress; }
            set { WebConfig.certificateEmailSendingWebServiceAddress = value; }
        }

        #region Cloud Storage
        private static string cloudUrl;
        public static string CloudUrl
        {
            get { return cloudUrl; }
        }

        private static string cloudIssuerName;
        public static string CloudIssuerName
        {
            get { return cloudIssuerName; }
        }

        private static string cloudSigningCertificateName;
        public static string CloudSigningCertificateName
        {
            get { return cloudSigningCertificateName; }
        }

        private static string cloudEncryptingCertificateName;
        public static string CloudEncryptingCertificateName
        {
            get { return cloudEncryptingCertificateName; }
        }

        private static string cloudStorageAccountName;
        public static string CloudStorageAccountName
        {
            get { return cloudStorageAccountName; }
        }

        private static string cloudStorageAccountKey;
        public static string CloudStorageAccountKey
        {
            get { return cloudStorageAccountKey; }
        }

        private static string cloudStorageUseDevelopmentStorage;
        public static string CloudStorageUseDevelopmentStorage
        {
            get { return cloudStorageUseDevelopmentStorage; }
        }
        #endregion

        #region Deloitte Integration
        private static string deloitteWebServiceAddress;
        public static string DeloitteWebServiceAddress
        {
            get { return WebConfig.deloitteWebServiceAddress; }
            set { WebConfig.deloitteWebServiceAddress = value; }
        }

        private static float deloitteWebServiceAccessFrequency;
        public static float DeloitteWebServiceAccessFrequency
        {
            get { return WebConfig.deloitteWebServiceAccessFrequency; }
            set { WebConfig.deloitteWebServiceAccessFrequency = value; }
        }
        #endregion

        #region Google map request URL
        private static string googleMapRequestURL;
        public static string GoogleMapRequestURL
        {
            get { return WebConfig.googleMapRequestURL; }
            set { WebConfig.googleMapRequestURL = value; }
        }
        #endregion
        #region Webinar Implementation

        private static string courseDocumentPath;
        public static string CourseDocumentPath
        {
            get { return courseDocumentPath; }
        }

        #endregion

        #region Comprehensive Bundle
        private static string compBundlePremiumBundleUnisonId;
        public static string PremiumBundleUnisonId
        {
            get { return compBundlePremiumBundleUnisonId; }
        }
        #endregion

        public static void InitializeSettings()
        {
            NameValueCollection config = (NameValueCollection)ConfigSettings.GetSettings();
            WebConfig.settings = config;

            ServiceLocation = APConvert.ToInt(config[GlobalConstants.ServiceLocation]);
            #region Role Mapping
            roleIdAuthor = APConvert.ToInt(config["RoleIdAuthor"]);
            #endregion Role Mapping

            _isRedeemedPromoEditable = APConvert.ToBoolean(config["IsRedeemedEditable"]);
            _getPricesProfessionalID = APConvert.ToString(config["GetPricesProfessionalID"]);
            _getPricesUnisonShipTo = APConvert.ToString(config["GetPricesUnisonShipTo"]);

            #region Shopping Cart

            _coursePlayerContentDownloadPurchase = APConvert.ToString(config["CoursePlayerContentDownloadPurchase"]);
            _coursePlayerContentDownloadPreview = APConvert.ToString(config["CoursePlayerContentDownloadPreview"]);
            _defaultTemplateLocation = APConvert.ToString(config["DefaultTemplateLocation"]);
            _isCartInMaintenance = APConvert.ToBoolean(config["IsCartInMaintenance"]);
            _receiptEmailSubjectFormat = APConvert.ToString(config["ReceiptEmailSubjectFormat"]);
            _visibleLineItemTypes = APConvert.ToString(config["VisibleLineItemTypes"]);
            _defaultPromoCode = APConvert.ToString(config["DefaultPromoCode"]);
            _defaultMailSource = APConvert.ToString(config["DefaultMailSource"]);
            _defaultItemSet = APConvert.ToString(config["DefaultItemSet"]);
            _defaultAddressCode = APConvert.ToString(config["DefaultAddressCode"]);
            _defaultOrderType = APConvert.ToString(config["DefaultOrderType"]);
            _defaultGetPriceOrderType = APConvert.ToString(config["DefaultGetPriceOrderType"]);
            _cuasOrderSource = APConvert.ToString(config["CuasOrderSource"]);
            _unisonOperator = APConvert.ToString(config["UnisonOperator"]);
            _allowedCreditCardTypes = APConvert.ToString(config["AllowedCreditCardTypes"]);
            _expirationYears = APConvert.ToString(config["ExpirationYears"]);
            _expirationMonths = APConvert.ToString(config["ExpirationMonths"]);
            _ccMerchantGUID = APConvert.ToString(config["CcMerchantGUID"]);
            _defaultOrderLineAdd = APConvert.ToString(config["DefaultOrderLineAdd"]);
            _upsellDisplayItemsPerLineItem = APConvert.ToInt(config["UpsellDisplayItemsPerLineItem"]);
            _upsellDisplayRowsPerOrder = APConvert.ToInt(config["UpsellDisplayRowsPerOrder"]);
            _upsellOnlineMediaIconPath = APConvert.ToString(config["UpsellOnlineMediaIconPath"]);
            _upsellPrintMediaIconPath = APConvert.ToString(config["UpsellPrintMediaIconPath"]);
            _upsellDownloadMediaIconPath = APConvert.ToString(config["UpsellDownloadMediaIconPath"]);
            _salesPhoneNumber = APConvert.ToString(config["SalesPhoneNumber"]);
            _billingStates = APConvert.ToString(config["BillingStates"]);
            _techSupportEmailAddress = APConvert.ToString(config["TechSupportEmailAddress"]);
            _payOnAccountText = APConvert.ToString(config["PayOnAccountText"]);
            _emailAdminSubjectLine = APConvert.ToString(config["EmailAdminSubjectLine"]);
            #endregion

            #region Content Management System

            _cmsWSDL = APConvert.ToString(config["CmsWSDL"]);
            _cmsSite = APConvert.ToString(config["CmsSite"]);
            _cmsContentType = APConvert.ToString(config["CmsContentType"]);
            _cmsWorkFlowState = APConvert.ToString(config["CmsWorkFlowState"]);

            #endregion
            certificateEmailSendingWebServiceAddress = config["LiveEventSendCertificateEmail"];

            _baseHelpURL = APConvert.ToString(config["BaseHelpURL"]);

            //global
            #region

            //ERA defect fixes :Add the APConvert.ToString()
            bundlePackageTypeIds = APConvert.ToString(config[GlobalConstants.BundlePackageTypeIDs]);

            //CE Tracking value load
            //ERA defect fixes :Add the APConvert.ToString()
            cpeTrackingLawProductTitle = APConvert.ToString(config[GlobalConstants.CpeTrackingLawProductTitle]);
            cpeTrackingAccountingProductTitle = APConvert.ToString(config[GlobalConstants.CpeTrackingAccountingProductTitle]);
            cpeTrackingDualProductTitle = APConvert.ToString(config[GlobalConstants.CpeTrackingDualProductTitle]);

            cpeTrackingLawProductDescription = APConvert.ToString(config[GlobalConstants.CpeTrackingLawProductDescription]);
            cpeTrackingAccountingProductDescription = APConvert.ToString(config[GlobalConstants.CpeTrackingAccountingProductDescription]);
            cpeTrackingDualProductDescription = APConvert.ToString(config[GlobalConstants.CpeTrackingDualProductDescription]);
            reconciliationReportLocation = APConvert.ToString(config[GlobalConstants.ReconciliationReportLocationPath]);
            #endregion
            competencyModelProductCode = APConvert.ToString(config[GlobalConstants.strCompetencyModelProductCode]);





            //Brand ID's
            microMashId = APConvert.ToInt(config["MicroMashId"]);
            passOnlineId = APConvert.ToInt(config["PassOnlineId"]);
            gearUpId = APConvert.ToInt(config["GearUpId"]);
            bellLearningId = APConvert.ToInt(config["BellLearningId"]);
            ppcId = APConvert.ToInt(config["PpcId"]);
            webinarLearningNetworkId = APConvert.ToInt(config["WebinarLearningNetworkId"]);
            riaId = APConvert.ToInt(config["RiaId"]);
            auditWatchId = APConvert.ToInt(config["AuditWatchId"]);
            quickFinderId = APConvert.ToInt(config["QuickFinderId"]);

            //Media Format ID's
            onlineId = APConvert.ToInt(config["OnlineId"]);
            cdId = APConvert.ToInt(config["CdId"]);
            fiveZeroEightId = APConvert.ToInt(config["FiveZeroEightId"]);
            downloadId = APConvert.ToInt(config["DownloadId"]);
            seminarId = APConvert.ToInt(config["SeminarId"]);
            webinarId = APConvert.ToInt(config["WebinarId"]);
            printBasedSelfStudyId = APConvert.ToInt(config["PrintBasedSelfStudyId"]);
            inHouseTrainingId = APConvert.ToInt(config["InHouseTrainingId"]);
            conferenceId = APConvert.ToInt(config["ConferenceId"]);

            //Delivery Format Group ID's
            groupOnlineLearningSelfStudyId = APConvert.ToInt(config["GroupOnlineLearningSelfStudyId"]);
            groupPrintBasedSelfStudyId = APConvert.ToInt(config["GroupPrintBasedSelfStudyId"]);

            ethics = APConvert.ToInt(config["Ethics"]);
            yellowBook = APConvert.ToInt(config["YellowBook"]);
            webinarLocationId = APConvert.ToInt(config["WebinarLocationId"]);
            smtpDeliveryMethod = APConvert.ToString(config["SmtpDeliveryMethod"]);
            performanceCounterCategoryName = config["PerformanceCounterCategoryName"];
            developerMode = APConvert.ToInt(config["DeveloperMode"]);

            //Active Directory
            activeDirectoryPath = APConvert.ToString(config["ActiveDirectoryPath"]);
            activeDirectoryUserListFilter = APConvert.ToString(config["ADUserListFilter"]);
            activeDirectoryUserDetails = APConvert.ToString(config["ActiveDirectoryUserDetails"]);
            activeDirectoryFirstFilter = APConvert.ToString(config["ActiveDirectoryFirstFilter"]);

            //Sponsor Admin Pages
            sponsorLogo = APConvert.ToString(config["SponsorLogo"]);
            royaltyFrequencies = APConvert.ToString(config["RoyaltyFrequencies"]);
            vendorImagesPath = APConvert.ToString(config["VendorImagesPath"]);
            globalTextImagesPath = APConvert.ToString(config["GlobalTextImagesPath"]);
            gearUpWorkshopSponsors = APConvert.ToString(config["GearUpWorkshopSponsors"]);

            //Resource Image
            resourceImage = APConvert.ToString(config["ResourceImage"]);
            emailSender = APConvert.ToString(config["EmailSender"]);
            addNewUserEmailMessage = APConvert.ToString(config["AddNewUserEmailMessage"]);
            addNewUserXSLTFile = APConvert.ToString(config["AddNweUserXSLTFile"]);

            addNewResourceEmailXSLTFile = APConvert.ToString(config["NewResourceXslt"]);
            resourceRecordChangeXSLTFile = APConvert.ToString(config["RecordsChangedXslt"]);
            addNewResourceEmailMessage = APConvert.ToString(config["AddNewResourceEmailMessage"]);

            //Resource Group Id - Online
            ResourceOnlineGroupId = APConvert.ToString(config["Online"]);

            //Resource Roles
            CertificateTypeResourceRoleId = APConvert.ToString(config["CertificateTypeResourceRoleId"]);
            DisplayCredentialResourceRoleId = APConvert.ToString(config["DisplayCredentialResourceRoleId"]);
            DisplayCredentialAcronymRoleId = APConvert.ToString(config["DisplayCredentialAcronymRoleId"]);

            //Email
            RecordChangeXSLTFile = APConvert.ToString(config["RecordChangedXSLTFile"]);
            RecordChangedEmailMessage = APConvert.ToString(config["RecordChangedEmailMessage"]);

            //Default User
            defaultUser = APConvert.ToString(config["DefaultUser"]);
            onlineGroupId = APConvert.ToString(config["Online"]);  //Use to get the online groupid

            //Url Host
            HostAddress = APConvert.ToString(config["HostAddress"]);

            //Pilot Test
            pilotTestDeliveryFormats = APConvert.ToString(config["PilotTestDeliveryFormats"]);
            pilotTestMediaFormatIds = APConvert.ToString(config["PilotTestMediaFormatIdsToEnableFeedback"]);

            //Pilot Test reply address for feed back form
            pilotTestReplyAddress = APConvert.ToString(config["PilotTestReplyAddress"]);

            //Pilot Test NASBA
            pilotTestNasbaYearRange = APConvert.ToString(config["PilotTestNASBAYearRange"]);

            //Pilot Test Email
            PilotTesterXSLTFile = APConvert.ToString(config["PilotTesterXSLTFile"]);
            PilotTesterEmailMessage = APConvert.ToString(config["PilotTesterEmailMessage"]);

            PilotTestMinutesPerCPECredit = APConvert.ToInt(config["MinutesPerCPECredit"]);
            PilotTesterCompletedStatusId = APConvert.ToInt(config["PilotTesterTestStatusCompletedId"]);
            PilotTesterInactiveStatusId = APConvert.ToInt(config["PilotTesterInactiveStatusId"]);
            PilotTestImageLocation = APConvert.ToString(config["PilotTestImage"]);

            //Pilot Test Notofocation Accept/Reject Button
            PilotTestAcceptButton = APConvert.ToString(config["PilotTestAcceptButton"]);
            PilotTestRejectButton = APConvert.ToString(config["PilotTestRejectButton"]);

            //Secret Key
            NotificationSecretKeyPath = config["NotificationSecretKeyPath"];

            PilotTestDefaultEmailList = config["PilotTestDefaultEmailList"];

            ProductPricingScheduleFrequency = APConvert.ToInt(config["ProductPricingScheduleFrequency"]);
            ProductPricingNotificationEmail = config["productPricingNotificationEmail"];
            RetireScheduleFrequency = APConvert.ToInt(config["RetireScheduleFrequency"]);

            #region Email Notifications

            notificationSmtpServer = APConvert.ToString(config["NotificationSmtpServer"]);
            notificationPortNumber = APConvert.ToInt(config["NotificationPortNumber"]);
            notificationDeliveryMethod = APConvert.ToString(config["NotificationDeliveryMethod"]);
            notificationTemplatePath = APConvert.ToString(config["NotificationTemplatePath"]);

            #endregion

            #region Shared Session Management
            applicationId = APConvert.ToInt(config["ApplicationId"]);
            sessionTokenTimeOutValue = APConvert.ToInt(config["SessionTokenTimeOutValue"]);
            sharedSessionExcludedExtensions = APConvert.ToString(config["SharedSessionExcludedExtensions"]);
            allowedLoginAttempts = APConvert.ToInt(config["AllowedLoginAttempts"]);
            requiredApplicationPath = APConvert.ToString(config["RequiredApplicationPath"]);
            checkpointLearningAppPath = APConvert.ToString(config["CheckpointLearningAppPath"]);
            pingFederateServerAddress = APConvert.ToString(config["PingFederateServerUrl"]);
            checkpointApplicationPath = APConvert.ToString(config["CheckpointApplicationPath"]);
            sessionTokenDomain = APConvert.ToString(config["SharedSessionCookieDomain"]);
            coursePlayerApplicationPath = APConvert.ToString(config["CoursePlayerApplicationPath"]);
            #endregion

            RegisteredSuccessEmailMessage = APConvert.ToString(config["RegisteredSuccessEmailMessage"]);
            SendPasswordEmailMessage = APConvert.ToString(config["SendPasswordEmailMessage"]);
            SendUsernameEmailMessage = APConvert.ToString(config["SendUsernameEmailMessage"]);
            RegisteredSuccessEmailTemplate = APConvert.ToString(config["RegisteredSuccessEmailTemplate"]);
            SendPasswordEmailTemplate = APConvert.ToString(config["SendPasswordEmailTemplate"]);
            SendUsernameEmailTemplate = APConvert.ToString(config["SendUsernameEmailTemplate"]);
            minValidSecurityAnswers = APConvert.ToInt(config["MinValidSecurityAnswers"]);
            maximumForgotLoginAttempts = APConvert.ToInt(config["MaximumForgotLoginAttempts"]);
            ProfessionalAddressTypeBusiness = APConvert.ToInt(config["ProfessionalAddressTypeBusiness"]);

            #region User Registration - Default Values

            DefaultTimeZoneId = APConvert.ToInt(config["DefaultTimeZoneId"]);
            EncryptionKeyPath = APConvert.ToString(config["EncryptionKeyPath"]);
            AllowPasswordEncryption = APConvert.ToBoolean(config["AllowPasswordEncryption"]);
            DefaultTimeZoneCode = APConvert.ToString(config["DefaultTimeZoneCode"]);
            DefaultStateId = APConvert.ToInt(config["DefaultStateId"]);
            DefaultCountryId = APConvert.ToInt(config["DefaultCountryId"]);
            resumesPath = APConvert.ToString(config["ResumesPath"]);
            userRegistrationHelpFile = APConvert.ToString(config["UserRegistrationHelpFile"]);
            #endregion

            #region OnlineGrading

            onlineGradingYearRange = APConvert.ToString(config["OnlineGradingYearRange"]);
            examSupervisorNotificationTemplateId = APConvert.ToInt(config["ExamSupervisorNotificationTemplateId"]);
            examCertificateNotificationTemplateId = APConvert.ToInt(config["ExamCertificateNotificationTemplateId"]);
            examFailureNotificationTemplateId = APConvert.ToInt(config["ExamFailureNotificationTemplateId"]);
            examOwnerNotificationTemplateId = APConvert.ToInt(config["ExamOwnerNotificationTemplateId"]);
            examFailureNoticeMaxTriesTemplateId = APConvert.ToInt(config["ExamFailureNoticeMaxTriesTemplateId"]);
            threeTimeFailureAdminNotificationTemplateId = APConvert.ToInt(config["ThreeTimeFailureAdminNotificationTemplateId"]);
            fivePeopleFailureAdminNotificationTemplateId = APConvert.ToInt(config["FivePeopleFailureAdminNotificationTemplateId"]);
            ogsReqwiredActivityTypeProvider = APConvert.ToString(config["OgsReqwiredActivityTypeProvider"]);
            ogsReqwiredActivityTypeFormat = APConvert.ToString(config["OgsReqwiredActivityTypeFormat"]);
            ogsMediaFormatId = APConvert.ToString(config["OgsMediaFormatId"]);
            #endregion

            rootFolderPath = APConvert.ToString(config["RootFolderPath"]);
            organizationLogoPath = APConvert.ToString(config["OrganizationLogoPath"]);
            nyId = APConvert.ToInt(config["NYId"]);
            txId = APConvert.ToInt(config["TXId"]);
            courseGraphicsImagePath = APConvert.ToString(config["CourseGraphicsImagePath"]);
            pdfPath = APConvert.ToString(config["Pdfpath"]);
            #region Delivery Format Ids
            inHouseId = APConvert.ToString(config["InHouseId"]);
            liveSeminarsAndConferencesId = APConvert.ToString(config["LiveSeminarsAndConferencesId"]);
            onlineLearningWebinarsId = APConvert.ToString(config["OnlineLearningWebinarsId"]);
            onlineLearningSelfStudyId = APConvert.ToString(config["OnlineLearningSelfStudyId"]);
            selfStudyPrintBasedId = APConvert.ToString(config["SelfStudyPrintBasedId"]);
            #endregion

            //OGS Time out setting
            ogsTransactionTimeOutInSeconds = APConvert.ToDouble(config["OgsTransactionTimeOutInSeconds"]);


            #region Course/CourseInstance Integration with Metadata
            courseActivityProfileTemplatePath = APConvert.ToString(config["CourseActivityProfileTemplatePath"]);
            #endregion
            showStackTrace = APConvert.ToBoolean(config["ShowStackTrace"]);

            //Swithces to turn on/off Functionality
            isUserRegistrationEnabled = APConvert.ToBoolean(config["IsUserRegistrationEnabled"]);
            isLearningLibraryEnabled = APConvert.ToBoolean(config["IsLearningLibraryEnabled"]);

            //Web Service Security
            ssmWebServiceUsername = config["SSMWebServiceUsername"];
            ssmWebServicePassword = config["SSMWebServicePassword"];
            entitlementWebServiceUsername = config["EntitlementWebServiceUsername"];
            entitlementWebServicePassword = config["EntitlementWebServicePassword"];
            ssoRequestTimeoutDurationInMinutes = APConvert.ToInt(config["SsoRequestTimeoutDurationInMinutes"]);
            liveEventWebServiceUsername = config["LiveEventWebServiceUsername"];
            liveEventWebServicePassword = config["LiveEventWebServicePassword"];

            entitlementWebServiceAddress = config["EntitlementWebServiceUrl"];
            pingAgentConfig = config["PingAgentConfig"];
            isMigrationInProgress = APConvert.ToBoolean(config["IsMigrationInProgress"]);

            #region CPL Data Migration
            migrationSenderEmailAddress = config["MigrationSenderEmailAddress"];
            migrationReceiverEmailAddress = config["MigrationReceiverEmailAddress"];
            migrationFailedEmailXsltFileName = config["MigrationFailedEmailXsltFleName"];
            migrationFailedEmailSubject = config["MigrationFailedEmailSubject"];
            maxLogMessageLength = APConvert.ToInt(config["MaxLogMessageLength"]);
            maxLogTechnicalDetailsLength = APConvert.ToInt(config["MaxLogTechnicalDetailsLength"]);
            maxSimulteniouslyExecutingJobCount = APConvert.ToInt(config["MaxSimulteniouslyExecutingJobCount"]);
            reqwired3DWebServiceUserName = config["Reqwired3DWebServiceUserName"];
            reqwired3DWebServicePassword = config["Reqwired3DWebServicePassword"];
            migrationOnlineGradingIPWebServiceAddress = config["MigrationOnlineGradingIPWebService"];
            migrationReqwired3DIPWebServiceAddress = config["MigrationReqwired3DIPWebService"];
            migrationMicroMashIPWebServiceAddress = config["MigrationMicroMashIPWebService"];
            migrationPassOnlineIPWebServiceAddress = config["MigrationPassOnlineIPWebService"];
            migrationIpDataImportWebService = config["MigrationIpDataImportWebService"];
            migrationSuccessEmailXsltFileName = config["MigrationSuccessEmailXsltFleName"];
            migrationSuccessEmailSubject = config["MigrationSuccessEmailSubject"];
            migrationQueuePollingInterval = APConvert.ToInt(config["MigrationQueuePollingInterval"]);

            technicalHandlingNoteNotificationSubject = config["TechnicalHandlingNoteNotificationSubject"];
            technicalHandlingNoteReceiverEmailAddress = config["TechnicalHandlingNoteReceiverEmailAddress"];
            technicalHandlingNoteXsltFileName = config["TechnicalHandlingNoteXsltFileName"];

            migrationDefaultItemSet = config["MigrationDefaultItemSet"];
            migrationDefaultPromoCode = config["MigrationDefaultPromoCode"];
            migrationDefaultMailSource = config["MigrationDefaultMailSource"];
            migrationDefaultOrderLineAdd = config["MigrationDefaultOrderLineAdd"];
            migrationUnisonOperator = config["MigrationUnisonOperator"];
            migrationDefaultOrderType = config["MigrationDefaultOrderType"];
            migrationCuasOrderSource = config["MigrationCuasOrderSource"];
            migrationDefaultAddressCode = config["MigrationDefaultAddressCode"];

            migrationProductionDataTransferJob = config["MigrationProductionDataTransferJob"];
            datamigrationEnable = APConvert.ToBoolean(config["DataMigrationEnabled"]);

            #endregion

            #region Order Processing
            unisonWebServiceAddress = config["UnisonWebServiceUrl"];

            #endregion

            #region Base Help Url

            baseHelpUrl = config["BaseHelpUrl"];

            #endregion

            #region NAS Test
            nasUsername = config["NASUsername"];
            nasPassword = config["NASPassword"];
            nasDomain = config["NASDomain"];
            nasUploadPath = config["NASUploadPath"];
            nasFolderName = config["NasFolderName"];
            brandImageNasFolderPath = config["BrandImageNasFolderPath"];
            nasFolderPath = config["NASFolderPath"];
            #endregion
            #region Entitlement
            bundlePackageType = APConvert.ToInt(config["BundlePackageType"]);
            cpeTrackingLawProductCode = APConvert.ToString(config["CpeTrackingLawProductCode"]);
            cpeTrackingAccountingProductCode = APConvert.ToString(config["CpeTrackingAccountingProductCode"]);
            cpeTrackingDualProductCode = APConvert.ToString(config["CpeTrackingDualProductCode"]);
            #endregion

            #region Auto Notification
            autoNotificationEmailScheduleFrequency = APConvert.ToFloat(config["AutoNotificationEmailScheduleFrequencyInMinutes"]);
            autoNotifyEmailFromAddress = config["AutoNotificationemailFromAddress"];
            #endregion

            #region Phone Numbers

            cplSupportPhoneNo = APConvert.ToString(config["CPLSupportPhoneNo"]);
            cplSalesPhoneNo = APConvert.ToString(config["CPLSalesPhoneNo"]);
            bellPoliciesPhoneNo = APConvert.ToString(config["BellPoliciesPhoneNo"]);
            courseDetailsPhoneNo = APConvert.ToString(config["CourseDetailsPhoneNo"]);
            microMashPoliciesPhoneNo = APConvert.ToString(config["MicroMashPoliciesPhoneNo"]);
            courseFinderPhoneNo = APConvert.ToString(config["CourseFinderPhoneNo"]);
            #endregion

            #region Coming Soon
            comingSoonInquiryEmail = APConvert.ToString(config["ComingSoonInquiryEmail"]);
            comingSoonInquirySubject = APConvert.ToString(config["ComingSoonInquirySubject"]);
            comingSoonInquiryBody = APConvert.ToString(config["ComingSoonInquiryBody"]);
            sSRSReprotServerUrl = APConvert.ToString(config["SSRSReprotServerUrl"]);
            sSRSPassword = APConvert.ToString(config["SSRSPassword"]);
            sSRSUserName = APConvert.ToString(config["SSRSUserName"]);
            uploadDocumentPath = APConvert.ToString(config["UploadDocumentPath"]);
            webinarReminderBccList = APConvert.ToString(config["WebinarReminderBccList"]);
            webinarReminderUsername = APConvert.ToString(config["WebinarReminderUsername"]);
            webinarReminderPassword = APConvert.ToString(config["WebinarReminderPassword"]);
            webinarReminderDomain = APConvert.ToString(config["WebinarReminderDomain"]);
            webinarEmailSender = APConvert.ToString(config["WebinarEmailSender"]);
            sSRSLmsUrl = APConvert.ToString(config["sSRSLmsUrl"]);
            sSRSLmsOrganizationFilter = APConvert.ToString(config["sSRSLmsOrganizationFilter"]);

            #endregion

            #region ProfilingOnline
            profilingOnlineURL = config["ProfilingOnlineURL"];
            pingAgentConfigForProfilingOnline = config["PingAgentConfigForProfileOnline"];
            pingFederateServerAddressForProfilingOnline = config["PingFederateServerUrlForProfilingOnline"];
            profilingOnlineMarketingPageAddress = config["ProfilingOnlineMarkettingPageURL"];
            profilingOnlineConnectionId = config["ProfillingPingConnectionId"];
            #endregion

            #region Live Event DeliveryFormats and Media Formats
            seminarConferenceDeliveryFormat = APConvert.ToString(config["LiveEventDeliveryFormats"]);
            nonLiveEventDeliveryFormat = APConvert.ToString(config["NonLiveEventDeliveryFormats"]);
            liveEventMediaFormats = APConvert.ToString(config["LiveEventMediaFormats"]);
            liveEventSeminarId = APConvert.ToString(config["LiveEventSeminarId"]);
            liveEventConferenceId = APConvert.ToString(config["LiveEventConferenceId"]);
            liveEventWorkshopId = APConvert.ToString(config["LiveEventWorkshop"]);
            liveEventWebinarId = APConvert.ToString(config["LiveEventWebinarId"]);
            #endregion

            #region IRS
            irsSelfRegistrationRedirectUrl = APConvert.ToString(config["IrsSelfRegistrationRedirectUrl"]);
            irsPrimeSiteId = APConvert.ToString(config["IrsPrimeSiteId"]);
            irsMainSiteId = APConvert.ToString(config["IrsMainSiteId"]);
            irsUserRegistrationEmailTemplate = APConvert.ToString(config["IRSUserRegistrationEmailTemplate"]);
            irsUserRegistrationEmailContent = APConvert.ToString(config["IRSUserRegistrationEmailContent"]);
            irsSponsorLandingPageUrl = APConvert.ToString(config["IrsSponsorLandingPageUrl"]);
            IRSForgotLoginEmailTemplate = APConvert.ToString(config["IRSForgotLoginEmailTemplate"]);
            IRSForgotLoginEmailContent = APConvert.ToString(config["IRSForgotLoginEmailContent"]);
            IrsForgotLoginRecievierEmailAddress = APConvert.ToString(config["IrsForgotLoginRecievierEmailAddress"]);
            #endregion
            #region versioning
            versionCategoryIdForNewAcronym = APConvert.ToString(config["VersionCategoryIdForNewAcronym"]);
            onlineCourseStatusInitialId = APConvert.ToString(config["OnlineCourseStatusInitialId"]);
            senderEmailAddressForCancelNotification = APConvert.ToString(config["SenderEmailAddressForCancelNotification"]);
            retiredRetention = APConvert.ToInt(config["RetiredRetention"]);
            courseLaunchRestriction = APConvert.ToInt(config["CourseLaunchRestriction"]);

            #endregion

            #region Live Event Brands
            liveEventAttendanceManagmentBrands = APConvert.ToString(config["LiveEventAttendanceManagmentBrands"]);


            #endregion

            #region LiveEventCourseTypeConference
            liveEventConferenceCourseTypeId = APConvert.ToString(config["LiveEventConferenceCourseTypeId"]);
            #endregion

            #region CourseSponsors
            liveEventCourseSponsors = APConvert.ToString(config["LiveEventCourseSponsors"]);
            nonLiveEventCourseSponsors = APConvert.ToString(config["NonLiveEventCourseSponsors"]);
            #endregion

            #region Live Event Order
            liveEventUserRegistrationEmailTemplate = config["LiveEventUserRegistrationEmail"];
            liveEventAttendanceTicketNotificationEmaiTemlate = config["AttendanceTicketNotificationEmailTemplate"];
            liveEventSendReceiptEmailTemplate = config["LiveEventSendReceiptEmailTemplate"];
            liveEventAttendanceTicketNotificationOwnerEmailTemplate = config["AttendanceTicketNotificationOwnerEmailTemplate"];
            liveEventProfessionalRegistrationEmailMessage = config["LiveEventProfessionalRegistrationEmailMessage"];
            liveEventWebinarModeratorEmailMessage = config["LiveEventWebinarModeratorEmailMessage"];
            liveEventWebinarModeratorEmailTemplate = config["LiveEventWebinarModeratorEmailTemplate"];
            liveEventOrderWebinarAttendeeEmailMessage = config["LiveEventOrderWebinarAttendeeEmailMessage"];
            liveEventOrderWebinarAttendeeEmailMessageTemplate = config["LiveEventOrderWebinarAttendeeEmailMessageTemplate"];
            fPAssignmentMailTemplateConference = config["FPAssignmentMailTemplateConference"];
            fPAssignmentMailTemplateSeminarsWorkshops = config["FPAssignmentMailTemplateSeminarsWorkshops"];
            fPAssignmentMailTemplateWebinarWebcast = config["FPAssignmentMailTemplateWebinarWebcast"];
            fPUnAssignmentMailTemplate = config["FPUnAssignmentMailTemplate"];
            fPAssignmentMailContentConference = config["FPAssignmentMailContentConference"];
            fPAssignmentMailContentSeminarsWorkshops = config["FPAssignmentMailContentSeminarsWorkshops"];
            fPAssignmentMailContentWebinarWebcast = config["FPAssignmentMailContentWebinarWebcast"];
            fPUnAssignmentMailContent = config["FPUnAssignmentMailContent"];
            fAOrderConfirmationMailTemplate = config["FAOrderConfirmationMailTemplate"];
            fAOrderConfirmationMailContent = config["FAOrderConfirmationMailContent"];
            #endregion

            #region Webinar Attendance management
            liveEventAttendanceWebinarDetailsEmailTemplate = config["LiveEventAttendanceWebinarDetailsEmailTemplate"];
            #endregion

            #region Pilot Test Registration Attachments
            //Defect fix for #83375 :Pilot Testing: Add Autorespone Message when user registers to be a Pilot Tester
            //Folder path of attachmnet files
            pilotTestRegistrationAttachmentFolderPath = APConvert.ToString(config["PilotTestRegistrationAttachmentFolderPath"]);
            //Attachment files 
            pilotTestRegistrationAttachmentFiles = APConvert.ToString(config["PilotTestRegistrationAttachmentFiles"]);
            #endregion

            #region Profiling Online Competency Model
            //Competency Model - PO integration IP Product Code
            competencyModelIPProductCode = APConvert.ToString(config["CompetencyModelIndividualProfessionalProductCode"]);
            competencyModelIPProductTitle = APConvert.ToString(config["CompetencyModelIndividualProfessionalProductTitle"]);
            competencyModelIPProductDescription = APConvert.ToString(config["CompetencyModelIndividualProfessionalProductDescription"]);
            #endregion

            #region Cloud Storage
            cloudUrl = APConvert.ToString(config["CloudStorageUrl"]);
            cloudIssuerName = APConvert.ToString(config["CloudStorageIssuerName"]);
            cloudSigningCertificateName = APConvert.ToString(config["CloudStorageSigningCertificateName"]);
            cloudEncryptingCertificateName = APConvert.ToString(config["CloudStorageEncryptingCertificateName"]);
            cloudStorageAccountName = APConvert.ToString(config["CloudStorageAccountName"]);
            cloudStorageAccountKey = APConvert.ToString(config["CloudStorageAccountKey"]);
            cloudStorageUseDevelopmentStorage = APConvert.ToString(config["UseCloudDevelopmentStorage"]);
            #endregion

            #region Deloitte Integration
            deloitteWebServiceAddress = config["DeloitteWebServiceUrl"];
            deloitteWebServiceAccessFrequency = APConvert.ToFloat(config["DeloitteWebServiceAccessFrequencyInMinutes"]);
            #endregion

            #region Google map request URL
            googleMapRequestURL = config["GoogleMapRequestUrl"];
            #endregion

            #region Webinar Implementation

            courseDocumentPath = APConvert.ToString(config["CourseDocumentPath"]);

            #endregion

            #region CourseFinder
            findCpeTopics = APConvert.ToString(config["FindCpeTopics"]);
            findCpeBrands = APConvert.ToString(config["FindCpeBrands"]);
            findCpeDeliveryFormats = APConvert.ToString(config["FindCpeDeliveryFormats"]);
            findCpeMediaFormats = APConvert.ToString(config["FindCpeMediaFormats"]);

            #endregion

            #region MyCPE
            myCpeTopics = APConvert.ToString(config["MyCpeTopics"]);
            myCpeBrands = APConvert.ToString(config["MyCpeBrands"]);
            myCpeDeliveryFormats = APConvert.ToString(config["MyCpeDeliveryFormats"]);
            myCpeMediaFormats = APConvert.ToString(config["MyCpeMediaFormats"]);

            #endregion

            #region Comprehensive Bundle
            compBundlePremiumBundleUnisonId = config["PremiumBundleUnisonId"];
            #endregion
        }


        static WebConfig()
        {
            InitializeSettings();
        }

        #endregion
    }
}



