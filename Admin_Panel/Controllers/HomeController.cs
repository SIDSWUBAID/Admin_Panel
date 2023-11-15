using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Admin_Panel.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult setup()
        {
            return View();
        }


        public ActionResult test()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult test2()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}