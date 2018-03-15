
using System.ComponentModel;

namespace Kotacs.Libraries.Common
{

    public enum PageResourceID : int
    {
        None = 0,
        CPECompliance = 1000,
        NotedExperts = 1001,
        AditionalResources = 1002,
        CPERuleChanges = 1003,
        NotedAuthors = 1004,
        QucikSearch = 1005,
        FieldOfStudy = 1006,
        DeliveryFormat = 1007,
        ThomsonCPEBrands = 1008,
        IndividualNotedExpert = 1009,
        TrainingSolutionsNewsletter = 1010,
        CorporateAccounts = 1011,
        CustomizedCourses = 1012,
        SponsorOpportunities = 1013,
        BecomeAuthor = 1014,
        NotedAuthor = 1015,
        AboutUs = 1016,
        ContactUs = 1017,
        SiteMap = 1018,
        PrivacyPolicy = 1019,
        TermsAndConditions = 1020,
        LearningLibraries = 1021,
        CPEHome = 1022,
        LearningInteractive = 1023,
        WebinarLearningNetwork = 1024,
        Reqwired = 1025,
        PilotTester = 1026,
        GearUpCompliance = 1027,
        BellLearningCompliance = 1028,
        PASSOnlineCompliance = 1029,
        MicroMashCompliance = 1030,
        PPCCompliance = 1031,
        RIACompliance = 1032,
        WebinarPartnershipCompliance = 1033,
        CPESolutions = 1051,
        InHouseTraining = 1052,
        LiveSeminarsConferences = 1053,
        OnlineLearning = 1054,
        SelfStudyCourses = 1055,
        Index = 2000,
        CourseFormats = 1056,
        InteractiveCourses = 1057,
        FindCourse = 1058,
        GAOYellowBook = 1059,
        CourseFinder = 1060,
        CancellationRefundPolicy = 1061,
        MicroMash = 1062,
        PassOnline = 1063,
        BellLearning = 1064,
        PPC = 1065,
        RIA = 1066,
        WebinarPartnership = 1067,
        GearUp = 1068,
        ViewCourseInformation = 1069,
        CourseList = 1070,
        QuickSearch = 1072,
        SalesAndSupport = 1071,
        RequestForInformation = 1080,
        SendEmail = 1073,
        ViewAllCourses = 1074,
        ScheduleInformation = 1075,
        TopSellers = 1076,
        HotTopic = 1077,
        HopTopicSummary = 1078,
        OnlineGrading = 1079,
        EthicCourses = 1081,
        ScheduleInformationMap = 1082,
        Bailout = 1083,
        IFRS = 1084,
        ReqwiredSpecialFeatures = 1086,
        PPCSelfStudy = 1085,
        CourseDescription = 1086,
        NewCourses = 1087,
        IndividualNotedAuthor = 1088,
        CpeTrainingInteractiveCatalog = 2001,
        CpeAndTrainingCatalog = 2002,
        IntrTopSellers = 2005,
        UpComingWebinars = 2006,
        WebinarCustomerPolicies = 2007,
        ReqwiredLearningLibraries = 2010,
        CPEBrands = 2011,
        SalesSummary = 2012,
        InternetSalesSummery = 2015,
        SponsorLandingPage = 2016,
        QuickFinder = 2017,
        GlobalTextManagement = 2018,
        SponsorManagement = 2019,
        Cart = 2020,
        MyCart = 2021,
        SponsorLandingPageManagement = 2022,
        Login = 2023,
        ResourceInfo = 2024,
        ProfessionalInfo = 2025,
        PersonalInfo = 2026,
        ContactInfo = 2027,
        AssociatedCourseInfo = 2028,
        ManageUserProfiles = 2029,
        BillingAndShipping = 2030,
        PromoCodes = 2031,
        OrderSummary = 2032,
        Receipt = 2033,
        AddItemsToCart = 2034,
        PreviewImage = 2035,
        ReportList = 2036,
        BuidReport = 2037,
        Report = 2038,
        ShippingAddress = 2039,
        AddressValidation = 2040,
        PreviewCourse = 2041,
        IndividualAuthor = 2042,
        CpeTracking = 2043,
        PredefinedBundles = 2044,
        CpeTrackingLegal = 2045,
        CpeTrackingAccounting = 2046,
        CpeTrackingDual = 2047,
        CompetencyModels = 2050,		//PO Integration
        ManifestManager = 2998,
        ManifestDownload = 2999,
        OtherTaxAndAccountingSolution = 3800,

        #region Internal Action Link Enums - no changes within regoin

        // Home Navigation
        InternalHome = 5000,


        // Product Management Navigation
        Resource = 5001,
        SponsorMetadata = 5002,
        CourseMetadata = 5003,
        PilotTest = 5004,
        EventManagement = 5005,
        Grading = 5006,
        ProductionSchedule = 5007,
        LiveEventManagement = 5008,

        MetadataTab = 5009,
        General = 5010,
        SupplementalMaterial = 5011,
        Contributors = 5012,
        CertificationsCredits = 5013,
        Measurement = 5014,
        Marketing = 5015,
        Status = 5016,
        TableOfContent = 5017,

        CoursewarePlayer = 5018,


        // DynamicAssembly
        DynamicAssemblyHome = 5020,
        DynamicAssemblyChapterLinking = 5021,
        DynamicAssemblyReports = 5022,

        // Sales & Marketing Navigation
        MarketingContent = 5201,
        SEM = 5202,
        SalesReporting = 5203,
        BusinessAffiliates = 5205,
        Extranets = 5206,
        LMS = 5207,

        // DiscountManagement 
        DiscountManagement = 5204,
        Promotions = 5208,
        ExcludeProducts = 5209,
        PromotionsReports = 5211,
        OrderLevelRule = 5212,
        LineItemDiscount = 5213,

        Manifest = 5210,

        // Support
        TechnicalCustomerSupport = 5301,
        Help = 5302,
        Administrations = 5303,

        Sponsor = 5051,

        //User Registration
        PurchasedProductsToolTip = 6600,
        PilotTesterToolTip = 6601,
        ForgotLogin = 6602,
        SecurityQuestions = 6603,
        ProfessionalUserEMailNotFoundHeading = 6604,
        ProfessionalEMailUserNameNotFoundHeading = 6605,
        ProfessionalSentPasswordHeading = 6606,
        ProfessionalSentUserNameHeading = 6607,
        ProfessionalSentPasswordMessage = 6608,
        ProfessionalSentUserNameMessage = 6609,
        ProfessionalInvalidAnswersHeading = 6610,
        ProfessionalInvalidAnswersMessage = 6611,
        ProfessionalNewUserRegistrationHeading = 6612,
        ProfessionalNewUserRegistrationMessage = 6613,
        ProfessionalNewUserRegistrationFailedMessage = 6614,
        ProfessionalRequiredField = 6615,
        ProfessionalInvalidEmailMessage = 6616,
        ProfessionalInvalidPhoneNumber = 6617,
        ProfessionalOnlyAllowCharactersHyphenMessage = 6618,
        ProfessionalOnlyAllowNumericCharactersHyphenMessage = 6619,
        ProfessionalRequiredOnlyCharactersHyphenMessage = 6620,
        ProfessionalSelectStateMessage = 6621,
        ProfessionalInvalidZipMessageLong = 6622,
        ProfessionalRequiredOnlyNumericCharactersHyphenMessage = 6623,
        ProfessionalInvalidExtensionMessage = 6624,
        PilotTesterSuccessfullyUpdateMessage = 6629,
        PilotTesterUpdateFailMessage = 6630,
        ProfessionalUpdateProfileMessage = 6632,
        ProfessionalInvalidZipMessageShort = 6633,
        ProfessionalPasswordMismatchMessage = 6634,
        ProfessionalInvalidSecurityQuestionSelectMessage = 6635,
        ProfessionalUpdateProfileHeading = 6636,
        ProfessionalUserProfileHeading = 6637,
        ProfessionalEmailRegisteredMessage = 6638,
        ProfessionalEmailPrimaryMessage = 6639,
        ProfessionalAddressRequiredMessage = 6640,
        ProfessionalMultipleAddressTypesInvalidMessage = 6641,
        ProfessionalViewProfileHeading = 6642,
        ProfessionalInvalidAnswerFormat = 6643,
        ProfessionalInvalidUserName = 6644,
        ProfessionalInvalidPassword = 6645,
        ProfessionalInvalidConfirmPassword = 6646,


        NotedExpertPageHeading = 6647,
        NotedAuthorPageHeading = 6648,
        AuthorPageHeading = 6649,
        UserPurchasedProductsPrimaryToolTip = 6650,
        ProfessionalInvalidMembershipHeading = 6651,
        ProfessionalInvalidMembershipMessage = 6652,
        CreateCustomerErrorMessage = 6653,
        StandardizedaddressMessage = 6654,
        InvalidShippingaddress = 6655,
        ProfessionalPhonePrimaryMessage = 6656,


        #endregion

        #region Checkpoint MetaTab Langing page - no changes within region

        CPMetaTabHome = 5500,

        #endregion

        #region Course Details

        CourseDetailsInvalidUnisonId = 7034,
        CourseDetailsNoCourseDetailsAvailable = 7035,
        #endregion

        #region Price Not Available Formats
        PriceNotAvailableShortFormat = 7036,
        PriceNotAvailableLongFormat = 7037,

        #endregion

        #region Order Process
        UnisonGetOrderHistoryError = 8061,
        UnisonAddOrderLineError = 8062,
        UnisonConfirmOrderError = 8063,
        UnisonCompleteOrderError = 8064,
        CUASAssignEntitlementError = 8065,
        OrderProcessingCreateOrderError = 8066,
        EntitlementAssignSeatError = 8067,
        CUASIsProfessionalEntitledError = 8073,
        OrderProcessingAssignSeatForEmployeeError = 8075,
        #endregion

        #region CourseMetadata - Internal
        // CourseMetadataMeidaFormatInvalidUrlHeaderError = 8068,
        // CourseMetadataMeidaFormatInvalidUrlMessageError = 8069,
        CourseMetadataMeidaFormatEmptyUnisonIdHeaderError = 8070,
        CourseMetadataMeidaFormatEmptyUnisonIdMessageError = 8071,
        #endregion

        #region Learning Plan
        CourseRequestEmailBody = 8072,
        #endregion

        #region OGS purchase exam
        OGSPurchaseExamConfirmation = 8074,
        #endregion

        #region BundlePackages

        BundlePackages = 8160,
        PremiumBundle = 8161,
        StandardBundle = 8162,
        CorporateCurriculum = 8163,
        #endregion

        #region Product Reconciliation
        NoResultsErrorMessage = 8401,
        ErrorHeader = 8402,
        #endregion

        #region Live Event Conference Setup (8420 - 8423 / 8486 - 8489 / 8516 - 8525)
        CsUpdateDoneMessage = 8420,
        CsUpdateDoneMessageHeader = 8421,
        CsNoUpdateErrorMessage = 8422,
        CsNoUpdateErrorMessageHeader = 8423,
        ConferenceDeleteSuccesMessage = 8486,
        ConferenceDeleteErrorMessage = 8487,
        ConferenceDeleteMessageHeader = 8488,
        CourseMetadataScheduleProductCodeExistsMessage = 8489,

        LiveEventSaveConferenceCategorySuccessHeader = 8516,
        LiveEventSaveConferenceCategorySuccessMessage = 8517,
        LiveEventSaveConferenceCategoryFailedHeader = 8518,
        LiveEventSaveConferenceCategoryFailedMessage = 8519,
        LiveEventSaveConferenceCategoryFailedHasConferenceMessage = 8520,
        LiveEventDeleteConferenceCategorySuccessHeader = 8521,
        LiveEventDeleteConferenceCategorySuccessMessage = 8522,
        LiveEventDeleteConferenceCategoryFailedHeader = 8523,
        LiveEventDeleteConferenceCategoryFailedMessage = 8524,

        #endregion

        #region Live Event Order Entry
        LiveEventNewUserRegistrationHeading = 8424,
        LiveEventNewUserRegistrationMessage = 8425,
        LiveEventUpdateUserHeading = 8426,
        LiveEventUpdateUserMessage = 8427,
        LiveEventNewUserRegistrationFailedMessage = 8428,
        LiveEventAttendanceTicketNotificationAttachmentName = 8509,
        LiveEventAttendanceTicketNotificationSubject = 8510,
        PdfConverterlicenseKey = 8511,
        TicketBarCodeEncordSymbology = 8512,
        LiveEventSendReceiptEmailSubject = 8513,
        LiveEventSendTicketsSuccessMessage = 8514,
        LiveEventSendTicketsFailMessage = 8561,
        LiveEventSendTicketSuccessMessage = 8562,
        LiveEventSendTicketFailMessage = 8563,
        LiveEventInvalidUnisonCodeMessage = 8564,
        LiveEventInvalidUnisonCodeFailMessage = 8565,
        LiveEventUnisonCodeSucessMessage = 8566,
        LiveEventValidUnisonCodeMessage = 8567,
        LiveEventSaveUnisonCodeMessage = 8568,
        LiveEventSaveUnisonCodeSucessMessage = 8569,
        LiveEventApplyPromoCodeSucessMessage = 8570,
        LiveEventOrderEntryInvalidSearchValueMessage = 8571,
        LiveEventOrderEntryInvalidTextValueMessage = 8572,
        LiveEventOrderEntryUnisonError = 8605,
        FpAssignmentMailSubjectSeminarWorkshop = 8606,
        FpAssignmentMailSubjectWebinarWebcast = 8607,
        FpAssignmentMailSubjectConference = 8608,
        FpUnAssignmentMailSubject = 8609,
        CartRejectDuplicateUnisonId = 8610,
        LiveEventSendReceiptAttachmentName = 8611,
        FAOrderConfirmationEmailSubject = 8612,
        #endregion

        #region IRS (8820-8840)
        IrsUserRegistrationEmailSubject = 8820,
        IrsForgotLoginEmailSubject = 8821,
        IrsForgotLoginEmailValidationError = 8822,
        #endregion

        #region Schedule 8429 - 8449/ 8466 - 8475 / 8480 - 8485
        CourseMetadataUpdateScheduleFailedHeader = 8429,
        CourseMetadataInvalidDaysMessage = 8430,
        CourseMetadataUpdateScheduleFailedMessage = 8431,
        CourseMetadataDeleteScheduleFailedHeader = 8432,
        CourseMetadataDeleteScheduleDayFailedMessage = 8433,
        CourseMetadataDayAddedMessage = 8434,
        CourseMetadataUpdateScheduleDayFailedMessage = 8435,
        CourseMetadataUpdateScheduleNoDaysFailedHeader = 8436,
        CourseMetadataUpdateScheduleNoDaysMessage = 8437,
        CourseMetadataSynchronizeCourseInstanceAddressFailedHeader = 8438,
        CourseMetadataSynchronizeCourseInstanceAddressFailedMessage = 8439,
        CourseMetadataUpdateScheduleDayFailedHeader = 8440,
        CourseMetadataUpdateScheduleDaySuccessHeader = 8441,
        CourseMetadataUpdateScheduleDaySuccessMessage = 8442,
        CourseMetadataDeleteScheduleSuccessHeader = 8443,
        CourseMetadataDeleteScheduleDaySuccessMessage = 8444,
        CourseMetadataUpdateScheduleSuccessMessage = 8445,
        CourseMetadataUpdateAccreditationSuccessHeader = 8446,
        CourseMetadataUpdateAccreditationSuccessMessage = 8447,
        CourseMetadataUpdateScheduleTopicSuccessHeader = 8448,
        CourseMetadataUpdateScheduleTopicSuccessMessage = 8449,

        CourseMetadataUpdateScheduleTopicFailedHeader = 8466,
        CourseMetadataUpdateScheduleTopicFailedMessage = 8467,
        CourseMetadataDeleteScheduleTopicSuccessMessage = 8468,
        CourseMetadataDeleteScheduleTopicFailedMessage = 8469,
        CourseMetadataUpdateAccreditationFailedHeader = 8470,
        CourseMetadataUpdateAccreditationFailedMessage = 8471,
        CourseMetadataScheduleCancelationSuccessMessage = 8472,
        CourseMetadataScheduleCancelationFailedMessage = 8473,

        CourseMetadataDeleteScheduleSuccessMessage = 8474,
        CourseMetadataDeleteScheduleFailedMessage = 8475,
        CourseMetadataDeleteScheduleFailedDueToAttendeeMessage = 8480,
        CourseMetadataUpdateScheduleFailedDuplicateProductCodesMessage = 8481,
        CourseMetadataDeleteScheduleFailedDueToConference = 8482,
        CourseMetadataDisableAccreditationSuccessHeader = 8483,
        CourseMetadataDisableAccreditationSuccessMessage = 8484,


        #endregion

        // 8450 - 8465 Live Event Schedule Instructor 
        #region Live Event Seminar Agenda Topic
        LiveEventSeminarAgendaNoScheduleAvailableEror = 8450,
        LiveEventSeminarAgendaSuccessfullySaved = 8451,
        LiveEventSeminarAgendaSaveFailed = 8452,
        LiveEventSeminarAgendaDeleteAgendaTopicSuccess = 8453,
        LiveEventSeminarAgendaDeleteAgendaTopicFailed = 8454,
        LiveEventSeminarAgendaSynchronizeWithScheduleAgendaSuccess = 8455,
        LiveEventSeminarAgendaSynchronizeWithScheduleAgendaFailed = 8456,
        #endregion


        #region Live Event Schedule Instructor

        #endregion

        #region Notes
        LiveEventProductNoteAddNoteSuccess = 8476,
        LiveEventProductNoteAddNoteFail = 8477,
        LiveEventProductNoteDeleteNoteSuccess = 8478,
        LiveEventProductNoteDeleteNoteFail = 8479,

        #endregion

        #region Live Event Seminar and Optional Seminar (8490 - 8495)
        LiveEventExcludeSeminarSuccessHeader = 8490,
        LiveEventExcludeSeminarSuccessMessage = 8491,
        LiveEventExcludeSeminarFailedHeader = 8492,
        LiveEventExcludeSeminarFailedMessage = 8493,
        LiveEventExcludeSeminarFailedHasCombinationsMessage = 8494,
        #endregion

        #region Live Event Seminar/Optional Seminar (8495 - 8505)
        LiveEventSaveScheduleCombinationsFailedMessage = 8495,
        LiveEventSaveScheduleCombinationsFailedHeader = 8496,
        LiveEventSaveScheduleCombinationsSuccessMessage = 8497,
        LiveEventSaveScheduleCombinationsSuccessHeader = 8498,
        LiveEventSaveScheduleCombinationsFailedNoSeminarsMessage = 8499,
        LiveEventDeleteCombinationSuccessHeader = 8500,
        LiveEventDeleteCombinationSuccessMessage = 8501,
        LiveEventDeleteCombinationFailedHeader = 8502,
        LiveEventDeleteCombinationFailedMessage = 8503,
        #endregion

        #region AttendanceManagement (8505-8515)/(8551-8560)
        LiveEventAttendanceManagementToggleStatusSuccessMessage = 8505,
        LiveEventAttendanceManagementToggleStatusSuccessHeader = 8506,
        LiveEventAttendanceManagementToggleStatusFailedMessage = 8507,
        LiveEventAttendanceManagementToggleStatusFailedHeader = 8508,
        LiveEventAttendanceManagementInOutTimeValidationSuccess = 8551,
        LiveEventAttendanceManagementInOutTimeValidationFailed = 8552,
        LiveEventAttendanceManagementEmailNotificationSuccessMessage = 8553,
        LiveEventAttendanceManagementEmailNotificationSuccessHeader = 8554,
        LiveEventAttendanceManagementEmailNotificationFailedMessage = 8555,
        LiveEventAttendanceManagementEmailNotificationFailedHeader = 8556,
        LiveEventAttendanceManagementEmailNotificationFailureContent = 8557,
        LiveEventAttendanceManagementEmailNotificationFailureSubject = 8558,

        #endregion

        #region Barcode (8526 - 8550)
        BarcodeInvalidScannedAttendeeMessage = 8526,
        BarcodeScheduleBuinessValidationSuccessfulMessage = 8527,
        BarcodeLocationValidationFailedMessage = 8528,
        BarcodeScheduleEndTimeExpiredMessage = 8529,
        BarcodeScheduleStartTimeOverInitialStartTimeMessage = 8530,
        BarcodeLineItemAttendeeStatusDeletedMessage = 8531,
        BarcodeConcurrentScheduleExistMessage = 8532,
        BarcodeInvalidBarcodeNumberMessage = 8533,
        BarCodeDeleteBarcodeProfessionalTimeEntryDetailsSuccessMessage = 8534,
        BarCodeDeleteBarcodeProfessionalTimeEntryDetailsFailedMessage = 8535,
        BarCodeSaveBarcodeProfessionalTimeEntryDetailsSuccessMessage = 8536,
        BarCodeSaveBarcodeProfessionalTimeEntryDetailsFailedMessage = 8537,
        BarcodeSwapProfessionalSuccess = 8538,
        BarcodeSwapProfessionalFailed = 8539,
        BarcodeBulkSaveSuccessful = 8540,
        BarcodeBulkSaveBusinessValidationFailed = 8541,
        BarcodeSavingBulkFailed = 8542,
        BarcodeBulkOperationSchedulesFoundMessage = 8543,
        BarcodeBulkOperationSchedulesNotFoundMessage = 8544,
        BarcodeCheckInAllSuccess = 8545,
        BarcodeCheckInAllScheduleNotExist = 8546,
        BarcodeCheckInAllFailed = 8547,
        BarcodeSaveBulkOperationSuccessful = 8548,
        BarcodeBulkCheckoutValidationFailed = 8549,
        BarcodeScheduleAttendanceLimitExceeded = 8550,
        BarcodeSwapAndSaveSuccessful = 8580,
        BarcodeInvalidMediaFormat = 8581,
        BarcodeOrderProductExistInCombination = 8582,
        BarcodeOrderProductNotExistInCombination = 8583,
        BarcodeBulkCheckInSchedulesNotFoundMessage = 8584,
        BarcodeBulkCheckOutSchedulesNotFoundMessage = 8585,
        BarcodeInvalidScheduleAtCurrentTimeMessage = 8586,
        BarcodeInvalidEventCodeMessage = 8587,

        #endregion

        #region MyCpe
        MyCpeNoSearchResultsFoundMessage = 8800,
        WebinarRegistrationSuccess = 8801,
        WebinarRegistrationFailed = 8802,
        WebinarUnRegistrationSuccess = 8803,
        WebinarUnRegistrationFailed = 8804,
        WebinarRetailPurchasedMessage = 8805,

        #endregion

    }

    public enum ActionLinkResID : int
    {
        None = 0,
        CPEHome = 1,
        CPESolutions = 2,
        CPEBrands = 3,
        CPECompliance = 8,
        NotedExperts = 9,
        RecentCPEChanges = 10,
        More = 11,
        AdditionalResources = 12,
        Auditing = 15,
        Accounting = 16,
        Ethics = 17,
        Taxation = 18,
        Management = 19,
        PersonalDevelopment = 20,
        CounsultingServices = 21,
        SpecializedKnowledge = 22,
        InformationTechnology = 23,
        YellowBook = 24,
        InHouseTraining = 25,
        LiveSeminarsConferences = 26,
        OnlineLearningWebinars = 27,
        OnlineLearningSelfStudy = 28,
        SelfStudyPrintBased = 29,
        MicroMash = 30,
        PASSOnline = 31,
        GearUp = 32,
        BellLearning = 33,
        PPC = 34,
        IndividualNotedExpert = 35,
        BecomeAuthor = 36,
        NotedAuthor = 37,
        AboutUs = 38,
        ContactUs = 39,
        SiteMap = 40,
        PrivacyPolicy = 41,
        TermsAndConditions = 42,
        LearningLibraries = 43,
        TrainingSolutionsNewsletter = 44,
        CorporateAccounts = 45,
        CustomizedCourses = 46,
        SponsorOpportunities = 47,
        CourseFormats = 65,
        InteractiveCourses = 66,
        FindCourse = 67,
        GAOYellowBook = 68,
        CourseFinder = 69,
        CancellationRefundPolicy = 70,
        MicroMashCancellationRefundPolicy = 71,
        PassOnlineCancellationRefundPolicy = 72,
        BellLearningCancellationRefundPolicy = 73,
        PPCCancellationRefundPolicy = 74,
        RIACancellationRefundPolicy = 75,
        WebinarPartnershipCancellationRefundPolicy = 76,
        GearUpCancellationRefundPolicy = 77,
        ViewCourseInformation = 78,
        CourseList = 79,
        QuickSearch = 92,
        MoreInformation = 93,
        ViewAllCourses = 94,
        SearchAgain = 95,
        ForMoreClickHereToLogin = 96,
        LearningInteractive = 80,
        WebinarLearningNetwork = 81,
        Reqwired = 82,
        PilotTester = 83,
        GearUpCompliance = 84,
        BellLearningCompliance = 85,
        PASSOnlineCompliance = 86,
        MicroMashCompliance = 87,
        PPCCompliance = 88,
        RIACompliance = 89,
        WebinarPartnershipCompliance = 90,

        SalesAndSupport = 91,

        OtherTaxAndAccountingSolution = 355,
        FindaCPECourse = 990,
        WhoAreYouHelpFindWhatYouNeed = 991,

        OnlineLearning = 60,
        SelfStudyCourses = 62,
        Index = 63,
        BecomePilotTester = 64,
        ViewAll = 97,
        HoptTopicSummary = 102,
        OnlineGrading = 103,
        EthicCourses = 104,
        ScheduleInformationMap = 105,
        CPEHotTopics = 106,
        Bailout = 107,
        IFRS = 108,
        PPCSelfStudy = 109,
        ReqwiredSpecialFeatures = 118,
        CPEComplianceManagement = 110,
        CompleteCPETracking = 111,
        ManagingInHouseSeminars = 112,
        SelfServiceCourseRegistration = 113,
        BeyondCPECompliance = 114,
        LearningPathTemplates = 115,
        CoachAccounts = 116,
        ReqwiredMobile = 117,
        CourseDescription = 118,
        IndividualNotedAuthor = 119,
        SearchCPECourseFinder = 125,
        InternalControls = 130,
        AuditWatch = 136,
        UseourinteractiveCourseFindertool = 137,
        WebinarLearningNetworkComplaintPolicy = 138,
        WebinarLearningNetworkCustomerPolicy = 145,
        InternationalFinancialReportingStandards = 120,
        Trainingsolution = 125,
        EmergencyEconomicStabilizationActof2008 = 139,
        CPEbrand = 168,
        ReqwiredLearningLibraries = 255,
        NewCourses = 256,

        EthicsLibrary = 126,
        AandALibrary = 127,
        TaxLibrary = 128,
        YellowBookLibrary = 129,
        SoftSkillsLibrary = 131,
        MixedPracticeLibrary = 132,
        TopSellers = 1076,
        CpeTrainingInteractiveCatalog = 227,
        CpeAndTrainingCatalog = 228,
        SendEmail = 229,
        UpComingWebinars = 300,
        ScheduleInformation = 301,
        ViewLearningLibraries = 302,
        WebinarCustomerPolicies = 310,
        PPCs1040Deskbook = 320,
        OnlineLearningInSiteMap = 321,
        LiveSeminarsConferencesInSiteMap = 322,
        TheAccountingandAuditingLibraries = 323,
        TheYellowBookGovernmentalAuditingLibrary = 324,
        TheTaxLibrary = 325,
        TheSoftSkillsLibrary = 326,
        TheMixedPracticeLibrary = 327,
        TheEthicsLibrary = 328,
        BellLearningGearUpWorkshops = 340,
        ShowLibrary = 341,
        Cart = 342,
        QuickFinder = 343,
        ViewLearningLibrariesHome = 345,
        MyCart = 346,
        Login = 347,
        BillingAndShipping = 348,
        PromoCodes = 349,
        OrderSummary = 350,
        Receipt = 351,
        AddItemsToCart = 352,

        #region Internal Action Link Enums - no changes within region

        // Home Navigation
        InternalHome = 6000,

        // Product Management Navigation
        Resource = 6001,
        SponsorMetadata = 6002,
        CourseMetadata = 6003,
        PilotTest = 6004,
        EventManagement = 6005,
        Grading = 6006,
        ProductionSchedule = 6007,
        LiveEventManagement = 6008,
        OrderEntryManagement = 6012,
        WebinarManagement = 6013,
        PackageManagement = 6014,
        CDShippedDate = 6015,
        // DynamicAssembly
        DynamicAssemblyHome = 6009,
        DynamicAssemblyChapterLinking = 6010,
        DynamicAssemblyReports = 6011,

        MetadataTab = 5009,
        General = 5010,
        SupplementalMaterial = 5011,
        Contributors = 5012,
        CertificationsCredits = 5013,
        Measurement = 5014,
        Marketing = 5015,
        Status = 5016,
        TableOfContent = 5017,

        // Sales & Marketing Navigation
        MarketingContent = 6201,
        SEM = 6202,
        SalesReporting = 6203,
        BusinessAffiliates = 6205,
        Extranets = 6206,
        LMS = 6207,

        Manifest = 6210,
        Reports = 6211,

        // DiscountManagement 
        PromotionManagement = 6204,
        Promotions = 6208,
        ExcludeProducts = 6209,

        // Support
        TechnicalCustomerSupport = 6301,
        Help = 6302,
        Administrations = 6303,
        Settings = 6304,
        ProductReconciliation = 6305,

        Sponsor = 6051,

        //Cutom Product List
        CutomProductList = 6052,

        //Auto Notification of Courses
        EmailManagement = 6053,

        #endregion

        #region Checkpoint MetaTab Langing page - no changes within region
        CPMetaTabHome = 6500,
        #endregion

        HotTopic1 = 500,
        HotTopic2 = 501,
        HotTopic3 = 502,
        HotTopic4 = 503,
        HotTopic5 = 504,
        HotTopic6 = 505,
        HotTopic7 = 506,
        HotTopic8 = 507,
        HotTopic9 = 508,
        HotTopicA = 509,
        HotTopicB = 510,

        SignOut = 999,

    }

    public enum LogMessageResID : int
    {
        None = 0,
        ServiceGetAllCustomersCalled=1,
        #region old code
        //DataSetConvertInfo = 1,
        DataSetConvertSucess = 2,
        InvokeCourseService = 3,
        PerformQuickSearch = 4,
        ReceivedDataFromService = 5,
        DatabaseService = 6,
        ExcuteQuery = 7,
        UnableToSendEmail = 8,
        GetNotedExpertCalled = 9,
        GetNotedAuthorCalled = 10,
        GetAuthorDetailsCalledWith = 11,
        SaveRequestInformationCalled = 12,
        GetInhouseCourseDetailsCalled = 13,
        GetInhouseCourseDeliveryFormatDetailsCalled = 14,
        GetStatesDetailsCalled = 15,
        GetUpComingWebinarsCalled = 16,
        GetWebinarDeliveryFormatListCalled = 17,
        GetUpComingWebinarsRecordCountCalled = 18,
        GetSchedulesByProductMetaDataCalled = 19,
        GetProductMetaDataDetailsCalled = 20,
        GetCourseDeliveryFormatDetailsCalled = 21,
        GetStatesQueryBuilderCalled = 22,
        GetNewCourseDetails = 23,
        GetNewCoursesRecordCount = 24,
        GetBasicSearchCourseDetails = 25,
        GetSearchRecordCountCalled = 26,
        GetEthicCourseDetails = 27,
        GetGMapLoationCalled = 29,
        ServiceSaveRequestInformationCalled = 30,
        ServiceGetInhouseCourseDetailsCalled = 31,
        ServiceGetUpcomingWebinarsCalled = 32,
        ServiceGetSchedulesByProductMetaDataCalled = 33,
        ControllerRequestForInformationCalled = 40,
        ControllerPostRequestForInformationCalled = 41,
        ControllerCourseScheduleCalled = 42,
        ControllerPostCourseScheduleCalled = 43,
        ControllerUpComingWebinarsCalled = 44,
        ControllerPostUpComingWebinarsCalled = 45,
        GetCourseDescription = 46,
        GetCoursesByLibraryCalled = 47,
        GetSelfStudyDeliveryFormatListCalled = 48,
        ControllerSendEmailCalled = 50,
        ControllerSendEmailCalledWith = 51,
        ServiceSendEmailCalledWith = 52,
        ControllerGAOYellowBookCalled = 53,
        SeriviceGetInteractiveGAOYellowBookCourseListCalled = 54,
        GetCourseListByFieldOfStudyIdCalledWith = 55,
        GetDeliveryFormatOfGAOYellowBookCalled = 56,
        ServiceGetGMapLoationCalled = 57,
        ServiceGetCoursesByLibraryCalled = 58,
        GetLibraryListCalled = 59,
        ServiceGetLibraryListCalled = 60,
        ControllerEthicCoursesCalled = 61,
        ControllerNewCourseListCalled = 62,
        ServiceGetCourseListCalled = 63,
        GetSearchResultsCalled = 64,
        ControllerSalesReportCalled = 65,
        ServiceGetSearchMarketingSalesSummaryCalled = 66,
        BusinessGetSearchMarketingSalesSummaryCalled = 67,
        GetAdvancedResultsCalled = 68,
        GetAdvancedSearchRecordCountCalled = 69,
        BusinessSaveVisitInformationCalled = 70,
        BusinessgetNextCookieIDCalled = 71,
        ServiceSaveVisitInformationCalled = 72,
        DBServiceExecuteDataSet = 73,
        DBServiceExecuteNonQuery = 74,
        //Resource Repository
        BusinessGetAddressTypeListCalled = 75,
        BusinessGetResourceStatusListCalled = 76,
        BusinessGetRecordStatusListCalled = 77,
        BusinessGetPhoneTypeListCalled = 78,
        BusinessGetEmailTypeListCalled = 79,
        BusinessGetPrimaryGroupListCalled = 80,
        BusinessGetUserListCalled = 81,
        BusinessGetCredentialStatusListCalled = 82,
        BusinessGetCertificateTypeListCalled = 83,
        BusinessGetRolesListCalled = 84,
        ControllerInternetSalesReportCalled = 85,
        BusinessGetInternetSalesSummeryCalled = 86,
        ServiceGetInternetSalesSummeryCalled = 87,
        BusinessGetFormListCalled = 88,
        BusinessGetExternalAffiliatesListCalled = 89,
        ServiceDeleteUserAuthorizationCalled = 90,
        GetDeliveryFormatListByCourseIdCalled = 91,
        ServiceGetManageUserProfileCalled = 92,
        ServiceGetManageUserProfileWithIdCalled = 93,
        ServiceGetGALUserListCalled = 94,
        BusinessGetPersonalInformationCalled = 95,
        BusinessSaveUserAuthorizationCalled = 96,
        BusinessDeleteUserAuthorizationCalled = 97,
        BusinessGetResourceListCalled = 98,
        ServiceGetUserDetailsByUserNameCalled = 99,
        ServiceSaveUserAuthorizationCalled = 100,
        BusinessSaveResourceCalled = 103,
        BusinessGetResourceInformationCalled = 104,
        BusinessGetManageUserProfileCalled = 105,
        BusinessGetManageUserProfileWithUserIdCalled = 106,
        BusinessGetContactInformationCalled = 107,
        BusinessGetProfessionalInformationCalled = 108,
        ServiceGetContactInformationCalled = 109,
        ServiceGetResourceInformationCalled = 111,
        BusinessGetResourcePaymentDetailsCalled = 112,
        BusinessGetAssociatedCourseInformationCalled = 113,
        ServiceGetPersonalInformationCalled = 114,
        BusinessGetSponsorPageCalled = 115,
        BusinessSponsorSearchCalled = 116,
        BusinessGetSponsorByCodeCalled = 117,
        BusinessGetGlobalTextSectionCalled = 118,
        BusinessGetRecordCountCalled = 119,
        BusinessSaveSponsorCalled = 120,
        BusinessSaveSponsorPageCalled = 121,
        BusinessSaveGlobalTextsCalled = 122,
        BusinessDeleteSponsorCalled = 123,
        BusinessDeleteSponsorPageCalled = 124,
        ServiceGetSponsorPageCalled = 125,
        ServiceGetGlobalTextsCalled = 126,
        ServiceGetSponsorByCodeCalled = 127,
        ServiceSaveSponsorCalled = 128,
        ServiceSaveSponsorPageCalled = 129,
        ServiceSponsorSearchCalled = 130,
        ServiceDeleteSponsorCalled = 131,
        ServiceDeleteSponsorPageCalled = 132,
        ServiceSaveGlobalTextsCalled = 133,
        ServiceSearchProductsCalled = 134,
        ControllerPersonalInformationCalled = 135,
        ControllerSaveCommunicationRecordCalled = 136,
        ServiceGetAssociatedCourseInformationCalled = 137,
        ControllerProfessionalInformationCalled = 138,
        GetStateListCalled = 139,
        GetStateListByCountryIdCalled = 140,
        GetCountryListCalled = 141,
        BusinessGetResourceRolesForCourseCalled = 142,
        ServiceSavePersonalInformationCalled = 143,
        BusinessSavePersonalInformationCalled = 144,
        ServiceSaveResourceCommunicationRecordCalled = 145,
        BusinessSaveResourceCommunicationRecordCalled = 146,
        BusinessGetSponsorStatusListCalled = 149,
        BusinessGetCourseListCalled = 150,
        BusinessSaveSponsorVisitCalled = 160,
        ServiceSaveSponsorVisitCalled = 161,
        ServiceGetProfessionalInformationCalled = 162,
        BusinessSaveProfessionalInformationCalled = 163,
        DBServiceExecuteScalar = 164,
        ControllerSaveProfessionalInformationCalled = 165,
        ControllerSaveResourceCertificateCalled = 166,
        ControllerDeleteResourceCertificateCalled = 167,
        BusinessSaveManageUserProfileCalled = 179,
        BusinessTableOfContextCalled = 180,
        ServiceTableOfContextCalled = 181,
        BusinessSaveAssociatedCourseInformationCalled = 185,
        ControllerEditResourceCertificateCalled = 186,
        ServiceSaveManageUserProfileCalled = 187,
        ControllerSearchActiveDirectoryUserCalled = 188,
        ControllerManageUserProfileCalled = 189,
        ControllerUserDetailsCalled = 190,
        ControllerAddPrimaryGroupCalled = 191,
        ControllerDeletePrimaryGroupCalled = 192,
        ControllerSelectActiveDirectoryUserCalled = 193,
        ControllerSaveUserDetailsCalled = 194,

