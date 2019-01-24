using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HowdyWorld.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public string String()
        {
            return "Howdy, World!";
        }

        public string Param(int id)
        {
            return "ID:" + id;
        }

        public ActionResult Redirect()
        {
            return View("About");
        }

    }
}