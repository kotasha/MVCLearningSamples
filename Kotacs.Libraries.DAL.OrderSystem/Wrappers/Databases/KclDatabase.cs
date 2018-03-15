using System;
using System.Collections.Generic;
using System.Text;

namespace Kotacs.Libraries.DAL.OrderSystem.Wrappers.Databases
{

        public partial class CplDatabase : Database
        {
            //public EmployeeTable SetEmployeeTable(QueryBase query)
            //{
            //  EmployeeTable table = new EmployeeTable();
            //  query.AddTable(table);
            //  return table;
            //}

            //public OrganizationTable SetOrganizationTable(QueryBase query)
            //{
            //  OrganizationTable table = new OrganizationTable();
            //  query.AddTable(table);
            //  return table;
            //}


            //public CourseInstanceTable SetCourseInstanceTable(QueryBase query)
            //{
            //    CourseInstanceTable table = new CourseInstanceTable();
            //    query.AddTable(table);
            //    return table;
            //}

            //public ScheduleTable SetScheduleTable(QueryBase query)
            //{
            //    ScheduleTable table = new ScheduleTable();
            //    query.AddTable(table);
            //    return table;
            //}


            /// <summary>
            /// Set CourseMetadata Table
            /// </summary>
            /// <param name="query">QueryBase</param>
            /// <returns>CourseMetadataTable</returns>
            //public CourseMetadataTable SetCourseMetadataTable(QueryBase query)
            //{
            //    CourseMetadataTable table = new CourseMetadataTable();
            //    query.AddTable(table);
            //    return table;
            //}


            //public LiveEventOrderTable SetLiveEventOrder(QueryBase query)
            //{
            //    LiveEventOrderTable table = new LiveEventOrderTable();
            //    query.AddTable(table);
            //    return table;

            //}


            //public CourseNasbaCreditsTable SetCourseNasbaCreditTable(QueryBase query)
            //{
            //    CourseNasbaCreditsTable table = new CourseNasbaCreditsTable();
            //    query.AddTable(table);
            //    return table;
            //}


            //public ScheduleLocationTable SetScheduleLocationTable(QueryBase query)
            //{
            //    ScheduleLocationTable table = new ScheduleLocationTable();
            //    query.AddTable(table);
            //    return table;
            //}

            /// <summary>
            /// Set NasbaFosidTable
            /// </summary>
            /// <param name="query"></param>
            /// <returns>NasbaFosidTable</returns>
            //public NasbaFieldOfStudyTable SetNasbaFieldOfStudyTable(QueryBase query)
            //{
            //  NasbaFieldOfStudyTable table = new NasbaFieldOfStudyTable();
            //  query.AddTable(table);
            //  return table;
            //}

            //public TimeZoneTable SetTimeZoneTable(QueryBase query)
            //{
            //  TimeZoneTable table = new TimeZoneTable();
            //  query.AddTable(table);
            //  return table;
            //}

            //public StateTable SetStateTable(QueryBase query)
            //{
            //  StateTable table = new StateTable();
            //  query.AddTable(table);
            //  return table;
            //}

            ///// <summary>
            ///// set course status table 
            ///// </summary>
            ///// <param name="query">QueryBase type quary</param>
            ///// <returns>CourseStatusTable as table</returns>
            //public CourseStatusTable SetCourseStatusTable(QueryBase query)
            //{
            //  CourseStatusTable table = new CourseStatusTable();
            //  query.AddTable(table);
            //  return table;
            //}

            /// <summary>
            /// set brand table
            ///// </summary>
            ///// <param name="query">query QueryBase</param>
            ///// <returns>brandTable as table</returns>
            //public BrandTable SetBrandTable(QueryBase query)
            //{
            //  BrandTable table = new BrandTable();
            //  query.AddTable(table);
            //  return table;
            //}


            //public DeliveryFormatTable SetDeliveryFormatTable(QueryBase query)
            //{
            //  DeliveryFormatTable table = new DeliveryFormatTable();
            //  query.AddTable(table);
            //  return table;
            //}

