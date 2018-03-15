using System;
namespace Kotacs.Libraries.Common
{
    public static class GlobalConstants
    {
        #region MediaFormat Table
        /// <summary>
        ///  MediaFormatID for Conference
        /// </summary>
        public const int MediaFormatConferenceMediaFormatId = 7;

        /// <summary>
        ///  MediaFormatID for seminrars
        /// </summary>
        public const int MediaFormatSeminarMediaFormatId = 4;
        /// <summary>
        ///  MediaFormatID for CD
        /// </summary>
        public const int MediaFormatCdMediaFormat = 6;

        /// <summary>
        ///  Retired Status Id
        /// </summary>
        ///  Retired Status Id
        /// </summary>
        /// 
        public const int RetiredStatusId = 4;
        public const int MediaFormat508MediaFormat = 29;
        /// <summary>


        /// <summary>
        /// Course search result display mode for Live Events
        /// </summary>
        public static string CourseFinderViewModeLiveEvents = "LiveEvent";

        /// <summary>
        /// Display filter for new inteeractive courses
        /// </summary>
        public static string AllNewCourses = "NewInteractiveCourses";

        /// <summary>
        /// Course search result display mode for new courses
        /// </summary>
        public const string CourseFinderViewModeNewCourses = "NewCourses";
        #endregion

        #region Controller Names
        public const string ControllerAdditionalResources = "AdditionalResources";
        public const string ControllerCourses = "Courses";
        public const string ControllerCourseFinder = "CourseFinder";
        public const string ControllerNewsAndUpdates = "NewsAndUpdates";
        public const string ControllerCpeBrands = "CPEBrands";
        public const string ControllerCommonNavigation = "CommonNavigation";
        public const string ControllerCorporateAccounts = "CorporateAccounts";
        public const string ControllerName = "Courses";
        public const string ControllerCpeSolutions = "CPESolutions";
        public const string ControllerHome = "Home";
        public const string ControllerMessage = "Message";
        public const string ControllerSendEmail = "Email";
        public const string ControllerSchedule = "Schedule";
        public const string ControllerUser = "User";
        public const string ControllerCart = "Cart";
        public const string ControllerProductValidate = "ProductValidate";
        public const string ControllerProductBillingCycle = "ProductBillingCycle";
        public const string ControllerSponsor = "Sponsor";
        public const string ControllerVender = "Vender";
        public const string ControllerOGS = "OGS";
        public const string ControllerOGSadmin = "OGSadmin";
        public const string ControllerSem = "Sem";
        public const string ControllerProfessional = "Professional";
        public const string ControllerSsm = "Ssm";
        public const string ControllerCoursePlayer = "CoursePlayer";
        public const string ControllerCheckpoint = "Checkpoint";
        public const string ControllerAuthor = "Author";
        public const string ControllerMigration = "Migration";
        public const string ControllerSysAdmin = "SysAdmin";
        public const string ControllerProduct = "Product";
        public const string ControllerWebinar = "Webinar";
        public const string ControllerInhouseInfo = "InhouseInfo";
        public const string MyCpeTabController = "MyCpe";
        public const string RequwiredEmployeeEntitlementActionPath = "/organization/Controller?com.reqwired.site.action=EmployeeListView";
        public const string ControllerIrs = "Irs";
        #endregion

        public const string ControllerDynamicAssembly = "DynamicAssembly";

        #region Checkpoint MetaTab - no changes within region
        public const string ControllerCPMetaTab = "CPMetaTab";
        public const string ActionInternalCPMetaTab = "Cpl";
        #endregion

        #region Internal Controllers - no changes within region
        public const string ControllerInternal = "Internal";
        // Product Management
        public const string ControllerResource = "Resource"; // (Virtusa) 
        public const string ControllerSponsorMetadata = "SponsorMetadata"; // (Sree)
        public const string ControllerCourseMetadata = "CourseMetadata"; // (Ken)
        public const string ControllerManagePackages = "ManagePackages";

        public const string ControllerPilotTest = "PilotTest"; // (Virtusa) 
        public const string ControllerPTest = "PTest";//(22/03/2010 change the location to get unprotected URL
        public const string ControllerEventManagement = "EventManagement"; // (OUT OF SCOPE)
        public const string ControllerOnlineGrading = "OnlineGrading"; // (Virtusa) 
        public const string ControllerTableOfContent = "TableOfContent"; // (Ken)
        public const string ControllerProductionSchedule = "ProductionSchedule"; // (OUT OF SCOPE)
        //OGSAdmin
        public const string ControllerOnlineGradingAdmin = "OGSAdmin";
        // Sales & Marketing
        public const string ControllerMarketingContent = "MarketingContent"; //(Ken)
        public const string ControllerSemReport = "SemReport"; // (Virtusa)
        public const string ControllerSalesReporting = "Reports"; // (Virtusa) 
        public const string ControllerPromotionManagement = "PromotionManagement"; //(Aaron)
        public const string ControllerBusinessAffiliates = "Sponsor"; // (Virtusa) 
        public const string ControllerExtranets = "Extranets"; // (Ken)
        public const string ControllerLMS = "LMS"; // (Ken) 
        // Support
        public const string ControllerTechnicalCustomerSupport = "TechnicalCustomerSupport"; //(Ken)
        public const string ControllerHelp = "Help"; //(Ken)
        public const string ControllerAdministrations = "Administrations"; //(Ken)		


        // Shared
        public const string ControllerShared = "Shared";
        public const string LeftNavigationCookieNameForCourseFinder = "LeftNavigationCookieForCourseFinder";
        public const string LeftNavigationCookieNameForDefaultPages = "LeftNavigationCookieForDefaultPages";
        #endregion

        #region Internal Action - no changes within region
        public const string ActionInternalIndex = "Index";

        // Product Management
        public const string ActionResource = "Resource"; // (Virtusa) 
        public const string ActionSponsorMetadata = "SponsorMetadata"; // (Sree)
        public const string ActionMetadataTab = "MetadataTab";
        public const string ActionGeneral = "General"; //(Sree)
        public const string ActionSaveGeneral = "SaveGeneral"; //(Sree)
        public const string ActionSupplementalMaterial = "SupplementalMaterial"; //(Ken)
        public const string ActionMeasurement = "Measurement"; //(Sree)
        public const string ActionMarketing = "Marketing"; //(Sree)
        public const string ActionContributors = "Contributors"; //(Sree)
        public const string ActionCertificationsCredits = "CertificationsCredits"; //(Sree)
        public const string ActionStatus = "Status"; //(Sree)
        public const string ActionPilotTest = "PilotTest"; // (Virtusa) 
        public const string ActionEventManagement = "EventManagement";  // (OUT OF SCOPE)
        public const string ActionOnlineGrading = "OnlineGrading"; // (Virtusa)
        public const string ActionTableOfContent = "TableOfContent"; //(Ken)
        public const string ActionTableOfContentTable = "TableOfContentTable"; //(Ken)
        public const string ActionProductionSchedule = "ProductionSchedule"; //(OUT OF SCOPE)
        public const string ActionSchedule = "Schedule";// (Virtusa)
        public const string ActionScheduleDetails = "ScheduleDetails";// (Virtusa)
        public const string ActionAgenda = "Agenda";// (Virtusa)
        public const string ActionProfessionalSearch = "Professional";
        public const string ActionScheduleSearch = "ScheduleSearch";
        public const string ActionScheduleInstructor = "ScheduleInstructor";
        public const string ActionManageInstructor = "ManageInstructor";

        // Sales & Marketing
        public const string ActionMarketingContent = "MarketingContent"; //(Ken)
        public const string ActionSem = "LandingPage"; // (Virtusa)
        public const string ActionSalesReporting = "ReportList"; // (Virtusa)
        public const string ActionPromotions = "PromoManagement"; //(Ken)
        public const string ActionPromotionsReport = "PromoReports"; //(Ken)
        public const string ActionBusinessAffiliates = "SponsorManagement"; // (Virtusa)
        public const string ActionExtranets = "Extranets"; // (Ken)
        public const string ActionLMS = "LMS"; // (Ken)

        // Support
        public const string ActionTechnicalCustomerSupport = "TechnicalCustomerSupport"; //(Ken)
        public const string ActionHelp = "Help"; //(Ken)
        public const string ActionAdministrations = "Administrations"; //(Ken)
        public const string ActionSetttings = "Settings";
        public const string ActionProductReconciliationReport = "ProductReconciliationReport";

        // Sign-out
        public const string ActionSignOut = "SignOut"; //(Ken)

        public const string ActionManifestReports = "ManifestManager";
        public const string ActionInternalManifestReports = "InternalManifestManager";

        public const string ActionManifestManagerCustomization = "ManifestManagerCustomization";
        public const string ActionInternalManifestManagerCustomization = "InternalManifestManagerCustomization";

        public const string ActionManifestDownload = "ManifestDownload";
        public const string ActionInternalManifestDownload = "InternalManifestDownload";

        public const string ActionManifestList = "ManifestList";
        public const string ActionInternalManifestList = "InternalManifestList";


        #endregion

        public const string ActionDynamicAssemblyHome = "Home";
        public const string ActionDynamicAssemblyChapterLinking = "ChapterLinking";
        public const string ActionDynamicAssemblyReport = "Reports";

        public const string ActionDynamicAssemblyHomeView = "HomeView";

        public const string ActionDynamicAssemblyChapterLinkingView = "ChapterLinkingView";
        public const string ActionDynamicAssemblyWorkGroupView = "WorkGroups";
        public const string ActionDynamicAssemblyChapterLinkingActions = "ChapterLinkingActions";

        public const string ActionDynamicAssemblyReportView = "ReportsView";
        public const string ActionDynamicAssemblyWorkGroup = "WorkGroupView";
        public const string ActionDynamicAssemblyReportResults = "ReportResultView";

        public const string ActionSupplementalData = "SupplementalData";
        public const string ActionStatusData = "StatusData";

        public const string ActionVersioningReports = "VersioningReports";

        #region String Table Of Content Replacements
        public const string OpenTagInternetTableOfContentSummery = "<InternetTableOfContentSummary>";
        public const string EndTagInternetTableOfContentSummery = "</InternetTableOfContentSummary>";
        public const string OpenTagInternetTableOfContentReport = "<InternetTableOfContentReport>";
        public const string EndTagInternetTableOfContentReport = "</InternetTableOfContentReport>";
        public const string XslTableOfContentMapPath = @"~\Resources\TableOfContentReport.xsl";
        #endregion

        #region Discount Management

        public const string ActionExcludeProducts = "ExcludeProducts"; //(Ken)
        public const string ActionExcludeProductsData = "ExcludeProductsData";
        public const string ActionExcludeOrIncludeUnisonID = "ExcludeOrIncludeUnisonID";

        public const string ActionOrderLevelRule = "OrderLevelRule";
        public const string ActionLineItemDiscount = "LineItemDiscount";

        public const string ActionPromotionData = "PromotionData";
        public const string ActionEditPromoCode = "EditPromoCode";
        public const string ActionUpdateOrInsertPromoCode = "UpdateOrInsertPromoCode";
        public const string ActionDeletePromoCode = "DeletePromoCode";

        public const string ActionPromoRuleSets = "PromoRuleSets";
        public const string ActionPromoRuleSetDetails = "PromoRuleSetDetails";
        public const string ActionPromoCodes = "PromoCodes";
        public const string ActionPromoRuleSetRules = "PromoRuleSetRules";
        public const string ActionPromoRuleSetApplicables = "PromoRuleSetApplicables";
        public const string ActionPromoRuleSetApplicableRules = "PromoRuleSetApplicableRules";
        public const string ActionPromoShowModalValueSelection = "ValueSelection";

