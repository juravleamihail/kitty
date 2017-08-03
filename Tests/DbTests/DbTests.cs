using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Kitty.DB;
using Kitty;
using System.Data.Entity;
using System.Collections.Generic;
using Kitty.Reader;

namespace Tests
{
    [TestClass]
    public class DbTests
    {

        private Office office;

        [TestInitialize]
        public void Setup()
        {
            office = new Office(new Manager("M", "M@office.com"), new Location("Sibiu"));
           
            //List<Location> locations = new List<Location>();

        }

        [TestMethod]
        public void CanAddAnEmployeeToDb()
        {
            var emp = office.CreateEmployee("Vasi", "vivas@vevo.com");
            using (EmployeeDbContext db = new EmployeeDbContext())
            {
                db.employees.Add(emp);
                db.SaveChanges();
            }

        }

        [TestMethod]
        public void CanAddCitiesToLocationDb()
        {
            using (LocationDbContext db = new LocationDbContext())
            {
                foreach (string city in JsonLocationReader.Cities())
                {
                    Location loc = new Location(city);
                    db.locations.Add(loc);
                    db.SaveChanges();
                }
            }

        }

        [TestMethod]
        public void CannAddAnOfficeToDb()
        {
            using (OfficeDbContext db = new OfficeDbContext())
            {
                db.offices.Add(office);
                db.SaveChanges();
            }

        }

        [TestMethod]
        public void CanAddAnManagerToDb()
        {
            var man = new Manager("Vasi", "vivas@vevo.com");
            using (ManagerDbContext db = new ManagerDbContext())
            {
                db.managers.Add(man);
                db.SaveChanges();
            }

        }



        [TestMethod]
        public void CanAddFilledBtToDb()
        {
            var emp = office.CreateEmployee("Ion", "i@mail.com)");
            var bt = emp.GetNewBT();
            FillBT(bt);
            using (BussinesTripDbContext db = new BussinesTripDbContext())
            {
                db.trips.Add(bt);
                db.SaveChanges();
            }
        }


    

        public static void FillBT(BusinessTrip bt)
        {
            bt.Destination = new Location("X");
            bt.StartingDate = new DateTime(2017, 4, 2);
            bt.EndDate = new DateTime(2017, 4, 2);
            bt.Phone = "112";
            bt.BankCard = "1502 4023 3453 3252";
            bt.MeanOfTransportation = "Bus";
        }
    }



       
   }