        BusinessDeleteResourcePaymentInfoCalled = 195,
        BusinessGetResourceInformationRecordCount = 196,
        BusinessSaveResourceGroupCalled = 197,
        BusinessGetResourceGroupDetailsCalled = 198,
        BusinessDeleteResourceGroupCalled = 199,
        BusinessSaveResourceInformationCalled = 200,
        BusinessSaveResourcePaymentInfoCalled = 201,

        ServiceGetResourceInformationSearchCalled = 202,
        ServiceSaveResourceInformationCalled = 203,
        ServiceSaveResourcePaymentInfoCalled = 204,
        ServiceSaveResourceGroupCalled = 205,
        ServiceDeleteResourcePaymentInfoCalled = 206,
        ServiceDeleteResourceGroupCalled = 207,
        ServiceGetResourceInformationRecordCountCalled = 208,
        ServiceGetContactListByGroupIdCalled = 209,

        ControllerGroupDetailsCalled = 210,
        ControllerSaveResourceCalled = 211,
        ControllerDeleteGroupCalled = 212,
        ControllerDeletePaymentInfoCalled = 213,
        ControllerSaveGroupCalled = 214,
        ControllerSavePaymentInfoCalled = 215,
        ControllerResourceInformationCalled = 216,

        BusinessGetTimeZoneListCalled = 217,
        BusinessGetCourseDetailsCalled = 218,
        BusinessGetResourceProductDetailsForCourseCalled = 219,
        ServiceGetCourseDetailsCalled = 220,
        ServiceSaveAssociatedCourseInformationCalled = 221,
        ServiceDeleteCourseCalled = 222,
        ControllerAssociatedCourseInfoCalled = 223,
        ControllerAssociatedCoursesCalled = 224,
        ControllerAddCourseCalled = 225,
        ControllerDeleteCourseCalled = 226,
        ControllerEditCourseCalled = 227,
        BusinessValidateResourceAddressCalled = 228,
        BusinessValidateResourcePhoneCalled = 229,
        BusinessValidateResourceEmailCalled = 230,

        ControllerClearGroupCalled = 231,
        ControllerClearPaymentInfoCalled = 232,
        BusinessValidatedAssociatedCoursesCalled = 233,

        BusinessKeyWordSearchCalled = 234,
        ServiceKeyWordSearchCalled = 235,

        ControllerResetGroupAndPaymentInfoCalled = 236,
        BusinessValidateResourceCertificateCalled = 237,
        ServiceDeleteResourceCalled = 238,
        BusinessDeleteResourceCalled = 239,

        ControllerSortPrimaryGroupCalled = 240,

        // Notification Service
        SendNotificationStart = 241,
        SendNotificationEnd = 242,
        SendingNotification = 243,
        DeliveryForSomeRecipientsFailed = 244,
        MessageIsPureString = 245,
        BusinessGetNotificationInitializeDataCalled = 246,

        BusinessSaveReportInstanceCalled = 247,
        BusinessEditReportInstanceCalled = 248,
        BusinessDeleteReportCalled = 249,
        BusinessRetrieveLastModifiedInstancesCalled = 250,
        BusinessRetrieveReportInstanceCalled = 251,
        BusinessgetReportListCalled = 252,
        BusinessGetPilotTestTestersOfPilotTestCalled = 258,
        BusinessGetPilotTestTesterCalled = 259,

        //Reports
        ServiceGetReportDefintionCalled = 260,
        ServiceGetReportInstanceDefinitionCalled = 261,
        ServiceSaveReportInstanceCalled = 262,
        ServiceGetLastModifiedInstancesCalled = 263,
        ServiceGeInstancesByReportIdCalled = 264,
        ServiceGetReportOperatorsCalled = 265,
        ServiceDeletedReportInstanceCalled = 266,
        ServiceGetGeneratedReportCalled = 267,
        ServiceGetReportDetailsCalled = 4285,
        BusinessSavePilotTestTesterCalled = 268,
        BusinessAddPilotTestersToPilotTestCalled = 269,

        ControllerPilotTestCalled = 270,
        ControllerPilotTestsCalled = 271,
        ControllerSearchPilotTestsCalled = 272,
        ControllerManagePilotTestsCalled = 273,
        ControllerPilotTestsExcelExportCalled = 274,
        ControllerStatusReportCalled = 275,

        ServiceGetPilotTestCalled = 276,
        ServiceGetPilotTestsAsExcelDocumentCalled = 277,
        ServiceGetStatusReportCalled = 278,
        ServiceSaveStatusReportCalled = 279,
        ServiceGetStatusReportAsExcelDocumentCalled = 280,
        ServiceSavePilotTestCalled = 281,
        ServiceSearchPilotTestCalled = 282,

        BussinessSearchPilotTestCalled = 283,
        BussinessGetPilotTestCalled = 284,
        BussinessGetPilotTestCourseInformationCalled = 285,
        BussinessGetPilotTestStatusesListCalled = 286,
        BussinessSavePilotTestCalled = 287,
        BussinessGetPilotTestStatusReportDataCalled = 288,
        BussinessGetPilotTestDurationDataCalled = 289,
        BussinessSaveStatusReportCalled = 290,
        BusinessSearchPilotTestersCalled = 291,
        ServiceAddTestersToPilotTestCalled = 292,
        ServiceSearchPilotTestersCalled = 293,
        ServiceGetAddPilotTestInitializingDataCalled = 294,
        ServiceSavePilotTestTesterCalled = 295,
        ServiceGetPilotTestTesterCalled = 296,
        ServiceGetPilotTestTestersCalled = 297,
        ControllerPilotTestersCalled = 298,
        ControllerUpdatePilotTesterCalled = 299,
        ControllerAddPilotTestersCalled = 300,
        ControllerSearchTestersCalled = 301,

        ControllerEmailTemplatesCalled = 302,
        ControllerUpdateEmailTemplateCalled = 303,
        ControllerSaveEmailTemplateCalled = 304,
        ControllerDeleteEmailTemplateCalled = 305,
        ControllerEmailTemplateSearchResultCalled = 306,
        ServiceSaveEmailTemplateCalled = 307,
        ServiceGetEmailTemplateCalled = 308,
        ServiceDeleteEmailTemplateCalled = 309,
        ServiceSearchEmailTemplateCalled = 310,

        ServiceGetNasbaReportCalled = 311,
        BussinessDeleteEmailTemplateCalled = 312,
        BussinessGetEmailTemplateCalled = 313,
        BussinessSaveEmailTemplateCalled = 314,
        BussinessSearchEmailTemplateCalled = 315,

        ControlNasbaReportCalled = 316,
        ControlNasbaReportPostCalled = 317,
        ControlNasbaReportSearchResultCalled = 318,
        ServiceGetGetBrandsCalled = 319,

        BusinessValidateUserSessionInformationCalled = 322,
        BusinessValidateUserCalled = 323,


        BusinessGetPilotTesterCalled = 324,
        BusinessSaveProfessionalCalled = 325,


        BusinessValidateAdminUserCalled = 326,
        BusinessCreateUserSessionCalled = 327,
        BusinessUpdateUserSessionCalled = 328,
        BusinessRemoveUserSessionCalled = 329,
        BusinessExpireUserSessionCalled = 330,
        BusinessWriteSharedSessionValueCalled = 331,
        BusinessReadSharedSessionValueCalled = 332,
        BusinessUpdatePilotTesterCalled = 333,
        BusinessGetProfessionalByIdCalled = 334,
        ServiceGetPilotTesterCalled = 335,
        ServiceUpdatePilotTesterCalled = 336,
        ServiceLoginCalled = 337,
        ServiceLogoutCalled = 338,
        ServiceExpireUserSessionCalled = 339,

        /// <summary>
        /// Online Grading codes
        /// </summary>
        ServiceOGSGetBrandsCalled = 340,
        BussinessOGSSearchPurchaseExamsCalled = 341,
        ControllerLoginCalled = 342,
        ControllerLogoutCalled = 343,
        ControllerRedirectCalled = 344,
        BusinessValidateEMailListCalled = 345,
        BusinessValidateSecurityAnswerListCalled = 346,

        ServiceUpdateUserSessionCalled = 347,
        ServiceSetSharedSessionValue = 348,

        ControllerUserProductAssociationCalled = 349,
        ControllerUserProductAssociationNextCalled = 350,
        ControllerUserProductAssociationPreviousCalled = 351,
        ControllerAddTRProductsCalled = 352,
        ControllerDeleteTRProductCalled = 353,
        ControllerEditProductCalled = 354,

        ServiceGetUserNameCalled = 355,
        ServiceGetPasswordCalled = 356,
        ServiceGetSecurityQuestionAnswerListByEmailCalled = 357,
        ServiceValidateUserCalled = 358,
        ServiceValidateEMailList = 359,

        BusinessGetSecurityQuestionAnswerListByEmailCalled = 360,
        BussinessOGSGetExamQuestionDetailsCalled = 361,

        /* Table Of Content */
        BusinessGetTOCCoursesCalled = 362,
        BusinessGetTOCRecordsCalled = 363,
        ServiceGetTOCCoursesCalled = 364,
        ServiceGetTOCRecordsCalled = 365,
        ControllerGetTOCCoursesCalled = 366,
        ControllerGetTOCRecordsCalled = 367,

        BusinessSortTOCCoursesCalled = 368,
        Other_B_Called = 369,

        BusinessOGSGetExamQuestionsCountCalled = 370,
        ServiceGetSharedSessionValuesCalled = 371,

        BussinessOGSAddExamAttemptCalled = 372,
        BussinessOGSSaveSaveAttemptAnswersCalled = 373,
        BussinessOGSCompleteExamAttemptCalled = 374,
        ServiceValidateUserSessionCalled = 375,

        ServiceSaveProfessionalCalled = 379,
        BusinessValidateUserNameCalled = 380,
        ServiceValidateUserNameCalled = 381,

        BusinessGetSalutationListCalled = 397,
        BusinessProfGetAddressTypeListCalled = 398,
        BusinessProfGetPhoneTypeListCalled = 399,
        BusinessProfGetEmailTypeListCalled = 400,
        BusinessGetProductTypeListCalled = 401,
        BusinessGetSecurityQuestionListCalled = 402,
        BusinessGetFielOfStudyListCalled = 403,
        ServiceGetProfessionalByIdCalled = 404,
        ServiceProfValidateUserCalled = 405,
        ServiceGetProfessionalReferenceCalled = 406,

        BussinessOGSGetPurchaseExamsCountCalled = 407,
        BussinessOGSGetMyExamsPageDataCalled = 408,

        ServiceOGSGetPurchaseExamsPageDataCalled = 409,
        ServiceOGSGetMyExamsPageDataCalled = 410,
        ServiceOGSGetExamQuestionsPageDataCalled = 411,
        ServiceOGSGetExamResultPageDataCalled = 412,
        ServiceOGSCompleteExamAttemptCalled = 413,
        ServiceOGSSaveAttemptAnswersCalled = 414,
        BussinessOGSGetPurchasedExamsCountCalled = 415,
        BussinessOGSGetInProgressExamsCountCalled = 416,
        BussinessOGSGetExamLastAttemptDetailsCalled = 417,

        ControllerOGSIndexCalled = 418,
        ControllerOGSWelComeCalled = 419,
        ControllerOGSPurchaseExamsCalled = 420,
        ControllerOGSPurchaseExamsSearchCalled = 421,
        ControllerOGSPostLoginHomeCalled = 422,
        ControllerOGSPostLoginExamPurchasedCalled = 423,
        ControllerOGSPostLoginExamsInProgressCalled = 424,
        ControllerOGSExamsInProgressCalled = 425,
        ControllerOGSExamsPurchasedCalled = 426,
        ControllerOGSOnlineExamsCalled = 427,
        ControllerOGSOnlineExamQuestionsCalled = 428,
        ControllerOGSExamResultsCalled = 429,


        BussinessOGSSearchCatalogCalled = 430,
        ServiceValidateProfessionalUserCalled = 431,
        BussinessOGSGetCourseIdCalled = 432,
        ServiceOGSGetCourseIdCalled = 433,

        BusinessGetGeneratedReportCalled = 440,
        BusinessGetGeneratedReportRowCountCalled = 441,
        BusinessGetReportDefinitionCalled = 442,

        ServicePingFederateLoginCalled = 443,
        ServicePingFederateValidateUserCalled = 444,

        ControllerUserRegistrationCalled = 446,
        ControllerProfessionalAddAddressCalled = 447,
        ControllerProfessionalEditAddressCalled = 448,
        ControllerProfessionalDeleteAddressCalled = 449,
        ControllerProfessionalAddEmailCalled = 450,
        ControllerProfessionalEditEmailCalled = 451,
        ControllerProfessionalDeleteEmailCalled = 452,
        ControllerProfessionalAddPhoneCalled = 453,
        ControllerProfessionalEditPhoneCalled = 454,
        ControllerProfessionalDeletePhoneCalled = 455,
        ControllerProfessionalValidateEmailCalled = 456,
        ControllerUserCredentialCalled = 457,
        ControllerProfessionalValidateUserNameCalled = 458,
        ControllerProfessionalValidateUserCalled = 459,
        ServiceUnsubscribeTesterCalled = 460,

        ServiceGetProfessionalProfileByIdCalled = 461,
        BusinessGetProfessionalProfileByIdCalled = 462,

        BusinessGetProfessionalProductAssociationByIdCalled = 463,
        BusinessGetProfessionalPilotTestByIdCalled = 464,
        BusinessUpdateProductAssociationCalled = 465,
        BusinessUpdatePilotTestCalled = 466,
        ServiceGetProfessionalPilotTestByIdCalled = 467,
        ServiceGetProfessionalProductAssociationByIdCalled = 468,
        ServiceUpdateProductAssociationCalled = 469,
        ServiceUpdatePilotTestCalled = 470,

        ServiceUpdateProfileCalled = 471,
        BusinessUpdateProfileCalled = 472,
        ControllerUpdateProfileCalled = 473,

        BussinessOGSSearchCatalogCountCalled = 474,
        ServiceOGSSearchCatalogCalled = 475,

        ControllerUserCredentialPreviousCalled = 476,

        BussinessUpdatePurchaseInformationCalled = 477,
        ServiceUpdatePurchaseInformationCalled = 478,

        BusinessGetTimeZoneCodeCalled = 479,
        ServiceGetTimeZoneCodeCalled = 480,

        ServiceGetProfessionalProductAssociationViewByIdCalled = 481,
        ServiceGetSecurityQuestionListByUserNameEmailCalled = 482,
        BusinessGetProfessionalIdByEmailCalled = 483,
        BusinessGetSecurityQuestionListByIdCalled = 484,
        BusinessGetProfessionalLoginSecurityByIdCalled = 485,
        BusinessUpdateLoginSecurityCalled = 486,



        BusinessOGSGetExamOwnerByExamIdCalled = 490,
        ServiceOGSSendExamOwnerChangeNotificationCalled = 491,
        ServiceOGSSendExamCompletedNotificationCalled = 492,


        ControllerOgsCatalogCalled = 487,
        ControllerOgsSearchCatalogCalled = 488,
        ControllerOGSQuestionsCalled = 489,
        ControllerOGSDeleteQuestionCalled = 493,
        ControllerOGSPreviewQuestionCalled = 494,
        ControllerOGSImportQuestionsCalled = 495,
        ControllerOGSUploadQuestionsCalled = 496,
        ControllerOgsSaveCatalogCalled = 497,
        ControllerOgsModifyCatalogCalled = 498,
        ControllerOgsDeleteCatalogCalled = 499,
        ControllerOgsExamsCalled = 500,
        ControllerOgsSearchExamsCalled = 501,
        ControllerOgsNewExamCalled = 502,
        ControllerOgsGetCourseDetailsCalled = 503,
        ControllerOgsExamDetailsCalled = 504,
        ControllerOgsNotesAndActivityCalled = 505,
        ControllerOgsDeleteNotesAndActivitiesCalled = 506,
        ControllerOgsVersioningCalled = 507,
        ControllerOgsPilotTestCalled = 508,
        ControllerOgsEmailTemplatesCalled = 509,
        ControllerOgsNewEmailTemplateCalled = 510,
        ControllerOgsModifyExamCalled = 511,
        ControllerOgsOnlineExamCalled = 512,
        //ControllerOgsOnlineExamQuestionsCalled=513,
        //ControllerOgsExamResultsCalled=514,
        ControllerOgsSearchQuestionsCalled = 515,
        ControllerOgsQuestionDetailsCalled = 516,
        ControllerOgsAddAnswersCalled = 517,
        ControllerOgsDeleteAnswersCalled = 518,
        ControllerOgsEditAnswersCalled = 519,
        GetOgsCatalogIdByUnisonIdCalled = 520,

        //Online Grading - Remaining
        BusinessGetExamDetailsCalled = 530,
        BusinessOgsGetCourseDetailsCalled = 531,
        BusinessCreateExamCalled = 532,
        BusinessGetExamNotesAndActivitiesCalled = 533,
        BusinessSaveExamNoteAndActivityCalled = 534,
        BusinessDeleteExamNoteAndActivityCalled = 535,
        BusinessGetExamQuestionsCalled = 536,
        BusinessGetExamQuestionsRecordsCountCalled = 537,
        BusinessDeleteExamQuestionAndAnswersCalled = 538,
        BusinessDeleteSaveExamQuestionCalled = 539,
        BusinessSaveExamAnswerCalled = 540,
        BusinessGetExamQuestionAnswersByExamQuestionIdCalled = 541,
        BusinessGetExamQuestionAnswersByExamIdCalled = 542,
        BusinessUpdateExamStatusCalled = 543,
        BusinessCheckIsExamAvailableCalled = 544,

        // Online Grading service 
        ServiceOGSGetPurchaseExamsCalled = 545,
        ServiceOGSGetOgsExamResultCalled = 546,
        ServiceOGSCompleteOgsExamAttemptCalled = 547,
        ServiceOGSSaveOgsExamAttemptAnswersCalled = 548,
        ServiceOGSGetCourseAcronymeCalled = 549,
        ServiceOGSGetExamDetailsCalled = 550,
        ServiceOGSGetCourseDetailsCalled = 551,
        ServiceOGSGetNotesAndActivitiesCalled = 552,
        ServiceOGSSearchExamsCalled = 553,
        ServiceOGSSaveExamNoteAndActivityCalled = 554,
        ServiceOGSDeleteExamNoteAndActivityCalled = 555,
        ServiceOGSGetExamQuestionsCalled = 556,
        ServiceOGSDeleteExamQuestionAndAnswersCalled = 557,
        ServiceOGSSaveExamQuestionCalled = 558,
        ServiceOGSGetExamQuestionAndAnswersByExamQuestionIdCalled = 559,
        ServiceOGSSaveExamCalled = 560,
        ServiceOGSUpdateExamStatusCalled = 561,
        ServiceOGSGetExamQuestionsWithAnswersCalled = 562,
        ServiceOGSDeleteExamCatalogCalled = 563,
        ServiceOGSGetAddCatalogPageDataCalled = 564,
        ServiceOGSGetUpdateCatalogCalled = 565,
        ServiceOGSSaveExamCatalogCalled = 566,
        ServiceOGSGenerateVersionCalled = 567,
        ServiceOGSGetVersionsCalled = 568,
        ServiceOGSUpdateQuestionCalled = 569,
        ServiceOGSImportQuestionsAndAnswersCalled = 570,
        ServiceOGSGetMyOgsExamsCalled = 571,

        BussinessGetUpdateCatalogCalled = 572,
        BusinessViewExamCalled = 573,
        BusinessCheckIsCourseMeasurementAvailableCalled = 574,
        BusinessGetExamVersionsCalled = 575,
        BusinessUpdateExamQuestionCalled = 576,
        BusinessUpdateExamQuestionAnswerCalled = 577,
        BusinessUpdateExamDetailsCalled = 578,
        BusinessArchiveExamsCalled = 579,
        BusinessGetExamQuestionByExamQuestionIdCalled = 580,
        BusinessGetExamAnswerOptionsCalled = 581,
        BusinessDeleteExamQuestionAnswersCalled = 582,
        BusinessSearchExamsCalled = 583,
        BusinessGetSearchedExamsCountCalled = 584,
        BusinessDeleteExamCatalogCalled = 585,
        BusinessGetAddNewCatalogDataCalled = 586,
        BusinessSaveExamCatalogCalled = 587,
        BussinessOGSGetPurchaseExamsCalled = 588,
        BussinessOGSGetCourseAcronymeCalled = 589,
        BussinessOGSGetMyExamsCalled = 590,
        BussinessOGSGetOgsPurchasedExamsCountCalled = 591,
        BussinessOGSGetOgsInProgressExamsCountCalled = 592,
        BussinessOGSGetFailedAttemptCountForExamCalled = 593,
        BussinessOGSGetFailedUserCountForExamCalled = 594,
        BussinessOGSGetOgsExamLastAttemptDetailsCalled = 595,
        BussinessOGSCreateExamAttemptCalled = 596,
        BussinessOGSCompleteOgsExamAttemptCalled = 597,
        BussinessOGSGetUnitNumberByProfessionalIdCalled = 598,
        BussinessOGSSaveOgsExamAttemptAnswersCalled = 599,

        ControllerPreviewCourseCalled = 600,

        ServiceSharedGetMacrosCalled = 601,
        ServiceSharedGetEmailTemplatesByModuleIdCalled = 602,
        ServiceSharedGetEmailTemplateCalled = 603,
        ServiceSharedGetEmailTemplateDetailsCalled = 604,
        ServiceSharedSaveEmailTemplateCalled = 605,
        ServiceSharedDeleteEmailTemplateCalled = 606,
        ServiceSharedGetEmailSenderListCalled = 607,
        ServiceSharedGetEmailSenderDetailsCalled = 608,
        ServiceSharedSaveEmailSenderDetailsCalled = 609,
        ServiceSharedDeleteEmailSenderDetailsCalled = 610,

        ServiceOGSEntitlementGetPurchasedUnisonIdsCalled = 611,
        ServiceOGSIsExamPurchasedCalled = 612,
        ServiceOGSEntitlementUpdateExamStatusCalled = 613,

        BusinessUpdateOgsPropertiesCalled = 614,

        ControllerSharedPreviewTemplateCalled = 615,
        ControllerSharedModifyEmailTemplateCalled = 616,
        ControllerSharedNewEmailTemplateCalled = 617,
        ControllerSharedEmailSenderDetailsCalled = 618,
        ControllerSharedSaveSenderDetailsCalled = 619,
        ControllerSharedDeleteSenderCalled = 620,
        ControllerSharedSaveEmailTemplateCalled = 621,
        ControllerSharedGetEmailTemplateListCalled = 622,

        ControllerTesterProfilesCalled = 623,
        ControllerUpdateTesterProfileCalled = 624,
        ControllerTesterProfilesExportToExcelCalled = 625,

        ServiceGetProfessionalProfileCalled = 626,
        ServiceGetTesterProfilesAsExcelDocumentCalled = 627,
        BusinessUpdatePilotTesterStatusCalled = 628,

        BusinessGetCurrentUserDetailsBySafeUserIdCalled = 629,

        ControllerPreviewPhotoCalled = 630,

        ServiceOGSEntitlementAddActivityForProfessionalCalled = 631,
        ServiceOGSEntitlementUpdateActivityForProfessionalCalled = 632,
        ServiceOGSEntitlementAddExamActivityForProfessionalCalled = 633,
        ServiceOGSEntitlementUpdateExamActivityForProfessionalCalled = 634,

        BusinessGetEmailSenderListCalled = 635,
        BusinessSaveEmailSenderDetailsCalled = 636,
        BusinessDeleteEmailSenderDetailsCalled = 637,
        BusinessGetTimeZoneDetailsByTimeZoneCodeCalled = 638,
        BusinessGetEmailTemplatesByModuleIdCalled = 639,

        ControllerReportsValidateReportInstanceCalled = 640,
        ServiceReportsIsReportInstanceExistCalled = 641,
        BusinessReportsIsReportInstanceExistCalled = 642,
        ControllerReportsDeleteReportInstanceCalled = 643,


        BusinessGetPilotTestIdByCourseMetadataIdCalled = 654,
        ServiceGetPilotTestIdByCourseMetadataIdCalled = 655,
        //information to check legacy system user ID
        LegecySystemUserID = 656,

        //Online grading Component log messages
        BussinessOGSGetExamDetailsForUnisonIdsCalled = 657,
        BussinessEntitlementGetUnitNumberByFirmIdCalled = 658,

        //Online grading service log messages
        ServiceOGSGetFirmAdminMyExamsCalled = 659,

        //Lifecycle execution process messages in reporting framework
        ListOfExamsReportPreProcess = 660,
        //Reportcomponent GetFilterItemListByReportColumnId Log message
        BusinessGetFilterItemListByReportColumnIdCalled = 661,
        // ReportService GetFilterItemListByReportColumnId Log message
        ServiceGetFilterItemListByReportColumnIdCalled = 662,
        PickNBundlesReportPreProcess = 663,
        BusinessClearReportLifeCycleTableDataCalled = 664,
        //Defect fix for #85059 
        ServiceCheckIfPilotTestCourseCompletedCalled = 665,
        BusinessIsPilotTestCourseCompletedCalled = 666,


        //Start - Live event log messages - 1451 to 1500
        LiveEventServiceSaveLiveEventDetailCall = 1451,
        LiveEventComponentSaveLiveEventDetailCall = 1452,
        LiveEventComponentDeleteLiveEventCall = 1453,
        LiveEventComponentDeleteLiveEventCredits = 1454,

        LiveEventComponentDeleteNasbaFosCreditsCall = 1454,
        LiveEventServiceDeleteLiveEventCalled = 1455,
        LiveEventComponentAddNasbaFosCreditsCall = 1456,
        SharedComponentsGetCollegesCalled = 1457,
        SharedComponentsGetNasbaDeliveryFormatsCalled = 1458,
        SharedComponentsGetCourseDeliveryFormatsCalled = 1459,
        LiveEventServiceSearchLiveEventsCalled = 1460,
        LiveEventComponentSearchLiveEventsCall = 1461,
        LiveEventServiceGetSearchPageDataCalled = 1462,
        LiveEventServiceGetDetailPageDataCalled = 1463,

        AgendaControllerHelperAgendaCalled = 1464,
        AgendaControllerHelperGetAgendaDetailsCalled = 1465,
        AgendaControllerHelperGetSeminarAgendaTopicDetailsCalled = 1466,
        AgendaControllerHelperUpdateSeminarAgendaDetailsCalled = 1467,
        CourseMetadataServiceGetAgendaDetailsCalled = 1468,
        CourseMetadataServiceGetSeminarAgendaTopicDetailsCalled = 1469,
        CourseMetadataServiceUpdateSeminarAgendaDetailsCalled = 1470,
        CourseMetadataComponentGetNasbaFosListValuesCalled = 1471,
        CourseMetadataComponentGetSeminarDaysCalled = 1472,
        CourseMetadataComponentGetAgendaDetailsCalled = 1473,
        CourseMetadataComponentGetSeminarAgendaDetailsRecordCountCalled = 1474,
        CourseMetadataComponentGenerateSeminarAgendaSelectQueryCalled = 1475,
        CourseMetadataComponentGetSeminarAgendaTopicDetailsCalled = 1476,
        CourseMetadataComponentAddSeminarAgendaDetailsCalled = 1477,
        CourseMetadataComponentUpdateSeminarAgendaDetailsCalled = 1478,
        CourseMetadataComponentIsSeminarScheduleAvailableCalled = 1479,
        CourseMetadataServiceDeleteSeminarAgendaTopicCalled = 1480,
        CourseMetadataServiceSynchronizeAgendaCalled = 1481,
        AgendaControllerHelperDeleteSeminarAgendaTopicCalled = 1482,
        CourseMetadataComponentDeleteScheduleAgendaCalled = 1483,
        CourseMetadataComponentUpdateScheduleAgendaCalled = 1484,
        CourseMetadataComponentGetSeminarSchedulesCalled = 1485,
        CourseMetadataComponentDeleteSeminarAgendaTopicCalled = 1486,
        CourseMetadataComponentIsAgendaUnderwayCalled = 1487,
        CourseMetadataComponentGetScheduleTimeDetailsCalled = 1485,

        //End of Live event log messages - 1451 to 1500	

        //
        // Promo codes
        //
        GetPromoCodes,
        GetAutomaticPromoCodes,
        GetPromoCodeRules,
        UpsertPromoCode,
        GetCriteriaValues,
        GetCardID,
        UpdateLastLineNumber,
        UpdateCartSession,

        //
        // Metadata
        //
        ServiceGetMaxNumberOfDaysCalled,
        BusinessGetMaxNumberOfDaysCalled,
        BusinessGetCourseMetadataGeneralCalled,
        BusinessGetCourseSponsorsCalled,
        ServiceGetCourseMetadataGeneralByAcronymCalled,
        ServiceGetCourseSponsorListCalled,
        BusinessGetCourseInteractivityLevelsCalled,
        BusinessGetCourseInteractivityLevelsFailed,
        ServiceGetCourseInteractivityLevelListCalled,
        BusinessGetBrandsBySponsorListCalled,
        BusinessGetBrandsBySponsorListFailed,
        ServiceGetBrandsBySponsorListCalled,
        BusinessGetNasbaDeliveryBySponsorListCalled,
        BusinessGetNasbaDeliveryBySponsorListFailed,
        ServiceGetNasbaDeliveryBySponsorListCalled,
        BusinessGetDeliveryFormatsByNasbaDeliveryIdCalled,
        BusinessGetDeliveryFormatsByNasbaDeliveryIdFailed,
        ServiceGetDeliveryFormatsByNasbaDeliveryIdCalled,
        ServiceGetLearningLevelListCalled,
        BusinessGetLearningLevelsCalled,
        BusinessGetFieldOfStudyListByFoSIDCalled,
        ServiceGetFieldOfStudyListByFoSIDCalled,

        BusinessGetInteractiveLearningCalled,

        BusinessGetCourseMetadataXMLCalled,
        BusinessGetActivityIdCalled,
        BusinessGetSponsorNameCalled,
        BusinessGetCourseAvcCalled,
        BusinessCourseInteractivityLevelCalled,
        BusinessGetNASBAInteractiveCalled,
        BusinessGetBioPtrCalled,
        BusinessGetNasbaCreditsCalled,

        BusinessUpdateCourseMetadataXMLCalled,
        BusinessUpdateCourseMetadataOutlineCalled,

        ServiceGetInteractiveLearningListCalled,
        ServiceDeterminePublishModeCalled,
        ServiceUpdateCourseMetadataXMLCalled,
        ServiceUpdateCourseMetadataOutlineCalled,
        ServiceGetCourseMetadataXMLCalled,
        ServiceGetNasbaCreditsCalled,

        ServiceSaveClickThroughCalled,
        BusinessSaveClickThroughCalled,

        ServiceGetSupplementalMaterialCalled,
        BusinessGetCourseMetadataSupplementsCalled,
        ControllerSupplementalMaterialSaveOutlineCalled,
        ControllerSupplementalMaterialCalled,

        BusinessSaveCourseCreditCalled,
        BusinessSaveCourseEvaluationCalled,
        ServiceSaveCourseEvaluationCalled,
        ServiceSaveCourseCreditCalled,

        ControllerMetadataCourseListCalled,
        ServiceGetCourseMetadataCollectionsCalled,
        BusinessCourseMetadataCollectionsCalled,



        BusinessGetCourseSearchCollectionsCalled,
        BusinessGetCourseMetadtaCountCalled,
        BusinessUpdateActiveVersionInCourseRecordCalled,
        BusinessInsertOrUpdateCourseRecordCalled,
        BusinessGetCourseMetadataIDByAcronymCalled,
        BusinessGetCourseSponsorDetailsCalled,

        BusinessGetChildrenListByCMDIDCalled,
        BusinessSaveGeneralCalled,
        BusinessDeleteParentCalled,
        BusinessAddParentCalled,
        BusinessGetMediaFormatsByCMDIDCalled,
        BusinessGetMediaFormatListCalled,

        BusinessGetParentsListByCMDIDCalled,

        ControllerTableOfContentCalled,
        ControllerStatusCalled,
        ControllerMarketingCalled,
        ControllerMeasurementCalled,
        ControllerCertificationsCreditsCalled,
        ControllerContributorsCalled,

        BusinessGetContributorsAuthorCalled,
        BusinessGetContributorsReviewerCalled,
        BusinessGetContributorsDataCalled,
        ServiceGetContributorsAuthorCalled,
        ServiceGetContributorsReviewerCalled,
        ServiceGetContributorsDataCalled,

        ServiceGetCourseSearchCollectionsCalled,
        BusinessGetAuthorListCalled,
        BusinessGetReviewerListCalled,
        BusinessGetPermissionToRepublishListCalled,
        BusinessGetAuthorResourceListCalled,
        BusinessGetReviewerResourceListCalled,
        ServiceGetResourceListCalled,
        ServiceGetPermissionToRepublishListCalled,
        ServiceGetReviewerResourceListCalled,
        ServiceGetAuthorResourceListCalled,
        ServiceGetAuthorListCalled,
        ControllerSaveContributorsInformationCalled,
        ControllerSaveContributorsAuthorDataCalled,
        ControllerSaveContributorsReviewerDataCalled,
        ControllerGetContributorsCalled,
        ControllerInsertUpdateContributorsAuthorDataCalled,
        ControllerInsertUpdateContributorsReviewerDataCalled,
        ControllerDeleteContributorsAuthorDataCalled,
        ControllerDeleteContributorsReviewerDataCalled,
        ControllerEditContributorsAuthorDataCalled,
        ControllerEditContributorsReviewerDataCalled,
        ControllerSaveContributorsDataCalled,

        //Unison Web Service Methods
        ServiceSetPricesToProductDeliveryFormatsCalled = 700,
        ServiceSetPriceToProductDeliveryFormatCalled = 701,
        ServiceSetPricesToCourseInstancesCalled = 702,
        ServiceGetGradingFeeCalled = 703,

        BusinessCourseSponsorStateBoardCalled,
        BusinessDeleteCourseLevelMembershipCalled,
        BusinessDeleteMediaFormatCalled,
        BusinessDeleteNasbaFoSListCalled,
        BusinessDeleteSponsorLevelMembershipCalled,
        BusinessGetCertificationsAndCreditsDataCalled,
        BusinessGetCourseActivityProfileByIDCalled,
        BusinessGetCourseLevelDataCalled,
        BusinessGetCourseLevelMembershipDropdownCalled,
        BusinessGetCourseLevelMembershipsCalled,
        BusinessGetCourseNasbaCreditsCalled,
        BusinessGetCourseSponsorStateBoardCreditListCalled,
        BusinessGetNasbaFoSDataCalled,
        BusinessGetNasbaFoSDropdownCalled,
        BusinessGetNasbaFoSIDCalled,
        BusinessGetNasbaFoSListCalled,
        BusinessGetNasbaFosStateBoardCategoryCalled,
        BusinessGetPilotTestCPECreditsCalled,
        BusinessGetSponsoreDataCalled,
        BusinessGetSponsorLevelDataCalled,
        BusinessGetSponsorLevelMembershipDropdownCalled,
        BusinessGetSponsorLevelMembershipIDCalled,
        BusinessGetSponsorLevelMembershipsCalled,
        BusinessGetStateBoardsStateCalled,
        BusinessGetStateFoSCatagoryDropdownCalled,
        BusinessGetStateFoSCategoryDropdownAbbreviationCalled,
        BusinessGetUnisonIDByCourseInstanceIDCalled,
        BusinessInsertUpdateCourseLevelMembershipCalled,
        BusinessInsertUpdateNasbaFoSListCalled,
        BusinessInsertUpdateSponsorLevelMembershipCalled,
        BusinessSaveCertificationsAndCreditsDataCalled,
        BusinessUpdateSummaryInCourseInstanceCalled,
        BusinessAddMediaFormatCalled,