        public const string ActionEditRuleSet = "EditRuleSet";
        public const string ActionUpdateOrInsertRuleSet = "UpdateOrInsertRuleSet";
        public const string ActionDeleteRuleSet = "DeleteRuleSet";
        public const string ActionPrioritizeRuleSet = "PrioritizeRuleSet";

        public const string ActionEditDiscountApplicable = "EditDiscountApplicable";
        public const string ActionUpdateOrInsertDiscountApplicable = "UpdateOrInsertDiscountApplicable";
        public const string ActionDeleteDiscountApplicable = "DeleteDiscountApplicable";

        public const string ActionPromoRules = "PromoRules";
        public const string ActionEditRule = "EditRule";
        public const string ActionUpdateOrInsertRule = "UpdateOrInsertRule";
        public const string ActionDeleteRule = "DeleteRule";

        public const string ActionNotes = "Notes";

        #endregion

        #region Metadata

        #region MetadataCourseList - Ken Brunet

        public const string CourseMetadataList = "CourseMetadataList";
        public const string SearchCourseList = "SearchCourseList";
        public const string AddCourseMetadata = "AddCourseMetadata";
        public const string PromotionalIcons = "AddCourseMetadata";

        #endregion

        #region Supplements - Ken Brunet

        public const string ValidUrlRegEx = @"^(http|https|ftp)\://[a-zA-Z0-9\-\.]+\.[a-zA-Z]{2,3}(:[a-zA-Z0-9]*)?/?([a-zA-Z0-9\-\._\?\,\'/\\\+&amp;%\$#\=~])*[^\.\,\)\(\s]$";

        #endregion

        #endregion

        #region ContributorsInformation

        // Contributors Information Page views
        public const string ActionContributorsAuthors = "ContributorsAuthors";
        public const string ActionContributorsReviewers = "ContributorsReviewers";
        public const string ActionContributorsData = "ContributorsData";

        #endregion

        #region Certifications & Credits Information

        // Certifications & Credits Page views  
        public const string ActionNasbaCertificate = "CertificationsCreditsNasbaCertificate";
        public const string ActionBoardMembershipsSponsorLevel = "CertificationsCreditsBoardMemberSponsorLevel";
        public const string ActionBoardMembershipsCourseLevel = "CertificationsCreditsBoardMemberCourseLevel";
        public const string ActionCertificationsCreditsData = "CertificationsCreditsData";

        #endregion

        #region SAFE

        public const string SafeCookieWebConfigKey = "txtCookieName";

        #endregion

        #region Internal Supporting pages
        // Product Management

        #region TableOfContent Page Management + related hidden fields

        public const string PartialViewTableOfContentCourseList = "TableOfContentCourseList"; //(Ken)
        public const string PartialViewTableOfContentSearch = "TableOfContentSearch"; //(Ken)
        public const string CoursesCurrentPageHiddenId = "CoursesCurrentPage";
        public const string CoursesTotalRecordsHiddenId = "CoursesCurrentRecords";
        public const string PartialViewCourseList = "CourseList"; //(Ken)
        public const string PartialViewContentList = "ContentList"; //(Ken)

        // Sales & Marketing

        // Sales & Marketing

        // Support

        #endregion

        #region Additional Resources
        public const string AuthorDescription = "AuthorDescription";
        public const string ActionAuthorDetails = "AuthorDetails";
        public const string ActionCpeCompliance = "CPECompliance";
        public const string ActionNotedExperts = "NotedExperts";
        public const string ActionAdditionalResources = "AdditionalResources";
        public const string ActionRecentCpeRuleChanges = "RecentCPERuleChanges";
        public const string ActionIndividualNotedExpert = "IndividualNotedExpert";
        public const string ActionIndividualNotedAuthor = "IndividualNotedAuthor";
        #endregion

        #region Corporate Accounts
        public const string ActionCorporateAccounts = "CorporateAccounts";
        public const string ActionSponsorOpportunities = "SponsorOpportunities";
        public const string ActionCustomizedCourses = "CustomizedCourses";
        #endregion

        #region Courses
        public const string ActionCourseFormats = "CourseFormats";
        public const string ActionQuickSearch = "QuickSearch";
        public const string ActionInteractiveSearch = "InteractiveSearch";
        public const string ActionFindCourse = "FindCourse";
        public const string ActionGAOYellowBook = "GAOYellowBook";
        public const string ActionFileDownload = "FileDownload";
        public const string ActionCourseFinder = "CourseFinder";
        public const string ActionCancellationRefundPolicy = "CancellationRefundPolicy";
        public const string ActionMicroMash = "MicroMashCancellationRefundPolicy";
        public const string ActionPassOnline = "PassOnlineCancellationRefundPolicy";
        public const string ActionBellLearning = "BellLearningCancellationRefundPolicy";
        public const string ActionPPC = "PPCCancellationRefundPolicy";
        public const string ActionRIA = "RIACancellationRefundPolicy";
        public const string ActionQuickFinder = "QuickFinderCancellationRefundPolicy";
        public const string ActionWebinarPartnership = "WebinarCancellationRefundPolicy";
        public const string ActionGearUp = "GearUpCancellationRefundPolicy";
        public const string ActionViewCourse = "ViewCourse";
        public const string ActionEthicCourses = "EthicCourses";
        public const string ActionScheduleInformationMap = "ScheduleInformationMap";
        public const string ActionCourseDetails = "CourseDetails";
        public const string ActionNewCourses = "NewCourseList";
        public const string ActionSearchResult = "SearchResult";
        public const string ActionCpeTrainingInteractiveCatalog = "CpeTrainingInteractiveCatalog";
        public const string ActionCpeAndTrainingCatalog = "CpeAndTrainingCatalog";
        public const string ActionUpComingWebinars = "UpComingWebinars";
        public const string ActionScheduleInformation = "CourseSchedule";
        public const string ActionAdvancedSearch = "AdvancedSearch";
        public const string ActionBasicSearch = "BasicSearch";
        public const string ActionWebinarCustomerPolicies = "WebinarCustomerPolicies";
        public const string ActionAdvancedSearchResults = "AdvancedSearchResults";
        public const string ActionCPEDefaultCompliance = "CPEDefaultCompliance";
        public const string ActionSocietyInformation = "SocietyInformation";

        public const int NewCourseDateThreshold = 90;
        public const int UpdatedCourseDateThreshold = 365;

        public const string ActionCETracking = "CpeTracking";
        public const string ActionPredefinedBundles = "PredefinedBundles";
        public const string ScheduleOpenStatus = "Open";
        public const string ScheduleFullStatus = "Full";
        #endregion


        #region Author
        public const string ActionBecomeAuthor = "BecomeAuthor";
        public const string ActionNotedAuthor = "NotedAuthors";
        #endregion

        #region Resource Repository
        public const string ActionManageUserProfile = "ManageUserProfile";
        #endregion

        #region CommonNavigation
        public const string ActionCpeHome = "CPEHome";
        public const string ActionAboutUs = "AboutUs";
        public const string ActionContactUs = "ContactUs";
        public const string ActionSiteMap = "SiteMap";
        public const string ActionPrivacyPolicy = "PrivacyPolicy";
        public const string ActionTermsAndConditions = "TermsAndConditions";
        public const string ActionLearningLibraries = "LearningLibraries";
        public const string ActionViewAllLibraries = "ViewAllLibraries";
        public const string ActionSalesSupport = "SalesSupport";
        public const string ActionOnlineGradingComNav = "Index";
        public const string ActionShowLibrary = "ShowLibrary";
        public const string ActionOtherTaxAndAccountingSolution = "OtherTaxAndAccountingSolution";
        #endregion

        #region News And Updates
        public const string ActionTrainingSolutionsNewsLetter = "TrainingSolutionsNewsletter";
        public const string ActionTopSellers = "TopSellers";

        public const string ActionHotTopic1 = "HotTopic1";
        public const string ActionHotTopic2 = "HotTopic2";
        public const string ActionHotTopic3 = "HotTopic3";
        public const string ActionHotTopic4 = "HotTopic4";
        public const string ActionHotTopic5 = "HotTopic5";
        public const string ActionHotTopic6 = "HotTopic6";
        public const string ActionHotTopic7 = "HotTopic7";
        public const string ActionHotTopic8 = "HotTopic8";
        public const string ActionHotTopic9 = "HotTopic9";
        public const string ActionHotTopicA = "HotTopicA";
        public const string ActionHotTopicB = "HotTopicB";

        public const string ActionHotTopicSummary = "HotTopicSummary";
        public const string ActionIntrTopSellers = "IntrTopSellers";
        #endregion

        #region Exception Handling Actions
        public const string ActionError = "Error";
        public const string ActionFileNotFound = "FileNotFound";
        public const string ActionNoAccess = "NoAccess";
        #endregion

        #region Query String Parameter Names
        public const string QueryStringQuickSearchType = "qstype";
        public const string QueryStringQuickSearchTypeId = "typeId";
        public const string QueryStringLandingPageID = "landingpageId";
        public const string QueryStringSiteName = "siteName";
        public const string QueryStringPageTitle = "source";
        #endregion

        #region CheckPoint Type Parameter Names
        public const string CheckPointType = "cpType";
        public const string CheckPointTypeSearch = "Search";
        public const string CheckPointCriteriaKeywords = "Keywords";

        public const string CheckPointTypeId = "Id";
        public const string CheckPointTypeCourse = "Course";
        #endregion

        #region Query String Parameter Operations
        public const string QueryStringStartCharacter = "?";
        public const char QueryStringSplitCharacter = '&';
        public const char QueryStringAssignCharacter = '=';
        #endregion

        #region "CPEBrands"
        public const string ActionLearningInteractive = "LearningInteractive";
        public const string ActionWebinarLearningNetwork = "WebinarLearningNetwork";
        public const string ActionReqwired = "Reqwired";
        public const string ActionPilotTester = "PilotTester";
        public const string ActionCpeGearUpCompliance = "CPEGearUpCompliance";
        public const string ActionCpeBellLearningCompliance = "CPEBellLearningCompliance";
        public const string ActionCpePassOnlineCompliance = "CPEPASSOnlineCompliance";
        public const string ActionCpeMicromashCompliance = "CPEMicroMashCompliance";
        public const string ActionCpePPCCompliance = "CPEPPCCompliance";
        public const string ActionCpeRIACompliance = "CPERIACompliance";
        public const string ActionCpeWebinarPartnershipCompliance = "CPEWebinarPartnershipCompliance";
        public const string ActionReqwiredSpecialFeaturesSection1 = "ReqwiredSpecialFeatures#sec1";
        public const string ActionReqwiredSpecialFeaturesSection2 = "ReqwiredSpecialFeatures#sec2";
        public const string ActionReqwiredSpecialFeaturesSection3 = "ReqwiredSpecialFeatures#sec3";
        public const string ActionReqwiredSpecialFeaturesSection4 = "ReqwiredSpecialFeatures#sec4";
        public const string ActionReqwiredSpecialFeaturesSection5 = "ReqwiredSpecialFeatures#sec5";
        public const string ActionReqwiredSpecialFeaturesSection6 = "ReqwiredSpecialFeatures#sec6";
        public const string ActionReqwiredSpecialFeaturesSection7 = "ReqwiredSpecialFeatures#sec7";
        public const string ActionReqwiredSpecialFeaturesSection8 = "ReqwiredSpecialFeatures#sec8";
        public const string ActionReqwiredLearningLibraries = "ReqwiredLearningLibraries";
        public const string ActionCPEBrands = "CPEBrands";
        public const string ActionSemRedirectPage = "RedirectPage";
        public const string ActionCPEBrandSelection = "CPEBrandComplianceSelection";
        public const string ActionCPECompliance = "CPECompliance";
        public const string ActionCPEPolicyRefundSelection = "CPEPolicyRefundSelection";
        public const string ActionTermAndCondition = "TermsAndConditions";
        public const string ActionCPEDefaultCancellationrefundPolicy = "CPEDefaultCancellationRefundPolicy";
        public const string ActionCPEQuickFinderCompliance = "CPEQuickFinderCompliance";
        public const string ActionAuditWatchCompliance = "AuditWatchCompliance";
        #endregion

