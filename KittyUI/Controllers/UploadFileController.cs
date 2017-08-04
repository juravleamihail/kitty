using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace KittyUI.Controllers
{
    public class UploadFileController : Controller
    {
        // GET: UploadFileController
        public ActionResult Index()
        {
            return View();
        }

        private bool isValidContenyType(string contentType)
        {
            return contentType.Equals("file/txt");
        }


        [HttpPost]
        public ActionResult Process(HttpPostedFileBase Location)
        {
            if (isValidContenyType(Location.ContentType))
            {
                ViewBag.Error = "It's not a text file";
                return View("Index");
            }
            return View("Succes");

        }
    }
}