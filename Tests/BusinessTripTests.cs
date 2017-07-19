using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Kitty;

namespace Tests
{

    [TestClass]
    public class BusinessTripTests
    {
        private Employee emp;
        private Manager manager;

        [TestInitialize]
        public void Setup()
        {
            emp = new Employee("gigel", "non");
            manager = new Manager("boss", "fara");

            Location location = new Location("Brasov");
            emp.Office = new Office(manager, location);
        }

        [TestMethod]
        public void ABusinessTripCanBeCreated() {
            BusinessTrip bt = emp.GetNewBT();
            Assert.IsNotNull(bt);
        }

        //todo: add a test for fill in the BT

        [TestMethod]
        public void ADefaultOfDepartureIsEmployeeLocation()
        {
            BusinessTrip bt = emp.GetNewBT();
            Assert.AreEqual(bt.Departure.Name, emp.Office.Location.Name);
        }

        [TestMethod]
        public void TheDefaultDestinationIsNull()
        {
            BusinessTrip bt = emp.GetNewBT();
            Assert.IsNull(bt.Destination);
        }
    }
}
