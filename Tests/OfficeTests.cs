using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Kitty;

namespace Tests
{
    [TestClass]
    public class OfficeTests
    {
        private Office office;

        [TestInitialize]
        public void Setup()
        {
            office = new Office(new Manager("M", "M@office.com"),new Location("Sibiu"));
        }

        [TestMethod]
        public void AnEmployeeCanBeCreated()
        {
            var employee = office.CreateEmployee("X", "X");
            Assert.IsNotNull(employee);
        }

        [TestMethod]
        public void AnEmployeeCanBeExtracted()
        {
            var newEmployee = office.CreateEmployee("X", "X");
            var existingEmployee = office.GetEmployee("X");

            Assert.AreEqual("X", existingEmployee.Name);
        }

        [TestMethod]
        public void WhenEmployeeNotFoundNullIsReturned()
        {
            var existingEmployee = office.GetEmployee("X");
            Assert.IsNull(existingEmployee);
        }
    }
}
