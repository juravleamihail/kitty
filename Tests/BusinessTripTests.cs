﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Kitty;
using System.Xml.Serialization;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Kitty.Tools;

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
        private string meaningOfTransportation;
        private bool AccommodationIsNeeded;

        [TestInitialize]
        public void Setup()
        {
            manager = new Manager("Mihail", "cristian.ursache96@yahoo.com");
            Location location = new Location("BT");

            var office = new Office(manager, location);
            emp = office.CreateEmployee("Valentin", "iquesttestemployee@gmail.com");

            startingDate=new DateTime(2008, 04, 14);
            endDate = new DateTime(2008, 04, 30);
            
            meaningOfTransportation = "bmw";
            AccommodationIsNeeded = true;
            BusinessTripRepository businessTripRepo = new BusinessTripRepository();
            businessTripRepo.CleanUp();
            EmailServiceLocator.SetEmailService(new EmailServiceTest());
            BusinessTripFormatterServiceLocator.SetFormatter(new BusinessTripFormatterTest());

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
            FillBT(bt);

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
        public void ASendedBTGetsPendingStatus()
        {
            BusinessTrip bt = emp.GetNewBT();
            FillBT(bt);
            bt.Send();
            Assert.AreEqual(BusinessTrip.STATES.STATE_PENDING, bt.Status);
        }

        [TestMethod]
        public void AllSendedBTAreInsertedInRepository()
        {
            for(int i=0;i<10;i++)
            {
                SendABt();
            }


            BusinessTripRepository businessTripRepo = new BusinessTripRepository();
            IEnumerable<BusinessTrip> storedBts = businessTripRepo.GetAllBts();

            Assert.AreEqual(10, storedBts.Count());
        }

        private BusinessTrip SendABt()
        {
            BusinessTrip bt = emp.GetNewBT();
            FillBT(bt);
            bt.Send();

            return bt;
        }

        [TestMethod]
        public void ASendedBTIsInsertedInRepository()
        {
            var bt = SendABt();

             BusinessTripRepository businessTripRepo = new BusinessTripRepository();
            IEnumerable<BusinessTrip> storedBts = businessTripRepo.GetAllBts();
            
            Assert.IsTrue(storedBts.Any(b=>b.ID == bt.ID));
        }

        [TestMethod]
        public void ASendedBTCanBeApproved()
        {
            var bt = SendABt();

            BusinessTripRepository businessTripRepo = new BusinessTripRepository();
            List<BusinessTrip> storedBts = businessTripRepo.GetPendingBTForManager(bt.Manager);
            var storedBt = storedBts.First();
            storedBt.Approve();

            List<BusinessTrip> approvedBts = businessTripRepo.GetApprovedBTForEmployee(bt.Employee);
            Assert.IsTrue(approvedBts.Any(b => b.ID == bt.ID));
        }

        [TestMethod]
        public void ASendedBTCanBeCanceled()
        {
            var bt = SendABt();

            BusinessTripRepository businessTripRepo = new BusinessTripRepository();
            List<BusinessTrip> storedBts = businessTripRepo.GetPendingBTForManager(bt.Manager);
            var storedBt = storedBts.First();
            storedBt.Cancel();

            List<BusinessTrip> approvedBts = businessTripRepo.GetCanceldBTForEmployee(bt.Employee);
            Assert.IsTrue(approvedBts.Any(b => b.ID == bt.ID));
        }

        [TestMethod]
        public void WhenBtIsSendedAnEmailIsSentToManager()
        {
            var bt = SendABt();
            EmailServiceTest emailServiceTest = new EmailServiceTest();
            Assert.IsTrue(EmailServiceTest.Emails.Any(e => e.To == bt.Manager.mailAddress));
        }

        [TestMethod]
        public void IfEmailIsSendToManager()
        {
            BusinessTrip bt = emp.GetNewBT();
            FillBT(bt);
            bt.Send();
        }
        [TestMethod]
        public void IfApprovedIsSentToEmployee()
        {
            BusinessTrip bt = emp.GetNewBT();
            FillBT(bt);
            bt.Approve(); 
        }

        [TestMethod]
        public void IfCanceledRequestIsSentToEmployee()
        {
            BusinessTrip bt = emp.GetNewBT();
            FillBT(bt);
            bt.Cancel();
        }



        public static void FillBT(BusinessTrip bt)
        { 
            bt.Destination = new Location("X");
            bt.StartingDate = new DateTime(2017,4,2);
            bt.EndDate = new DateTime(2017, 4, 2);
            bt.Phone = "112";
            bt.BankCard = "1502 4023 3453 3252";
            bt.MeanOfTransportation = "Bus";
        }

    }
}
