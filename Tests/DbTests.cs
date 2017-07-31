using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Kitty.DB;
using Kitty;
using System.Data.Entity;

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
            
        }

        [TestMethod]
        public void CanAddAnEmployeeToDb()
        {
            var emp = office.CreateEmployee("Vasi", "viva@vevo.com");
            using (EmployeeDbContext db = new EmployeeDbContext())
            {
                db.employees.Add(emp);
                db.SaveChanges();
            }
           
        }
    }
}
