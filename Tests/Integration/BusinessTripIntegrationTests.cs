using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Kitty;
using System.Xml.Serialization;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Kitty.Tools;

namespace Tests.Integration
{

    [TestClass]
    public class BusinessTripIntegrationTests
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
            manager = new Manager("Mihail", "testiq9999@gmail.com");
            Location location = new Location("BT");

            var office = new Office(manager, location);
            emp = office.CreateEmployee("Valentin", "iquest9999@gmail.com");

            startingDate = new DateTime(2008, 04, 14);
            endDate = new DateTime(2008, 04, 30);
            phone = "112";
            bankCard = "1502 4023 3453 3252";
            meaningOfTransportation = "bmw";
            AccommodationIsNeeded = true;
            BusinessTripRepository businessTripRepo = new BusinessTripRepository();
            businessTripRepo.CleanUp();
            EmailServiceLocator.SetEmailService(new GmailEmailService());
            BusinessTripFormatterServiceLocator.SetFormatter(new BusinessTripFormatterTest());
        }

        [TestMethod]
        public void OnSendAnEmailIsSentTroughGmail()
        {
            BusinessTrip bt = emp.GetNewBT();
            BusinessTripTests.FillBT(bt);
            bt.Send("http:\\\\aTest.com\\Approve", "http:\\\\aTest.com\\Cancel");
        }

    }
}