        #region "CPE Solutions"
        public const string ActionCpeSolutions = "CPESolutions";
        public const string ActionInHouseTraining = "InHouseTraining";
        public const string ActionLiveSeminarsConferences = "LiveSeminarsConferences";
        public const string ActionOnlineLearning = "OnlineLearning";
        public const string ActionSelfStudyCourses = "SelfStudyCourses";
        public const string ActionBailout = "Bailout";
        public const string ActionIFRS = "IFRS";
        public const string ActionPPCSelfStudy = "PPCSelfStudy";

        #endregion

        #region ComprehensiveBundles

        public const string ComprehensiveBundlesWebinarAttendeeEmailSubject = "Webinar Participation";

        #endregion

        #region "Shopping Cart"

        public const string ActionCartLogin = "CartLogin";
        public const string ActionCart = "Cart";
        public const string ActionCartMaintenance = "CartMaintenance";
        public const string ActionCartError = "CartError";
        public const string ActionBillingAndShipping = "BillingAndShipping";
        public const string ActionOrderSummary = "OrderSummary";
        public const string ActionReceipt = "Receipt";
        public const string AddProductListToCart = "AddProductListToCart";
        public const string ActionGetCartItems = "GetCartItems";
        public const string ActionShippingAddress = "ShippingAddress";
        public const string ActionAddressValidation = "AddressValidation";
        public const string ActionAccountCreationError = "AccountCreationError";
        public const string ActionCreditAuthorizationError = "CreditAuthorizationError";
        public const string ActionAddToCart = "AddToCart";
        public const string ActionReturnToCart = "ReturnToCart";
        public const string ActionProductError = "ProductError";
        public const string ActionReturnLiveEventToCart = "ReturnLiveEventToCart";
        public const string ActionReturnLiveEventSchedulesToCart = "ReturnLiveEventSchedulesToCart";
        public const string ActionGoToCart = "GoToCart";

        #endregion

        public const string ActionProductValidateValidate = "Validate";
        public const string ActionProductBillingCycleSelectFrequency = "SelectFrequency";
        public const string ActionProductBillingCycleConfirmBillingCycle = "ConfirmBillingCycle";
        public const string ActionProductBillingCycle = "BillingCycle";
        public const string ActionProductValidateResolve = "Resolve";

        #region "Home"
        public const string ActionIndex = "Index";
        #endregion

        #region "Sponsor Landing Page"

        public const string ActionLandingPage = "LandingPage";
        public const string ActionSponsorManagement = "SponsorManagement";
        public const string ActionSponsorSearch = "SponsorSearch";
        public const string ActionSponsorPageSearch = "SponsorPageSearch";
        public const string ActionSponsorDetails = "SponsorDetails";
        public const string ActionSponsorPageDetails = "SponsorPageDetails";
        public const string ActionProductsSearch = "ProductsSearch";
        public const string ActionSponsorPageManagement = "SponsorPageManagement";
        public const string ActionRemoveLandingPage = "RemoveLandingPage";
        public const string ActionSavePage = "SavePage";
        public const string ActionPreviewSponsorPage = "PreviewSponsorPage";
        public const string ActionGlobalTextManagement = "GlobalTextManagement";
        public const string ActionSearchLandingPage = "SearchLandingPage";
        public const string ActionSponsorPageImage = "SponsorPageImage";
        public const string ActionSponsorPageImageSave = "SponsorPageImageSave";
        public const string ActionSponsorPageImageDelete = "SponsorPageImageDelete";
        public const string ActionGlobalTextImage = "GlobalTextImage";
        public const string ActionGlobalTextImageSave = "GlobalTextImageSave";
        public const string ActionGlobalTextImageDelete = "GlobalTextImageDelete";
        public const string ActionPreviewImage = "PreviewImage";

        public const string SuccessConfirmationMessage = "Global Texts have been saved successfully";
        public const string GlobalTextFieldName = "staticName";
        public const string GlobalTextFieldDescription = "staticDescription";
        public const string HiddenFieldName = "noOfTexts";
        public const string HiddenFieldId = "textFieldId";
        public const string HiddenSequenceNumber = "sequenceNumber";

        public const int DefaultCountryId = 225;  // United States
        public const int DefaultStateId = 52;     // Texas

        public const string DefaultVendorLogo = "DefaultVendorLogo.gif";
        #endregion

        #endregion

        #region Professional
        public const string ActionForgotPassword = "ForgotPassword";
        public const string ActionForgotUserName = "ForgotUserName";
        public const string ActionSubmitSecurityAnswers = "SubmitSecurityAnswers";
        public const string ActionProfessionalLogin = "Login";
        public const string ActionProfessionalViewProfile = "ViewProfile";
        public const string ActionProfessionalViewProductAssociation = "ViewProductAssociation";
        public const string ActionForgotLogin = "ForgotLogin";
        public const string ActionViewProfile = "ViewProfile";
        public const string ActionvViewProductAssociation = "ViewProductAssociation";
        public const string ActionvUpdateUserProfile = "UpdateUserProfile";

        public const string OnlineCourseType = "IsOnline";
        public const string BookBasedCourseType = "IsBookBased";
        public const string TempFileSuffix = "_Temp";
        public const int UserRegistrationMinimumPasswordLength = 6;
        public const string ResumeFileNameDot = ".";
        public const string ResumeFilePathSlash = "\\";
        public const string ShippingNullValue = "null";
        public const char CommaSeperator = ',';
        public const string UserEnteredShippingAddress = "Entered in Shipping Address Field";

        #endregion

        #region Shared Session Management
        public const string ActionLogin = "Login";
        public const string ActionLoginAdmin = "LoginAdmin";
        public const string ActionCheckpointLogin = "CpLogin";
        public const string ActionCheckpointRedirect = "CpRedirect";
        public const string ActionRedirectToApplication = "RedirectToApplication";
        public const string ActionCheckpointUnlink = "unlink";
        public const string ActionApplicationUnlink = "Unlink";
        public const string ActionLogout = "Logout";
        public const string ActionRedirect = "Redirect";
        public const string SharedSessionCookieName = "CplGlobalSessionId";
        public const string SsmRedirectUrl = "CplReturnUrl";
        public const string SsmLastAccessTimeCookieName = "CplLastAcceessTime";
        public const string PingOrganization = "CheckpointLearning";
        public const string PartnerSpId = "GenericPingLinkIdp";
        public const string IdpAdapterId = "CheckpointLearningIdp";
        public const string CheckpointRedirectParam = "resume";
        public const string CheckpointLearningRedirectParam = "resume";
        public const string PingUnlinkUrl = "PingUnlinkUrl";
        public const string PingRedirectUrl = "PingRedirectUrl";
        public const string CheckpointLearningKeywordParam = "keyword";
        public const string CheckpointLearningDeparturePageParam = "cpType";
        public const string ActionMultipleLoginAttemp = "MultipleLogin";
        public const string ActionResetLogin = "ResetLogin";
        public const string MultipleLoginAttemptUserId = "MultipleLoginAttempUserId";
        public const string MultipleLoginAttemptIsAdmin = "MultipleLoginAttempIsAdmin";
        public const string SsmSupport = "Support";
        public const string SsmDirectLogin = "Direct";
        public const string ViewPingError = "PingError";
        public const string ActionPingError = "PingError";
        public const string ActionCloudLogin = "GhostCloudLogin";
        public const string ActionGetParametersForIFrame = "GetParametersForIFrame";

        #region Shared Session Management
        //Firm Administrator Post Login URLs
        public const string ReqwiredAdminUrlPrefix = "/organization/Controller?com.reqwired.site.action=";
        public const string PostLoginAdminEmployeeURL = "ComplianceManager";
        public const string PostLoginAdminUniversityURL = "UniversityCalendar";
        public const string PostLoginAdminLearningPathsURL = "LearningTemplates";
        public const string PostLoginAdminSettingsURL = "SettingsAccountView";
        public const string PostLoginAdminSupportURL = "Support";
        public const string PostLoginAdminResourcesURL = "RuleView";

        //Independednt and Professional Post Login URLs  
        public const string ReqwiredUserUrlPrefix = "/professional/Controller?com.reqwired.site.action=";
        public const string PostLoginUserHomeURL = "Homepage";
        public const string PostLoginUserStatusReportURL = "CEReports"; //"StatusIndex";
        public const string PostLoginUserActivityHistoryURL = "Activities";
        public const string PostLoginUserScheduleLearningURL = "LearningIndex";
        public const string PostLoginUserSettingsURL = "AccountView";
        public const string PostLoginUserResourcesURL = "RuleView";


        #endregion

        #endregion

        #region Error Routes
        public const string ServiceErrorPage = "/Error/ServiceError";
        #endregion

        #region Web Configuration
        public const string ServiceLocation = "ServiceLocation";
        public const string WebConfigSection = "sapphireSection";
        #endregion

        #region Email
        public const string ActionSendEmail = "SendEmail";
        public const string ActionConfirmationMessage = "ConfirmationMessage";
        #endregion

        #region Common
        public const int FirstRowIndex = 0;

        public const int RowsInPage = 10;
        public const int RowsInSmallPage = 5;
        public const int PagerSize = 10;
        public const int NoOfPagesToBeDisplayed = 5;
        public const int NoOfNewCoursesDefaultShow = 5;
        public const int NoOfQuestionsPerPage = 5;
        public const int RowsInCoursesBundleListPage = 50;
        public const int PagerSizeInCoursesBundleListPage = 50;
        public const int RowsInLiveEventOrderEntryGrid = 10;
        //Constants for Auto create Hidden Fields in Pagination
        public const string PageIndexHidenFieldId = "PageNumber";
        public const string PaginationHiddenFieldId = "Pagination";
        public const string NoOfRecordsHiddenFieldId = "TotalNoOfRecords";
        //Constants values for Time Manipulation
        public const string TimeMeridiamAM = "AM";
        public const string TimeMeridiamPM = "PM";
        public const string TimeFormatHHMM = "{0:hh:mm}";
        public const string TimeFormatMeridiam = "{0:tt}";

        //Constatnts use to build HTML tags
        public const string HTMLUnorderedListBegin = "<ul style='margin-bottom:0px'>";
        public const string HTMLUnorderedListEnd = "</ul>";
        public const string HTMLListItemBegin = "<li>";
        public const string HTMLListItemEnd = "</li>";

        // Contants to string concatanation
        public const string RemainingTextExistsIndicationDots = "...";

        public const int PaginationFirstPage = 1;

        public const string StringSpace = " ";
        #endregion

        #region Columns
        public const string ColumnFirstName = "[FirstName]";
        public const string ColumnLastName = "[LastName]";
        #endregion

        #region Excepiton Policy
        public const string PolicyException = "Global Policy";
        public const string PolicyPresentationException = "Web Policy";
        public const string PolicyDeliveryFrameworkException = "Service Policy";
        public const string PolicyServiceException = "Service Policy";
        public const string PolicyBusinessException = "Business Policy";
        public const string PolicyDataException = "Data Policy";
        #endregion

        #region Database Table names , Field Names and referencing keys

