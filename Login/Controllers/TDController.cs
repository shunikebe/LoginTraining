using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Login.Controllers
{
    public class TDController : Controller
    {
        // GET: TD
        public ActionResult Index()
        {
            return File("~/Views/TD/index.html", "text/html");
        }
    }
}