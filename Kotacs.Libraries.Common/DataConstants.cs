using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kotacs.Libraries.Common
{
    public static class DataConstants
    {
        public const string MarketingStatementChanges = "MarketingStatementChanges";

        #region

        public const string Nickname = "Nickname";
        #endregion

        #region Table Of Content XML

        public const string TableOfContent = "TableOfContent";
        public const string TableOfContentsTable = "TableOfContents";
        public const string TableOfContentsAlias = "TOC";

        #endregion

        #region Environment Settings
        public const string ParamEnvironmentID = "@appEnvironmentID";
        public const string SpSetEnvironmentSettings = "usp_setSapphireConfigSettings";
        public const string EnvironmentSettingsAppSettingsID = "appSettingsID";
        public const string EnvironmentSettingsValue = "value";
        public const string ParamAppSettings = "@appSettings";

        #endregion

        #region SP Get Environment Settings
        public const string SpGetEnvironmentSettings = "usp_getSapphireConfigSettings";
        public const string SpGetEnvironmentSettingsAppSettingID = "AppSettingID";
        public const string SpGetEnvironmentSettingsKey = "Key";
        public const string SpGetEnvironmentSettingsValue = "Value";
        public const string SpGetEnvironmentSettingsAreaName = "AreaName";
        public const string SpGetEnvironmentSettingsIsEnvironmentRelated = "IsEnvironmentRelated";
        public const string SpGetEnvironmentSettingsEnvironmentName = "EnvironmentName";
        public const string SpGetEnvironmentSettingsIsReadOnly = "IsReadOnly";
        #endregion

        #region Discount Management

        #region Promotions

        public const string PromoCodesView = "PromoCodes";
        public const string PromoCodesAlias = "PCL";

        public const string PromoBeginDate = "BeginDate";
        public const string PromoEndDate = "EndDate";
        public const string PromoIsAutomatic = "IsAutomatic";
        public const string PromoRedemptionCode = "RedemptionCode";
        public const string PromoAuditDate = "AuditDate";
        public const string PromoAuditUser = "AuditUser";
        public const string PromoIsExclusive = "IsExclusive";

        public const string PromoRuleSetsTable = "PromoRuleSets";
        public const string PromoRuleSetID = "PromoRuleSetID";
        public const string PromoCodeID = "PromoCodeID";
        public const string PromoDiscountTypeID = "PromoDiscountTypeID";
        public const string PromoDescription = "Description";
        public const string PromoSource = "Source";

        public const string PromoValue = "Value";
        public const string PromoRuleSetPriority = "Priority";

        public const string PromoDiscountTypesTable = "PromoDiscountTypes";
        public const string PromoCriteria = "PromoCriteria";
        public const string PromoDiscountSource = "Source";

        public const string PromoCriteriaTable = "PromoCriteria";
        public const string PromoCriteriaID = "PromoCriteriaID";

        public const string PromoDiscountApplicablesTable = "PromoDiscountApplicables";
        public const string PromoDiscountApplicableView = "vw_DiscountApplicablesCriteria";
        public const string PromoDiscountApplicableID = "PromoDiscountApplicableID";

        public const string PromoLevelTypeID = "PromoLevelTypeID";
        public const string PromoCriteriaTypeID = "PromoCriteriaTypeID";

        public const string PromoOperatorsTable = "PromoOperators";
        public const string PromoOperatorID = "PromoOperatorID";

        public const string PromoRulesTable = "PromoRules";
        public const string PromoRuleID = "PromoRuleID";
        public const string CriteriaValue = "CriteriaValue";
        public const string PromoCompareValue = "CompareValue";

        public const string PromoCriteriaView = "vw_PromoCriteriaList";
        public const string PromoCriteriaType = "PromoCriteriaType";
        public const string PromoCriteriaLevelType = "PromoCriteriaLevelType";

        public const string PromoCriteriaDescription = "PromoCriteriaDescription";
        public const string PromoDiscountTypeDescription = "PromoDiscountTypeDescription";
        public const string PromoDiscountValue = "DiscountValue";

        public const string PromoCodeStatsTable = "PromoCodeStats";
        public const string PromoCodesTable = "PromoCodes";



        #endregion

        #region Product Exclution

        public const string ProductListView = "vw_ProductList";
        public const string ProductListAlias = "PEL";

        public const string PromoExcludedProducts = "PromoExcludedProducts";
        public const string PromoExcludedProductsAlias = "PEP";

        public const string ProductCourseMetadataID = "CourseMetadataID";
        public const string ProductTitle = "title";
        public const string ProductUnisonID = "UnisonID";
        public const string ProductVersionNumber = "VersionNumber";
        public const string ProductPromoExcludedProductID = "PromoExcludedProductID";

        #endregion

        #endregion

        #region Dynamic Assembly

        public const string WorkGroupTable = "WorkGroup";
        public const string WorkGroupID = "ID";
        public const string WorkGroupName = "Name";

        public const string WorkGroupIDAlias = "WorkGroupID";
        public const string CourseCode = "Acronym";

        public const string CourseChapterMapping = "CourseChapterMapping";
        public const string CourseChapterDetails = "CourseChapterDetails";

        public const string MetadataID = "MetadataID";
        public const string CourseInstanceID = "CourseInstanceID";
        public const string ChapterReferenceID = "ChapterReferenceID";
        public const string ChapterTitle = "ChapterTitle";
        public const string ChapterIndex = "ChapterIndex";
        public const string ChapterStatus = "ChapterStatus";

        public const string IsDynamicAssembled = "IsDynamicAssembled";

        //Live Event - 1.03 - Implementation
        public const string MediaFormatType = "MediaFormatType";


        #endregion

        #region Course Metadata XML

        public const string CourseMetadataXMLView = "vw_CourseMetadataXML";
        public const string CourseMetadataXMLViewAlias = "CMDVW";
        public const string CourseMetadataXMLAlias = "CMD";

        public const string CourseMetadataContributorsAuthorListView = "vw_CourseMetadataContributorsAuthorList";
        public const string CourseMetadataContributorsAuthorListAlias = "CMAL";

        public const string CourseMetadataContributorsReviewerListView = "vw_CourseMetadataContributorsReviewerList";
        public const string CourseMetadataContributorsReviewerListAlias = "CMRL";

        public const string CourseMetadataContributorsAuthorDataView = "vw_CourseMetadataContributorsAuthorData";
        public const string CourseMetadataContributorsAuthorDataAlias = "CMAD";

        public const string CourseMetadataContributorsResourceListView = "vw_CourseMetadataContributorsResourceList";
        public const string CourseMetadataContributorsResourceListAlias = "CMRCL";

        public const string CourseMetadataContributorsReviewerDataView = "vw_CourseMetadataContributorsReviewerData";
        public const string CourseMetadataContributorsReviewerDataAlias = "CMRD";

        public const string CourseMetadataContributorsDataView = "vw_CourseMetadataContributorsData"; // data
        public const string CourseMetadataContributorsDataAlias = "CMCD";

        public const string CoursePermissionToRepublishView = "vw_PermissionToRepublish";
        public const string CoursePermissionToRepublishAlias = "PTP";

        public const string CourseMetadataSupplementView = "vw_CourseMetadataSupplements";
        public const string CourseMetadataSupplementAlias = "CMS";

        public const string CourseMetadataXMLNasbaCreditsView = "vw_CourseMetadataXML_NasbaCredits";

        public const string InteractiveLearning = "InteractiveLearning";
        public const string CourseInteractivityLearningTable = "CourseInteractiveLearning";
        public const string CourseInteractivityLearningAlias = "CI";
        public const string CourseInteractivityLearningName = "Name";

        public const string ActivityTable = "Activity";
        public const string ActivityTableAlias = "ACTV";
        public const string ActivityId = "id";
        public const string ActivityProfessional = "professional";
        public const string ActivityInstance = "instance";
        // Added for Firm Migration use
        public const string ActivityTitle = "title";
        public const string ActivityProvider = "provider";
        public const string ActivityFormat = "format";
        public const string ActivityCompletion = "completion";
        public const string ActivityDescription = "description";
        public const string ActivityCourse = "course";
        public const string ActivityPassed = "passed";
        public const string ActivityLog = "log";
        public const string ActivityUniversity = "university";
        public const string ActivityProgress = "progress";
        public const string ActivityStarted = "started";
        public const string ActivityMigrationDate = "migdate";
        public const string ActivitySource = "source";
        public const string ActivityOldid = "oldid";
        public const string ActivityError = "error";
        public const string ActivityKey = "key";

        //SP param names for ActivityCertificate add 
        public const string ActivityCeId = "id";
        public const string ActivityCeProfessional = "professional";
        public const string ActivityCeIssuedDate = "issued";
        public const string ActivityCeContent = "content";
        public const string ActivityCeValid = "valid";
        public const string ActivityCeInstance = "instance";
        public const string ActivityCeCompletedDate = "completed";
        public const string ActivityCeCertificateType = "type";
        public const string ActivityCeCompatibleCode = "compatibleCode";
        public const string ActivityCeForm = "form";
        public const string ActivityCeSignature = "signature";
        public const string ActivityCeKey = "key";
        //End  - SP param names for ActivityCertificate add 

        //SP param names for CertificateProfile add 
        public const string CertificateProfileId = "id";
        public const string CertificateProfileProfessional = "professional";
        public const string CertificateProfileRegulator = "regulator";
        public const string CertificateProfileStartDate = "date_start";
        public const string CertificateProfileEndDate = "date_end";
        public const string CertificateProfileExtDate = "date_ext";
        public const string CertificateProfileFillingDate = "date_filing";
        public const string CertificateProfileCurrent = "current";
        public const string CertificateProfileStates = "states";
        public const string CertificateProfileRequired = "required";
        public const string CertificateProfileCarryFrom = "carryfrom";
        public const string CertificateProfileCarryOver = "carryover";
        public const string CertificateProfileReport = "report";
        public const string CertificateProfileAlertDate = "date_alert";
        public const string CertificateProfileRefStartDate = "date_ref_start";
        public const string CertificateProfileRefEndDate = "date_ref_end";
        public const string CertificateProfileRefExtDate = "date_ref_ext";
        public const string CertificateProfileCreditsNeeded = "needed_credits";
        public const string CertificateProfileArchived = "archived";
        public const string CertificateProfileKey = "key";
        //End  - SP param names for CertificateProfile add 

        //SP param names for firm add 
        public const string FirmUserName = "username";
        public const string FirmName = "name";
        public const string FirmSecretKey = "secretKey";
        public const string FirmPassword = "password";
        public const string FirmUnitNo = "unit_num";
        public const string FirmAddress1 = "address1";
        public const string FirmAddress2 = "address2";
        public const string FirmCity = "city";
        public const string FirmState = "state";
        public const string FirmZipCode = "zipcode";
        public const string FirmCountry = "country";
        public const string FirmContact = "contact";
        public const string FirmCTCName = "ctc_name";
        public const string FirmCTCPhone = "ctc_phone";
        public const string FirmCTCFax = "ctc_fax";
        public const string FirmCTCEmail = "ctc_email";
        public const string FirmTrackingSeat = "tracking_seats";
        public const string FirmEMPSeat = "emp_seats";
        public const string FirmAdminSeat = "admin_seats";
        public const string FirmCoachSeat = "coach_seats";
        public const string FirmLogoURI = "logo_uri";
        public const string FirmHomePage = "homepage";
        public const string FirmStyleURI = "style_uri";
        public const string FirmSingleSignOn = "single_signon";
        public const string FirmUnivName = "univ_name";
        public const string FirmUnivDescription = "univ_description";
        public const string FirmUnivLogo = "univ_logo";
        public const string FirmUnivHomePage = "univ_homepage";
        public const string FirmCollegeSeat = "college_seats";
        public const string FirmLearningSeat = "learning_seats";
        public const string FirmLMSEnable = "lms_enable";
        public const string FirmPrivateRule = "private_rule";
        public const string FirmDescription = "description";
        public const string FirmTermination = "termination";
        public const string FirmAbbrName = "abbrname";
        public const string FirmKey = "key";
        //End  - SP param names for firm add 

        //SP param names for firm professional add 
        public const string FirmProfessionalUserName = "username";
        public const string FirmProfessionalPassword = "password";
        public const string FirmProfessionalFirstName = "firstname";
        public const string FirmProfessionalLastName = "lastname";
        public const string FirmProfessionalEmail = "email";
        public const string FirmProfessionalWritable = "writable";
        public const string FirmProfessionalReminder = "reminder";
        public const string FirmProfessionalPreference = "preference";
        public const string FirmProfessionalEnablethomsoncourses = "enablethomsoncourses";
        public const string FirmProfessionalOwner = "owner";
        public const string FirmProfessionalKey = "key";
        //End  - SP param names for firm professional add

        //SP param names for firm professional Address add 
        public const string FirmProfessionalAddressProfId = "ProfessionalID";
        public const string FirmProfessionalAddressTypeId = "ProfessionalAddressTypeID";
        public const string FirmProfessionalAddress1 = "Address1";
        public const string FirmProfessionalAddress2 = "Address2";
        public const string FirmProfessionalAddressCity = "City";
        public const string FirmProfessionalAddressCountryId = "CountryID";
        public const string FirmProfessionalAddressStateId = "StateID";
        public const string FirmProfessionalAddressZipCode = "ZipCode";
        public const string FirmProfessionalAddressTimeZoneId = "TimeZoneID";
        public const string FirmProfessionalAddressKey = "key";
        //End  - SP param names for firm professional address add

        //SP param names for ActivityCertificate association add 
        public const string ActivityCeAssActivity = "activity";
        public const string ActivityCeAssCertificateKey = "certificate";
        public const string ActivityCeAssociationKey = "key";

        //End  - SP param names for ActivityCertificate association add 

        // End - Added for Firm Migration use


        public const string MediaFormatTable = "MediaFormat";
        public const string MediaFormatTableAlias = "MDF";
        public const string MediaFormatName = "Name";
        public const string MediaFormatId = "MediaFormatId";

        public const string MediaFormatDescription = "MediaFormatDescription";

        public const string MediaDescription = "MediaDescription";

        #endregion

        #region NASBA PilotTestTables & Views

        #region PilotTesterTable & PilotTesterView

        public const string PilotTesterProfilesView = "vw_PilotTesterProfile";
        public const string PilotTesterProfilesAlias = "PTP";
        public const string PilotTesterProfilesId = "PilotTesterProfileID";
        public const string PilotTesterProfilesFirstName = "FirstName";
        public const string PilotTesterProfilesLastName = "LastName";
        public const string PilotTesterProfilesEmail = "Email";
        public const string PilotTesterProfilesPhone = "Phone";
        public const string PilotTesterProfilesContact = "Contact";
        public const string PilotTesterProfilesCPECreditHistory = "CPECreditHistory";
        public const string PilotTesterProfilesResume = "Resume";
        public const string PilotTesterProfilesFieldOfStudyId = "FieldOfStudyID";
        public const string PilotTesterProfilesStateId = "StateID";
        public const string PilotTesterProfilesPilotTesterStatusId = "PilotTesterStatusID";
        public const string PilotTesterProfilesIsResumeAvailable = "IsResumeAvailable";
        public const string PilotTesterProfilesPilotTesterWarningLevelId = "PilotTesterWarningLevelID";
        public const string PilotTesterProfilesPilotTestStateOfLicensureId = "PilotTestStateOfLicensureID";
        public const string PilotTesterProfilesPilotTesterUserTypeID = "PilotTesterUserTypeID";
        public const string PilotTesterProfilesIsPilotTester = "IsPilotTester";
        #endregion PilotTesterTable & PilotTesterView

        #region PilotTests
        public const string PilotTestsTable = "PilotTest";
        public const string PilotTestsAlias = "PTS";
        public const string PilotTestsId = "PilotTestID";
        public const string PilotTestsProductMetadataId = "ProductMetadataID";
        public const string PilotTestsDeadline = "Deadline";
        public const string PilotTestsCreditIssuedDate = "CreditIssuedDate";
        public const string PilotTestStatusID = "PilotTestStatusID";
        public const string PilotTestProductDeliveryFormatID = "ProductDeliveryFormatID ";
        public const string PilotTestIsCertificatePrinted = "IsCertificatePrinted";
        public const string PilotTestIsFeedbackFormFreezed = "IsFeedbackFormFreezed";
        public const string PilotTestQueryAlias = "PilotTestQueryAlias";
        public const string PilotTestCountQueryAlias = "PilotTestCountQueryAlias";
        public const string NoOfTesters = "NoOfTesters";
        public const string PilotTestClosedDate = "ClosedDate";
        public const string PilotTestNextPilotTestDueDate = "NextPilotTestDueDate";
        public const string PilotTestCourseLevelId = "PilotTestSkillLevelID";
        public const string PilotTestCourseLevel = "PilotTestSkillLevel";
        public const string PilotTesterQueryAlias = "PilotTesterQueryAlias";
        public const string PilotTestPilotTestDate = "PilotTestDate";
        public const string PilotTestEnableIssuingCertificates = "IsCertificatePrinted";
        public const string PilotTestCourseTitle = "PilotTestCourseTitle";

        #endregion PilotTests

        #region PilotTestStatusesTable
        public const string PilotTestStatusesTable = "PilotTestStatus";
        public const string PilotTestStatusesAlias = "PTSS";
        public const string PilotTestStatusesID = "PilotTestStatusID";
        public const string PilotTestStatusesName = "Name";
        #endregion

        #region PilotTestTester
        public const string PilotTestTesterTable = "PilotTestTester";
        public const string PilotTestTesterAlias = "PTTR";
        public const string PilotTestTesterId = "PilotTestTesterID";
        public const string PilotTestTesterPilotTestId = "PilotTestID";
        public const string PilotTestTesterPilotTesterProfileId = "PilotTesterProfileID";
        public const string PilotTestTesterPilotTestInvitationStatusId = "PilotTestInvitationStatusID";
        public const string PilotTestTesterPilotTestTesterStatusID = "PilotTesterTestStatusId";
        public const string PilotTestTesterInvitationDate = "InvitationDate";
        public const string PilotTestTesterResponseDate = "ResponseDate";
        public const string PilotTestTesterCompletedDate = "CompletedDate";
        public const string PilotTestTesterDeadline = "Deadline";
        public const string PilotTestTesterGradingStatusID = "GradingStatusID";
        public const string PilotTestTesterIsIncludedIncalculations = "IsIncludedIncalculations";
        public const string PilotTestTesterIsPass = "IsPass";
        #endregion

        #region PilotTestEmailType
        public const string PilotTestEmailTypeTable = "PilotTestEmailType";
        public const string PilotTestEmailTypeAlias = "PTE";

        public const string PilotTestEmailTypeId = "PilotTestEmailTypeID";
        public const string PilotTestEmailTypeName = "Name";
        public const string PilotTestEmailTypeStatusId = "StatusID";


        #endregion

        #region PilotTestEmailTemplate
        public const string PilotTestEmailTemplateTable = "PilotTestEmailTemplate";
        public const string PilotTestEmailTemplateAlias = "PTET";

        public const string PilotTestEmailTemplateId = "PilotTestEmailTemplateID";
        public const string PilotTestEmailTemplateName = "Name";
        public const string PilotTestEmailTemplateSubject = "Subject";
        public const string PilotTestEmailTemplateBody = "Body";
        public const string PilotTestEmailTemplateStatusId = "StatusID";
        #endregion

        #region PilotTestInvitationTable

        public const string PilotTestInvitationsStatusTable = "PilotTestInvitationStatus";
        public const string PilotTestInvitationsStatusAlias = "PTI";
        public const string PilotTestInvitationsStatusId = "PilotTestInvitationStatusID";
        public const string PilotTestInvitationsStatusName = "Name";
        public const string PilotTestInvitationsStatusStatusId = "StatusID";
        #endregion

        #region PilotTestUserType
        public const string PilotTesterUserTypeTable = "PilotTesterUserType";
        public const string PilotTesterUserTypeAlias = "PTUT";
        public const string PilotTesterUserTypeId = "PilotTesterUserTypeID";
        public const string PilotTesterUserTypeName = "Name";
        public const string PilotTesterUserTypeStatusId = "StatusID";
        #endregion

        #region PilotTesterTestStatusTable

        public const string PilotTesterTestStatusTable = "PilotTesterTestStatus";
        public const string PilotTesterTestStatusAlias = "PTTS";
        public const string PilotTesterTestStatusId = "PilotTesterTestStatusID";
        public const string PilotTesterTestStatusName = "Name";
        public const string PilotTesterTestStatusStatusId = "StatusID";
        #endregion

        #region PilotTesterWarningLevel Table
        public const string PilotTesterWarningLevelTable = "PilotTesterWarningLevel";
        public const string PilotTesterWarningLevelAlias = "PTWL";

        public const string PilotTesterWarningLevelId = "PilotTesterWarningLevelID";
        public const string PilotTesterWarningLevelName = "Name";
        public const string PilotTesterWarningLevelStatusId = "StatusID";
        #endregion

        #region PilotTestNotificationContent Table
        public const string PilotTestNotificationContentTable = "PilotTestNotificationContent";
        public const string PilotTestNotificationContentAlias = "PTNC";

        public const string PilotTestNotificationContentId = "PilotTestNotificationContentID";
        public const string PilotTestNotificationPilotTestId = "PilotTestID";
        public const string PilotTestNotificationTestEmailTypeId = "PilotTestEmailTypeID";
        public const string PilotTestNotificationTestEmailTemplateId = "PilotTestEmailTemplateID";
        public const string PilotTestNotificationSubject = "Subject";
        public const string PilotTestNotificationBody = "Body";
        public const string PilotTestNotificationAttachment = "Attachment";
        public const string PilotTestNotificationFileName = "FileName";

        #endregion

        #region PilotTestChapter Table
        public const string PilotTestChapterTable = "PilotTestChapter";
        public const string PilotTestChapterAlias = "PTC";
        public const string PilotTestChapterID = "PilotTestChapterID";
        public const string PilotTestChapterChapterTitle = "ChapterTitle";
        public const string PilotTestChapterPilotTestID = "PilotTestID";
        public const string PilotTestChapterSequence = "Sequence";
        #endregion

        #region PilotTestStateOfLicensure Table And Fields
        public const string PilotTestStateOfLicensureTable = "PilotTestStateOfLicensure";
        public const string PilotTestStateOfLicensureAlias = "PTSL";

        public const string PilotTestStateOfLicensureId = "PilotTestStateOfLicensureID";
        public const string PilotTestStateOfLicensureStateId = "StateID";
        public const string PilotTestStateOfLicensureTesterProfileID = "PilotTesterProfileID";
        public const string PilotTestStateOfLicensureTesterProfessionalID = "ProfessionalID";
        #endregion

        # region PilotTestFeedback
        public const string PilotTestFeedbackTable = "PilotTestFeedback";
        public const string PilotTestFeedbackAlias = "PTFB";
        public const string PilotTestFeedbackID = "PilotTestFeedbackID";
        public const string PilotTestFeedbackPilotTestTesterID = "PilotTestTesterID";
        public const string PilotTestFeedbackSkillLevelID = "PilotTestSkillLevelID";
        public const string PilotTestFeedbackComment = "Comment";
        public const string PilotTestFeedbackTotalDuration = "TotalDuration";
        public const string PilotTestFeedbackIsTotalDurationModified = "IsTotalDurationModified";

        #endregion

        # region PilotTestChapterFeedback
        public const string PilotTestChapterFeedbackTable = "PilotTestChapterFeedback";
        public const string PilotTestChapterFeedbackAlias = "PTCF";
        public const string PilotTestChapterFeedbackID = "PilotTestChapterFeedbackID";
        public const string PilotTestChapterFeedbackPilotTestChapterID = "PilotTestChapterID";

        public const string PilotTestChapterFeedbackStartTime = "StartTime";
        public const string PilotTestChapterFeedbackEndTime = "EndTime";
        public const string PilotTestChapterFeedbackPilotTestFeedbackID = "PilotTestFeedbackID";
        public const string PilotTestChapterFeedbackDuration = "Duration";
        public const string PilotTestChapterFeedbackIsDurationEdited = "IsDurationEdited";
        #endregion

        #region PilotTesterStatus
        public const string PilotTesterStatusTable = "PilotTesterStatus";
        public const string PilotTesterStatusAlias = "PTST";

        public const string PilotTesterStatusId = "PilotTesterStatusID";
        public const string PilotTesterStatusName = "Name";
        #endregion

        #region PilotTestQuestion
        public const string PilotTestQuestionTable = "PilotTestQuestion";
        public const string PilotTestQuestionAlis = "PTQ";

        public const string PilotTestQuestionId = "PilotTestQuestionId";
        public const string PilotTestQuestionQuestion = "Question";
        public const string PilotTestQuestionStatusId = "StatusID";
        #endregion

        #region PilotTestQuestionResponse
        public const string PilotTestQuestionResponseTable = "PilotTestQuestionResponse";
        public const string PilotTestQuestionResponseAlias = "PTQR";
        public const string PilotTestQuestionResponseId = "PilotTestQuestionResponseId";
        public const string PilotTestQuestionResponseName = "Name";
        public const string PilotTestQuestionResponseStatusId = "StatusID";
        #endregion

        #region PilotTestQuestionFeedback
        public const string PilotTestQuestionFeedbackTable = "PilotTestQuestionFeedback";
        public const string PilotTestQuestionFeedbackAlias = "PTQF";
        public const string PilotTestQuestionFeedbackId = "PilotTestQuestionFeedbackID";
        public const string PilotTestQuestionFeedbackFeedbackId = "PilotTestFeedbackID";
        public const string PilotTestQuestionFeedbackQuestionId = "PilotTestQuestionID";
        public const string PilotTestQuestionFeedbackResponseId = "PilotTestQuestionResponseID";
        #endregion

        #region PilotTestSkillLevel
        public const string PilotTestSkillLevelTable = "PilotTestSkillLevel";
        public const string PilotTestSkillLevelAlias = "PTSL";
        public const string PilotTestSkillLevelId = "PilotTestSkillLevelID";
        public const string PilotTestSkillLevelName = "Name";
        public const string PilotTestSkillLevelStatusId = "StatusID";
        #endregion

        #region CourseNasbaCredits

        public const string CourseNasbaCreditsTable = "CourseNasbaCredits";
        public const string CourseNasbaCreditsAlias = "CNC";
        public const string CourseNasbaCreditsId = "CourseNasbaID";
        public const string CourseNasbaCreditsNasbaFOSID = "NasbaFOSID";
        public const string CourseNasbaCreditsProductMetadataID = "CourseMetadataID";
        public const string CourseNasbaCreditsNasbaCredits = "NasbaCredits";
        public const string CourseNasbaCreditsAbbreviation = "Abbreviation";

        #endregion


        #region Course Status
        public const string CourseStatusTable = "CourseStatus";
        public const string CourseStatusAlias = "CS";
        public const string CourseStatusCourseStatusID = "CourseStatusID";
        public const string CourseStatusName = "Name";
        public const string ComingSoonDate = "ComingSoonDate";
        public const string DisplayIconDate = "DisplayIconDate";
        public const string CourseReplacement = "CourseReplacement";
        public const string CourseReplacementID = "CourseReplacementID";
        public const string code = "code";
        public const string CourseReplacementMetadataID = "CourseMetadataID";
        public const string CourseReplacementtitle = "title";


        #endregion

        #endregion

        #region Author Table & View Fields

        public const string AuthorTable = "Authors";
        public const string AuthorView = "vw_Author";
        public const string AuthorAlias = "AUT";

        public const string AuthorId = "AuthorID";
        public const string AuthorFirstName = "FirstName";
        public const string AuthorLastName = "LastName";
        public const string AuthorBio = "Bio";
        public const string AuthorPhoto = "Photo";
        public const string AuthorIsExpert = "isExpert";

        #endregion Author Table & View Fields

        #region Course-Author Table & View Fields
        public const string CourseAuthorView = "vw_CourseAuthor";
        public const string CourseAuthorAlias = "CAU";

        public const string CourseAuthorAuthorId = "AuthorID";
        public const string CourseAuthorProductMetadataId = "ProductMetadataID";
        #endregion

        #region ProductMetadata Table & View Fields
        public const string ProductMetadataTable = "CourseMetadata";
        public const string ProductMetadataView = "vw_ProductMetadata";
        public const string ProductMetadataViewAlias = "PRDVW";
        public const string ProductMetadataAlias = "PRD";

        public const string ProductMetadataId = "ProductMetaDataID";
        public const string CourseMetadataId = "CourseMetaDataID";
        public const string ProductMetadataBrandId = "BrandID";
        public const string ProductMetadataTitle = "Title";
        public const string ProductMetadataDescription = "Description";
        public const string ProductMetadataMarketingDescription = "MarketingDescription";
        public const string ExamCatalogUnisonID = "ExamCatalogUnisonID";

        public const string ProductMetadataLongDescription = "LongDescription";
        public const string ProductMetadataShortDescription = "ShortDescription";

        public const string ProductMetadataFieldOfStudyID = "FieldOfStudyID";
        public const string ProductMetadataCourseId = "CourseId";
        public const string ProductMetadataBrandName = "BrandName";
        public const string ProductMetadataPrivateCourse = "PrivateCourse";
        public const string ProductMetaDataFieldOfStudyName = "FieldOfStudyNames";
        public const string ProductMetaDataSeminarWebinarDescription = "SeminarWebinarDescription";
        public const string ProductMetaDataIsNewCourse = "IsNew";
        public const string ProductMetaDataIsUpdateCourse = "IsUpdate";
        public const string ProductMetaDataIsComingSoon = "IsComingSoon";
        //public const string ProductMetaDataCourseGradingFee = "CourseGradingFee";
        public const string ProductMetaDataLearningObjectives = "LearningObjectives";
        public const string ProductMetaDataOutline = "Outline";
        public const string ProductMetaDataAdvancedRequirements = "AdvancedRequirements";
        public const string ProductMetaDataSystemRequirements = "SystemRequirements";
        //public const string ProductMetaDataPublicationDate = "PublicationDate";
        public const string ProductMetaDataCategoryID = "CategoryID";
        public const string ProductMetaDataLearningLevelID = "LearningLevelID";
        public const string ProductMetaDataOtherCertificationID = "ClassificationID";
        public const string ProductMetaDataLearningLibraryID = "LearningLibraryID";
        public const string ProductMetadataCourseID = "CourseID";
        public const string ProductMetadataPrerequsites = "Prerequsites";
        public const string ProductMetadataAcronym = "Acronym";
        public const string ProductMetadataCourseStatusId = "CourseStatusID";
        public const string ProductMetadataPublicationRevisionDate = "PublicationRevisionDate";
        public const string ProductMetadataVersionNumber = "VersionNumber";
        public const string ProductMetadataPassingGrade = "PassingGrade";
        public const string ProductMetadataAllowedAttempts = "AllowedAttempts";
        public const string ProductMetadataCfpCredits = "CfpCredits";

        public const string ProductMetadataCtecFederalcCredits = "CtecFederalcCredits";//1
        public const string ProductMetadataCtecCaCredits = "CtecCaCredits";//4

        public const string ProductMetadataCtecFederalTaxLawUpdateCredits = "CtecFederalTaxLawUpdateCredits";//2
        public const string ProductMetadataCtecEthicsCredits = "CtecEthicsCredits";//3
        public const string ProductMetadataCtecFederalNumber = "CtecFederalNumber";
        public const string ProductMetadataCtecCaNumber = "CtecCaNumber";
        public const string ProductMetadataCtecFederalTaxLawUpdateNumber = "CtecFederalTaxLawUpdateNumber";
        public const string ProductMetadataCtecEthicsNumber = "CtecEthicsNumber";
        public const string ProductMetadataIrsCourse = "IrsCourse";
        public const string ProductMetadataIrsRtrpCourse = "IrsRtrpCourse";
        public const string ProductMetadataIrsEaCourse = "IrsEaCourse";
        public const string ProductMetadataIrsRtrpEthicsCredits = "IrsRtrpEthicsCredits";//7
        public const string ProductMetadataIrsRtrpFederalTaxUpdateCredits = "IrsRtrpFederalTaxUpdateCredits";//9
        public const string ProductMetadataIrsRtrpFederalTaxCredits = "IrsRtrpFederalTaxCredits";//8
        public const string ProductMetadataIrsRtrpTestPreparationCredits = "IrsRtrpTestPreparationCredits";//10
        public const string ProductMetadataIrsEaEthicsCredits = "IrsEaEthicsCredits";//5
        public const string ProductMetadataIrsEaFederalTaxMattersCredits = "IrsEaFederalTaxMattersCredits";//6
        public const string ProductMetadataIrsRtrpEthicsNum = "IrsRtrpEthicsNum";
        public const string ProductMetadataIrsRtrpFederalTaxUpdateNum = "IrsRtrpFederalTaxUpdateNum";
        public const string ProductMetadataIrsRtrpFederalTaxNum = "IrsRtrpFederalTaxNum";
        public const string ProductMetadataIrsRtrpTestPreparationNum = "IrsRtrpTestPreparationNum";
        public const string ProductMetadataIrsEaEthicsNum = "IrsEaEthicsNum";
        public const string ProductMetadataIrsEaFederalTaxMattersNum = "IrsEaFederalTaxMattersNum";




        public const string ProductMetadataInteractiveLevelID = "InteractiveLevelID";
        public const string ProductMetadataLogoPath = "LogoPath";
        public const string ProductMetadataAdvancedPreparation = "AdvancedPreparation";
        public const string ProductMetadataSupplements = "Supplements";
        public const string ProductMetadataCopyrightNotes = "CopyrightNotes";
        public const string ProductMetadataMainGlossaryPool = "MainGlossaryPool";
        public const string ProductMetadataSubGlossaryPool = "SubGlossaryPool";
        public const string ProductMetadataKeywords = "Keywords";
        public const string ProductMetadataTechnicalRequirements = "TechnicalRequirements";
        public const string ProductMetadataTechnicalSpecification = "TechnicalSpecification";
        public const string ProductMetadataRecentChanges = "RecentChanges";
        public const string ProductMetadataHistroryNotes = "HistroryNotes";
        public const string ProductMetadataChangesForNextPublication = "ChangesForNextPublication";
        public const string ProductMetadataInteractiveLearningID = "InteractiveLearningID";
        public const string ProductMetadataNasbaQas = "NasbaQas";
        public const string ProductMetadataNasbaRegistry = "NasbaRegistry";
        // public const string ProductMetadataNasbaRevisionDate = "NasbaRevisionDate";
        public const string ProductMetadataYellowBookQualify = "YellowBookQualify";
        public const string ProductMetadataCourseSponsorID = "CourseSponsorID";
        public const string ProductMetadataAuthorContentRevisionDate = "AuthorContentRevisionDate";
        public const string ProductMetadataLastAuthorRevisionDate = "LastAuthorRevisionDate";
        public const string ProductMetadataLearningObjectives = "LearningObjectives";
        public const string ProductMetadataCourseMetadataID = "CourseMetadataID";
        public const string ProductMetadataFinalNasbaExpDate = "FinalNasbaExpDate";
        public const string OldVersionNumber = "OldVersionNumber";

        public const string ProductMetaDataDateCreated = "DateCreated";
        public const string ProductMetaDataLastModifiedDate = "LastModifiedDate";
        //public const string ProductMetaDataCourseFinderExpDate = "CourseFinderExpDate";
        public const string ProductMetaDataInactiveDate = "InactiveDate";
        public const string ProductMetaDataClassificationId = "ClassificationID";
        public const string ProductMetaDataVersionAvailableDate = "VersionAvailableDate";

        public const string AVORef = "AVORef";
        public const string AVOImageRef = "AVOImageRef";
        public const string AVOAudioRef = "AVOAudioRef";
        public const string AVOPlayerRef = "AVOPlayerRef";
        public const string AVOLearningObjectives = "AVOLearningObjectives";
        public const string NumberOfDays = "NoOfDays";
        public const string RedirectToLegacySite = "IsRedirectToLegacySite";
        public const string CourseTypeId = "CourseTypeId";


        public const string AllowedAttempts = "AllowedAttempts";

        public const string LinkToMediaClips = "MediaDescription";
        public const string RelatedProducts = "RelatedProducts";
        public const string AlternateFormat = "AlternateFormats";


        public const string ConferenceTotalCredits = "ConferenceTotalCredits";



        // KEB - Change set no 1001109. 
        public const string IsMasterCourse = "IsMasterCourse";
        #endregion

        #region Product Metadata For Course Finder view fields

        public const string ProductMetadataForCourseFinderView = "vw_ProductMetadataForCourseFinder";
        public const string ProductMetadataForCourseFinderViewAlias = "PMCFV";

        public const string ProductMetadataForCourseFinderFieldsOfStudies = "FieldsOfStudies";
        public const string ProductMetadataForCourseFinderCourseFieldOfStudyAlias = "VCFS2";

        public const string FieldOfStudyForSortingAlias = "FOSS";
        public const string BrandForSortingAlias = "BRDS";

        public const string IsRedirectToLegacySite = "IsRedirectToLegacySite";

        public const string CourseFinderView = "vw_CourseFinder";

        public const string CourseFinderAlias = "CF";

        public const string OgsUnisonId = "OgsUnisonID";

        public const string UnisonId = "UnisonID";

        #endregion

        #region Product Metadata For Resource Repository view fields

        public const string ProductMetadataForResourceRepositoryView = "vw_ProductMetadataForResourceRepository";
        public const string ProductMetadataForResourceRepositoryViewAlias = "PMFRR";

        #endregion

        #region CourseDetails View Fields
        public const string CourseDetailsView = "vw_CourseDetails";
        public const string CourseDetailsAlias = "VCD";

        public const string MarketingDescription = "MarketingDescription";
        #endregion

        #region Brand Table & View Fields
        public const string BrandTable = "Brands";
        public const string BrandView = "vw_Brands";
        public const string BrandAlias = "BRD";

        public const string BrandID = "BrandID";
        public const string BrandName = "Name";
        public const string BrandWebSite = "BrandWebSite";
        public const string BrandSite = "BrandSite";
        public const string BrandDescription = "Description";
        public const string BrandEmail = "Email";
        public const string BrandSequence = "Sequence";
        public const string BannerImageFileName = "BannerImageFileName";
        public const string MarketingImageFileName = "MarketingImageFileName";
        #endregion

        #region	PilotTestBrandEmail
        public const string PilotTestBrandEmailTable = "PilotTestBrandEmail";
        public const string PilotTestBrandEmailAlias = "PTBE";
        public const string PilotTestBrandEmailBrandId = "BrandID";
        public const string PilotTestBrandEmailID = "PilotTestBrandEmailID";
        public const string PilotTestBrandEmailBrandEmail = "Email";
        #endregion

        #region FieldOfStudy Table & View Fields
        public const string FieldOfStudyTable = "FieldOfStudy";
        public const string FieldOfStudyView = "vw_FieldOfStudy";
        public const string FieldOfStudyAlias = "FOS";

        public const string FieldOfStudyID = "FieldOfStudyID";
        public const string FieldOfStudyName = "Name";
        public const string FieldOfStudyNASBAFieldOfStudyID = "NASBAFieldOfStudyID";

        public const string FieldOfStudyNameAlias = "FieldOfStudyName";
        #endregion

        #region ProdutDeliveryFormat table & View Fields

        public const string ProductDeliveryFormatTable = "ProductDeliveryFormat";
        public const string ProductDeliveryFormatView = "vw_ProductDeliveryFormat";
        public const string ProductDeliveryFormatAlias = "PDF";

        public const string ProductDeliveryFormatId = "ProductDeliveryFormatID";
        public const string ProductDeliveryFormatDeliveryFormatId = "DeliveryFormatID";
        public const string ProductDeliveryFormatProductMetaDataId = "ProductMetaDataID";
        public const string ProductDeliveryFormatCoursePrice = "Price";
        public const string ProductDeliveryFormatFilePath = "FileDownloadPath";
        public const string ProductDeliveryFormatNumberOfCPECredits = "CPECredits";

        public const string ProductDeliveryFormatCourseId = "CourseID";
        public const string ProductDeliveryFormatCPECredits = "CPECredit";
        public const string ProductDeliveryFormatPrice = "Price";
        public const string ProductDeliveryFormatUnisonID = "UnisonID";
        public const string ProdutDeliveryFormatMediaFormatId = "MediaFormatID";

        #endregion

        #region CourseFieldOfStudy Table & View Fields

        public const string CourseFieldOfStudyView = "vw_CourseFieldOfStudy";
        public const string CourseFieldOfStudyAlias = "PFS";

        public const string CourseFieldOfStudyCourseMetaDataId = "CourseMetadataID";

        public const string CourseFieldOfStudyID = "FiledOfStudyID";
        public const string CourseFieldOfStudyName = "FieldOfStudy";
        public const string CourseFieldOfStudyNASBAFieldOfStudyId = "NASBAFieldOfStudyID";
        public const string CourseFieldOfStudyNASBAFieldOfStudyName = "NASBAFiledOfStudy";
        public const string CourseFieldOfStudyNASBACredits = "NasbaCredits";

        #endregion

        #region CourseNasbaFieldOfStudyList View Fields

        public const string CourseNasbaFieldOfStudyListView = "vw_CourseNasbaFieldOfStudyList";
        public const string CourseNasbaFieldOfStudyListViewAlias = "CFL";

        public const string CourseNasbaFieldOfStudyCourseMetaDataId = "CourseMetadataID";
        public const string CourseNasbaFieldOfStudyNasbaFieldsOfStudies = "NasbaFieldsOfStudies";

        #endregion

        #region CourseNasbaDeliveryFormatList View Fields

        public const string CourseNasbaDeliveryFormatListView = "vw_CourseNasbaDeliveryFormatList";
        public const string CourseNasbaDeliveryFormatListViewAlias = "CNL";

        public const string CourseNasbaDeliveryFormatCourseMetaDataId = "CourseMetadataID";
        public const string CourseNasbaDeliveryFormatNasbaDeliveryFormats = "NasbaDeliveryFormats";

        #endregion

        #region InhouseRequest Table & View Fields


        public const string InhouseRequestTable = "InHouseRequest";
        public const string InhouseRequestView = "vw_InHouseRequest";
        public const string InhouseRequestAlias = "INR";
        public const string InhouseRequestId = "Id";
        public const string InhouseRequestCourseId = "CourseId";
        public const string InhouseRequestProductMetaDataID = "ProductMetaDataID";
        public const string InhouseRequestFirstName = "FirstName";
        public const string InhouseRequestLastName = "LastName";
        public const string InhouseRequestTitle = "Title";
        public const string InhouseRequestStreetAddress1 = "StreetAddress1";
        public const string InhouseRequestStreetAddress2 = "StreetAddress2";
        public const string InhouseRequestZipCode = "ZipCode";
        public const string InhouseRequestCity = "City";
        public const string InhouseRequestState = "State";
        public const string InhouseRequestCompanyName = "CompanyName";
        public const string InhouseRequestBusinessPhone = "BussinessPhone";
        public const string InhouseRequestFax = "Fax";
        public const string InhouseRequestCountry = "Country";
        public const string InhouseRequestRegion = "Region";
        public const string InhouseRequestEmailAddress = "EmailAddress";
        public const string InhouseRequestNeedInstructor = "NeedInstructor";
        public const string InhouseRequestNumberOfSeats = "NumberOfSeats";
        public const string InhouseRequestStartDate = "StartDate";
        public const string InhouseRequestEndDate = "EndDate";
        public const string InhouseRequestStateId = "StateID";
        public const string InhouseRequestRequestedInformation = "RequestedInfo";





        # endregion

        #region Schedule Table & View Fields
        public const string ScheduleTable = "Schedule";
        public const string ScheduleView = "vw_Schedule";
        public const string ScheduleAlias = "SCH";
        public const string ScheduleViewTimeZoneName = "TimeZoneName";

        public const string ScheduleDate = "StartDate";
        public const string ScheduleStartTime = "StartTime";
        public const string ScheduleEndTime = "EndTime";
        public const string ScheduleStatus = "Status";
        public const string ScheduleLocationId = "LocationID";
        public const string ScheduleId = "ScheduleID";
        public const string ScheduleProductMetaDataId = "ProductMetadataID";
        public const string ScheduleCourseMetaDataId = "CourseMetadataID";
        public const string ScheduleMaxAttendees = "MaxAttendees";
        public const string ScheduleRoom = "Room";
        public const string ScheduleTimeZoneId = "TimeZoneId";
        public const string ScheduleUrl = "Url";
        public const string ScheduleImportedLiveEventSchId = "ImportedLiveEventSCHID";

        public const string ScheduleStartDate = "StartDate";
        public const string ScheduleEndDate = "EndDate";
        #endregion

        #region Location Table & View Fields
        public const string LocationTable = "Location";
        public const string LocationView = "vw_Location";
        public const string LocationAlias = "LOC";
        public const string ScheduleLocationTableAlias = "SLT";

        public const string ScheduleLocationTable = "ScheduleLocation";
        public const string LocationTitle = "Title";
        public const string LocationId = "LocationID";
        public const string LocationScheduleId = "ScheduleID";
        public const string LocationStateId = "StateID";
        public const string LocationName = "Name";
        public const string LocationAddress1 = "Address1";
        public const string LocationAddress2 = "Address2";
        public const string LocationZip = "Zip";
        public const string LocationHotelName = "HotelName";
        public const string LocationCity = "City";
        public const string LocationScheduleLocationID = "ScheduleLocationID";
        #endregion

        #region Society table
        public const string SocietyTable = "Society";
        public const string SocietyName = "Name";
        public const string SocietyId = "SocietyID";
        #endregion

        #region State Table & View Fields

        public const string StateTable = "State";
        public const string StateView = "vw_State";
        public const string StateAlias = "STE";

        public const string StateAbbreviation = "Abbreviation";
        public const string StateId = "StateID";
        public const string StateName = "Name";

        #endregion

        #region DeliveryFormat Table & View Fields
        public const string DeliveryFormatTable = "DeliveryFormat";
        public const string DeliveryFormatView = "vw_DeliveryFormat";
        public const string DeliveryFormatAlias = "DLF";

        public const string DeliveryFormatID = "DeliveryFormatID";
        public const string DeliveryFormatId = "DeliveryFormatID";
        public const string DeliveryFormatName = "Name";
        public const string DeliveryFormatNASBADeliveryId = "NASBADeliveryId";
        #endregion

        #region DeliveryFormatGroup Table & View Fields
        public const string DeliveryFormatGroupTable = "DeliveryFormatGroup";
        public const string DeliveryFormatGroupView = "vw_DeliveryFormatGroup";
        public const string DeliveryFormatGroupAlias = "DLFG";
        public const string DeliveryFormatGroupId = "DeliveryFormatGroupID";
        public const string DeliveryFormatGroupName = "Name";
        #endregion

        #region ProdutDelivery table & View Fields
        public const string ProductDeliveryTable = "ProductDeliveryFormat";
        public const string ProductDeliveryView = "vw_ProductDeliveryFormat";
        public const string ProductDeliveryAlias = "PDL";

        public const string ProductDeliveryId = "ProductDeliveryFormatID";
        public const string ProductDeliveryDeliveryFormatId = "DeliveryFormatID";
        public const string ProductDeliveryProductMetaDataId = "ProductMetaDataID";
        public const string ProductDeliveryPrice = "Price";
        public const string ProductDeliveryCPECredits = "CPECredits";
        #endregion

        #region Credit Range
        public const string CPECreditRangeTable = "CPECreditRange";
        public const string CPECreditRangeAlias = "CCR";

        public const string CPECreditRangeId = "CPECreditRangeID";
        public const string CPECreditRangeLow = "LowCPECredits";
        public const string CPECreditRangeHigh = "HighCPECredits";
        #endregion

        #region Credit Price
        public const string PriceRangeTable = "PriceRange";
        public const string PriceRangeAlias = "PRR";

        public const string PriceRangeId = "PriceRangeID";
        public const string PriceRangeLow = "LowPriceRange";
        public const string PriceRangeHigh = "HighPriceRange";
        #endregion

        #region Learning Level table & View Fields
        public const string LearningLevelTable = "LearningLevel";
        public const string LearningLevelView = "vw_LearningLevel";
        public const string LearningLevelAlias = "LLE";

        public const string LearningLevelID = "LearningLevelID";
        public const string LearningLevelTitle = "Name";
        #endregion

        #region Learning Library table & View Fields
        public const string LearningLibraryTable = "LearningLibrary";
        public const string LearningLibraryView = "vw_LearningLibrary";
        public const string LearningLibraryAlias = "LLI";

        public const string LearningLibraryID = "LearningLibraryID";
        public const string LearningLibraryTitle = "Title";
        public const string LearningLibraryTitleAlias = "LibraryName";
        #endregion

        #region Product Learning Library table & View Fields
        public const string ProductLearningLibraryTable = "ProductLearningLibrary ";
        public const string ProductLearningLibraryView = "vw_ProductLearningLibrary";
        public const string ProductLearningLibraryAlias = "PLL";

        public const string ProductLearningLibraryID = "LearningLibraryID";
        public const string ProductLearningLibraryProductMetaDataID = "ProductMetaDataID";
        public const string LearningLevelTitleAlias = "LearningLevelName";
        #endregion

        #region Product Nasba Credits table & View Fields
        public const string ProductNasbaCreditsTable = "ProductNasbaCredits";
        public const string ProductNasbaCreditsView = "vw_ProductNasbaCredits";
        public const string ProductNasbaCreditsAlias = "PNC";

        public const string ProductNasbaFieldofStudyID = "NasbaFieldofStudyID";
        public const string ProductNasbaCreditsProductNasbaCredit = "NasbaCredits";
        public const string ProductNasbaCreditsProductMetadataId = "ProductMetadataID";

        #endregion

        #region Nasba Field Of Study Product table & View Fields
        public const string NasbaFieldOfStudyTable = "NasbaFieldOfStudy";
        public const string NasbaFieldOfStudyView = "vw_NasbaFieldOfStudy";
        public const string NasbaFieldOfStudyAlias = "NFOS";

        public const string NasbaFieldOfStudyID = "NasbaFOSID";
        public const string NasbaFieldOfStudyName = "Name";
        public const string NasbaFieldOfStudySourceFOSID = "SourceFOSID";
        public const string NasbaFieldOfStudyViewId = "NasbaFieldOfStudyID";
        #endregion

        #region Nasba Delivery Format table & View Fields
        public const string NasbaDeliveryFormatTable = "NasbaDeliveryFormat";
        public const string NasbaDeliveryFormatView = "vw_DeliveryFormat";
        public const string NasbaDeliveryFormatAlias = "NDF";

        public const string NasbaDeliveryFormatID = "NasbaDeliveryID";
        public const string NasbaDeliveryFormatName = "Name";
        #endregion

        #region Nasba Delivery table & View Fields
        public const string NasbaDeliveryTable = "NasbaDelivery";
        public const string NasbaDeliveryView = "vw_NasbaDelivery";
        public const string NasbaDeliveryAlias = "ND";

        public const string NasbaDeliveryID = "NasbaDeliveryID";
        public const string NasbaDeliveryName = "Name";
        #endregion

        #region Auto Notify Courses Relevent fields in Course Metadata
        public const string CourseMetadataNotifyCustomers = "NotifyCustomers";
        #endregion
        #region versioning
        public const string VersionCategoryID = "VersionCategoryID";
        public const string RevisionCategoryID = "RevisionCategoryID";

        #endregion

        #region Course Sponsor Nasba Delivery table & View Fields
        public const string CourseSponsorNasbaDeliveryView = "vw_CourseSponsorNasbaDelivery";
        public const string CourseSponsorNasbaDeliveryAlias = "CSND";
        #endregion

        #region SEM Visitor table & View Fields
        public const string SemVisitorTable = "SearchMarketingVisitor";
        public const string SearchMarketingVisitorList = "SearchMarketingVisitorList";

        //Table Field names
        public const string SemVisitorCookieID = "CookieID";
        public const string SemVisitorLandingPage = "LandingPage";
        public const string SemVisitorVisitDate = "VisitDate";
        public const string SemVisitorSiteName = "SiteName";
        public const string SemVisitorIsPurchased = "IsPurchased";
        public const string SemVisitorPurchasedDate = "PurchasedDate";
        public const string SemVisitorValue = "Value";
        public const string SemVisitorUserID = "UserID";
        public const string SemVisitorProductMetaData = "ProductMetaData";
        public const string SemVisitorDeliveryFormatID = "DeliveryFormatID";
        public const string SemVisitorView = "vw_SearchMarketingVisitor";
        public const string SemVisitorAlias = "SEMV";
        public const string SemVisitorIsEthics = "IsEthics";
        public const string SemVisitorVisitDateAlias = "YearMonth";
        public const string SemVisitorIsHit = "IsHit";

        public const string SemVisitorProductMetadataId = "ProductMetadataID";
        public const string SemVisitorDeliveryFormatId = "DeliveryFormatID";
        public const string SemVisitorUserId = "UserID";
        public const string SemTransactionNo = "TransactionNo";
        public const string SemVisitorSearchMarketingVisitorID = "SearchMarketingVisitorID";
        public const string SemVisitorUnisonId = "UnisonID";

        public const string SemReportYearAlias = "Year";
        public const string SemReportMonthAlias = "Month";
        public const string SemReportSalesAlias = "Sales";
        public const string SemReportOrdersAlias = "Orders";


        #endregion

        #region Resource Repository Tables and Fields

        #region Address Type Table & Fields
        public const string AddressTypeTable = "AddressType";
        public const string AddressTypeAlias = "ADT";

        public const string AddressTypeID = "AddressTypeID";
        public const string AddressTypeName = "Name";
        public const string AddressTypeStatusId = "StatusID";
        #endregion

        #region Resource VendorStatus Table & Fields
        public const string ResourceStatusTable = "ResourceStatus";
        public const string ResourceStatusAlias = "RSS";

        public const string ResourceStatusID = "StatusID";
        public const string ResourceStatusName = "Name";

        #endregion

        #region Record VendorStatus table & Fields
        public const string RecordStatusTable = "RecordStatus";
        public const string RecordStatusAlias = "RCS";

        public const string RecordStatusID = "RecordStatusID";
        public const string RecordStatusName = "Name";
        public const string RecordStatusStatusId = "StatusID";

        #endregion

        #region VendorPhone Type Table & Fields
        public const string PhoneTypeTable = "PhoneType";
        public const string PhoneTypeAlias = "PHT";

        public const string PhoneTypeID = "PhoneTypeID";
        public const string PhoneTypeName = "Name";
        public const string PhoneTypeStatusId = "StatusID";
        #endregion

        #region VendorEmail Type Tables & Fields
        public const string EmailTypeTable = "EmailType";
        public const string EmailTypeAlias = "EMT";

        public const string EmailTypeID = "EmailTypeID";
        public const string EmailTypeName = "Name";
        public const string EmailTypeStatusId = "StatusID";
        #endregion

        #region PrimaryGroup Tables & Fields
        public const string GroupTable = "[Group]";
        public const string GroupAlias = "GRP";

        public const string GroupID = "GroupID";
        public const string GroupName = "Name";
        public const string GroupStatusId = "StatusID";
        #endregion

        #region Primary Contact Tables & Fields
        public const string UserTable = "[User]";
        public const string UserAlias = "USR";

        public const string UserID = "UserID";
        public const string UserFirstName = "FirstName";
        public const string UserLastName = "LastName";
        public const string UserUserName = "UserName";
        public const string UserPassword = "Password";
        public const string UserUserStatusId = "UserStatusID";
        public const string UserADUserName = "ADUserName";

        #endregion

        #region Credential VendorStatus Tables & Fields
        public const string CredentialStatusTable = "CredentialStatus";
        public const string CredentialStatusAlias = "CRS";

        public const string CredentialStatusID = "CredentialStatusID";
        public const string CredentialStatusName = "Name";
        public const string CredentialStatusStatusId = "StatusID";

        #endregion

        #region Certificate Type Tables & Fields

        public const string CertificateTypeTable = "CertificateType";
        public const string CertificateTypeAlias = "CRT";

        public const string CertificateTypeID = "CertificateTypeID";
        public const string CertificateTypeName = "Name";
        public const string CertificateTypeStatusId = "StatusID";

        #endregion

        #region Resource Roles Tables & Fields
        public const string ResourceRolesTable = "ResourceRoles";
        public const string ResourceRolesAlias = "RSRR";

        public const string ResourceRolesID = "RoleID";
        public const string ResourceRolesName = "Name";
        public const string ResourceRolesAbbreviation = "Abbreviation";
        public const string ResourceRolesStatusId = "StatusID";
        #endregion

        #region Form Table & Fields
        public const string FormTable = "Form";
        public const string FormAlias = "FRM";

        public const string FormID = "FormID";
        public const string FormName = "Name";
        public const string FormStatusId = "StatusID";

        #endregion

        #region Resource Table & Fields
        public const string ResourceTable = "Resource";
        public const string ResourceAlias = "RSR";

        public const string ResourceFirstName = "FirstName";
        public const string ResourceLastName = "LastName";
        public const string ResourceId = "ResourceID";

        public const string ResourceIsExpert = "IsExpert";
        public const string ResourceNickname = "Nickname";
        public const string ResourceVendorId = "VendorID";
        public const string ResourceResourceStatusId = "ResourceStatusID";
        public const string ResourcePhoto = "Photo";
        public const string ResourceBio = "Bio";
        public const string ResourceResume = "Resume";
        public const string ResourceComputerInformation = "ComputerInformation";
        public const string ResourceBirthDate = "BirthDate";
        public const string ResourceRecordStatusId = "RecordStatusID";
        public const string ResourceBusinessAlias = "BusinessAlias";
        public const string ResourceDisplayCredentials = "DisplayCredentials";

        public const string FirstName = "FirstName";
        public const string LastName = "LastName";

        #endregion

        #region TRTA_ProductMetadata Table & Fields
        public const string TRTA_ProductMetadataTable = "TRTA_ProductMetadata";
        public const string TRTA_ProductMetadataAlias = "TRTAPM";
        public const string TRTA_ProductMetadataTitle = "Title";
        public const string TRTA_ProductMetadataProductMetadataID = "ProductMetadataID";
        public const string TRTA_ProductMetadataFieldOfStudyId = "FieldOfStudyID";
        #endregion TRTA_ProductMetadata Table & Fields

        #region User VendorStatus Table & Fields
        public const string UserStatusTable = "UserStatus";
        public const string UserStatusAlias = "UTS";

        public const string UserStatusUserStatusId = "UserStatusID";
        public const string UserStatusName = "Name";
        public const string UserStatusStatusId = "StatusID";
        #endregion

        #region ResourceGroup Table & Fields
        public const string ResourceGroupTable = "ResourceGroup";
        public const string ResourceGroupAlias = "RGA";

        public const string ResourceGroupID = "ResourceGroupID";
        public const string ResourceGroupResourceID = "ResourceID";
        public const string ResourceGroupPrimaryGroupID = "GroupID";
        public const string ResourceGroupPrimaryContactID = "PrimaryContactID";
        public const string ResourceGroupStatusID = "StatusID";
        #endregion

        #region User Group Table & Fields
        public const string UserGroupTable = "UserGroup";
        public const string UserGroupAlias = "USG";

        public const string UserGroupID = "UserGroupID";
        public const string UserGroupUserID = "UserID";
        public const string UserGroupGroupID = "GroupID";
        public const string UserGroupIsPrimaryContact = "IsPrimaryContact";
        public const string UserGroupStatusID = "StatusID";
        #endregion

        #region Resource Certificate Table & Fields
        public const string ResourceCertificateTable = "ResourceCertificate";
        public const string ResourceCertificateAlias = "RCT";

        public const string ResourceCertificateId = "CertificateID";
        public const string ResourceCertificateResourceId = "ResourceID";
        public const string ResourceCertificateCertificateTypeId = "CertificateTypeID";
        public const string ResourceCertificateTitle = "Title";
        public const string ResourceCertificateAcronym = "Acronym";
        public const string ResourceCertificateRegulator = "Regulator";
        public const string ResourceCertificateStateId = "StateID";
        public const string ResourceCertificateCredentialStatusId = "CredentialStatusID";
        #endregion

        #region CommunicationRecord Table & Fields
        public const string CommunicationTable = "CommunicationRecord";
        public const string CommunicationAlias = "CMN";

        public const string CommunicationId = "CommunicationID";
        public const string CommunicationResourceId = "ResourceID";
        public const string CommunicationEnteredDate = "EnteredDate";
        public const string CommunicationUserId = "UserID";
        public const string CommunicationSubject = "Subject";
        public const string CommunicationComment = "Comment";
        public const string CommunicationNeverArchived = "NeverArchived";
        public const string CommunicationSpecialCondition = "SpecialCondition";
        public const string CommunicationStatusId = "StatusID";
        #endregion

        #region Resource VendorEmail Table & Fields
        public const string ResourceEmailTable = "ResourceEmail";
        public const string ResourceEmailAlias = "RSE";

        public const string ResourceEmailId = "ResourceEmailID";
        public const string ResourceEmailEmailTypeId = "EmailTypeID";
        public const string ResourceEmailEmail = "Email";
        public const string ResourceEmailIsPrimary = "IsPrimary";
        public const string ResourceEmailResourceId = "ResourceID";
        public const string ResourceEmailStatusId = "StatusID";
        #endregion

        #region Course Contributor Table & Fields
        public const string CourseContributorTable = "CourseContributor";
        public const string CourseContributorAlias = "RPD";

        public const string CourseContributorID = "CourseContributorID";
        public const string CourseContributorId = "CourseContributorID";
        public const string CourseContributorResourceId = "ResourceID";
        //public const string ResourceProductsProductStatusID = "ProductStatusID";
        public const string CourseContributorIsContractOnFile = "IsContractOnFile";
        public const string CourseContributorRoyalityRate = "RoyaltyRates";
        public const string CourseContributorExternalAffiliateId = "ExternalAffiliateID";
        public const string CourseContributorCourseMetadataId = "CourseMetadataID";
        //public const string ResourceProductsStatusID = "StatusID";

        #endregion

        #region Resource VendorPhone Table & Fields
        public const string ResourcePhoneTable = "ResourcePhone";
        public const string ResourcePhoneAlias = "RSP";

        public const string ResourcePhoneId = "ResourcePhoneID";
        public const string ResourcePhoneResourceId = "ResourceID";
        public const string ResourcePhonePhoneTypeId = "PhoneTypeId";
        public const string ResourcePhonePhoneNo = "PhoneNo";
        public const string ResourcePhoneIsPrimary = "IsPrimary";
        public const string ResourcePhoneStatusId = "StatusID";
        #endregion

        #region ResourceAddress Table & Fields

        public const string ResourceAddressTable = "ResourceAddress";
        public const string ResourceAddressTableAlias = "RAD";

        public const string ResourceAddressResourceId = "ResourceID";
        public const string ResourceAddressId = "ResourceAddressId";
        public const string ResourceAddressAddress1 = "Address1";
        public const string ResourceAddressAddress2 = "Address2";
        public const string ResourceAddressCity = "City";
        public const string ResourceAddressStateId = "StateID";
        public const string ResourceAddressZip = "Zip";
        public const string ResourceAddressAddressTypeId = "AddressTypeID";
        public const string ResourceAddressCountryId = "CountryID";
        public const string ResourceAddressTimeZoneId = "TimeZoneID";
        public const string ResourceAddressStatusId = "StatusID";

        #endregion

        #region ResourceProductRoles Object & Attributes
        public const string CourseContributorRolesTable = "CourseContributorRoles";
        public const string CourseContributorRolesAlias = "RPR";

        public const string CourseContributorRolesId = "CourseContributorRoleID";
        public const string CourseContributorRolesProductId = "CourseContributorID";
        public const string CourseContributorRolesRoleId = "RoleID";

        public const string DeleteResourceProductRoles = "DeleteResourceProductRoles";
        public const string SaveResourceProductRoles = "SaveResourceProductRoles";

        #endregion

        #region Resource External Affliates Table & Fields
        public const string ResourceExternalAffiliatesTable = "ResourceExternalAffiliates";
        public const string ResourceExternalAffiliatesAlias = "REAF";

        public const string ResourceExternalAffiliateID = "ResourceExternalAffiliateID";
        public const string ResourceExternalAffiliatesProductID = "CourseContributorID";
        public const string ResourceExternalAffiliatesExternalAffiliateID = "ExternalAffiliateID";

        public const string DeleteResourceExternalAffiliates = "DeleteResourceExternalAffiliates";
        public const string SaveResourceExternalAffiliates = "SaveResourceExternalAffiliates";

        public const string ExternalAffiliateConcatenated = "ExternalAffliateConcatanated"; //Temp table maintain to keep concatenates Affliates for sorting
        public const string ExternalAffiliatesList = "ExternalAffliate"; //Temp table maintain to keep concatenates Affliates for sorting

        #endregion

        #region ProductStatus Table & Fields
        public const string ProductStatusTable = "CourseStatus";
        public const string ProductStatusAlias = "PSS";

        public const string ProductStatusID = "CourseStatusID";
        public const string ProductStatusName = "Name";
        public const string ProductStatusStatusID = "StatusID";
        #endregion

        #region ProductVersion Table & Fields
        //public const string ProductVersionTable = "CourseMetadataVersion";
        //public const string ProductVersionAlias = "PVS";

        //public const string ProductVersionID = "CourseMetadataVersionID";
        //public const string ProductVersionVersionID = "VersionID";
        //public const string ProductVersionName = "Name";
        //public const string ProductVersionProductMetaDataID = "CourseMetaDataID";
        //public const string ProductVersionProductStatusID = "CourseStatusID";
        #endregion


        #region Resource Payment Table & Fields

        public const string ResourcePaymentTable = "ResourcePayment";
        public const string ResourcePaymentAlias = "RPA";

        public const string ResourcePaymentId = "ResourcePaymentId";
        public const string ResourcePaymentResourceId = "ResourceID";
        public const string ResourcePaymentFormId = "FormID";
        public const string ResourcePaymentDateReceived = "DateReceived";
        public const string ResourcePaymentStatusId = "StatusID";

        #endregion

        #region Sponsor Page Table & Fields
        public const string SponsorPageTable = "SponsorPage";
        public const string SponsorPageTableAlias = "SPG";

        public const string ContentHeader = "ContentHeader";
        public const string CustomText = "CustomText";
        public const string SponsorPageID = "SponsorPageID";
        public const string SponsorPageSponsorID = "SponsorID";
        public const string SponsorPageProductList = "ProductList";
        public const string DisplayPanelTop = "DisplayPanelTop";
        public const string DisplayPanelBottom = "DisplayPanelBottom";
        public const string DisplayPanelLeft = "DisplayPanelLeft";
        public const string DisplayPanelLogin = "DisplayPanelLogin";

        #endregion

        #region Sponsor Page Product Table & Fields
        public const string SponsorPageProductTable = "SponsorPageProduct";
        public const string SponsorPageProductSponsorPageId = "SponsorPageID";
        public const string SponsorPageProductTableAlias = "SPP";
        public const string SponsorPageProductTypeID = "SponsorPageProductTypeID";
        public const string SponsorPageProductMetadataID = "ProductMetadataID";
        public const string SponsorPageProductText = "Text";
        #endregion

        #region Sponsor Page Global Text Table & Fields
        public const string SponsorPageGlobalTextTable = "SponsorPageGlobalText";
        public const string SponsorPageGlobalTextTableAlias = "SPG";
        public const string SPGGlobalTextID = "SponsorPageGlobalTextID";
        public const string SPGName = "Name";
        public const string SPGGlobalText = "GlobalText";
        public const string SPGSequenceNumber = "SequenceNumber";
        #endregion

        #region Course Graphic Table & Fields

        public const string CourseGraphicAlias = "CG";
        public const string CourseGraphicTable = "CourseGraphic";
        public const string ExampleGraphicPath = "ExampleGraphicPath";
        public const string CourseGraphicID = "CourseGraphicID";


        #endregion

        #region Sponsor Table & Fields

        public const string SponsorTable = "Sponsor";
        public const string SponsorAlias = "SPN";
        public const string SponsorId = "SponsorID";
        public const string SponsorCode = "SponsorCode";
        public const string SponsorName = "SponsorName";
        public const string SponsorAddress = "SponsorAddress";
        public const string SponsorCity = "City";
        public const string SponsorZipCode = "ZipCode";
        public const string SponsorPhone = "Phone";
        public const string SponsorWebsite = "Website";
        public const string SponsorEmail = "Email";
        public const string SponsorLogoImage = "LogoImage";
        public const string SponsorRoyaltyFrequency = "RoyaltyFrequency";
        public const string SponsorCountryID = "CountryID";
        public const string SponsorStateID = "StateID";
        public const string SponsorStatusID = "StatusID";
        #endregion

        #region VendorStatus Table & Fields
        public const string StatusTable = "Status";
        public const string StatusTableAlias = "STS";
        public const string StatusID = "StatusID";
        public const string StatusName = "Name";
        #endregion


        #region Sponsor Page Included Text Table & Fields
        public const string SponsorPageIncludedTextTable = "SponsorPageIncludedText";
        public const string SponsorPageIncludedTextSponsorPageId = "SponsorPageID";
        public const string SponsorPageIncludedTextTableAlias = "SPIT";
        public const string SponsorPageIncludedTextID = "SponsorPageIncludedTextID";
        public const string GlobalTextID = "GlobalTextID";
        #endregion

        #region Sponsor Visit Table & Fields
        public const string SponsorVisitSponsorVisitID = "SponsorVisitID";
        public const string SponsorVisitTable = "SponsorVisit";
        public const string SponsorVisitAlias = "SV";
        public const string SponsorVisitCookieID = "CookieID";
        public const string SponsorVisitVisitDate = "VisitDate";
        public const string SponsorVisitSponsorCode = "SponsorCode";
        public const string SponsorVisitIsPurchased = "IsPurchased";
        public const string SponsorVisitPurchasedDate = "PurchasedDate";
        public const string SponsorVisitValue = "Value";
        public const string SponsorVisitUserID = "UserID";
        public const string SponsorVisitIsHit = "IsHit";
        public const string SponsorVisitProductMetadataID = "ProductMetadataID";
        public const string SponsorVisitDeliveryFormatID = "DeliveryFormatID";
        public const string SponsorTransactionNo = "TransactionNo";
        public const string SponsorVisitUnisonId = "UnisonID";
        #endregion


        #region Sponsor Image Table & Fields
        public const string SponsorImagesTable = "SponsorImages";
        public const string SponsorImagesAlias = "SI";
        public const string SponsorImageId = "ImageID";
        public const string SponsorImageName = "ImageName";
        public const string SponsorImageFileName = "ImageFileName";
        public const string SponsorImageSponsorId = "SponsorID";
        #endregion

        #region Sponsor Image Table & Fields
        public const string GlobalImagesTable = "GlobalImages";
        public const string GlobalImagesAlias = "GI";
        public const string GlobalImageId = "ImageID";
        public const string GlobalImageName = "ImageName";
        public const string GlobalImageFileName = "ImageFileName";
        #endregion

        #region Report Table & Fields
        public const string ReportTable = "Report";
        public const string ReportAlias = "RPT";

        public const string ReportId = "ReportID";
        public const string ReportName = "Name";
        public const string ReportViewName = "ViewName";
        public const string ReportComparisonColumn = "ComparisonColumn";
        public const string ReportStatusId = "StatusID";
        public const string ReportData = "ReportData";
        public const string ReportIsFirmReport = "IsFirmReport";
        public const string ReportFirmFilterColumn = "FirmFilterColumn";
        public const string ReportLifeCycleAdapterName = "LifeCycleAdapterName";
        public const string ReportFirmFilterColumnOrganizationId = "OrganizationID";
        public const string ReportFirmFilterColumnProfessionalOrganizationId = "OrganizationID";
        public const string ReportFirmFilterColumnReportInstanceId = "ReportInstanceID";
        public const string ReportLifeCycleTableName = "LifeCycleTableName";
        public const string SSRSRdlcLocation = "SsrsRdlcLocation";
        public const string FirmFilterColumn = "FirmFilterColumn";

        #endregion

        #region Report Type Table & Fields
        public const string ReportTypeTable = "ReportType";
        public const string ReportTypeAlias = "RType";
        public const string ReportTypeId = "ReportTypeID";
        public const string ReportTypeName = "Name";


        #endregion


        #region Report Column Table & Fields
        public const string ReportColumnTable = "ReportColumn";
        public const string ReportColumnAlias = "RPTCOL";
        public const string ReportColumnId = "ReportColumnID";
        public const string ReportColumnReportId = "ReportID";
        public const string ReportColumnName = "Name";
        public const string ReportColumnType = "ReportColumnTypeID";
        public const string ReportColumnDisplayName = "DisplayName";
        public const string ReportColumnIsAnalytical = "IsAnalytical";
        public const string ReportColumnListLookupID = "ReportListLookupID";
        #endregion

        #region ReportListLookup  Table & Fields
        public const string ReportListLookupTable = "ReportListLookup";
        public const string ReportLookupColumn = "LookupColumn";
        public const string ReportLookupTable = "LookupTable";
        public const string ReportListLookupId = "ReportListLookupID";
        #endregion

        #region ReportInstance Table & Fields
        public const string ReportInstanceTable = "ReportInstance";
        public const string ReportInstanceAlias = "RPI";
        public const string ReportInstanceView = "vw_SearchMarketingVisitor";
        public const string ReportInstanceViewAlias = "vw_SearchMarketingVisitor";

        public const string ReportInstanceId = "ReportInstanceID";
        public const string ReportInstanceReportId = "ReportID";
        public const string ReportInstanceName = "Name";
        public const string ReportInstanceReportTypeId = "ReportTypeID";
        public const string ReportInstanceDefinition = "ReportDefinition";
        public const string ReportInstanceLastModifiedDate = "LastModifiedDate";
        public const string ReportInstanceGeneratedUser = "GeneratedUser";
        public const string ReportInstanceGeneratedDate = "GeneratedDate";
        public const string ReportInstanceDatabaseView = "DatabaseView";
        public const string ReportInstanceLastModifiedUser = "LastModifiedUser";
        public const string ReportInstanceGeneratedUserTypeId = "GeneratedUserTypeID";
        public const string ReportInstanceLastModifiedUserTypeId = "LastModifiedUserTypeID";
        public const string ReportInstanceOrganizationId = "OrganizationID";
        #endregion

        #region CPClickThorughVisit Table & Fields

        public const string CPClickThorughVisitTable = "CPClickThorughVisit";
        public const string CPClickThorughVisiteAlias = "CPClick";

        public const string CPClickThorughVisitID = "CPClickThorughVisitID";
        public const string CPClickThroughVisitProfessionalID = "ProfessionalID";
        public const string CPClickThroughVisitClickThroughID = "ClickThroughID";
        public const string CPClickThroughVisitKeyword = "Keyword";
        public const string CPClickThroughVisitCPLDestinationPage = "CPLDestinationPage";
        public const string CPClickThroughVisitCPDeparturePage = "CPDeparturePage";
        public const string CPClickThroughVisitIsPurchased = "IsPurchased";
        public const string CPClickThroughVisitPaymentModel = "PaymentModel";
        public const string CPClickThroughVisitTransactionNo = "TransactionNo";
        public const string CPClickThroughVisitPurchasedDate = "PurchasedDate";
        public const string CPClickThroughVisitVisitDate = "VisitDate";
        public const string CPClickThroughVisitUnisonID = "UnisonID";
        #endregion

        #region Common Data
        #region VendorCountry Table & Fields
        public const string CountryTable = "Country";
        public const string CountryTableAlias = "Cntry";
        public const string CountryId = "CountryID";
        public const string CountryName = "Name";
        public const string CountryAbbreviation = "Abbreviation";
        #endregion

        #endregion

        //Query Parameters
        public const string SearchKeyword = "@Keyword";
        public const string GlobalTextIdParameter = "@GlobalTextId";
        public const string CourseIdParameter = "@CourseId";
        public const string CourseTitleParameter = "@CourseTitle";

        public const string AcronymParameter = "@Acronym";
        public const string UnisonIdParameter = "@UnisonId";

        public const string PharseSearchKeywordParameter = "@PharseSearchKeyword";
        public const string WordSearchKeywordParameter = "@WordSearchKeyword";
        public const string CurrentTimeParameter = "@Now";
        public const string FieldOfStudyParameter = "@FieldOfStudyParameter";

        public const string ProductListCodeParameter = "@ProductListCode";


        public const string InstructorName = "InstructorName";

        public const string FacilityTable = "Facility";
        public const string FacilityName = "Name";
        public const string FacilityId = "FacilityID";
        public const string FacilityLocationId = "LocationID";



        #region Common
        public const string NewDataSet = "NewDataSet";
        public const string RowNumberBy = "ROW_NUMBER() OVER (ORDER BY ";
        public const string RowNumberAlias = "Row";
        public const string RowNumberTableAlias = "RowTable";
        public const string OldVersionNumberTable = "TableAcronym";
        public const string MaxValue = "MaxValue";

        public const string SqlOr = " OR ";
        public const string SqlAnd = " AND ";
        public const string SqlNot = " NOT ";
        public const string SqlSeparator = ", ";
        public const string SqlBetweenSeperator = "; ";
        public const string SqlLikeAny = "%";
        public const string SqlIn = " IN ";
        public const string SqlNotIn = "NOT IN";
        public const string SqlDistinctCount = " COUNT ( DISTINCT ";
        public const string SqlOperationEnd = " ) ";

        public const string SqlBeginBrace = "(";
        public const string SqlSelect = "SELECT";
        public const string SqlSpace = " ";
        public const string SqlEndBrace = ")";
        public const string SqlMinus = " -";
        public const string SqlOne = " 1";
        public const string SqlZero = " 0";
        public const string SqlFrom = "FROM";
        public const string SqlSum = "SUM";
        public const string sqlGetDate = "GetDate ( )";
        public const string SqlWhere = "WHERE";
        public const string SqlAs = " AS ";
        public const string SqlYear = "YEAR";
        public const string SqlMonth = "MONTH";
        public const string SqlDot = ".";
        public const string SqlComma = ",";
        public const string SqlEqual = " = ";
        public const string SqlNotEqualTo = " <> ";
        public const string SqlLessThan = " < ";
        public const string SqlLessThanOrEqualTo = " <= ";
        public const string SqlPlus = "+";
        public const string SqlIsNull = " IS NULL";
        public const string SqlIsNotNull = " IS NOT NULL";
        public const string SqlCount = "count";
        public const string SqlCase = "CASE ";
        public const string SqlConvert = " CONVERT(varchar(4),";
        public const string CaseStatement = " WHEN 1 THEN 1 ELSE 0 END ";
        public const string SqlSplit = "/";
        public const string SqlDecimalConvert = "CONVERT(decimal(10, 2), ROUND(";
        public const string SqlAddSlash = " + '/' +";
        public const string SqlKeyWordDecending = "Desc";
        public const string SqlKeyForXML = " FOR XML PATH('') ";
        public const string SqlTrue = "1";
        public const string SqlFalse = "0";

        public const char Splitter = '/';
        public const char Seperator = ',';
        public const string DecimalPoints = ", 2))";
        public const string SingleQuote = "'";
        public const string SqlFieldSpace = "' '";
        public const string SqlStatementSpace = " ";
        public const string SingleQuoteWithSpace = ", ";
        public const string SqlNull = "NULL";

        public const string SqlDefaultDate = "1/1/0001";
        public const string RecordCountTableAlias = "CountTable";
        public const string Asterisk = "*";
        public const string SqlGreaterThan = " > ";
        public const string SqlGreaterThanOrEqualTo = " >= ";
        public const string SqlMax = "MAX";

        public const char SqlDoubleQuote = '\"';
        public const char SqlSpaceChar = ' ';

        public const string SqlFullTextSearchKeywordRegExpression = @"[\~\!\(\)\&\|,\""\'\[\]]";
        public const string SqlFullTextOr = " OR ";
        public const string SqlDoubleQuoteString = "\"";
        public const string SqlFullTextDoubleQuoteString = "\"\"";
        public const string SqlBetween = "BETWEEN";
        #region Oracle Constants
        public const string oracleSysDate = "sysdate";
        #endregion

        #endregion

        #endregion

        #region Notification Service Table & Fields

        public const string NotificationTable = "Notifications";
        public const string NotificationId = "NotificationID";
        public const string NotificationTypeId = "NotificationTypeID";
        public const string NotificationSender = "Sender";
        public const string NotificationSubject = "Subject";
        public const string NotificationMessage = "Message";
        public const string NotificationPriority = "Priority";
        public const string NotificationStatus = "Status";
        public const string NotificationCompletedTime = "CompletedTime";

        public const string NotificationTypeTable = "NotificationTypes";
        public const string NotificationTypeName = "NotificationTypeName";
        public const string NotificationTypeMessageTemplate = "MessageTemplate";

        public const string RecipientTable = "Recipients";
        public const string RecipientEmail = "Email";
        #endregion

        #region TimeZone table & View Fields

        public const string TimeZoneTable = "TimeZone";
        public const string TimeZoneAlias = "TMZ";

        public const string TimeZoneID = "TimeZoneID";
        public const string TimeZoneName = "Name";
        public const string TimeZoneStatusId = "StatusID";
        public const string TimeZoneHourOffset = "HourOffset";
        public const string TimeZoneMinOffset = "MinuteOffset";

        #endregion

        #region SharedSession table & View Fields

        public const string SharedSessionTable = "SharedSession";
        public const string SharedSessionAlias = "SHS";

        public const string SharedSessionSharedSessionID = "SharedSessionID";
        public const string SharedSessionGlobalSessionID = "GlobalSessionID";
        public const string SharedSessionApplicationID = "CPLApplicationID";
        public const string SharedSessionUserId = "UserID";
        public const string SharedSessionOrganizationID = "OrganizationID";
        public const string SharedSessionIsAdmin = "IsAdmin";
        public const string SharedSessionIsGhostLogin = "isGhostUser";

        #endregion

        #region Professional table & View Fields

        public const string ProfessionalTable = "Professional";
        public const string ProfessionalAlias = "PRO";

        public const string ProfessionalId = "id";
        public const string ProfessionalUsername = "username";
        public const string ProfessionalPassword = "password";
        public const string ProfessionalFirstname = "firstname";
        public const string ProfessionalLastname = "lastname";
        public const string ProfessionalUnisonShipTo = "UnisonShipTo";
        public const string ProfessionalBirthday = "birthday";
        public const string ProfessionalEmail = "email";
        public const string ProfessionalHasWritable = "writable";

        public const string ProfessionalReminder = "reminder";
        public const string ProfessionalWritable = "writable";
        public const string ProfessionalDirty = "dirty";
        public const string ProfessionalOwner = "owner";
        public const string ProfessionalPreference = "preference";
        public const string ProfessionalLastAccess = "last_access";
        public const string ProfessionalProfessionalSalutationID = "ProfessionalSalutationID";
        public const string ProfessionalMiddleInitial = "MiddleInitial";
        public const string ProfessionalSuffix = "Suffix";
        public const string ProfessionalCompanyName = "CompanyName";
        public const string ProfessionalDepartment = "Department";
        public const string ProfessionalIsPilotTester = "IsPilotTester";
        public const string ProfessionalResume = "Resume";
        public const string ProfessionalResumeName = "ActualFileName";
        public const string ProfessionalPilotTesterUserTypeID = "PilotTesterUserTypeID";
        public const string ProfessionalFieldOfStudyID = "FieldOfStudyID";
        public const string ProfessionalCPAMembershipNumber = "CPAMembershipNumber";//to hold pilot tester CPAMembershipNumber 
        public const string ProfessionalPilotTesterWarningLevelID = "PilotTesterWarningLevelID";
        public const string ProfessionalPilotTesterStatusID = "PilotTesterStatusID";
        public const string ProfessionalPilotTesterStatusChangedReason = "PilotTesterStatusChangedReason";
        public const string ProfessionalPilotTesterStatusChangedDate = "PilotTesterStatusChangedDate";
        public const string ProfessionalProfessionalStatusID = "ProfessionalStatusID";
        public const string ProfessionalUnitNumber = "unit_num";
        public const string ProfessionalLocked = "locked";
        public const string ProfessionalIsUserLinkedToCheckpoint = "Isuserlinkedtocp";
        public const string ProfessionalRegistartionTimeStamp = "RegistartionTimeStamp";
        public const string ProfessionalIsProfileUpdateRequired = "IsProfileUpdateRequired";
        public const string ProfessionalIsRegistrant = "IsRegistrant";
        public const string ProfessionalHasValidEmail = "HasValidEmail";
        #endregion

        #region OrganizationAdministrator table & View Fields

        public const string OrgAdministratorTable = "OrganizationAdministrator";
        public const string OrgAdministratorAlias = "OAD";

        public const string OrgAdministratorId = "id";
        public const string OrgAdministratorUsername = "username";
        public const string OrgAdministratorPassword = "password";
        public const string OrgAdministratorOrganization = "organization";
        public const string OrgAdministratorName = "name";
        public const string OrgAdministratorLocked = "locked";
        public const string OrgAdministratorEmail = "email";
        public const string OrgAdministratorMaster = "master";
        public const string OrgAdministratorComplianceManager = "compliance_manager";
        public const string OrgAdministratorEmployeeManager = "employee_manager";
        public const string OrgAdministratorUniversityManager = "university_manager";
        public const string OrgAdministratorCoach = "coach";

        #endregion

        #region Organization table
        public const string OrganizationTable = "Organization";
        public const string OrganizationAlias = "ORG";

        public const string OrganizationId = "id";
        public const string OrganizationUsername = "username";
        public const string OrganizationLogo = "logo";
        public const string OrganizationPreference = "preference";
        public const string OrganizationEnabled = "enabled";
        public const string OrganizationSeatsEmployee = "seats_employee";
        public const string OrganizationSeatsProfessional = "seats_professional";
        public const string OrganizationUnitNumber = "unit_num";
        public const string OrganizationTerminationDate = "date_termination";
        public const string OrganizationSeatsCollege = "seats_college";
        public const string OrganizationSeatsLearning = "seats_learning";
        public const string OrganizationSeatsAdministrator = "seats_administrator";
        public const string OrganizationSeatsCoach = "seats_coach";
        public const string OrganizationLmsEnabled = "lms_enabled";
        public const string OrganizationsingleSignon = "single_signon";
        public const string OrganizationResultRecordCount = "RecCount";
        public const string OrganizationSecretKey = "secret_key";
        public const string OrganizationName = "name";
        public const string OrganizationUnisonShipToDefault = "UnisonShipToDefault";
        #endregion

        #region OrganizationService table

        public const string OrganizationServiceTable = "OrganizationService";
        public const string OrganizationServiceAlias = "ORGS";

        public const string OrganizationServiceFieldOrganization = "organization";
        public const string OrganizationServiceFieldService = "service";

        #endregion

        #region OrganizationHost table

        public const string OrganizationHostTable = "OrganizationHost";
        public const string OrganizationHostAlias = "ORGH";

        public const string OrganizationHostFieldOrganization = "organization";
        public const string OrganizationHostFieldHost = "host";

        #endregion

        #region SharedSessionValue table & View Fields

        public const string SharedSessionValueTable = "SharedSessionValue";
        public const string SharedSessionValueAlias = "SSV";

        public const string SharedSessionValueSharedSessionValueID = "SharedSessionValueID";
        public const string SharedSessionValueSharedSessionID = "SharedSessionID";
        public const string SharedSessionValueSessionKey = "SessionKey";
        public const string SharedSessionValueSessionValue = "SessionValue";


        #endregion

        #region Online Grading Table,  View Fields & SPs

        #region Exams table & view fields
        public const string ExamsView = "vw_Exams";
        public const string ExamsViewAlias = "EXVW";
        public const string ExamsTable = "OgsExam";
        public const string ExamsAlias = "EXM";

        public const string ExamId = "OgsExamID";
        public const string ExamsCatalogId = "OgsCatalogID";
        public const string ExamsCourseMetadataId = "CourseMetadataID";
        public const string ExamsDateCreated = "DateCreated";
        public const string ExamsDateUpdated = "DateUpdated";
        public const string ExamsOwnerId = "OwnerID";
        public const string ExamsExamStatusId = "OgsExamStatusID";

        public const string ExamsProductMetadataId = "ProductMetadataId";
        public const string ExamsViewCourseId = "CourseId";
        public const string ExamsViewExamId = "ExamID";
        public const string ExamsViewBrandId = "BrandID";
        public const string ExamsViewDateExpires = "DateExpires";
        public const string ExamsViewCourseTitle = "CourseTitle";
        public const string ExamsViewScore = "Score";
        public const string ExamsViewAttempts = "Attempts";
        public const string ExamsViewPrice = "Price";
        public const string ExamsViewExamMode = "Mode";
        public const string MaxExamIdAlias = "MaxExamIdAlias";
        public const string ExamsViewMaxAttempts = "MaxAttempts";
        public const string ExamsViewMaxScore = "MaxScore";

        #endregion

        #region OgsExams table & view fields
        public const string OgsExamsTable = "OgsExam";
        public const string OgsExamsAlias = "OgsEXM";

        public const string OgsExamId = "OgsExamID";
        public const string OgsExamsCatalogId = "OgsCatalogID";
        public const string OgsExamsCourseMetadataId = "CourseMetadataID";
        public const int EndOfDateSeconds = 86399;// This constant value to extend the time to till EOD FINAL NASBA DATE 


        #endregion

        #region ExamPurchased Table & View Fields

        public const string ExamPurchasedTable = "ExamPurchased";
        public const string ExamPurchasedAlias = "EXPD";
        public const string ExamPurchasedQueryAlias = "EXPQ";

        public const string ExamPurchasedId = "ExamPurchasedID";
        public const string ExamPurchasedDatePurchased = "DatePurchased";
        public const string ExamPurchasedInvoiceId = "InvoiceID";
        public const string ExamPurchasedProfessionalId = "ProfessionalID";
        public const string ExamPurchasedExamId = "ExamID";
        public const string ExamPurchasedFlags = "Flags";
        public const string ExamPurchasedNoOfAttemptsAlias = "NoOfAttemts";
        #endregion

        #region Exam Attempts Table & View Fields
        public const string ExamAttemptsTable = "ExamAttempts";
        public const string ExamAttemptsAlias = "EXAT";

        public const string ExamAttemptsAttemptId = "AttemptID";
        public const string ExamAttemptsExamPurchasedId = "ExamPurchasedID";
        public const string ExamAttemptsDateStarted = "DateStarted";
        public const string ExamAttemptsDateCompleted = "DateCompleted";
        public const string ExamAttemptsScore = "Score";
        public const string ExamAttemptsSource = "Source";
        public const string ExamAttemptsFlags = "Flags";
        public const string NumberOfExamAttempts = "NumberOfExamAttempts";
        public const string ExamAttemptsScoreAlias = "ExamAttemptsScoreAlias";
        public const string ExamsLastAttemptScoreAlias = "LASA";
        public const string ExamsLastAttemptScoreMainQueryAlias = "LASMQ";

        #endregion

        #region ExamQuestions Table & Fields

        public const string OgsExamQuestionsTable = "OgsExamQuestion";
        public const string OgsExamQuestionsTableAlias = "EXQ";

        public const string OgsExamQuestionsListDataAlias = "ExamQuestionsListData";
        public const string OgsExamQuestionsPagedListDataAlias = "ExamQuestionsPagedListData";

        public const string OgsExamQuestionsId = "OgsExamQuestionID";
        public const string OgsExamQuestionsExamId = "OgsExamID";
        public const string OgsExamQuestionsNumber = "Number";
        public const string OgsExamQuestionsQuestion = "Question";
        public const string OgsExamQuestionStatusId = "OgsExamQuestionStatusID";
        public const string OgsExamQuestionsIsVoid = "IsVoid";

        public const string OgsExamQuestionsFlags = "Flags";

        #endregion

        #region ExamAnswers Table & Fields

        public const string OgsExamAnswerTable = "OgsExamAnswer";
        public const string OgsExamAnswerTableAlias = "EXAN";

        public const string OgsExamAnswerId = "OgsExamAnswerID";
        public const string OgsExamAnswerQuestionId = "OgsExamQuestionID";
        public const string OgsExamAnswerOptionId = "OgsExamAnswerOptionID";
        public const string OgsExamAnswerAnswer = "Answer";
        public const string OgsExamAnswerReason = "Reason";
        public const string OgsExamAnswerIsCorrect = "IsCorrect";

        public const string OgsExamAnswersExamId = "ExamID";
        public const string ExamAnswersNumber = "Number";
        public const string ExamAnswersLetter = "Letter";
        public const string ExamAnswersDescription = "Description";
        public const string ExamAnswersCorrect = "Correct";

        #endregion

        #region ExamAttemptAnswers Table & Fields

        public const string ExamAttemptAnswersTable = "ExamAttemptAnswers";
        public const string ExamAttemptAnswersTableAlias = "EXAA";

        public const string ExamAttemptAnswersAttemptId = "AttemptID";
        public const string ExamAttemptAnswersNumber = "Number";
        public const string ExamAttemptAnswersLetter = "Letter";
        public const string ExamAttemptAnswersFlags = "Flags";

        #endregion

        #region OnlineGradingCatalog Table & View Fields

        public const string OGSCatalogView = "vw_OgsCatalog";
        public const string OGSCatalogViewAlias = "VWOGSCAT";

        public const string OGSCatalogViewCourseTitle = "CourseTitle";
        public const string OGSCatalogViewCatalogId = "OgsCatalogID";
        public const string OGSCatalogViewExamVersion = "VersionNumber";
        public const string OGSCatalogViewCatalogTypeId = "OgsCatalogTypeID";
        public const string OGSCatalogViewDateUpdated = "DateUpdated";
        public const string OGSCatalogViewUnisonId = "UnisonID";
        public const string OGSCatalogViewCatalogTypeName = "CatalogTypeName";
        public const string OGSCatalogViewDateAvailable = "DateAvailable";
        public const string OGSCatalogViewDateExpires = "DateExpires";
        public const string OGSCatalogViewPrice = "Price";
        public const string OGSCatalogViewIsActive = "IsActive";

        public const string OGSCatalogTypeTable = "OgsCatalogType";
        public const string OGSCatalogTypeTableAlias = "OGSCATTY";

        public const string OGSCatalogTypeId = "OgsCatalogTypeID";
        public const string OGSCatalogTypeName = "Name";

        public const string OGSCatalogStatusTable = "Status";
        public const string OGSCatalogStatusTableAlias = "ST";

        public const string OGSCatalogStatusId = "StatusID";
        public const string OGSCatalogStatusName = "Name";

        public const string OGSCatalogTable = "OgsCatalog";
        public const string OGSCatalogTableAlias = "OGSCAT";

        public const string OGSCatalogCatalogId = "OgsCatalogID";
        public const string OGSCatalogCatalogTypeId = "OgsCatalogTypeID";
        public const string OGSCatalogCreated = "DateCreated";
        public const string OGSCatalogUpdated = "DateUpdated";
        public const string OGSCatalogAvailable = "DateAvailable";
        public const string OGSCatalogExpires = "DateExpires";
        public const string OGSCatalogUnisonId = "UnisonID";
        public const string OGSCatalogDescription = "Description";
        public const string OGSCatalogFactor = "Factor";
        public const string OGSCatalogPrice = "Price";
        public const string OGSCatalogIsActive = "IsActive";
        public const string OGSCatalogFinalNasbaExpDate = "FinalNasbaExpDate";
        public const string OGSCatalogViewDescription = "Description";
        public const string OGSCatalogViewDateCreated = "DateCreated";
        public const string OgsCatalogViewCourseMetadataId = "CourseMetadataID";
        public const string OGSCatalogViewCatalogAcronym = "Acronym";
        #endregion

        #region Temp Owners Table, View & Fileds
        //public const string OgsInternalUsersTable = "Profile";
        //public const string OgsInternalUsersTableAlias = "PROFL";
        public const string OgsInternalUsersView = "vw_OgsInternalUsers";
        public const string OgsInternalUsersAlias = "vwInU";

        public const string OgsInternalUsersUserId = "OgsInternalUserID";
        public const string OgsInternalUsersName = "Name";
        public const string OgsInternalUsersEmail = "Email";
        public const string OgsInternalUsersFirstName = "FirstName";
        public const string OgsInternalUsersLastName = "LastName";

        #endregion

        #region ExamStatus Table & Fields
        public const string OgsExamStatusTable = "OgsExamStatus";
        public const string OgsExamStatusAlias = "EXST";

        public const string OgsExamStatusId = "OgsExamStatusID";
        public const string OgsExamStatusName = "Name";

        #endregion

        #region Ogs Exam View & Fields

        public const string OgsExamView = "vw_OgsExams";
        public const string OgsExamViewAlias = "EXVW";
        public const string RetireDateValidation = "Datediff(d,EXVW.RetiredDate,Getdate())<";
        public const string InactiveDateValidation = "Datediff(d,EXVW.InactiveDate,Getdate())<";
        public const string OgsExamViewAcronym = "Acronym";
        public const string OgsExamViewVersion = "VersionNumber";//Course meta data version umber
        public const string OgsExamViewCourseTitle = "CourseTitle";
        public const string OgsExamViewCourseMetadataId = "CourseMetadataID";
        public const string OgsExamViewOgsExamId = "OgsExamID";
        public const string OgsExamViewUnisonId = "UnisonID";
        public const string OgsExamViewDateUpdated = "DateUpdated";
        public const string OgsExamViewDateAvailable = "DateAvailable";
        public const string OgsExamViewDateExpires = "DateExpires";
        public const string OgsExamViewPassingGrade = "PassingGrade";
        public const string OgsExamViewAllowedAttempts = "AllowedAttempts";
        public const string OgsExamViewOwnerId = "OwnerID";
        public const string OgsExamViewOwnerName = "OwnerName";
        public const string OgsExamViewOgsExamStatusId = "OgsExamStatusID";
        public const string RetiredData = "RetiredDate";
        public const string OgsExamViewExamStatusName = "ExamStatusName";
        public const string OgsExamViewOgsCatalogId = "OgsCatalogID";
        public const string OgsExamViewBrandId = "BrandID";
        public const string OgsExamViewBrandName = "BrandName";
        public const string OgsExamViewNoOfQuestions = "NoOfQuestions";
        public const string OgsExamViewIsCatalogActive = "IsCatalogActive";
        public const string OgsExamViewPrice = "Price";
        public const string OgsExamViewBrandNamesAlias = "BrandNames";
        public const string OgsExamViewCourseBrandsAlias = "CourseBrandsAlias";
        public const string OgsExamViewDateCreated = "DateCreated";
        public const string OgsExamViewCourseDescription = "CourseDescription";
        #endregion

        #region Online Grading Exam Note Table & Fields
        public const string OgsExamNoteTable = "OgsExamNote";
        public const string OgsExamNoteAlias = "EXN";

        public const string OgsExamNoteId = "OgsExamNoteID";
        public const string OgsExamNoteDateCreated = "DateCreated";
        public const string OgsExamNoteExamId = "OgsExamID";
        public const string OgsExamNote = "Note";
        public const string OgsExamNoteUserId = "UserID";
        #endregion

        #region Online Grading OgsExamAnswerOption Table & Fields
        public const string OgsExamAnswerOptionTable = "OgsExamAnswerOption";
        public const string OgsExamAnswerOptionTableAlias = "ANSO";

        public const string OgsExamAnswerOptionName = "Name";
        #endregion

        #region OnlineGrading CourseMetadata Table & Fields
        public const string OGSCourseMetaDataTable = "CourseMetadata";
        public const string OGSCourseMetaDataTableAlias = "CORSMETA";
        public const string OgsCourseMetadataTitle = "Title";
        public const string OgsCourseMetadataId = "CourseMetadataID";


        #endregion

        #region Online Grading OgsExamAttemptAnswers Table & Fields

        public const string OgsExamAttemptAnswersTable = "OgsExamAttemptAnswer";
        public const string OgsExamAttemptAnswersTableAlias = "EAAN";

        public const string OgsExamAttemptAnswerId = "OgsExamAttemptAnswerID";
        public const string OgsExamAttemptAnswers = "OgsExamAttemptAnswers";

        #endregion

        #region Online Grading (Admin) Purchased Exams
        public const string OgsExamPurchasedInnerRow = "OgsExamInnerPurchasedRow";
        #endregion

        #region Online Grading vw_OgsExamAttemptDetails View Fields

        public const string OgsExamAttemptDetailsView = "vw_OgsExamAttemptDetails";
        public const string OgsExamAttemptDetailsViewAlias = "EADVW";

        public const string OgsExamAttemptDetailsViewOgsExamId = "OgsExamID";
        public const string OgsExamAttemptDetailsViewCourseMetadataId = "CourseMetadataID";
        public const string OgsExamAttemptDetailsViewCourseTitle = "CourseTitle";
        public const string OgsExamAttemptDetailsViewAcronym = "Acronym";
        public const string OgsExamAttemptDetailsViewAllowedAttempts = "AllowedAttempts";
        public const string OgsExamAttemptDetailsViewPassingGrade = "PassingGrade";
        public const string OgsExamAttemptDetailsViewProfessionalId = "ProfessionalID";
        public const string OgsExamAttemptDetailsViewLastAttemptId = "LastAttemptID";
        public const string OgsExamAttemptDetailsViewScore = "Score";
        public const string OgsExamAttemptDetailsViewDateCompleted = "DateCompleted";
        public const string OgsExamAttemptDetailsViewDateStarted = "DateStarted";
        public const string OgsExamAttemptDetailsViewUnisonId = "UnisonID";
        public const string OgsExamAttemptDetailsViewNoOfAttemptsCompleted = "NoOfAttempts";
        public const string OgsExamAttemptDetailsViewNoOfAnsweredQuestions = "NoOfAnsweredQuestions";
        public const string OgsExamAttemptDetailsViewDateAvailable = "DateAvailable";
        public const string OgsExamAttemptDetailsViewDateExpires = "DateExpires";

        #endregion

        #region Online Grading vw_OgsLastAttemptDetails View Fields

        public const string OgsLastAttemptDetailsView = "vw_OgsLastAttemptDetails";
        public const string OgsLastAttemptDetailsViewAlias = "ELADVW";
        public const string OgsLastAttemptDetailsViewOuterAlias = "ELOADVW";

        public const string OgsLastAttemptDetailsViewOgsExamId = "OgsExamID";
        public const string OgsLastAttemptDetailsViewCourseMetadataId = "CourseMetadataID";
        public const string OgsLastAttemptDetailsViewCourseTitle = "CourseTitle";
        public const string OgsLastAttemptDetailsViewAcronym = "Acronym";
        public const string OgsLastAttemptDetailsViewAllowedAttempts = "AllowedAttempts";
        public const string OgsLastAttemptDetailsViewPassingGrade = "PassingGrade";
        public const string OgsLastAttemptDetailsViewProfessionalId = "ProfessionalID";
        public const string OgsLastAttemptDetailsViewLastAttemptId = "LastAttemptID";
        public const string OgsLastAttemptDetailsViewScore = "Score";
        public const string OgsLastAttemptDetailsViewDateCompleted = "DateCompleted";
        public const string OgsLastAttemptDetailsViewDateStarted = "DateStarted";
        public const string OgsLastAttemptDetailsViewUnisonId = "UnisonID";
        public const string OgsLastAttemptDetailsViewNoOfAttempts = "NoOfAttempts";
        public const string OgsLastAttemptDetailsViewNoOfAnsweredQuestions = "NoOfAnsweredQuestions";
        public const string OgsLastAttemptDetailsViewLastAttemptOgsExamId = "OgsExamId";

        public const string OgsExamInnerPurchasedUnionQuery = "OgsExamInnerPurchasedUnionQuery";

        #endregion

        #region OgsExamAttempt Table & Fields

        public const string OgsExamAttemptTable = "OgsExamAttempt";
        public const string OgsExamAttemptTableAlias = "EA";

        public const string OgsExamAttemptId = "OgsExamAttemptID";
        public const string OgsExamAttemptOgsExamId = "OgsExamID";
        public const string OgsExamAttemptProfessionalId = "ProfessionalID";
        public const string OgsExamAttemptDateStarted = "DateStarted";
        public const string OgsExamAttemptDateCompleted = "DateCompleted";
        public const string OgsExamAttemptScore = "Score";

        #endregion

        #region Ogs Failed Exams View & Fields

        public const string OgsFailedExamsView = "vw_OgsFailedExams";
        public const string OgsFailedExamsViewAlias = "FEXVW";

        public const string OgsFailedExamsViewOgsExamId = "OgsExamID";
        public const string OgsFailedExamsViewProfessionalId = "ProfessionalID";
        public const string OgsFailedExamsViewOgsExamAttemptId = "OgsExamAttemptID";
        public const string OgsFailedExamsViewDateCompleted = "DateCompleted";

        public const string OgsFailedExamsFailedCount = "FailedCount";

        #endregion

        #region Online Grading Stored Procedures and Columns
        public const string OGSSPOGSGetExamDetailsforUnisonIds = "usp_OGSGetExamDetailsforUnisonIds";
        public const string OGSFirmAdminUnisonId = "UnisonId";
        public const string OGSFirmAdminStartRowNo = "StartRowNo";
        public const string OGSFirmAdminEndRowNo = "EndRowNo";
        public const string OGSFirmAdminNoRecords = "NoRecords";
        public const string OGSFirmAdminEndDate = "UserTime";
        #endregion

        #endregion

        #region ProfessionalEmail table & View Fields

        public const string ProfessionalEmailTable = "ProfessionalEmail";
        public const string ProfessionalEmailAlias = "PROEM";

        public const string ProfessionalEmailProfessionalId = "ProfessionalID";
        public const string ProfessionalEmailId = "ProfessionalEmailId";
        public const string ProfessionalEmailEmailTypeId = "ProfessionalEmailTypeId";
        public const string ProfessionalEmailEmailAddress = "EmailAddress";
        public const string ProfessionalEmailReminder = "Reminder";
        public const string ProfessionalEmailIsPrimary = "IsPrimary";

        #endregion

        #region ProfessionalAddress table & View Fields

        public const string ProfessionalAddressTable = "ProfessionalAddress";
        public const string ProfessionalAddressAlias = "PROAD";

        public const string ProfessionalAddressId = "ProfessionalAddressId";
        public const string ProfessionalAddressProfessionalId = "ProfessionalId";
        public const string ProfessionalAddressAddressTypeId = "ProfessionalAddressTypeId";
        public const string ProfessionalAddressAddress1 = "Address1";
        public const string ProfessionalAddressAddress2 = "Address2";
        public const string ProfessionalAddressCity = "City";
        public const string ProfessionalAddressState = "State";
        public const string ProfessionalAddressStateId = "StateId";
        public const string ProfessionalAddressZipCode = "ZipCode";
        public const string ProfessionalAddressCountryId = "CountryId";
        public const string ProfessionalAddressCountry = "Country";
        public const string ProfessionalAddressTimeZoneId = "TimeZoneID";

        #endregion

        #region ProfessionalPhone table & View Fields

        public const string ProfessionalPhoneTable = "ProfessionalPhone";
        public const string ProfessionalPhoneAlias = "PROPH";

        public const string ProfessionalPhoneId = "ProfessionalPhoneId";
        public const string ProfessionalPhoneProfessionalId = "ProfessionalId";
        public const string ProfessionalPhonePhoneTypeId = "ProfessionalPhoneTypeId";
        public const string ProfessionalPhonePhoneNumber = "PhoneNumber";
        public const string ProfessionalPhoneExtension = "Extension";
        public const string ProfessionalPhoneIsPrimary = "IsPrimary";

        #endregion

        #region Professional Salutation table & View Fields

        public const string ProfessionalSalutationTable = "ProfessionalSalutation";
        public const string ProfessionalSalutationAlias = "PROFSAL";

        public const string ProfessionalSalutationId = "ProfessionalSalutationID";
        public const string ProfessionalSalutationName = "Name";
        public const string ProfessionalSalutationAbbreviation = "Abbreviation";
        public const string ProfessionalSalutationStatusId = "StatusID";

        #endregion

        #region Proffesional Status table & view fields
        public const string ProfessionalStatusTable = "ProfessionalStatus";
        public const string ProffesionalStatusAlias = "PROS";

        public const string ProfessionalStatusId = "ProfessionalStatusID";
        public const string ProfessionalStatusName = "Name";
        public const string ProfessionalStatusStatusId = "StatusID";
        #endregion

        #region Professional Address Type table & view fields

        public const string ProfessionalAddressTypeTable = "ProfessionalAddressType";
        public const string ProfessionalAddressTypeAlias = "PROFADDTYPE";

        public const string ProfessionalAddressTypeId = "ProfessionalAddressTypeID";
        public const string ProfessionalAddressTypeName = "Name";
        public const string ProfessionalAddressTypeStatusId = "StatusID";

        #endregion

        #region Professional Email Type table & view fields

        public const string ProfessionalEmailTypeTable = "ProfessionalEmailType";
        public const string ProfessionalEmailTypeAlias = "PROFEMAILTYPE";

        public const string ProfessionalEmailTypeId = "ProfessionalEmailTypeID";
        public const string ProfessionalEmailTypeName = "Name";
        public const string ProfessionalEmailTypeStatusId = "StatusID";

        #endregion

        #region Professional Phone Type table & view fields

        public const string ProfessionalPhoneTypeTable = "ProfessionalPhoneType";
        public const string ProfessionalPhoneTypeAlias = "PROFPHONETYPE";

        public const string ProfessionalPhoneTypeId = "ProfessionalPhoneTypeID";
        public const string ProfessionalPhoneTypeName = "Name";
        public const string ProfessionalPhoneTypeStatusId = "StatusID";

        #endregion

        #region Professional Product Type table & view fields

        public const string ProfessionalProductTable = "ProfessionalProduct";
        public const string ProfessionalProductAlias = "PROFPROD";

        public const string ProfessionalProductId = "ProfessionalProductID";
        public const string ProfessionalProductName = "Name";
        public const string ProfessionalProductStatusId = "StatusID";

        #endregion

        #region Professional Security Question table & view fields

        public const string ProfessionalSecurityQuestionTable = "ProfessionalSecurityQuestion";
        public const string ProfessionalSecurityQuestionAlias = "PROFSECQUEST";

        public const string ProfessionalSecurityQuestionId = "ProfessionalSecurityQuestionID";
        public const string ProfessionalSecurityQuestionName = "Question";
        public const string ProfessionalSecurityQuestionStatusId = "StatusID";

        #endregion

        #region Professional Security Answer table & view fields

        public const string ProfessionalSecurityAnswerTable = "ProfessionalSecurityAnswer";
        public const string ProfessionalSecurityAnswerAlias = "PROFSECANSWER";

        public const string ProfessionalSecurityAnswerId = "ProfessionalSecurityAnswerID";
        public const string ProfessionalSecurityAnswerProfessionalId = "ProfessionalID";
        public const string ProfessionalSecurityAnswerQuestionId = "ProfessionalSecurityQuestionID";
        public const string ProfessionalSecurityAnswerAnswer = "SecurityAnswer";
        #endregion

        #region SharedSessionAuditLog table & View Fields

        public const string SharedSessionAuditLogTable = "SharedSessionAuditLog";
        public const string SharedSessionAuditLogAlias = "SAL";

        public const string SharedSessionAuditLogId = "SharedSessionAuditLogID";
        public const string SharedSessionAuditLogUserId = "UserID";
        public const string SharedSessionAuditLogOrganizationId = "OrganizationID";
        public const string SharedSessionAuditLogCPLApplicationId = "CPLApplicationID";
        public const string SharedSessionLogTypeId = "SharedSessionLogTypeID";
        public const string SharedSessionAuditLogGlobalSessionID = "GlobalSessionID";

        #endregion

        #region Professional Product Association table & view fields

        public const string ProfessionalProductAssociationTable = "ProfessionalProductAssociation";
        public const string ProfessionalProductAssociationAlias = "PROFPRODASSO";

        public const string ProfessionalProductAssociationId = "ProfessionalProductAssociationID";
        public const string ProfessionalProductAssociationProfessionalId = "ProfessionalID";
        public const string ProfessionalProductAssociationProfessionalProductId = "ProfessionalProductID";
        public const string ProfessionalProductAssociationUserName = "UserName";
        public const string ProfessionalProductAssociationPassword = "Password";

        #endregion

        #region Professional Membership Association table
        public const string ProfessionalMembershipAssociationTable = "ProfessionalMemberships";
        public const string MembershipAssociationTable = "Membership";
        public const string MembershipAssociationAlias = "MEM";
        public const string MembershipID = "MembershipID";
        public const string MembershipName = "Name";
        public const string ProfessionalMembershipAssociationAlias = "PROFMEMASSO";

        public const string ProfessionalMembershipAssociationId = "ID";
        public const string ProfessionalMembershipAssociationProfessionalId = "ProfessionalID";
        public const string ProfessionalMembershipAssociationProfessionalMembershipId = "MembershipIDValue";
        public const string ProfessionalMembershipAssociationMembershipName = "Membership";
        public const string ProfessionalMembershipAssociationMembershipID = "MembershipID";

        #endregion

        #region TabelOfContet Table & View Fields
        public const string TableOfContentTableView = "vw_TableOfContents";
        public const string TableOfContentTable = "TableOfContents";
        public const string TableOfContentAlias = "TOC";
        public const string Applied = "Applied";

        // Course List
        public const string TableOfContentID = "TableOfContentID";
        public const string TProductMetadataID = "ProductMetadataID";
        public const string TableOfContentLink = "TableOfContentLink";

        // Content List
        public const string TCourseId = "CourseID";
        public const string TCourseAcronym = "CourseAcronym";
        public const string TCourseTitle = "Title";

        #endregion

        #region Metadata Table & View Fields

        #region Status View

        public const string StatusData = "StatusData";
        public const string OnlineCourseStatus = "OnlineCourseStatus";

        public const string CourseStatusID = "CourseStatusID"; // Field #1 [Course Status] 
        public const string OnlineStatusID = "OnlineStatusID"; // Field #2 [Online Course Status dropdown]
        public const string OnlineHistroryNotes = "OnlineHistroryNotes"; // Field #3 [Online Course Historical Notes]
        public const string PublicationRevisionDate = "PublicationRevisionDate"; // Field #4 [Course Publication Revision Date]
        public const string VersionAvailableDate = "VersionAvailableDate"; // Field #5 [Version Availability Date]
        //public const string FinalNasbaExpDate = "FinalNasbaExpDate"; // Field #6 [Final NASBA Expiration Date]
        public const string AuthorContentRevisionDate = "AuthorContentRevisionDate"; // Field #7 [Author Content Revision Date]
        public const string GuideShipDate = "GuideShipDate"; // Field #8 [Guid Ship Date] (optional) 
        public const string InactiveDate = "InactiveDate"; // Field #9 [Inactive Date] (Reqwired if course status is inactive)   
        public const string LastFullReadDate = "LastFullReadDate"; // Field #10 [Date of Last Full Read]
        public const string LastFullReadByID = "LastFullReadByID"; // Field #11 [Full Read Done By] (Reqwired if date of Last Full Read is completed)
        public const string RecentChanges = "ChangesForNextPublication"; // Field #12 [Changes needed next for Publication]

        public const string OnlineCourseStatusID = "OnlineCourseStatusID";
        public const string OnlineCourseStatusName = "OnlineCourseStatusName";
        public const string FixedExpireDate = "FixedExpireDate";
        public const string FixedExpireUserID = "FixedExpireUserID";
        public const string IsOnlineGradingExam = "OnlineGradingExam";
        public const string RetiredDate = "RetiredDate";
        public const string RetiredUserID = "RetiredUserID";
        public const string MediaFormatCheckRetire = "MediaFormatCheckRetire";



        //public const string StatusID = "StatusID";
        //public const string Name = "Name";

        public const string IsFeatureComingSoon = "IsFeatureComingSoon";
        public const string IsIncludeIcon = "IsIncludeIcon";
        #endregion

        //added by Virtusa team
        #region LiveEventScheduleDay Table & Fields
        public const string LiveEventScheduleDayGetMaxNumberOfDaysQuery = "LiveEventScheduleDay";

        public const string LiveEventScheduleDayTable = "LiveEventScheduleDay";

        public const string ScheduleDayDayNo = "DayNo";
        public const string ScheduleDayCourseInstanceID = "CourseInstanceID";
        #endregion

        #region LiveEventSeminarTopic Table & Fields
        public const string LiveEventSeminarTopicGetMaxNumberOfDaysQuery = "LiveEventSeminarTopic";

        public const string LiveEventSeminarTopicTable = "LiveEventSeminarTopic";

        public const string SeminarTopicDayNo = "DayNo";
        #endregion


        #region CourseMetadata Table & Fields
        public const string CourseMetadataTable = "CourseMetadata";
        public const string VersionRevisionMappingTable = "VersionRevisionMapping";
        public const string CourseMetadataAlias = "CMA";
        public const string CourseMetadataCountAlias = "CMCA";
        public const string CourseMetadataID = "CourseMetadataID";
        public const string Acronym = "Acronym";
        public const string Title = "Title";
        public const string CurrentVersionNumber = "CurrentVersionNumber";
        public const string ShortDescription = "ShortDescription";
        public const string Description = "Description";
        public const string CourseSponsorID = "CourseSponsorID";
        public const string InteractiveLevelID = "InteractiveLevelID";
        public const string PrivateCourse = "PrivateCourse";
        public const string ClientName = "ClientName";
        public const string LogoPath = "LogoPath";
        public const string LearningObjectives = "LearningObjectives";
        public const string Supplements = "Supplements";
        public const string Outline = "Outline";
        public const string MainGlossaryPool = "MainGlossaryPool";
        public const string SubGlossaryPool = "SubGlossaryPool";
        public const string Prerequisites = "Prerequsites";
        public const string AdvancedPreparation = "AdvancedPreparation";
        public const string TechnicalRequirements = "TechnicalRequirements";
        public const string TechnicalSpecification = "TechnicalSpecification";
        public const string CourseGradingFee = "CourseGradingFee";
        public const string SeminarWebinarDescription = "SeminarWebinarDescription";
        public const string CertificationID = "CertificationID";
        public const string VersionNumber = "VersionNumber";
        public const string VersionNote = "VersionNote";
        public const string ReadyForPilotTesting = "ReadyForPilotTesting";
        public const string TargetPilotTestCompletionDate = "TargetPilotTestCompletionDate";
        public const string ActualPilotTestCompletionDate = "ActualPilotTestCompletionDate";
        public const string FinalNasbaExpDate = "FinalNasbaExpDate";
        public const string CourseMetadataImportedLiveEventID = "ImportedLiveEventID";

        // Registered Tax Return Perparers (CTEC Updates)
        public const string CtecCourse = "CtecCourse"; // Original code
        public const string CtecCourseNumber = "CtecCourseNumber"; // Original code
        public const string CtecMemberNumber = "CtecMemberNumber";
        public const string CtecFederalcCredits = "CtecFederalcCredits"; // Original code
        public const string CtecFederalNumber = "CtecFederalNumber";
        public const string CtecFederalTaxLawUpdateCredits = "CtecFederalTaxLawUpdateCredits";
        public const string CtecFederalTaxLawUpdateNumber = "CtecFederalTaxLawUpdateNumber";
        public const string CtecEthicsCredits = "CtecEthicsCredits";
        public const string CtecEthicsNumber = "CtecEthicsNumber";
        public const string CtecCaCredits = "CtecCaCredits"; // Original code
        public const string CtecCaNumber = "CtecCaNumber";

        // No changes for CFP			
        public const string CfpMemberNumber = "CfpMemberNumber";
        public const string CfpCourse = "CfpCourse";
        public const string CfpCourseNumber = "CfpCourseNumber";
        public const string CfpCredits = "CfpCredits";

        // Registered Tax Return Perparers (RTRP)
        public const string IrsMemberNumber = "IrsMemberNumber";
        public const string IrsCourse = "IrsCourse";
        public const string IrsRtrpCourse = "IrsRtrpCourse";
        public const string IrsEaCourse = "IrsEaCourse";
        public const string IrsRtrpEthicsCredits = "IrsRtrpEthicsCredits";
        public const string IrsRtrpFederalTaxUpdateCredits = "IrsRtrpFederalTaxUpdateCredits";
        public const string IrsRtrpFederalTaxCredits = "IrsRtrpFederalTaxCredits";
        public const string IrsRtrpTestPreparationCredits = "IrsRtrpTestPreparationCredits";
        public const string IrsEaEthicsCredits = "IrsEaEthicsCredits";
        public const string IrsEaFederalTaxMattersCredits = "IrsEaFederalTaxMattersCredits";
        public const string IrsRtrpEthicsNum = "IrsRtrpEthicsNum";
        public const string IrsRtrpFederalTaxUpdateNum = "IrsRtrpFederalTaxUpdateNum";
        public const string IrsRtrpFederalTaxNum = "IrsRtrpFederalTaxNum";
        public const string IrsRtrpTestPreparationNum = "IrsRtrpTestPreparationNum";
        public const string IrsEaEthicsNum = "IrsEaEthicsNum";
        public const string IrsEaFederalTaxMattersNum = "IrsEaFederalTaxMattersNum";
        public const string IrsCertificateStatement = "IrsCertificateStatement";
        public const string CtecCertificateStatement = "CtecCertificateStatement";
        public const string CfpCertificateStatement = "CfpCertificateStatement";
        public const string CfpCreditsOverRide = "CfpCreditsOverRide";
        public const string IrsRTRPStringConst = "IRS RTRP";
        public const string IrsEAStringConst = "IRS EA";
        public const string IRSNumber = "IRS Program #";
        public const string CTecCourseString = "CTEC Course #";
        public const string CtecString = "CTEC";
        public const string CfpString = "CFP";

        //public const string Transcripts = "Transcripts";
        public const string CourseMetadataStatusId = "CourseStatusID";
        public const string CourseMetadataLastModifiedDate = "LastModifiedDate";
        public const string CourseMetadataCourseURL = "CourseURL";

        public const string NasbaRegistry = "NasbaRegistry";
        public const string NasbaRegistryNumber = "NasbaRegistryNumber";
        public const string NasbaQas = "NasbaQas";
        public const string NasbaQasNumber = "NasbaQasNumber";
        public const string PilotTestCpeCreditTarget = "PilotTestCpeCreditTarget";

        public const string YellowBookQualify = "YellowBookQualify";

        public const string LastAuthorRevisionDate = "LastAuthorRevisionDate";
        public const string PermissionToRepublishID = "PermissionToRepublishID";
        public const string HistroryNotes = "HistroryNotes";
        public const string CopyRightNotes = "CopyRightNotes";

        public const string NasbaCredentialRequirement = "NasbaCredentialRequirement";
        public const string ContractRules = "ContractRules";
        public const string RoyaltyRules = "RoyaltyRules";
        public const string RoyaltyRates = "RoyaltyRates";
        public const string Notes = "Notes";

        public const string RoleID = "RoleID";
        public const string ResourceID = "ResourceID";
        public const string Name = "Name";
        public const string CourseMetadataBrandId = "BrandID";

        public const string CourseMetadataPassingGrade = "PassingGrade";
        public const string CourseMetadataAllowedAttempts = "AllowedAttempts";

        public const string CourseMetadataImportedLiveEventId = "ImportedLiveEventID";
        public const string CourseMetadataMarketingDescription = "MarketingDescription";
        public const string NoOfQuestionsPerCreditHour = "NoOfQuestionsPerCreditHour";
        public const string PercentageQuestionsToBeAnswered = "PercentageQuestionsToBeAnswered";
        // Coming soon
        public const string CurrentActiveVersion = "CurrentActiveVersion";
        #endregion

        #region CourseSponsor Table & Fields
        public const string CourseSponsor = "CourseSponsor";
        public const string CourseSponsorAlias = "CSP";
        public const string CourseSponsorTable = "CourseSponsor";


        #endregion

        #region CourseInteractivityLevel Table & Fields
        public const string CourseInteractivityLevel = "CourseInteractivityLevel";
        public const string CourseInteractivityLevelAlias = "CIL";
        public const string CourseInteractivityLevelTable = "CourseInteractivityLevel";
        public const string CourseInteractivityLevelID = "CourseInteractivityLevelID";
        public const string CourseInteractivityLevelName = "InteractiveLevelName";

        #endregion

        #region CourseInteractiveLearning Table & Fields
        public const string CourseInteractiveLearning = "CourseInteractiveLearning";
        public const string CourseInteractiveLearningAlias = "CIN";
        public const string CourseInteractiveLearningTable = "CourseInteractiveLearning";
        public const string InteractiveLearningID = "InteractiveLearningID";
        public const string InteractiveLearningName = "Name";


        #endregion

        #region CourseSponsorBrands Table & Fields
        public const string CourseSponsorBrands = "CourseSponsorBrands";
        public const string CourseSponsorBrandsAlias = "CSB";
        public const string CourseSponsorBrandsTable = "CourseSponsorBrands";
        public const string CourseSponsorBrandsID = "CourseSponsorBrandsID";

        #endregion

        #region CourseMetadataBrands Table & Fields

        public const string CourseMetadataBrandsTable = "CourseMetadataBrands";
        public const string CourseMetadataBrandsTableAlias = "CMDB";
        public const string CourseMetadataBrandsId = "CourseMetadataBrandsID";
        public const string CourseMetadataBrandsCourseMetadataId = "CourseMetadataID";
        public const string CourseMetadataBrandsBrandId = "BrandID";

        #endregion

        #region CourseMetadataParent Table & View Fields

        public const string CourseMetadataParent = "CourseMetadataParent";
        public const string CourseMetadataParentTable = "CourseMetadataParent";
        public const string CourseMetadataParentsView = "vw_CourseMetadataParents";
        public const string CourseMetadataParentsViewAlias = "CMP";
        public const string CourseParentID = "CourseParentID";
        public const string CourseMetadataParentID = "CourseMetadataParentID";
        public const string ParentAcronym = "ParentAcronym";
        public const string ParentTitle = "ParentTitle";
        public const string ChildAcronym = "ChildAcronym";
        public const string ChildTitle = "ChildTitle";

        public const string CourseMetadataChildrenView = "vw_CourseMetadataChildren";
        public const string CourseMetadataChildrenViewAlias = "CMC";

        #endregion

        #region MediaFormat Table & View Fields

        public const string MediaFormatView = "vw_MediaFormat";
        public const string MediaFormatViewAlias = "MFVA";



        #endregion

        #region Sponsor Level Memberships View Fields

        public const string SponsorLevelMembershipTable = "vw_CourseMetadataSponsorLevelMemberships";
        public const string SponsorLevelMembershipsAlias = "SLMA";
        public const string StateBoardMemberID = "StateBoardMemberID";
        public const string StateBoardStatement = "StateBoardStatement";
        public const string StateBoardCategoryID = "StateBoardCategoryID";
        public const string CategoryName = "CategoryName";
        public const string CourseMembershipNumber = "CourseMembershipNumber";
        public const string CourseSponsorStateBoardCreditID = "CourseSponsorStateBoardCreditID";

        public const string CourseSponsorStateBoardTable = "CourseSponsorStateBoard";
        public const string CourseSponsorStateBoardAlias = "CSSB";

        public const string StateBoardsTable = "StateBoards";
        public const string StateBoardID = "StateBoardID";
        public const string StateID = "StateID";
        public const string CountryID = "CountryID";
        public const string Abbreviation = "Abbreviation";
        public const string StateBoardsStateAbbreviation = "StateAbbreviation";
        public const string StateBoardsAbbreviation = "StateAbbreviation";

        public const string NasbaFosStateBoardCategoryTable = "NasbaFosStateBoardCategory";
        public const string NasbaFosStateBoardCategoryAlias = "NFSBC";
        public const string NasbaFosStateBoardCategoryID = "NasbaFosStateBoardCategoryID";
        public const string NasbaFosID = "NasbaFosID";

        #endregion

        #region Course Level Memberships View Fields

        public const string CourseLevelMembershipTable = "vw_CourseMetadataCourseLevelMemberships";
        public const string CourseLevelMembershipsAlias = "SMA";
        public const string CourseLevelMembershipsList = "CourseLevelMembershipsList";
        public const string CourseStateBoardCreditID = "CourseStateBoardCreditID";
        public const string SponsorMembershipNumber = "SponsorMembershipNumber";
        public const string CertificateStatement = "CertificateStatement";

        #endregion

        #endregion

        #region Email Template Table & View Fields

        public const string EmailTemplateTable = "EmailTemplate";
        public const string EmailTemplateAlias = "ET";

        public const string EmailTemplateId = "EmailTemplateID";
        public const string EmailTemplateName = "Name";
        public const string EmailTemplateCreated = "Created";
        public const string EmailTemplateUpdated = "Updated";
        public const string EmailTemplateSenderId = "EmailSenderID";
        public const string EmailTemplateStatusId = "StatusID";
        public const string EmailTemplateSubject = "Subject";
        public const string EmailTemplateBody = "Body";
        public const string EmailTemplateModuleId = "ModuleID";

        #endregion

        #region Email EmailSender Table & View Fields

        public const string EmailSenderTable = "EmailSender";
        public const string EmailSenderTableAlias = "ESA";

        public const string EmailSenderID = "EmailSenderID";
        public const string EmailSenderFromName = "FromName";
        public const string EmailSenderFromEmail = "FromEmail";
        public const string EmailSenderReplyEmail = "ReplyEmail";
        public const string EmailSenderSignature = "Signature";

        #endregion

        #region Course Instance table & Fields

        public const string CourseInstanceTable = "CourseInstance";
        public const string CourseInstanceAlias = "CI";
        public const string CourseInstanceProductMetadataId = "CourseMetadataID";
        public const string CourseInstanceMediaFormatId = "MediaFormatID";
        public const string CourseInstanceUnisionId = "UnisonID";
        public const string CourseInstanceId = "id";
        public const string CourseInstanceMediaFormatsView = "vw_CourseInstance_MediaFormats";
        public const string CourseInstanceMediaFormatsViewAlias = "CIMF";
        public const string Price = "Price";
        public const string FileDownloadPath = "FileDownloadPath";
        //added by Virtusa team to meet new requirement
        public const string IsCreditApplied = "IsCreditApplied";
        public const string CourseInstanceCollegeId = "college";
        public const string CourseInstanceTitle = "Title";
        public const string CourseInstanceFormat = "format";
        public const string CourseInstanceCourse = "course";
        public const string CourseInstanceCode = "code";//Acronym of courseMetaData table
        public const string CourseInstanceApproval = "approval";//approval status of courseInstance table

        public const string StartDate = "[start]";
        public const string EndDate = "[end]";

        #endregion

        #region Special course Metadata fields

        public const string PlayerDemoChapters = "PlayerDemoChapters";
        public const string PlayerExamPosition = "PlayerExamPosition";
        public const string PlayerSuppressRemediation = "PlayerSuppressRemediation";
        public const string PlayerTitleImagePath = "PlayerTitleImagePath";
        public const string PlayerWelcomeImagePath = "PlayerWelcomeImagePath";
        public const string PlayerCourseInfoImagePath = "PlayerCourseInfoImagePath";

        #endregion

        #region ReqwiredTimeZoneMap table & fields
        public const string ReqwiredTimeZoneMapTable = "ReqwiredTimeZoneMap";
        public const string ReqwiredTimeZoneMapTableAlias = "RTZMap";

        public const string ReqwiredTimeZoneMapTimeZoneID = "TimeZoneID";
        public const string ReqwiredTimeZoneMapReqwiredTimeZoneCodeID = "ReqwiredTimeZoneCodeID";
        #endregion

        #region ReqwiredTimeZoneCode table & fields
        public const string ReqwiredTimeZoneCodeTable = "ReqwiredTimeZoneCode";
        public const string ReqwiredTimeZoneCodeTableAlias = "RTZCode";

        public const string ReqwiredTimeZoneCodeReqwiredTimeZoneCodeID = "ReqwiredTimeZoneCodeID";
        public const string ReqwiredTimeZoneCodeReqwiredCode = "Code";
        #endregion

        #region Profile table & fields
        public const string ProfileTable = "Profile";
        public const string ProfileTableAlias = "PRF";

        public const string ProfileId = "ProfileId";
        public const string ProfileRoleId = "RoleId";
        public const string ProfileUID = "UID";
        public const string ProfileEmail = "Email";
        public const string ProfileGivenName = "GivenName";
        public const string ProfileSurname = "Surname";
        public const string ProfileTelephoneNumber = "TelephoneNumber";
        public const string ProfileTitle = "Title";
        public const string ProfileDeptID = "DeptID";
        public const string ProfileSupervisorID = "SupervisorID";
        public const string ProfileCompanyDescOverride = "CompanyDescOverride";
        public const string ProfileActive = "Active";

        #region CourseEvaluationAnswer table & Fields
        public const string CourseEvaluationAnswerTable = "CourseEvaluationAnswer";
        public const string CourseEvaluationAnswerTableAlias = "CEvalAns";

        public const string CourseEvaluationAnswerID = "CourseEvaluationAnswerID";
        public const string CourseEvaluationAnswerCourseEvaluationID = "CourseEvaluationID";
        public const string CourseEvaluationAnswerQuestion = "Question";
        public const string CourseEvaluationAnswerOption = "AnswerOption";
        #endregion

        #region CourseEvaluation table & Fields
        public const string CourseEvaluationTable = "CourseEvaluation";
        public const string CourseEvaluationTableAlias = "CEval";

        public const string CourseEvaluationID = "CourseEvaluationID";
        public const string CourseEvaluationCourseInstanceID = "CourseInstanceID";
        public const string CourseEvaluationProfessionalID = "ProfessionalID";
        public const string CourseEvaluationOrganizationEvaluationFormID = "OrganizationEvaluationFormID";
        public const string CourseEvaluationComment = "Comment";
        public const string CourseEvaluationDateSubmitted = "DateSubmitted";

        #endregion

        #region ActivityRegulatorCredit table & Fields
        public const string ActivityRegulatorCreditTable = "ActivityRegulatorCredit";
        public const string ActivityRegulatorCreditTableAlias = "ActRegCredit";

        public const string ActivityRegulatorCreditActivityRegulatorCreditID = "ActivityRegulatorCreditID";
        public const string ActivityRegulatorCreditActivityID = "ActivityID";
        public const string ActivityRegulatorCreditRegulatorID = "RegulatorID";
        public const string ActivityRegulatorCreditCategory = "Category";
        public const string ActivityRegulatorCreditCredits = "Credits";
        #endregion

        #region Course Graphic Table & Fields
        //public const string CourseGraphicTable = "CourseGraphic";
        //public const string CourseGraphicAlias = "CGA";
        //public const string CourseGraphicID = "CourseGraphicID";
        //public const string ExampleGraphicPath = "ExampleGraphicPath";

        #endregion

        #region

        public const string CourseSponsorStateBoardCreditsTable = "CourseSponsorStateBoardCredits";
        public const string CourseSponsorStateBoardCreditsAlias = "CSBC";
        public const string CourseSponsorStateBoardCreditId = "CourseSponsorStateBoardCreditID";
        public const string CourseSponsorStateBoardID = "CourseSponsorStateBoardID";
        public const string StateBoardId = "StateBoardID";
        public const string StateBoardCategoryId = "StateBoardCategoryID";
        public const string StateBoardCredits = "StateBoardCredits";

        public const string StateBoardCategoryTabel = "StateBoardCategory";
        public const string StateBoardCategoryAlias = "SBC";
        public const string StateBoardCategoryStateFoSView = "vw_StateBoardCategoryStateFoS";
        public const string CourseStateBoardCreditsTable = "CourseStateBoardCredits";
        public const string CourseStateBoardCreditsAlias = "CSTB";

        #endregion

        #endregion

        #region NASBAReport Table & Fields
        public const string NASBAReportView = "vw_NASBAReport_PilotTest";
        public const string NASBAReportViewAlias = "VWNR";

        public const string NASBAReportViewProductMetadataId = "ProductMetadataID";
        public const string NASBAReportViewCourseId = "CourseId";
        //public const string NASBAReportViewPublicationRevisionDate = "PublicationRevisionDate";
        public const string NASBAReportViewVersionAvailableDate = "VersionAvailableDate";
        public const string NASBAReportViewInactiveDate = "InactiveDate";
        public const string NASBAReportViewBrandID = "BrandID";
        public const string NASBAReportViewFieldOfStudyNames = "FieldOfStudyNames";
        public const string NASBAReportViewTitle = "Title";
        public const string NASBAReportViewCourseStatusId = "CourseStatusID";
        public const string NASBAReportViewPilotTestStatusID = "PilotTestStatusID";
        public const string NASBAReportViewPilotTestCourseStatus = "PilotTestCourseStatus";
        public const string NASBAReportViewClosedDate = "ClosedDate";
        public const string NASBAReportViewCourseStatus = "CourseStatus";
        public const string NASBAReportViewBrandName = "BrandName";
        public const string NASBAReportViewNasbaCredits = "NasbaCredits";
        public const string NASBAReportQueryAlias = "NASBAReportQueryAlias";
        #endregion

        #region Pilot Test Table & View Fields
        public const string PilotTestView = "vw_PilotTest";
        public const string PilotTestViewAlias = "PTVW";
        #endregion


        #region Oracle a_package table & Fields
        public const string Package = "a_package";
        public const string PackageTable = "checkpoint.a_package";
        public const string PackageTableAlias = "PKG";
        public const string PackagePackageId = "package_id";
        public const string PackagePackageType = "PACKAGE_TYPE";
        public const string PackagePackageCode = "PACKAGE_CODE";
        public const string PackagePackageName = "PACKAGE_NAME";
        public const string PackagePackageNameShort = "package_name_short";
        public const string PackageGlobalWhereClause = "package_type = 12 and is_cpl_bundle = 'L' and is_usage = 'N' and is_accountlevel = 'N'";
        public const string PackageIsCplBundle = "IS_CPL_BUNDLE";
        public const string BundlePackageIdentifire = "N";

        //This will used to retrive order information
        public const string PackageGlobalWhereClauseForOrder = "package_type = 12 orders1_.END_DATE>=sysdat";
        #endregion

        #region Oracle a_package_ext table & Fields
        public const string PackageExtensionTable = "checkpoint.a_package_ext";
        public const string PackageExtensionTableAlias = "PACK_EXT";
        public const string PackageExtensionTablePackageId = "package_id";
        public const string PackageExtensionMarketingDescriptionNotes = "marketing_description_notes";
        #endregion

        #region Oracle cpl_package table & Fields
        public const string CplPackageTable = "checkpoint.CPL_PACKAGE";
        public const string CplPackageTableAlias = "CPLPKG";
        public const string CplPackagePackageId = "PACKAGE_ID";
        public const string CplPackageCplId = "CPL_ID";

        #endregion

        #region Oracle cpl_bundle table & Fields
        public const string CplBundleTable = "checkpoint.cpl_bundle";
        public const string CplBundleTableAlias = "CPLB";
        public const string CplBundlePackageId = "package_id";
        public const string CplBundleCplId = "cpl_id";

        #endregion

        #region Oracle cpl table & Fields
        public const string CplTable = "checkpoint.cpl";
        public const string CplTableAlias = "CPL";
        public const string CplCplId = "cpl_id";
        public const string CplCplCode = "cpl.cpl_code";
        public const string CplCplShortName = "cpl.cpl_short_name";

        #endregion

        #region Nasba Fos

        public const string CourseNASBACertificationView = "vw_CourseNASBACertification";
        public const string CourseNASBACertificationAlias = "CNASB";

        public const string NasbaFOSID = "NasbaFOSID";

        public const string CourseNasbaID = "CourseNasbaID";
        public const string NasbaCredits = "NasbaCredits";

        #endregion

        #region Pilot Test CPE Credits View & Fields
        public const string PilotTestCPECreditsView = "vw_PilotTestCPECredits";
        public const string PilotTestCPECreditsViewAlias = "CPEC";

        public const string PilotTestCourseMetadataID = "CourseMetadataID";
        public const string PilotTestCPECredits = "CPECredits";
        public const string PilotTestCPECreditsId = "id";
        public const string PilotTestCompletionDate = "CompletionDate";
        public const string CPECredits = "CPECredits";

        #endregion

        #region PilotTest View Fields
        public const string PilotTestViewCourseId = "pilottestcourseid";
        public const string PilotTestViewCourseTitle = "pilottestcoursetitle";
        public const string PilotTestViewTargetCompletionDate = "PilotTestTargetCompletionDate";
        public const string PilotTestViewTargetCPCredit = "PilotTestTargetCPCredit";
        public const string PilotTestViewFieldOfStudy = "pilottestfieldofstudy";
        public const string PilotTestViewProductDeliveryFormatId = "productdeliveryformatid";
        public const string PilotTestViewPilotTestId = "pilottestid";
        public const string PilotTestViewCPECredits = "pilottestcpecredits";
        public const string PilotTestViewCreditIssuedDate = "CreditIssuedDate";
        public const string PilotTestViewDeadline = "PilotTestDeadline";
        public const string PilotTestViewNextPilotTestDueDate = "PilotTestNextPilotTestDueDate";
        public const string PilotTestViewPilotTestStatusId = "PilotTestStatusId";
        public const string PilotTestViewPilotTestStatus = "PilotTestStatus";
        public const string PilotTestViewBrandName = "PilotTestBrandName";

        #endregion

        #region Data Migration
        public const string DataMigrationQueryAlias = "DataMigrationInnerQuery";
        public const string MigrationInnerQueryAlias = "MigrationInnerQuery";

        #region DataMigrationJob Table
        public const string DataMigrationJobTable = "DataMigrationJob";
        public const string DataMigrationJobTableAlias = "DMJ";

        public const string DataMigrationJobId = "DataMigrationJobID";
        public const string DataMigrationJobDataMigrationJobStatusId = "DataMigrationJobStatusID";
        public const string DataMigrationJobTitle = "Title";
        public const string DataMigrationJobRequestedTime = "RequestedTime";
        public const string DataMigrationJobStartedTime = "StartedTime";
        public const string DataMigrationJobLastModifiedTime = "LastModifiedTime";
        public const string DataMigrationJobProperties = "Properties";
        #endregion DataMigrationJob Table = "";

        #region DataMigrationJobStatus Table
        public const string DataMigrationJobStatusTable = "DataMigrationJobStatus";
        public const string DataMigrationJobStatusAlias = "DMJS";

        public const string DataMigrationJobStatusDataMigrationJobStatusId = "DataMigrationJobStatusID";
        public const string DataMigrationJobStatusName = "Name";
        #endregion DataMigrationJobStatus Table

        #region DataMigrationLog table
        public const string DataMigrationLogTable = "DataMigrationLog";
        public const string DataMigrationLogAlias = "DMLG";

        public const string DataMigrationLogDataMigrationLogID = "DataMigrationLogID";
        public const string DataMigrationLogDataMigrationLogTypeID = "DataMigrationLogTypeID";
        public const string DataMigrationLogMessage = "Message";
        public const string DataMigrationLogTechnicalDetails = "TechnicalDetails";
        public const string DataMigrationLogCreatedTime = "CreatedTime";
        public const string DataMigrationLogDataMigrationJobID = "DataMigrationJobID";
        public const string DataMigrationLogDataMigrationTaskID = "DataMigrationTaskID";
        #endregion DataMigartionlog table

        #region DataMigrationLogType Table
        public const string DataMigrationLogTypeTable = "DataMigrationLogType";
        public const string DataMigrationLogTypeAlias = "DMLT";

        public const string DataMigrationLogTypeID = "DataMigrationLogTypeID";
        public const string DataMigrationLogType = "Name";
        #endregion DataMigrationLogType Table

        #region DataMigrationTask Table
        public const string DataMigrationTaskTable = "DataMigrationTask";
        public const string DataMigrationTaskTableAlias = "DMTS";

        public const string DataMigrationTaskID = "DataMigrationTaskID";
        public const string DataMigrationTaskJobID = "DataMigrationJobID";
        public const string DataMigrationTaskTaskDefinitionID = "DataMigrationTaskDefinitionID";
        public const string DataMigrationTaskProfessionalProductID = "ProfessionalProductID";
        public const string DataMigrationTaskTitle = "Title";
        public const string DataMigrationTaskSequanceNo = "SequanceNo";
        public const string DataMigrationTaskProperties = "Properties";
        public const string DataMigrationTaskStartedTime = "StartedTime";
        public const string DataMigrationTaskLastModifiedTime = "LastModifiedTime";
        public const string DataMigrationTaskParentReferenceID = "ParentReferenceID";
        public const string DataMigrationTaskReferenceID = "ReferenceID";
        public const string DataMigrationTaskTaskStatusID = "DataMigrationTaskStatusID";


        #endregion

        #region DataMigrationDefinition Table
        public const string DataMigrationTaskDefinitionTable = "DataMigrationTaskDefinition";
        public const string DataMigrationTaskDefinitionTableAlias = "DMTD";

        public const string DataMigrationTaskDefinitionID = "DataMigrationTaskDefinitionID";
        public const string DataMigrationTaskDefinitionUnityID = "UnityID";
        public const string DataMigrationTaskDefinitionStatusID = "StatusID";
        #endregion

        #region DataMigrationDataExtract Table
        public const string DataMigrationDataExtractTable = "DataMigrationDataExtract";
        public const string DataMigrationDataExtractTableAlias = "DMDE";

        public const string DataMigrationDataExtractProfessionalID = "ProfessionalID";
        public const string DataMigrationDataExtractProfessionalProductID = "ProfessionalProductID";
        public const string DataMigrationDataExtractData = "Data";
        public const string DataMigrationDataExtractDataMigrationDataExtractProcessStatusID = "DataMigrationDataExtractProcessStatusID";
        #endregion

        #region DataMigrationIPJob Table
        public const string DataMigrationIPJobTable = "DataMigrationIPJob";
        public const string DataMigrationIPJobTableAlias = "DMIPJ";

        public const string DataMigrationIPJobDataMigrationJobId = "DataMigrationJobID";
        public const string DataMigrationIPJobProfessionalId = "ProfessionalID";
        #endregion

        #region DataMigrationJobQueue
        public const string DataMigrationJobQueueTable = "DataMigrationJobQueue";
        public const string DataMigrationJobQueueTableAlias = "DMJQ";

        public const string DataMigrationJobQueueID = "DataMigrationJobQueueID";
        public const string DataMigrationJobQueuePriority = "Priority";
        public const string DataMigrationJobQueueCreatedTime = "CreatedTime";
        public const string DataMigrationJobQueueDataMigrationJobID = "DataMigrationJobID";
        public const string DataMigrationJobQueueDataMigrationTaskReferenceId = "DataMigrationTaskReferenceID";
        public const string DataMigrationJobQueueIsRetry = "IsRetry";
        public const string DataMigrationJobQueueBookmark = "Bookmark";
        public const string DataMigrationJobQueueStatusID = "StatusID";
        #endregion

        #region Firm Migration

        #region Stored Procedure names

        //Save activity stored procedure name
        public const string SaveMicroMashPassonlineDataStoredProcedureName = "sp_rqwd_professional_activity_add_ip_migration";

        //Save activityCertificate stored procedure name
        public const string InsertProfessionalDetailsStoredProcedureName = "usp_DataMigrationInsertProfessionalDetails";
        public const string ActivityCertificateAssociationAddStoredProcedureName = "sp_rqwd_certificate_activity_association_add";
        public const string CertificateProfileAddStoredProcedureName = "sp_rqwd_ceprofile_add";
        public const string FirmAddStoredProcedureName = "sp_rqwd_organization_account_create";
        public const string NonReqwiredFirmAddStoredProcedureName = "usp_FirmMigrationCreateNoneReqwiredOrganization";
        public const string FirmProfessionalAddStoredProcedureName = "sp_rqwd_professional_account_create";
        public const string ProfessionalAddressAddStoredProcedureName = "HaveToCreateSP";
        public const string UpdateDataMigrationLogStoredProcedureName = "usp_UpdateDataMigrationLog";
        public const string DataMigrationFirmEnableStoredProcudureName = "sp_rqwd_organization_account_enable";
        public const string OrganizationAdministratorCreateStoredProcedureName =
          "sp_rqwd_organization_administrator_account_create";

        public const string NonReqwiredOrganizationAdministratorCreateStoredProcedureName =
          "usp_FirmMigrationCreateNoneReqwiredOrganizationAdministrator";


        public const string DataMigrationEmployeeDetailsByEmailStoredProcedureName = "usp_GetDataMigrationEmployeeDetailsByEmail";

        #endregion // Stored Procedure names

        #region Stored Procedure parameters

        #region DataMigrationDataTransferSP
        public const string DataMigrationDataTransferSPJobId = "JobID";
        public const string DataMigrationDataTransferSPTaskId = "TaskID";
        public const string DataMigrationDataTransferSPOrganizationId = "FirmId";
        #endregion

        #region DataMigrationInsertProfessionalDetailsSP
        public const string DataMigrationFirmProfessionalDetails = "professionals";
        public const string DataMigrationFirmActivitiesDetails = "activities";
        public const string DataMigrationInsertProfessionalDetailsJobId = "JobId";
        public const string DataMigrationInsertProfessionalDetailsTaskId = "TaskId";
        #endregion

        #region UpdateDataMigrationLogStoredProcedureName
        public const string UpdateDataMigrationLogStoredProcedureLogTypeID = "LogTypeID";
        public const string UpdateDataMigrationLogStoredProcedureMessage = "Message";
        public const string UpdateDataMigrationLogStoredProcedureTechnicalDetails = "TechnicalDetails";
        public const string UpdateDataMigrationLogStoredProcedureJobID = "JobID";
        public const string UpdateDataMigrationLogStoredProcedureTaskID = "TaskID";
        #endregion

        #region OrganizationAccountEnable
        public const string OrganizationIdParameter = "id";
        public const string OrganizationEnableParameter = "enable ";
        #endregion

        #region OrganizationAdministratorCreate
        public const string OrganizationAdministratorUserNameParameter = "username";
        public const string OrganizationAdministratorPasswordParameter = "password";
        public const string OrganizationAdministratorNameParameter = "name";
        public const string OrganizationAdministratorEmailParameter = "email";
        public const string OrganizationAdministratorMasterAdminParameter = "master_admin";
        public const string OrganizationAdministratorUnivercityAdminParameter = "university_admin";
        public const string OrganizationAdministratorEmployeeAdminParameter = "employee_admin";
        public const string OrganizationAdministratorComplinceAdminParameter = "compliance_admin";
        public const string OrganizationAdministratorCoachParameter = "coach";
        public const string OrganizationAdministratorPreferenceParameter = "preference";
        public const string OrganizationAdministratorSignatureParameter = "signature";
        public const string OrganizationAdministratorOrganizationIdParameter = "organization";
        public const string OrganizationAdministratorKeyParameter = "key";
        #endregion

        #region InvokeCPLProductionFirmMigrationSSIS
        public const string InvokeCPLProductionFirmMigrationSSISJobName = "job_name";
        #endregion

        #region GetDataMigrationEmployeeDetailsByEmail
        public const string DataMigrationEmployeeDetailsByEmailEmailParameterName = "EmailAddresses";
        #endregion

        #endregion //End of Stored Procedure parameters

        #region DataMigrationDataTransferTask Table
        public const string DataMigrationDataTransferTaskTable = "DataMigrationDataTransferTask";
        public const string DataMigrationDataTransferTaskTableAlias = "DMDTT";

        public const string DataMigrationDataTransferTaskId = "DataMigrationDataTransferTaskID";
        public const string DataMigrationDataTransferTaskJobId = "DataMigrationJobID";
        public const string DataMigrationDataTransferTaskTaskId = "DataMigrationTaskID";
        public const string DataMigrationDataTransferTaskOrganizationId = "OrganizationID";
        public const string DataMigrationDataTransferTaskJobQueId = "DataMigrationJobQueID";
        public const string DataMigrationDataTransferTaskTransferStepId = "DataMigrationDataTransferStepID";
        public const string DataMigrationDataTransferTaskTransferStatusId = "DataMigrationDataTransferStatusID";
        #endregion // DataMigrationDataTransferTask Table

        #region Data Migration FirmJob
        public const string DataMigrationFirmJobTable = "DataMigrationFirmJob";
        public const string DataMigrationFirmJobTableAlias = "DMFJ";

        public const string DataMigrationFirmJobJobId = "DataMigrationJobID";
        public const string DataMigrationFirmJobPreferredMigrationDate = "PreferredMigrationDate";
        public const string DataMigrationFirmJobUnderTechnicalHandling = "UnderTechnicalHandling";
        public const string DataMigrationFirmJobUnitNumber = "UnitNumber";

        #endregion

        #region DataMigrationFirmTechnicalNotes Table

        public const string DataMigrationFirmTechnicalNotesTable = "DataMigrationFirmTechnicalNotes";
        public const string DataMigrationFirmTechnicalNotesTableAlias = "DMFTN";

        public const string DataMigrationFirmTechnicalNotesDataMigrationFirmTechnicalNotesId = "DataMigrationFirmTechnicalNotesID";
        public const string DataMigrationFirmTechnicalNotesDataMigrationJobId = "DataMigrationJobID";
        public const string DataMigrationFirmTechnicalNotesTechnicalNote = "TechnicalNote";
        public const string DataMigrationFirmTechnicalNotesCreateDate = "CreateDate";

        #endregion

        #region DataMigrationFirmCoordinator Table
        public const string DataMigrationFirmCoordinatorTable = "DataMigrationFirmCoordinator";
        public const string DataMigrationFirmCoordinatorTableAlias = "DMFC";

        public const string DataMigrationFirmCoordinatorJobId = "DataMigrationJobID";
        public const string DataMigrationFirmCoordinatorName = "Name";
        public const string DataMigrationFirmCoordinatorEmail = "Email";
        public const string DataMigrationFirmCoordinatorPhone = "Phone";
        #endregion

        #region DataMigrationMicroMashFirmDetails table
        public const string DataMigrationMicroMashFirmDetailsTable = "DataMigrationMicroMashFirmDetails";
        public const string DataMigrationMicroMashFirmDetailsTableAlias = "MMFD";

        public const string DataMigrationMicroMashFirmDetailsId = "DataMigrationMicroMashFirmDetailsID";
        public const string DataMigrationMicroMashFirmDetailsJobId = "DataMigrationJobID";
        public const string DataMigrationMicroMashFirmDetailsSubscriptionTypeId = "DataMigrationMicroMashSubscriptionTypeID";
        public const string DataMigrationMicroMashFirmDetailsFirmId = "FirmID";
        public const string DataMigrationMicroMashFirmDetailsUserEmail = "UserEmail";
        public const string DataMigrationMicroMashFirmDetailsImportedData = "ImportedData";
        public const string DataMigrationMicroMashFirmDetailsCompanyType = "CompanyType";
        public const string DataMigrationMicroMashFirmDetailsProductCode = "ProductCode";
        public const string DataMigrationMicroMashFirmDetailsExpiryDate = "ExpiryDate";
        public const string DataMigrationMicroMashFirmDetailsUnitNumber = "UnitNumber";
        public const string DataMigrationMicroMashFirmDetailsDataMigrationJobID = "DataMigrationJobID";

        #endregion

        #region DataMigrationReqwired3DFirmDetails table
        public const string DataMigrationReqwired3DFirmDetailsTable = "DataMigrationReqwired3DFirmDetails";
        public const string DataMigrationReqwired3DFirmDetailsTableAlias = "RDFD";

        public const string DataMigrationReqwired3DFirmDetailsId = "DataMigrationReqwired3DFirmDetailsID";
        public const string DataMigrationReqwired3DFirmDetailsJobId = "DataMigrationJobID";
        public const string DataMigrationReqwired3DFirmDetailsOrganizationId = "OrganizationID";
        public const string DataMigrationReqwired3DFirmDetailsFirmName = "FirmName";
        public const string DataMigrationReqwired3DFirmDetailsFreeAdminName = "FreeAdminName";
        public const string DataMigrationReqwired3DFirmDetailsAdministrators = "Administrators";
        #endregion

        #region DataMigrationPassOnlineFirmDetails table
        public const string DataMigrationPassOnlineFirmDetailsTable = "DataMigrationPassOnlineFirmDetails";
        public const string DataMigrationPassOnlineFirmDetailsTableAlias = "POFD";

        public const string DataMigrationPassOnlineFirmDetailsId = "DataMigrationPassOnlineFirmDetailsID";
        public const string DataMigrationPassOnlineFirmDetailsJobId = "DataMigrationJobID";
        public const string DataMigrationPassOnlineFirmDetailsLoginProcessId = "DataMigrationPassOnlineLoginProcessID";
        public const string DataMigrationPassOnlineFirmDetailsSubscriptionTypeId = "DataMigrationPassOnlineSubscriptionTypeID";
        public const string DataMigrationPassOnlineFirmDetailsFirmId = "FirmID";
        public const string DataMigrationPassOnlineFirmDetailsFirmName = "FirmName";
        public const string DataMigrationPassOnlineFirmDetailsUserId = "UserID";
        public const string DataMigrationPassOnlineFirmDetailsUserEmail = "UserEmail";
        public const string DataMigrationPassOnlineFirmDetailsImportedData = "ImportedData";

        #endregion

        #region DataMigrationCrticalSection table
        public const string DataMigrationCrticalSectionTable = "DataMigrationCrticalSection";
        public const string DataMigrationCrticalSectionTableAlias = "DMCS";

        public const string DataMigrationCrticalSectionId = "DataMigrationCrticalSectionID";
        public const string DataMigrationCrticalSectionName = "Name";
        public const string DataMigrationCrticalSectionDataMigrationJobId = "DataMigrationJobID";
        public const string DataMigrationCrticalSectionWaitingQueue = "WaitingQueue";
        #endregion

        #region DataMigrationFirmAdministrator
        public const string DataMigrationFirmAdministratorTable = "DataMigrationFirmAdministrator";
        public const string DataMigrationFirmAdministratorTableAlias = "DMFA";

        public const string DataMigrationFirmAdministratorJobId = "DataMigrationJobID";
        public const string DataMigrationFirmAdministratorName = "Name";
        public const string DataMigrationFirmAdministratorUserName = "UserName";
        public const string DataMigrationFirmAdministratorPassword = "Password";
        public const string DataMigrationFirmAdministratorEmail = "Email";
        #endregion

        #region DataMigrationFirmDetails
        public const string DataMigrationFirmDetailsTable = "DataMigrationFirmDetails";
        public const string DataMigrationFirmDetailsTableAlias = "DMFD";

        public const string DataMigrationFirmDetailsJobId = "DataMigrationJobID";
        public const string DataMigrationFirmDetailsUserName = "FirmUserName";
        public const string DataMigrationFirmDetailsSecretKey = "SecretKey";
        public const string DataMigrationFirmDetailsUnitNumber = "UnitNumber";
        public const string DataMigrationFirmDetailsShipToAddressId = "ShipToAddressID";
        public const string DataMigrationFirmDetailsShipToAddress = "ShipToAddress";
        public const string DataMigrationFirmDetailsAddress1 = "Address1";
        public const string DataMigrationFirmDetailsAddress2 = "Address2";
        public const string DataMigrationFirmDetailsCity = "City";
        public const string DataMigrationFirmDetailsState = "State";
        public const string DataMigrationFirmDetailsZipCode = "ZipCode";
        public const string DataMigrationFirmDetailsCountry = "Country";
        public const string DataMigrationFirmDetailsContactPersonName = "ContactPersonName";
        public const string DataMigrationFirmDetailsContactPersonPhone = "ContactPersonPhone";
        public const string DataMigrationFirmDetailsContactPersonFax = "ContactPersonFax";
        public const string DataMigrationFirmDetailsContactPersonEmail = "ContactPersonEmail";
        public const string DataMigrationFirmDetailsUniversityName = "UniversityName";
        public const string DataMigrationFirmDetailsTerminationDate = "TerminationDate";
        #endregion

        #region Firm migration
        //Firm migration - professinal output tables
        public const string FirmMigrationOrganizationTable = "Organization";
        public const string FirmMigrationProfessionalSalutationTable = "ProfessionalSalutation";
        public const string FirmMigrationFieldOfStudyTable = "FieldOfStudy";
        public const string FirmMigrationPilotTesterWarningLevelTable = "PilotTesterWarningLevel";
        public const string FirmMigrationPilotTesterStatusTable = "PilotTesterStatus";
        public const string FirmMigrationProfessionalStatusTable = "ProfessionalStatus";

        //Firm migration - professinal output queries
        public const string FirmMigrationOrganizationQuery = "FirmMigrationOrganizationData";
        //public const string FirmMigrationProfessionalSalutationQuery = "FirmMigrationProfessionalSalutationData";
        //public const string FirmMigrationFieldOfStudyQuery = "FirmMigrationFieldOfStudyData";
        //public const string FirmMigrationPilotTesterWarningLevelQuery = "FirmMigrationPilotTesterWarningLevelData";
        //public const string FirmMigrationPilotTesterStatusQuery = "FirmMigrationPilotTesterStatusData";
        //public const string FirmMigrationProfessionalStatusQuery = "FirmMigrationProfessionalStatusData";

        //Firm migration - professinal output fields
        public const string FirmMigrationOrganizationId = "Organization";
        public const string FirmMigrationProfessionalSalutationId = "ProfessionalSalutation";
        public const string FirmMigrationFieldOfStudyId = "FieldOfStudy";
        public const string FirmMigrationPilotTesterWarningLevelId = "PilotTesterWarningLevel";
        public const string FirmMigrationPilotTesterStatusId = "PilotTesterStatus";
        public const string FirmMigrationProfessionalStatusId = "ProfessionalStatus";
        #endregion


        #endregion  // Firm Migration

        #region CreateEntitlement

        #region EntitlementCreationPrameters table
        public const string EntitlementCreationParametersTable = "EntitlementCreationParameters";
        public const string EntitlementCreationParametersTableAlias = "ECP";

        public const string EntitlementCreationParametersId = "EntitlementCreationParametersId";
        public const string EntitlementCreationParametersJobId = "DataMigrationJobId";
        public const string EntitlementCreationParametersProductCode = "ProductCode";
        public const string EntitlementCreationParametersUnisionShipTo = "UnisionShipTo";
        public const string EntitlementCreationParametersUnitNumber = "UnitNo";
        public const string EntitlementCreationParametersExpiryDate = "ExpiryDate";
        public const string EntitlementCreationParametersQuantity = "Quantity";
        public const string EntitlementCreationParametersCartId = "CartId";
        public const string EntitlementCreationParametersAddedSubIndetifiers = "AddedSubIndetifiers";
        public const string EntitlementCreationParametersUnisonReferenceNumber = "UnisonReferenceNumber";
        public const string EntitlementCreationParametersOrderConfirmed = "OrderConfirmed";
        public const string EntitlementCreationParametersOrderEntitled = "OrderEntitled";
        public const string EntitlementCreationParametersSeatAssigned = "SeatAssigned";

        #endregion
        #endregion


        #endregion Data Migration

        #region Live Seminars and Conferences

        public const string ImportLiveSeminarLogTable = "ImportLiveSeminarLog";
        public const string SeminarLogLogId = "ImportLiveSeminarLogID";
        public const string SeminarLogLiveEventId = "ImportedLiveEventID";
        public const string SeminarLogMessage = "Message";
        public const string SeminarLogStatus = "Status";
        public const string SeminarLogLogDate = "LogDate";
        public const string SeminarLogUsername = "Username";
        public const string SeminarLogSummaryId = "ImportSummaryLogId";

        public const string ImportLiveSeminarSummaryLogTable = "ImportLiveSeminarSummaryLog";
        public const string SummaryLogImportSummaryLogId = "ImportSummaryLogId";
        public const string SummaryLogImportedStartDate = "ImportedStartDate";
        public const string SummaryLogImportFileName = "ImportFileName";
        public const string SummaryLogImportUser = "ImportUser";

        public const string ConferenceInstanceId = "ConferenceInstanceId";


        #endregion

        #region OrganizationVertical table & Fields

        public const string OrganizationVerticalTable = "OrganizationVertical";
        public const string OrganizationVerticalAlias = "ORGVERTI";

        public const string OrganizationVerticalOrganization = "organization";
        public const string OrganizationVerticalVertical = "vertical";

        #endregion

        #region Oracle A_ORDER table & Fields

        public const string OrderTable = "CHECKPOINT.A_ORDER";
        public const string OrderTableAlias = "ODR";
        public const string OrderOrderId = "ORDER_ID";
        public const string OrderRenewCount = "RENEW_COUNT";
        public const string OrderAccountId = "ACCOUNT_ID";
        public const string CISOrderNumber = "cis_order_num";
        public const string OrderPackageId = "PACKAGE_ID";
        public const string OrderMaxUsers = "MAX_USERS";
        public const string OrderEndDate = "END_DATE";
        public const string OrderStatusCode = "STATUS_CODE";

        #endregion

        #region Oracle A_ORDER_EXT table & Fields

        public const string CuasOrderExtensionTableAlias = "ORD_EXT";
        public const string CuasOrderExtensionOrderId = "ORDER_ID";

        #endregion

        #region Oracle ACCOUNT table & Fields
        public const string AccountTable = "CHECKPOINT.ACCOUNT";
        public const string AccountTableAlias = "ACCT";
        public const string AccountAccountId = "ACCOUNT_ID";
        public const string AccountRiaCustomerNumber = "RIACUSTOMER_NUM";
        #endregion

        #region Oracle CPL_ADMIN_ORDER table & feilds
        public const string AdminOrderTable = "CHECKPOINT.CPL_ADMIN_ORDER";
        public const string AdminOrderTableAlias = "ADMODR";
        public const string AdminOrderOrderId = "ORDER_ID";
        public const string AdminOrderRenewCount = "RENEW_COUNT";
        public const string AdminOrderOrgAdminId = "ORG_ADMIN_ID";
        public const string AdminOrderLastUsedRenewDate = "LAST_USED_RENEW_DATE";
        public const string AdminOrderCreatedBy = "CREATED_BY";
        public const string AdminOrderCreatedDate = "CREATED_DATE";
        #endregion

        #region CPL_EMPLOYEE_ORDER table & fields
        public const string EmployeeOrderTable = "CHECKPOINT.CPL_EMPLOYEE_ORDER";
        public const string EmployeeOrderTableAlias = "EMPODR";
        public const string EmployeeOrderOrderId = "ORDER_ID";
        public const string EmployeeOrderEmployeeId = "EMPLOYEE_ID";
        public const string EmployeeOrderProfessionalId = "PROFESSIONAL_ID";
        public const string EmployeeOrderLastUsedRenewDate = "LAST_USED_RENEW_DATE";
        public const string EmployeeOrderRenewCount = "RENEW_COUNT";
        public const string EmployeeOrderCreatedDate = "CREATED_DATE";
        public const string EmployeeOrderCreatedBy = "CREATED_BY";

        #endregion
        #region CPL_ORGANIZATION_ORDER table & fields
        public const string OrganizationOrderTable = "CHECKPOINT.CPL_ORGANIZATION_ORDER";
        public const string OrganizationOrderTableAlias = "ORGODR";
        public const string OrganizationOrderOrderId = "ORDER_ID";
        public const string OrganizationOrderOrganizationId = "ORGANIZATION_ID";
        public const string OrganizationOrderCreatedBy = "CREATED_BY";
        public const string OrganizationOrderCreatedDate = "CREATED_DATE";

        #endregion

        #region Employee table & fields
        public const string EmployeeTable = "Employee";
        public const string EmployeeTableAlias = "EMP";
        public const string EmployeeOrganizationId = "organization";
        public const string EmployeeEmployeeId = "id";
        public const string EmployeeProfessionalId = "professional";
        public const string EmployeeLearningPlan = "learning_enabled";
        public const string EmployeeRefId = "ref_id";

        #endregion

        #region ReqwiredLearningLibraries table & fields

        //Table names and Alias
        public const string ReqwiredLearningLibrariesTable = "ReqwiredLearningLibraries";
        public const string ReqwiredLearningLibrariesTableAlias = "RLL";

        //Table fields
        public const string RLLFieldBundleId = "BundleId";
        public const string RLLFieldProductCode = "ProductCode";

        #endregion

        #region College table & fields
        public const string CollegeTable = "College";
        public const string CollegeTableAlias = "COL";
        public const string CollegeId = "Id";
        public const string CollegeName = "name";
        public const string CollegeUniversityId = "university";
        #endregion

        #region ProfessionalVertical table & fields

        //table names and aliases

        public const string ProfessionalVerticalProfessionalTable = "professional";
        public const string ProfessionalVerticalProfessionalTableAlias = "PRF";
        public const string ProfessionalVerticalTable = "ProfessionalVertical";
        public const string ProfessionalVerticalTableAlias = "PRV";
        public const string ProfessionalVerticalEmployeeTable = "Employee";
        public const string ProfessionalVerticalEmployeeTableAlias = "EMP";

        //field names and aliases

        public const string ProfessionalVerticalProfessionalFieldID = "id";
        public const string ProfessionalVerticalProfessionalFieldOwner = "owner";
        public const string ProfessionalVerticalEmployeeFieldID = "id";
        public const string ProfessionalVerticalProfessionalFieldProfessional = "professional";
        public const string ProfessionalVerticalProfessionalFieldProfessionalAlas = "professional";
        public const string ProfessionalVerticalInnerQueryFieldProfessional = "professional";
        public const string ProfessionalVerticalEmployeeFieldProfessional = "professional";
        public const string ProfessionalVerticalProfessionalFieldVertical = "vertical";
        public const string ProfessionalVerticalProfessionalFieldCount = "VerticalCount";
        public const string ProfessionalVerticalProfessionalFieldMax = "VerticalMax";

        //innerquary fields
        public const string ProfessionalVerticalInnerQuery = "ProfVerticalInnerQuery";
        #endregion

        #region EmployeeVertical table & fields
        public const string EmployeeVerticalTable = "EmployeeVertical";
        public const string EmployeeVerticalTableAlias = "EMPV";
        public const string EmployeeVerticalEmployee = "employee";
        public const string EmployeeVerticalVertical = "vertical";

        #endregion


        #region PreviewCourseActivity Fileds
        public const string PreviewCourseActivityTable = "PreviewedCourseActivity";
        public const string PreviewCourseActivityTableAlias = "PCA";

        public const string PreviewCourseActivityId = "id";
        public const string PreviewCourseActivityTitle = "title";
        public const string PreviewCourseActivityProvider = "provider";
        public const string PreviewCourseActivityFormat = "format";
        public const string PreviewCourseActivityProfessionalId = "professional";
        public const string PreviewCourseActivityCourseInstanceId = "instance";
        public const string PreviewCourseActivityCourseId = "course";
        public const string PreviewCourseActivityActivityMode = "mode";
        #endregion

        #region Cuas

        #region CuasCplTable
        public const string CuasCplTable = "CHECKPOINT.CPL";
        public const string CuasCplTableAlias = "QCPL";
        public const string CuasCplCplId = "CPL_ID";
        public const string CuasCplCplCode = "CPL_CODE";
        public const string CuasCplCplType = "CPL_TYPE";
        public const string CuasCplCplDescription = "CPL_DESCRIPTION";
        #endregion

        #region CuasCplPackage
        public const string CuasCplPackageTable = "CHECKPOINT.CPL_PACKAGE";
        public const string CuasCplPackageTableAlias = "QCPAK";
        public const string CuasCplPackagePackageId = "PACKAGE_ID";
        public const string CuasCplPackageCplId = "CPL_ID";
        #endregion

        #region Oracle A_ORDER_CPL_BUNDLE
        public const string CuasOrderCplBundleTable = "CHECKPOINT.a_order_cpl_bundle";
        public const string CuasOrderCplBundleTableAlias = "AOCB";
        public const string CuasOrderCplBundleOrderId = "Order_Id";
        public const string CuasOrderCplBundleCplId = "CPL_ID";
        public const string CuasOrderCplBundleEndDate = "END_DATE";

        #endregion

        #region Oracle CPL_CUSTOM_PACKAGE
        public const string CuasCplCustomPackageTable = "CHECKPOINT.CPL_CUSTOM_PACKAGE";
        public const string CuasCplCustomPackageTableAlias = "CCPAC";
        public const string CuasCplCustomPackageId = "CPL_CUSTOM_PACKAGE_ID";
        public const string CuasCplCustomPackageAccountId = "ACCOUNT_ID";
        public const string CuasCplCustomPackageIdCustom = "PACKAGE_ID_CUSTOM";


        #endregion

        #endregion

        #region Product List

        #region ProductListTable
        public const string ProductListTable = "ProductList";
        public const string ProductListTableAlias = "PL";
        public const string ProductListProductListId = "ProductListId";
        public const string ProductListCode = "Code";
        public const string ProductListName = "Name";
        public const string ProductListEffectiveDate = "EffectiveDate";
        public const string ProductListExpiryDate = "ExpiryDate";
        public const string ProductListDoesNotExpire = "DoesNotExpire";
        public const string ProductListStatus = "Status";
        #endregion

        #region ProductListProductTable
        public const string ProductListProductTable = "ProductListProduct";
        public const string ProductListProductTableAlias = "PLP";
        public const string ProductListProductProductListProductId = "ProductListProductId";
        public const string ProductListProductProductListId = "ProductListId";
        public const string ProductListProductProductId = "ProductId";
        public const string ProductListProductProductListProductTypeId = "ProductListProductTypeId";
        #endregion

        #region ProductListProductTypeTable
        public const string ProductListProductTypeTable = "ProductListProductType";
        public const string ProductListProductTypeAlias = "PLPT";
        public const string ProductListProductTypeProductListProductTypeId = "ProductListProductTypeId";
        public const string ProductListProductTypeName = "Name";
        public const string ProductListProductTypeStatus = "Status";
        #endregion

        #region PurchaseHistory Table

        public const string PurchaseHistoryTable = "PurchaseHistory";
        public const string PurchaseHistoryTableAlias = "PH";
        public const string PurchaseHistoryUserID = "UserID";
        public const string PurchaseHistoryIsUserAdmin = "IsUserAdmin";
        public const string PurchaseHistoryPurchasedDate = "PurchasedDate";
        public const string PurchaseHistoryPurchasedMode = "PurchasedMode";
        public const string PurchaseHistoryUnisionID = "UnisionID";
        public const string PurchaseHistoryQuantity = "Quantity";
        public const string PurchaseHistoryUnitPrice = "UnitPrice";
        public const string PurchaseHistoryUnitNumber = "UnitNumber";

        #endregion

        #endregion

        #region Predefined Bundle Table, Stored Procedures and Columns

        #region PredefinedBundle Table
        public const string PredefinedBundleTable = "PredefinedBundle";
        public const string PredefinedBundleTableAlias = "PDB";
        public const string PredefinedBundleBundleID = "BundleID";
        public const string PredefinedBundleTitle = "Title";
        public const string PredefinedBundleDescription = "Description";
        public const string PredefinedBundlePrice = "Price";
        public const string PredefinedBundleStatusID = "StatusID";
        public const string PredefinedBundleProductCode = "ProductCode";
        #endregion

        #region Stored Procedures and paramerters
        public const string CourseFinderGetProductDetailsforUnisonIds = "usp_CourseFinderGetProductDetailsforUnisonIds";
        public const string ProductDetailsUnisonId = "UnisonId";
        public const string ProductDetailsStartRowNo = "StartRowNo";
        public const string ProductDetailsEndRowNo = "EndRowNo";
        public const string ProductDetailsNoRecords = "NoRecords";
        #endregion

        #endregion

        #region FosToNasbaFos
        public const string FosToNasbaFosTable = "FosToNasbaFos";
        public const string FosToNasbaFosAlias = "FTNF";
        public const string FosToNasbaFosNasbaFosID = "NasbaFosID";
        public const string FosToNasbaFosFieldOfStudyID = "FieldOfStudyID";
        #endregion

        #region Auto Notify
        public const string AutoNotifyTemplateTable = "AutoNotifyTemplate";
        public const string AutoNotifyTemplateTableAlias = "ANT";
        public const string AutoNotifyTemplateID = "AutoNotifyTemplateID";
        public const string AutoNotifyTemplateName = "TemplateName";
        public const string AutoNotifyTemplateAutoNotifyFequencyID = "AutoNotifyFequencyID";
        public const string AutoNotifyTemplateAutoNotifyVersionID = "AutoNotifyVersionID";
        public const string AutoNotifyTemplateEmailSubject = "Subject";
        public const string AutoNotifyTemplateEmailBody = "EmailBody";
        public const string AutoNotifyTemplateStatus = "Status";
        public const string AutoNotifyTemplateLastModifiedDate = "LastModifiedDate";
        public const string AutoNotifyTemplateLastNotifiedDate = "LastNotifiedDate";

        public const string AutoNotifySelectedEmailDistributionListTable = "AutoNotifyTemplateEmailDistributionList";
        public const string AutoNotifySelectedEmailDistributionListAlias = "ANSEDL";
        public const string AutoNotifySelectedEmailDistributionListTemplateID = "AutoNotifyTemplateID";
        public const string AutoNotifySelectedEmailDistributionListID = "AutoNotifyEmailDistributionListID";

        public const string AutoNotifyEmailNotifyLogTable = "AutoNotifyEmailNotifyLog";
        public const string AutoNotifyEmailNotifyLogTableAlais = "ANENL";
        public const string AutoNotifyEmailNotifyLogID = "AutoNotifyEmailNotifyLogID";
        public const string AutoNotifyEmailNotifyLogIDAlais = "AutoNotifyEmailNotifyLogID";
        public const string AutoNotifyEmailDistributionListNotified = "EmailDistributionListNotified";
        public const string AutoNotifyNotifiedDate = "NotifiedDate";
        public const string AutoNotifyLogInnerQuery = "InnerQuery";

        public const string AutoNotifyTemplateEmailDistributionListTable = "AutoNotifyTemplateEmailDistributionList";
        public const string AutoNotifyTemplateEmailDistributionListTableAlias = "ANTEDL";
        public const string AutoNotifyTemplateEmailDistributionListId = "AutoNotifyEmailDistributionListID";
        public const string AutoNotifyTemplateEmailDistributionListAutoNotifyTemplateID = "AutoNotifyTemplateID";


        public const string AutoNotifyEmailDistributionListTable = "AutoNotifyEmailDistributionList";
        public const string AutoNotifyEmailDistributionListTableAlias = "ANEDL";
        public const string AutoNotifyEmailDistributionListId = "AutoNotifyEmailDistributionListID";
        public const string AutoNotifyEmailDistributionListIdAlias = "AutoNotifyEmailDistributionListID";
        public const string AutoNotifyEmailDistributionName = "EmailDistributionName";
        public const string AutoNotifyEmailDistributionNameAlias = "EmailDistributionName";
        public const string AutoNotifyEmailDistributionEmails = "Emails";
        public const string AutoNotifyEmailDistributionStatus = "Status";
        public const string AutoNotifyEmailDistributionsafeUserId = "LastModifiedUserID";

        public const string AutoNotifyEmailNotifyLogCourseMetadataID = "CourseMetadataID";
        public const string AutoNotifyEmailNotifyLogAutoNotifyTemplateID = "AutoNotifyTemplateID";
        public const string AutoNotifyEmailNotifyLogNotifiedDate = "NotifiedDate";
        //public const string AutoNotifyLogEmailDistributionListIdAlias = "AutoNotifyEmailDistributionListID";

        public const string AutoNotifySelectedFieldOfStudyTable = "AutoNotifyTemplateFieldOfStudy";
        public const string AutoNotifySelectedFieldOfStudyAlias = "ANSFOS";
        public const string AutoNotifySelectedFieldOfStudyFieldOfStudyID = "FieldOfStudyID";
        public const string AutoNotifySelectedFieldOfStudyAutoNotifyTemplateID = "AutoNotifyTemplateID";

        #region AutoNotifySelectedCPEProductBrands Table
        public const string AutoNotifySelectedCPEProductBrandsTable = "AutoNotifyTemplateCPEProductBrands";
        public const string AutoNotifySelectedCPEProductBrandsAlias = "ANSPB";
        public const string AutoNotifySelectedCPEProductBrandsAutoNotifyTemplateID = "AutoNotifyTemplateID";
        public const string AutoNotifySelectedCPEProductBrandsBrandID = "BrandID";
        #endregion

        #region AutoNotifyFrequency table & fields
        public const string AutoNotifyFrequencyTable = "AutoNotifyFrequency";
        public const string AutoNotifyFrequencyTableAlias = "ANF";
        public const string AutoNotifyFrequencyFequencyID = "AutoNotifyFequencyID";
        public const string AutoNotifyFrequencyFrequencyDetail = "FrequencyDetail";

        #endregion


        #region AutoNotifyVersion table & fields
        public const string AutoNotifyVersionTable = "AutoNotifyVersion";
        public const string AutoNotifyVersionTableAlias = "ANV";
        public const string AutoNotifyVersionAutoNotifyVersionID = "AutoNotifyVersionID";
        public const string AutoNotifyVersionVesionDescription = "VesionDescription";

        #endregion

        #region vw_AutoNotifyTemplate view and fields
        public const string AutoNotifyTemplateView = "vw_AutoNotifyTemplate";
        public const string AutoNotifyTemplateAlias = "VWANT";
        public const string AutoNotifyTemplateAutoNotifyTemplateID = "AutoNotifyTemplateID";
        public const string AutoNotifyTemplateSubject = "Subject";
        public const string AutoNotifyTemplateBody = "EmailBody";
        public const string AutoNotifyTemplateIsNotificationRequired = "IsNotificationRequired";
        #endregion

        #endregion

        #region Manifest

        public const string ManifestAlias = "MAN";
        public const string ManifestView = "vw_Manifest";

        // Total Number of CPE credits

        public const string ManifestDownloadTypeID = "DownloadTypeID";
        public const string ManifestLastSort = "LastSort";

        public const string ManifestCourseInstanceId = "CourseInstanceId";
        public const string ManifestCourseMetadataID = "CourseMetadataID";
        public const string ManifestAcronym = "Acronym";
        public const string ManifestTitle = "Title ";
        public const string ManifestBrandName = "BrandName";
        public const string ManifestDeliveryFormatName = "DeliveryFormatName";
        public const string ManifestNasbaLearningLevelName = "NasbaLearningLevelName";
        public const string ManifestVersionNumber = "VersionNumber";
        public const string ManifestDescription = "Description";
        public const string ManifestCourseSponsorID = "CourseSponsorID";
        public const string ManifestInteractiveLevelID = "InteractiveLevelID";
        public const string ManifestPrivateCourse = "PrivateCourse";
        public const string ManifestLearningLevelID = "LearningLevelID";
        public const string ManifestLearningObjectives = "LearningObjectives";
        public const string ManifestAdvancedPreparation = "AdvancedPreparation";
        public const string ManifestPrerequisites = "Prerequsites";
        public const string ManifestNasbaRegistry = "NasbaRegistry";
        public const string ManifestNasbaQas = "NasbaQas";
        public const string ManifestCtecCourse = "CtecCourse";
        public const string ManifestCfpCourse = "CfpCourse";
        public const string ManifestCtecFederalcCredits = "CtecFederalcCredits";
        public const string ManifestCtecCaCredits = "CtecCaCredits";
        public const string ManifestCfpCredits = "CfpCredits";
        public const string ManifestMarketingDescription = "MarketingDescription";
        public const string ManifestRecentChanges = "RecentChanges";
        public const string ManifestKeywords = "Keywords";
        public const string ManifestPublicationRevisionDate = "PublicationRevisionDate";
        public const string ManifestVersionAvailableDate = "VersionAvailableDate";
        public const string ManifestCourseStatusID = "CourseStatusID";
        public const string ManifestNasbaFieldOfStudyName = "NasbaFieldOfStudyName";
        public const string ManifestClientName = "ClientName";

        #region Manifest Column Definition Objects & Attributes

        public const string ManifestColumnTable = "ManifestColumn";
        public const string ManifestColumnDefinition = "ColumnDefinition";
        public const string ManifestColumnDefinitionList = "ColumnDefinitionList";
        public const string ManifestColumnId = "ColumnId";
        public const string ManifestColumnName = "ColumnName";
        public const string ManifestColumnDataType = "ColumnTypeID";
        public const string ManifestColumnDisplayName = "DisplayName";
        public const string ManifestColumnIsAnalytical = "IsAnalytical";

        public const string ManifestInstanceTable = "ManifestInstance";
        public const string ManifestInstanceID = "ManifestInstanceID";
        public const string ManifestSelectedColumns = "SelectedColumns";
        public const string ManifestAvailableColumns = "AvailableColumns";
        public const string ManifestSortColumns = "SortColumns";
        public const string ManifestUserId = "UserId";
        public const string ManifestLastModifiedDate = "LastModifiedDate";
        public const string ManifestXSLTCellValue = "XSLTCellValue";
        public const string ManifestOrganizationID = "OrganizationID";

        #endregion

        #endregion

        #region CEFormat table & View Fields

        public const string CEFormatTable = "CEFormat";
        public const string CEFormatAlias = "CEFormat";

        public const string CEFormatId = "id";
        public const string CEFormatName = "name";
        public const string CEFormatDescription = "description";
        public const string CEFormatImage = "image";
        public const string CEFormatNeedLocation = "needLocation";
        public const string CEFormatNeedTime = "needTime";

        #endregion

        #region bulk live event import
        public const string SpImportLiveEvents = "usp_ImportLiveEvents";
        public const string ImportLiveEventsQuery = "ImportLiveEvents";

        #endregion

        #region IRS Register Bulk Import
        public const string SpImportIrsUsers = "usp_ImportIrsUsers";
        public const string ImportIrsUsersQuery = "ImportIrsUsers";
        public const string SpValidateIrsUser = "usp_IRS_ProfessionalDetails_Select";
        public const string SPSaveProfessionalOrderFormShippedDate = "usp_IRS_SaveProfessionalOrderFormShippedDate";
        public const string CDSearchQuery = "CDSearch";
        public const string SpCDShippedSearchQuery = "usp_CDShippedSearch";

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


        #region NasbaLearningLevel Table and fields
        public const string NasbaLearningLevelTable = "NasbaLearningLevel";
        public const string NasbaLearningLevelName = "Name";
        public const string LearningLevelId = "LearningLevelID";
        #endregion

        #region Course table
        public const string CourseTable = "Course";
        public const string CourseTableAlias = "CO";

        public const string CourseCourseMetadataId = "CourseMetadataID";
        public const string CourseCourseCode = "code";

        #endregion

        #region CoursePermissionToRepublishTable
        public const string CoursePermissionToRepublishTable = "CoursePermissionToRepublish";
        public const string CoursePermissionToRepublishName = "Name";
        public const string CoursePermissionToRepublishId = "PermissionToRepublishID";
        #endregion

        #region CourseMetadata CourseGroup

        //CourseGrouping Table fields
        public const string CourseGroupSponsorId = "CourseGroupSponsorId";
        public const string CourseGroupBrandId = "CourseGroupBrandId";
        public const string CourseGroupNasbaId = "CourseGroupNasbaId";
        public const string CourseGroupDeliveryFormatId = "CourseGroupDeliveryFormatId";
        public const string CourseGroupMediaFormatId = "CourseGroupMediaFormatId";
        public const string CourseGroupCeFormatId = "CourseGroupCeFormatId";

        public const string CourseGroupBrandName = "CourseGroupBrandName";
        public const string CourseGroupNasbaName = "CourseGroupNasbaName";
        public const string CourseGroupDeliveryFormatName = "CourseGroupDeliveryFormatName";
        public const string CourseGroupMediaFormatName = "CourseGroupMediaFormatName";
        public const string CourseGroupCeFormatName = "CourseGroupCeFormatName";
        #endregion

        #region Deloitte Integration
        public const string UpdateEmployeeDetailsForDeloitteProfessional = "usp_UpdateEmployeeDetailsForDeloitteProfessional";

        #endregion

        #region AssoAssociate Attachments
        public const string AttachmentInformationQuery = "AttachmentInformationQuery";
        public const string AttachmentAssociationInfoQuery = "AttachmentAssociationInfoQuery";
        #endregion

        public const string DisplayIcon = "DisplayIcon";
        public const string DisplayIconId = "DisplayIconId";
        public const string DisplayIconName = "DisplayIconName";
        public const string IconID = "IconID";
        public const string GetDefaultDurationIdUsp = "usp_GetDefaultDurationID";
        public const string DefaultVersionSelection = "usp_defaultIconSelectionMappings";

        public const string DisplayIconDuration = "DisplayIconDuration";
        public const string DisplayIconDurationId = "DisplayIconDurationId";
        public const string DisplayIconDurationName = "DisplayIconDurationName";
        public const string MembershipDetailsForDropDown = "usp_GetMembershipDetailsForDropDown";
        public const string usp_MediaFormatCheckRetire = "usp_MediaFormatCheckRetire";
        public const string CanShowRetire = "CanShowRetire";

        public const string usp_GearUpRetakeProductValidation = "usp_GearUpRetakeProductValidation";
        public const string isGearUpPurchased = "isGearUpPurchased";




        public const string ProductId = "productId";
        public const string LiveEventScheduleStartDate = "StartDate";
        public const string LiveEventScheduleEndDate = "EndDate";
        public const string GetLiveEventScheduleDates = "usp_GetLiveEventScheduleDates";
        #region RetireCheck
        public const string RetireCheck = "RetirementCheck";
        public const string SpRetireCheck = "sp_rqwd_courseinstance_retirement_check";
        public const string inprogress_check = "inprogress_check";
        public const string Sp_bundle_inprogress_check = "sp_rqwd_bundle_inprogress_check";
        #endregion


        #region PackageManagement Table & Fields

        public const string ProductsTable = "Products";
        public const string ProductsAlias = "PR";
        public const string ProductTypeID = "ProductTypeID";
        public const string ProductID = "ProductID";
        public const string ProductCode = "ProductCode";
        #endregion


        #region ReminderSetupMail
        public const string GetMailFrequency = "usp_GetMailFrequency";
        public const string GetSelectedMailFrequency = "usp_GetSelectedMailFrequency";
        public const string AddMailReminder = "usp_AddMailReminder";
        public const string UpdateMailReminder = "usp_UpdateMailReminder";
        public const string DeleteUploadDocuments = "Usp_DeleteUploadDocuments";
        public const string SaveUploadDocuments = "Usp_SaveUploadDocuments";
        public const string AddMailFrequencyToReminder = "usp_AddMailFrequencyToReminder";
        public const string GetReminderIdByProductId = "usp_GetReminderIdByProductId";
        public const string GetRemainderMailDetails = "usp_GetRemainderMailDetails";
        public const string GetRemainderMailAttachments = "usp_GetRemainderMailAttachments";
        public const string GetSelectedFrequency = "Usp_GetSelectedFrequency";
        public const string GetWebinarRegistrantList = "usp_GetWebinarRegistrantList";
        #endregion

        #region CourseCatalog
        public const string SearchQueryOfRecords = "SearchQueryOfRecords";
        public const string ProductCount = "ProductCount";
        public const string SpLiveeventForCourseSearch = "Usp_LiveeventForCourseSearch";
        public const string Coursemetadataids = "Coursemetadataids";
        public const string Eventstateid = "stateid";
        public const string includeSocietySearch = "includeSocietySearch";
        public const string sp_GetCourseInstanceForCourseSearch = "usp_GetCourseInstanceForCourseSearch";
        #endregion

    }
}
