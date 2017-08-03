using Kitty;
using KittyUI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace KittyUI.Controllers
{
    public class RegisterBTController : Controller
    {
        // GET: RegisterBT
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult CreateBT()
        {
            var manager = new Manager("Mihail", "the_mihail@yahoo.com");
            Location location = new Location("Sibiu");

            var office = new Office(manager, location);
            var emp = office.CreateEmployee("Valentin", "testiq9999@gmail.com");
            var bt = emp.GetNewBT();
            bt.Destination = new Location("Brasov");
            ViewBag.BtID = bt.ID;
            bt.Send();
            return View();
        }
        //
        public ActionResult Approve(Guid ID)
        {
            BusinessTripRepository btr = new BusinessTripRepository();
            var bt = btr.GetBtById(ID);
            bt.Approve();
            return View(bt);
        }

        public ActionResult Cancel(Guid ID)
        {
            BusinessTripRepository btr = new BusinessTripRepository();
            var bt = btr.GetBtById(ID);
            bt.Cancel();
            return View(bt);
        }
    }
}