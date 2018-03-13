using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OrderSystemWeb.Controllers
{
    public class TestController : KotacsControllerBase
    {
        //
        // GET: /Test/

        public ActionResult Index()
        {
            return View();
        }

    }
}