        ServiceAddMediaFormatCalled,
        ServiceAddParentCalled,
        ServiceDeleteContributorsDataCalled,
        ServiceDeleteCourseLevelMembershipCalled,
        ServiceDeleteMediaFormatCalled,
        ServiceDeleteNasbaFoSListCalled,
        ServiceDeleteSponsorLevelMembershipCalled,
        ServiceGetCertificationsAndCreditsDataCalled,
        ServiceGetChildrenListByCMDIDCalled,
        ServiceGetContributorsAuthorDataCalled,
        ServiceGetContributorsReviewerDataCalled,
        ServiceGetCourseLevelDataCalled,
        ServiceGetCourseLevelMembershipDropdownCalled,
        ServiceGetCourseLevelMembershipListCalled,
        ServiceGetCourseMetadataIDByAcronymCalled,
        ServiceGetCourseSponsorDetailsCalled,
        ServiceGetCourseSponsorStateBoardCreditListCalled,
        ServiceGetCourseSponsorStateBoardCreditListFailed,
        ServiceGetMediaFormatListCalled,
        ServiceGetMediaFormatsByCMDIDCalled,
        ServiceGetNasbaFoSDataCalled,
        ServiceGetNasbaFoSDropdownCalled,
        ServiceGetNasbaFoSIDCalled,
        ServiceGetNasbaFoSListCalled,
        ServiceGetNasbaFosStateBoardCategoryCalled,
        ServiceGetParentsListByCMDIDCalled,
        ServiceGetPilotTestCPECreditsCalled,
        ServiceGetSponsorCourseSponsorStateBoardMembershipCalled,
        ServiceGetSponsoreDataCalled,
        ServiceGetSponsorLevelDataCalled,
        ServiceGetSponsorLevelMembershipDropdownCalled,
        ServiceGetSponsorLevelMembershipIDCalled,
        ServiceGetSponsorLevelMembershipListCalled,
        ServiceGetStateBoardsStateCalled,
        ServiceGetStateFoSCategoryDropdownAbbreviationCalled,
        ServiceGetStateFoSDropdownCalled,
        ServiceGetUnisonIDByCourseInstanceIDCalled,
        ServiceInsertOrUpdateCourseRecordCalled,
        ServiceInsertUpdateContributorsAuthorDataCalled,
        ServiceInsertUpdateContributorsReviewerDataCalled,
        ServiceInsertUpdateCourseLevelMembershipCalled,
        ServiceInsertUpdateNasbaFoSListCalled,
        ServiceInsertUpdateSponsorLevelMembershipCalled,
        ServiceSaveCertificationsAndCreditsDataCalled,
        ServiceUpdateActiveVersionInCourseRecordCalled,
        ServiceUpdateSummaryInCourseInstanceCalled,

        ControllerGetNasbaFoSListCalled,
        ControllerDeleteNasbaFoSDataCalled,
        ControllerDeleteCourseLevelCalled,
        ControllerGetSponsorLevelCalled,
        ControllerGetCourseLevelCalled,
        ControllerInsertUpdateSponsorLevelMembershipCalled,
        ControllerInsertUpdateCourseLevelMembershipCalled,
        ControllerSaveCertificationsAndCreditsDataCalled,
        ControllerGetCertificationsCreditsInformationCalled,

        ControllerDeleteSponsorLevelCalled,
        ControllerSaveStatusDataCalled,

        BusinessGetProductExclutionListCalled,
        BusinessGetExclutionListCountCalled,
        BusinessExcludeOrIncludeUnisonIDCalled,
        ServiceGetProductListCalled,
        ServiceExcludeOrIncludeUnisonIDCalled,
        ControllerExcludeProductsCalled,
        ControllerExcludeProductsDataCalled,
        ControllerExcludeOrIncludeUnisonIDCalled,

        //CPL Data Migration - Log Messages
        //Enum keys allocated 711 to 725
        MigrationAccountManagmentServiceGetExamMigrationDetailsCalled = 711,
        ValidateUserCredentialsForlegacySystemAccounts = 712,
        CreateMigrationJobAndBeginMigrationAsynchronously = 713,
        StartCreateMigrationJobAndBeginMigrationAsynchronously = 714,
        AbortDataMigrationJob = 715,
        AbortSelectedTaskExecution = 716,
        SearchMigrationProfessionalStatus = 717,
        GetMigrationSearchResultWithPageData = 718,
        GetDataMigrationLogByJobId = 719,
        AsynchronouslyRetryMigrationJob = 720,
        AsynchronouslyRetryATask = 721,
        GetJobDataInUIFriendlyFormat = 722,
        SaveJobProperties = 723,
        GetDataMigrationTaskList = 725,
        GetFirmMigrationSearchResultWithPageData = 726,
        SearchFirmMigrationData = 727,
        StartGettingStatusOfLodedData = 728,
        StartInitiateFirmMigrationDataLoading = 729,
        GetUnisonShipToInformation = 730,
        //Ends CPL Data Migration - Log Messages


        //CPL (Controllers) MigrationControllers - Log Messages of Method initiation
        //Enum keys allocated 750 to 799
        MigrationControllerActionForIndexView = 750,
        CallingIndexViewWithMigrationIndexModelAsParam = 751,
        CallingIndexViewWithMigrationActionForTaskStatus = 752,
        CallingSaveJobProperties = 753,
        CallingActionForLogs = 754,
        CallingPostActionForLogs = 755,
        AbortSelectedDataMigrationJobFromJobDetailsPage = 756,
        AbortSelectedDataMigrationJobFromJobSearchPage = 757,
        RestartSelectedDataMigrationJobFromJobDetailsPage = 758,
        RestartSelectedDataMigrationJobFromJobSearchPage = 759,
        StartSelectedDataMigrationJobDetailsPage = 760,
        StartSelectedDataMigrationJobFromSearchPage = 761,
        RefreshJobDetailsPartialPage = 762,
        CallingRefreshJobSearchPage = 763,
        RetrySelectedDataMigrationTask = 764,
        AbortSelectedDataMigrationTask = 765,
        MigrationControllerActionForFirmsView = 766,
        CallingFirmsViewWithMigrationFirmsModelAsParam = 767,
        MigrationControllerCallingAddFirmView = 768,
        MigrationControllerCallingAddFirmViewWithMigrationJobIdAsParam = 769,
        MigrationControllerCallingFirmMigrationJobStatusView = 770,
        MigrationControllerCallingFirmMigrationLogsView = 771,
        MigrationControllerCallingFirmMigrationProfileSummaryView = 772,
        MigrationControllerCallingNotesForTechnicalHandlingView = 773,
        MigrationControllerSavingTheTechnicalNoteAndRedirectingToFirmsView = 774,
        MigrationControllerCallingSortFirmInfo = 775,
        MigrationControllerCallingSortIpInfo = 776,

        //Ends CPL (Controllers) MigrationControllers - Messages initiation

        //CPL (Business) MigrationComponent - Log Messages of Method initiation
        //Enum keys allocated 800 to 825
        BusinessSearchMigrationProfessionalStatus = 800,
        BusinessGetMigrationProfessionalStatusCount = 801,
        BusinessGetMigrationJobStatusList = 802,
        BusinessGetDataMigrationLogByJobId = 803,
        BusinessGetDataMigrationLogsCount = 804,
        BusinessGetsJobDetailsByAGivenJobId = 805,
        BusinessPersistsAJobWithTheJobToBeSaved = 806,
        BusinessUpdateTaskDetailsWithTheTaskDetailsToBeSaved = 807,
        BusinessRetrivesAllProductsInformation = 808,
        BusinessSaveALogEntryWithTheLogEntryDetails = 809,
        BusinessSaveExtractedDataFromLegeacySystems = 810,
        BusinessGetExtractedXmlData = 811,
        BusinessSaveNewTechnicalHandlingNote = 812,
        BusinessSaveTechnicalHandlingNote = 813,
        BusinessGetMicroMashCompanyType = 814,
        //Ends CPL (Business) MigrationComponent - Messages initiation

        //CPL Migration Tasks Logs - Information Log Messages of Migration tasks execution
        //Enum keys allocated 825 to 849
        IPTasksExecutesTaskLoadHistoryDataStart = 825,
        IPTasksExecutesTaskLoadHistoryDataLoded = 826,
        IPTasksExecutesTaskLockAccountStart = 827,
        IPTasksExecutesTaskLockAccountComplet = 828,
        IPTasksExecutesTaskUnLockAccountStart = 829,
        IPTasksExecutesTaskUnLockAccountComplet = 830,
        IPTasksExecutesTaskValidateAndLockTasksStart = 831,
        IPTasksExecutesTaskValidateAndLockTasksComplet = 832,
        IPTasksExecutesTaskValidateCredentialsStart = 833,
        IPTasksExecutesTaskValidateCredentialsComplet = 834,

        //End of CPL Migration Tasks Logs - Information Log Messages of Migration tasks execution

        //Start-Data Migration: Data import tasks messages. 
        TaskLogIPImportDataExecutesComplete = 840,
        CommonLogIPImportDataTasksExecutesComplete = 841,
        TaskLogIPImportDataExecuteStart = 842,
        CommonLogIPImportDataExecuteStart = 843,
        TaskLogIPImportDataExecutesError = 844,
        //End-Data Migration: Data import tasks messages. 

        ControllerAddMembershipsCalled = 850,
        ControllerDeleteMembershipCalled = 851,
        ServiceGetShippingInformationCalled = 852,
        ServiceGetProfessionalMembershipAssociationByIdCalled = 853,
        ServiceUpdateMembershipAssociationCalled = 854,
        BusinessGetProfessionalMembershipAssociationByIdCalled = 855,
        BusinessUpdateMembershipAssociationCalled = 856,
        BusinessSaveIpDataMigrationJobMethodCalled = 857,
        BusinessSaveDataMigrationJobQueueMethodCalled = 858,
        BusinessGetMigrationCommandsMethodCalled = 859,
        BusinessDeleteMigrationCommandsMethodCalled = 860,
        MigrationSendCompletionEmailCalled = 861,

        ServiceCUASAssignEntitlementCalled = 865,
        ServiceUnisonGetOrderHistoryCalled = 866,
        ServiceUnisonAddOrderToOrderLineCalled = 867,
        ServiceUnisonConfirmOrderCalled = 868,
        ServiceUnisonCompleteOrderCalled = 869,
        ServiceOrderProcessingCreateOrderCalled = 870,
        BusinessGetMigrationCommnadsWithFirmDataTransferCompleteOrFailedTasksMethodCalled = 871,
        BusinessGetInactiveFirmMigrationCommandCountCalled = 872,

        FirmMigrationAsyncronusDataLoadingTaskDataTransferCompleted = 873,
        FirmMigrationAsyncronusDataLoadingTaskDataTransferFailed = 874,
        FirmMigrationAsyncronusDataLoadingTaskDataTransferAlreadyStarted = 875,
        FirmMigrationAsyncronusDataLoadingTaskDataTransferInitiated = 876,
        FirmMigrationAsyncronusDataLoadingTaskTaskSuspended = 877,
        FirmMigrationAsyncronusDataLoadingTaskStarted = 878,
        FirmMigrationExecuteStoredProcedureTaskStarted = 879,

        //Start-Firm data migration web log messages. Dedicated keys 1050 to 1075  
        WebGetReqwiredInformationCalled = 1050,
        WebGetMicroMashInformationCalled = 1051,
        WebGetShipToInformationCalled = 1052,
        //End-Firm Data Migration.

        //Start-Firm data migration common messages. Dedicated keys 1076 to 1100  
        SaveFirmMigrationCertificateStart = 1076,
        SaveFirmMigrationCEProfileStart = 1077,
        SaveFirmMigrationFirmStart = 1078,
        SaveFirmMigrationProfessionalStart = 1079,
        SaveFirmMigrationProfessionalAddressStart = 1080,
        SaveFirmMigrationProfessionalFKConstrainsCheckStart = 1081,
        //WebGetMicroMashInformationCalled = 1051
        //End-Common Firm Data Migration.


        //Create Entitlements Log messages for IP
        TaskLogIPExpirationDateInvalid = 1201,
        TaskLogIPExpirationDatesInvalid = 1202,
        TaskLogVerticalsInvalid = 1203,
        TaskLogIndustryIdInvalid = 1204,
        TaskLogIPLatestExpirationDateInvalid = 1205,

        TaskLogIPCreateEntitlementForCETrackingComplete = 1206,
        TaskLogIPNoImportedXMLDataForCETracking = 1207,
        TaskLogIPNoNeedToEntitleForCETracking = 1208,
        TaskLogIPOrderCreationStartedForCETracking = 1209,
        TaskLogIPOrderCreationFinishedForCETracking = 1210,
        TaskLogIPOrderCreationSuccessForMicroMashPlus = 1211,
        TaskLogIPOrderCreationSuccessForCheckPoint = 1212,
        TaskLogIPOrderCreationSuccessForMicroMashUnlimited = 1213,
        TaskLogIPOrderCreationSuccessForPassOnline = 1214,

        //Product List Log Messages
        //Enum keys allocated 1220 to 1250
        ControllerCallingSearchProducts = 1220,
        ServiceSearchProductsStarted = 1221,
        BusinessSearchProductsStarted = 1222,
        BusinessSaveOrderInformationForReportStarted = 1223,
        BusinessAddProductsStarted = 1224,
        ServiceDeleteProductsStarted = 1225,

        //Global enums 1260~1300/1351~1375 allocated to auto notify courses log messages
        BusinessDeleteEmailDistributionListCalled = 1260,
        BusinessSaveEmailDistributionListCalled = 1261,
        BusinessGetAutoNotifyEmailLogCalled = 1262,
        BusinessSearchEmailDistributionListsCalled = 1263,

        ServiceSearchEmailDistributionListsCalled = 1264,
        BusinessGetAutoNotifyEmailLogRecordCountCalled = 1265,
        BusinessGetTemplateEmailDistributionListCountCalled = 1266,
        ServiceDeleteEmailDistributionListCalled = 1267,


        ServiceGetAutoNotifyEmailCalled = 1268,
        ServiceGetEmailDistributionListCalled = 1269,
        ServiceSaveEmailDistributionListCalled = 1270,
        BusinessGetEmailDistributionListCalled = 1271,

        ControllerManageEmailDistributionListCalled = 1272,
        ControllerGetEmailDistributionListCalled = 1273,
        ControllerDeleteEmailDistributionListCalled = 1274,
        ControllerSaveEmailDistributionListCalled = 1275,

        ControllerAutoNotifyEmailTemplatesCalled = 1276,
        ControllerDeleteAutoNotifyEmailTemplateCalled = 1277,
        ControllerModifyAutoNotifyEmailTemplateCalled = 1278,
        ControllerAutoNotifyEmailTemplatesAsParamCalled = 1279,
        ControllerAddNewEmailTemplateCalled = 1280,
        ControllerClearEmailTemplateCalled = 1281,

        ControllerManageTemplateLogCalled = 1282,

        ServiceSearchTemplatesCalled = 1283,
        ServiceDeleteTemplateCalled = 1284,
        ServiceGetTemplateCalled = 1285,
        ServiceSaveTemplateCalled = 1286,
        ServiceSendAutoNotifyEmailCalled = 1287,

        BusinessSearchTemplatesCalled = 1288,
        BusinessDeleteTemplateCalled = 1289,
        BusinessGetTemplateCalled = 1290,
        BusinessGetAutoNotifyFrequenciesCalled = 1291,
        BusinessGetAutoNotifyVersionsCalled = 1292,
        BusinessSaveTemplateCalled = 1293,
        BusinessGetSelectedEmailDistributionGroupsByTemplateIdCalled = 1294,
        BusinessGetSelectedFieldOfStudiesByTemplateIdCalled = 1295,
        BusinessGetSelectedBrandsByTemplateIdCalled = 1296,

        BusinessGetRecipientEmailsByTemplateIdCalled = 1297,
        BusinessAddAutoNotifyEmailNotifyLogCalled = 1298,
        BusinessUpdateTemplateLastNotifiedDateCalled = 1299,
        BusinessGetEmailTemplatesCalled = 1300,
        BusinessFetchNotificationEmailDetailsCalled = 1351,

        //Global enums 1301~1350 allocated to SSM enhancements
        BussinessSSMGetOrganizationIdByFirmUserNameCalled = 1301,
        BussinessGetProfessionalRefIdCalled = 1302,
        BussinessGetCplOrganizationInformationCalled = 1303,

        BusinessGetOrganizationAdminPreferenceByIdCalled = 1310,

        ServiceScheduleServiceStartCalled = 1352,
        ServiceScheduleServiceExecuteActivityCalled = 1353,

        //Diagnostic Log Messages
        //Enum keys allocated 1355 to 1360
        DiagnosticControllerActionForIndexView = 1355,

        //Global enums 1360~1420 allocated to live event schedule management
        BusinessDeleteScheduleCalled = 1360,
        ServiceDeleteScheduleCalled = 1361,
        BusinessGetSchedulesCalled = 1362,
        ServiceGetSchedulesCalled = 1363,
        BusinessSaveScheduleCalled = 1364,
        BusinessGetScheduleCalled = 1365,
        BusinessGetScheduleListCountCalled = 1366,
        ServiceSaveScheduleCalled = 1367,
        ControllerLiveEventScheduleGridDataCalled = 1368,
        ServiceGetScheduleCalled = 1369,

        //End global enums 1360~1420 allocated to live event schedule management

        //Global enums 1500~1550 allocated to Application Integration
        ControllerActionManageExternalApplicationCalled = 1500,
        ControllerGetProfessionalApplicationsCalled = 1501,
        ControllerActionApplicationUnlinkCalled = 1502,
        ControllerActionRedirectToApplicationCalled = 1503,
        ControllerIsUserLinkedToApplicationCalled = 1504,
        BusinessGetApplicationsCall = 1505,
        BusinessGetApplicationByIdCall = 1506,
        ServiceGetApplicationByIdCalled = 1507,
        ServiceGetApplicationsCalled = 1508,
        ControllerNoAccessCalled = 1509,
        //End global enums 1500~1550  allocated to Application Integration
        ControllerPingErrorCalled = 1510,
        ControllerActionRedirectToProfileOnlineCalled = 1511,
        ControllerActionManageCompetenciesCalled = 1512,
        ControllerOspLaunchCalled = 1513,

        //Start of ProductMetadata messages 1800 to 1820
        GetGeneralProductInformationServiceCall = 1800,
        GetProductDetailsServiceCall = 1801,
        GetBundlePackagesControllerCall = 1802,
        ServiceGetBundlePackagesCalled = 1803,
        BusinessGetBundlePackagesCalled = 1804,
        BusinessGetBundlePackagesMethodeCalled = 1805,
        BusinessGetProductDetailsForLiveEventCalled = 1806,
        PorductMetadataServiceCancelLiveEventOrderCalled = 1807,
        RTRPPackagesCourseControllerCall = 1808,
        //Start of ProductMetadata messages1800 to 1820

        //Start - Product Reconciliation Report 1821 to 1840
        ControllerReportsProductReconciliationReportCalled = 1821,
        ControllerReportsSearchProductReconciliationCalled = 1822,
        ControllerReportsProductReconciliationExcelReportCalled = 1823,
        //End - Product Reconciliation Report 1821 to 1840

        //Defect fix for #83375 :Pilot Testing: Add Autorespone Message when user registers to be a Pilot Tester
        //Start User Registration log message for   send email attachment for pilot tester 1851~
        ServiceAttachedFileDataCalled = 1851,
        // End of User Registration log message for send email attachment for pilot tester 1851~

        //Live Event Order Entry 2000 to 2099 and 3100 to 3400
        ServiceSaveProfessionalDetailsCalled = 2000,
        ServiceUpdateProfessionalDetailsCalled = 2001,
        BusinessSaveProfessionalDetailsCalled = 2002,
        BusinessUpdateProfessionalDetailsCalled = 2003,
        ControllerSaveProfessionalDetailsCalled = 2004,
        BusinessGetOrderByIdCalled = 2008,
        BusinessGetOrderResultCountCalled = 2009,
        BusinessGetOrderLevelDetailCalled = 2013,
        BusinessGetOrderProductDetailbyIdCalled = 2014,
        BusinessGetOrderProductDetailCountCalled = 2048,
        BusinessDeleteOrderProductCalled = 2049,
        ServiceGetOrderByIdCalled = 2050,
        ServiceGetOrderResultCountCalled = 2051,
        ServiceGetOrderLevelDetailCalled = 2052,
        ServiceGetOrderProductDetailbyIdCalled = 2053,
        ServiceGetOrderProductDetailCountCalled = 2054,
        ServiceDeleteOrderProductCalled = 2055,
        ServiceGetProfessionalSearchResultCalled = 2056,
        ServiceGetProfessionalResultCountCalled = 2057,
        BusinessGetProfessionalSearchResultCalled = 2058,
        BusinessGetProfessionalResultCountCalled = 2059,
        BusinessSearchAttendeeTicketDetailsCalled = 2060,
        BusinessSearchAttendeeForTicketCalled = 2061,
        BusinessSearchAttendeeForTicketCountCalled = 2062,
        BusinessGetGlobalAttendeesCalled = 2063,
        BusinessGetGlobalAttendeesCountCalled = 2064,
        BusinessCanceleProfessionalOrderCalled = 2065,
        BusinessSearchProfessionalOrderHistoryCountCalled = 2066,
        BusinessSearchProfessionalOrderHistoryCalled = 2067,
        BusinessSaveGlobalAttendeesCalled = 2068,
        BusinessGetSelectedGlobalAttendeesCalled = 2069,
        BusinessCheckTheAttendeeExistsCalled = 2070,
        ServiceSearchAttendeeTicketDetailsCalled = 2071,
        ServiceSearchAttendeeForTicketCalled = 2072,
        ServiceSearchAttendeeForTicketCountCalled = 2073,
        ServiceGetGlobalAttendeesCalled = 2074,
        ServiceGetGlobalAttendeesCountCalled = 2075,
        ServiceCanceleProfessionalOrderCalled = 2076,
        ServiceSearchProfessionalOrderHistoryCountCalled = 2077,
        ServiceSearchProfessionalOrderHistoryCalled = 2078,
        ServiceSaveGlobalAttendeesCalled = 2079,
        ServiceGetSelectedGlobalAttendeesCalled = 2080,
        ServiceCheckTheAttendeeExistsCalled = 2081,
        BusinessUpdateOrderStatusCalled = 2082,
        BusinessCancelOrderCalled = 2083,
        BusinessGetOrderHeadingCalled = 2084,
        BusinessGetOriginalOrderDetailCountCalled = 2085,
        BusinessGetProductTypeListMethodCalled = 2086,
        BusinessGetProductTypeListCountCalled = 2087,
        BusinessGetProductTypesCalled = 2088,
        ServiceCancelOrderCalled = 2089,
        ServiceGetOrderHeadingCalled = 2090,
        ServiceGetOriginalOrderDetailCountCalled = 2091,
        ServiceGetOrderDetailsCalled = 2092,
        ServiceGetProductTypeListCalled = 2093,
        ServiceGetProductTypesCalled = 2094,
        ServiceGetProductTypeListCountCalled = 2095,
        ServiceUpdateOrderStatusCalled = 2096,
        ControllerProfessionalCalled = 2097,
        ControllerSearchProfessionalCalled = 2098,
        ControllerGetProductListCalled = 2099,
        ControllerOrderLevelDetailsSummaryCalled = 3100,
        ControllerChangeOrderStatusCalled = 3101,
        ControllerEmptyOrderCalled = 3102,
        ControllerSearchOrderLevelDetailsCalled = 3103,
        ControllerSearchOrderCalled = 3104,
        ControllerOriginalOrderCalled = 3105,
        ControllerOriginalOrderDetailsCalled = 3106,
        ControllerOrderProductDetailCalled = 3107,
        BusinessGetOrderProductDetailsCalled = 3108,
        BusinessAddOrderProductCalled = 3109,
        BusinessSaveOrderProductDetailsCalled = 3110,
        ServiceGetOrderProductDetailsCalled = 3111,
        ServiceAddOrderProductCalled = 3112,
        ServiceSaveOrderProductDetailsCalled = 3113,
        ServiceProfessionalDetailsCalled = 3114,
        ComponentGetOrderByCartSessionIdCalled = 3115,
        ComponentUpdateOrderTypeCalled = 3800,

        ServiceGetAttendeeForLineItemCalled = 3801,
        ServiceRemoveAttendeeFromAttendeeListCalled = 3802,
        ServiceGetOrderProductCalled = 3803,
        ServiceDeleteGlobalAttendeeListCalled = 3804,
        ServiceInsertToLiventEventOrderAtendeeCalled = 3805,
        ServiceIsProductExistsForOrderCalled = 3806,
        ServiceGetConferenceScheduleDetailsCalled = 3807,
        ServiceGetCombinationDescriptionCalled = 3808,
        ServiceNotifyOrderPurchaseCalled = 3809,
        ServiceGetLiveEventOrderLineItemIdForCartCalled = 3810,
        ServiceGetOriginalOrderHeadingCalled = 3811,
        ServiceApplyPromoCodeForOrderCalled = 3812,
        ServiceUpdateLiveEventOrderForCartCalled = 3813,
        ServiceGetOriginalOrderDetailsCalled = 3814,
        ServiceCancelProductCalled = 3815,
        ServiceValidateAttendeesCalled = 3816,
        ComponentGetAttendeeForLineItemCalled = 3817,
        ComponentGetOrderProductCalled = 3818,
        ComponentRemoveAttendeeFromAttendeeListCalled = 3819,
        ComponentDeleteGlobalAttendeeListCalled = 3820,
        ComponentInsertToLiventEventOrderAtendeeCalled = 3821,
        ComponentIsProductExistsForOrderCalled = 3822,
        ComponentGetConferenceScheduleDetailsCalled = 3823,
        ComponentGetCombinationDescriptionCalled = 3824,
        ComponentGetLiveEventOrderLineItemIdForCartCalled = 3825,
        ComponentGetOriginalOrderHeadingCalled = 3826,
        ComponentApplyPromoCodeForOrderCalled = 3827,
        ComponentGetOriginalOrderDetailsCalled = 3828,
        ComponentValidateAttendeesCalled = 3829,
        ServiceGetOriginalOrderProductDetailsCalled = 3830,
        ServiceGetLiveEventOrderStatusCalled = 3831,
        BusinessGetBrandsCalled = 3832,
        BusinessGetStatesCalled = 3833,
        BusinessGetLocationsCalled = 3834,


        //End - Live Event Order Entry


        // Live Event Product Setup 2100 - 2150
        LiveEventControllerProductSetupCalled = 2100,
        LiveEventControllerProductSetupEditCalled = 2101,
        LiveEventControllerSearchProductsCalled = 2102,
        LiveEventControllerUpdateProductDetailsCalled = 2103,

        LiveEventServiceGetProductSetupPageDetailsCalled = 2104,
        LiveEventServiceSearchProductsCalled = 2105,
        LiveEventServiceGetProductDetailsCalled = 2106,
        LiveEventServiceUpdateProductDetailsCalled = 2107,

        LiveEventComponentGetProductSetupPageDetailsCalled = 2108,
        LiveEventComponentSearchProductsCalled = 2109,
        LiveEventComponentSearchProductsCountCalled = 2110,
        LiveEventComponentGetProductDetailsCalled = 2111,
        LiveEventComponentUpdateProductDetailsCalled = 2112,



        //Live Event Location Setup 2151-2250
        LiveEventComponentSearchLocationsCalled = 2151,
        LiveEventComponentGetLocationPageDetailsCalled = 2152,
        LiveEventComponentSearchLocationCountCalled = 2153,
        LiveEventComponentGetLocationSetupHotelsCalled = 2154,
        LiveEventComponentSearchHotelCountCalled = 2155,
        LiveEventComponentGetHotelDetailsCalled = 2156,
        LiveEventComponentUpdateLocationDetailsCalled = 2157,
        LiveEventComponentUpdateHotelDetailsCalled = 2158,
        LiveEventComponentInsertLocationDetailsCalled = 2159,
        LiveEventComponentInsertHotelDetailsCalled = 2160,
        LiveEventComponentDeleteHotelDetailsCalled = 2161,
        LiveEventComponentDeleteLocationDetailsCalled = 2162,
        LiveEventComponentGenerateCousreInstanceAddressCalled = 2163,
        // SynchronizeTimeZoneInCourseInstance

        LiveEventServiceSearchLocationsCalled = 2164,
        LiveEventServiceGetLocationPageDetailsCalled = 2165,
        LiveEventServiceGetLocationSetupHotelsCalled = 2166,
        LiveEventServiceGetHotelDetailsCalled = 2167,
        LiveEventServiceUpdateLocationDetailsCalled = 2168,
        LiveEventServiceUpdateHotelDetailsCalled = 2169,
        LiveEventServiceSearchLocationCountCalled = 2170,
        LiveEventServiceSearchHotelCountCalled = 2171,
        LiveEventServiceSaveLocationDetailsCalled = 2172,
        LiveEventServiceSaveHotelDetailsCalled = 2173,
        LiveEventServiceDeleteLocationDetailsCalled = 2174,
        LiveEventServiceDeleteHotelDetailsCalled = 2175,

        RequiredComponentSynchronizeCourseInstanceAddressCalled = 2176,
        RequiredServiceSynchronizeCourseInstanceAddressCalled = 2177,
        RequiredServiceGetCourseInstanceForAddressSynchronizationCalled = 2178,

        RequiredComponentDeleteCourseInstanceAddressCalled = 2179,
        RequiredComponentInsertCourseInstanceAddressCalled = 2180,
        RequiredComponentSelectCourseInstanceAddressCalled = 2181,
        RequiredComponentSynchronizeTimeZoneInCourseInstanceCalled = 2182,
        RequiredComponentGetCourseInstanceCalled = 2183,
        RequiredComponentIsDirectDepositCalled = 2185,

        // LiveEvent Society Setup 2300 - 2450
        LiveEventControllerSearchSocietiesCalled = 2300,
        LiveEventControllerSocietySetupEditCalled = 2301,
        LiveEventControllerSocietyUpdateCalled = 2302,
        LiveEventControllerDeleteSocietiesCalled = 2303,

        LiveEventServiceGetSocietyPageDetailsCalled = 2310,
        LiveEventServiceSocietyDetailsCalled = 2311,
        LiveEventServiceGetSocietyCalled = 2312,
        LiveEventServiceUpdateSocietyCalled = 2313,
        LiveEventServiceDeleteSocieties = 2314,

        LiveEventComponentSocietySetupEditCalled = 2320,
        LiveEventComponentUpdateSocietyCalled = 2321,
        LiveEventComponentDeleteSocietiesCalled = 2322,
        LiveEventComponentSearchSocietiesCountCalled = 2323,
        LiveEventComponentSocietyDetailsCountCalled = 2324,


        //End - Live Event Society Setup 

        //Conference setup 2451-2600
        LiveEventComponentDeleteConferenceCalled = 2451,
        LiveEventServiceDeleteConferenceCalled = 2452,
        //end Conference setup

        //Course Metadata- Schedule 2251-2263/2267-2270
        CourseMetadataControllerScheduleCalled = 2251,
        CourseMetadataControllerSearchSchedulesCalled = 2252,
        CourseMetadataControllerScheduleDetailsCalled = 2253,
        CourseMetadataControllerSearchScheduleDaysCalled = 2254,
        CourseMetadataControllerUpdateScheduleDayCalled = 2255,
        CourseMetadataControllerDeleteScheduleDayCalled = 2256,
        CourseMetadataControllerUpdateScheduleCalled = 2257,

        CourseMetadataServiceGetSchedulePageDetailsCalled = 2258,
        CourseMetadataServiceSearchSchedulesCalled = 2259,
        CourseMetadataServiceGetScheduleDetailsPageDetailsCalled = 2260,
        CourseMetadataServiceUpdateScheduleCalled = 2261,
        CourseMetadataServiceSynchronizeCourseInstanceAddressCalled = 2262,

        CourseMetadataComponentCopyAccreditationGloballySuccess = 2267,
        CourseMetadataComponentCopyAccreditationGloballyDisabled = 2268,
        CourseMetadataComponentCopyAccreditationGloballyNoSourceFound = 2269,
        CourseMetadataComponentCopyAccreditationGloballyFailed = 2270,
        CourseMetadataComponentCopyAccreditationFirstSchedule = 2500,
        //Course Metadata- Schedule 2251-2263/2267-2270 END

        #region LiveEvent Attendance Managment
        CourseMetadataComponentGetLiveEventBrandsCalled = 2263,
        LiveEventServiceSearchAttandanceManagementLiveEventsCalled = 2264,
        ComponentSearchAttendanceManagementLiveEventsCountCalled = 2265,
        LiveEventControllerSearchAttendanceManagementLiveEventsCalled = 2266,
        ComponentSearchAttendanceManagementLiveEventsCalled = 2271,
        LiveEventControllerLiveTimeEntryDetailsCalled = 2272,
        LiveEventComponentSearchRegistrantsTimeEntryCalled = 2274,
        LiveEventComponentSearchRegistrantsTimeEntryCountCalled = 2275,
        LiveEventServiceSearchRegistrantTimeEntryCalled = 2276,
        LiveEventControllerLiveEventRegistrantSearchCalled = 2277,
        LiveEventControllerAttendanceManagementCalled = 2278,
        LiveEventControllerSaveTimeEntryDetailsCalled = 2279,
        LiveEventComponentSaveTimeEntryDetailsCalled = 2280,
        LiveEventServiceSaveTimeEntryDetailsCalled = 2281,
        LiveEventComponentDeleteScheduleTimeEntryCalled = 2282,
        LiveEventControllerRegistrantsCalled = 2283,
        LiveEventServiceGetRegistrantsProductDeatilsCalled = 2284,
        LiveEventComponentSearchRegistrantCalled = 2285,
        LiveEventComponentSearchRegistrantCountCalled = 2286,
        LiveEventServiceSearchRegistrantCalled = 2287,
        LiveEventControllerSearchRegistrantsCalled = 2288,
        LiveEventComponentGetProfessionalByIdCalled = 2289,
        LiveEventServiceGetTimeEntryDetailsCalled = 2290,
        LiveEventServiceGetTimeEntryDetailsForProfissionalCalled = 2291,
        LiveEventControllerProfessionalTimeEntryDetailsCalled = 2292,
        LiveEventControllerSaveProfessionalTimeEntryDetailsCalled = 2293,
        LiveEventControllerToggleStatusCalled = 2294,
        LiveEventServiceChangeAttendanceStatusCalled = 2295,
        LiveEventComponentToggleStatusByProfessionalCalled = 2296,
        LiveEventComponentDeleteAttendeeTimeEntryCalled = 2297,
        LiveEventComponentGetConcurrentSchedulesCalled = 2298,
        LiveEventServiceGetConcurrentScheduleCalled = 2299,
        LiveEventControllerSwapProfessionalsCalled = 2501,
        LiveEventComponentSwapProfissionalScheduleCalled = 2502,
        LiveEventControllerSaveProfessionalScheduleCalled = 2503,
        LiveEventServiceSaveProfessionalScheduleCalled = 2504,
        LiveEventComponentGetConferenceIdByScheduleIdCalled = 2505,
        LiveEventServiceGetAttendanceManagementPageDataCalled = 2506,
        LiveEventControllerLiveEventSendCertificateEmailCalled = 2507,
        LiveEventServiceSendCertificateEmailCalled = 2508,
        ServiceAgentSendCertificateEmailCalled = 2509,
        LiveEventComponentUpdateIsFullAttendanceCalled = 2510,
        LiveEventComponentGetCitiesForLiveEventCalled = 2511,
        LiveEventComponentSearchScheduleTopicsCalled = 2512,
        LiveEventServiceGetProfessionalTopicAttendanceCalled = 2513,
        LiveEventComponentGetProfessionalsAttendanceCalled = 2514,
        LiveEventControllerDirectDepositCalled = 2515,
        LiveEventControllerViewCertificateCalled = 2516,
        LiveEventControllerSendAggregateEmailsCalled = 2517,
        LiveEventControllerGetAgendaDetailsCalled = 2518,
        LiveEventServiceGetAllSwappingProfessionalsCalled = 2519,
        LiveEventComponentGetAllSwappingProfessionalCalled = 2520,
        LiveEventServiceGetRegisteredLiveEventSearchResultCalled = 2521,
        LiveEventServiceGetRosterCalled = 2522,



        #endregion


        CourseCatalogServiceCourseSearchCalled = 2273,

