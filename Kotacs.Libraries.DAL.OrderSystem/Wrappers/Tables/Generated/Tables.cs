using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kotacs.Libraries.DAL.OrderSystem.Wrappers.Tables.Generated
{
    public partial class VwLeftNavigationNodesTable : SqlTable
    {
        /// <summary>
        /// Initializes a new table defintion for the datbase table, vw_LeftNavigationNodes
        /// </summary>
        public VwLeftNavigationNodesTable()
            : base("vw_LeftNavigationNodes", "vw_LeftNavigationNodes")
        {

        }

        /// <summary>
        /// The LeftNavigationNodeId table Field
        /// </summary>
        public SqlField LeftNavigationNodeId
        {
            get { return this["[LeftNavigationNodeId]"]; }
        }

        /// <summary>
        /// The NodeTitle table Field
        /// </summary>
        public SqlField NodeTitle
        {
            get { return this["[NodeTitle]"]; }
        }

        /// <summary>
        /// The NavigationUrl table Field
        /// </summary>
        public SqlField NavigationUrl
        {
            get { return this["[NavigationUrl]"]; }
        }

        /// <summary>
        /// The IsRelativeUrl table Field
        /// </summary>
        public SqlField IsRelativeUrl
        {
            get { return this["[IsRelativeUrl]"]; }
        }

        /// <summary>
        /// The IsCollapsible table Field
        /// </summary>
        public SqlField IsCollapsible
        {
            get { return this["[IsCollapsible]"]; }
        }

        /// <summary>
        /// The ParentNodeId table Field
        /// </summary>
        public SqlField ParentNodeId
        {
            get { return this["[ParentNodeId]"]; }
        }

        /// <summary>
        /// The LeftNavigationNodeTypeId table Field
        /// </summary>
        public SqlField LeftNavigationNodeTypeId
        {
            get { return this["[LeftNavigationNodeTypeId]"]; }
        }

        /// <summary>
        /// The ImageFilePath table Field
        /// </summary>
        public SqlField ImageFilePath
        {
            get { return this["[ImageFilePath]"]; }
        }

        /// <summary>
        /// The LeftNavigationNodeType table Field
        /// </summary>
        public SqlField LeftNavigationNodeType
        {
            get { return this["[LeftNavigationNodeType]"]; }
        }

        /// <summary>
        /// The AbsoluteUrl table Field
        /// </summary>
        public SqlField AbsoluteUrl
        {
            get { return this["[AbsoluteUrl]"]; }
        }

        /// <summary>
        /// The VisibleToAnonymous table Field
        /// </summary>
        public SqlField VisibleToAnonymous
        {
            get { return this["[VisibleToAnonymous]"]; }
        }

        /// <summary>
        /// The VisibleToFA table Field
        /// </summary>
        public SqlField VisibleToFa
        {
            get { return this["[VisibleToFA]"]; }
        }

        /// <summary>
        /// The VisibleToFP table Field
        /// </summary>
        public SqlField VisibleToFp
        {
            get { return this["[VisibleToFP]"]; }
        }

        /// <summary>
        /// The VisibleToIP table Field
        /// </summary>
        public SqlField VisibleToIp
        {
            get { return this["[VisibleToIP]"]; }
        }

        /// <summary>
        /// The Priority table Field
        /// </summary>
        public SqlField Priority
        {
            get { return this["[Priority]"]; }
        }

        /// <summary>
        /// The CompBundleStatus table Field
        /// </summary>
        public SqlField CompBundleStatus
        {
            get { return this["[CompBundleStatus]"]; }
        }

    }
    public partial class OgsExamTable : SqlTable
    {
        /// <summary>
        /// Initializes a new table defintion for the datbase table, OgsExam
        /// </summary>
        public OgsExamTable()
            : base("OgsExam", "OgsExam")
        {

        }

        /// <summary>
        /// The OgsExamID table Field
        /// </summary>
        public SqlField OgsExamId
        {
            get { return this["[OgsExamID]"]; }
        }

        /// <summary>
        /// The OgsCatalogID table Field
        /// </summary>
        public SqlField OgsCatalogId
        {
            get { return this["[OgsCatalogID]"]; }
        }

        /// <summary>
        /// The CourseMetadataID table Field
        /// </summary>
        public SqlField CourseMetadataId
        {
            get { return this["[CourseMetadataID]"]; }
        }

        /// <summary>
        /// The DateCreated table Field
        /// </summary>
        public SqlField DateCreated
        {
            get { return this["[DateCreated]"]; }
        }

        /// <summary>
        /// The DateUpdated table Field
        /// </summary>
        public SqlField DateUpdated
        {
            get { return this["[DateUpdated]"]; }
        }

        /// <summary>
        /// The DatePilotStart table Field
        /// </summary>
        public SqlField DatePilotStart
        {
            get { return this["[DatePilotStart]"]; }
        }

        /// <summary>
        /// The DatePilotEnd table Field
        /// </summary>
        public SqlField DatePilotEnd
        {
            get { return this["[DatePilotEnd]"]; }
        }

        /// <summary>
        /// The OwnerID table Field
        /// </summary>
        public SqlField OwnerId
        {
            get { return this["[OwnerID]"]; }
        }

        /// <summary>
        /// The OgsExamStatusID table Field
        /// </summary>
        public SqlField OgsExamStatusId
        {
            get { return this["[OgsExamStatusID]"]; }
        }


        /// <summary>
        /// Adds an inner join relationship with the table, CourseMetadataTable
        /// </summary>
        //public CourseMetadataTable JoinCourseMetadataTable(QueryBase query)
        //{
        //    CourseMetadataTable courseMetadataTable = new CourseMetadataTable();
        //    query.InnerJoin(courseMetadataTable, this.CourseMetadataId, courseMetadataTable.CourseMetadataId);
        //    return courseMetadataTable;
        //}

        ///// <summary>
        ///// Adds a left outer join relationship with the table, CourseMetadataTable
        ///// </summary>
        //public CourseMetadataTable OuterJoinCourseMetadataTable(QueryBase query)
        //{
        //    CourseMetadataTable courseMetadataTable = new CourseMetadataTable();
        //    query.LeftOuterJoin(courseMetadataTable, this.CourseMetadataId, courseMetadataTable.CourseMetadataId);
        //    return courseMetadataTable;
        //}

        /// <summary>
        /// Adds an inner join relationship with the table, OgsCatalogTable
        /// </summary>
        public OgsCatalogTable JoinOgsCatalogTable(QueryBase query)
        {
            OgsCatalogTable ogsCatalogTable = new OgsCatalogTable();
            //query.InnerJoin(ogsCatalogTable, this.OgsCatalogId, ogsCatalogTable.OgsCatalogId);
            return ogsCatalogTable;
        }

        /// <summary>
        /// Adds a left outer join relationship with the table, OgsCatalogTable
        /// </summary>
        public OgsCatalogTable OuterJoinOgsCatalogTable(QueryBase query)
        {
            OgsCatalogTable ogsCatalogTable = new OgsCatalogTable();
            query.LeftOuterJoin(ogsCatalogTable, this.OgsCatalogId, ogsCatalogTable.OgsCatalogId);
            return ogsCatalogTable;
        }
    }
    public partial class OgsCatalogTable : SqlTable
    {
        /// <summary>
        /// Initializes a new table defintion for the datbase table, OgsCatalog
        /// </summary>
        public OgsCatalogTable()
            : base("OgsCatalog", "OgsCatalog")
        {

        }

        /// <summary>
        /// The OgsCatalogID table Field
        /// </summary>
        public SqlField OgsCatalogId
        {
            get { return this["[OgsCatalogID]"]; }
        }

        /// <summary>
        /// The OgsCatalogTypeID table Field
        /// </summary>
        public SqlField OgsCatalogTypeId
        {
            get { return this["[OgsCatalogTypeID]"]; }
        }

        /// <summary>
        /// The DateCreated table Field
        /// </summary>
        public SqlField DateCreated
        {
            get { return this["[DateCreated]"]; }
        }

        /// <summary>
        /// The DateUpdated table Field
        /// </summary>
        public SqlField DateUpdated
        {
            get { return this["[DateUpdated]"]; }
        }

        /// <summary>
        /// The DateAvailable table Field
        /// </summary>
        public SqlField DateAvailable
        {
            get { return this["[DateAvailable]"]; }
        }

        /// <summary>
        /// The DateExpires table Field
        /// </summary>
        public SqlField DateExpires
        {
            get { return this["[DateExpires]"]; }
        }

        /// <summary>
        /// The UnisonID table Field
        /// </summary>
        public SqlField UnisonId
        {
            get { return this["[UnisonID]"]; }
        }

        /// <summary>
        /// The Description table Field
        /// </summary>
        public SqlField Description
        {
            get { return this["[Description]"]; }
        }

        /// <summary>
        /// The Factor table Field
        /// </summary>
        public SqlField Factor
        {
            get { return this["[Factor]"]; }
        }

        /// <summary>
        /// The Price table Field
        /// </summary>
        public SqlField Price
        {
            get { return this["[Price]"]; }
        }

        /// <summary>
        /// The IsActive table Field
        /// </summary>
        public SqlField IsActive
        {
            get { return this["[IsActive]"]; }
        }


        /// <summary>
        /// Adds an inner join relationship with the table, OgsExamTable
        /// </summary>
        public OgsExamTable JoinOgsExamTable(QueryBase query)
        {
            OgsExamTable ogsExamTable = new OgsExamTable();
            //query.InnerJoin(ogsExamTable, this.OgsCatalogId, ogsExamTable.OgsCatalogId);
            return ogsExamTable;
        }

        /// <summary>
        /// Adds a left outer join relationship with the table, OgsExamTable
        /// </summary>
        public OgsExamTable OuterJoinOgsExamTable(QueryBase query)
        {
            OgsExamTable ogsExamTable = new OgsExamTable();
            query.LeftOuterJoin(ogsExamTable, this.OgsCatalogId, ogsExamTable.OgsCatalogId);
            return ogsExamTable;
        }
    }
    //public partial class CourseMetadataTable : SqlTable
    //{
    //    /// <summary>
    //    /// Initializes a new table defintion for the datbase table, CourseMetadata
    //    /// </summary>
    //    public CourseMetadataTable()
    //        : base("CourseMetadata", "CourseMetadata")
    //    {

    //    }

    //    /// <summary>
    //    /// The CourseMetadataID table Field
    //    /// </summary>
    //    public SqlField CourseMetadataId
    //    {
    //        get { return this["[CourseMetadataID]"]; }
    //    }

    //    /// <summary>
    //    /// The Acronym table Field
    //    /// </summary>
    //    public SqlField Acronym
    //    {
    //        get { return this["[Acronym]"]; }
    //    }

    //    /// <summary>
    //    /// The Title table Field
    //    /// </summary>
    //    public SqlField Title
    //    {
    //        get { return this["[Title]"]; }
    //    }

    //    /// <summary>
    //    /// The VersionNumber table Field
    //    /// </summary>
    //    public SqlField VersionNumber
    //    {
    //        get { return this["[VersionNumber]"]; }
    //    }

    //    /// <summary>
    //    /// The Description table Field
    //    /// </summary>
    //    public SqlField Description
    //    {
    //        get { return this["[Description]"]; }
    //    }

    //    /// <summary>
    //    /// The CourseSponsorID table Field
    //    /// </summary>
    //    public SqlField CourseSponsorId
    //    {
    //        get { return this["[CourseSponsorID]"]; }
    //    }

    //    /// <summary>
    //    /// The InteractiveLevelID table Field
    //    /// </summary>
    //    public SqlField InteractiveLevelId
    //    {
    //        get { return this["[InteractiveLevelID]"]; }
    //    }

    //    /// <summary>
    //    /// The PrivateCourse table Field
    //    /// </summary>
    //    public SqlField PrivateCourse
    //    {
    //        get { return this["[PrivateCourse]"]; }
    //    }

    //    /// <summary>
    //    /// The ClientName table Field
    //    /// </summary>
    //    public SqlField ClientName
    //    {
    //        get { return this["[ClientName]"]; }
    //    }

    //    /// <summary>
    //    /// The LearningLevelID table Field
    //    /// </summary>
    //    public SqlField LearningLevelId
    //    {
    //        get { return this["[LearningLevelID]"]; }
    //    }

    //    /// <summary>
    //    /// The LearningObjectives table Field
    //    /// </summary>
    //    public SqlField LearningObjectives
    //    {
    //        get { return this["[LearningObjectives]"]; }
    //    }

    //    /// <summary>
    //    /// The Prerequsites table Field
    //    /// </summary>
    //    public SqlField Prerequsites
    //    {
    //        get { return this["[Prerequsites]"]; }
    //    }

    //    /// <summary>
    //    /// The AdvancedPreparation table Field
    //    /// </summary>
    //    public SqlField AdvancedPreparation
    //    {
    //        get { return this["[AdvancedPreparation]"]; }
    //    }

    //    /// <summary>
    //    /// The TechnicalRequirements table Field
    //    /// </summary>
    //    public SqlField TechnicalRequirements
    //    {
    //        get { return this["[TechnicalRequirements]"]; }
    //    }

    //    /// <summary>
    //    /// The TechnicalSpecification table Field
    //    /// </summary>
    //    public SqlField TechnicalSpecification
    //    {
    //        get { return this["[TechnicalSpecification]"]; }
    //    }

    //    /// <summary>
    //    /// The BrandID table Field
    //    /// </summary>
    //    public SqlField BrandId
    //    {
    //        get { return this["[BrandID]"]; }
    //    }

    //    /// <summary>
    //    /// The NasbaRegistry table Field
    //    /// </summary>
    //    public SqlField NasbaRegistry
    //    {
    //        get { return this["[NasbaRegistry]"]; }
    //    }

    //    /// <summary>
    //    /// The NasbaQas table Field
    //    /// </summary>
    //    public SqlField NasbaQas
    //    {
    //        get { return this["[NasbaQas]"]; }
    //    }

    //    /// <summary>
    //    /// The CtecCourse table Field
    //    /// </summary>
    //    public SqlField CtecCourse
    //    {
    //        get { return this["[CtecCourse]"]; }
    //    }

    //    /// <summary>
    //    /// The CtecCourseNumber table Field
    //    /// </summary>
    //    public SqlField CtecCourseNumber
    //    {
    //        get { return this["[CtecCourseNumber]"]; }
    //    }

    //    /// <summary>
    //    /// The CfpCourse table Field
    //    /// </summary>
    //    public SqlField CfpCourse
    //    {
    //        get { return this["[CfpCourse]"]; }
    //    }

    //    /// <summary>
    //    /// The CfpCourseNumber table Field
    //    /// </summary>
    //    public SqlField CfpCourseNumber
    //    {
    //        get { return this["[CfpCourseNumber]"]; }
    //    }

    //    /// <summary>
    //    /// The YellowBookQualify table Field
    //    /// </summary>
    //    public SqlField YellowBookQualify
    //    {
    //        get { return this["[YellowBookQualify]"]; }
    //    }

    //    /// <summary>
    //    /// The ReadyForPilotTesting table Field
    //    /// </summary>
    //    public SqlField ReadyForPilotTesting
    //    {
    //        get { return this["[ReadyForPilotTesting]"]; }
    //    }

    //    /// <summary>
    //    /// The PilotTestCpeCreditTarget table Field
    //    /// </summary>
    //    public SqlField PilotTestCpeCreditTarget
    //    {
    //        get { return this["[PilotTestCpeCreditTarget]"]; }
    //    }

    //    /// <summary>
    //    /// The TargetPilotTestCompletionDate table Field
    //    /// </summary>
    //    public SqlField TargetPilotTestCompletionDate
    //    {
    //        get { return this["[TargetPilotTestCompletionDate]"]; }
    //    }

    //    /// <summary>
    //    /// The ActualPilotTestCompletionDate table Field
    //    /// </summary>
    //    public SqlField ActualPilotTestCompletionDate
    //    {
    //        get { return this["[ActualPilotTestCompletionDate]"]; }
    //    }

    //    /// <summary>
    //    /// The CtecFederalcCredits table Field
    //    /// </summary>
    //    public SqlField CtecFederalcCredits
    //    {
    //        get { return this["[CtecFederalcCredits]"]; }
    //    }

    //    /// <summary>
    //    /// The CtecCaCredits table Field
    //    /// </summary>
    //    public SqlField CtecCaCredits
    //    {
    //        get { return this["[CtecCaCredits]"]; }
    //    }

    //    /// <summary>
    //    /// The CfpCredits table Field
    //    /// </summary>
    //    public SqlField CfpCredits
    //    {
    //        get { return this["[CfpCredits]"]; }
    //    }

    //    /// <summary>
    //    /// The MarketingDescription table Field
    //    /// </summary>
    //    public SqlField MarketingDescription
    //    {
    //        get { return this["[MarketingDescription]"]; }
    //    }

    //    /// <summary>
    //    /// The RecentChanges table Field
    //    /// </summary>
    //    public SqlField RecentChanges
    //    {
    //        get { return this["[RecentChanges]"]; }
    //    }

    //    /// <summary>
    //    /// The MarketingStatementChanges table Field
    //    /// </summary>
    //    public SqlField MarketingStatementChanges
    //    {
    //        get { return this["[MarketingStatementChanges]"]; }
    //    }

    //    /// <summary>
    //    /// The Keywords table Field
    //    /// </summary>
    //    public SqlField Keywords
    //    {
    //        get { return this["[Keywords]"]; }
    //    }

    //    /// <summary>
    //    /// The TargetAudiance table Field
    //    /// </summary>
    //    public SqlField TargetAudiance
    //    {
    //        get { return this["[TargetAudiance]"]; }
    //    }

    //    /// <summary>
    //    /// The CourseURL table Field
    //    /// </summary>
    //    public SqlField CourseUrl
    //    {
    //        get { return this["[CourseURL]"]; }
    //    }

    //    /// <summary>
    //    /// The PassingGrade table Field
    //    /// </summary>
    //    public SqlField PassingGrade
    //    {
    //        get { return this["[PassingGrade]"]; }
    //    }

    //    /// <summary>
    //    /// The AllowedAttempts table Field
    //    /// </summary>
    //    public SqlField AllowedAttempts
    //    {
    //        get { return this["[AllowedAttempts]"]; }
    //    }

    //    /// <summary>
    //    /// The OnlineGradingExam table Field
    //    /// </summary>
    //    public SqlField OnlineGradingExam
    //    {
    //        get { return this["[OnlineGradingExam]"]; }
    //    }

    //    /// <summary>
    //    /// The OnlineGradingExamCode table Field
    //    /// </summary>
    //    public SqlField OnlineGradingExamCode
    //    {
    //        get { return this["[OnlineGradingExamCode]"]; }
    //    }

    //    /// <summary>
    //    /// The LastAuthorRevisionDate table Field
    //    /// </summary>
    //    public SqlField LastAuthorRevisionDate
    //    {
    //        get { return this["[LastAuthorRevisionDate]"]; }
    //    }

    //    /// <summary>
    //    /// The HistroryNotes table Field
    //    /// </summary>
    //    public SqlField HistroryNotes
    //    {
    //        get { return this["[HistroryNotes]"]; }
    //    }

    //    /// <summary>
    //    /// The PermissionToRepublishID table Field
    //    /// </summary>
    //    public SqlField PermissionToRepublishId
    //    {
    //        get { return this["[PermissionToRepublishID]"]; }
    //    }

    //    /// <summary>
    //    /// The CopyrightNotes table Field
    //    /// </summary>
    //    public SqlField CopyrightNotes
    //    {
    //        get { return this["[CopyrightNotes]"]; }
    //    }

    //    /// <summary>
    //    /// The OnlineHistroryNotes table Field
    //    /// </summary>
    //    public SqlField OnlineHistroryNotes
    //    {
    //        get { return this["[OnlineHistroryNotes]"]; }
    //    }

    //    /// <summary>
    //    /// The InactiveDate table Field
    //    /// </summary>
    //    public SqlField InactiveDate
    //    {
    //        get { return this["[InactiveDate]"]; }
    //    }

    //    /// <summary>
    //    /// The PublicationRevisionDate table Field
    //    /// </summary>
    //    public SqlField PublicationRevisionDate
    //    {
    //        get { return this["[PublicationRevisionDate]"]; }
    //    }

    //    /// <summary>
    //    /// The VersionAvailableDate table Field
    //    /// </summary>
    //    public SqlField VersionAvailableDate
    //    {
    //        get { return this["[VersionAvailableDate]"]; }
    //    }

    //    /// <summary>
    //    /// The FinalNasbaExpDate table Field
    //    /// </summary>
    //    public SqlField FinalNasbaExpDate
    //    {
    //        get { return this["[FinalNasbaExpDate]"]; }
    //    }

    //    /// <summary>
    //    /// The AuthorContentRevisionDate table Field
    //    /// </summary>
    //    public SqlField AuthorContentRevisionDate
    //    {
    //        get { return this["[AuthorContentRevisionDate]"]; }
    //    }

    //    /// <summary>
    //    /// The LastFullReadDate table Field
    //    /// </summary>
    //    public SqlField LastFullReadDate
    //    {
    //        get { return this["[LastFullReadDate]"]; }
    //    }

    //    /// <summary>
    //    /// The LastFullReadByID table Field
    //    /// </summary>
    //    public SqlField LastFullReadById
    //    {
    //        get { return this["[LastFullReadByID]"]; }
    //    }

    //    /// <summary>
    //    /// The ChangesForNextPublication table Field
    //    /// </summary>
    //    public SqlField ChangesForNextPublication
    //    {
    //        get { return this["[ChangesForNextPublication]"]; }
    //    }

    //    /// <summary>
    //    /// The DateCreated table Field
    //    /// </summary>
    //    public SqlField DateCreated
    //    {
    //        get { return this["[DateCreated]"]; }
    //    }

    //    /// <summary>
    //    /// The LastModifiedDate table Field
    //    /// </summary>
    //    public SqlField LastModifiedDate
    //    {
    //        get { return this["[LastModifiedDate]"]; }
    //    }

    //    /// <summary>
    //    /// The LastModifiedByID table Field
    //    /// </summary>
    //    public SqlField LastModifiedById
    //    {
    //        get { return this["[LastModifiedByID]"]; }
    //    }

    //    /// <summary>
    //    /// The CourseStatusID table Field
    //    /// </summary>
    //    public SqlField CourseStatusId
    //    {
    //        get { return this["[CourseStatusID]"]; }
    //    }

    //    /// <summary>
    //    /// The OnlineStatusID table Field
    //    /// </summary>
    //    public SqlField OnlineStatusId
    //    {
    //        get { return this["[OnlineStatusID]"]; }
    //    }

    //    /// <summary>
    //    /// The Outline table Field
    //    /// </summary>
    //    public SqlField Outline
    //    {
    //        get { return this["[Outline]"]; }
    //    }

    //    /// <summary>
    //    /// The Supplements table Field
    //    /// </summary>
    //    public SqlField Supplements
    //    {
    //        get { return this["[Supplements]"]; }
    //    }

    //    /// <summary>
    //    /// The MainGlossaryPool table Field
    //    /// </summary>
    //    public SqlField MainGlossaryPool
    //    {
    //        get { return this["[MainGlossaryPool]"]; }
    //    }

    //    /// <summary>
    //    /// The SubGlossaryPool table Field
    //    /// </summary>
    //    public SqlField SubGlossaryPool
    //    {
    //        get { return this["[SubGlossaryPool]"]; }
    //    }

    //    /// <summary>
    //    /// The InteractiveLearningID table Field
    //    /// </summary>
    //    public SqlField InteractiveLearningId
    //    {
    //        get { return this["[InteractiveLearningID]"]; }
    //    }

    //    /// <summary>
    //    /// The GuideShipDate table Field
    //    /// </summary>
    //    public SqlField GuideShipDate
    //    {
    //        get { return this["[GuideShipDate]"]; }
    //    }

    //    /// <summary>
    //    /// The LogoPath table Field
    //    /// </summary>
    //    public SqlField LogoPath
    //    {
    //        get { return this["[LogoPath]"]; }
    //    }

    //    /// <summary>
    //    /// The VersionDate table Field
    //    /// </summary>
    //    public SqlField VersionDate
    //    {
    //        get { return this["[VersionDate]"]; }
    //    }

    //    /// <summary>
    //    /// The VersionCreatedByID table Field
    //    /// </summary>
    //    public SqlField VersionCreatedById
    //    {
    //        get { return this["[VersionCreatedByID]"]; }
    //    }

    //    /// <summary>
    //    /// The VersionNote table Field
    //    /// </summary>
    //    public SqlField VersionNote
    //    {
    //        get { return this["[VersionNote]"]; }
    //    }

    //    /// <summary>
    //    /// The PlayerDemoChapters table Field
    //    /// </summary>
    //    public SqlField PlayerDemoChapters
    //    {
    //        get { return this["[PlayerDemoChapters]"]; }
    //    }

    //    /// <summary>
    //    /// The PlayerExamPosition table Field
    //    /// </summary>
    //    public SqlField PlayerExamPosition
    //    {
    //        get { return this["[PlayerExamPosition]"]; }
    //    }

    //    /// <summary>
    //    /// The PlayerSuppressRemediation table Field
    //    /// </summary>
    //    public SqlField PlayerSuppressRemediation
    //    {
    //        get { return this["[PlayerSuppressRemediation]"]; }
    //    }

    //    /// <summary>
    //    /// The PlayerTitleImagePath table Field
    //    /// </summary>
    //    public SqlField PlayerTitleImagePath
    //    {
    //        get { return this["[PlayerTitleImagePath]"]; }
    //    }

    //    /// <summary>
    //    /// The PlayerWelcomeImagePath table Field
    //    /// </summary>
    //    public SqlField PlayerWelcomeImagePath
    //    {
    //        get { return this["[PlayerWelcomeImagePath]"]; }
    //    }

    //    /// <summary>
    //    /// The PlayerCourseInfoImagePath table Field
    //    /// </summary>
    //    public SqlField PlayerCourseInfoImagePath
    //    {
    //        get { return this["[PlayerCourseInfoImagePath]"]; }
    //    }

    //    /// <summary>
    //    /// The NasbaDeliveryID table Field
    //    /// </summary>
    //    public SqlField NasbaDeliveryId
    //    {
    //        get { return this["[NasbaDeliveryID]"]; }
    //    }

    //    /// <summary>
    //    /// The DeliveryFormatID table Field
    //    /// </summary>
    //    public SqlField DeliveryFormatId
    //    {
    //        get { return this["[DeliveryFormatID]"]; }
    //    }

    //    /// <summary>
    //    /// The LastPromotionDate table Field
    //    /// </summary>
    //    public SqlField LastPromotionDate
    //    {
    //        get { return this["[LastPromotionDate]"]; }
    //    }

    //    /// <summary>
    //    /// The PlayerTitleWidth table Field
    //    /// </summary>
    //    public SqlField PlayerTitleWidth
    //    {
    //        get { return this["[PlayerTitleWidth]"]; }
    //    }

    //    /// <summary>
    //    /// The VersionCreatedBy table Field
    //    /// </summary>
    //    public SqlField VersionCreatedBy
    //    {
    //        get { return this["[VersionCreatedBy]"]; }
    //    }

    //    /// <summary>
    //    /// The ImportedLiveEventID table Field
    //    /// </summary>
    //    public SqlField ImportedLiveEventId
    //    {
    //        get { return this["[ImportedLiveEventID]"]; }
    //    }

    //    /// <summary>
    //    /// The AVORef table Field
    //    /// </summary>
    //    public SqlField Avoref
    //    {
    //        get { return this["[AVORef]"]; }
    //    }

    //    /// <summary>
    //    /// The AVOImageRef table Field
    //    /// </summary>
    //    public SqlField AvoimageRef
    //    {
    //        get { return this["[AVOImageRef]"]; }
    //    }

    //    /// <summary>
    //    /// The AVOAudioRef table Field
    //    /// </summary>
    //    public SqlField AvoaudioRef
    //    {
    //        get { return this["[AVOAudioRef]"]; }
    //    }

    //    /// <summary>
    //    /// The AVOPlayerRef table Field
    //    /// </summary>
    //    public SqlField AvoplayerRef
    //    {
    //        get { return this["[AVOPlayerRef]"]; }
    //    }

    //    /// <summary>
    //    /// The AVOLearningObjectives table Field
    //    /// </summary>
    //    public SqlField AvolearningObjectives
    //    {
    //        get { return this["[AVOLearningObjectives]"]; }
    //    }

    //    /// <summary>
    //    /// The NotifyCustomers table Field
    //    /// </summary>
    //    public SqlField NotifyCustomers
    //    {
    //        get { return this["[NotifyCustomers]"]; }
    //    }

    //    /// <summary>
    //    /// The WorkGroupID table Field
    //    /// </summary>
    //    public SqlField WorkGroupId
    //    {
    //        get { return this["[WorkGroupID]"]; }
    //    }

    //    /// <summary>
    //    /// The IsDynamicAssembled table Field
    //    /// </summary>
    //    public SqlField IsDynamicAssembled
    //    {
    //        get { return this["[IsDynamicAssembled]"]; }
    //    }

    //    /// <summary>
    //    /// The IsMasterCourse table Field
    //    /// </summary>
    //    public SqlField IsMasterCourse
    //    {
    //        get { return this["[IsMasterCourse]"]; }
    //    }

    //    /// <summary>
    //    /// The IsFeatureComingSoon table Field
    //    /// </summary>
    //    public SqlField IsFeatureComingSoon
    //    {
    //        get { return this["[IsFeatureComingSoon]"]; }
    //    }

    //    /// <summary>
    //    /// The IsIncludeIcon table Field
    //    /// </summary>
    //    public SqlField IsIncludeIcon
    //    {
    //        get { return this["[IsIncludeIcon]"]; }
    //    }

    //    /// <summary>
    //    /// The NoOfDays table Field
    //    /// </summary>
    //    public SqlField NoOfDays
    //    {
    //        get { return this["[NoOfDays]"]; }
    //    }

    //    /// <summary>
    //    /// The MediaDescription table Field
    //    /// </summary>
    //    public SqlField MediaDescription
    //    {
    //        get { return this["[MediaDescription]"]; }
    //    }

    //    /// <summary>
    //    /// The RelatedProducts table Field
    //    /// </summary>
    //    public SqlField RelatedProducts
    //    {
    //        get { return this["[RelatedProducts]"]; }
    //    }

    //    /// <summary>
    //    /// The AlternateFormats table Field
    //    /// </summary>
    //    public SqlField AlternateFormats
    //    {
    //        get { return this["[AlternateFormats]"]; }
    //    }

    //    /// <summary>
    //    /// The IsAccreditated table Field
    //    /// </summary>
    //    public SqlField IsAccreditated
    //    {
    //        get { return this["[IsAccreditated]"]; }
    //    }

    //    /// <summary>
    //    /// The ConferenceTotalCredits table Field
    //    /// </summary>
    //    public SqlField ConferenceTotalCredits
    //    {
    //        get { return this["[ConferenceTotalCredits]"]; }
    //    }

    //    /// <summary>
    //    /// The IsRedirectToLegacySite table Field
    //    /// </summary>
    //    public SqlField IsRedirectToLegacySite
    //    {
    //        get { return this["[IsRedirectToLegacySite]"]; }
    //    }

    //    /// <summary>
    //    /// The CourseTypeId table Field
    //    /// </summary>
    //    public SqlField CourseTypeId
    //    {
    //        get { return this["[CourseTypeId]"]; }
    //    }

    //    /// <summary>
    //    /// The NoOfQuestionsPerCreditHour table Field
    //    /// </summary>
    //    public SqlField NoOfQuestionsPerCreditHour
    //    {
    //        get { return this["[NoOfQuestionsPerCreditHour]"]; }
    //    }

    //    /// <summary>
    //    /// The PercentageQuestionsToBeAnswered table Field
    //    /// </summary>
    //    public SqlField PercentageQuestionsToBeAnswered
    //    {
    //        get { return this["[PercentageQuestionsToBeAnswered]"]; }
    //    }

    //    /// <summary>
    //    /// The CtecFederalTaxLawUpdateCredits table Field
    //    /// </summary>
    //    public SqlField CtecFederalTaxLawUpdateCredits
    //    {
    //        get { return this["[CtecFederalTaxLawUpdateCredits]"]; }
    //    }

    //    /// <summary>
    //    /// The CtecEthicsCredits table Field
    //    /// </summary>
    //    public SqlField CtecEthicsCredits
    //    {
    //        get { return this["[CtecEthicsCredits]"]; }
    //    }

    //    /// <summary>
    //    /// The CtecFederalNumber table Field
    //    /// </summary>
    //    public SqlField CtecFederalNumber
    //    {
    //        get { return this["[CtecFederalNumber]"]; }
    //    }

    //    /// <summary>
    //    /// The CtecCaNumber table Field
    //    /// </summary>
    //    public SqlField CtecCaNumber
    //    {
    //        get { return this["[CtecCaNumber]"]; }
    //    }

    //    /// <summary>
    //    /// The CtecFederalTaxLawUpdateNumber table Field
    //    /// </summary>
    //    public SqlField CtecFederalTaxLawUpdateNumber
    //    {
    //        get { return this["[CtecFederalTaxLawUpdateNumber]"]; }
    //    }

    //    /// <summary>
    //    /// The CtecEthicsNumber table Field
    //    /// </summary>
    //    public SqlField CtecEthicsNumber
    //    {
    //        get { return this["[CtecEthicsNumber]"]; }
    //    }

    //    /// <summary>
    //    /// The IrsCourse table Field
    //    /// </summary>
    //    public SqlField IrsCourse
    //    {
    //        get { return this["[IrsCourse]"]; }
    //    }

    //    /// <summary>
    //    /// The IrsRtrpCourse table Field
    //    /// </summary>
    //    public SqlField IrsRtrpCourse
    //    {
    //        get { return this["[IrsRtrpCourse]"]; }
    //    }

    //    /// <summary>
    //    /// The IrsEaCourse table Field
    //    /// </summary>
    //    public SqlField IrsEaCourse
    //    {
    //        get { return this["[IrsEaCourse]"]; }
    //    }

    //    /// <summary>
    //    /// The IrsRtrpEthicsCredits table Field
    //    /// </summary>
    //    public SqlField IrsRtrpEthicsCredits
    //    {
    //        get { return this["[IrsRtrpEthicsCredits]"]; }
    //    }

    //    /// <summary>
    //    /// The IrsRtrpFederalTaxUpdateCredits table Field
    //    /// </summary>
    //    public SqlField IrsRtrpFederalTaxUpdateCredits
    //    {
    //        get { return this["[IrsRtrpFederalTaxUpdateCredits]"]; }
    //    }

    //    /// <summary>
    //    /// The IrsRtrpFederalTaxCredits table Field
    //    /// </summary>
    //    public SqlField IrsRtrpFederalTaxCredits
    //    {
    //        get { return this["[IrsRtrpFederalTaxCredits]"]; }
    //    }

    //    /// <summary>
    //    /// The IrsRtrpTestPreparationCredits table Field
    //    /// </summary>
    //    public SqlField IrsRtrpTestPreparationCredits
    //    {
    //        get { return this["[IrsRtrpTestPreparationCredits]"]; }
    //    }

    //    /// <summary>
    //    /// The IrsEaEthicsCredits table Field
    //    /// </summary>
    //    public SqlField IrsEaEthicsCredits
    //    {
    //        get { return this["[IrsEaEthicsCredits]"]; }
    //    }

    //    /// <summary>
    //    /// The IrsEaFederalTaxMattersCredits table Field
    //    /// </summary>
    //    public SqlField IrsEaFederalTaxMattersCredits
    //    {
    //        get { return this["[IrsEaFederalTaxMattersCredits]"]; }
    //    }

    //    /// <summary>
    //    /// The IrsRtrpEthicsNum table Field
    //    /// </summary>
    //    public SqlField IrsRtrpEthicsNum
    //    {
    //        get { return this["[IrsRtrpEthicsNum]"]; }
    //    }

    //    /// <summary>
    //    /// The IrsRtrpFederalTaxUpdateNum table Field
    //    /// </summary>
    //    public SqlField IrsRtrpFederalTaxUpdateNum
    //    {
    //        get { return this["[IrsRtrpFederalTaxUpdateNum]"]; }
    //    }

    //    /// <summary>
    //    /// The IrsRtrpFederalTaxNum table Field
    //    /// </summary>
    //    public SqlField IrsRtrpFederalTaxNum
    //    {
    //        get { return this["[IrsRtrpFederalTaxNum]"]; }
    //    }

    //    /// <summary>
    //    /// The IrsRtrpTestPreparationNum table Field
    //    /// </summary>
    //    public SqlField IrsRtrpTestPreparationNum
    //    {
    //        get { return this["[IrsRtrpTestPreparationNum]"]; }
    //    }

    //    /// <summary>
    //    /// The IrsEaEthicsNum table Field
    //    /// </summary>
    //    public SqlField IrsEaEthicsNum
    //    {
    //        get { return this["[IrsEaEthicsNum]"]; }
    //    }

    //    /// <summary>
    //    /// The IrsEaFederalTaxMattersNum table Field
    //    /// </summary>
    //    public SqlField IrsEaFederalTaxMattersNum
    //    {
    //        get { return this["[IrsEaFederalTaxMattersNum]"]; }
    //    }

    //    /// <summary>
    //    /// The CfpCreditsOverRide table Field
    //    /// </summary>
    //    public SqlField CfpCreditsOverRide
    //    {
    //        get { return this["[CfpCreditsOverRide]"]; }
    //    }

    //    /// <summary>
    //    /// The ComingSoon table Field
    //    /// </summary>
    //    public SqlField ComingSoon
    //    {
    //        get { return this["[ComingSoon]"]; }
    //    }

    //    /// <summary>
    //    /// The ComingSoonDate table Field
    //    /// </summary>
    //    public SqlField ComingSoonDate
    //    {
    //        get { return this["[ComingSoonDate]"]; }
    //    }

    //    /// <summary>
    //    /// The DisplayIconID table Field
    //    /// </summary>
    //    public SqlField DisplayIconId
    //    {
    //        get { return this["[DisplayIconID]"]; }
    //    }

    //    /// <summary>
    //    /// The DisplayIconDurationID table Field
    //    /// </summary>
    //    public SqlField DisplayIconDurationId
    //    {
    //        get { return this["[DisplayIconDurationID]"]; }
    //    }

    //    /// <summary>
    //    /// The DisplayIconDate table Field
    //    /// </summary>
    //    public SqlField DisplayIconDate
    //    {
    //        get { return this["[DisplayIconDate]"]; }
    //    }

    //    /// <summary>
    //    /// The RetiredDate table Field
    //    /// </summary>
    //    public SqlField RetiredDate
    //    {
    //        get { return this["[RetiredDate]"]; }
    //    }

    //    /// <summary>
    //    /// The RetiredUserID table Field
    //    /// </summary>
    //    public SqlField RetiredUserId
    //    {
    //        get { return this["[RetiredUserID]"]; }
    //    }

    //    /// <summary>
    //    /// The FixedExpireDate table Field
    //    /// </summary>
    //    public SqlField FixedExpireDate
    //    {
    //        get { return this["[FixedExpireDate]"]; }
    //    }

    //    /// <summary>
    //    /// The FixedExpireUserID table Field
    //    /// </summary>
    //    public SqlField FixedExpireUserId
    //    {
    //        get { return this["[FixedExpireUserID]"]; }
    //    }

    //    /// <summary>
    //    /// The VersionCategoryID table Field
    //    /// </summary>
    //    public SqlField VersionCategoryId
    //    {
    //        get { return this["[VersionCategoryID]"]; }
    //    }

    //    /// <summary>
    //    /// The SubscriptionExpirationDate table Field
    //    /// </summary>
    //    public SqlField SubscriptionExpirationDate
    //    {
    //        get { return this["[SubscriptionExpirationDate]"]; }
    //    }

    //    /// <summary>
    //    /// The CustomBannerName table Field
    //    /// </summary>
    //    public SqlField CustomBannerName
    //    {
    //        get { return this["[CustomBannerName]"]; }
    //    }

    //    /// <summary>
    //    /// The HasCustomBanner table Field
    //    /// </summary>
    //    public SqlField HasCustomBanner
    //    {
    //        get { return this["[HasCustomBanner]"]; }
    //    }

    //    /// <summary>
    //    /// The CustomBannerImage table Field
    //    /// </summary>
    //    public SqlField CustomBannerImage
    //    {
    //        get { return this["[CustomBannerImage]"]; }
    //    }

    //    /// <summary>
    //    /// The PrivateLabelLogoName table Field
    //    /// </summary>
    //    public SqlField PrivateLabelLogoName
    //    {
    //        get { return this["[PrivateLabelLogoName]"]; }
    //    }

    //    /// <summary>
    //    /// The PrivateLabelLogoImage table Field
    //    /// </summary>
    //    public SqlField PrivateLabelLogoImage
    //    {
    //        get { return this["[PrivateLabelLogoImage]"]; }
    //    }

    //    /// <summary>
    //    /// The TimerExpired table Field
    //    /// </summary>
    //    public SqlField TimerExpired
    //    {
    //        get { return this["[TimerExpired]"]; }
    //    }


    //    /// <summary>
    //    /// Adds an inner join relationship with the table, CourseTable
    //    /// </summary>
    //    public CourseTable JoinCourseTable(QueryBase query)
    //    {
    //        CourseTable courseTable = new CourseTable();
    //        query.InnerJoin(courseTable, this.CourseMetadataId, courseTable.CourseMetadataId);
    //        return courseTable;
    //    }

    //    /// <summary>
    //    /// Adds a left outer join relationship with the table, CourseTable
    //    /// </summary>
    //    public CourseTable OuterJoinCourseTable(QueryBase query)
    //    {
    //        CourseTable courseTable = new CourseTable();
    //        query.LeftOuterJoin(courseTable, this.CourseMetadataId, courseTable.CourseMetadataId);
    //        return courseTable;
    //    }

    //    /// <summary>
    //    /// Adds an inner join relationship with the table, OgsExamTable
    //    /// </summary>
    //    public OgsExamTable JoinOgsExamTable(QueryBase query)
    //    {
    //        OgsExamTable ogsExamTable = new OgsExamTable();
    //        query.InnerJoin(ogsExamTable, this.CourseMetadataId, ogsExamTable.CourseMetadataId);
    //        return ogsExamTable;
    //    }

    //    /// <summary>
    //    /// Adds a left outer join relationship with the table, OgsExamTable
    //    /// </summary>
    //    public OgsExamTable OuterJoinOgsExamTable(QueryBase query)
    //    {
    //        OgsExamTable ogsExamTable = new OgsExamTable();
    //        query.LeftOuterJoin(ogsExamTable, this.CourseMetadataId, ogsExamTable.CourseMetadataId);
    //        return ogsExamTable;
    //    }

    //    /// <summary>
    //    /// Adds an inner join relationship with the table, ScheduleTable
    //    /// </summary>
    //    public ScheduleTable JoinScheduleTable(QueryBase query)
    //    {
    //        ScheduleTable scheduleTable = new ScheduleTable();
    //        query.InnerJoin(scheduleTable, this.CourseMetadataId, scheduleTable.CourseMetadataId);
    //        return scheduleTable;
    //    }

    //    /// <summary>
    //    /// Adds a left outer join relationship with the table, ScheduleTable
    //    /// </summary>
    //    public ScheduleTable OuterJoinScheduleTable(QueryBase query)
    //    {
    //        ScheduleTable scheduleTable = new ScheduleTable();
    //        query.LeftOuterJoin(scheduleTable, this.CourseMetadataId, scheduleTable.CourseMetadataId);
    //        return scheduleTable;
    //    }

    //    /// <summary>
    //    /// Adds an inner join relationship with the table, CourseInstanceTable
    //    /// </summary>
    //    public CourseInstanceTable JoinCourseInstanceTable(QueryBase query)
    //    {
    //        CourseInstanceTable courseInstanceTable = new CourseInstanceTable();
    //        query.InnerJoin(courseInstanceTable, this.CourseMetadataId, courseInstanceTable.CourseMetadataId);
    //        return courseInstanceTable;
    //    }

    //    /// <summary>
    //    /// Adds a left outer join relationship with the table, CourseInstanceTable
    //    /// </summary>
    //    public CourseInstanceTable OuterJoinCourseInstanceTable(QueryBase query)
    //    {
    //        CourseInstanceTable courseInstanceTable = new CourseInstanceTable();
    //        query.LeftOuterJoin(courseInstanceTable, this.CourseMetadataId, courseInstanceTable.CourseMetadataId);
    //        return courseInstanceTable;
    //    }

    //    /// <summary>
    //    /// Adds an inner join relationship with the table, LiveEventSeminarTopicTable
    //    /// </summary>
    //    public LiveEventSeminarTopicTable JoinLiveEventSeminarTopicTable(QueryBase query)
    //    {
    //        LiveEventSeminarTopicTable liveEventSeminarTopicTable = new LiveEventSeminarTopicTable();
    //        query.InnerJoin(liveEventSeminarTopicTable, this.CourseMetadataId, liveEventSeminarTopicTable.CourseMetadataId);
    //        return liveEventSeminarTopicTable;
    //    }

    //    /// <summary>
    //    /// Adds a left outer join relationship with the table, LiveEventSeminarTopicTable
    //    /// </summary>
    //    public LiveEventSeminarTopicTable OuterJoinLiveEventSeminarTopicTable(QueryBase query)
    //    {
    //        LiveEventSeminarTopicTable liveEventSeminarTopicTable = new LiveEventSeminarTopicTable();
    //        query.LeftOuterJoin(liveEventSeminarTopicTable, this.CourseMetadataId, liveEventSeminarTopicTable.CourseMetadataId);
    //        return liveEventSeminarTopicTable;
    //    }

    //    /// <summary>
    //    /// Adds an inner join relationship with the table, BrandTable
    //    /// </summary>
    //    public BrandTable JoinBrandTable(QueryBase query)
    //    {
    //        BrandTable brandTable = new BrandTable();
    //        query.InnerJoin(brandTable, this.BrandId, brandTable.BrandId);
    //        return brandTable;
    //    }

    //    /// <summary>
    //    /// Adds a left outer join relationship with the table, BrandTable
    //    /// </summary>
    //    public BrandTable OuterJoinBrandTable(QueryBase query)
    //    {
    //        BrandTable brandTable = new BrandTable();
    //        query.LeftOuterJoin(brandTable, this.BrandId, brandTable.BrandId);
    //        return brandTable;
    //    }

    //    /// <summary>
    //    /// Adds an inner join relationship with the table, CourseStatusTable
    //    /// </summary>
    //    public CourseStatusTable JoinCourseStatusTable(QueryBase query)
    //    {
    //        CourseStatusTable courseStatusTable = new CourseStatusTable();
    //        query.InnerJoin(courseStatusTable, this.CourseStatusId, courseStatusTable.CourseStatusId);
    //        return courseStatusTable;
    //    }

    //    /// <summary>
    //    /// Adds a left outer join relationship with the table, CourseStatusTable
    //    /// </summary>
    //    public CourseStatusTable OuterJoinCourseStatusTable(QueryBase query)
    //    {
    //        CourseStatusTable courseStatusTable = new CourseStatusTable();
    //        query.LeftOuterJoin(courseStatusTable, this.CourseStatusId, courseStatusTable.CourseStatusId);
    //        return courseStatusTable;
    //    }

    //    /// <summary>
    //    /// Adds an inner join relationship with the table, DeliveryFormatTable
    //    /// </summary>
    //    public DeliveryFormatTable JoinDeliveryFormatTable(QueryBase query)
    //    {
    //        DeliveryFormatTable deliveryFormatTable = new DeliveryFormatTable();
    //        query.InnerJoin(deliveryFormatTable, this.DeliveryFormatId, deliveryFormatTable.DeliveryFormatId);
    //        return deliveryFormatTable;
    //    }

    //    /// <summary>
    //    /// Adds a left outer join relationship with the table, DeliveryFormatTable
    //    /// </summary>
    //    public DeliveryFormatTable OuterJoinDeliveryFormatTable(QueryBase query)
    //    {
    //        DeliveryFormatTable deliveryFormatTable = new DeliveryFormatTable();
    //        query.LeftOuterJoin(deliveryFormatTable, this.DeliveryFormatId, deliveryFormatTable.DeliveryFormatId);
    //        return deliveryFormatTable;
    //    }

    //    /// <summary>
    //    /// Adds an inner join relationship with the table, ResourceTable
    //    /// </summary>
    //    public ResourceTable JoinResourceTable(QueryBase query)
    //    {
    //        ResourceTable resourceTable = new ResourceTable();
    //        query.InnerJoin(resourceTable, this.LastFullReadById, resourceTable.ResourceId);
    //        return resourceTable;
    //    }

    //    /// <summary>
    //    /// Adds a left outer join relationship with the table, ResourceTable
    //    /// </summary>
    //    public ResourceTable OuterJoinResourceTable(QueryBase query)
    //    {
    //        ResourceTable resourceTable = new ResourceTable();
    //        query.LeftOuterJoin(resourceTable, this.LastFullReadById, resourceTable.ResourceId);
    //        return resourceTable;
    //    }

    //    /// <summary>
    //    /// Adds an inner join relationship with the table, NasbaLearningLevelTable
    //    /// </summary>
    //    public NasbaLearningLevelTable JoinNasbaLearningLevelTable(QueryBase query)
    //    {
    //        NasbaLearningLevelTable nasbaLearningLevelTable = new NasbaLearningLevelTable();
    //        query.InnerJoin(nasbaLearningLevelTable, this.LearningLevelId, nasbaLearningLevelTable.LearningLevelId);
    //        return nasbaLearningLevelTable;
    //    }

    //    /// <summary>
    //    /// Adds a left outer join relationship with the table, NasbaLearningLevelTable
    //    /// </summary>
    //    public NasbaLearningLevelTable OuterJoinNasbaLearningLevelTable(QueryBase query)
    //    {
    //        NasbaLearningLevelTable nasbaLearningLevelTable = new NasbaLearningLevelTable();
    //        query.LeftOuterJoin(nasbaLearningLevelTable, this.LearningLevelId, nasbaLearningLevelTable.LearningLevelId);
    //        return nasbaLearningLevelTable;
    //    }

    //    /// <summary>
    //    /// Adds an inner join relationship with the table, NasbaDeliveryTable
    //    /// </summary>
    //    public NasbaDeliveryTable JoinNasbaDeliveryTable(QueryBase query)
    //    {
    //        NasbaDeliveryTable nasbaDeliveryTable = new NasbaDeliveryTable();
    //        query.InnerJoin(nasbaDeliveryTable, this.NasbaDeliveryId, nasbaDeliveryTable.NasbaDeliveryId);
    //        return nasbaDeliveryTable;
    //    }

    //    /// <summary>
    //    /// Adds a left outer join relationship with the table, NasbaDeliveryTable
    //    /// </summary>
    //    public NasbaDeliveryTable OuterJoinNasbaDeliveryTable(QueryBase query)
    //    {
    //        NasbaDeliveryTable nasbaDeliveryTable = new NasbaDeliveryTable();
    //        query.LeftOuterJoin(nasbaDeliveryTable, this.NasbaDeliveryId, nasbaDeliveryTable.NasbaDeliveryId);
    //        return nasbaDeliveryTable;
    //    }

    //    /// <summary>
    //    /// Adds an inner join relationship with the table, CourseNasbaCreditsTable
    //    /// </summary>
    //    public CourseNasbaCreditsTable JoinCourseNasbaCreditsTable(QueryBase query)
    //    {
    //        CourseNasbaCreditsTable courseNasbaCreditsTable = new CourseNasbaCreditsTable();
    //        query.InnerJoin(courseNasbaCreditsTable, this.CourseMetadataId, courseNasbaCreditsTable.CourseMetadataId);
    //        return courseNasbaCreditsTable;
    //    }

    //    /// <summary>
    //    /// Adds a left outer join relationship with the table, CourseNasbaCreditsTable
    //    /// </summary>
    //    public CourseNasbaCreditsTable OuterJoinCourseNasbaCreditsTable(QueryBase query)
    //    {
    //        CourseNasbaCreditsTable courseNasbaCreditsTable = new CourseNasbaCreditsTable();
    //        query.LeftOuterJoin(courseNasbaCreditsTable, this.CourseMetadataId, courseNasbaCreditsTable.CourseMetadataId);
    //        return courseNasbaCreditsTable;
    //    }
    //}
}
