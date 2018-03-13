using Kotacs.Libraries.Web.Extensibility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.SessionState;
namespace OrderSystemWeb.Controllers
{
    [SessionState(SessionStateBehavior.Disabled)]
    public class RedirectController : KotacsControllerBase
    {
        //
        // GET: /Redirect/
       
        public ActionResult Index()
        {
            ViewData["IndexViewData"] = "From Index Action ViewData";
            ViewBag.ViewBagIndexMessage = "From Index Action ViewBag";
            TempData["IndexViewTempData"] = "From Index Action Temp ViewData";
            return View();
        }
        public ActionResult Action2()
        {
            ViewData["Action2ViewData"] = "From Action2 Action ViewData";
            ViewBag.ViewBagAction2Message = "From Action2 Action ViewBag";
            TempData["Action2ViewTempData"] = "From Action2 Action Temp ViewData";
            return RedirectToAction("Index");
        }
        //demonstrate the Action3 view cannot hold TempData (Peek) as it will be flagged to deletable in Action2, so will make use of Peek() to read and extend one more time
        
        public ActionResult Action3()
        {
            return View();
        }
    }
}