        #region Conference Setup 3114 - 3142
        LiveEventControllerConferenceSetupCalled = 3114,
        LiveEventControllerSearchConferencesCalled = 3115,
        LiveEventControllerConferenceSetupAddCalled = 3116,
        LiveEventControllerConferenceSetupEditCalled = 3117,
        LiveEventControllerDeleteConferenceCalled = 3118,
        LiveEventControllerConferenceSetupUpdateCalled = 3119,
        LiveEventServiceGetConferenceSetupPageDetailsCalled = 3120,
        LiveEventServiceSearchConferencesCalled = 3121,
        LiveEventServiceSearchConferencesRecordCountCalled = 3122,
        LiveEventServiceGetConferenceDetailsCalled = 3123,
        LiveEventServiceUpdateConferenceDetailsCalled = 3124,
        LiveEventComponentSearchConferencesCalled = 3125,
        LiveEventComponentSearchConferencesRecordCountCalled = 3126,
        LiveEventComponentGetBrandListForConferenceCalled = 3127,
        LiveEventComponentGetLocationListForConferenceCalled = 3128,
        LiveEventComponentGetHotelListForConferenceCalled = 3129,
        LiveEventComponentInsertConferenceCalled = 3130,
        LiveEventComponentEditConferenceCalled = 3131,
        LiveEventComponentInsertLiveEventMetaDataCalled = 3132,
        LiveEventComponentEditLiveEventMetaDataCalled = 3133,
        LiveEventComponentInsertLiveEventInstantDataCalled = 3134,
        LiveEventComponentEditLiveEventInstantDataCalled = 3135,
        LiveEventComponentGetNasbaLearningLevelListCalled = 3136,
        LiveEventComponentGetConferenceDetailsCalled = 3137,
        LiveEventComponentIsAssocitedProductIdExistCalled = 3138,
        LiveEventComponentIsLiveEventOrderLineItemExistCalled = 3139,
        LiveEventControllerSearchCategoriesCalled = 3140,
        LiveEventControllerSaveConferenceCategoryCalled = 3141,
        LiveEventControllerDeleteConferenceCategoryCalled = 3142,

        #endregion

        #region Seminar and Optional Seminars 3143 - 3173 / 3241 - 3250
        LiveEventControllerSeminarsCalled = 3143,
        LiveEventControllerSearchAssociatedSeminarsCalled = 3144,
        LiveEventControllerGetSeminarPageDetailsCalled = 3145,
        LiveEventControllerSearchSeminarsCalled = 3146,
        LiveEventControllerAddSeminarsToConferenceCalled = 3147,
        LiveEventControllerOptionalSeminarsCalled = 3148,
        LiveEventControllerSearchAssociatedOptionalSeminarsCalled = 3149,
        LiveEventControllerGetOptionalSeminarPageDetailsCalled = 3150,
        LiveEventControllerSearchOptionalSeminarsCalled = 3151,
        LiveEventControllerExcludeSeminarCalled = 3152,
        LiveEventServiceSearchAssociatedSeminarsCalled = 3153,
        LiveEventServiceGetAddSeminarsPageDataCalled = 3154,
        LiveEventServiceSearchSeminarsCalled = 3155,
        LiveEventServiceAddSeminarsToConferenceCalled = 3156,
        LiveEventServiceSearchAssociatedOptionalSeminarsCalled = 3157,
        LiveEventServiceSearchOptionalSeminarsCalled = 3158,
        LiveEventServiceExcludeSeminarCalled = 3159,
        LiveEventComponentSearchAssociateSeminarsCalled = 3160,
        LiveEventComponentSearchAssociateSeminarsRecordCountCalled = 3161,
        LiveEventComponentSearchSeminarsCalled = 3162,
        LiveEventComponentSearchSeminarsRecordCountCalled = 3163,
        LiveEventComponentGetStateListForSeminarCalled = 3164,
        LiveEventComponentAddSeminarsToConferenceCalled = 3165,
        LiveEventComponentSearchAssociatedOptionalSeminarsCalled = 3166,
        LiveEventComponentSearchAssociatedOptionalSeminarsRecordCountCalled = 3167,
        LiveEventComponentSearchOptionalSeminarsCalled = 3168,
        LiveEventComponentSearchOptionalSeminarsRecordCountCalled = 3169,
        LiveEventComponentUpdateCourseInstanceConferenceInstanceIdCalled = 3170,
        LiveEventComponentIsAssociateProductIdExistCalled = 3172,
        LiveEventComponentDeleteAssociateProductCalled = 3173,
        LiveEventControllerGetOptionalSeminarsForConferenceCalled = 3241,
        LiveEventServiceSearchCategoriesCalled = 3242,
        LiveEventServiceDeleteCourseNasbaCreditsCalled = 3243,
        LiveEventComponentGetConferenceCategoriesCalled = 3244,
        LiveEventComponentInsertUpdateCourseNasbaCreditsCalled = 3245,
        LiveEventComponentDeleteCourseNasbaCreditsCalled = 3246,

        #endregion

        #region Combinations 3174 - 3195
        LiveEventControllerGetCombinationDetailsCalled = 3174,
        LiveEventControllerSearchScheduleCombinationsCalled = 3175,
        LiveEventControllerGetScheduleCombinationsCalled = 3176,
        LiveEventControllerSaveScheduleCombinationsCalled = 3177,
        LiveEventControllerDeleteCombinationCalled = 3178,
        LiveEventServiceSearchCombinationsCalled = 3179,
        LiveEventServiceGetScheduleTimeSlotsCalled = 3180,
        LiveEventServiceSaveScheduleCombinationsCalled = 3181,
        LiveEventServiceGetCombinationDataCalled = 3182,
        LiveEventServiceDeleteScheduleCombinationCalled = 3183,
        LiveEventComponentSearchCombinationsCalled = 3184,
        LiveEventComponentSearchCombinationsRecordCountCalled = 3185,
        LiveEventComponentSearchSchedulesForConferenceCalled = 3186,
        LiveEventComponentGetProductIdsForCombinationCalled = 3187,
        LiveEventComponentSaveLiveEventSeminarCombinationCalled = 3188,
        LiveEventComponentSaveLiveEventSeminarCombinationDetailCalled = 3189,
        LiveEventComponentDeleteLiveEventSeminarCombinationDetailCalled = 3190,
        LiveEventComponentSearchScheduleCombinationCalled = 3191,
        LiveEventComponentDeleteLiveEventSeminarCombinationCalled = 3192,
        LiveEventComponentIsLiveEventProductCodeExistCalled = 3193,

        #endregion

        #region Schedule (3196 - 3240 and 3401- 3450)
        ScheduleControllerHelpersUpdateAccreditationCalled = 3196,
        ScheduleControllerHelpersSearchScheduleTopicsCalled = 3197,
        ScheduleControllerHelpersUpdateScheduleTopicCalled = 3198,
        ScheduleControllerHelpersDeleteScheduleTopicCalled = 3199,
        ScheduleControllerHelpersSelectFacilitiesCalled = 3200,
        ScheduleControllerHelpersDeleteScheduleCalled = 3201,
        CourseMetadataServiceSearchScheduleDaysCalled = 3202,
        CourseMetadataServiceUpdateLiveEventScheduleDayCalled = 3203,
        CourseMetadataServiceSearchScheduleTopicsCalled = 3204,
        CourseMetadataServiceUpdateScheduleTopicCalled = 3205,
        CourseMetadataServiceDeleteScheduleTopicCalled = 3206,
        CourseMetadataServiceToggleAccreditationCalled = 3207,
        CourseMetadataServiceGetFacilityListByLocationCalled = 3208,
        CourseMetadataServiceDeleteScheduleCalled = 3209,
        CourseMetadataComponentGetSchedulePageDetailsCalled = 3210,
        CourseMetadataComponentSearchSchedulesCalled = 3211,
        CourseMetadataComponentSearchSchedulesRecordCountCalled = 3212,
        CourseMetadataComponentGetScheduleDetailsPageDetailsCalled = 3213,
        CourseMetadataComponentInsertUpdateLiveEventProductCalled = 3214,
        CourseMetadataComponentInsertUpdateCourseInstanceCalled = 3215,
        CourseMetadataComponentGetFacilityLocationDataCalled = 3216,
        CourseMetadataComponentGetCourseInstanceAddressByIdRecordCountCalled = 3217,
        CourseMetadataComponentInsertCourseInstanceAddressCalled = 3218,
        CourseMetadataComponentUpdateCourseInstanceAddressCalled = 3219,
        CourseMetadataComponentInsertUpdateLiveEventScheduleDayCalled = 3220,
        CourseMetadataComponentUpdateLiveEventScheduleDayCalled = 3221,
        CourseMetadataComponentSearchScheduleDaysCalled = 3222,
        CourseMetadataComponentSearchScheduleDaysRecordCountCalled = 3223,
        CourseMetadataComponentSynchronizeCourseInstanceDaysCalled = 3224,
        CourseMetadataComponentSearchScheduleTopicsCalled = 3225,
        CourseMetadataComponentSearchScheduleTopicsRecordCountCalled = 3226,
        CourseMetadataComponentInsertUpdateCourseInstanceScheduleCalled = 3227,
        CourseMetadataComponentSetCourseInstanceScheduleTimelineCalled = 3228,
        CourseMetadataComponentDeleteScheduleTopicCalled = 3229,
        CourseMetadataComponentSetAgendaSynchronizeValueCalled = 3230,
        CourseMetadataComponentSetAgendaSynchronizeValueToFalseCalled = 3231,
        CourseMetadataComponentToggleAccreditationCalled = 3232,
        CourseMetadataComponentCopyAccreditationGloballyCalled = 3233,
        CourseMetadataComponentGetFacilityListByLocationCalled = 3234,
        CourseMetadataComponentDeleteCourseInstanceCalled = 3235,
        CourseMetadataComponentDeleteLiveEventScheduleResourceCalled = 3236,
        CourseMetadataComponentGetAttendeeCountForCourseInstaceIdCalled = 3237,
        CourseMetadataComponentGetConferenceIdForScheduleCalled = 3238,

        CourseMetadataComponentGetTimeZoneByLocationIdCalled = 3239,
        CourseMetadataComponentGetCourseIdByMetadadataIdCalled = 3240,
        CourseMetadataComponentGetCodeByMetadadataIdCalled = 3401,
        CourseMetadataComponentCourseGroupSearchCalled = 3402,
        CourseMetadataComponentGetLiveEventMediaFormatsCalled = 3403,

        CourseMetadataServiceCourseGroupSearchCalled = 3404,
        CourseMetadataServiceGetLiveEventMediaFormatsCalled = 3405,
        CourseMetadataServiceIsSchedulesExistCalled = 3406,

        //For Webinar 
        CourseMetadataComponentGetPollingQuestionsAndResponsesRequiredCalled = 3407,
        CourseMetadataComponentIsInstanceEvaluatedCalled = 3408,

        CourseMetadataServiceIsInstanceEvaluatedCalled = 3409,

        #endregion

        #region LiveEvent Barcode 3251 - 3300

        LiveEventControllerGetBarcodeImageCalled = 3251,
        LiveEventServiceGetBarcodeForAttendeeCalled = 3252,
        LiveEventComponentGetBarcodeForAttendeeCalled = 3253,
        LiveEventComponentSaveBarcodeTimeEntryCalled = 3254,
        LiveEventControllerBarcodeAttendanceCaptureCalled = 3255,
        LiveEventComponentSearchAttendeeTimeEntryDetailsCalled = 3256,
        LiveEventControllerBarcodeLiveEventLocationCalled = 3257,
        LiveEventControllerGetFacilitiesCalled = 3258,
        LiveEventServiceGetBarcodeLiveEventLocationPageDataCalled = 3259,
        LiveEventServiceGetFacilitiesCalled = 3260,
        LiveEventComponentGetLiveEventCitiesCalled = 3261,
        LiveEventComponentGetLiveEventFacilitiesCalled = 3262,
        LiveEventServiceGetBarcodeLiveEventSeminarsCalled = 3263,
        LiveEventComponentGetTimeZoneCalled = 3264,
        LiveEventComponentGetBarCodeLiveEventSeminarsCalled = 3265,
        LiveEventComponentGetScannedAttendeeDetailsCalled = 3266,
        LiveEventComponentSearchAttendeeTimeEntryDetailsCountCalled = 3267,
        LiveEventServiceSaveAndRetrieveScannedAttendeeInformationCalled = 3268,
        LiveEventServiceSearchBarcodeAttendeeInformationCalled = 3269,
        LiveEventServiceSwapAndSaveBarcodeProfessionalCalled = 3270,
        LiveEventServiceSaveBulkOperationCalled = 3271,
        LiveEventComponentGetBarcodeTimeEntryProfessionalBySchedulesCalled = 3272,
        LiveEventServiceBarcodeSaveCheckInAllCalled = 3273,
        LiveEventComponentGetBarcodeTimeEnteredScheduleCalled = 3274,
        LiveEventComponentGetBarcodeOrderCompletedProfessionalBySchedulesCalled = 3275,
        LiveEventControllerSearchAttendeeTimeEntryCalled = 3276,
        LiveEventControllerSaveAttendeeTimeEntryCalled = 3277,
        LiveEventControllerScanBarcodeCalled = 3278,
        LiveEventControllerSearchBarcodeAttendeeDetailsCalled = 3279,
        LiveEventControllerProcessBulkOperationCalled = 3280,
        LiveEventControllerSaveBulkOperationCalled = 3281,
        LiveEventControllerSaveSeminarInformationCalled = 3282,
        LiveEventControllerSaveCheckInAllBulkOperationCalled = 3283,
        LiveEventComponentGetMaximumNumberOfAttendeeByScheduleCalled = 3284,
        LiveEventComponentGetProfessionalConferenceSchedulesCalled = 3285,
        LiveEventServiceSearchBarcodeAttendeeDetailsCalled = 3286,
        LiveEventComponentSearchBarcodeAttendeeTimeEntryDetailsCalled = 3287,
        LiveEventComponentSearchBarcodeAttendeeTimeEntryDetailsCountCalled = 3288,
        LiveEventComponentGetBarcodeRecordsCountByCourseInstanceIdCalled = 3289,
        LiveEventControllerSearchBarcodeAttendeeDetailsAttendanceManagmentCalled = 3290,
        LiveEventComponentGetFacilityByIdCalled = 3291,
        LiveEventComponentGetScannedAttendeeScheduleDetailsCalled = 3292,
        LiveEventComponentGetBarcodeProfessionalTimeEntryDetailsCalled = 3293,
        LiveEventComponentGetBarcodeProfessionalTimeEntryDetailsCountCalled = 3294,
        LiveEventComponentDeleteBarcodeProfessionalTimeEntryDetailCalled = 3295,
        LiveEventComponentSaveBarcodeProfessionalTimeEntryDetailCalled = 3296,
        LiveEventComponentGetSchedulesTopicsCalled = 3297,
        LiveEventComponentGetBulkOperationDataCalled = 3298,
        LiveEventComponentGetBarcodeProfessionalTimeEntryDetailsBySchedulesCalled = 3299,
        LiveEventComponentGetLiveEventScheduleDayCalled = 3300,
        LiveEventComponentGetAttendanceLocationInfoByCourseInstanceIdCalled = 3301,
        LiveEventComponentGetAttendeeTopicDetailsCalled = 3302,
        LiveEventComponentGetSchedulesTitleCalled = 3303,
        LiveEventServiceGetBarcodeProfessionalTimeEntryDetailsCalled = 3304,
        LiveEventServiceDeleteBarcodeProfessionalTimeEntryDetailsCalled = 3305,
        LiveEventServiceSaveBarcodeProfessionalTimeEntryDetailsCalled = 3306,
        LiveEventServiceGetBulkOperationSchedulesCalled = 3307,
        LiveEventServiceGetCheckInAllSchedulesCalled = 3308,
        LiveEventServiceSyncBarcodeRecordsCalled = 3309,
        LiveEventServiceGetScheduleLocationInfoCalled = 3310,
        LiveEventControllerBarcodeAttendanceManagementCaptureCalled = 3311,

        #endregion

        #region PilotTestTimingReport 3350 - 3400

        ControllerGetPdfTimingReportCalled = 3351,
        ControllerTimingReportInformationCalled = 3352,
        ServiceGetTimingReportCalled = 3353,
        BussinessGetPilotTestTimingReportDataCalled = 3354,
        BussinessGetTimingReportPilotTestCalled = 3355,

        #endregion

        #region Deloitee Integration 3451 - 3500

        ServiceUpdateEmployeeDetailsForDeloitteProfessionalsCalled = 3451,
        ServiceEmployeeDetailCalled = 3452,
        BusinessUpdateEmployeeDetailsForDeloitteProfessionalsCalled = 3453,

        #endregion

        #region Associate Documents 3832-3840
        ProfessionalServiceGetAttachmentInfoCalled = 3832,
        ProfessionalServiceGetAttachmentAssociationInfoCalled = 3833,
        ProfessionalComponentGetAttachmentInfoCalled = 3834,
        ProfessionalComponentGetAttachmentAssociationInfoCalled = 3835,
        #endregion

        #region Cloud Storage 3841-3850
        CloudStorageServiceListBlobsCalled = 3841,
        CloudStorageServiceUploadBlobsCalled = 3842,
        CloudStorageServiceDownloadBlobCalled = 3843,
        CloudStorageServiceDeleteBlobCalled = 3844,
        CloudStorageServiceRenameBlobCalled = 3845,
        CloudStorageServiceAssociateDocumentsCalled = 3846,
        #endregion

        #region Bulk Upload 3851-3865
        LiveEventControllerLiveSeminarImportCalled = 3851,
        LiveEventControllerImportLiveSeminarDataCalled = 3852,
        LiveEventControllerLiveEventsLogViewCalled = 3853,
        LiveEventServiceRetrieveLiveSeminarLogsCalled = 3854,
        LiveEventServiceRetrieveLiveEventLogCountCalled = 3855,
        LiveEventServiceLiveEventLogFilterValuesCalled = 3856,
        LiveEventServiceImportLiveSeminarDataCalled = 3857,
        LiveEventComponentRetrieveLiveSeminarLogsCalled = 3858,
        WebinarComponentGetBulkImportReferenceDataCalled = 3859,
        LiveEventComponentGetAdvertisedCityAndFacilityCalled = 3860,
        #endregion

        #region 1.04 - webinar setup 3601-3800
        LiveEventServiceSendWebinarDetailsMailCalled = 3601,
        LiveEventComponentGetWebinarAnswersCalled = 3602,
        LiveEventServiceGetWebinarAnswersCalled = 3603,
        LiveEventServiceSaveWebinarTimeEntryDetailsCalled = 3604,
        LiveEventComponentSaveWebinarTimeEntryDetailsCalled = 3605,
        LiveEventComponentDeleteWebinarTimeEntryDetailsCalled = 3606,
        LiveEventComponentGetCourseDocumentFileNameCalled = 2523,


        #endregion

        #region Shared 3866 - 3900
        SharedControllerNoteDetailsCalled = 3866,
        SharedControllerAddNoteCalled = 3867,
        SharedServiceGetNoteDetailsCalled = 3868,
        SharedServiceAddNoteCalled = 3869,
        SharedServiceAddProfessionalNotesCalled = 3870,
        SharedComponentGetNoteDetailsCalled = 3871,
        SharedComponentGetNoteDetailsRecordCountCalled = 3872,
        SharedComponentAddNoteCalled = 3873,
        SharedComponentGetNoteIdCalled = 3874,
        SharedComponentAddProfessionalNotesCalled = 3875,

        #endregion


        #region Comprehensive Bundles 3900 - 4100
        ComprehensiveBundleComponentGetBundleDefinitionsCalled = 3901,
        ComprehensiveBundleComponentGetCoursesCalled = 3902,
        ComprehensiveBundleComponentCourseSearchResultCountCalled = 3903,
        ComprehensiveBundleComponentGetCourseFlagTypeCalled = 3904,
        ComprehensiveBundleComponentGetBundleUnisonIdCalled = 3905,
        ComprehensiveBundleComponentGetProfessionalComprehensiveBundleOrderCalled = 3906,
        ComprehensiveBundleComponentSaveProfessionalBundleCalled = 3907,
        ComprehensiveBundleComponentGetBundleDefinitionByProfessionalCalled = 3908,
        ComprehensiveBundleComponentGetCourseInBundleCalled = 3909,
        ComprehensiveBundleComponentGetPromoCodesForDiscountProductCalled = 3910,
        ComprehensiveBundleComponentGetCpeHoursByProductCalled = 3911,
        ComprehensiveBundleComponentIsProductInBundleCalled = 3912,
        ComprehensiveBundleComponentGetProductTypeIdCalled = 3913,
        ComprehensiveBundleServiceGetBundleDefinitionsCalled = 3914,
        ComprehensiveBundleServiceGetBundleCoursesCalled = 3915,
        ComprehensiveBundleServiceGetEntitledCoursesCalled = 3916,
        ComprehensiveBundleServiceGetBundleUnisonIdCalled = 3917,
        ComprehensiveBundleServiceGetProfessionalBundleSubscriptionCalled = 3918,
        ComprehensiveBundleServiceRegisterBundleLiveEventCalled = 3919,
        ComprehensiveBundleServiceUnregisterBundleLiveEventCalled = 3920,
        ComprehensiveBundleServiceSaveProfessionalBundleCalled = 3921,
        ComprehensiveBundleServiceIsCourseInBundleByProfessionalCalled = 3922,
        ComprehensiveBundleServiceGetCpeHoursByProductCalled = 3923,
        ComprehensiveBundleServiceGetComprehensiveBundleProductCodesForProductCalled = 3924,
        ComprehensiveBundleServiceGetPromoCodesForDiscountProductCalled = 3925,

        #endregion

        #region Sales Report Process 4101 - 4105
        SalesReportProcessValidateReportRulesCalled = 4101,
        SalesReportProcessPreProcessCalled = 4102,
        #endregion

        #region IRS Bulk Upload 4120-4150
        IrsControllerImportIrsBulkRegisterDataCalled = 4121,
        IrsServiceImportIrsBulkRegisterDataCalled = 4122,
        #endregion

        #region EarlyBird Price calculation process 4151 - 4170
        ProductPricingServiceStartCalled = 4151,
        ProductPricingServiceSetProductPriceCalled = 4152,
        ProductPricingServiceGetLogsFromDBCalled = 4153,
        ProductPricingServiceClearCacheCalled = 4154,
        #endregion








        # region  Package Management 4213 - 4300

        ControllerPackagesMetadataListCalled = 4213,
        ControllersaveAsPackageCalled = 4214,
        ControllerCreateNewPackageCalled = 4215,
        ControllerSavePackagePriorityListCalled = 4216,
        ControllerDeletePackageCalled = 4217,
        ControllerSaveGeneralDatalCalled = 4218,
        ControllerGeneralDataCalled = 4219,
        ControllerEditPackageDataCalled = 4220,
        ControllerPreviewPackageDataCalled = 4221,
        ControllerGeneralCalled = 4222,
        ControllerGetGeneralDataCalled = 4223,
        ControllerProductsCalled = 4224,
        ControllerSaveProductsCalled = 4225,
        ControllerPromotionManagementCalled = 4226,
        ControllerSavePromoCalled = 4227,
        ControllerCourseListCalled = 4228,
        ControllerSaveCourseListQueryCalled = 4229,
        ControllerSearchQueryCalled = 4230,
        ControllerCourseListNewCalled = 4231,
        ControllerAddNewRuleCalled = 4232,
        ControllerChangeFieldCalled = 4233,
        ControllerDeleteRuleCalled = 4234,
        ControllerSaveRulesCalled = 4235,

        PackageComponentGetAllPackagesCalled = 4236,
        PackageComponentGetPackageDetailsByPackageCodeCalled = 4237,
        PackageComponentGetAllPackageDetailsCalled = 4238,
        PackageComponentGetDeltaCourseListCalled = 4239,
        PackageComponentGetNotesHistoryCalled = 4240,
        PackageComponentGetPackageDetailsByPackageCodesCalled = 4241,
        PackageComponentGetPackagesCountCalled = 4242,
        PackageComponentSearchCuasProductsByCplCodeCalled = 4243,
        PackageComponentSaveGeneralDataCalled = 4244,
        PackageComponentCreateNewPackageCalled = 4245,
        PackageComponentSavePromoRulesCalled = 4246,
        PackageComponentSaveSelectedProductsCalled = 4247,
        PackageComponentGetNonCPEProdctsListCalled = 4248,
        PackageComponentSearchQueryCalled = 4249,
        PackageComponentsaveAsPackageCalled = 4250,
        PackageComponentGetFieldFilterValuesCalled = 4251,
        PackageComponentGetOperatorFilterValuesCalled = 4252,
        PackageComponentGetPackageRulesByPackageCodeCalled = 4253,
        PackageComponentGetValueFilterValuesCalled = 4254,
        PackageComponentSaveRulesCalled = 4255,
        PackageComponentGetRuleByFieldIdCalled = 4256,
        PackageComponentAddNewRuleCalled = 4257,

        PackageServiceGetAllPackagesCalled = 4258,
        PackageServiceGetPackageDetailsByPackageCodeCalled = 4259,
        PackageServiceGetNonCPEProdctsListCalled = 4260,
        PackageServiceGetNonCPESelectedProductsListCalled = 4261,
        PackageServiceSaveSelectedProductsCalled = 4262,
        PackageServiceGetCAUSProductsListCalled = 4263,
        PackageServiceGetPromoCodeDetailsByPackageCodeCalled = 4264,
        PackageServiceValidatePromoCalled = 4265,
        PackageServiceSavePromoCalled = 4266,
        PackageServiceGetCourseListQueryCalled = 4267,
        PackageServiceSearchQueryCalled = 4268,
        PackageServiceGetbundlePriorityListCalled = 4269,
        PackageServiceCreateNewPackageCalled = 4270,
        PackageServiceSaveGeneralCalled = 4271,
        PackageServiceSavePackagePriorityListDetailsCalled = 4272,
        PackageServiceGetAllPackageCalled = 4273,
        PackageServiceGetDeltaCourseListCalled = 4274,
        PackageServiceGetCourseLsitCalled = 4275,
        PackageServiceGetNotesHistoryCalled = 4276,
        PackageServiceGetFieldFilterValuesCalled = 4277,
        PackageServiceGetOperatorFilterValuesCalled = 4278,
        PackageServiceGetValueFilterValuesCalled = 4279,
        PackageServiceGetPackageRulesByPackageCodeCalled = 4280,
        PackageServiceGetRuleByFieldIdCalled = 4281,
        PackageServicesaveAsPackageCalled = 4282,
        PackageServiceGetPackagesDataBySortQueryCalled = 4283
        
        
        #endregion
        //ServiceGetAllCustomersCalled = 1
        #endregion
    }



    public enum CourseStatusID : int
    {
        None = 0,
        Active = 1,
        Inactive = 2,
        Inwork = 3
    }

    public enum ErrorMessageResID : int
    {
        None = 0,
        BasicSerach = 1,
        CourseService = 2,
        DatabaseAccess = 3,
        UnableToResolveService = 4,
        UnableToBusinessComponent = 5,
        UnableToDBService = 6,
        GetNotedExpertFromDbFailed = 7,
        GetNotedAuthorFromDbFailed = 8,
        GetAuthorDetailsFromDbFailed = 9,
        SaveInhouseRequestFaild = 10,
        GetInhouseCourseDetailsFaild = 11,
        GetInhouseCourseDeliveryFormatDetailsFaild = 12,
        GetStatesDetailsFaild = 13,
        GetUpComingWebinarsFaild = 14,
        GetWebinarDeliveryFormatListFaild = 15,
        GetUpComingWebinarsRecordCountFaild = 16,
        GetSchedulesByCourseIDFaild = 17,
        GetCourseDetailsFaild = 18,
        GetCourseDeliveryFormatDetailsFaild = 19,
        GetStateDetailsFaild = 20,
        BusinessGetRecordCountFaild = 26,
        ServiceSaveRequestInformationFaild = 30,
        ServiceGetInhouseCourseDetailsFaild = 31,
        ServiceGetUpcomingWebinarsCalled = 32,
        ServiceGetSchedulesByProductMetaDataFaild = 33,
        GetGMapLoationIdFailed = 35,
        ControllerRequestForInformationFaild = 40,
        ControllerPostRequestForInformationFaild = 41,
        ControllerCourseScheduleFaild = 42,
        ControllerPostCourseScheduleFaild = 43,
        ControllerUpComingWebinarsFaild = 44,
        ControllerPostUpComingWebinarsFaild = 45,
        GetCoursesByLibraryFaild = 46,
        GetSelfStudyDeliveryFormatListFaild = 47,
        ControllerSendEmailFailed = 50,
        ControllerSendEmailFailedFor = 51,
        ServiceSendEmailFailed = 52,
        ControllerGAOYellowBookFailed = 53,
        ServiceGetInteractiveGAOYellowBookCourseListFailed = 54,
        GetCourseListByFieldOfStudyIdFailedFor = 55,
        GetDeliveryFormatOfGAOYellowBookFailed = 56,
        ServiceGetGMapLoationIdFailed = 57,
        ServiceGetCoursesByLibraryFailed = 58,
        GetInteractiveEthicCourseListFailed = 59,
        GetLibraryListFailed = 60,
        ServiceGetLibraryListFailed = 61,

        ControllerNewCourseListFailed = 62,
        ControllerEthicCoursesFailed = 63,
        ServiceGetCourseListFaild = 64,
        ServiceGetBasicSearchResultsFailed = 65,

        ControllerSalesReportFailed = 66,
        ServiceGetSearchMarketingSalesSummaryFailed = 67,
        BusinessGetSearchMarketingSalesSummaryFailed = 68,
        BusinessSaveVisitInformationFailed = 69,
        ServiceSaveVisitInformationFailed = 70,
        DBServiceExecuteDataSetFailed = 71,
        DBServiceExecuteNonQueryFailed = 72,
        DBServiceCreatePerformanceCountersFailed = 73,
        DBServiceUpdatePerformanceCounterFailed = 74,
        //Resource Repository
        GetAddressTypeListFailed = 75,
        GetResourceStatusListFailed = 76,
        GetRecordStatusListFailed = 77,
        GetPhoneTypeListFailed = 78,
        GetEmailTypeListFailed = 79,
        BusinessGetPrimaryGroupListFailed = 80,
        BusinessGetUserListFailed = 81,
        GetCredentialStatusListFailed = 82,
        GetCertificateTypeFailed = 83,
        GetRolesListFailed = 84,
        ControllerInternetSalesReportFailed = 85,
        BusinessGetInternetSalesSummeryFaild = 86,
        ServiceGetInternetSalesSummeryFaild = 87,
        GetFormListFailed = 88,
        GetExternalAffiliatesListFailed = 89,
        ServiceDeleteUserAuthorizationFailed = 90,
        GetDeliveryFormatListByCourseIdFailed = 91,
        ServiceGetManageUserProfileFailed = 92,
        ServiceGetManageUserProfileWithIdFailed = 93,
        ServiceGetGALUserListFailed = 94,
        BusinessGetPersonalInformationFaild = 95,
        BusinessSaveUserAuthorizationFailed = 96,
        BusinessDeleteUserAuthorizationFailed = 97,
        BusinessGetResourceListFailed = 98,
        ServiceGetUserDetailsByUserNameFailed = 99,
        ServiceSaveUserAuthorizationFailed = 100,
        BusinessGetCommunicationRecordListFailed = 101,
        BusinessGetResourceAssociatedCourseListFailed = 102,
        BusinessSaveResourceFailed = 103,
        BusinessGetResourceInformationFailed = 104,
        BusinessGetManageUserProfileFailed = 105,
        BusinessGetManageUserProfileWithUserIdFailed = 106,
        BusinessGetContactInformationFailed = 107,
        BusinessGetProfessionalInformationFailed = 108,
        ServiceGetContactInformationFailed = 109,
        ServiceGetResourceInformationFailed = 111,
        BusinessGetResourcePaymentDetailsFailed = 112,
        BusinessGetAssociatedCourseInformationFailed = 113,
        ServiceGetPersonalInformationFailed = 114,
        ControllerContactInformationFailed = 150,
        ControllerSaveAddressFailed = 151,
        ControllerSaveEmailFailed = 152,
        ControllerSavePhoneFailed = 153,
        ControllerDeleteAddressFailed = 154,
        ControllerDeleteEmailFailed = 155,
        ControllerDeletePhoneFailed = 156,

        //Sponsor Landing Pages
        SponsorLandingPageFail = 110,
        SponsorManagementPageFail = 157,
        SponsorGlobalTextManagementPageFail = 158,

        BusinessGetSponsorPageFailed = 115,
        BusinessSponsorSearchFailed = 116,
        BusinessGetSponsorByCodeFailed = 117,
        BusinessGetGlobalTextSectionFailed = 118,
        BusinessGetRecordCountFailed = 119,
        BusinessSaveSponsorFailed = 120,
        BusinessSaveSponsorPageFailed = 121,
        BusinessSaveGlobalTextsFailed = 122,
        BusinessDeleteSponsorFailed = 123,
        BusinessDeleteSponsorPageFailed = 124,

        ServiceGetSponsorPageFailed = 125,
        ServiceGetGlobalTextsFailed = 126,
        ServiceGetSponsorByCodeFailed = 127,
        ServiceSaveSponsorFailed = 128,
        ServiceSaveSponsorPageFailed = 129,
        ServiceSponsorSearchFailed = 130,
        ServiceDeleteSponsorFailed = 131,
        ServiceDeleteSponsorPageFailed = 132,
        ServiceSaveGlobalTextsFailed = 133,
        ServiceSearchProductsFailed = 134,

        ControllerPersonalInformationFailed = 135,
        ControllerSaveCommunicationRecordFailed = 136,
        ServiceGetAssociatedCourseInformationFailed = 137,
        ControllerProfessionalInformationFailed = 138,
        ControllerSponsorProductSearchFailed = 139,
        BusinessGetResourceRolesForCourseFailed = 142,
        ControllerSponsorPageSearchFailed = 143,
        ControllerSponsorPageRemoveFailed = 144,
        ServiceSavePersonalInformationFaild = 145,
        BusinessSavePersonalInformationFaild = 146,
        ServiceSaveResourceCommunicationRecordFaild = 147,
        BusinessSaveResourceCommunicationRecordFaild = 148,
        BusinessGetSponsorStatusListFaild = 149,
        BusinessGetCourseListFailed = 150,
        BusinessSaveSponsorVisitFaild = 160,
        ServiceSaveSponsorVisitFaild = 161,
        BusinessSaveResourceAddressFailed = 162,
        BusinessSaveResourcePhoneFailed = 163,
        BusinessSaveResourceEmailFailed = 164,
        BusinessDeleteResourceAddressFailed = 165,
        BusinessDeleteResourcePhoneFailed = 166,
        BusinessDeleteResourceEmailFailed = 167,
        ServiceSaveResourceAddressFailed = 168,
        ServiceSaveResourcePhoneFailed = 169,
        ServiceSaveResourceEmailFailed = 170,
        ServiceDeleteResourceAddressFailed = 171,
        ServiceDeleteResourcePhoneFailed = 172,
        ServiceDeleteResourceEmailFailed = 173,
        ServiceGetProfessionalInformationFailed = 174,
        BusinessSaveProfessionalInformationFaild = 175,
        ControllerSaveProfessionalInformationFailed = 176,
        ControllerSaveResourceCertificateFailed = 177,
        ControllerDeleteResourceCertificateFailed = 178,
        BusinessSaveManageUserProfileFailed = 179,
        BusinessTableOfContextFailed = 180,
        ServiceTableOfContextFailed = 181,
        ControllerEditAddressFailed = 182,
        ControllerEditPhoneFailed = 183,
        ControllerEditEmailFailed = 184,
        BusinessSaveAssociatedCourseInformationFailed = 185,
        ControllerEditResourceCertificateFailed = 186,
        ServiceSaveManageUserProfileFailed = 187,
        ControllerSearchActiveDirectoryUserFailed = 188,
        ControllerManageUserProfileFailed = 189,
        ControllerUserDetailsFailed = 190,
        ControllerAddPrimaryGroupFailed = 191,
        ControllerDeletePrimaryGroupFailed = 192,
        ControllerSelectActiveDirectoryUserFailed = 193,
        ControllerSaveUserDetailsFailed = 194,

        BusinessDeleteResourcePaymentInfoFailed = 195,
        BusinessGetResourceInformationRecordCountFailed = 196,
        BusinessSaveResourceGroupFailed = 197,
        BusinessGetResourceGroupDetailsFailed = 198,
        BusinessDeleteResourceGroupFailed = 199,
        BusinessSaveResourceInformationFailed = 200,
        BusinessSaveResourcePaymentInfoFailed = 201,

        ServiceGetResourceInformationSearchFailed = 202,
        ServiceSaveResourceInformationFaild = 203,
        ServiceSaveResourcePaymentInfoFaild = 204,
        ServiceSaveResourceGroupFaild = 205,
        ServiceDeleteResourcePaymentInfoFaild = 206,
        ServiceDeleteResourceGroupFaild = 207,
        ServiceGetGetResourceInformationRecordCountFaild = 208,
        ServiceGetGetContactListByGroupIdFaild = 209,

        ControllerGroupDetailsFailed = 210,
        ControllerSaveResourceFailed = 211,
        ControllerDeleteGroupFailed = 212,
        ControllerDeletePaymentInfoFailed = 213,
        ControllerSaveGroupFailed = 214,
        ControllerSavePaymentInfoFailed = 215,
        ControllerResourceInformationFailed = 216,