        #region "Table Names"
        public const String FieldOfStudyTable = "FieldOfStudy";
        public const String CPECredithourRangeTable = "CPECreditRange";
        public const String DeliveryFormatTable = "DeliveryFormat";
        public const String LocationTable = "Location";
        public const String PriceRangeTable = "PriceRange";
        public const String BrandTable = "Brands";
        public const string ViewScheduleInformation = "vw_ScheduleInformation";
        public const string ViewCourseHeader = "vw_CourseHeader";
        public const string ViewGAOYellowBook = "vw_GAOYellowBook";
        public const string ViewCourseLine = "vw_CourseLine";
        public const string CourseDescriptionView = "vw_CourseDescription";
        public const String StateTable = "State";
        public const string CourseTable = "vw_CourseList_ProductMetaData";

        #region StateTable Fields
        public const String StateID = "StateID";
        public const String StateName = "Name";
        public const String StateAbbreviation = "Abbreviation";
        #endregion

        public const string ProductDeliveryFormatView = "vw_ProductDelivery";
        public const string ViewDeliveryFormat = "vw_DeliveryFormat";
        public const string ProductMetadataView = "vw_ProductMetadata";
        public const string ViewBrands = "vw_Brands";
        public const string ViewFieldOfStudy = "vw_FieldOfStudy";
        public const string InHouseRequestView = "vw_InHouseRequest";

        public const string ViewLcation = "vw_Location";
        public const string ViewOfState = "vw_State";
        public const string ViewSchedule = "vw_Schedule";
        public const string ViewLearningLibrary = "vw_LearningLibrary";
        public const string ViewLearningLevel = "vw_LearningLevel";
        public const string ViewNasbaFieldOfStudy = "vw_NasbaFieldOfStudy";
        public const string ViewOtherCertifications = "vw_OtherCertifications";
        public const string ViewNASBADelivery = "vw_NASBADelivery ";
        #endregion

        #region Generic Column Names
        public const string ColId = "ID";
        public const string ColName = "Name";
        #endregion

        #region FieldOfStudyTable Fields
        public const String FieldOfStudyID = "FieldOfStudyID";
        public const String FieldOfStudyNASBAID = "NASBAFieldOfStudyID";
        public const String FieldOfStudyName = "Name";
        public const String FieldOfDescription = "Description";
        #endregion

        #region CourseTable Fields
        public const string FieldOfCourseId = "CourseID";
        public const string FieldOfCourseTitle = "Title";
        public const string FieldOfCourseGraphic = "GraphicPath";
        public const string FieldOfCourseLearningObjectives = "LearningObjectives";
        public const string FieldOfCourseOutLine = "OutLine";
        public const string FieldOfAdvancedRequirements = "AdvancedRequirements";
        public const string FieldOfSystemRequirements = "SystemRequirements";
        public const string FieldOfPublicationDate = "PublicationDate";
        public const string FieldOfCourseDescription = "Description";
        public const string FieldOfGradingFee = "CourseGradingFee";
        public const string FieldOfCategoryName = "CategoryName";
        public const string FieldOfProductMetaDataId = "ProductMetaDataID";

        #endregion

        #region OtherCertification table fields
        public const string FieldOfOtherCertification = "CertificationName";
        #endregion

        #region NASBAFieldOfStudyTable Fields
        public const string FieldOfNASBAFieldOfStudyName = "NASBAFieldOfStudyName";
        #endregion

        #region ProductDelivery Format fields
        public const string FieldOfCoursePrice = "CoursePrice";
        public const string FieldOfCPECredits = "NumberOfCPECredits";
        #endregion

        #region Delivery Format fields
        public const string FieldOfDeliveryFormat = "Name";
        #endregion

        #region Delivery Format Group fields and DB Keys
        //public const string DeliveryFormatGroupId = "DeliveryFormatGroupId";
        //public const string DeliveryFormatGroupName = "Name";

        //DB Keys
        public const String Webinar = "3";
        #endregion


        #region NASBADelivery fields
        public const string FieldOfNASBADeliveryMethod = "FormatName";
        #endregion

        #region LearningLevel fields
        public const string FieldOfLearningLevel = "LlName";
        #endregion

        #region LearningLibrary fields
        public const string FieldOfLearningLibraryID = "LearningLibraryID";
        public const string FieldOfLearningLibraryName = "LearningLibraryName";
        #endregion


        #region DeliveryFormatTable Fields
        public const String DeliveryFormatID = "DeliveryFormatID";
        public const String DeliveryFormatName = "Name";
        public const String DeliveryFormatNASBADeliveryID = "NASBADeliveryID";
        public const String DeliveryFormatDescription = "Description";

        #endregion


        #region LocationTable Fields
        public const String ScheduleDate = "Date";
        public const String ScheduleStartTime = "StartTime";
        public const String ScheduleEndTime = "EndTime";
        public const string ScheduleStatus = "Status";
        public const String LocationID = "LocationID";
        public const String LocationStateID = "StateID";
        public const String LocationName = "Name";
        public const String LocationAddress1 = "Address1";
        public const String LocationAddress2 = "Address2";
        public const String LocationZip = "Zip";
        public const String LocationHotelName = "HotelName";
        public const String LocationCity = "City";
        public const String LocationStateName = "StateName";
        public const String LocationAbbreviation = "Abbreviation";

        #endregion

        #region PriceRangeTable Fields
        public const String PriceRangeID = "PriceRangeID";
        public const String PriceRangeLow = "LowPriceRange";
        public const String PriceRangeHigh = "HighPriceRange";
        #endregion

        #endregion

        #region Page Specific Constants

        #region Email
        public const string SuccessMessage = "The e-mail has been sent";
        public const string FailureMessage = "The e-mail has not been sent";
        public const string MessageSubject = "Checkpoint Learning Course of interest- WWW.CheckPointLearning.com";
        public const string EmailRegularExpression = @"^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}" +
                                                                                                                                                                                                        @"\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\" +
                                                                                                                                                                                                        @".)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$";
        public const string EmptyFromAddress = "Please enter a from address! ";
        public const string EmptyToAddress = "Please enter a To address! ";
        public const string EmptySubject = "Please enter a subject! ";
        public const string EmptyMessage = "Please enter a message!";
        public const string InvalidFromAddress = "Please enter a valid From address! ";
        public const string InvalidToAddress = "Please enter a valid To address! ";
        public const string MessageTitleText = "Refer this course title : ";
        public const string MessageUrlText = " Course URL: ";
        public const string EmailFrom = "From";
        public const string EmailTo = "To";
        public const string EmailSubject = "Subject";
        public const string EmailMessage = "Message";

        #endregion

        #region Display Format Strings
        public const int PriceRangeFormat = 7001;
        public const int HoursRangeFormat = 7002;
        public const int CreditComboMaximumLimitFormat = 7003;
        public const int PriceComboMaximumLimitFormat = 7004;

        #endregion

        #region InformationRequest/Webinar/Schedule
        public const string SuccessSaveMessage = "Your Information Request has been submitted.";
        public const string FailureSaveMessage = "Your Information Request has not been submitted.";
        public const string EmptyFirstName = "Please enter the First Name";
        public const string EmptyLastName = "Please enter the Last Name";
        public const string EmptyCompanyName = "Please enter the Company Name";
        public const string EmptyTitle = "Please enter the Title";
        public const string EmptyStreetAddress1 = "Please enter the Street Address1";
        public const string EmptyCity = "Please enter the City";
        public const string EmptyState = "Please Select a State";
        public const string EmptyZip = "Please enter the Zip";
        public const string EmptyBusinessPhone = "Please enter the BusinessPhone";
        public const string EmptyEmailAddress = "Please enter the EmailAddress";
        public const string InvalidEmailAddress = "Please enter a valid EmailAddress";
        public const string InvalidNumberOfSeats = "Please enter valid number of seats";
        public const string EmptyInstructor = "Please enter the Instructor";
        public const string EmptyDate = "Please enter the Date";
        public const string NeedInstructorDropDownValueYes = "Yes";
        public const string NeedInstructorDropDownValueNo = "No";
        public const string primeNumberRegularExpression = @"^\d+$";
        public const string Need = "1";
        public const string DontNeed = "0";
        public const string SearchAgainLink = "Search again";
        public const string CheckDateValidity = "To Date Must Be Grater Than From Date";

        //-------XML Mapping InhouseInformation Request-----------
        public const string TableName = "Table";
        public const string ColIRId = "Id";
        public const string ColIRCourseId = "CourseId";
        public const string ColIRFirstName = "FirstName";
        public const string ColIRLastName = "LastName";
        public const string ColIRTitle = "Title";
        public const string ColIRStreetAddress1 = "StreetAddress1";
        public const string ColIRStreetAddress2 = "StreetAddress2";
        public const string ColIRZipCode = "ZipCode";
        public const string ColIRCity = "City";
        public const string ColIRState = "State";
        public const string ColIRCompanyName = "CompanyName";
        public const string ColIRBusinessPhone = "BusinessPhone";
        public const string ColIRFax = "Fax";
        public const string ColIREmailAddress = "EmailAddress";
        public const string ColIRNeedInstructor = "NeedInstructor";
        public const string ColIRInstructor = "Instructor";
        public const string ColIRNumberOfSeats = "NumberOfSeats";
        public const string ColIRStartDate = "StartDate";
        public const string ColIREndDate = "EndDate";
        public const string ColIRCompareDate = "CompareDate";
        public const string ColIRDate = "Date";
        public const string ColIRStateId = "StateID";
        public const string ColIRRequestedInformation = "RequestedInformation";
        public const string StartRootFrom = "<InHouseRequest";
        public const string StartRootTo = "<NewDataSet><InHouseRequest";
        public const string EndRootFrom = "</InHouseRequest>";
        public const string EndRootTo = "</InHouseRequest></NewDataSet>";
        public const string CourseCatelogRootElement = "</Table></NewDataSet>";

        //Grid Columns for Seminar and Webinar
        public const string GridColClassDate = "Class Date";
        public const string GridColClassTime = "Class Time";
        public const string GridColCity = "City";
        public const string GridColStatus = "Status";
        public const string GridColState = "State";
        public const string GridColDeliveryFormat = "Delivery Format";
        public const string GridColCPECredit = "CPE Credit";
        public const string GridColPrice = "Price";

        //--Other fields for ProductMetaData view
        public const string ColIRProductMetaDataID = "ProductMetaDataID";
        public const string ColIRRequestedInfo = "RequestedInfo";
        public const string InformationRequestBodyTitle = "In-House Information Request";

        //--Database tables and columns---------
        public const string ColProductMetadataId = "ProductMetadataID";
        public const string ColDeliveryForamtId = "DeliveryFormatID";
        public const string ColTitle = "Title";
        public const string ColDescription = "Description";
        public const string ColPrice = "Price";
        public const string ColCredits = "CPECredits";
        public const string ColFieldOfStudyId = "FieldOfStudyID";
        public const string ColFieldOfStudyName = "Name";
        public const string ColBrandName = "Name";
        public const string ColBrandId = "BrandID";
        public const string ColDeliveryFormat = "Name";
        public const string ColSeminarWebinarDescription = "SeminarWebinarDescription";


        //DeliveryFormat Id temporary value
        public const int TempDeliveryFormatID = 11;
        public const int SeminarDeliveryFormatID = 5;
        public const int WebinarDeliveryFormatID = 11;
        public const string ZeroNumberOfSeats = "0";

        //State Const Value
        public const int EmptyStateId = 0;

        //Aliases
        public const string AsProductMetaDataID = "ID";
        public const string AsBrandName = "BrandName";
        public const string AsFieldOfStudyName = "FieldOfStudyName";
        public const string AsPrice = "Price";
        public const string AsCPECredit = "CPECredit";
        public const string AsCourseID = "CourseID";

        //Abbreviation DropDownList Values
        public const string AbbDropDownValue = "0";
        public const string AbbDropDownText = "Select State";

        #endregion

