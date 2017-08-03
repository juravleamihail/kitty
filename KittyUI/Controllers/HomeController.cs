using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace KittyUI.Controllers
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

        public ActionResult Messages()
        {
            ViewBag.Message = "Messages";

            return View();
        }

        public ActionResult HelloKitty()
        {
            return View();
        }
    }
}
     
    