        BusinessGetTimeZoneListFailed = 217,
        BusinessGetCourseDetailsFailed = 218,
        BusinessGetResourceProductDetailsForCourseFailed = 219,
        ServiceGetCourseDetailsFailed = 220,
        ServiceSaveAssociatedCourseInformationFailed = 221,
        ServiceDeleteCourseFailed = 222,
        ControllerAssociatedCourseInfoFailed = 223,
        ControllerAssociatedCoursesFailed = 224,
        ControllerAddCourseFailed = 225,
        ControllerDeleteCourseFailed = 226,
        ControllerEditCourseFailed = 227,
        BusinessValidateResourceAddressFailed = 228,
        BusinessValidateResourcePhoneFailed = 229,
        BusinessValidateResourceEmailFailed = 230,

        ControllerClearGroupFailed = 231,
        ControllerClearPaymentInfoFailed = 232,
        BusinessValidatedAssociatedCoursesFaild = 233,

        BusinessKeyWordSearchFailed = 234,
        ServiceKeyWordSearchFailed = 235,

        ControllerResetGroupAndPaymentInfoFailed = 236,
        BusinessValidateResourceCertificateFailed = 237,
        ServiceDeleteResourceFaild = 238,
        BusinessDeleteResourceFaild = 239,

        ControllerSortPrimaryGroupFailed = 240,
        SponsorPageImageSaveFail = 241,
        SponsorPageImageDeleteFail = 242,
        // Notification Service
        SendNotificationFailed = 243,
        TransformMessageFailed = 244,

        SponsorPageImageFail = 245,

        GlobalTextImageFail = 246,
        GlobalTextImageSaveFail = 247,
        GlobalTextImageDeleteFail = 248,

        ImagePreviewFail = 249,

        BusinessGetNotificationInitializeDataFailed = 250,

        BusinessSaveReportInstanceFailed = 251,
        BusinessEditReportInstanceFailed = 252,
        BusinessDeleteReportInstanceFailed = 253,
        BusinessRetrieveLastModifiedInstancesFailed = 254,
        BusinessRetrieveReportInstanceFailed = 255,
        BusinessgetReportListFailed = 256,
        BusinessGetFilterItemListByReportColumnIdFailed = 707,
        BusinessClearReportLifeCycleTableDataFailed = 709,

        /// <summary>
        /// Report services section
        /// </summary>
        ServiceReportGetLastModifiedInstancesFailed = 257,

        BusinessGetPilotTestTestersOfPilotTestFailed = 258,
        BusinessGetPilotTestTesterFailed = 259,

        //ServiceReportGetInstancesFailed = 260,
        ServiceGetReportDefintionFailed = 260,
        ServiceGetReportInstanceDefinitionFailed = 261,
        ServiceSaveReportInstanceFailed = 262,
        ServiceGetLastModifiedInstancesFailed = 263,
        ServiceGeInstancesByReportIdFailed = 264,
        ServiceGetReportOperatorsFailed = 265,
        ServiceDeletedReportInstanceFailed = 266,
        ServiceGetGeneratedReportFailed = 267,
        ServiceGetFilterItemListByReportColumnIdFailed = 708,

        BusinessSavePilotTestTesterFailed = 268,
        BusinessAddPilotTestersToPilotTestFailed = 269,

        ControllerPilotTestFailed = 270,
        ControllerPilotTestsFailed = 271,
        ControllerSearchPilotTestsFailed = 272,
        ControllerManagePilotTestsFailed = 273,
        ControllerPilotTestsExcelExportFailed = 274,
        ControllerStatusReportFailed = 275,

        ServiceGetPilotTestFailed = 276,
        ServiceGetPilotTestsAsExcelDocumentFailed = 277,
        ServiceGetStatusReportFailed = 278,
        ServiceSaveStatusReportFailed = 279,
        ServiceGetStatusReportAsExcelDocumentFailed = 280,
        ServiceSavePilotTestFailed = 281,
        ServiceSearchPilotTestFailed = 282,

        BussinessSearchPilotTestFailed = 283,
        BussinessGetPilotTestFailed = 284,
        BussinessGetPilotTestCourseInformationFailed = 285,
        BussinessGetPilotTestStatusesListFailed = 286,
        BussinessSavePilotTestFailed = 287,
        BussinessGetPilotTestStatusReportDataFailed = 288,
        BussinessGetPilotTestDurationDataFailed = 289,
        BussinessSaveStatusReportFailed = 290,
        BusinessSearchPilotTestersFailed = 291,
        ServiceAddTestersToPilotTestFailed = 292,
        ServiceSearchPilotTestersFailed = 293,
        ServiceGetAddPilotTestInitializingDataFailed = 294,
        ServiceSavePilotTestTesterFailed = 295,
        ServiceGetPilotTestTesterFailed = 296,
        ServiceGetPilotTestTestersFaild = 297,
        ControllerPilotTestersFailed = 298,
        ControllerUpdatePilotTesterFailed = 299,
        ControllerAddPilotTestersFailed = 300,
        ControllerSearchTestersFailed = 301,

        ControllerEmailTemplatesFailed = 302,
        ControllerUpdateEmailTemplateFailed = 303,
        ControllerSaveEmailTemplateFailed = 304,
        ControllerDeleteEmailTemplateFailed = 305,
        ControllerEmailTemplateSearchResultFailed = 306,

        ServiceSaveEmailTemplateFailed = 307,
        ServiceGetEmailTemplateFailed = 308,
        ServiceDeleteEmailTemplateFailed = 309,
        ServiceSearchEmailTemplateFailed = 310,

        ServiceGetNasbaReportFailed = 311,

        BussinessDeleteEmailTemplateFailed = 312,
        BusinessGetEmailTemplateFailed = 313,
        BusinessSaveEmailTemplateFailed = 314,
        BusinessSearchEmailTemplateFailed = 315,

        ControllerNasbaReportsFailed = 316,
        ControllerNasbaReportsPostFailed = 317,
        ControllerNasbaReportsSearchResultFailed = 318,

        ServiceGetBrandsFailed = 319,

        BusinessValidateUserSessionInformationFailed = 322,
        BusinessValidateUserFailed = 323,

        BusinessGetPilotTesterFailed = 324,
        BusinessSaveProfessionalFailed = 325,

        BusinessValidateAdminUserFailed = 326,
        BusinessCreateUserSessionFailed = 327,
        BusinessUpdateUserSessionFailed = 328,
        BusinessRemoveUserSessionFailed = 329,
        BusinessExpireUserSessionFailed = 330,
        BusinessWriteSharedSessionValueFailed = 331,
        BusinessReadSharedSessionValueFailed = 332,
        BusinessUpdatePilotTesterFailed = 333,
        BusinessGetProfessionalByIdFailed = 334,
        BusinessLockUserFailed = 638,
        BusinessLockAdminUserFailed = 639,
        BusinessUpdateCheckpointLinkFlagFailed = 640,

        ServiceGetPilotTesterFailed = 335,
        ServiceUpdatePilotTesterFailed = 336,

        ServiceLoginFailed = 337,
        ServiceLogoutFailed = 338,
        ServiceExpireUserSessionFailed = 339,

        BussinessOGSSearchPurchaseExamsFailed = 340,

        ControllerLoginFailed = 341,
        ControllerLogoutFailed = 342,
        ControllerRedirectFailed = 343,

        BusinessValidateEMailListFailed = 344,
        BusinessValidateSecurityAnswerListFailed = 345,
        ServiceUpdateUserSessionFailed = 346,
        ServiceSetSharedSessionFailed = 347,

        ControllerUserProductAssociationFailed = 349,
        ControllerUserProductAssociationNextFailed = 350,
        ControllerUserProductAssociationPreviousFailed = 351,
        ControllerAddTRProductsFailed = 352,
        ControllerDeleteTRProductFailed = 353,
        ControllerEditProductFailed = 354,

        BussinessOGSGetExamQuestionDetailsFailed = 355,

        /* Table Of Content */
        BusinessGetTOCCoursesFailed = 356,
        BusinessGetTOCRecordsFailed = 357,
        ServiceGetTOCCoursesFailed = 358,
        ServiceGetTOCRecordsFailed = 359,
        ControllerGetTOCCoursesFailed = 360,
        ControllerGetTOCRecordsFailed = 361,
        BusinessSortTOCCoursesFailed = 362,
        Other_B_Failed = 363,

        BusinessGetSecurityQuestionAnswerListByEmailFailed = 364,

        ServiceValidateEmailListFailed = 365,
        ServiceGetSecurityQuestionAnswerListByEmailFailed = 366,
        ServiceGetPasswordFailed = 367,
        ServiceGetUserNameFailed = 368,

        ControllerForgotLoginFailed = 369,
        ControllerForgotUserNameFailed = 370,
        ControllerForgotPasswordFailed = 371,
        ControllerSecurityQuestionGetFailed = 372,
        ControllerSubmitSecurityQuestionFailed = 373,

        BusinessOGSGetExamQuestionsCountFailed = 374,
        ServiceGetSharedSessionValuesFalied = 375,

        BussinessOGSAddExamAttemptFailed = 376,
        BussinessOGSSaveSaveAttemptAnswersFailed = 377,
        BussinessOGSCompleteExamAttemptFailed = 378,

        ServiceSaveProfessionalFailed = 379,
        BusinessValidateUserNameFailed = 380,
        ServiceValidateUserNameFailed = 381,
        ServiceValidateUserSessionFailed = 382,

        ControllerOGSIndexFailed = 383,
        ControllerOGSWelcomeFailed = 384,
        ControllerOGSPurchaseExamsFailed = 385,
        ControllerOGSPurchaseExamsSearchFailed = 386,
        ControllerOGSPostLoginHomeFailed = 387,
        ControllerOGSPostLoginExamPurchasedFailed = 388,
        ControllerOGSPostLoginExamsInProgressFailed = 389,
        ControllerOGSExamsInProgressFailed = 390,
        ControllerOGSExamsPurchasedFailed = 391,
        ControllerOGSExamPassFailed = 392,
        ControllerOGSExamFailedFailed = 393,
        ControllerOGSOnlineExamsFailed = 394,
        ControllerOGSOnlineExamQuestionsFailed = 395,
        ControllerOGSExamResultFailed = 396,

        BusinessGetSalutationListFailed = 397,
        BusinessGetAddressTypeListFailed = 398,
        BusinessGetPhoneTypeListFailed = 399,
        BusinessGetEmailTypeListFailed = 400,
        BusinessGetProductTypeListFailed = 401,
        BusinessGetSecurityQuestionListFailed = 402,
        BusinessGetFielOfStudyListFailed = 403,
        ServiceGetProfessionalByIdFailed = 404,
        ServiceValidateUserFailed = 405,
        ServiceGetProfessionalReferenceFailed = 406,

        BussinessOGSGetPurchaseExamsCountFailed = 407,
        BussinessOGSGetMyExamsPageDataFailed = 408,
        BussinessOGSGetPurchasedExamsCountFailed = 409,
        BussinessOGSGetInProgressExamsCountFailed = 410,
        BussinessOGSGetExamLastAttemptDetailsFailed = 411,

        ServiceOGSGetPurchaseExamsPageDataFailed = 412,
        ServiceOGSGetMyExamsPageDataFailed = 413,
        ServiceOGSGetExamQuestionsPageDataFailed = 414,
        ServiceOGSGetExamResultPageDataFailed = 415,
        ServiceOGSCompleteExamAttemptFailed = 416,
        ServiceOGSSaveAttemptAnswersFailed = 417,

        BussinessOGSSearchCatalogFailed = 418,
        BusinessGetGeneratedReportFailed = 440,
        BusinessGetGeneratedReportRowCountFailed = 441,
        BusinessGetReportDefinitionFailed = 442,

        ServiceValidateProfessionalUserFailed = 431,
        BussinessOGSGetCourseIdFailed = 432,
        ServiceOGSGetCourseIdFailed = 433,

        ServicePingFederateLoginFailed = 444,
        ServicePingFederateValidateUserFailed = 445,

        ControllerUserRegistrationFailled = 446,
        ControllerProfessionalAddAddressFailed = 447,
        ControllerProfessionalEditAddressFailed = 448,
        ControllerProfessionalDeleteAddressFailed = 449,
        ControllerProfessionalAddEmailFailed = 450,
        ControllerProfessionalEditEmailFailed = 451,
        ControllerProfessionalDeleteEmailFailed = 452,
        ControllerProfessionalAddPhoneFailed = 453,
        ControllerProfessionalEditPhoneFailed = 454,
        ControllerProfessionalDeletePhoneFailed = 455,
        ControllerProfessionalValidateEmailFailed = 456,
        ControllerUserCredentialFailed = 457,
        ControllerProfessionalValidateUserNameFailed = 458,
        ControllerProfessionalValidateUserFailed = 459,
        ServiceUnsubscribeTesterFalied = 460,

        ServiceGetProfessionalProfileByIdFailed = 461,
        BusinessGetProfessionalProfileByIdFailed = 462,

        BusinessGetProfessionalProductAssociationByIdFailed = 463,
        BusinessGetProfessionalPilotTestByIdFailed = 464,
        BusinessUpdateProductAssociationFailed = 465,
        BusinessUpdatePilotTestFailed = 466,
        ServiceGetProfessionalPilotTestByIdFailed = 467,
        ServiceGetProfessionalProductAssociationByIdFailed = 468,
        ServiceUpdateProductAssociationFailed = 469,
        ServiceUpdatePilotTestFailed = 470,

        ServiceUpdateProfileFailed = 471,
        BusinessUpdateProfileFailed = 472,
        ControllerUpdateProfileFailled = 473,

        BussinessOGSSearchCatalogCountFailed = 474,
        ServiceOGSSearchCatalogFailed = 475,

        ControllerUserCredentialPreviousFailed = 476,

        BussinessUpdatePurchaseInformationFailed = 477,
        ServiceUpdatePurchaseInformationFailed = 478,

        BusinessGetTimeZoneCodeFailed = 479,
        ServiceGetTimeZoneCodeFailed = 480,

        ServiceGetProfessionalProductAssociationViewByIdFailed = 481,
        ServiceGetSecurityQuestionListByUserNameEmailFailed = 482,

        GetProfessionalIdByEmailFailed = 483,
        GetSecurityQuestionListByIdFailed = 484,
        GetProfessionalLoginSecurityByIdFailed = 485,
        UpdateLoginSecurityFailed = 486,

        ControllerEditPilotTestFailed = 487,
        ControllerUpdatePilotTestFailed = 488,
        ControllerEditProductAssociationFailed = 489,
        ControllerUpdateProductAssociationFailed = 490,



        BussinessOGSGetExamOwnerByExamIdFailed = 494,
        ServiceOGSSendExamOwnerChangeNotificationFailed = 495,
        ServiceOGSSendExamCompletedNotificationFailed = 496,


        ControllerOgsCatalogFailed = 491,
        ControllerOgsSearchCatalogFailed = 492,
        ControllerOgsQuestionsFailed = 493,
        ControllerOgsDeleteQuestionFailed = 497,
        ControllerOgsPreviewQuestionFailed = 498,
        ControllerOgsImportQuestionsFailed = 499,
        ControllerOgsUploadQuestionsFailed = 500,

        ControllerOgsSearchExamsFailed = 501,
        ControllerOgsNewExamFailed = 502,
        ControllerOgsGetCourseDetailsFailed = 503,
        ControllerOgsExamDetailsFailed = 504,
        ControllerOgsNotesAndActivityFailed = 505,
        ControllerOgsDeleteNotesAndActivitiesFailed = 506,
        ControllerOgsVersioningFailed = 507,
        ControllerOgsPilotTestFailed = 508,
        ControllerOgsEmailTemplatesFailed = 509,
        ControllerOgsNewEmailTemplateFailed = 510,
        ControllerOgsModifyExamFailed = 511,
        ControllerOgsOnlineExamFailed = 512,
        ControllerOgsExamsFailed = 513,
        ControllerOgsSearchQuestionsFailed = 515,
        ControllerOgsQuestionDetailsFailed = 516,
        ControllerOgsAddAnswersFailed = 517,
        ControllerOgsDeleteAnswersFailed = 518,
        ControllerOgsEditAnswersFailed = 519,

        ControllerOgsSaveCatalogFailed = 520,
        ControllerOgsModifyCatalogFailed = 521,
        ControllerOgsDeleteCatalogFailed = 522,
        ControllerOgsExamResultsFailed = 523,

        //Oniline Grading - Remains
        BusinessGetExamDetailsFailed = 530,
        BussinessOGSGetCourseDetailsFailed = 531,
        BussinessCreateExamFailed = 532,
        BussinessGetExamNotesAndActivitiesFailed = 533,
        BussinessSaveExamNoteAndActivityFailed = 534,
        BussinessDeleteExamNoteAndActivityFailed = 535,
        BussinessGetExamQuestionsFailed = 536,
        BussinessGetExamQuestionsRecordsCountFailed = 537,
        BussinessDeleteExamQuestionAndAnswersFailed = 538,
        BussinessSaveExamQuestionFailed = 539,
        BussinessSaveExamAnswerFailed = 540,
        BussinessGetExamQuestionAnswersByExamQuestionIdFailed = 541,
        BussinessGetExamQuestionAnswersByExamIdFailed = 542,
        BussinessUpdateExamStatusFailed = 543,
        BussinessCheckIsExamAvailableFailed = 544,

        ServiceOGSGetPurchaseExamsFailed = 545,
        ServiceOGSGetOgsExamResultFailed = 546,
        ServiceOGSCompleteOgsExamAttemptFailed = 547,
        ServiceOGSSaveOgsExamAttemptAnswersFailed = 548,
        ServiceOGSGetCourseAcronymeFailed = 549,
        ServiceOGSGetExamDetailsFailed = 550,
        ServiceOGSGetCourseDetailsFailed = 551,
        ServiceOGSGetNotesAndActivitiesFailed = 552,
        ServiceOGSSearchExamsFailed = 553,
        ServiceOGSSaveExamNoteAndActivityFailed = 554,
        ServiceOGSDeleteExamNoteAndActivityFailed = 555,
        ServiceOGSGetExamQuestionsFailed = 556,
        ServiceOGSDeleteExamQuestionAndAnswersFailed = 557,
        ServiceOGSSaveExamQuestionFailed = 558,
        ServiceOGSGetExamQuestionAndAnswersByExamQuestionIdFailed = 559,
        ServiceOGSSaveExamFailed = 560,
        ServiceOGSUpdateExamStatusFailed = 561,
        ServiceOGSGetExamQuestionsWithAnswersFailed = 562,
        ServiceOGSDeleteExamCatalogFailed = 563,
        ServiceOGSGetAddCatalogPageDataFailed = 564,
        ServiceOGSGetUpdateCatalogFailed = 565,
        ServiceOGSSaveExamCatalogFailed = 566,
        ServiceOGSGenerateVersionFailed = 567,
        ServiceOGSGetVersionsFailed = 568,
        ServiceOGSUpdateQuestionFailed = 569,
        ServiceOGSImportQuestionsAndAnswersFailed = 570,
        ServiceOGSGetMyOgsExamsFailed = 571,

        BussinessGetUpdateCatalogFailed = 572,
        BussinessViewExamFailed = 573,
        BussinessCheckIsCourseMeasurementAvailableCalledFailed = 574,
        BussinessOGSGetExamVersionsFailed = 575,
        BusinessUpdateExamQuestionAnswerFailed = 576,
        BussinessOGSUpdateExamDetailsFailed = 577,
        BussinessOGSArchiveExamsFailed = 578,
        BussinessGetExamQuestionByExamQuestionIdCalledFailed = 579,
        BussinessOGSGetExamAnswerOptionsFailed = 580,
        BusinessDeleteExamQuestionAnswersFailed = 581,
        BusinessSearchExamsFailed = 582,
        BusinessGetSearchedExamsCountFailed = 583,
        BusinessDeleteExamCatalogFailed = 584,
        BusinessGetAddNewCatalogDataFailed = 585,
        BussinessSaveExamCatalogFailed = 586,

        BussinessOGSGetPurchaseExamsFailed = 587,
        BussinessOGSGetCourseAcronymeFailed = 588,
        BussinessOGSGetMyExamsFailed = 589,
        BussinessOGSGetOgsPurchasedExamsCountFailed = 590,
        BussinessOGSGetOgsInProgressExamsCountFailed = 591,
        BussinessOGSGetFailedAttemptCountForExamFailed = 592,
        BussinessOGSGetFailedUserCountForExamFailed = 593,
        BussinessOGSGetOgsExamLastAttemptDetailsFailed = 594,
        BussinessOGSCreateExamAttemptFailed = 595,
        BussinessOGSSaveOgsExamAttemptAnswersFailed = 596,
        BussinessOGSCompleteOgsExamAttemptFailed = 597,
        BussinessOGSGetUnitNumberByProfessionalIdFailed = 598,

        ControllerPreviewCourseFailed = 599,

        ServiceSharedGetMacrosFailed = 600,
        ServiceSharedGetEmailTemplatesByModuleIdFailed = 601,
        ServiceSharedGetEmailTemplateFailed = 602,
        ServiceSharedGetEmailTemplateDetailsFailed = 603,
        ServiceSharedSaveEmailTemplateFailed = 604,
        ServiceSharedDeleteEmailTemplateFailed = 605,
        ServiceSharedGetEmailSenderListFailed = 606,
        ServiceSharedGetEmailSenderDetailsFailed = 607,
        ServiceSharedSaveEmailSenderDetailsFailed = 608,
        ServiceSharedDeleteEmailSenderDetailsFailed = 609,

        ServiceOGSEntitlementGetPurchasedUnisonIdsFailed = 610,
        ServiceOGSEntitlementIsExamPurchasedFailed = 611,
        ServiceOGSEntitlementUpdateExamStatusFailed = 612,

        BusinessUpdateOgsPropertiesFailed = 613,

        ControllerSharedPreviewTemplateFailed = 614,
        ControllerSharedModifyEmailTemplateFailed = 615,
        ControllerSharedNewEmailTemplateFailed = 616,
        ControllerSharedEmailSenderDetailsFailed = 617,
        ControllerSharedSaveSenderDetailsFailed = 618,
        ControllerSharedDeleteSenderFailed = 619,
        ControllerSharedSaveEmailTemplateFailed = 620,
        ControllerSharedGetEmailTemplateListFailed = 621,

        ServiceOGSNoEmailTemplateAvailable = 622,
        ServiceOGSEmailTemplateStatusNotAvailable = 623,
        ServiceOGSEmailTemplateNotActive = 624,
        ServiceOGSEmailSenderNotAvailable = 625,
        ServiceOGSEmailSenderDetailsNotAvailable = 626,

        BusinessGetAuthorDetailsFailed = 614,

        ControllerTesterProfilesFailed = 627,
        ControllerUpdateTesterProfileFailed = 628,
        ControllerTesterProfilesExportToExcelFailed = 629,

        ServiceGetProfessionalProfileFailed = 630,
        ServiceGetTesterProfilesAsExcelDocumentFailed = 631,

        BusinessUpdatePilotTesterStatusFailed = 632,

        BusinessGetCurrentUserDetailsBySafeUserIdFaild = 633,

        ControllerPreviewPhotoFailed = 634,


        ServiceOGSEntitlementAddActivityForProfessionalFailed = 635,
        ServiceOGSEntitlementUpdateActivityForProfessionalFailed = 636,
        SharedSessionModule = 637,

        ServiceOGSEntitlementAddExamActivityForProfessionalFailed = 641,
        ServiceOGSEntitlementUpdateExamActivityForProfessionalFailed = 642,

        BusinessGetEmailSenderListFailed = 643,
        BusinessSaveEmailSenderDetailsFailed = 644,
        BusinessDeleteEmailSenderDetailsFailed = 645,
        BusinessGetTimeZoneDetailsByTimeZoneCodeFailed = 646,
        BusinessGetEmailTemplatesByModuleIdFailed = 647,
        ServiceGetResourceAuthorsDetails = 648,
        BusinessHasCETrackingLicenseForProfessional = 649,

        ControllerReportsDeleteReportInstanceFailed = 650,
        ControllerReportsValidateReportInstanceFailed = 651,
        ServiceReportsIsReportInstanceExistFailed = 652,
        BusinessReportsIsReportInstanceExistFailed = 653,
        ServiceReportsGetReportDetails = 4213,

        BusinessGetPilotTestIdByCourseMetadataIdFailed = 654,
        ServiceGetPilotTestIdByCourseMetadataIdFailed = 655,
        BussinessOGSGetUnitNumberByFirmIdFailed = 656,
        ControllerIsUserLinkedToCheckpoint = 703,

        ServiceOGSGetProductPricesFailed = 704,
        ServiceGetShippingAddressForProfessional = 705,
        AssignSeatsForMultipleProducts,

        // Promo codes
        //
        GetPromoCodes,
        GetAutomaticPromoCodes,
        GetPromoCodeRules,
        UpsertPromoCode,
        GetCriteriaValues,
        GetCardID,
        UpdateLastLineNumber,
        UpdateCartSession,

        //
        // Metadata
        //
        ServiceGetMaxNumberOfDaysFailed,
        BusinessGetMaxNumberOfDaysFailed,
        BusinessGetCourseMetadataGeneralFailed,
        BusinessGetCourseSponsorsFailed,
        ServiceGetCourseMetadataGeneralByAcronymFailed,
        ControllerGeneralFailed,
        ServiceGetCourseSponsorListFailed,
        ServiceGetCourseInteractivityLevelListFailed,
        BusinessGetCourseInteractivityLevelsFailed,
        BusinessGetBrandsBySponsorListFailed,
        ServiceGetBrandsBySponsorListFailed,
        BusinessGetNasbaDeliveryFormatsBySponsorListFailed,
        ServiceGetNasbaDeliveryFormatsBySponsorListFailed,
        BusinessGetNasbaDeliveryBySponsorListFailed,
        BusinessGetDeliveryFormatsByNasbaDeliveryIdFailed,
        ServiceGetDeliveryFormatsByNasbaDeliveryIdFailed,
        ServiceGetLearningLevelsListFailed,
        BusinessGetLearningLevelsFailed,
        BusinessGetFieldOfStudyListByFoSIDFailed,
        ServiceGetFieldOfStudyListByFoSIDFailed,

        BusinessGetInteractiveLearningFailed,

        BusinessGetCourseMetadataXMLFailed,
        BusinessGetActivityIdFailed,
        BusinessGetSponsorNameFailed,
        BusinessGetCourseAvcFailed,
        BusinessCourseInteractivityLevelFailed,
        BusinessGetNASBAInteractiveFailed,
        BusinessGetBioPtrFailed,
        BusinessGetNasbaCreditsFailed,

        BusinessUpdateCourseMetadataXMLFailed,
        BusinessUpdateCourseMetadataOutlineFailed,

        ServiceGetInteractiveLearningListFailed,
        ServiceDeterminePublishModeFailed,
        ServiceUpdateCourseMetadataXMLFailed,
        ServiceUpdateCourseMetadataOutlineFailed,
        ServiceGetCourseMetadataXMLFailed,
        ServiceGetNasbaCreditsFailed,

        ServiceSaveClickThroughFailed,

        BusinessSaveClickThroughFailed,

        ServiceGetSupplementalMaterialFailed,
        BusinessGetCourseMetadataSupplementsFailed,
        ControllerSupplementalMaterialSaveOutlineFailed,
        ControllerSupplementalMaterialFailed,

        BusinessSaveCourseEvaluationFailed,
        BusinessSaveCourseCreditFailed,
        ServiceSaveCourseEvaluationFailed,
        ServiceSaveCourseCreditFailed,

        ControllerMetadataCourseListFailed,
        ServiceGetCourseMetadataCollectionsFailed,
        BusinessCourseMetadataCollectionsFailed,

        BusinessGetCourseSearchCollectionsFailed,
        BusinessGetCourseMetadtaCountFailed,
        BusinessUpdateActiveVersionInCourseRecordFailed,
        BusinessInsertOrUpdateCourseRecordFailed,
        BusinessGetCourseMetadataIDByAcronymFailed,
        BusinessGetCourseSponsorDetailsFailed,

        BusinessGetChildrenListByCMDIDFailed,
        BusinessSaveGeneralFailed,
        BusinessDeleteParentFailed,
        BusinessAddParentFailed,
        BusinessGetMediaFormatsByCMDIDFailed,
        BusinessGetMediaFormatListFailed,
        BusinessGetParentsListByCMDIDFailed,

        ControllerTableOfContentFailed,
        ControllerStatusFailed,
        ControllerMarketingFailed,
        ControllerMeasurementFailed,
        ControllerCertificationsCreditsFailed,
        ControllerContributorsFailed,

        BusinessGetContributorsAuthorFailed,
        BusinessGetContributorsReviewerFailed,
        BusinessGetContributorsDataFailed,
        ServiceGetContributorsAuthorFailed,
        ServiceGetContributorsReviewerFailed,
        ServiceGetContributorsDataFailed,

        ServiceGetCourseSearchCollectionsFailed,
        BusinessGetAuthorListFailed,
        BusinessGetReviewerListFailed,
        BusinessGetPermissionToRepublishListFailed,
        BusinessGetAuthorResourceListFailed,
        BusinessGetReviewerResourceListFailed,
        ServiceGetResourceListFailed,
        ServiceGetPermissionToRepublishListFailed,
        ServiceGetAuthorResourceListFailed,
        ServiceGetReviewerResourceListFailed,
        ServiceGetAuthorListFailed,
        ControllerSaveContributorsInformationFailed,
        ControllerSaveContributorsAuthorDataFailed,
        ControllerSaveContributorsReviewerDataFailed,
        ControllerGetContributorsCalledFailed,
        ControllerInsertUpdateContributorsAuthorDataFailed,
        ControllerInsertUpdateContributorsReviewerDataFailed,
        ControllerDeleteContributorsAuthorDataFailed,
        ControllerDeleteContributorsReviewerDataFailed,
        ControllerEditContributorsAuthorDataFailed,
        ControllerEditContributorsReviewerDataFailed,
        ControllerSaveContributorsDataFailed,
        ServiceSetPricesToProductDeliveryFormatsFailed = 700,
        ServiceSetPriceToProductDeliveryFormatFailed = 701,
        ServiceSetPricesToCourseInstancesFailed = 702,
        ServiceGetGradingFeeFailed = 706,

        BusinessAddMediaFormatFailed,
        BusinessCourseSponsorStateBoardFailed,
        BusinessDeleteMediaFormatFailed,
        BusinessDeleteNasbaFoSListFailed,
        BusinessGetCertificationsAndCreditsDataFailed,
        BusinessGetCourseActivityProfileByIDFailed,
        BusinessDeleteSponsorLevelMembershipFailed,
        BusinessDeleteCourseLevelMembershipFailed,
        BusinessGetCourseLevelMembershipDropdownFailed,
        BusinessGetCourseLevelDataFailed,
        BusinessGetCourseLevelMembershipsFailed,
        BusinessGetCourseNasbaCreditsFailed,
        BusinessGetCourseSponsorStateBoardCreditListFailed,
        BusinessGetNasbaFoSDataFailed,
        BusinessGetNasbaFoSDropdownFailed,
        BusinessGetNasbaFoSListFailed,
        BusinessGetNasbaFoSIDFailed,
        BusinessGetNasbaFosStateBoardCategoryFailed,
        BusinessGetSponsoreDataFailed,
        BusinessGetSponsorLevelDataFailed,
        BusinessGetSponsorLevelMembershipDropdownFailed,
        BusinessGetSponsorLevelMembershipIDFailed,
        BusinessGetSponsorLevelMembershipsFailed,
        BusinessGetStateBoardsStateFailed,
        BusinessGetStateFoSCatagoryDropdownFailed,
        BusinessGetPilotTestCPECreditsFailed,
        BusinessUpdateSummaryInCourseInstanceFailed,
        BusinessSaveCertificationsAndCreditsDataFailed,
        BusinessInsertUpdateCourseLevelMembershipFailed,
        BusinessInsertUpdateContributorsAuthorDataFailed,
        BusinessGetUnisonIDByCourseInstanceIDFailed,
        BusinessGetStateFoSCategoryDropdownAbbreviationFailed,

        ServiceAddMediaFormatFailed,
        ServiceAddParentFailed,
        ServiceDeleteContributorsDataFailed,
        ServiceDeleteCourseLevelMembershipFailed,
        ServiceDeleteMediaFormatFailed,
        ServiceDeleteNasbaFoSListFailed,
        ServiceDeleteSponsorLevelMembershipFailed,
        ServiceGetCertificationsAndCreditsDataFailed,
        ServiceGetChildrenListByCMDIDFailed,
        ServiceGetContributorsAuthorDataFailed,
        ServiceGetMediaFormatListFailed,
        ServiceGetCourseLevelMembershipDropdownFailed,
        ServiceGetMediaFormatsByCMDIDFailed,
        ServiceGetCourseMetadataIDByAcronymFailed,
        ServiceGetCourseLevelMembershipListFailed,
        ServiceGetContributorsReviewerDataFailed,
        ServiceGetCourseLevelDataFailed,
        ServiceGetCourseSponsorDetailsFailed,
        ServiceGetNasbaFoSDataFailed,
        ServiceGetNasbaFoSDropdownFailed,
        ServiceGetParentsListByCMDIDFailed,
        ServiceGetNasbaFoSIDFailed,
        ServiceGetNasbaFoSListFailed,
        ServiceGetNasbaFosStateBoardCategoryFailed,
        ServiceGetSponsorCourseSponsorStateBoardMembershipFailed,
        ServiceGetStateFoSCategoryDropdownAbbreviationFailed,
        ServiceGetSponsorLevelMembershipIDFailed,
        ServiceGetSponsorLevelMembershipListFailed,
        ServiceGetSponsorLevelMembershipDropdownFailed,
        ServiceGetSponsorLevelDataFailed,
        ServiceGetSponsoreDataFailed,
        ServiceGetPilotTestCPECreditsFailed,
        ServiceGetStateFoSDropdownFailed,
        ServiceGetStateBoardsStateFailed,
        ServiceInsertUpdateNasbaFoSListFailed,
        ServiceInsertUpdateContributorsReviewerDataFailed,
        ServiceInsertUpdateContributorsAuthorDataFailed,
        ServiceGetUnisonIDByCourseInstanceIDFailed,
        ServiceInsertOrUpdateCourseRecordFailed,
        ServiceUpdateActiveVersionInCourseRecordFailed,
        ServiceSaveCertificationsAndCreditsDataFailed,
        ServiceInsertUpdateSponsorLevelMembershipFailed,
        ServiceInsertUpdateCourseLevelMembershipFailed,
        ServiceUpdateSummaryInCourseInstanceFailed,
        ServiceGetCourseSponsorStateBoardCreditListFailed,

        ControllerGetNasbaFoSListFailed,
        ControllerDeleteNasbaFoSDataFailed,
        ControllerDeleteSponsorLevelFailed,
        ControllerDeleteCourseLevelFailed,
        ControllerGetSponsorLevelFailed,
        ControllerGetCourseLevelFailed,
        ControllerInsertUpdateSponsorLevelMembershipFailed,
        ControllerInsertUpdateCourseLevelMembershipFailed,
        ControllerSaveCertificationsAndCreditsDataFailed,
        ControllerGetCertificationsCreditsInformationFailed,
        ControllerSaveStatusDataFailed,

        BusinessGetProductExclutionListFailed,
        BusinessGetExclutionListCountFailed,
        BusinessExcludeOrIncludeUnisonIDFailed,
        ServiceGetProductListFailed,
        ServiceExcludeOrIncludeUnisonIDFailed,
        ControllerExcludeProductsFailed,
        ControllerExcludeProductsDataFailed,
        ControllerExcludeOrIncludeUnisonIDFailed,
        ControllerCheckpointRedirectFailed,

        //CPL Data Migration - Error Messages
        MigrationAccountManagmentServiceGetExamMigrationDetailsFailed = 710,
        MigrationLoggerWriteMethodFailed = 711,
        ValidateUserCredentialsForlegacySystemAccountsError = 712,
        CreateMigrationJobAndBeginMigrationAsynchronouslyFailed = 713,
        StartCreateMigrationJobAndBeginMigrationAsynchronouslyFailed = 714,

        AbortDataMigrationJobFailed = 715,
        AbortSelectedTaskExecutionFailed = 716,
        SearchMigrationProfessionalStatusFailed = 717,
        GetMigrationSearchResultWithPageDataFailed = 718,
        GetDataMigrationLogByJobIdFailed = 719,
        AsynchronouslyRetryMigrationJobFailed = 720,

        AsynchronouslyRetryATaskFailed = 721,
        GetJobDataInUIFriendlyFormatFailed = 722,
        //SaveJobPropertiesFailed = 723, {There is no specific exception and we not log any exception on this me thode}
        //AsynchronouslyRetryMigrationJobFailed = 724, 
        GetDataMigrationTaskListFailed = 725,
        GetFirmMigrationSearchResultWithPageDataFailed = 726,
        SearchFirmMigrationDataFailed = 727,
        GetUnisonShipToInformationFailed = 728,
        //Ends CPL Data Migration - Error Messages

