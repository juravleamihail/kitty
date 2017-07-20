using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kitty
{
    public class BusinessTrip
    {
        public readonly Employee Employee;
        public Location Departure;
        public Location Destination;
        public DateTime StartingDate;
        public DateTime EndDate;
        public string Phone;
        public string BankCard;
        public bool AccommodationIsNeeded;

        enum STATES { STATE_CANCELED = 0, STATE_APPROVED = 1, STATE_PENDING = 2 }
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
    }
}
