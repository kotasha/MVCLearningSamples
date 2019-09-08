using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OrderSystemWeb.Controllers
{
    public class HomeController : KotacsControllerBase
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            ViewBag.Message = "Welcome to Kotacs Order System";
            return View();
        }
        public ActionResult Show()
        {
            return View();
        }
        public ActionResult Process(string id)
        {
            var cookie = new HttpCookie(COOKIE_NAME, id)
            {
                Secure = false,
                HttpOnly = true
            };

            HttpContext.Response.Cookies.Add(cookie);

            return View();
        }

        private const string COOKIE_NAME = "Thomson.Cookie";
        
    }
}