        //CPL (Controllers) MigrationControllers - Error Messages
        MigrationControllersActionForIndexViewFailed = 750,
        CallingIndexViewWithMigrationIndexModelAsParamFailed = 751,
        CllingIndexViewWithMigrationActionForTaskStatusFailed = 752,
        CllingSaveJobPropertiesFailed = 753,
        CllingActionForLogsFailed = 754,
        CllingPostActionForLogsFailed = 755,
        AbortSelectedDataMigrationJobFromJobDetailsPageFailed = 756,
        AbortSelectedDataMigrationJobFromJobSearchPageFalied = 757,
        RestartSelectedDataMigrationJobFromJobDetailsPageFailed = 758,
        RestartSelectedDataMigrationJobFromJobSearchPageFailed = 759,
        StartSelectedDataMigrationJobDetailsPageFailed = 760,
        StartSelectedDataMigrationJobFromSearchPageFalied = 761,
        RefreshJobDetailsPartialPageFailed = 762,
        //Following will keep as referance and no loging required since its a direct contact transfer
        //StartSelectedDataMigrationJobDetailsPageFailed3 = 763,
        RetrySelectedDataMigrationTaskFailed = 764,
        AbortSelectedDataMigrationTaskFailed = 765,
        ExecuteTheCommandsUsingMigrationAgentsFailed = 766,
        MigrationControllerActionForFirmsViewFailed = 767,
        CallingFirmsViewWithMigrationFirmsModelAsParamFailed = 768,
        MigrationControllerCallingAddFirmViewFailed = 769,
        MigrationControllerCallingAddFirmViewWithMigrationJobIdAsParamFailed = 770,
        MigrationControllerCallingFirmMigrationJobStatusViewFailed = 771,
        MigrationControllerCallingFirmMigrationLogsViewFailed = 772,
        MigrationControllerCallingFirmMigrationProfileSummaryViewFailed = 773,
        MigrationControllerCallingNotesForTechnicalHandlingViewFailed = 774,
        MigrationControllerSavingTheTechnicalNoteAndRedirectingToFirmsViewFailed = 775,
        MigrationControllerCallingSortFirmInfoFailed = 776,
        MigrationControllerCallingSortIpInfoFailed = 777,
        //Ends CPL (Controllers) MigrationControllers - Error Messages

        //CPL (Business) MigrationComponent - Error Log Messages of Method initiation
        //Enum keys allocated 800 to 825
        BusinessSearchMigrationProfessionalStatusFailed = 800,
        BusinessGetMigrationProfessionalStatusCountFailed = 801,
        BusinessGetMigrationJobStatusListFailed = 802,
        BusinessGetDataMigrationLogByJobIdFailed = 803,
        BusinessGetDataMigrationLogsCountFailed = 804,
        BusinessGetsJobDetailsByAGivenJobIdFailed = 805,
        BusinessPersistsAJobWithTheJobToBeSavedFailed = 806,
        BusinessUpdateTaskDetailsWithTheTaskDetailsToBeSavedFailed = 807,
        BusinessRetrivesAllProductsInformationFailed = 808,
        BusinessSaveALogEntryWithTheLogEntryDetailsFailed = 809,
        BusinessSaveExtractedDataFromLegeacySystemsFailed = 810,
        BusinessGetExtractedXmlDataFailed = 811,
        BusinessSaveNewTechnicalHandlingNoteFailed = 812,
        BusinessSaveTechnicalHandlingNoteFailed = 813,
        BusinessGetMicroMashCompanyTypeFailed = 814,
        //Ends CPL (Business) MigrationComponent - Error Messages   

        //CPL Migration Tasks Logs - Information Log Messages of Migration tasks execution
        //Enum keys allocated 825 to 849
        IPTasksExecutesTaskLoadHistoryDataLodedFailed = 825,
        IPTasksExecutesTaskLockAccountFailed = 826,
        IPTasksExecutesTaskUnLockAccountFailed = 827,
        IPTasksExecutesTaskValidateAndLockTaskFailed = 828,
        IPTasksExecutesTaskValidateCredentialsFailed = 829,
        IPSendNotificationEmailFailed = 861,
        //End of CPL Migration Tasks Logs - Information Log Messages of Migration tasks execution

        //Start-Data Migration: Data import tasks messages. 
        TaskLogImportDataExecuteCompleteFailed = 840,
        TaskLogIPImportDataTasksExecutesExeption = 841,
        CommonLogIPImportDataTasksExecutesFailed = 842,
        CommonLogIPImportDataTasksExecutesExeption = 843,
        TaskLogIPImportDataExecutesComplete = 844,
        //End-This will take by Migration/Tasks/Loging tab for view to the user

        ControllerAddMembershipsFailed = 850,
        ControllerDeleteMembershipFailed = 851,
        ServiceGetShippingInformationFailed = 852,
        ServiceGetProfessionalMembershipAssociationByIdFailed = 853,
        ServiceUpdateMembershipAssociationFailed = 854,
        BusinessGetProfessionalMembershipAssociationByIdFailed = 855,
        BusinessUpdateMembershipAssociationFailed = 856,
        BusinessSaveIpDataMigrationJobFailed = 857,
        BusinessSaveDataMigrationJobQueueMethodFailed = 858,
        BusinessGetMigrationCommandsMethodFailed = 859,
        BusinessDeleteMigrationCommandsMethodFailed = 860,

        ServiceCUASAssignEntitlementFailed = 865,
        ServiceUnisonGetOrderHistoryFailed = 866,
        ServiceUnisonAddOrderToOrderLineFailed = 867,
        ServiceUnisonConfirmOrderFailed = 868,
        ServiceUnisonCompleteOrderFailed = 869,
        ServiceOrderProcessingCreateOrderFailed = 870,
        ServiceEntitlementAssignSeatsFailed = 871,

        BusinessSaveFirmMigrationStoredProcOperationFailed = 872,
        BusinessGetMigrationCommnadsWithFirmDataTransferCompleteOrFailedTasksMethodCalledFailed = 873,
        BusinessGetInactiveFirmMigrationCommandCountFailed = 874,
        BusinessGetFirmDataLoadedStatus = 875,
        BusinessInitiateFirmMigrationDataLoading = 876,
        IPMigrationEmptyDataReturnError = 877,
        BusinessFirmMigrationActivityCertificateSaveFailed = 878,
        BusinessFirmMigrationAccCertificateProfileSaveFailed = 878,
        BusinessFirmMigrationFirmSaveFailed = 879,

        BusinessGetOrganizationAdminPreferenceByIdFailed = 881,

        //Defect fix for #85059
        ServiceCheckIfPilotTestCourseCompletedFailed = 882,
        BusinessIsPilotTestCourseCompletedFailed = 883,


        //Start-Firm Data Migration Web log messages. Dedicated keys 1050 to 1075  
        WebGetReqwiredInformationFailed = 1050,
        WebGetMicroMashInformationFailed = 1051,
        WebGetShipToInformationFailed = 1052,
        WebGetShipToInformationUnisonWebServiceFailed = 1053,
        //End-Firm Data Migration.

        //Start-Firm data migration common messages. Dedicated keys 1076 to 1100  
        SaveFirmMigrationCertificateFailed = 1076,
        BusinessFirmMigrationActivityCertificateAssociationSaveFailed = 1077,
        BusinessFirmMigrationCertificateProfileSaveFailed = 1078,
        BusinessFirmMigrationCertificateProfileAssociationSaveFailed = 1079,
        BusinessFirmMigrationFirmProfessioanlAddressSaveFailed = 1080,
        FirmMigrationProcessMicroMashAndPassOnlineDataFailed = 1081,
        FirmMigrationProcessMicroMashAndPassOnlineDataNotFound = 1082,
        //End-Common Firm Data Migration.

        //Start-Course meta data common messages. Dedicated keys 1200 to 1225
        LogLiveSeminarProcessFailed = 1200,
        //End-Course meta data common messages.

        //Start-Course meta data common messages. Dedicated keys 1226 to 1250
        GetReqCollegeSeatRecordsForOrgIdFailed = 1226,
        GetSeatsLearningRecordsForOrgIdFailed = 1227,
        GetHRIntegrationEntitlementRecordCount = 1228,
        GetOrganizationHostRecordCount = 1229,
        GetOrganizationSingleSignOnByOrghId = 1230,
        //End-Course meta data common messages.

        //Start OGSCatalog data access error messages dedicated 1251 to 1260
        GetOgsCatalogIdByUnisonIdFailed = 1251,

        //End OGSCatalog data access error messages dedicated 1251 to 1260

        //Product List Error Messages
        //Enum keys allocated 1260 to 1285
        ControllerCallingSearchProductsFailed = 1260,
        ServiceSearchProductDetailsFailed = 1261,
        BusinessSearchProductDetailsFailed = 1262,
        BusinessSaveOrderInformationForReportFailed = 1263,
        BusinessAddProductsFailed = 1264,
        ServiceDeleteProductsFailed = 1265,

        //Global enums 1286~1300/1351~1385 allocated to auto notify courses error messages
        BussinessDeleteEmailDistributionListFailed = 1286,
        BussinessSaveEmailDistributionListFailed = 1287,
        BussinessGetAutoNotifyEmailLogFailed = 1288,
        BussinessSearchEmailDistributionListsFailed = 1289,

        ServiceSearchEmailDistributionListsFailed = 1290,
        BussinessGetAutoNotifyEmailLogRecordCountFailed = 1291,
        BussinessGetTemplateEmailDistributionListCountFailed = 1292,
        ServiceDeleteEmailDistributionListFailed = 1293,

        ServiceGetAutoNotifyEmailFailed = 1294,
        ServiceGetEmailDistributionListFailed = 1295,
        ServiceSaveEmailDistributionListFailed = 1296,
        BussinessGetEmailDistributionListFailed = 1297,
        BusinessSearchEmailDistributionListsFailed = 1298,

        //
        ControllerManageEmailDistributionListFailed = 1299,
        ControllerGetEmailDistributionListFailed = 1300,
        ControllerDeleteEmailDistributionListFailed = 1351,
        ControllerSaveEmailDistributionListFailed = 1352,

        ControllerAutoNotifyEmailTemplatesFailed = 1353,
        ControllerDeleteAutoNotifyEmailTemplateFailed = 1354,
        ControllerModifyAutoNotifyEmailTemplateFailed = 1355,
        ControllerAutoNotifyEmailTemplatesAsParamFailed = 1356,
        ControllerAddNewEmailTemplateFailed = 1357,
        ControllerClearEmailTemplateFailed = 1358,

        ControllerManageTemplateLogFailed = 1359,
        ServiceSearchTemplatesFailed = 1360,
        ServiceDeleteTemplateFailed = 1361,
        ServiceGetTemplateFailed = 1362,
        ServiceSaveTemplateFailed = 1363,
        ServiceSendAutoNotifyEmailFailed = 1364,

        BusinessSearchTemplatesFailed = 1365,
        BusinessDeleteTemplateFailed = 1366,
        BusinessGetTemplateFailed = 1367,
        BusinessGetAutoNotifyFrequenciesFailed = 1368,
        BusinessGetAutoNotifyVersionsFailed = 1369,
        BusinessSaveTemplateFailed = 1370,
        BusinessGetSelectedEmailDistributionGroupsByTemplateIdFailed = 1371,
        BusinessGetSelectedFieldOfStudiesByTemplateIdFailed = 1372,
        BusinessGetSelectedBrandsByTemplateIdFailed = 1373,

        BusinessGetRecipientEmailsByTemplateIdFailed = 1374,
        BusinessAddAutoNotifyEmailNotifyLogFailed = 1375,
        BusinessUpdateTemplateLastNotifiedDateFailed = 1376,
        BusinessGetEmailTemplatesFailed = 1377,
        BusinessFetchNotificationEmailDetailsFailed = 1378,


        //Global enums 1301~1350 allocated to Ssm enhancement error messages
        BussinessSSMGetOrganizationIdByFirmUserNameFailed = 1301,
        BusinessGetProfessionalRefIdFailed = 1302,
        BussinessGetCplOrganizationInformationFailed = 1303,

        ServiceCplRequestOrgIdParamNullOrEmpty = 1304,
        ServiceCplRequestMessageHashParamNullOrEmpty = 1305,
        ServiceCplRequestUsernameParamNullOrEmpty = 1306,
        ServiceCplRequestActionParamNullOrEmpty = 1307,
        ServiceCplRequestTimeStampParamNullOrZero = 1308,
        ServiceCplRequestSequanceNoParamNullOrZero = 1309,
        SsoActionCeStatusActionParamNullOrEmpty = 1310,
        SsoActionCeStatusRefIdParamNullOrEmpty = 1311,
        SsoActionCeStatusCeProfileIdParamNullOrEmpty = 1312,

        ServiceScheduleServiceStartFailed = 1379,
        ServiceScheduleServiceExecuteActivityFailed = 1380,
        ServiceOGSGetFirmAdminMyExamsFailed = 1381,

        //Diagnostic Log Messages
        //Enum keys allocated 1385 to 1390
        DiagnosticControllersActionForIndexViewFailed = 1385,

        //Global enums 1390~1450 allocated for live event schedule management
        BusinessDeleteScheduleFailed = 1390,
        ServiceDeleteScheduleFailed = 1391,
        BusinessGetSchedulesFailed = 1392,
        ServiceGetSchedulesFailed = 1393,
        BusinessSaveScheduleFailed = 1394,
        ServiceSaveScheduleFailed = 1395,
        BusinessGetScheduleFailed = 1396,
        BusinessGetScheduleListCountFailed = 1397,
        ControllerLiveEventScheduleGridDataFailed = 1398,
        ServiceGetScheduleFailed = 1399,
        //End Global enums 1390~1450 allocated for live event schedule management

        //Start - Live event error messages - 1501 to 1550
        LiveEventServiceSaveLiveEventDetailFailed = 1501,
        LiveEventComponentSaveLiveEventDetailFailed = 1502,
        LiveEventComponentDeleteLiveEventFailed = 1503,
        LiveEventComponentDeleteLiveEventCredits = 1504,
        LiveEventComponentDeleteNasbaFosCreditsFailed = 1504,
        LiveEventServiceDeleteLiveEventFailed = 1505,
        LiveEventComponentAddNasbaFosCreditsFailed = 1506,
        SharedComponentsGetCollegesFailed = 1507,
        SharedComponentsGetNasbaDeliveryFormatsFailed = 1508,
        SharedComponentsGetCourseDeliveryFormatsFailed = 1509,
        LiveEventServiceSearchLiveEventsFailed = 1510,
        LiveEventComponentSearchLiveEventsFailed = 1511,
        LiveEventServiceGetSearchPageDataFailed = 1512,
        LiveEventServiceGetDetailPageDataFailed = 1513,
        LiveEventGetItemListFailed = 1514,
        LiveEventRetrieveReferenceIdValueFailed = 1515,
        LiveEventImportLiveSeminarDataFailed = 1516,
        //LiveEventImportLiveSeminarDataFailed = 1517,
        LiveEventValidateImportedLiveEventDataFailed = 1518,
        LiveEventLogLiveEventFailed = 1519,
        LiveEventLogLiveEventSummaryInfoFailed = 1520,

        //Live Event Order Entry
        LiveEventComponentSearchProfessionalOrderHistoryFailed = 1521,
        LiveEventComponentSearchProfessionalOrderHistoryCountFailed = 1522,
        LiveEventServiceSearchProfessionalOrderHistoryCountFailed = 1523,
        LiveEventServiceSearchProfessionalOrderHistoryFailed = 1524,
        LiveEventControllerSearchProfessionalOrderHistoryFaild = 1525,

        //Live Event Product
        SaveLiveEventProductDetailsSuccessful = 1526,
        SaveLiveEventProductDetailsFail = 1527,

        //Live Event Course Metadata

        AgendaControllerHelperAgendaFailed = 1530,
        AgendaControllerHelperGetAgendaDetailsFailed = 1531,
        AgendaControllerHelperGetSeminarAgendaTopicDetailsFailed = 1532,
        AgendaControllerHelperUpdateSeminarAgendaDetailsFailed = 1533,
        CourseMetadataServiceGetAgendaDetailsFailed = 1534,
        CourseMetadataServiceGetSeminarAgendaTopicDetailsFailed = 1535,
        CourseMetadataServiceUpdateSeminarAgendaDetailsFailed = 1536,
        CourseMetadataComponentGetNasbaFosListValuesFailed = 1537,
        CourseMetadataComponentGetSeminarDaysFailed = 1538,
        CourseMetadataComponentGetAgendaDetailsFailed = 1539,
        CourseMetadataComponentGetSeminarAgendaDetailsRecordCountFailed = 1540,
        CourseMetadataComponentGenerateSeminarAgendaSelectQueryFailed = 1541,
        CourseMetadataComponentGetSeminarAgendaTopicDetailsFailed = 1542,
        CourseMetadataComponentAddSeminarAgendaDetailsFailed = 1543,
        CourseMetadataComponentUpdateSeminarAgendaDetailsFailed = 1544,
        CourseMetadataComponentIsSeminarScheduleAvailableFailed = 1545,




        //End of Live event error messages - 1501 to 1550

        //Start - Application Integration error messages - 1551 to 1600
        ControllerActionManageExternalApplicationFailed = 1551,
        ControllerGetProfessionalApplicationsFailed = 1552,
        ControllerActionApplicationUnlinkFailed = 1553,
        ControllerActionRedirectToApplicationFailed = 1554,
        ControllerIsUserLinkedToApplicationFailed = 1555,
        BusinessGetApplicationsFailed = 1556,
        BusinessGetApplicationByIdFailed = 1557,

        ServiceGetApplicationByIdFailed = 1558,
        ServiceGetApplicationsFailed = 1559,
        ControllerActionRedirectToProfileOnlineFailed = 1560,
        ControllerActionManageCompetenciesFailed = 1561,
        ControllerOspLaunchFailed = 1562,
        ControllerOspCourseFinderFailed = 1563,

        //Society Setup 2400-2420
        SaveLiveEventSocietyUpdateDetailsSuccessful = 2400,
        SaveLiveEventSocietyUpdateDetailsFailed = 2401,
        SaveLiveEventSocietyDeleteSuccessful = 2402,
        SaveLiveEventSocietyDeleteFailed = 2403,
        LiveEventSocietyDetailsUpdateSuccessful = 2404,
        LiveEventSocietyDetailsUpdateFailed = 2405,
        LiveEventSocietyDetailsDeleteFailed = 2406,

        //End - Application Integration error messages - 1551 to 1600

        //Start - ProductMetadata - 1700 to 1720
        WebConfigBundlePackagetypeIds_Failed = 1700,
        //WebConfig_bundlePackagetypeIds_Failed = 1701,
        ServiceGetGeneralProductInformationFails = 1702,
        ServiceGetProductDetailsFails = 1703,
        ControllerGetBundlePackagesFails = 1704,
        ServiceGetBundlePackagesFailed = 1705,
        BussinesGetBundlePackagesFailed = 1706,
        ProductMDServiceSaveVisitInformationFailed = 1707,
        ServiceSaveSponsorVisitFailed = 1708,
        //End - Application Integration error messages - 1700 to 1720

        //Start - Product Reconciliation Report 1721 to 1740
        ControllerReportsProductReconciliationReportFailed = 1721,
        ControllerReportsSearchProductReconciliationFailed = 1722,
        ControllerReportsProductReconciliationExcelReportFailed = 1723,

        //End - Product Reconciliation Report 1721 to 1740


        #region Live Event Seminar
        SeminarNotSelectedHeader = 1530,
        SeminarNotSelectedMessage = 1531,
        SeminarAddedHeader = 1532,
        SeminarAddedMessage = 1533,
        SeminarNotAddedHeader = 1534,
        SeminarNotAddedMessage = 1535,
        #endregion

        //Live event order entry 1750 to 2000
        #region Live event order entry
        LiveEventControllerSaveProfessionalDetailsFailled = 1750,
        ServiceSaveProfessionalDetailsFailed = 1751,
        ServiceUpdateProfessionalDetailsFailed = 1752,
        BusinessSaveProfessionalDetailsFailed = 1753,
        BusinessUpdateProfessionalDetailsFailed = 1754,
        BusinessGetOrderByIdFailed = 1755,
        BusinessGetOrderResultCountFailed = 1756,
        BusinessGetOrderLevelDetailFailed = 1757,
        BusinessGetOrderProductDetailbyIdFailed = 1758,
        BusinessGetOrderProductDetailCountFailed = 1759,
        BusinessDeleteOrderProductFailed = 1760,
        ServiceGetOrderByIdFailed = 1761,
        ServiceGetOrderResultCountFailed = 1762,
        ServiceGetOrderLevelDetailFailed = 1763,
        ServiceGetOrderProductDetailbyIdFailed = 1764,
        ServiceGetOrderProductDetailCountFailed = 1765,
        ServiceDeleteOrderProductFailed = 1766,
        ServiceGetProfessionalSearchResultFailed = 1767,
        ServiceGetProfessionalResultCountFailed = 1768,
        BusinessGetProfessionalSearchResultFailed = 1769,
        BusinessGetProfessionalResultCountFailed = 1770,
        BusinessSearchProfessionalOrderHistoryFailed = 1771,
        BusinessSearchProfessionalOrderHistoryCountFailed = 1772,
        BusinessCanceleProfessionalOrderFailed = 1773,
        BusinessSearchAttendeeTicketDetailsFailed = 1774,
        BusinessSearchAttendeeForTicketFailed = 1775,
        BusinessSearchAttendeeForTicketCountFailed = 1776,
        BusinessGetGlobalAttendeesFailed = 1777,
        BusinessGetGlobalAttendeesCountFailed = 1778,
        BusinessSaveGlobalAttendeesFailed = 1779,
        BusinessGetSelectedGlobalAttendeesFailed = 1780,
        BusinessCheckTheAttendeeExistsFailed = 1781,
        ServiceSearchProfessionalOrderHistoryFailed = 1782,
        ServiceSearchProfessionalOrderHistoryCountFailed = 1783,
        ServiceCanceleProfessionalOrderFailed = 1784,
        ServiceSearchAttendeeTicketDetailsFailed = 1785,
        ServiceSearchAttendeeForTicketFailed = 1786,
        ServiceSearchAttendeeForTicketCountFailed = 1787,
        ServiceGetGlobalAttendeesFailed = 1788,
        ServiceGetGlobalAttendeesCountFailed = 1789,
        ServiceSaveGlobalAttendeesFailed = 1790,
        ServiceGetSelectedGlobalAttendeesFailed = 1791,
        ServiceCheckTheAttendeeExistsFailed = 1792,
        ControllerProductSearchFailed = 1793,
        ControllerAttendeesFailed = 1794,
        ControllerSearchAttendeesFailed = 1795,
        ControllerGetAttendeeListFailed = 1796,
        ControllerSaveGlobalAttendeesFailed = 1797,
        ControllerProfessionalOrderHistorySearchFailed = 1798,
        ControllerSearchProfessionalOrderHistoryFailed = 1799,
        ControllerConferenceSelectionPopupFailed = 1820,
        ControllerAttendanceTicketFailed = 1821,
        ControllerSearchAttendanceTicketFailed = 1822,
        ControllerCheckTheAttendeeExistsFailed = 1823,
        BusinessUpdateOrderStatusFailed = 1824,
        BusinessCancelOrderFailed = 1825,
        BusinessGetOrderHeadingFailed = 1826,
        BusinessGetOriginalOrderDetailCountFailed = 1827,
        BusinessGetProductTypeListMethodFailed = 1828,
        BusinessGetProductTypeListCountFailed = 1829,
        BusinessGetProductTypesFailed = 1830,
        ServiceCancelOrderFailed = 1831,
        ServiceGetOrderHeadingFailed = 1832,
        ServiceGetOriginalOrderDetailCountFailed = 1833,
        ServiceGetOrderDetailsFailed = 1834,
        ServiceGetProductTypeListFailed = 1835,
        ServiceGetProductTypesFailed = 1836,
        ServiceGetProductTypeListCountFailed = 1837,
        ServiceUpdateOrderStatusFailed = 1838,
        ControllerProfessionalFailled = 1839,
        ControllerSearchProfessionalFailled = 1840,
        ControllerGetProductListFailled = 1841,
        ControllerOrderLevelDetailsSummaryFailled = 1842,
        ControllerChangeOrderStatusFailled = 1843,
        ControllerEmptyOrderFailled = 1844,
        ControllerSearchOrderLevelDetailsFailled = 1845,
        ControllerSearchOrderFailled = 1846,
        ControllerOriginalOrderFailled = 1847,
        ControlleOriginalOrderDetailsFailled = 1848,
        ControllerOrderProductDetailFailled = 1849,
        ControllerAddOrderProductFailed = 1890,
        ControllerEditOrderProductFailed = 1891,
        ControllerSaveOrderProductDetailsFailed = 1892,
        BusinessGetOrderProductDetailsFailed = 1893,
        BusinessAddOrderProductFailed = 1894,
        BusinessSaveOrderProductDetailsFailed = 1895,
        ServiceGetOrderProductDetailsFailed = 1896,
        ServiceAddOrderProductFailed = 1897,
        ServiceSaveOrderProductDetailsFailed = 1898,
        ComponentGetOrderByCartSessionIdFailed = 1899,
        ComponentUpdateOrderTypeByOrderId = 1900,
        ServiceGetStatesFailed = 1901,
        ServiceGetLocationsFailed = 1902,

        ServiceGetAttendeeForLineItemFailed = 1943,
        ServiceRemoveAttendeeFromAttendeeListFailed = 1944,
        ServiceGetOrderProductFailed = 1945,
        ServiceDeleteGlobalAttendeeListFailed = 1946,
        ServiceInsertToLiventEventOrderAtendeeFailed = 1947,
        ServiceIsProductExistsForOrderFailed = 1948,
        ServiceGetConferenceScheduleDetailsFailed = 1949,
        ServiceGetCombinationDescriptionFailed = 1950,
        ServiceNotifyOrderPurchaseFailed = 1951,
        ServiceGetLiveEventOrderLineItemIdForCartFailed = 1952,
        ServiceGetOriginalOrderHeadingFailed = 1953,
        ServiceApplyPromoCodeForOrderFailed = 1954,
        ServiceUpdateLiveEventOrderForCartFailed = 1955,
        ServiceGetOriginalOrderDetailsFailed = 1956,
        ServiceCancelProductFailed = 1957,
        ServiceValidateAttendeesFailed = 1958,
        ComponentGetAttendeeForLineItemFailed = 1959,
        ComponentRemoveAttendeeFromAttendeeListFailed = 1960,
        ComponentGetOrderProductFailed = 1961,
        ComponentDeleteGlobalAttendeeListFailed = 1962,
        ComponentInsertToLiventEventOrderAtendeeFailed = 1963,
        ComponentIsProductExistsForOrderFailed = 1964,
        ComponentGetConferenceScheduleDetailsFailed = 1965,
        ComponentGetCombinationDescriptionFailed = 1966,
        ComponentGetLiveEventOrderLineItemIdForCartFailed = 1967,
        ComponentGetOriginalOrderHeadingFailed = 1968,
        ComponentApplyPromoCodeForOrderFailed = 1969,
        ComponentGetOriginalOrderDetailsFailed = 1970,
        ComponentValidateAttendeesFailed = 1971,
        ServiceGetOriginalOrderProductDetailsFailed = 1972,
        ServiceGetLiveEventOrderStatusFailed = 1973,








        #endregion

        // Live Event Product Setup 1800 - 1850
        #region Live Event ProductSetup
        LiveEventControllerProductSetupFailed = 1801,
        LiveEventControllerProductSetupEditFailed = 1802,
        LiveEventControllerSearchProductsFailed = 1803,
        LiveEventControllerUpdateProductDetailsFailed = 1804,

        LiveEventServiceGetProductSetupPageDetailsFailed = 1805,
        LiveEventServiceSearchProductsFailed = 1806,
        LiveEventServiceGetProductDetailsFailed = 1807,
        LiveEventServiceUpdateProductDetailsFailed = 1808,

        LiveEventComponentGetProductSetupPageDetailsFailed = 1809,
        LiveEventComponentSearchProductsFailed = 1810,
        LiveEventComponentSearchProductsCountFailed = 1811,
        LiveEventComponentGetProductDetailsFailed = 1812,
        LiveEventComponentUpdateProductDetailsFailed = 1813,
        LiveEventComponentGetProductDetailsForLiveEventFailed = 1814,
        ProductMetadataCancelLiveEventOrderFailed = 1815,

        #endregion

        // Live Event Agenda Schedule 1850 -1875
        CourseMetadataServiceDeleteSeminarAgendaTopicFailed = 1851,
        CourseMetadataServiceSynchronizeAgendaFailed = 1852,
        AgendaControlHelperDeleteSeminarAgendaTopicFailed = 1853,
        CourseMetadataComponentDeleteScheduleAgendaFailed = 1854,
        CourseMetadataComponentUpdateScheduleAgendaFailed = 1855,
        CourseMetadataComponentGetSeminarSchedulesFailed = 1856,
        CourseMetadataComponentDeleteSeminarAgendaTopicFailed = 1857,
        CourseMetadataComponentIsAgendaUnderwayFailed = 1858,
        CourseMetadataComponentGetScheduleTimeDetailsFailed = 1859,

        // Live Event Schedule Istructor 1875 - 1900
        LiveEventScheduleInstructorDeleteInstructorSuccess = 1875,
        LiveEventScheduleInstructorDeleteInstructorFailed = 1876,
        LiveEventScheduleInstructorAddInstructorSuccess = 1877,
        LiveEventScheduleInstructorAddInstructorFailed = 1878,
        LiveEventScheduleInstructorAddInstructorOnAttendeesFailed = 1879,
        LiveEventScheduleInstructorAddInstructorOnDirectDepositFailed = 1880,
        // Live Event SocietySetup 2200 - 2250
        #region Live Event SocietySetup

        LiveEventControllerSearchSocietiesFailed = 2200,
        LiveEventControllerSocietyUpdateFailed = 2201,
        LiveEventControllerDeleteSocietyFailed = 2202,

        LiveEventComponentGetSocietyPageDetailsFailed = 2220,
        LiveEventComponentSocietySetupEditFailed = 2221,
        LiveEventComponentGetSocietyFailed = 2222,
        LiveEventComponentUpdateSocietyFailed = 2223,
        LiveEventComponentDeleteSocietiesFailed = 2224,
        LiveEventComponentSocietySearchCount = 2225,
        LiveEventComponentSocietyDetailsCountFailed = 2226,

        LiveEventServiceGetSocietyPageDetailsFailed = 2230,
        LiveEventServiceGetSocietyFailed = 2231,
        LiveEventServiceUpdateSocietyFailed = 2232,
        LiveEventServiceDeleteSocietiesFailed = 2233,



        #endregion


        //LiveEvent Location Setup 1901-2000
        LiveEventComponentSearchLocationsFailed = 1901,
        LiveEventComponentGetLocationPageDetailsFailed = 1902,
        LiveEventComponentSearchLocationCountFailed = 1903,
        LiveEventComponentGetLocationSetupHotelsFailed = 1904,
        LiveEventComponentSearchHotelCountFailed = 1905,
        LiveEventComponentGetHotelDetailsFailed = 1906,
        LiveEventComponentUpdateLocationDetailsFailed = 1907,
        LiveEventComponentUpdateHotelDetailsFailed = 1908,
        LiveEventComponentInsertLocationDetailsFailed = 1909,
        LiveEventComponentInsertHotelDetailsFailed = 1910,
        LiveEventComponentDeleteHotelDetailsFailed = 1911,
        LiveEventComponentDeleteLocationDetailsFailed = 1912,
        LiveEventComponentGenerateCousreInstanceAddressFailed = 1920,


        LiveEventServiceGetLocationPageDetailsFailed = 1913,
        LiveEventServiceSearchLocationsFailed = 1914,
        LiveEventServiceGetLocationSetupHotelsFailed = 1915,
        LiveEventServiceGetHotelDetailsFailed = 1916,
        LiveEventServiceUpdateLocationDetailsFailed = 1917,
        LiveEventServiceUpdateHotelDetailsFailed = 1918,
        LiveEventServiceDeleteLocationDetailsFailed = 1919,
        LiveEventServiceGenerateCousreInstanceAddressFailed = 1920,
        LiveEventServiceSearchLocationCountFailed = 1921,
        LiveEventServiceSearchHotelCountFailed = 1922,
        LiveEventServiceSaveLocationDetailsFailed = 1923,
        LiveEventServiceSaveHotelDetailsFailed = 1924,
        LiveEventServiceDeleteHotelDetailsFailed = 1925,

        SaveLiveEventLocationDetailsFailed = 1926,
        SaveLiveEventLocationDetailsSuccessfull = 1927,
        DeleteLiveEventLocationDetailsFailed = 1928,
        DeleteLiveEventLocationDetailsSuccessfull = 1929,
        DeleteLiveEventHotelDetailsFailed = 1930,
        DeleteLiveEventHotelDetailsSuccessfull = 1931,

        SaveLiveEventLocationDetailsHeader = 1932,
        DeleteLiveEventHotelDetailsHeader = 1933,
        DeleteLiveEventLocationDetailsHeader = 1934,

        RequiredComponentSynchronizeCourseInstanceAddressFailed = 1935,
        RequiredServiceSynchronizeCourseInstanceAddressFailed = 1936,

        RequiredComponentDeleteCourseInstanceAddressFailed = 1937,
        RequiredComponentInsertCourseInstanceAddressFailed = 1938,
        RequiredComponentSelectCourseInstanceAddressFailed = 1939,
        RequiredComponentSynchronizeTimeZoneInCourseInstanceFailed = 1940,
        RequiredComponentGetCourseInstanceForAddressSynchronizationFailed = 1941,
        RequiredComponentGetCourseInstanceFailed = 1942,
        RequiredComponentIsCourseInstanceHasDirectDepositedProfessional = 1974,


        //Conference setup 2251-2270

        LiveEventServiceDeleteConferenceFailed = 2251,
        LiveEventComponentDeleteConferenceFailed = 2252,

        //end conference setup


        //Course Metadata- Schedule 2001-2050
        CourseMetadataControllerScheduleFailed = 2001,
        CourseMetadataControllerSearchSchedulesFailed = 2002,
        CourseMetadataControllerScheduleDetailsFailed = 2003,
        CourseMetadataControllerSearchScheduleDaysFailed = 2004,
        CourseMetadataControllerUpdateScheduleDayFailed = 2005,
        CourseMetadataControllerDeleteScheduleDayFailed = 2006,
        CourseMetadataControllerUpdateScheduleFailed = 2007,


        CourseMetadataServiceGetSchedulePageDetailsFailed = 2008,
        CourseMetadataServiceSearchSchedulesFailed = 2009,
        CourseMetadataServiceGetScheduleDetailsPageDetailsFailed = 2010,
        CourseMetadataServiceUpdateScheduleFailed = 2011,
        CourseMetadataServiceSynchronizeCourseInstanceAddressFailed = 2012,

        //Course Metadata- Schedule 2001-2050 END

        //Live Event Attendance Managment: Start
        LiveEventComponentSearchAttendanceManagementLiveEventsFailed = 2013,
        ComponentSearchAttendanceManagementLiveEventsCountFailed = 2014,
        LiveEventControllerLiveEventAttendanceTimeEntryCalled = 2015,
        LiveEventComponentSearchRegistrantsTimeEntryFailed = 2017,
        LiveEventComponentSearchRegistrantsTimeEntryCountFailed = 2018,
        LiveEventServiceSearchAttandanceManagementLiveEventsFailed = 2019,
        LiveEventServiceSearchLiveEventRegistrantFailed = 2020,
        LiveEventControllerLiveEventRegistrantSearchFailed = 2021,
        LiveEventControllerAttendanceManagementFailed = 2022,
        LiveEventControllerSaveTimeEntryDetailsFailed = 2023,
        LiveEvnetComponentSaveTimeEntryDetailsFailed = 2024,
        LiveEventServiceSaveTimeEntryDetailsFailed = 2025,
        LiveEvnetComponentDeleteScheduleTimeEntryFailed = 2026,
        LiveEventControllerRegistrantsFailed = 2027,
        LiveEventServiceGetRegistrantsProductDeatilsFailed = 2028,
        LiveEventComponentSearchRegistrantFailed = 2029,
        LiveEventComponentSearchRegistrantCountFailed = 2030,
        LiveEventServiceSearchRegistrantFailed = 2031,
        LiveEventControllerSearchRegistrantsFailed = 2032,
        LiveEventComponentGetProfessionalByIdFailed = 2033,
        LiveEventControllerProfessionalTimeEntryDetailsFailed = 2035,
        LiveEventcontrollerSaveProfessionalTimeEntryDetailsFailed = 2036,
        LiveEventControllerToggleStatusFailed = 2037,
        LiveEventServiceChangeAttendanceStatusFailed = 2038,
        LiveEventComponentToggleStatusByProfessionalFailed = 2039,
        LiveEventComponentDeleteAttendeeTimeEntryFailed = 2040,
        LiveEventComponentGetConcurrentSchedulesFailed = 2041,
        LiveEventServiceGetConcurrentScheduleFailed = 2042,
        LiveEventControllerSwapProfessionalsFailed = 2043,
        LiveEventComponentSwapProfissionalScheduleFailed = 2044,
        LiveEventControllerSaveProfessionalScheduleFailed = 2045,
        LiveEventServiceSaveProfessionalScheduleFailed = 2046,
        LiveEventComponentGetConferenceIdByScheduleIdFailed = 2047,
        LiveEventServiceGetAttendanceManagementPageDataFailed = 2048,
        SearchAttendanceManagementLiveEventsFailed = 2049,
        LiveEventServiceGetTimeEntryDetailsFailed = 2050,
        LiveEventControllerLiveEventSendCertificateEmailFailed = 2051,
        LiveEventServiceSendCertificateEmailFailed = 2052,
        ServiceAgentSendCertificateEmailFailed = 2053,
        LiveEventComponentUpdateIsFullAttendanceFailed = 2054,
        LiveEventComponentGetCitiesForLiveEventFailed = 2055,
        LiveEventComponentSearchScheduleTopicsFailed = 2056,
        LiveEventServiceGetProfessionalTopicAttendanceFailed = 2057,
        LiveEventComponentGetProfessionalsAttendanceFailed = 2058,
        LiveEventControllerDirectDepositFailed = 2059,
        LiveEventControllerViewCertificateFailed = 2060,
        LiveEventControllerSendAggregateEmailsFailed = 2061,
        LiveEventControllerGetAgendaDetailsFailed = 2062,
        LiveEventServiceGetAllSwappingProfessionalsFailed = 2063,
        LiveEventComponentGetAllSwappingProfessionalFailed = 2064,
        LiveEventServiceGetRegisteredLiveEventSearchResultFailed = 2065,
        LiveEventServiceGetTimeEntryDetailsForProfissionalFailed = 2066,
        LiveEventServiceGetRosterFailed = 2067,
        LiveEventComponentGetCourseDocumentFileNameFailed = 2068,
        //Live Event Attendance Managment:END