        #region Resource Repository Message Headers
        public const string MessageHeaderPageSaved = "Page Saved";
        public const string MessageHeaderPageError = "Page Error";
        public const string MessageHeaderPageValidation = "Page Validation";
        #endregion


        #endregion

        #region Common

        #region SeachTypes
        public const string BasicSearch = "BasicSearch";
        public const string AdvancedSearch = "AdvancedSearch";
        public const string QuickSearch = "QuickSearch";
        public const string InteractiveSearch = "InteractiveSearch";
        public const string InteractiveCourse = "InteractiveCourse";
        #endregion

        #region SearchSource
        public const string CourseDetailsSource = "CourseDetails";
        #endregion

        #region vw_CourseDescription Fields
        public const string vw_CourseDescriptionFormatFieldId = "DeliveryFormatID";
        public const string vw_CourseDescriptionFormatFieldName = "DfName";
        #endregion

        public const int FullyCompletedPercentage = 100;
        public const string AdvancedSearchYellowBookReplaceValue = ",1000";

        //Defect fix on #66864,74287 :When the user fails the exam after 3 attempts progress=99%
        public const int FullyCompletedPercentageForFailExam = 99;
        //Defect fix on #93158,97310 
        public const int ActiveLiveEventStatusId = 1;

        #endregion

        public const string Underscore = "_";
        public const string Dash = "-";
        public const string None = "None";
        public const string Yes = "Yes";
        public const string No = "No";
        public const string NotApplicable = "N/A";
        public const string InProgress = "In-Progress";
        public const string DollarSign = "$";

        #region Search Result Page Sort Fields
        public const String SortFieldNone = "";
        public const String SortFieldBrandName = "Brand Name";
        public const String SortFieldTitle = "Title";
        public const String SortFieldAcronym = "Acronym";
        public const String SortFieldFieldofStudy = "Category";
        public const String SortFieldCPECredit = "CPE Credits";
        public const String SortFieldDeliveryFormat = "Delivery Format";
        public const String SortFieldPrice = "Price";
        public const string SortFieldDefault = SortFieldTitle;
        public const string LiveEventSortFieldDate = "Date";
        public const string LiveEventSortFieldState = "State";
        public const string LiveEventSortFieldLocation = "Location";
        public const string LiveEventSortFieldPrice = "price";
        public const string LiveEventSortFieldEarlyBirdPrice = "Early Bird Price";
        public const string LiveEventSortFieldDefalut = LiveEventSortFieldDate;
        #endregion

        #region Object Names
        public const string ObjectQuickSearchNavigation = "QuickSearchNavigation";
        public const string ObjectBasicSearch = "BasicSearch";
        public const string ObjectInteractiveSearch = "InteractiveSearch";
        public const string ObjectAdvancedSearch = "AdvancedSearch";
        #endregion

        #region Quick Search Type
        public const int QuickSearchByDeliveryFormat = 1;
        public const int QuickSearchByBrand = 2;
        public const int QuickSearchByFieldOfStudy = 3;
        public const int QuickSearchViewTopNewCourses = 4;
        public const int QuickSearchByYellowBook = 5;
        public const int QuickSearchYellowBookValue = 1;
        public const string QuickSearchValueAttribName = "quickSearchValue";
        public const string QuickSearchTypeAttribName = "quickSearchType";
        #endregion

        #region Search Criteria Keys
        public const string SearchCriteriaKeyword = "Keyword";
        public const string SearchCriteriaQuickSearchValue = "QuickSearchValue";
        public const string SearchCriteriaSortBy = "SortBy";
        public const string SearchCriteriaPageNumber = "PageNumber";
        public const string SearchCriteriaQuickSearchType = "QuickSearchType";
        public const string SearchCriteriaSearchType = "SearchType";
        public const string SearchCriteriaIsNewCourse = "IsNewCourse";
        public const string SearchCriteriaInteractiveCourse = "InteractiveCourse";

        public const string SearchCriteriaRowCount = "Recordcount";
        public const string SearchCriteriaFieldOfStudyIDs = "FieldOfStudyIDs";
        public const string SearchCriteriaDeliveryFormatIDs = "DeliveryFormatIDs";
        public const string SearchCriteriaCreditRangeID = "CreditRangeID";
        public const string SearchCriteriaPriceRangeID = "PriceRangeID";
        public const string SearchCriteriaStateID = "StateID";
        public const string SearchCriteriaFromDate = "FromDate";
        public const string SearchCriteriaToDate = "ToDate";
        public const string BundlePackageTypeIDs = "BundlePackageTypeIDs";

        public const string SearchCriteriaInnerQuery = "InnerQuery";
        public const string SearchCriteriaRecordCount = "RecordCount";

        public const string CPECreditDropDownMaximumLimit = " Over";
        public const string CPEPriceDropDownMaximumLimit = " and up";

        //CE Tracking
        public const string CpeTrackingLawProductTitle = "CpeTrackingLawProductTitle";
        public const string CpeTrackingAccountingProductTitle = "CpeTrackingAccountingProductTitle";
        public const string CpeTrackingDualProductTitle = "CpeTrackingDualProductTitle";

        public const string CpeTrackingLawProductDescription = "CpeTrackingLawProductDescription";
        public const string CpeTrackingAccountingProductDescription = "CpeTrackingAccountingProductDescription";
        public const string CpeTrackingDualProductDescription = "CpeTrackingDualProductDescription";
        public const string ReconciliationReportLocationPath = "ReconciliationReportLocation";
        #endregion

        #region UIControl Details
        public const string DefaultSelectBoxValue = "0";
        public const int DropDownSelectionNotSpecifiedValue = -1;
        #endregion

        #region DeliveryFormatDictionary
        public const string DeliveryFormatDictionaryKeyName = "Name";
        public const string DeliveryFormatDictionaryKeyCPECredit = "CPECredit";
        public const string DeliveryFormatDictionaryKeyPrice = "Price";
        public const string DeliveryFormatDictionaryValueName = "Delivery Format";
        public const string DeliveryFormatDictionaryValueCPECredit = "CPE Credit";
        public const string DeliveryFormatDictionaryValuePrice = "Price";
        #endregion

        #region Temp Data Fields
        public const string TempDataKeywords = "Keywords";
        public const string TempDataFieldOfStudies = "FieldOfStudies";
        public const string TempDataStates = "States";
        public const string TempDataCreditHours = "CreditHours";
        public const string TempDataPriceRange = "PriceRange";
        public const string TempDataDeliveryFormats = "DeliveryFormats";
        public const string TempDataFromDate = "FromDate";
        public const string TempDataToDate = "ToDate";
        public const string TempDataRecordCount = "RecordCount";
        public const string TempDataSortBy = "SortBy";
        #endregion

        #region Advanced Search Drop Down Default Items
        public const string AdvancedSearchDefaultPriceRange = "Select a Price Range";
        public const string AdvancedSearchDefaultCreditRange = "Select a Credit Range";
        public const string AdvancedSearchDefaultState = "Select the State";
        #endregion

        #region Search Engine Marketing
        public const string ViewReports = "ViewReports";
        public const string LandingPage = "LandingPage";
        public const string VenderLandingPage = "../Vender/LandingPage";
        public const string SalesReport = "SalesReport";
        public const string InternetSalesReport = "InternetSalesReport";
        public const string SemCookieName = "SEMCookie";
        public const string SemCookieNameLastUpdatedDate = "SEMCookieLastUpdatedDate";
        public const long CookieExpiresDays = 10;

        #region Vendor Landing Page Management
        public const string VendorLandingPageCookieName = "VendorLandingCookie";
        public const string VendorLandingPageCookieLastUpdatedDate = "VendorLandingCookieLastUpdatedDate";
        public const long VendorLandingPageCookieExpiresDays = 10;
        public const string VendorProductListIdCookie = "VendorProductListIdCookie";
        public const int VendorProductListIdCookieExpiresDays = 30;
        #endregion
        public const string CookieSeparator = "::";

        //-------XML Mapping SaveVisitInformation Request-----------
        public const string StartRootFromSaveVisit = "<SEMVisitor";
        public const string StartRootToSaveVisit = "<NewDataSet><SEMVisitor";
        public const string EndRootFromSaveVisit = "</SEMVisitor>";
        public const string EndRootToSaveVisit = "</SEMVisitor></NewDataSet>";
        public const string ViewExcelReport = "View As Excel";
        public const string GenerateReport = "Generate Report";
        public const string ExcelContentType = "application/vnd.ms-excel";
        public const string Excel2007ContentType = "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet";
        public const string XslSalesMapPath = @"~\Resources\SEMSalesReportExcel.xsl";
        public const string XslInternetSalesMapPath = @"~\Resources\SEMInternetSalesReportExcel.xsl";
        public const string XslReportInstanceMapPath = @"~\Resources\ReportXSLT.xsl";

        public const string ReportInatanceXML = "ReportInatance.xml";


        #endregion

        #region Query String Parameter Names
        public const string QueryStringId = "Id";
        public const string QueryStringHideQuickSearchNavigation = "hqsnav";
        #endregion

        #region Configuration
        public const string UnityConfiguration = "unityConfiguration";
        public const string UnityWebContainer = "SapphireContainer";
        #endregion

        #region Internet Sales Summery Report
        public const string InvalidDateRange = "Please select a valid month range. Selected months should be lower than or equal to the current month";
        public const string FromMonthLowerThanToMonth = "From month should be lower than or equal to the To month";

        public const string IntRptMonth = "Month";
        public const string IntRptMTDSales = "MTD Sales";
        public const string IntRptMTDOrders = "MTD No Orders";
        public const string IntRptYTDSales = "YTD Sales";
        public const string IntRptYTDOrders = "YTD No Orders";
        public const string IntRptLYMTDSales = "Last Yr MTD Sales";
        public const string IntRptLYMTDOrders = "Last Yr MTD No Orders";
        public const string IntRptLYTDSales = "Last YTD Sales";
        public const string IntRptLYTDOrders = "Last YTD No Orders";

        #region String Replacements
        public const string OpenTagInternetSalesSummery = "<SearchMarketingInternetSalesSummary>";
        public const string EndTagInternetSalesSummery = "</SearchMarketingInternetSalesSummary>";
        public const string OpenTagInternetSalesReport = "<InternetSalesReport>";
        public const string EndTagInternetSalesReport = "</InternetSalesReport>";
        #endregion

        #region Value set
        public const int BeginningValueSet = 0;
        public const int FirstValueSet = 1;
        #endregion


        #endregion

        #region Active Directory
        public const string UserGivenName = "givenName";
        public const string UserDisplayName = "DisplayName";
        public const string UserLastName = "sn";
        public const string UserEmail = "mail";
        public const string UserAlias = "mailnickname";
        public const string UserPhoneNo = "mobile";
        public const string UserJobTitle = "title";

        #endregion

        #region Resource

        #region Manage User Profile
        public const string DisplayPassword = "*******";
        public const string DefaultPassword = "Password";

        public const string IsUserExist = "isExist";
        public const string NewlyAddeduserId = "userId";

        public const string AddNewUserEmailSubject = "Welcome New Resource Repository User";
        public const string AddNewUserEmailMessage = "The following user profile has been added to the Resource Repository: ";

        public const string PrimaryContactYes = "Yes";
        public const string PrimaryContactNo = "No";

        public const string UserListDefaultValue = "Select a User";
        #endregion

        #region Personal Information Page Sort Fields
        public const string SortFieldDateEnterd = "Date Entered";
        public const string SortEnterBy = "Enter By";
        public const string SortFieldSubject = "Subject";
        public const string SortFieldNeverArchive = "Never Archive";

        public const string MinBirthYear = "1930";
        public const string MaxBirthYear = "2000";

        #endregion

