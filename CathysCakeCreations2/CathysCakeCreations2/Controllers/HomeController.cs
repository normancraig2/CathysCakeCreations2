using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CathysCakeCreations2.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "About Cathy";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "How to reach me";

            return View();
        }
    }
}