        CourseCatalogServiceCourseSearchFailed = 2016,


        //Defect fix for #83375 :Pilot Testing: Add Autorespone Message when user registers to be a Pilot Tester
        //Start User Registration Fail message for send email attachment for pilot tester 1741~
        ServiceAttachedFileDataFailed = 1741,
        //End of User Registration Fail message for send email email for pilot tester 1741~
        Promo,

        #region Conference Setup 2407 - 2435
        LiveEventControllerConferenceSetupFailed = 2407,
        LiveEventControllerSearchConferencesFailed = 2408,
        LiveEventControllerConferenceSetupAddFailed = 2409,
        LiveEventControllerConferenceSetupEditFailed = 2410,
        LiveEventControllerDeleteConferenceFailed = 2411,
        LiveEventControllerConferenceSetupUpdateFailed = 2412,
        LiveEventServiceGetConferenceSetupPageDetailsFailed = 2413,
        LiveEventServiceSearchConferencesFailed = 2414,
        LiveEventServiceSearchConferencesRecordCountFailed = 2415,
        LiveEventServiceGetConferenceDetailsFailed = 2416,
        LiveEventServiceUpdateConferenceDetailsFailed = 2417,
        LiveEventComponentSearchConferencesFailed = 2418,
        LiveEventComponentSearchConferencesRecordCountFailed = 2419,
        LiveEventComponentGetBrandListForConferenceFailed = 2420,
        LiveEventComponentGetLocationListForConferenceFailed = 2421,
        LiveEventComponentGetHotelListForConferenceFailed = 2422,
        LiveEventComponentInsertConferenceFailed = 2423,
        LiveEventComponentEditConferenceFailed = 2424,
        LiveEventComponentInsertLiveEventMetaDataFailed = 2425,
        LiveEventComponentEditLiveEventMetaDataFailed = 2426,
        LiveEventComponentInsertLiveEventInstantDataFailed = 2427,
        LiveEventComponentEditLiveEventInstantDataFailed = 2428,
        LiveEventComponentGetNasbaLearningLevelListFailed = 2429,
        LiveEventComponentGetConferenceDetailsFailed = 2430,
        LiveEventComponentIsAssocitedProductIdExistFailed = 2431,
        LiveEventComponentIsLiveEventOrderLineItemExistFailed = 2432,
        LiveEventControllerSaveConferenceCategoryFailed = 2433,
        LiveEventControllerSearchCategoriesFailed = 2434,
        LiveEventControllerDeleteConferenceCategoryFailed = 2435,
        #endregion

        #region Seminar and Optional Seminars 2436 - 2465 / 2536 - 2550
        LiveEventControllerSeminarsFailed = 2436,
        LiveEventControllerSearchAssociatedSeminarsFailed = 2437,
        LiveEventControllerGetSeminarPageDetailsFailed = 2438,
        LiveEventControllerSearchSeminarsFailed = 2439,
        LiveEventControllerAddSeminarsToConferenceFailed = 2440,
        LiveEventControllerOptionalSeminarsFailed = 2441,
        LiveEventControllerSearchAssociatedOptionalSeminarsFailed = 2442,
        LiveEventControllerGetOptionalSeminarPageDetailsFailed = 2443,
        LiveEventControllerSearchOptionalSeminarsFailed = 2444,
        LiveEventControllerExcludeSeminarFailed = 2445,
        LiveEventServiceSearchAssociatedSeminarsFailed = 2446,
        LiveEventServiceGetAddSeminarsPageDataFailed = 2447,
        LiveEventServiceSearchSeminarsFailed = 2448,
        LiveEventServiceAddSeminarsToConferenceFailed = 2449,
        LiveEventServiceSearchAssociatedOptionalSeminarsFailed = 2450,
        LiveEventServiceExcludeSeminarFailed = 2451,
        LiveEventComponentSearchAssociateSeminarsFailed = 2452,
        LiveEventComponentSearchAssociateSeminarsRecordCountFailed = 2453,
        LiveEventComponentSearchSeminarsFailed = 2454,
        LiveEventComponentSearchSeminarsRecordCountFailed = 2455,
        LiveEventComponentGetStateListForSeminarFailed = 2456,
        LiveEventComponentAddSeminarsToConferenceFailed = 2457,
        LiveEventComponentSearchAssociatedOptionalSeminarsFailed = 2458,
        LiveEventComponentSearchAssociatedOptionalSeminarsRecordCountFailed = 2459,
        LiveEventComponentSearchOptionalSeminarsFailed = 2460,
        LiveEventComponentSearchOptionalSeminarsRecordCountFailed = 2461,
        LiveEventComponentUpdateCourseInstanceConferenceInstanceIdFailed = 2462,
        LiveEventComponentIsAssociateProductIdExistFailed = 2464,
        LiveEventComponentDeleteAssociateProductFailed = 2465,
        LiveEventControllerGetOptionalSeminarsForConferenceFailed = 2536,
        LiveEventServiceSearchCategoriesFailed = 2537,
        LiveEventServiceDeleteCourseNasbaCreditsFailed = 2538,
        LiveEventComponentGetConferenceCategoriesFailed = 2539,
        LiveEventComponentInsertUpdateCourseNasbaCreditsFailed = 2540,
        LiveEventComponentDeleteCourseNasbaCreditsFailed = 2541,
        LiveEventServiceSearchOptionalSeminarsFailed = 2542,

        #endregion

        #region Combinations 2466 - 2490
        LiveEventControllerGetCombinationDetailsFailed = 2466,
        LiveEventControllerSearchScheduleCombinationsFailed = 2467,
        LiveEventControllerGetScheduleCombinationsFailed = 2468,
        LiveEventControllerSaveScheduleCombinationsFailed = 2469,
        LiveEventControllerDeleteCombinationFailed = 2470,
        LiveEventServiceSearchCombinationsFailed = 2471,
        LiveEventServiceGetScheduleTimeSlotsFailed = 2472,
        LiveEventServiceSaveScheduleCombinationsFailed = 2473,
        LiveEventServiceGetCombinationDataFailed = 2474,
        LiveEventServiceDeleteScheduleCombinationFailed = 2475,
        LiveEventComponentSearchCombinationsFailed = 2476,
        LiveEventComponentSearchCombinationsRecordCountFailed = 2477,
        LiveEventComponentSearchSchedulesForConferenceFailed = 2478,
        LiveEventComponentGetProductIdsForCombinationFailed = 2479,
        LiveEventComponentSaveLiveEventSeminarCombinationFailed = 2480,
        LiveEventComponentSaveLiveEventSeminarCombinationDetailFailed = 2481,
        LiveEventComponentDeleteLiveEventSeminarCombinationDetailFailed = 2482,
        LiveEventComponentSearchScheduleCombinationFailed = 2483,
        LiveEventComponentDeleteLiveEventSeminarCombinationFailed = 2484,
        LiveEventComponentIsLiveEventProductCodeExistFailed = 2485,

        #endregion

        #region Schedule (2491 - 2535 and 2751-2800)
        ScheduleControllerHelpersUpdateAccreditationFailed = 2491,
        ScheduleControllerHelpersSearchScheduleTopicsFailed = 2492,
        ScheduleControllerHelpersUpdateScheduleTopicFailed = 2493,
        ScheduleControllerHelpersDeleteScheduleTopicFailed = 2494,
        ScheduleControllerHelpersSelectFacilitiesFailed = 2495,
        ScheduleControllerHelpersDeleteScheduleFailed = 2496,
        CourseMetadataServiceSearchScheduleDaysFailed = 2497,
        CourseMetadataServiceUpdateLiveEventScheduleDayFailed = 2498,
        CourseMetadataServiceSearchScheduleTopicsFailed = 2499,
        CourseMetadataServiceUpdateScheduleTopicFailed = 2500,
        CourseMetadataServiceDeleteScheduleTopicFailed = 2501,
        CourseMetadataServiceToggleAccreditationFailed = 2502,
        CourseMetadataServiceGetFacilityListByLocationFailed = 2503,
        CourseMetadataServiceDeleteScheduleFailed = 2504,
        CourseMetadataComponentGetSchedulePageDetailsFailed = 2505,
        CourseMetadataComponentSearchSchedulesFailed = 2506,
        CourseMetadataComponentSearchSchedulesRecordCountFailed = 2507,
        CourseMetadataComponentGetScheduleDetailsPageDetailsFailed = 2508,
        CourseMetadataComponentInsertUpdateLiveEventProductFailed = 2509,
        CourseMetadataComponentInsertUpdateCourseInstanceFailed = 2510,
        CourseMetadataComponentGetFacilityLocationDataFailed = 2511,
        CourseMetadataComponentGetCourseInstanceAddressByIdRecordCountFailed = 2512,
        CourseMetadataComponentInsertCourseInstanceAddressFailed = 2513,
        CourseMetadataComponentUpdateCourseInstanceAddressFailed = 2514,
        CourseMetadataComponentInsertUpdateLiveEventScheduleDayFailed = 2515,
        CourseMetadataComponentUpdateLiveEventScheduleDayFailed = 2516,
        CourseMetadataComponentSearchScheduleDaysFailed = 2517,
        CourseMetadataComponentSearchScheduleDaysRecordCountFailed = 2518,
        CourseMetadataComponentSynchronizeCourseInstanceDaysFailed = 2519,
        CourseMetadataComponentSearchScheduleTopicsFailed = 2520,
        CourseMetadataComponentSearchScheduleTopicsRecordCountFailed = 2521,
        CourseMetadataComponentSetCourseInstanceScheduleTimelineFailed = 2522,
        CourseMetadataComponentDeleteScheduleTopicFailed = 2523,
        CourseMetadataComponentSetAgendaSynchronizeValueFailed = 2524,
        CourseMetadataComponentSetAgendaSynchronizeValueToFalseFailed = 2525,
        CourseMetadataComponentToggleAccreditationFailed = 2526,
        CourseMetadataComponentCopyAccreditationGloballyFailed = 2527,
        CourseMetadataComponentGetFacilityListByLocationFailed = 2528,
        CourseMetadataComponentDeleteCourseInstanceFailed = 2529,
        CourseMetadataComponentDeleteLiveEventScheduleResourceFailed = 2530,
        CourseMetadataComponentGetAttendeeCountForCourseInstaceIdFailed = 2531,
        CourseMetadataComponentGetConferenceIdForScheduleFailed = 2532,
        CourseMetadataComponentInsertUpdateCourseInstanceScheduleFailed = 2533,

        CourseMetadataComponentGetTimeZoneByLocationIdFailed = 2534,
        CourseMetadataComponentGetCourseIdByMetadadataIdFailed = 2535,
        CourseMetadataComponentGetCodeByMetadadataIdFailed = 2751,
        CourseMetadataComponentCourseGroupSearchFailed = 2752,
        CourseMetadataComponentGetLiveEventMediaFormatsFailed = 2753,

        CourseMetadataServiceCourseGroupSearchFailed = 2754,
        CourseMetadataServiceGetLiveEventMediaFormatsFailed = 2755,
        CourseMetadataServiceIsSchedulesExistFailed = 2756,
        //Webinar - Agenda
        CourseMetadataServiceGetPollingQuestionsAndResponsesRequiredFailed = 2757,


        //Webinar - Agenda- component
        CourseMetadataComponentGetPollingQuestionsAndResponsesRequiredFailed = 2758,
        CourseMetadataComponentIsInstanceEvaluatedFailed = 2759,
        CourseMetadataServiceIsInstanceEvaluatedFailed = 2760,
        #endregion

        #region Live Event Barcode: 2551 - 2650

        LiveEventControllerGetBarcodeImageFailed = 2551,
        LiveEventServiceGetBarcodeForAttendeeFailed = 2552,
        LiveEventComponentGetBarcodeForAttendeeFailed = 2553,
        LiveEventComponentSaveBarcodeTimeEntryFailed = 2554,
        LiveEventControllerBarcodeAttendanceCaptureFailed = 2555,
        LiveEventComponentSearchAttendeeTimeEntryDetailsFailed = 2556,
        LiveEventControllerBarcodeLiveEventLocationFailed = 2557,
        LiveEventControllerGetFacilitiesFailed = 2558,
        LiveEventServiceGetBarcodeLiveEventLocationPageDataFailed = 2559,
        LiveEventServiceGetFacilitiesFailed = 2560,
        LiveEventComponentGetLiveEventCitiesFailed = 2561,
        LiveEventComponentGetLiveEventFacilitiesFailed = 2562,
        LiveEventServiceGetBarcodeLiveEventSeminarsFailed = 2563,
        LiveEventComponentGetTimeZoneFailed = 2564,
        LiveEventComponentGetBarCodeLiveEventSeminarsFailed = 2565,
        LiveEventComponentGetScannedAttendeeDetailsFailed = 2566,
        LiveEventComponentSearchAttendeeTimeEntryDetailsCountFailed = 2567,
        LiveEventServiceSaveAndRetrieveScannedAttendeeInformationFailed = 2568,
        LiveEventServiceSearchBarcodeAttendeeInformationFailed = 2569,
        LiveEventServiceSwapAndSaveBarcodeProfessionalFailed = 2570,
        LiveEventServiceSaveBulkOperationFailed = 2571,
        LiveEventComponentGetBarcodeTimeEntryProfessionalBySchedulesFailed = 2572,
        LiveEventComponentGetBarcodeTimeEnteredScheduleFailed = 2573,
        LiveEventComponentGetBarcodeOrderCompletedProfessionalBySchedulesFailed = 2574,
        LiveEventServiceBarcodeSaveCheckInAllFailed = 2575,
        LiveEventControllerSearchAttendeeTimeEntryFailed = 2576,
        LiveEventControllerSaveAttendeeTimeEntryFailed = 2577,
        LiveEventControllerScanBarcodeFailed = 2578,
        LiveEventControllerSearchBarcodeAttendeeDetailsFailed = 2579,
        LiveEventControllerProcessBulkOperationFailed = 2580,
        LiveEventControllerSaveBulkOperationFailed = 2581,
        LiveEventControllerSaveSeminarInformationFailed = 2582,
        LiveEventControllerSaveCheckInAllBulkOperationFailed = 2583,
        LiveEventComponentGetMaximumNumberOfAttendeeByScheduleFailed = 2584,
        LiveEventComponentGetProfessionalConferenceSchedulesFailed = 2585,
        LiveEventServiceSearchBarcodeAttendeeDetailsFailed = 2586,
        LiveEventComponentSearchBarcodeAttendeeTimeEntryDetailsFailed = 2587,
        LiveEventComponentSearchBarcodeAttendeeTimeEntryDetailsCountFailed = 2588,
        LiveEventComponentGetBarcodeRecordsCountByCourseInstanceIdFailed = 2589,
        LiveEventControllerSearchBarcodeAttendeeDetailsAttendanceManagmentFailed = 2590,
        LiveEventComponentGetFacilityByIdFailed = 2591,
        LiveEventComponentGetScannedAttendeeScheduleDetailsFailed = 2592,
        LiveEventComponentGetBarcodeProfessionalTimeEntryDetailsFailed = 2593,
        LiveEventComponentGetBarcodeProfessionalTimeEntryDetailsCountFailed = 2594,
        LiveEventComponentDeleteBarcodeProfessionalTimeEntryDetailFailed = 2595,
        LiveEventComponentSaveBarcodeProfessionalTimeEntryDetailFailed = 2596,
        LiveEventComponentGetSchedulesTopicsFailed = 2597,
        LiveEventComponentGetBulkOperationDataFailed = 2598,
        LiveEventComponentGetBarcodeProfessionalTimeEntryDetailsBySchedulesFailed = 2599,
        LiveEventComponentGetLiveEventScheduleDayFailed = 2600,
        LiveEventComponentGetAttendanceLocationInfoByCourseInstanceIdFailed = 2601,
        LiveEventComponentGetAttendeeTopicDetailsFailed = 2602,
        LiveEventComponentGetSchedulesTitleFailed = 2603,
        LiveEventServiceGetBarcodeProfessionalTimeEntryDetailsFailed = 2604,
        LiveEventServiceDeleteBarcodeProfessionalTimeEntryDetailsFailed = 2605,
        LiveEventServiceSaveBarcodeProfessionalTimeEntryDetailsFailed = 2606,
        LiveEventServiceGetBulkOperationSchedulesFailed = 2607,
        LiveEventServiceGetCheckInAllSchedulesFailed = 2608,
        LiveEventServiceSyncBarcodeRecordsFailed = 2609,
        LiveEventServiceGetScheduleLocationInfoFailed = 2610,
        LiveEventControllerBarcodeAttendanceManagementCaptureFailed = 2611,


        #endregion

        #region PilotTestTimingReport 2700 - 2750
        ControllerGetPdfTimingReportFailed = 2701,
        ControllerTimingReportInformationFailed = 2702,
        ServiceGetTimingReportFailed = 2703,
        BussinessGetPilotTestTimingReportDataFailed = 2704,
        BussinessGetTimingReportPilotTestFailed = 2705,
        #endregion

        #region Deloitee Integration 2800-2850
        BusinessUpdateEmployeeDetailsForDeloitteProfessionalsFailed = 2801,
        ServiceEmployeeDetailFailed = 2802,
        ServiceUpdateEmployeeDetailsForDeloitteProfessionalsFailed = 2803,

        #endregion

        #region Assoiciate Documents 2851-2860
        ProfessionalServiceGetAttachmentInfoFailed = 2851,
        ProfessionalServiceGetAttachmentAssociationInfoFailed = 2852,
        ProfessionalComponentGetAttachmentInfoFailed = 2853,
        ProfessionalComponentGetAttachmentAssociationInfoFailed = 2854,
        #endregion

        #region Cloud Storage 2861-2870
        CloudStorageServiceListBlobsFailed = 2861,
        CloudStorageServiceUploadBlobsFailed = 2862,
        CloudStorageServiceDownloadBlobFailed = 2863,
        CloudStorageServiceDeleteBlobFailed = 2864,
        CloudStorageServiceRenameBlobFailed = 2865,
        CloudStorageServiceAssociateDocumentsFailed = 2866,
        #endregion

        #region Bulk Import 2871-2885
        LiveEventControllerLiveSeminarImportFailed = 2871,
        LiveEventControllerImportLiveSeminarDataFailed = 2872,
        LiveEventControllerLiveEventsLogViewFailed = 2873,
        LiveEventServiceRetrieveLiveSeminarLogsFailed = 2874,
        LiveEventServiceRetrieveLiveEventLogCountFailed = 2875,
        LiveEventServiceLiveEventLogFilterValuesFailed = 2876,
        LiveEventServiceImportLiveSeminarDataFailed = 2877,
        LiveEventComponentRetrieveLiveSeminarLogsFailed = 2878,
        WebinarComponentGetBulkImportReferenceDataFailed = 2879,
        LiveEventComponentGetAdvertisedCityAndFacilityFailed = 2880,
        #endregion

        #region Webinar Setup 3501- 3600
        LiveEventServiceSendWebinarDetailsMailFailed = 3501,
        LiveEventComponentGetWebinarAnswersFailed = 3502,
        LiveEventServiceGetWebinarAnswersFailed = 3503,
        LiveEventServiceSaveWebinarTimeEntryDetailsFailed = 3504,
        LiveEventComponentSaveWebinarTimeEntryDetailsFailed = 3505,
        LiveEventComponentDeleteWebinarTimeEntryDetailsFailed = 3506,

        #endregion

        #region Shared 3601 - 3635
        SharedControllerNoteDetailsFailed = 3601,
        SharedControllerAddNoteFailed = 3602,
        SharedServiceGetNoteDetailsFailed = 3603,
        SharedServiceAddNoteFailed = 3604,
        SharedServiceAddProfessionalNotesFailed = 3605,
        SharedComponentGetNoteDetailsFailed = 3606,
        SharedComponentGetNoteDetailsRecordCountFailed = 3607,
        SharedComponentAddNoteFailed = 3608,
        SharedComponentGetNoteIdFailed = 3609,
        SharedComponentAddProfessionalNotesFailed = 3610,
        #endregion

        #region Comprehensive Bundles 3636 - 3836
        ComprehensiveBundleComponentGetBundleDefinitionsFailed = 3636,
        ComprehensiveBundleComponentGetCoursesFailed = 3637,
        ComprehensiveBundleComponentCourseSearchResultCountFailed = 3638,
        ComprehensiveBundleComponentGetCourseFlagTypeFailed = 3639,
        ComprehensiveBundleComponentGetBundleUnisonIdFailed = 3640,
        ComprehensiveBundleComponentGetProfessionalComprehensiveBundleOrderFailed = 3641,
        ComprehensiveBundleComponentSaveProfessionalBundleFailed = 3642,
        ComprehensiveBundleComponentGetBundleDefinitionByProfessionalFailed = 3643,
        ComprehensiveBundleComponentGetCourseInBundleFailed = 3644,
        ComprehensiveBundleComponentGetPromoCodesForDiscountProductFailed = 3645,
        ComprehensiveBundleComponentGetCpeHoursByProductFailed = 3646,
        ComprehensiveBundleComponentIsProductInBundleFailed = 3647,
        ComprehensiveBundleComponentGetProductTypeIdFailed = 3648,
        ComprehensiveBundleServiceGetBundleDefinitionsFailed = 3649,
        ComprehensiveBundleServiceGetBundleCoursesFailed = 3650,
        ComprehensiveBundleServiceGetEntitledCoursesFailed = 3651,
        ComprehensiveBundleServiceGetBundleUnisonIdFailed = 3652,
        ComprehensiveBundleServiceGetProfessionalBundleSubscriptionFailed = 3653,
        ComprehensiveBundleServiceRegisterBundleLiveEventFailed = 3654,
        ComprehensiveBundleServiceUnregisterBundleLiveEventFailed = 3655,
        ComprehensiveBundleServiceSaveProfessionalBundleFailed = 3656,
        ComprehensiveBundleServiceIsCourseInBundleByProfessionalFailed = 3657,
        ComprehensiveBundleServiceGetCpeHoursByProductFailed = 3658,
        ComprehensiveBundleServiceGetComprehensiveBundleProductCodesForProductFailed = 3659,
        ComprehensiveBundleServiceGetPromoCodesForDiscountProductFailed = 3660,
        CourseFinderNoRecordsMessage = 3661,
        #endregion

        #region Sales Report Process 3837 - 3840
        SalesReportProcessValidateReportRulesFailed = 3837,
        SalesReportProcessPreProcessFailed = 3838,
        #endregion

        #region IRS Bulk Import 3850-3900
        IrsControllerImportIrsBulkRegisterDataFailled = 3851,
        IrsServiceImportIrsBulkRegisterDataFailed = 3851,

        #endregion

        #region EarlyBird Price calculation process 3900-3930
        ProductPricingServiceStartFailled = 3901,
        ProductPricingServiceSetProductPriceFailled = 3902,
        ProductPricingServiceClearCacheFailled = 3903,
        ProductPricingServiceGetLogsFromDBFailld = 3904,
        ProductPricingServiceGetLogsCountFailld = 3905,

        #endregion

        #region ProductRetireService 3931-3940
        ProductRetireServiceFixedExpireDateTimerFailled = 3931,


        #endregion

        # region Package Management 3941-4250
        ControllerPackagesMetadataListFailed = 3941,
        ControllersaveAsPackageFailed = 3942,
        ControllersCreateNewPackageFailed = 3943,
        ControllersSavePackagePriorityListFailed = 3944,
        ControllersDeletePackageFailed = 3945,
        ControllersSaveGeneralDataFailed = 3946,
        ControllersGeneralDataFailed = 3947,
        ControllersEditPackageDataFailed = 3948,
        ControllersPreviewPackageDataFailed = 3949,
        ControllersGeneralFailed = 3950,
        ControllersGetGeneralDataFailed = 3951,
        ControllersProductsFailed = 3952,
        ControllersSaveProductsFailed = 3953,
        ControllersPromotionManagementFailed = 3954,
        ControllersSavePromoFailed = 3955,
        ControllersSaveCourseListQueryFailed = 3957,
        ControllersCourseListFailed = 3956,
        ControllersSearchQueryFailed = 3958,
        ControllersCourseListNewFailed = 3959,
        ControllersAddNewRuleFailed = 3960,
        ControllersChangeFieldFailed = 3961,
        ControllersDeleteRuleFailed = 3962,
        ControllersSaveRulesFailed = 3963,

        PackageComponentGetAllPackagesFailed = 3964,
        PackageComponentGetPackageDetailsByPackageCodeFailed = 3965,
        PackageComponentGetAllPackageDetailsFailed = 3966,
        PackageComponentGetDeltaCourseListFailed = 3967,
        PackageComponentGetNotesHistoryFailed = 3968,
        PackageComponentGetPackageDetailsByPackageCodesFailed = 3969,
        PackageComponentGetPackagesCountFailed = 3970,
        PackageComponentSearchCuasProductsByCplCodeFailed = 3971,
        PackageComponentSaveGeneralDataFailed = 3972,
        PackageComponentCreateNewPackageFailed = 3973,
        PackageComponentSavePromoRulesFailed = 3974,
        PackageComponentSaveSelectedProductsFailed = 3975,
        PackageComponentGetNonCPEProdctsListFailed = 3976,
        PackageComponentSearchQueryFailed = 3977,
        PackageComponentsaveAsPackageFailed = 3978,
        PackageComponentGetFieldFilterValuesFailed = 3979,


        PackageComponentGetOperatorFilterValuesFailed = 3980,
        PackageComponentGetPackageRulesByPackageCodeFailed = 3981,
        PackageComponentGetValueFilterValuesFailed = 3982,
        PackageComponentSaveRulesFailed = 3983,
        PackageComponentGetRuleByFieldIdFailed = 3984,
        PackageComponentAddNewRuleFailed = 3985,

        PackageServiceGetAllPackagesFailed = 3986,
        PackageServiceGetPackageDetailsByPackageCodeFailed = 3987,
        PackageServiceGetNonCPEProdctsListFailed = 3988,
        PackageServiceGetNonCPESelectedProductsListFailed = 3989,
        PackageServiceSaveSelectedProductsFailed = 3990,
        PackageServiceGetCAUSProductsListFailed = 3991,
        PackageServiceGetPromoCodeDetailsByPackageCodeFailed = 3992,
        PackageServiceValidatePromoFailed = 3993,
        PackageServiceSavePromoFailed = 3994,
        PackageServiceGetCourseListQueryFailed = 3995,
        PackageServiceSearchQueryFailed = 3996,
        PackageServiceGetbundlePriorityListFailed = 3997,
        PackageServiceCreateNewPackageFailed = 3998,
        PackageServiceSaveGeneralFailed = 3999,
        PackageServiceSavePackagePriorityListDetailsFailed = 4200,
        PackageServiceGetAllPackageFailed = 4201,
        PackageServiceGetDeltaCourseListFailed = 4202,
        PackageServiceGetCourseLsitFailed = 4203,
        PackageServiceGetNotesHistoryFailed = 4204,
        PackageServiceGetFieldFilterValuesFailed = 4205,
        PackageServiceGetOperatorFilterValuesFailed = 4206,
        PackageServiceGetValueFilterValuesFailed = 4207,
        PackageServiceGetPackageRulesByPackageCodeFailed = 4208,
        PackageServiceGetRuleByFieldIdFailed = 4209,
        PackageServicesaveAsPackageFailed = 4210,
        PackageServiceGetPackagesDataBySortQueryFailed = 4211,
        PackageServiceGetCourseListQuerysFailed = 4212
        #endregion


    }

    public enum QuickSearchType
    {
        None = 0,
        FieldOfStudy = 1,
        DeliveryFormat = 2,
        CPEBrands = 3
    }

    public enum AdvancedSearchListItemType
    {
        None = 0,
        FieldOfStudy = 1,
        DeliveryFormat = 2,
        Brands = 3,
        MediaFormat = 4,
        SpecializedDesignation = 5
    }

    public enum SpecializedDesignations
    {
        [Description("CFP   - Certified Financial Planner")]
        CFP = 0,
        [Description("CTEC  - California Tax Education Council")]
        CTEC = 1,
        [Description("EA    - IRS Enrolled Agent")]
        EA = 2,
        [Description("RTRP  - IRS Registered Tax Return Preparer")]
        RTRP = 3
    }

    public enum QuickSearchSubType
    {
        None = 0,
        Auditing = 1,
        Accounting = 2,
        Ethics = 3,
        Taxation = 4,
        Management = 5,
        PersonalDevelopment = 6,
        CounsultingServices = 7,
        SpecializedKnowledge = 8,
        InformationTechnology = 9,
        YellowBook = 10,
        InHouseTraining = 11,
        LiveSeminarsConferences = 12,
        OnlineLearningWebinars = 13,
        OnlineLearningSelfStudy = 14,
        SelfStudyPrintBased = 15,
        MicroMash = 16,
        PASSOnline = 17,
        GearUp = 18,
        BellLearning = 19,
        PPC = 20
    }

    public enum ExceptionPolicyId
    {
        None = 0,
        General = 1,
        Presentation = 2,
        Delivery = 3,
        Service = 4,
        Business = 5,
        Data = 6
    }

    public enum LogSource
    {
        Web,
        Integration,
        Business,
        Data
    }

    public enum ServiceLocation
    {
        None = 0,
        Local = 1,
        Remote = 2
    }

    public enum SearchType
    {
        None = 0,
        GetCourseDetails = 1,
        UpcomingWebinars = 2,
        EthicCourses = 3,
        GAOYellowBook = 4,
        NewCourses = 5
    }

    //public class GlobalEnums
    //{
    //    //public enum DBType
    //    //{
    //    //    SqlServer
    //    //}

    //}

    public enum ResourceSearchType
    {
        None = 0,
        LastName = 1,
        NickName = 2
    }

    /// <summary>
    /// Enumeration for Resource Record Status
    /// </summary>
    public enum ResourceRecordStatus
    {
        None = 0,
        InProgress = 1,
        Active = 2,
        Inactive = 3,
        Archived = 4,
        Deleted = 5
    }

    /// <summary>
    /// Get the Learning Library Id's  
    /// </summary>
    public enum LearningLibraryId
    {
        None = 0,
        MicroMash = 1,
        PASSOnline = 2,
        MicroMashPlus = 3,
        ReqwiredAccountingAuditingLibraryLevel1 = 4,
        ReqwiredAccountingAuditingLibraryLevel2 = 5,
        ReqwiredAccountingAuditingLibraryLevel3 = 6,
        ReqwiredIndividualTaxLibrary = 7,
        ReqwiredPassThroughEntitiesTaLibrary = 8,
        ReqwiredSmallBusinessTaxLibrary = 9,
        ReqwiredCorporateTaxLibrary = 10,
        ReqwiredEthicsLibrary = 12,
        ReqwiredAALibrary = 13,
        ReqwiredTaxLibrary = 14,
        ReqwiredYellowBookLibrary = 15,
        ReqwiredSoftSkillsLibrary = 16,
        ReqwiredMixedPracticeLibrary = 17,
        ParenteOnlineLearng = 18
    }

    /// <summary>
    /// Personal Information sorty by values
    /// </summary>
    public enum CommiunicationRecordSortValue
    {

        EnteredDate,
        UserID,
        Subject,
        NeverArchived,
        Default
    }

    public enum DeveloperMode
    {
        None = 0,
        Enabled = 1,
        Disabled = 0
    }

    /// <summary>
    /// Indicator for Success/Failure 
    /// </summary>
    public enum SuccessIndicator
    {
        Failed = 0,
        Succeeded = 1,
        Undefined = -1
    }

    /// <summary>
    /// Indicator for records status  
    /// </summary>
    public enum EntityStatus : int
    {
        None = 0,
        Active = 1,
        Inactive = 2
    }

    /// <summary>
    /// Indicator for Entity Action
    /// </summary>
    public enum EntityAction
    {
        None = 0,
        New = 1,
        Existing = 2
    }

    public enum SaveType
    {
        None = 0,
        Insert = 1,
        Update = 2

    }

    public enum SponsorPageProductType
    {
        None = 0,
        type1 = 1,
        type2 = 2

    }

    public enum SponsorMessages
    {
        None = 0,
        SponsorDetailsSuccessfullySaved = 2500,
        SponsorPageDetailsSuccessfullySaved = 2501,
        SponsorDetailsSuccessfullyDeleted = 2502,
        SponsorPageDetailsSuccessfullyDeleted = 2503,
        SponsorDetailsAlreadyInDatabaseError = 2504,
        SponsorAlreadyHasSponsorPageError = 2505,
        UnkonwnError = 2506,
        GlobalTextsSuccefullySaved = 2507,
        LandingPageDeleteConfirmation = 2508,
        SponsorImageDetailsSuccessfullySaved = 2509,
        SponsorImageDetailsSuccessfullyDeleted = 2510,
        FileNameAlreadyExists = 2511,
        SponsorImageDeleteConfirmation = 2512,
        GlobalImageDetailsSuccessfullySaved = 2513,
        GlobalImageDetailsSuccessfullyDeleted = 2514,
        GlobalImageDeleteConfirmation = 2515
    }

    public enum Status : int
    {
        None = 0,
        Active = 1,
        Inactive = 2
    }

    public enum ResourceMessages
    {
        None = 0,
        ResourceDtailsSuccessfullySaved = 3000,
        ProfessionalInfoDetailsSuccessfullySaved = 3001,
        PersonalInfoSuccessfullySaved = 3002,
        PersonalInfoSuccessfullyError = 3003,
        ContactInfoSuccessfullySaved = 3004,
        ManageUserProfileSuccessfullyUpdated = 3005,
        ManageUserProfileUserAlreadyExist = 3006,
        ManageUserProfileSuccessfullySaved = 3007,
        ProfessionalInfoDetailsSavingFailed = 3008,
        ProfessionalInfoValidationFailed = 3009,
        AssociatedCourseInfoSuccessfullySaved = 3010,
        AssociatedCourseInfoSavingFailed = 3011,
        ContactInfoSavingFailed = 3012,
        ResourceActivationFailed = 3013,
        ResourceGroupSavingFailed = 3014,
        AssociatedCourseInfoRecordExists = 3015
    }

    public enum ResourceEmailFileds
    {
        CourseStatus,
        CredentialStatus,
        PrimaryGroup,
        PrimaryContact,
        ResourceStatus,
        PrimaryGroupAdded
    }

    public enum MetadataActiveTab
    {
        None = 0,
        MetadataTab = 1
    }

    public enum EventManagementTab
    {
        None = 0,
        EventManagement = 1
    }

    public enum ProductionScheduleTab
    {
        None = 0,
        ProductionSchedule = 1
    }

    public enum DiscountManagementTab
    {
        None = 0,
        Promotions = 1,
        ExcludeProducts = 2
    }


    public enum HelpTab
    {
        None = 0,
        Help = 1
    }

    public enum ExtranetsTab
    {
        None = 0,
        Extranets = 1
    }
    public enum LMSTab
    {
        None = 0,
        LMS = 1
    }
    public enum MarketingContentTab
    {
        None = 0,
        MarketingContent = 1
    }

    public enum AdministrationsTab
    {
        None = 0,
        Administrations = 1
    }

    public enum CourseMetadataActiveTab
    {
        None = 0,
        General = 1,
        SupplementalMaterial = 2,
        Contributors = 3,
        CertificationsCredits = 4,
        Certifications = 5,
        Credits = 6,
        Measurement = 7,
        Marketing = 8,
        Status = 9,
        CoursewarePlayer = 10,
        TableOfContent = 11,
        Schedule = 12,
        Agenda = 13,
        ScheduleDetails = 14


    }

    public enum ResourceActiveTab
    {
        None = 0,
        ResourceTab = 1,
        ProfessionalInformationTab = 2,
        PersonalInformationTab = 3,
        ContactInformationTab = 4,
        AssociatedCoursesTab = 5,
        ManageUserProfilesTab = 6
    }

