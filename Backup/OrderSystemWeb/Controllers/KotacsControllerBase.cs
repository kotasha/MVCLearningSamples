using Kotacs.Libraries.Web.Extensibility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OrderSystemWeb.Controllers
{
    public class KotacsControllerBase : Controller
    {
        //
        // GET: /KotacsControllerBase/

        protected override ITempDataProvider CreateTempDataProvider()
        {
            return new KotacsTempDataProvider();
        }
    }
}