        #region Email information
        public const string FieldChangedEmailSubject = "Notice: Change to {0} Record";
        public const string ChangedFieldCredentialStatus = "Credential Status";
        public const string ChangedFieldResourceStatus = "Resource Status";
        public const string ChangedFieldResourceGroup = "Resource Group";
        public const string ChangedFieldPrimaryContact = "Primary Contact";
        public const string NewResourceAdded = "New Resource Added";
        public const string NewGroupAssignedSubject = "The following Resource has been added to the ";
        public const string OrderRecieptEmailSubject = "{0}, Your Order Confirmation & Receipt from Checkpoint Learning";

        #endregion

        #region ResourceInformation Tab Actions
        public const string ActionResourceInformation = "ResourceInformation";

        public const string ActionEditGroup = "EditGroup";
        public const string ActionEditPaymentInfo = "EditPaymentInfo";

        public const string ActionDeleteGroup = "DeleteGroup";
        public const string ActionDeletePaymentInfo = "DeletePaymentInfo";
        #endregion

        #region Resource Session
        public const string ResourceSessionKey = "DATA";
        #endregion

        #region Word Template
        public const string WordTemplateFirstName = "First Name";
        public const string WordTemplateLastName = "Last Name";
        public const string WordTemplateNickName = "Nick Name";
        public const string WordTemplateDoingBusinessAs = "Doing Business As";
        public const string WordTemplateVenderId = "Vender Id";

        public const string WordTemplateTable = "w:tbl";
        public const string WordTemplateTableRow = "w:tr";
        public const string WordTemplateTableCell = "w:tc";
        public const string WordTemplateText = "w:t";

        public const string ResourceTableName = "Personal  Information";
        public const string ResourceTableFirstName = "First Name";
        public const string ResourceTableLastName = "Last Name";
        public const string ResourceTableNickName = "Nickname";
        public const string ResourceTableDoingBusinessAs = "Doing Business As";
        public const string ResourceTablePersonalComputerInformation = "Personal Computer Information";
        public const string ResourceTableBirthMonth = "Birth Month (MM)";
        public const string ResourceTableBirthDate = "Birth Date (DD)";
        public const string ResourceTableDisplayCredential = "Display Credentials As (e.g., CPA, CFP)";
        public const string ResourceTableBiography = "Biography";
        public const string ResourceTableVendorId = "Vendor Id";
        public const string ResourceDefaultBirthYear = "2000";
        public const string ResourceBirthDateSplitter = "/";

        public const string PaymentInformationtableName = "Payment Information";
        public const string PaymentInformationVendorId = "Vendor Identification Number";

        public const string CertificatesTableName = "Certificates & Degrees";
        public const string CertificatesTableTitle = "Title";
        public const string CertificatesTableAcronym = "Acronym (e.g., MBA, Ph.D)";
        public const string CertificatesTableCertificateType = "Type (Certificate, Degree)";
        public const string CertificatesTableCredentialStatus = "Credential Status (Active, Inactive, Expired)";
        public const string CertificatesTableIssuingState = "Issuing State (e.g., TX)";

        public const string AddressTableName = "Address";
        public const string AddressTableAddress1 = "Address 1";
        public const string AddressTableAddress2 = "Address 2";
        public const string AddressTableCity = "City";
        public const string AddressTableAddressType = "Type (Home, Office, Mailing, Shipping)";
        public const string AddressTableState = "State (e.g., TX)";
        public const string AddressTableCountry = "Country Code *"; // * Indicates that user has to refer the given country list

        public const string PhoneTableName = "Phone";
        public const string PhoneTableNumber = "Number (nnn-nnn-nnnn)";
        public const string PhoneTableIsPrimary = "Primary(Y/N)";
        public const string PhoneTablePhoneType = "Type (Home, Work, Cell, Fax)";

        public const string EmailTableName = "Email";
        public const string EmailTableAddress = "Email Address (text@text.xxx)";
        public const string EmailTableIsPrimary = "Primary(Y/N)";
        public const string EmailTableEmailType = "Type (Home, Work, Other)";

        public const string TrueAsBooleanValue = "true";
        public const string YesAsBooleanValue = "y";
        public const string XAsBooleanValue = "x";

        public const string WordTemplateErrorMessage = "Error in Word file";
        public const string WordTemplateErrorHeader = "Error";

        public const string FileImportCriticalErrorMessage = "Resource Can't save without a valid ";
        public const string FileImportErrorMessage = " table information can't save without a valid ";
        public const string FileImportWarningMessage = " table information will save without ";
        public const string FileImportInvalidVendorId = "Vendor Id should be 6 digit numeric.";
        public const string FileImportMissingTable = "Word Tempalte doesn't contain table ";
        public const string FileImportMaxLenthMessage = " field can contain only ";
        public const string FileImportMaxLenthCharacters = " characters. ";
        public const string FileImportInvalidEmail = "Invalid Email address";
        public const string FileImportInvalidPhoneNo = "Enter a valid 10-digit phone number including dashes.(xxx-xxx-xxxx)";
        public const string FileImportEmailRegex = "^[\\w\\.=-]+@[\\w\\.-]+\\.[\\w]{2,3}$";
        public const string FileImportPhoneNoRegex = "^[0-9]\\d{2}-\\d{3}-\\d{4}$";

        #endregion

        #endregion

        public const string SemCourseId = "CourseId";

        #region "SqlQuery Column ConcatString"
        public const string SqlQueryColumnConcat = " +' '+ ";
        public const string OracleDateTimeType = "dd-MMM-yy";
        #endregion

        #region Web View Names
        public const string WebViewFileLoader = "FileUploader";
        public const string WebViewProfessionalForgotPassword = "ForgotPassword";
        public const string WebViewProfessionalUserNotFound = "UserNotFound";
        public const string WebViewProfessionalIncorrectAnswers = "IncorrectAnswers";
        public const string WebViewProfessionalUserNamePasswordSentSuccess = "UserNamePaswordSentSuccess";
        public const string WebViewProfessionalSecurityQuestions = "SecurityQuestions";
        public const string WebViewProfessionalLocked = "ProfessionalLocked";
        #endregion

        #region PartialViewNames

        public const string PartialViewSponsorSearch = "SponsorSearch";
        public const string PartialViewSelectedSponsor = "SelectedSponsor";
        public const string PartialViewSponsorPageSearch = "SponsorPageSearch";
        public const string PartialViewSponsorProductSearch = "SponsorProductSearch";
        public const string PartialViewLandingPageViewer = "LandingPageViewer";
        public const string PartialViewSponsorPageDetails = "SponsorPageDetails";
        public const string PartialViewSponsorPageImage = "SponsorPageImage";
        public const string PartialViewGlobalTextImage = "GlobalTextImage";

        #endregion

        #region FormCollection keys
        public const string VendorLandingTextItems = "VendorLandingTextItems";
        public const string VendorLandingTextItemsId = "VendorLandingTextItemsId";
        public const string SelectedFilter = "";

        public const string BuildReportFirstValue = "FirstValue";
        public const string BuildReportSecondValue = "SecondValue";
        public const string BuildReportTodayValue = "TodayValue";

        public const string BuildReportAvilableFilters = "AvilableFilters";
        public const string BuildReportAvailableFilterOperators = "AvailableFilterOperators";
        public const string BuildReportSelectedFilterOperator = "SelectedFilterOperator";
        public const string BuildReportInputRegularExpression = "InputRegularExpression";
        public const string BuildReportInvalidValueErrorMessage = "InvalidValueErrorMessage";

        #endregion

        #region Sponsor Page Management: Search Results related hidden fields

        public const string SponsorResultCurrentPageHiddenId = "SponsorCurrentPage";
        public const string SponsorResultTotalRecordsHiddenId = "SponsorTotalRecords";
        public const string SponsorSearchKeywordTextBoxId = "sponsorSearchKeyword";
        public const string SponsorSearchIncludeInactiveCheckboxId = "includInactive";

        public const string ProductSearchResultCurrentPageHiddenId = "ProductSearchCurrentPage";
        public const string ProductSearchResultTotalRecordsHiddenId = "ProductSearchTotalRecords";
        public const string ProductSearchKeywordTextBoxId = "productSearchKeyword";

        #endregion

        #region Template Engine Tokens
        public const string TokenCourseTitle = "Title";
        public const string TokenCourseUrl = "Url";
        public const string TokenVendorImagePrefix = "Vendor_";
        public const string TokenGlobalImagePrefix = "Global_";
        #endregion

        #region "Vendor"
        public const string SponsorDetailsSuccessfullySaved = "Sponsor details successfully saved";
        public const string SponsorDetailsSuccessfullyDeleted = "Sponsor details successfully Deleted";
        public const string SponsorDetailsAlreadyInDatabaseError = "The Sponsor Code is already in the database";
        public const string UnkonwnError = "Unknown Error";

        public const int SuccessMessageId = 0;
        public const int UnSuccessMessageId = 1;
        public const int UnkownErrorId = 2;
        #endregion

        #region "SQL exception Numbers"
        public const int DuplicateValuesInsertionExceptionNumber = 2601;
        #endregion

        #region web
        public const string UrlProtocolHttp = "http://";
        public const string UrlPortDelimiter = ":";
        public const int DefaultHttpPort = 80;
        public const string HtmlSpace = "&nbsp;";
        #endregion

        #region Search Messages
        public const string NoRecordFoundMessage = "No Resource found for the given search criteria.";
        #endregion

        #region Notification Service
        public const string NotificationServiceEndpoint = "NotificationService";
        public const string EmailDumpPath = "\\Debug\\Notifications";
        #endregion

        #region Reports
        public const string ReportList = "ReportList";
        public const string ReportInstanceList = "ReportInstanceList";
        public const string XslReportMapPath = @"~\Resources\ReportXSLT.xsl";
        public const string TodayValue = "True";
        public const string SortByFirst = "Sort By";
        public const string SortByNext = "Then By";
        public const string ControllerReports = "Reports";

        public const string ControllerManifest = "ManifestReports";

        public const string MasterPageReport = "Report";
        public const string MasterPagePostLoginReport = "PostLoginReport";
        public const string XmlAttributeKey = "key";
        public const string XmlAttributeValue = "value";
        public const string XmlElementComment = "Comment";
        public const string XmlElementScore = "Score";
        public const string XmlElementCredit = "Credit";
        public const string XmlAttributeCategory = "category";
        public const string ControllerAdminReports = "AdminReports";
        public const string ProductReconciliationReportXSLPath = @"~\Resources\ProductReconciliationReport.xslt";
        public const string BundleProductReconciliationReportXSLPath = @"~\Resources\BundleProductReconciliationReport.xslt";
        // Defect Fixing - #86092 Default Bundle Name
        public const string DefaultPickNBundleName = "Pick N Bundle";
        //Defect fix # 87457
        //Set up file extension type as '.xls'
        public const string ExcelExtensionType = ".xls";

        #endregion

        #region Pilot Test
        public const string ActionPilotTests = "PilotTests";
        public const string ActionSearchPilotTests = "SearchPilotTests";
        public const string PilotTestEmailTemplateSearchKeyword = "SearchKeyword";
        public const string PilotTestNASBAReportFilter = "NASBAReportFilter";
        public const string PilotTest = "PilotTest";
        public const string AddTestersSaveButtonName = "Save";
        public const double FileMaxLength = 2e9;
        public const string PilotTestsReportXSLPath = @"~\Resources\PilotTestsReport.xsl";
        public const string StatusReportXSLPath = @"~\Resources\StatusReport.xsl";
        public const string NASBAReportXSLPath = @"~\Resources\NASBAReport.xsl";
        public const string UserTypeOnline = "Online";
        public const string AcceptHeaderText = "Thank you for Accepting!";
        public const string RejectHeaderText = "Thank you for Responding!";
        public const string SavePilotTesterMessage = "Details Successfully Saved";
        public const string TesterAlreadyExistsMessage = "Some testers have been added to this pilot test by somebody else";
        public const string PilotTesterDefaultFirstName = "Tester Name";
        public const int PilotTestDefaultSkillLevelId = 1;
        public const string PTest = "PTest";//This will be used to get unprotected URL's for Accept and reject instances insteend of getting protected 
        public const int PilotTestNoOfCPECreditForFOSNotAssigned = 0;
        //'PilotTest' instances 