    public enum SupportToolsActiveTab
    {
        None = 0,
        Search = 1,
        ManageProfile = 2,
        ManageOrders = 3,
        ManageCPECredit = 4,
        InstallCode = 5,
        Emails = 6,
        ConsumptionTracking = 7
    }

    public enum PilotTestActiveTab
    {
        None = 0,
        PilotTestTab = 1,
        TestersTab = 2,
        NotificationsTab = 3,
        StatusReportTab = 4,
        FeedbackFormTab = 5,
        GradingStatusTab = 6
    }

    public enum PilotTestsActiveTab
    {
        None = 0,
        PilotTestsTab = 1,
        EmailTemplatesTab = 2,
        NASBAReportsTab = 3,
        TesterProfilesTab = 4
    }

    public enum LiveManagementTab
    {
        None = 0,
        ImportLiveEventsTab = 3,
        ImportLiveEventsLogTab = 4
    }

    public enum PromotionsActiveTab
    {
        None = 0,
        PromotionsTab = 1,
        ExcludeProductsTab = 2,
        ReportProductsTab = 3,
        OrderLevelRuleTab = 4,
        LineItemDiscountTab = 5
    }

    public enum OnLineGradingAdminActiveTab
    {
        None = 0,
        Exams = 1,
        Catalog = 2,
        Templates = 3
    }

    public enum OnLineGradingAdminExamTab
    {
        None = 0,
        ExamDetails = 1,
        Questions = 2,
        NotesActivity = 3,
        Versioning = 4,
        PilotTest = 5

    }

    public enum ReportTab
    {
        None = 0,
        ReportingManager = 1,
        ManifestManager = 2
    }

    #region Notification Service Enums

    public enum NotificationPriority
    {
        None = 0,
        High = 1,
        Medium = 2,
        Low = 3
    }

    public enum NotificationStatus
    {
        None = 0,
        Pending = 1,
        Completed = 2,
        Failed = 3
    }

    #endregion

    /// <summary>
    /// Email types
    /// </summary>
    public enum PilotTestEmailTypes
    {
        None = 0,
        Invitation = 1,
        CourseDetails = 2,
        Reminder = 3,
        TargetDateChange = 4
    }

    /// <summary>
    /// Invitations Status
    /// </summary>
    public enum PilotTestInvitationStatus
    {
        None = 0,
        NotInvited = 1,
        Invited = 2,
        Accepted = 3,
        Rejected = 4,
        Revoked = 5

    }

    /// <summary>
    /// Tester Status
    /// </summary>
    public enum PilotTesterTestStatus
    {
        None = 0,
        Completed = 1,
        InProgress = 2,
        NotStarted = 3,
        NA = 4
    }

    public enum PilotTestMessages
    {
        None = 0,
        PilotTestSuccessfullySaved = 4001,
        PilotTestSaveFailed = 4002,
        TemplateSuccessfullySaved = 4005,
        TemplateSuccessfullyDeleted = 4006,
        UnkonwnError = 2506,
        PilotTestFeedbackSucessfullySaved = 4007,
        PilotTestFeedbackSaveFailed = 4008,
        PilotTestCreateActivityWebServiceFailed = 4009,
        PilotTestValidTesterNotFound = 4010,
        PilotTestCpeCreditsNotAvailable = 4011,
        PilotTestWebServiceFailProfessionalNotExist = 4012,
        PilotTestWebServiceFailCourseInstanceNotExist = 4013,
        PilotTestWebServiceFailCourseInstanceNotAproved = 4014,
        //Defect fix for #85059 : Pilot Test - If Pilot test admin sends the link to ‘feedback’ form with ‘Course Details’ mail tester can submit the feedback form without successfully completing the pilot course.
        PilotTestFeedbackMessage = 4015



    }

    public enum PilotTestStatus
    {
        None = 0,
        Completed = 1,
        Started = 2,
        Invited = 3,
        InPrograss = 4,
        Closed = 5
    }

    public enum CourseLevels
    {
        None = 0,
        Basic = 1,  //Defalut
        Intermediate = 2,
        Advance = 3,
        Update = 4,
        Overview = 5
    }

    /// <summary>
    /// For the DatePart function
    /// </summary>
    public enum DateParts : int
    {
        Year = 0,
        Month = 1,
        Date = 2

    }

    #region Reports Enum

    /// <summary>
    /// Report Id to Map with Report table in database
    /// </summary>
    public enum ReportIdMap
    {
        None = 0,
        [Description("Click Through - Checkpoint")]
        ClickThroughCheckpoint = 1,
        [Description("Course Completion - Checkpoint")]
        CourseCompletionCheckpoint = 2,
        [Description("Course “Starts” - Checkpoint")]
        CourseStartsCheckpoint = 3,
        [Description("Course “Starts” - Royalty")]
        CourseStartsRoyalty = 4,
        [Description("Course Completion – Usage")]
        CourseCompletionUsage = 5,
        [Description("Course “Starts” – Usage")]
        CourseStartsUsage = 6,
        [Description("Issued Credits – Usage")]
        IssuedCreditsUsage = 7,
        [Description("Numeric Responses – Evaluations")]
        NumericResponsesEvaluations = 8,
        [Description("Free From Responses - Evaluations")]
        FreeFromResponsesEvaluations = 9,
        [Description("Course “No Shows” - Usage")]
        CourseNoShowsUsage = 10,
        [Description("Sales Report")]
        SalesReport = 11
    }

    public enum DataType
    {
        None = 0,
        Integer = 1,
        String = 2,
        DateTime = 3,
        SingleSelect = 4,
        MultiSelect = 5
    }


    public enum ReportSqlOperator
    {
        None = 0,
        Equal = 1,
        GreaterThan = 2,
        GreaterThanEqualTo = 3,
        Contains = 4,
        Between = 5,
        DoesNotEqualTo = 6,
        DoesNotContain = 7,
        BeginsWith = 8,
        DoesNotBeginwith = 9,
        EndsWith = 20,
        DoesNotEndWith = 11,
        LessThan = 12,
        LessThanOrEqualTo = 13

    }

    public enum ReportSortDirection
    {
        Asc = 0,
        Desc = 1

    }

    public enum PilotTesterStatus : int
    {
        None = 0,
        Active = 1,
        Doment = 2,
        Inactive = 3
    }



    public enum ReportsMessages
    {
        None = 0,
        ReportInstanceDetailsSuccessfullySaved = 4003,
        ReportInstanceDetailsSuccessfullyDeleted = 4004


    }

    public enum AddPilotTestersSortFields : int
    {
        FirstName = 0,
        LastName = 1,
        UserType = 2
    }

    public enum PilotTesterUserType
    {
        None = 0,
        PrintBased = 1,
        Online = 2,
        Both = 3
    }

    public enum ProfessionalStatus
    {
        None = 0,
        Active = 1,
        InActive = 2,
        Locked = 3
    }

    public enum FirmReport : int
    {
        None = 0,
        FirmAdmin = 1
    }

    #endregion

    #region Professional Enums

    /// <summary>
    /// Professional Reference Type
    /// </summary>
    public enum ProfessionalReferenceType
    {
        None = 0,
        Salutation = 1,
        AddressType = 2,
        EmailType = 3,
        PhoneType = 4,
        ProductType = 5,
        FieldOfStudy = 6,
        CountryList = 7,
        StateList = 8,
        TimeZoneList = 9,
        SecurityQuestion = 10
    }

    /// <summary>
    /// Professional Messages
    /// </summary>
    public enum ProfessionalMessages
    {
        None = 0,
        ProductAssociationFailed = 8057,
    }

    public enum RecordTypeStatus
    {
        Insert = 0,
        Update = 1,
        Delete = 2,
        New = 3

    }

    public enum UserProfileStatus
    {
        New = 0,
        Update = 1
    }

    #endregion

    #region Online Grading Enum

    public enum ExamStatus : int
    {
        All = 0,
        InProgress = 1,
        Completed = 2
    }

    public enum ExamMode : int
    {
        Edit = 0,
        Pilot = 1,
        Active = 2,
        Inactive = 4,
        Archive = 8
    }

    public enum OGSMessages
    {
        None = 0,
        OGSGetExamQuestionsPageDataNotFound = 6625,
        OGSGetExamQuestionsPageDataExamExpired = 6626,
        OGSGetExamQuestionsPageDataNoExamAttemptsRemaining = 6627,
        OGSGetExamQuestionsPageDataExamNewExamAttemptCreationFailed = 6628,
        OGSGetExamQuestionsPageDataNotAllowedCreate = 6631,
        OGSExamCreationNotSuccessfull = 7005,
        OGSExamCreationSuccessfull = 7006,
        OGSExamSuccessfullyUpdated = 7007,
        OGSCatalogSuccessfullyDeleted = 7013,
        OGSExamCourseMesurementsNotFound = 7008,
        OGSExamQuestionsNotAvailable = 7009,
        OGSExamQuestionAnswersNotAvailable = 7010,
        OGSExamImportQuestionAndAnswersSuccessfull = 7011,
        OGSCatalogSuccessfullySaved = 7012,


        OGSExamAttemptsNotAvailable = 7014,
        OGSCatalogSaveFailed = 7015,
        OGSCatalogUnisonIdFailed = 7016,
        OGSVaidateExamForUserInvalidExam = 7020,
        OGSVaidateExamForUserUnisonidNotAvailable = 7021,
        OGSVaidateExamForUserExamNotPurchased = 7022,
        OGSVaidateExamForUserExamValidationPassed = 7023,
        OGSUnisonIdsNotReceivedFromEntitlementService = 7024,
        OGSExamImportQuestionAndAnswersNoXmlFileUploaded = 7025,
        OGSExamImportQuestionAndAnswersInvalidXmlFileUploaded = 7026,
        OGSVaidateExamForUserExamNotAvailableYet = 7027,
        OGSVaidateExamForUserExamExpired = 7028,

        OGSExamSessionExpired = 7029,
        OGSReqwiredWebServiceFailedToAddActivity = 7031,
        OGSReqwiredWebServiceFailedToUpdateActivity = 7032,

        OGSExamAttemptCompletionFailed = 7033,

        OGSExamsNotSelectedForPurchase = 8056,

        OGSCatalogCourseStatusValidationFailed = 8058,
    }

    #endregion

    public enum ForgotLoginType : int
    {
        GetPassword = 0,
        GetUserName = 1
    }

    public enum SharedSessionLogType
    {
        None = 0,
        Login = 1,
        Logout = 2,
        UpdateSession = 3,
        ExpireSession = 4
    }

    public enum OgsCatalogStatus : int
    {
        Inactive = 0,
        Active = 1,
    }

    public enum KeywordSearchType
    {
        PhraseSearch = 0,
        WordSearch = 1
    }


    public enum SsmMessages
    {
        None = 0,
        DfaultOrganizationTextValue = 7030,
        PingIntegrationErrorTitle = 8166,
        PingIntegrationErrorMessage = 8167,
    }
    public enum LoginStatus
    {
        Success = 0,
        Failed = 1,
        AccountLocked = 2,
        MultipleLoginAttempt = 3,
        InvalidPassword = 4
    }

    public enum UserType
    {
        None = 0,
        Professional = 1,
        OrganizationAdministrator = 2,
        Internal = 3
    }

    public enum NasbaDelivery
    {
        GroupBasedLive = 1,
        InternetGroupBased = 2,
        SelfStudy = 3

    }

    /// <summary>
    /// for Delivery format ID's
    /// </summary>
    public enum DeliveryFormats
    {
        InHouseTrainingProduct = 1,
        Seminars = 2,
        OnlineLearningWebinars = 3,
        OnlineLearningSelfStudy = 4,
        SelfStudyPrintBased = 5,
        InHouseTrainingProgram = 6,
        Conferences = 8,
        Workshop = 7
    }

    public enum NasbaLearningLevel
    {

        None = 0,
        Basic = 1,
        Intermediate = 2,
        Advanced = 3,
        Overview = 4,
        Update = 5
    }

    public enum DataMigrationFrameworkMessages
    {
        ErrorMessageHeader = 8000,
        InvalidLegacySystemCredentials = 8001,
        InvalidCredentials = 8002,
        AdministratorPasswordMismatchMessage = 8003
    }

    public enum WCFUsernameSecurityMessages
    {
        InvalidHeaderContents = 8051,
        SecurityHeaderNotPresent = 8052,
        InvalidSecurityHeader = 8053,
        InvalidUsernameOrPassword = 8054,
        AccessDenied = 8055
    }

    public enum SysAdminActiveTab
    {
        None = 0,
        Diagnostic = 1,
        Settings = 2,
        Statistics = 3,
        NasTest = 4,
        UserRights = 5,
        DataMigration = 6,
        CloudStorage = 7,
        DataAdmin = 8
    }

    public enum MigrationActiveTab
    {
        None = 0,
        IpMigrationTab = 1,
        FirmMigrationTab = 2
    }

    public enum IpMigrationActiveTab
    {
        None = 0,
        TaskStatusTab = 1,
        LogsTab = 2,
        ExtractedDataTab = 3,
    }

    public enum FirmMigrationActiveTab
    {
        None = 0,
        FirmDetailsTab = 1,
        JobStatusTab = 2,
        LogsTab = 3,
        NotesForTechnicalHandlingTab = 4
    }

    public enum ProductReconciliationActiveTab
    {
        None = 0,
        ProductReconciliationReport = 1
    }

    //Data Migration Enums

    /// <summary>
    /// Task Statuses
    /// </summary>
    public enum TaskStatus
    {
        NotStarted = 1,
        InProgress = 2,
        Completed = 3,
        Failed = 4,
        Suspended = 5,
        Undefined = 0
    }


    /// <summary>
    /// Data Extract Process Status Enums
    /// </summary>
    public enum DataExtractProcessStatus
    {
        None = 0,
        InProgress = 1,
        Completed = 2,
        Failed = 3,
        Suspended = 4,
    }

    /// <summary>
    /// Migration Job Status
    /// </summary>
    public enum MigrationJobStatusInfo : int
    {
        None = 0,
        NotStarted = 1,
        InProgress = 2,
        Completed = 3,
        Failed = 4,
        Suspended = 5,
        Queued = 6,
        OnHold = 7,
        OnTechnicalHandling
    }

    /// <summary>
    /// Maintains  the Legacy Data Retrieval Status 
    /// Failed/PartiallyCompleted/Completed
    /// </summary>
    public enum LegacyDataRetrievalStatus
    {
        Failed = 0,
        PartiallyCompleted = 1,
        Completed = 2
    }

    public enum DynamicAssemblyTab
    {
        None = 0,
        Home = 1,
        ChapterLinking = 2,
        Reports = 3
    }

    /// <summary>
    /// Maintains the Legacy Data Operation Status 
    /// Failed/Succeeded
    /// </summary>
    public enum LegacyOperationStatus
    {
        Failed = 0,
        Succeeded = 1
    }

    /// <summary>
    /// Maintains the Legacy User Authentication Status 
    /// InternalError/InvalidCredentials/Authenticated
    /// </summary>
    public enum LegacyUserAuthenticationStatus
    {
        //User could not be authenticated due to an exception
        //Warning messages will give the actual error message
        InternalError = 0,

        //Provided credentials are invalid
        InvalidCredentials = 1,

        //User is successfully authenticated
        Authenticated = 2
    }


    /// <summary>
    /// Maintain the Legacy User Entititlement type
    /// </summary>
    public enum LegacyEntitlementType
    {
        //Default Value
        NoEntitlement = 0,
        //CE Tracking
        CETracking = 1,
        //MM+
        MicroMashPlus = 2,
        //unilited
        MicroMashUnlimited = 3,
        //Checkpoint
        Checkpoint = 4,
        //Passonline
        PassOnline = 5,
    }


    /// <summary>
    /// Maintains the Log Types 
    /// Information/Error/CriticalError
    /// </summary>
    public enum LogType
    {
        Undefined = 0,
        Information = 1,
        Error = 2,
        CriticalError = 3,
        Warning = 4
    }

    /// <summary>
    /// Maintains Task Property Scope
    /// Local/Job
    /// </summary>
    public enum TaskPropertyScope
    {
        Local = 0,
        Job = 1
    }

    //Ends of Data Migration Enums

    /// <summary>
    /// Professional Membership Types
    /// </summary>
    public enum ProfessionalMembership
    {
        [Description("None")]
        None = 0,
        [Description("CTEC")]
        CTEC = 1,
        [Description("CFP")]
        CFP = 2,
        [Description("IRS PTIN (EA or RTRP)")]
        IRSPTIN = 3
    }

    #region Firm Migration Enums
    public enum DataTransferStatus
    {
        None = -1,
        NotStarted = 0,
        Started = 1,
        Completed = 2,
        Failed = 3,
    }

    public enum DataTransferType
    {
        None = 0,
        Staging = 1,
        Production = 2,
    }
    #endregion

    #region Professional Address Type Enums

    public enum ProfessionalAddressTypes
    {
        None = 0,
        Shipping = 1,
        Billing = 2
    }

    /// <summary>
    /// Firm PASS Online selected validation type
    /// </summary>
    public enum FirmPASSOnlineSelectedValidationType
    {
        UserId = 0,
        Email = 1
    }

    #endregion

    public enum ProfessionalProductTypes
    {
        None = 0,
        Reqwired = 1,
        MicroMash = 2,
        PASSOnline = 3,
        OnlineGrading = 4,
        Checkpoint = 5
    }

    public enum DisplayProfessionalProductTypes
    {
        Reqwired = 1,
        MicroMash = 2,
        MicroMashPlusViaCheckpoint = 3,
        MicroMashPlusBothMicroMashAndPASSOnline = 4,
        MicroMashUnlimited = 5,
        PASSOnlineCreditHourspurchasedInadvance = 6,
        PASSOnlineSpecificCoursesPurchasedInAdvance = 7,
        OnlineGrading = 8,
    }

    public enum FileImportStatus
    {
        Success = 0,
        Warning = 1,
        Error = 2,
        CriticalError = 3,
    }

    #region Product List
    public enum ProductListActiveTab
    {
        None = 0,
        ProductList = 1
    }

    public enum ProductListManagementActiveTab
    {
        None = 0,
        CustomProductListManagement = 1
    }

    public enum PreviewCourseActivityStatus
    {
        None = 0,
        Preview = 1,
        Archive = 2,
        Purchased = 3

    }

    //public enum ProductListProductType
    //{
    //  None = 0,
    //  Course = 1,
    //  Exam = 2,
    //  Bundle = 3,
    //  SubscriptionProduct = 4,
    //  LiveEvent = 5,
    //  Seats = 6
    //}

    /// <summary>
    /// Holds product types for order entry
    /// </summary>
    public enum OrderEntryProductType
    {
        None = 0,
        Seminar = 1,
        Conference = 2,
        Workshop = 3,
        Unknown = 4,
        Webinar = 5,
        Webcast = 6

    }

    public enum ProductListManagementMessages
    {
        //ERA defect fixes add none=0
        None = 0,
        ProductListSuccessfullySaved = 8059,
        ProductListSaveFailed = 8060,
        AddProductsToProductListFailed = 8125,
    }

    #endregion

    public enum AutoNotifyCoursesActiveTab
    {
        None = 0,
        AutoNotifyEmailTemplatesTab = 1,
        AutoNotifyEmailDistributionTab = 2,
        AutoNotifyEmailNotificationTab = 3
    }

    public enum AutoNotifyMessages
    {
        None = 0,
        AutoNotifyEmailDistributionListDeleteFail = 8100,
    }


    public enum AutoNotifyTemplateVersion
    {
        None = 0,
        OnlyNewCourses = 1,
        NewCoursesMajorVersions = 2,
        NewCoursesAllVersions = 3,
    }

    /// <summary>
    /// Package types
    /// </summary>
    public enum PackageType
    {
        None = 0,
        Retail = 1,
        RAndG = 2,
        PickN = 3,
    }

    /// <summary>
    /// Sso request user types
    /// </summary>
    public enum SsoRequestUserType
    {
        None = 0,
        FirmProfessional = 1,
        FirmaAdministrator = 2
    }

    /// <summary>
    /// Sso Success Indicator
    /// </summary>
    public enum SsoStatusIndicator
    {
        None = 0,
        InvalidRequestParameters = 1,
        EntitleFailed = 2,
        LoginCredentialFailed = 3,
        ConcurrentUserLoggedIn = 4,
        RequestSuccessful = 5,
        RequestRuleFailed = 6
    }

    public enum MediaFormats
    {
        //ERA defect fixes add none=0
        None = 0,
        Online = 1,
        Download = 2,
        Seminar = 4,
        PrintBased = 5,
        Conference = 7,
        Webinar = 8,
        Workshop = 9,
        Webcast = 28,
        Ipad = 31
    }

    public enum CplGridSortDirection
    {
        Asc = 0,
        Desc = 1
    }

    /// <summary>
    /// This is the tab definition of the live event metadata
    /// </summary>
    public enum LiveEventMetadataActiveTab
    {
        None = 0,
        LiveEventManagement = 1,
        LiveEventCreditManagement = 2,
        LiveEventScheduleManagement = 3
    }

    public enum LiveEventSearchActiveTab
    {
        None = 0,
        LiveEventSearch = 1,
        BulkUpload = 2
    }

    public enum CustomerSupportMessage
    {
        None = 0,
        ShipToIdFail = 8600,
        UnitNumberExist = 8601,

    }
    public enum LiveEventMetadataMessage
    {
        None = 0,
        SaveScheduleFail = 8130,
        SaveScheduleSuccessFull = 8131,
        DeleteScheduleFail = 8132,
        DeleteScheduleSuccessful = 8133,
        DeleteLiveEventHeaderInformation = 8134,
        DeleteLiveEventSuccessful = 8135,
        DeleteLiveEventFail = 8136,
        SaveLiveEventCreditsSuccessful = 8137,
        SaveLiveEventCreditsFail = 8138,
        SaveLiveEventDetailsSuccessful = 8139,
        SaveLiveEventDetailsFail = 8140,
        InsertLiveEventDetailsFailCourseAcronymExists = 8141,
        InsertLiveEventDetailsFailCourseUnisonExists = 8142


    }

    public enum ProductMetadataMessage : int
    {
        //ERA defect fixes add none=0
        None = 0,
        ProductExamAndProfessionalPassed = 8300,
        ProfessionalIsExceedTheLimits = 8301,
        ExamIsExpiredToCurrentProfessional = 8302,
        ExamHasBeenPurchasedByThisProfessional = 8303,
        ItemHasPurchasedAlready = 8304,
        ProfessionalIsAipAndProductIsNotPurchased = 8305,
        OnlyIndividualProfessionalsCanBePurchased = 8306,
        FirmAdminCannotPurchaseProduct = 8307,
        InvalidLiveEventProductToPurchase = 8309,
        ValidLiveEventProductToPurchase = 8308,
        FACannotPurchaseComprehensiveBundle = 8312,
        FPCannotPurchaseComprehensiveBundle = 8313,
        IPAlreadyPurchasedBundle = 8314,
        IPAlreadyHasThisProductUnderMyCpe = 8315,
        UserHasThisProduct = 8316,
        ActivityFoundErrorMessage = 8319,
        ActiveEntitledWithDontHaveActivity = 8318,

        FirmAdminCannotPurchaseCompetencyModel = 8317
    }

    public enum LiveEventScheduleStatus
    {
        //ERA defect fixes add none=0
        None = 0,
        Open = 1,
        Full = 2,
        Close = 3,
    }

    #region Live Event Setup

    public enum LiveEventProductSetupEditActiveTab
    {
        None = 0,
        ProductSetup = 1,
        Promotion = 2,
        Notes = 3,
    }
    public enum LiveEventConferenceSetupActiveTab
    {
        None = 0,
        ConferenceDetails = 1,
        Seminars = 2,
        OptionalSeminars = 3,
        Combinations = 4,
    }

    public enum LiveEventProductSetupActiveTab
    {
        None = 0,
        ProductSetup = 1,
        ConferenceSetup = 2,
        LocationSetup = 3,
        SocietySetup = 4,
        BulkUpload = 5
    }

    #endregion

    public enum BrandList
    {
        //ERA defect fixes add none=0
        None = 0,
        WebinarLearningNetwork = 3,
        GearUp = 4,
        GearUpWorkshops = 5,
        PPC = 6,
        PPCInHouse = 7,
        AuditWatch = 8,
        PPCAuditWatchConferences = 9,
        PPCVideoDigest = 10,
    }

    public enum ExternalApplications
    {
        None = 0,
        CheckPoint = 1,
        OneSource = 2,
    }

    public enum TrtaAppsMessages
    {
        None = 0,
        UnauthorizedAccessFP = 8164,
        UnauthorizedAccessIP = 8165,
        OspErrorLaunch = 8168,
        OspErrorCourseFinder = 8169,
        OspErrorInprogressCourses = 8170,
        OspErrorStatusReport = 8171,
    }

    public enum ProductReconciliationReportType
    {
        None = 0,
        SpecificProductList = 1,
        FullProductList = 2,
        BundleReportList = 3
    }

    public enum ProductReconciliationSearchType
    {
        None = 0,
        CPLAcronym = 1,
        CuasProductCode = 2,
        CuasCPL = 3,
        UnisonItemCode = 4
    }

    /// <summary>
    /// Profiling online user types
    /// </summary>
    public enum ProfilingOnlineUserType
    {
        None = 0,
        IndependentProfessional = 1,
        FirmProfessional = 2,
        OrganizationAdministrator = 3
    }

    #region Live Event Order Entry

    #region Live Event Oder Entry Active tabs
    public enum LiveEventMainOderEntryActiveTab
    {
        None = 0,
        Professionals = 1,
        Orders = 2,
        Customers = 3
    }

    public enum LiveEventOrderEntryOrderDetailsActiveTab
    {
        None = 0,
        OrderDetails = 1,
        AttendeesSearch = 2,
        Notes = 3,
        OriginalOrder = 4
    }

    public enum LiveEventOrderEntryProfessionalOrderDetailsActiveTab
    {
        None = 0,
        ProfessionalDetails = 1,
        ProfessionalOrderHistory = 2
    }

    public enum LiveEventOrderEntryFirmOrderDetailsActiveTab
    {
        None = 0,
        FirmOrderHistorySearch = 1
    }

    public enum LiveEventOrderEntryAttendanceTicketsDetailsActiveTab
    {
        None = 0,
        AttendanceTickets = 1
    }

    public enum LiveEventMainOderEntryProductActiveTab
    {
        None = 0,
        Product = 1,
        EventAttendees = 2,
        ConferenceSelection = 3
    }

    public enum LiveEventMainOderEntryUnisonProductActiveTab
    {
        None = 0,
        UnisonProduct = 1
    }


    #endregion

    public enum LiveEventOrderLineItemStatus
    {
        None = 0,
        Assigned = 1,
        Deleted = 2
    }

    public enum LiveEventOrderStatus
    {
        None = 0,
        Open = 1,
        Completed = 2,
        Cancelled = 3,
        Updated = 4
    }

    public enum LiveEventOrderAttendeeMode
    {
        None = 0,
        IsEditMode = 1
    }

    public enum LiveEventOrderLineItemTableUpdateType : int
    {
        None = 0,
        Insert = 1,
        Update = 2
    }

    public enum LiveEventOrderType
    {
        None = 0,
        Fax = 1,
        Phone = 2,
        Web = 3,
        Mail = 4,
        ComprehensiveBundle = 5
    }

    public enum DeleteAttendeeStatus
    {
        Required = 0,
        NotRequired = 1

    }

    public enum LiveEventOrderEntryType
    {
        None = 0,
        IP = 1,
        FirmAdmin = 2,
        FirmProfessional = 3
    }


    public enum LiveEventOrderLineItemRegistrationStatus : int
    {
        None = 0,
        NotConfirmed = 1,
        Active = 2,
        Inactive = 3
    }

    public enum LiveEventOrderLineItemAttendeeStatus
    {
        None = 0,
        Allocated = 1,
        Deleted = 2
    }


    public enum LiveEventOrderDeleteMode
    {
        None = 0,
        Cancel = 1,
        PermanentDelete = 2
    }

    public enum LiveEventOrderCancelDisplayMode
    {
        None = 0,
        GoToProductSearch = 1,
        GoToEmptyOrder = 2,
        Error = 3
    }


    public enum ProfessionalEmailAddressType
    {
        None = 0,
        Personal = 1,
        Business = 2
    }

    public enum LiveEventOrderDeleteReturnType
    {
        Error = 0,
        OrderDeleted = 1,
        LineItemDeleted = 2
    }

    #endregion

    #region Irs

    public enum IrsBulkImportTab
    {
        None = 0,
        BulkImport = 1,
        ImportLog = 2
    }
    #endregion

    /// <summary>
    /// Use to represent attendance managment tag index
    /// </summary>
    public enum AttendanceManagementTab
    {
        None = 0,
        AttendanceManagement = 1,
        TimeEntryDetail = 2,
        RegistrantList = 3,
        ProfessionalTimeEntry = 4,
        AddProfessional = 5,
        Barcode = 6,
        ReminderSetup = 7
    }

    public enum CourseDetailsRedirectPageType
    {
        None = 0,
        PredefinedBundles = 1,
        CETracking = 2,
        ComprehensiveBundles = 3,
        CompetencyModel = 4

    }


    /// <summary>
    /// Defines Course Feature information
    /// </summary>
    public enum CourseFeatureType
    {
        None = 0,
        ComingSoon = 1,
        New = 2,
        Updated = 3
    }
    /// <summary>
    /// Use to holds error codes from the Copy Accreditation SP
    /// </summary>
    public enum AccreditationErrorCode : int
    {
        Success = 0,
        NoSourceFound = 50001,
        AccreditationGloballyDisabled = 50002,
        FirstSchedule = 50003,
        Failed = 50004
    }

    /// <summary>
    /// Course Sponsors
    /// </summary>
    public enum CourseSponsorType : int
    {
        None = 0,
        MicroMash = 2001,
        PassOnline = 2002,
        PPCSelfStudy = 2003,
        PPCGroupLiveGroupInternetBased = 2004,
        PPCOther = 2005,
        GearUpSelfStudyGearUpQF = 2006,
        GearUpGroupLiveGearUp = 2007,
        GearUpGearUpWorkshops = 2008,
        AuditWatch = 2009,
    }

    /// <summary>
    /// Holds barcode validation codes
    /// </summary>
    public enum BarcodeValidationCode : int
    {
        None = 0,
        BusinessRulesValidationSuccessful = 1,
        InvalidScannedAttendee = 2,
        LocationValidationFailed = 3,
        InvalidScheduleOrderStatus = 4,
        ScheduleTimeExpired = 5,
        ScheduleNotExist = 6,
        ConcurrentScheduleExist = 7,
        OverInitialStartTime = 8,
        LineItemAttendeeStatusDeleted = 9,
        InvalidBarcodeNumber = 10,
        MaximumNumberOfAttendeeExceeded = 11,
        ScheduleSwapAndSaveSuccessful = 12,
        InvalidMediaFormat = 13,
        OrderExistToConcurrentSchedule = 14,
        OrderNotExistToConcurrentSchedule = 15,
        InvalidConferenceSchedule = 16,
        InvalidEventCode = 17
    }

    /// <summary>
    /// Holds the Barcode Bulk Operation Indicator
    /// </summary>
    public enum BarcodeBulkOperationIndicator
    {
        None = 0,
        BulkCheckout = 1,
        BulkCheckIn = 2,
        CheckInAll = 3
    }

    /// <summary>
    /// Holds attendance management time entry
    /// </summary>
    public enum AttendanceManagementTimeEntry : int
    {
        None = 0,
        AttendedInOutValidationSuccess = 5,
        AttendedInOutValidationFailed = 6

    }

    /// <summary>
    /// Log status for the live event import operation
    /// </summary>
    public enum ImportLiveSeminarStatus
    {
        Starting = 0,
        InProgress = 1,
        Pass = 2,
        Fail = 3,
        NotApplicable = 4,
        End = 5,
        Completed = 6,
        Warning = 7
    }

    /// <summary>
    /// Bulk Import Course Types
    /// </summary>
    public enum BulkImportCourseType
    {
        None = 0,
        SeminarsAndWorkshops = 1,
        WebinarsAndWebcasts = 2
    }

    public enum CourseFinderButtonType
    {
        None = 0,
        MoreInfo = 1,
        BuyNow = 2,
        BuyExam = 3,
        Pdf = 4,
        Preview = 5,
        BuyNowWithByExam = 6,
        PdfWithByExam = 7,
        BuyNowWithPreview = 8,
        LiveEvent = 9,
        BuyLiveEvent = 10,
        Webinar = 11,
        InHouse = 12,
        LaunchAndDownload = 13,
        Register = 14,
        Registered = 15,
        LaunchExam = 16,
        PdfWithLaunchExam = 17,
        UNRegister = 18
    }

    public enum ActionType
    {
        None = 0,
        Launch = 1,
        Register = 2,
        LaunchExam = 3,
        RedirectToCourseDetail = 4,
        Download = 5,
        UNRegister = 6
    }

    public enum PageUserIFrameStatus
    {
        Success = 0,
        Failed = -1
    }


    //public enum ProductType
    //{
    //  None = 0,
    //  LiveEvent = 1,
    //  Course = 2
    //}

    public enum ProductType
    {
        [Description("None")]
        None = 0,
        [Description("Course")]
        Course = 1,
        [Description("Exam")]
        Exam = 2,
        [Description("Bundle")]
        Bundle = 3,
        [Description("Subscription Product")]
        SubscriptionProduct = 4,
        [Description("Live Event")]
        LiveEvent = 5,
        [Description("Comprehensive Bundle")]
        ComprehensiveBundle = 6

    }

    ///// <summary>
    ///// Uses to identify product types for cart operations
    ///// </summary>
    //public enum CartProductType
    //{
    //  None = 0,
    //  LiveEvent = 1,
    //  Course = 2,
    //  Exam = 3,
    //  ComprehensiveBundle = 4
    //}

    /// <summary>
    /// Messages related to cart
    /// </summary>
    public enum CartMessage
    {
        None = 0,
        ShoppingCartDisabledForAdmin = 8308,
        ShoppingCartDisabledForProfessional = 8311,
        CartMaintenance = 8602,
        CartErrorShoppingCartDisableHeader = 8309,
        CartException = 8310,
    }

    public enum NoteType
    {
        None = 0,
        LiveEventProductNote = 1,
        OrderNote = 2,
        WebinarAttendanceNote = 3
    }

    public enum LeftNavigationPageType
    {
        Default = 0,
        CourseFinder = 1,
        MyCpe = 3
    }

    /// <summary>
    /// Enums for CourseMetadata Dropdown Filtering
    /// </summary>
    public enum CourseGroupSearchType
    {
        None = 0,
        BrandSearch = 1,
        NasbaDeliveryFormatSearch = 2,
        DeliveryFormatSearch = 3,
        MediaFormatSearch = 4,
        CEFormatSearch = 5
    }

    //TODO
    public enum LiveEventMediaFormatType
    {
        Seminar = 1,
        Conference = 2,
        Workshop = 3,
        Webinar = 4,
        Webcast = 5,
    }


    public enum CourseFinderPageType
    {
        CourseFinder = 0,
        CourseDetail = 1
    }

    public enum ApplicationUserType
    {
        Unauthenticated = 0,
        FirmProfessional = 1,
        FirmAdmin = 2,
        IndividualProfessional = 3,
        Internal = 4
    }

    public enum ProfileOnlineMarketingMessage
    {
        None = 0,
        FirmProfessionalMessage = 8603,
        FirmAdminMessage = 8604,
    }

    public enum CourseFlagType
    {
        None = 0,
        BundleCourse = 1,
        LiveEventCourse = 2,
        RetailCourse = 3
    }

    public enum EntitledCourseStatusType
    {
        None = 0,
        BundleLiveEventRegistered = 1,
        BundleLiveEventNotRegistered = 2,
        RetailLiveEventRegistered = 3
    }

    /// <summary>
    /// The product types that a professional is entitled
    /// </summary>
    public enum EntitledCourseType
    {
        None = 0,
        RetailCourse = 1,
        PredefinedBundle = 2,
        PickNBundle = 3,
    }

    /// <summary>
    /// Comprehensive Bundle Subscription Status Id
    /// </summary>
    public enum ComprehensiveBundleSubscriptionStatusId
    {
        None = 0,
        Active = 1,
        InActive = 2
    }

    /// <summary>
    /// To determine the different pages (Find Cpe, My Cpe etc)
    /// </summary>
    public enum PageSourceType
    {
        None = 0,
        FindCpe = 1,
        MyCpe = 2
    }


    /// <summary>
    /// Enum defines the comprehensive bundle subscription status
    /// </summary>
    public enum ComprehensiveBundleSubscriptionStatusType
    {
        None = 0,
        Active = 1,
        Expired = 2
    }

    #region Irs
    public enum IrsUserImportStatus
    {
        None = 0,
        Succeess = 1,
        Fail = 2,
        EntitleMentFail = 3
    }
    #endregion

    #region ManagePackages
    public enum ManagePackagesTab
    {
        None = 0,
        ManagePackages = 1,
        General = 2,
        CourseList = 3,
        Products = 4,
        PromotionManagement = 5
    }
    public enum PackageStatus
    {
        None = 0,
        Active = 1,
        Inwork = 3,
        Edit = 4
    }
    #endregion

}




