using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace s452631_webApp.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }


        public ActionResult About()
        {
            ViewBag.Message = "My Simple CRM web app description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Author's contact page.";

            return View();
        }
    }
}