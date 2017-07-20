using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kitty
{
    public class Employee : Person
    {
        public Manager Manager;
        public Office Office;
        
        public Employee(string Name, string email):base(Name)
        {
            this.name = Name;
            this.mailAddress = email;
        }

        public BusinessTrip GetNewBT()
        {
            var bt = new BusinessTrip(this, Manager);
            return bt;
        }

        public BusinessTrip fillBT(Location destination, DateTime startDate, DateTime endDate, string phone, string bankCard, bool accomodation, string meaningOfTranspartion)
        {
            BusinessTrip bt = GetNewBT();
            bt.Departure = this.Office.Location;
            bt.Destination = destination;
            bt.StartingDate = startDate;
            bt.EndDate = endDate;
            bt.Phone = phone;
            bt.BankCard = bankCard;
            bt.AccommodationIsNeeded = accomodation;
            bt.MeanOfTransportation = meaningOfTranspartion;
            return bt;
        }


        public string ChooseCity()
        {
            string stringSwitch;
            string location = null;
            Console.WriteLine("Alegeti orasul in care vrei sa calatoresti: 1 - SB, 2 - CJ, 3 -B , 4 - IS, 5 - TM");
            stringSwitch = Console.ReadLine();
            switch (stringSwitch)
            {
                case "1":
                    location = "Sibiu";
                    break;
                case "2":
                    location = "Cluj-Napoca";
                    break;
                case "3":
                    location = "Bucuresti";
                    break;
                case "4":
                    location = "Iasi";
                    break;
                case "5":
                    location = "Timisoara";
                    break;
            }
            return location;
        }
    }
}