        public const string ValidTimeRegularExpression = @"^([1-9]|0[1-9]|1[0-2]):[0-5]\\d$";
        public const string ValidIntegerRegularExpression = @"^\\d*$";
        public const string PilotTestActiveCourseStatus = "Active";
        public const string PilotTestInActiveCourseStatus = "Inactive";
        public const string PilotTestTesterPagination = "Pagination";
        public const string PilotTestTesterSelect = "Select";
        public const int PilotTestAllMacrosEmailType = -1;
        public const string PilotTesterDomentStyle = "display:none";
        public const string TesterProfilesXSLPath = @"~\Resources\TesterProfiles.xsl";
        public const string PilotTestIssueCertificateAction = "IssueCertificates";
        #endregion

        #region Report Operators
        public const string OperatorEqualTo = "Equal to";
        public const string OperatorDoesNotEqualTo = "Does not equal to";
        public const string OperatorContains = "Contains";
        public const string OperatorDoesNotContain = "Does not Contain";
        public const string OperatorBeginsWith = "Begins with";
        public const string OperatorDoesNotBeginWith = "Does not Begin with";
        public const string OperatorEndsWith = "Ends with";
        public const string OperatorDoesNotEndWith = "Does not End with";
        public const string OperatorGreaterThan = "Greater than";
        public const string OperatorGreaterThanOrEqualTo = "Greater than or equal to";
        public const string OperatorLessThan = "Less than";
        public const string OperatorLessThanOrEqualTo = "Less than or equal to";
        public const string OperatorBetween = "Between";
        #endregion

        #region Report Common constants
        public const string ForInitialPeriod = " For Initial Period";
        public const string ForComparisonPeriod = " For Comparison Period";
        public const string DatePeriodSeperator = ";";
        public const string FinalReportTable = "ResultsTable";
        public const string ReportFirmFilterColumnOrganizationId = "OrganizationID";
        public const string ReportTypeComparison = "Comparison";
        #endregion

        public const string PdfFileContentType = "application/pdf";
        public const string BetweenDelimeter = ";";
        public const string ImageFileContentType = "image/jpeg";

        #region Promo Codes

        public const string PromoCodes = "PromoCodes";
        public const string PromoCodeRules = "PromoCodeRules";

        #endregion

        #region User Registration
        public const int RecordCountEmpty = 0;
        public const string HyphenString = "-";
        public const char HyphenChar = '-';
        public const string ResumesRelativePath = @"..\Resumes\";
        public const string DefaultContentType = " ";
        public const string PreferenceElement = "Preference";
        public const string DefaultTimeZoneElement = "DefaultTimeZone";
        public const string DefaultTimeZoneAttribute = "value";

        #endregion

        public const string Home = "Home";
        public const string SsmAgentConfigFile = "SsmAgentConfig.xml";

        //Constant maintains the cache name for Unprotected Pages Xml data
        public const string SsmUnprotectedPageCache = "SharedSessionUnprotectedPageCache";
        public const string Patterns = "patterns";
        public const char Asterisk = '*';

        #region Shared Session

        public const string UnProtectedResources = "UnProtectedResources.xml";
        //Constant maintains the cache name for Unprotected Pages Xml data

        //Pages that has the Login Screen 
        public const string LearningInteractive = "CPEBrands/LearningInteractive";
        public const string OnlineGrading = "OGS";
        public const string SSMLogin = "SSM/Login";
        #endregion

        #region OnlineGrading
        public const string OnlineExamPrevoiusAction = "Previous";
        public const string OnlineExamFinishAction = "Finish";
        public const string OnlineExamNextAction = "Next";
        public const string OnlineExamContinueLaterAction = "ContinueLater";

        public const string ExamStatusNotYetStarted = "Not Yet Started";
        public const string ExamStatusInProgress = "In-Progress";
        public const string ExamStatusCompleted = "Completed";

        public const string ExamAttemptSourceOnline = "Online";
        public const string OnlineGradingExamIdParameterName = "ExamId";
        public const int OnlineGradingAllMacros = 0;


        public const int ExamInternalUserId = 3;

        #endregion

        public const string ActionPostLoginCommanNavLoad = "ActionPostLoginCommanNavLoad";
        public const string ConfigFolderPath = @"\Config\";
        public const string RelativeEncryptionFilePath = @"\Config\EncryptionKey.txt";
        public const string DefaultEncryptionKey = "*&^(*&KLHFSKLHFSLKHKLH@^*/(E$^*(^$&*(";
        public const int MaximumLengthOfTheQuestion = 250;

        #region Module Id

        public const int ModuleIdPilotTest = 1;
        public const int ModuleIdOgs = 2;

        public const string CartItemCount = "CartItemCount";

        #endregion

        #region Macro Definition Unity Names

        public const string MacroDefinitionUnityNamePilotTest = "PilotTestMacros";
        public const string MacroDefinitionUnitNameOgs = "OgsMacros";

        #endregion

        #region method execution Failure Return Values

        public const int MethodExecutionFailureReturnNegativeId = -1;
        public const int MethodExecutionSuccessReturnId = 1;

        #endregion

        #region method parameters
        public const string ogsBusinessSaveExamCatalogData = "catalogData";
        #endregion

        #region Course Images Path
        public const string CourseImagesPath = @"~\Images\CourseGrapics\";
        public const string FileDownloadErrorMessage = "File Download failed. Please try again.";
        #endregion

        public const string NasbaCredentialRequirement = "NasbaCredentialRequirement";
        public const string ContractRules = "ContractRules";
        public const string RoyaltyRules = "RoyaltyRules";
        public const string RoyaltyRates = "RoyaltyRates";
        public const string Notes = "Notes";

        #region Price Web Service Constants
        public const string PriceNotFound = "NOT FOUND";
        public const string PriceNotApplicable = "N/A";
        #endregion

        #region Entitlment Web Service Settings

        public const string EntitlementServiceClientConfigurationElement = "EntitlementServiceWS";

        #endregion

        #region Attendance Management Certificate Email Send
        public const string CertificateEmailSendServiceClientConfigurationElement = "liveEventsService";
        #endregion

        #region CartSoap Web Service Setting
        public const string UnisonServiceClientConfigurationElement = "order_historySoap";
        #endregion

        public const string BackwardSlash = "/";
        public const string ForwardSlash = "\\";
        public const string Pipe = " | ";
        public const string PageTitle = "Checkpoint Learning";
        public const string CourseDeatailsTitleCpe = " CPE ";

        #region Environment Settings

        public const string EnvironmentSettingEditAction = "Edit";
        public const string EnvironmentSettingSaveAction = "Save";
        public const string EnvironmentSettingReloadAction = "Reload";
        public const string EnvironmentIDAppSettingName = "EnvironmentId";
        public const int EnvironmentSettingAdminUser = 1;
        public const int EnvironmentSettingNoneAdminUser = 0;
        public const string PdfFileSarchPattern = "*.pdf";
        public const string FilePathParameter = "filePath";
        #endregion

        #region Migration Settings

        public const string Reqwired3DWebServiceEndpointConfigurationName = "migrationservice";
        public const string OnlineGradingWebServiceEndpointConfigurationName = "ThomsonAccountManagmentServiceSoap";
        public const string MicroMashWebServiceEndpointConfigurationName = "MigrationServiceSoap";
        public const string PassOnlineWebServiceEndpointConfigurationName = "PassOnlineMigrationServiceSoap";
        public const string IpDataImportWebServiceEndpointConfigurationName = "IpDataImport";
        public const int AccountancyEmployeeVeticalValue = 1;
        public const int LawEmployeeVeticalValue = 2;

        #endregion

        #region Live Event Management

        public const string ActionManageLiveSeminar = "ManageLiveSeminar";
        public const string ActionLiveEventLogView = "LiveEventsLogView";
        public const string ActionLiveEventList = "LiveEvents";
        public const string ControllerLiveEvent = "LiveEvent";
        public const int CourseAcronymExistsReturnId = 0;

        #endregion

        #region CPE Tracking
        public const string ActionNameCPETracking = "CpeTracking";
        #endregion

        #region Auto Notify
        public const string ControllerAutoNotifyCourses = "AutoNotify";
        public const string CourseDetailsQueryString = "?source=CourseList&id=";
        public const string AutoNotifyEmailFormatterXslt = "AutoNotifyEmailFormatter.xslt";
        #endregion

        #region Custom Product List Management
        public const string ControllerProductList = "ProductList";
        public const string ProductListAlreadyInDatabase = "The Product List Code already exists";
        public const int ProductListInactiveStatus = 2;
        #endregion

        #region Manifest

        public const string ManifestList = "ManifestList";

        #endregion

        #region DynamicAssembly

        public const string ChapterLinkingView = "ChapterLinkingView";
        public const string ChapterLinkingActions = "ChapterLinkingActions";

        public const string ChapterLinking = "ChapterLinking";
        public const string ReportsView = "ReportsView";
        public const string ReportResultView = "ReportResultView";

        public const string FillCodeAndTitle = "FillCodeAndTitle";

        #endregion

        public const string CourseFinderReportXsltPath = @"~\Resources\CourseFinderFormatter.xslt";

        #region IRS
        public const string IrsImportLogXsltPath = @"~\Resources\IrsImportLogFormatter.xslt";
        public const string IrsEntitleUserErroMessage = "Entitlement failed due to an error";
        public const string IrsEntitleEmptyOrderErroMessage = "Entitlement failed: Order not found";
        public const string IrsSelfRegistrationRequiredAction = "/irs?com.reqwired.site.action=IRSRegistration";
        public const string IrsForgotLogin = "ForgotLogin";
        public const string IrsConfirmationMessage = "ConfirmationMessage";
        #endregion



        #region SSO
        public const string ActionCplLogin = "CplLogin";
        public const string ActionCplRelogin = "CplRelogin";

        public const string RequestUserAccreditUtility = "accredit_utility";
        public const string RequestUserAddActivities = "add_activities";
        public const string RequestUserInstanceCredits = "instance_credits";
        public const string RequestUserInstanceDeposit = "instance_deposit";
        public const string RequestUserCeStatus = "ce_status";

        public const string SsowProductUnisionNumber = "SSOW";
        public const string SsowMessagePatternCaret = "^";
        public const string SsoSequenceParameter = "fp_sequence";
        public const string SsoTimeStampParameter = "fp_timestamp";
        public const string SsoMessageHashParameter = "fp_hash";
        public const string SsoOrgIdParameter = "org_id";
        public const string SsoUsernameParameter = "username";
        public const string SsoActionParameter = "action";
        public const string SsoOrganizationUserName = "OrganizationUserName";
        public const string SsoIsAdmin = "isAdmin";
        public const string SsoRefId = "ref_id";
        public const string SsoCePrflId = "profile";
        public const string SsoRedirectPath = "redirect_url";

        #endregion

        #region SysAdminMessages
        public const string UpdateSummaryFailedForCourseMetadataIdError = "Update Failed for course with CourseMetadataID = ";
        public const string UpdateSummaryFailedCriticalError = "Update Failed due to critical error";
        #endregion

