using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Kitty;

namespace Tests
{
    [TestClass]
    public class EmployeeTest
    {
        private BusinessTrip newBT;


        [TestMethod]
        public void EmployeeCanBeCreated()
        {
            //Arange
            Employee john = new Employee("John", "john@yahoo.com");

            Assert.IsNotNull(john);

        }

        [TestMethod]
        public void AnEmployeeBelongsToAOffice()
        {
            //Arange
            Employee john = new Employee("John", "john@yahoo.com");

            Assert.IsNotNull(john.Office);

        }

        [TestMethod]
        public void AnEmployeeHasAManager()
        {
            //Arange
            Employee john = new Employee("John", "john@yahoo.com");

            Assert.IsNotNull(john.Office.Manager);

        }

        [TestMethod]
        public void ShouldCreateNewBusinessTripRequest()
        {
            //Arange
            Employee john = new Employee("John", "john@yahoo.com");

            newBT = john.GetNewBT();
            
        }

        [TestMethod]
        public void NewlyCreatedTestBelongsToEmployee()
        {
            //Arange
            Employee john = new Employee("John", "john@yahoo.com");

            newBT = john.GetNewBT();

            Assert.AreEqual(newBT.Employee.Name, john.Name);

        }

        static void Main(string[] args)
        {
            EmployeeTest a = new EmployeeTest();
            a.ShouldCreateNewBusinessTripRequest();

        }
    
    }
}
