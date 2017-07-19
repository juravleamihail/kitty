using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Kitty;

namespace Tests
{
    [TestClass]
    public class EmployeeTest
    {
        private BusinessTrip newBT;
        private Office office;

        [TestInitialize]
        public void Setup()
        {
            office = new Office(new Manager("M", "M@office.com"),new Location("Sibiu"));
        }

        [TestMethod]
        public void EmployeeCanBeCreated()
        {
            //Arange
            Employee john = office.CreateEmployee("John", "john@yahoo.com");

            Assert.IsNotNull(john);

        }

        [TestMethod]
        public void AnEmployeeHasAnOffice()
        {
            //Arange
            Employee john = office.CreateEmployee("John", "john@yahoo.com");

            Assert.IsNotNull(john.Office);

        }

        [TestMethod]
        public void AnEmployeeHasAManager()
        {

            //Arange
            Employee john = GetNewEmployee();

            Assert.IsNotNull(john.Manager);

        }

        [TestMethod]
        public void ShouldCreateNewBusinessTripRequest()
        {
            //Arange
            Employee john = GetNewEmployee();

            newBT = john.GetNewBT();
            
        }

        [TestMethod]
        public void NewlyCreatedTestBelongsToEmployee()
        {
            //Arange
            Employee john = GetNewEmployee();

            newBT = john.GetNewBT();

            Assert.AreEqual(newBT.Employee.Name, john.Name);

        }

        private Employee GetNewEmployee()
        {
            return office.CreateEmployee("John", "john@yahoo.com");
        }
    
    }
}
