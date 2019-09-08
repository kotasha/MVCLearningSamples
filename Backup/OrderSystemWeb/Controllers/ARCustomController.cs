using Kotacs.Libraries.SOA.Contracts.Services;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Kotacs.Libraries.Web.Extensibility;
namespace OrderSystemWeb.Controllers
{

    //[KotacsLogActionFilterAttribute(LogFormat=@"{0}-{1}-{2}",Message="HomeController",LogToResponseBuffer=true)]
    public class ARCustomController : KotacsControllerBase
    {
        // GET: /ARCustom/
        private ICustomerService customerservice= default(ICustomerService);
        public ARCustomController(ICustomerService customerservice)
        {
            this.customerservice = customerservice;
        }
        //[KotacsLogActionFilterAttribute(LogFormat = @"{0}-{1}-{2}", Message = "IndexAction", LogToResponseBuffer = true)]
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult AllCustomers()
        {
            if (customerservice != default(ICustomerService))
            {
                var customers = customerservice.GetAllCustomers();
                return Json(customers, JsonRequestBehavior.AllowGet);
            }
            return View(viewName: "Error");
        }
        [ActionName("Stock")]
        public ActionResult GetCurrentStock(string Customerid)
        {
            var data = string.Format(@"Customer {0} Stock Value is {1}", Customerid, new Random().Next(200));

            var scriptOutput = string.Format("javacript:processResult('{0}')", data);

            return JavaScript(scriptOutput);
        }
        [ActionName("Specification")]
        public ActionResult GetCustomerSpecification(string Customerid)
        {
            if (string.IsNullOrEmpty(Customerid))
                throw new ArgumentException("Invalid CustomeId Specified");
            var fileId= string.Format(@"{0}\Customer SRS ({1}).docx", ConfigurationManager.AppSettings["DocumentsFolder"],Customerid);
            if(string.IsNullOrEmpty(fileId))
                throw new ArgumentException("Invalid File Id Found!");
            var fileBytes= System.IO.File.ReadAllBytes(fileId);
            var mimeType="application/vnd.openxmlformats-officedocument.wordprocessingml.document";
            var downloadName = string.Format(@"{0}-{1}.docx",Customerid, Guid.NewGuid().ToString());

            return File(fileBytes,mimeType,downloadName);
        }

        [ActionName("Video")]
        public ActionResult GetCustomerMediaContents(string Customerid)
        {
            if (string.IsNullOrEmpty(Customerid))
                throw new ArgumentException("Invalid Customer ID Specified!");

            var fileId = string.Format(@"{0}\Customer Talk ({1}).wmv",
                ConfigurationManager.AppSettings["VideosFolder"], Customerid);

            if (string.IsNullOrEmpty(fileId) || !System.IO.File.Exists(fileId))
                throw new ArgumentException("Invalid File Id Found!");
            //var fileStream = System.IO.File.OpenRead("D:\\Personal\\SelfPractice\\MVCCaseStudy\\Resources\\Videos\\Customer Talk (C100011).wmv");
            //if(System.IO.File.Exists(fileId))
            var  fileStream = System.IO.File.OpenRead(fileId);
            //else
            //fileStream=System.IO.File.OpenRead("D:\\Personal\\SelfPractice\\MVCCaseStudy\\Resources\\Videos\\Customer Talk (C100011).wmv");
            var mimeType="video/x-ms-wmv";
            var downloadName= string.Format(@"{0}-{1}.wmv",Customerid,Guid.NewGuid().ToString());

            return File(fileStream, mimeType);
        }
    }
}
