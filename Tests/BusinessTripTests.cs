using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Kitty;
using System.Xml.Serialization;
using System.Text;

namespace Tests
{

    [TestClass]
    public class BusinessTripTests
    {
        private Employee emp;
        private Manager manager;
        private Location location;
        private DateTime startingDate;
        private DateTime endDate;
        private string phone;
        private string bankCard;
        private string meaningOfTransportation;
        private bool AccommodationIsNeeded;

        [TestInitialize]
        public void Setup()
        {
            emp = new Employee("gigel", "non");
            manager = new Manager("boss", "fara");

            Location location = new Location("Brasov");
            emp.Office = new Office(manager, location);

            startingDate=new DateTime(2008, 04, 14);
            endDate = new DateTime(2008, 04, 30);
            phone = "112";
            bankCard = "1502 4023 3453 3252";
            meaningOfTransportation = "bmw";
            AccommodationIsNeeded = true;

        }

        [TestMethod]
        public void ABusinessTripCanBeCreated() {
            BusinessTrip bt = emp.GetNewBT();
            Assert.IsNotNull(bt);
        }

        //todo: add a test for fill in the BT

        [TestMethod]
        public void BusinessTripCanBeFill()
        {
            BusinessTrip bt = emp.GetNewBT();
            bt.Departure = new Location("X");
            bt.Destination = new Location("X");
            bt.StartingDate = DateTime.Now;
            bt.EndDate = endDate;
            bt.Phone = phone;
            bt.BankCard = bankCard;
            bt.MeanOfTransportation = "Bus";

            XmlSerializer ser = new XmlSerializer(typeof(BusinessTrip));
            StringBuilder sb = new System.Text.StringBuilder();
            string serializedBT;
            using (var s = new System.IO.StringWriter(sb))
            {
                ser.Serialize(s, bt);
                serializedBT = sb.ToString();
            }

            BusinessTrip newBt;
            using (var r = new System.IO.StringReader(serializedBT))
            {
                newBt = (BusinessTrip)ser.Deserialize(r);                
            }

            sb.Clear();
            string serializedNewBT;
            using (var s = new System.IO.StringWriter(sb))
            {
                ser.Serialize(s, bt);
                serializedNewBT = sb.ToString();
            }

            Assert.AreEqual(serializedBT, serializedNewBT);
        }

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

        [TestMethod]
        public void ManagerGetFilledBusinessTrip()
        {

        }

    }
}