            ///// <summary>
            ///// set college table
            ///// </summary>
            ///// <param name="query"></param>
            ///// <returns>College table as table</returns>
            //public CollegeTable SetCollegeTable(QueryBase query)
            //{
            //  CollegeTable table = new CollegeTable();
            //  query.AddTable(table);
            //  return table;
            //}

            ///// <summary>
            ///// set nasbaDeliveruformatId
            ///// </summary>
            ///// <param name="query">QueryBase as query builder</param>
            ///// <returns>NasbaDeliveryFormatTable as table</returns>
            //public NasbaDeliveryFormatTable SetNasbaDeliveryFormatTable(QueryBase query)
            //{
            //  NasbaDeliveryFormatTable table = new NasbaDeliveryFormatTable();
            //  query.AddTable(table);
            //  return table;
            //}

            /// <summary>
            /// set MediaFormatTable
            /// </summary>
            /// <param name="query"></param>
            /// <returns></returns>
            //public MediaFormatTable SetMediaFormatTable(QueryBase query)
            //{
            //  MediaFormatTable table = new MediaFormatTable();
            //  query.AddTable(table);
            //  return table;
            //}

            /// <summary>
            /// set NasbaLearningLevel Table
            /// </summary>
            /// <param name="query">query QueryBase</param>
            /// <returns>NasbaLearningLevelTable as table</returns>
            //public NasbaLearningLevelTable SetNasbaLearningLevelTable(QueryBase query)
            //{
            //  NasbaLearningLevelTable table = new NasbaLearningLevelTable();
            //  query.AddTable(table);
            //  return table;
            //}

            //public ProductMetadataForLiveEventsTable SetProductMetadataForLiveEventsTable(QueryBase query)
            //{
            //    ProductMetadataForLiveEventsTable table = new ProductMetadataForLiveEventsTable();
            //    query.AddTable(table);
            //    return table;
            //}


            //public LiveEventBrandCollegeTable SetLiveEventBrandCollegeTable(QueryBase query)
            //{
            //  LiveEventBrandCollegeTable table = new LiveEventBrandCollegeTable();
            //  query.AddTable(table);
            //  return table;
            //}

            //public TrtaApplicationTable SetApplicationTable(QueryBase query)
            //{
            //    TrtaApplicationTable table = new TrtaApplicationTable();
            //    query.AddTable(table);
            //    return table;
            //}

            //public ProfessionalTable SetProfessionalTable(QueryBase query)
            //{
            //  ProfessionalTable table = new ProfessionalTable();
            //  query.AddTable(table);
            //  return table;
            //}

            /// <summary>
            /// Sets PickNBundleReportData Table
            /// </summary>
            /// <param name="query">QueryBase</param>
            /// <returns>PickNBundleReportDataTable</returns>
            //public PickNBundleReportDataTable SetPickNBundleReportDataTable(QueryBase query)
            //{
            //    PickNBundleReportDataTable table = new PickNBundleReportDataTable();
            //    query.AddTable(table);
            //    return table;
            //}

            /// <summary>
            /// Adds an instance of <see cref="OrganizationStringMapTable"/> table to the query builder
            /// passed into the method.
            /// </summary>
            /// <param name="query"><see cref="QueryBase"/> on to which the table should be added.</param>
            /// <returns>The instance of <see cref="OrganizationStringMapTable"/> that got added to 
            /// the query base instance.</returns>
            //public OrganizationStringMapTable SetOrganizationStringMapTable(QueryBase query)
            //{
            //    OrganizationStringMapTable table = new OrganizationStringMapTable();
            //    query.AddTable(table);
            //    return table;
            //}

            /// <summary>
            /// Add instance of OgsExamView view
            /// </summary>
            /// <param name="query">QueryBase</param>
            /// <returns>instance of OgsExamView</returns>
            //public OgsExamView SetOgsExamView(QueryBase query)
            //{
            //    OgsExamView table = new OgsExamView();
            //    query.AddTable(table);
            //    return table;
            //}