        #region Live event import mapping XML
        public const string MappingXmlElementNameRoot = "Mappings";
        public const string MappingXmlElemetNameTable = "Table";
        public const string MappingXmlElementAttributeNameTable = "name";
        public const string MappingXmlElementNameTableMappedTo = "mappedTo";
        public const string MappingXMLElementNameRequiredExcelFields = "requiredExcelFields";
        public const string MappingXMLElementNameField = "field";
        public const string MappingXMLElementAttributeFieldName = "name";
        public const string MappingXMLElementNamemFieldMappedTo = "mappedTo";
        public const string MappingXMLElementNamemFieldDbType = "dbType";
        public const string MappingXMLElementNameFieldReference = "reference";
        public const string MappingXMLElementNameRferenceTable = "table";
        public const string MappingXMLElementNameRferenceColumn = "column";
        public const string MappingXMLElementNameRferenceIdColumn = "idColumn";
        public const string MappingXMLElementNameFieldDefaultValue = "defaultValue";
        #endregion


        #region Live event import Excel file columns and tabs

        public const string ImportExcelTabCourseMetadataInstance = "CourseMetadata_Instance";
        public const string ImportExcelFieldLiveEventID = "LiveEventID";
        public const string ImportExcelFieldAcronym = "Acronym";
        public const string ImportExcelFieldCourseMetadata = "CourseMetadata";
        public const string ImportExcelFieldLiveEventSCHID = "LiveEventSCHID";
        public const string ImportExcelFieldCourseStatus = "CourseStatus";
        public const string ImportExcelFieldMediaFormat = "MediaFormat";
        public const string ImportExcelTabCourseNasbaCredit = "CourseNasbaCredit";
        public const string ImportExcelTabSchedule = "Schedule";
        public const string ImportExcelTabScheduleLocation = "ScheduleLocation";

        #endregion

        #region DataBase Command Default Time Out
        public const int DBCommandTimeout = 60;
        #endregion

        #region TrtaApps Integration
        public const string ControllerApplication = "TrtaApps";

        public const string ActionManageSingleSignOn = "ManageSingleSignOn";
        public const string ActionManageExternalApplication = "ManageApplications";
        public const string ActionGetProfessionalApplications = "GetProfessionalApplications";


        public const string ActionOspLaunch = "Launch";
        public const string ActionInprogressCourse = "InprogressCourse";
        public const string ActionStatusReport = "StatusReport";

        public const string CourseFinderParam = "cf";
        public const string InProgressCourseParam = "ipc";
        public const string StatusReportParam = "sr";

        public const string ActionOspCourseFinder = "BasicSearch?IsInIframe=true";
        public const string ActionOspInprogressCourse = "/professional/Controller?com.reqwired.site.action=OneSourceGadget&widgetType=INPROGRESS";
        public const string ActionOspStatusReport = "/professional/Controller?com.reqwired.site.action=OneSourceGadget&widgetType=STATUSREPORT";
        public const string ActionOspOneSource = "OneSource";
        public const string ActionOspRedirect = "osRedirect";

        public const string ErrorMsgTextCourseFinder = "Course Finder";
        public const string ErrorMsgTextStatusReport = "Status Report Manager";


        public const string ActionManageCompetencies = "ManageCompetencies";
        public const string ActionRedirectToProfileOnline = "RedirectToProfileOnline";

        //ToDo: Following line need to delete when the actual requirement implemented
        public const string AttrSourceApplication = "Thomson.TRTA.Shared.Source.Application";
        public const string ProfilingIdpAdapterId = "ProfilingOnlineDev";

        //PingInfo attributes
        public const string PingInfoUserId = "UserId";
        public const string PingInfoUserFirstName = "FirstName";
        public const string PingInfoUserLastName = "LastName";
        public const string PingInfoEmailAddress = "EmailAddress";
        public const string PingInfoIsAdmin = "IsAddmin";
        public const string PingInfoFirmId = "FirmId";
        public const string PingInfoFirmName = "FirmName";


        //End - ToDo
        //public const string OspPrivacyPolicyP3P = "p3p";
        //public const string OspPrivacyPolicyValue = "CP=\"IDC DSP COR ADM DEVi TAIi PSA PSD IVAi IVDi CONi HIS OUR IND CNT\"";

        public const string ViewOspOneSource = "OneSource";
        public const string ViewOspCourseFinder = "../osp/CourseFinder";

        public const string OspPrivacyPolicyP3P = "p3p";
        public const string OspPrivacyPolicyValue = "CP=\"IDC DSP COR ADM DEVi TAIi PSA PSD IVAi IVDi CONi HIS OUR IND CNT\"";

        #endregion

        #region Live Event Order Entry

        public const string ProfessionalEmailAddressSuffix = "@dummyemailaddress.dmy";
        public const string ProfessionalDummyEmailDomain = "@ThomsonCPL.com";
        public const string LiveEventOrderEntryControler = "LiveEvent";
        public const string ActionLiveEventTicketInformation = "TicketInformation";
        public const string LiveEventWebinarModeratorForm = "Moderator Form.pdf";
        public const string LiveEventWebinarModeratorFormEmailSubject = "Moderators' Attendee List";
        public const string LiveEventOrderWebinarAttendeeEmailSubject = "Webinar Participation";
        public const string LiveEventOrderTypesDeliverLikeSeminar = "Seminar,Workshop,Webinar,Webcast,liveEvent,Unknown,Live Event";
        public const string LiveEventAddRegistrantsSuccessMessage = "Registrants Successfully added";
        public const string LiveEventWebinarModeratorFormAttachmentName = "Moderator Form.pdf";
        public const string LiveEventAddRegistrantsSendEmailFailedMessage = "Email send failed for one or more recipients";
        #endregion

        #region Product Reconciliation Report Constants
        public const string ShowGrid = "showGrid";
        #endregion

        #region Profiling Online
        public const string ActionCompetencyModel = "CompetencyModel";
        #endregion

        #region Course Metadata Schedule

        public const string AcccreditationRedirectLink = "{0}/adminSAFE?com.reqwired.site.action=TRTACourseInstanceEdit&courseinstance_id={1}&TabName={2}";
        public const string ManageCourseMetadataId = "ManageCourseMetadataID";

        #endregion

        #region Shopping cart actions for live events
        public const string AddLiveEventToCart = "AddLiveEventToCart";
        #endregion


        #region Live Event - Attendance Management
        //Holds the Reqwired Direct deopist Path
        public const string ReqwiredDirectDepositActionPath = "/adminSAFE?com.reqwired.site.action=TRTAProfessionalsActivityDeposit&courseinstance_id={0}";

        //Holds the Reqwired Certificate Path
        public const string ReqwiredCertificateActionPath = "/adminSAFE?com.reqwired.site.action=ProfessionalCertificateView&professional_id={0}&courseinstance_id={1}";

        //Holds the Reqwired Aggergate emails Path
        public const string ReqwiredAggregateEmailsActionPath = "/adminSAFE?com.reqwired.site.action=ConferenceNotificationEmail&courseinstance_id={0}";
        #endregion

        #region Barcode
        public const string BarcodeAttendanceCaptureReportXSLTPath = @"~\Resources\BarcodeAttendanceCaptureReport.xslt";

        #endregion

        #region CartProductTypes
        //public const string ProductTypeCourse = "Course";
        //public const string ProductTypeExam = "Exam";
        //public const string ProductTypeBundle = "Bundle";
        //public const string ProductTypeSubscriptionProduct = "Subscription Product";
        //public const string ProductTypeLiveEvent = "Live Event";
        #endregion

        // the common transaction time out period in seconds - 120 -  two mins
        public const double transactionTimeOutPeriod = 120;

        #region Passive Federation
        //public const string WifIssuerName = "IssuerName";
        //public const string WifSigningCertificateName = "SigningCertificateName";
        //public const string WifEncryptingCertificateName = "EncryptingCertificateName";

        public const string WifFa = "fa";
        public const string WifIp = "ip";
        public const string WifFp = "fp";

        public const string Trta = "trta";
        #endregion

        #region Course Finder New Design
        public const string BasicSearchDefaultFieldOfStuey = "All Courses";
        public const string BasicSearchDefaultBrand = "Brand Name";
        public const int ScheduleCountOnDefaultView = 2;
        public const string ErroMessageBuyLiveEventFA = "This product is not available for purchase via the Checkpoint Learning website. Please call 1-800-231-1860 for more information";
        public const string ErroMessageBuyLiveEventFP = "This product is not available for purchase via the Checkpoint Learning website. Please contact your firm administrator or call 1-800-231-1860 for more information";
        public const string ConfExpireScheduleMessage = "Online registration has closed for this conference; please call toll free 1-800-231-1860 to purchase.";
        public const string learningPlanDisplayModeAdminEmailRequest = "adminEmailRequest";

        #region Buy Now Description
        public const string BuyNowDescriptionForConference = "To register, choose your seminar choices for the primary conference, plus the optional seminars you would like to attend, then click the above \"Buy Now\" button. If you prefer to register by phone please call ";
        public const string BuyNowDescriptionForExpiredConference = "Online registration has closed for this conference; Please call toll free 1-800-231-1860 to purchase.";
        public const string BuyNowDescriptionForSeminar = "To make your selection, check the box next to the event of your choice and then click on the green \"Buy Now\" button. If you prefer to order or register by phone, please call ";
        public const string BuyNowDescriptionForNoneLiveEventCourses = "To make your selection, check the box next to the product of your choice and then click on the green \"Buy Now\" button. If you prefer to order or register by phone, please call ";
        #endregion

        #endregion
        # region Competency Model
        public const string ActionCompetencyModelDetails = "CompetencyModelDetails";
        public const string CompetencyModelDetails = "Competency";
        public const string strCompetencyModelProductCode = "CompetencyModelProductCode";


        # endregion
        #region Comprehensive bundels

        //Cookie set when user has comprehensive bundle
        public const string ComprehensiveBundlePurchasedCookie = "ComprehensiveBundlePurchased";


        #region My Cpe Implementation
        public const string ControllerMyCpe = "MyCpe";
        public const string ControllerBundle = "Bundle";

        public const string ActionMyCpeCourseDetails = "CourseDetails";
        public const string ActionComprehensiveBundleDetails = "ComprehensiveBundleDetails";
        public const string ActionMyComprehensiveBundleDetails = "MyComprehensiveBundleDetails";

        public const string CourseFinderLaunchButtonName = "launchButton";
        public const string CourseFinderDownloadButtonName = "downloadButton";
        public const string LaunchUrl = "{0}/professional/Controller?com.reqwired.site.action=OnDemandCourseInstanceView&id={1}& university_type=thomson&order_id={2}& college_id={3}&ONDEMAND=true&is_cpl_bundle=Y";
        public const string ConsumptionSummaryCancelWebinarSuccessMessage = "Selected items successfully Canceled";
        public const string MyCpeViewMode = "MyCpe";
        #endregion // My Cpe Implementation
        public const string CourseMetadataController = "CourseMetadata";
        #endregion


        #region Internal ManagePackages
        public const string PackagesMetadataList = "PackagesMetadataList";
        public const string CDShipped = "CDShipped";
        public const string General = "General";
        public const string CourseList = "CourseList";
        public const string CourseListNew = "CourseListNew";
        public const string Products = "Products";
        public const string PromotionManagement = "PromotionManagement";
        public const string PackageAlreadyInDatabase = "The product code that you have provided is already in use by another Comprehensive Subscription Package.  Please provide a unique product code for this Package.";

        #endregion

        #region iPad
        public const string ExportToPdfReportPath = @"MobilePdfReport\ExportToPdfReport.rdlc";
        public const string ExportToPdfDataSet = "ExportToPdfDS";
        public const string RegisteredSign = "<sup>&reg;</sup>";
        public const string AndiPad = " and iPad";
        #endregion


    }
}


