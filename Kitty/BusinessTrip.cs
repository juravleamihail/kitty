using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kitty
{
    public class BusinessTrip
    {
        STATES value = STATES.STATE_PENDING;

        public readonly Employee Employee;
        public Location Departure;
        public Location Destination;
        public DateTime StartingDate;
        public DateTime EndDate;
        public string Phone;
        public string BankCard;
        public bool AccommodationIsNeeded;

        public enum STATES { STATE_START=0,STATE_CANCELED = 1, STATE_APPROVED = 2, STATE_PENDING = 3 }
        public string MeanOfTransportation;
        //public string OtherNeeds;
        public BusinessTrip()
        {

        }

        public BusinessTrip(Employee employee, Manager manager)
        {
            Departure = employee.Office.Location;
            Employee = employee;
        }


        public void Send()
        {

            Manager manager;
            manager = this.Employee.Office.Manager;
            manager.BTs.Add(this);
        }

        public STATES ChooseStatus(string STATUS)
        {
            switch (STATUS)
            {
                case "APPROVED":
                    value = STATES.STATE_APPROVED;
                    break; 

                case "CANCELED":
                    value = STATES.STATE_CANCELED;
                    break;                   
            }
            return value;
        }

    }
}