            /// <summary>
            /// Sets CoursesOrderedReportData Table
            /// </summary>
            /// <param name="query">QueryBase</param>
            /// <returns>CoursesOrderedReportDataTable</returns>
            //public CoursesOrderedReportDataTable SetCoursesOrderedReportDataTable(QueryBase query)
            //{
            //  CoursesOrderedReportDataTable table = new CoursesOrderedReportDataTable();
            //  query.AddTable(table);
            //  return table;
            //}

            /// <summary>
            /// Add an instance of a ProductReconciliationCplProductDetailsView to the query
            /// </summary>
            /// <param name="query"></param>
            /// <returns></returns>
            //public ProductReconciliationCplProductDetailsView SetProductReconciliationCplProductDetailsView(QueryBase query)
            //{
            //    ProductReconciliationCplProductDetailsView view = new ProductReconciliationCplProductDetailsView();
            //    query.AddTable(view);

            //    return view;
            //}

            /// <summary>
            /// Set LiveEventProductTable
            /// </summary>
            /// <param name="query"></param>
            /// <returns>Instance of LiveEventProductTable</returns>
            //public LiveEventProductTable SetLiveEventProductTable(QueryBase query)
            //{
            //  LiveEventProductTable table = new LiveEventProductTable();
            //  query.AddTable(table);
            //  return table;
            //}

            /// <summary>
            ///// Set LocationTable
            ///// </summary>
            ///// <param name="query"></param>
            ///// <returns>Instance of LocationTable</returns>
            //public LocationTable SetLocationTable(QueryBase query)
            //{
            //  LocationTable table = new LocationTable();
            //  query.AddTable(table);
            //  return table;
            //}

            /// <summary>
            /// Set HotelTable
            /// </summary>
            /// <param name="query"></param>
            /// <returns>Instance of HotelTable</returns>
            //public HotelTable SetHotelTable(QueryBase query)
            //{
            //  HotelTable table = new HotelTable();
            //  query.AddTable(table);
            //  return table;
            //}

            /// <summary>
            /// Add the ConferenceSetupSearchView View to the Database
            /// </summary>
            /// <param name="query">QueryBase</param>
            /// <returns>Instance of ConferenceSetupSearchView</returns>
            //public ConferenceSetupSearchView SetConferenceSetupSearchView(QueryBase query)
            //{
            //    //Create new table
            //    ConferenceSetupSearchView table = new ConferenceSetupSearchView();
            //    //Add the table to the query
            //    query.AddTable(table);

            //    return table;
            //}

            /// <summary>
            /// Set SocietyTable
            /// </summary>
            /// <param name="query">Select Query</param>
            /// <returns>An instance of SocietyTable</returns>
            //public SocietyTable SetSocietyTable(QueryBase query)
            //{
            //  SocietyTable table = new SocietyTable();
            //  query.AddTable(table);
            //  return table;
            //}

            /// <summary>
            /// Set CourseInstanceProfessional Table
            /// </summary>
            /// <param name="query"></param>
            /// <returns>An instance of CourseInstanceProfessionalTable</returns>
            //public CourseInstanceProfessionalTable SetCourseInstanceProfessionalTable(QueryBase query)
            //{
            //    //Create new table
            //    CourseInstanceProfessionalTable table = new CourseInstanceProfessionalTable();
            //    //Add the table to the query
            //    query.AddTable(table);

            //    return table;
            //}

            /// <summary>
            /// Add Stored Procedure
            /// </summary>
            /// <param name="query">the input query</param>
            /// <param name="storedProcedureName">the stored procedure name</param>
            public void AddStoredProcedure(QueryBase query, string storedProcedureName)
            {
                query.AddStoredProcedure(storedProcedureName);
            }


            /// <summary>
            /// Constructor overload to create CourseInstance Table with user defined alias
            /// </summary>
            /// <param name="query"></param>
            /// <param name="alias"></param>
            /// <returns></returns>
            //public CourseInstanceTable SetCourseInstanceTableWithSpecificAlias(QueryBase query, string alias)
            //{
            //    CourseInstanceTable table = new CourseInstanceTable(alias);
            //    query.AddTable(table);
            //    return table;
            //}
        }
   
}