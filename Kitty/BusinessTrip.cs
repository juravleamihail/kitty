using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kitty
{
    public class BusinessTrip
    {
        private Employee employee;
        private Location departure;
        private Location destination;
        private DateTime startingDate;
        private DateTime endDate;
        private string phone;

        //private string accommodation;

        enum STATES { STATE_CANCELED = 0, STATE_APPROVED = 1, STATE_PENDING = 2 }
        private string meanOfTransportation;
        private string otherNeeds;

        public BusinessTrip(Employee employee, Manager manager)
        {
            departure = new Location();
            destination = new Location();
            this.employee = employee;
        }

        public Employee Employee
        {
            get
            {
                return employee;
            }

            set
            {
                employee = value;
            }
        }

        public Location Departure
        {
            get
            {
                return departure;
            }

            set
            {
                departure = value;
            }
        }

        public Location Destination
        {
            get
            {
                return destination;
            }

            set
            {
                destination = value;
            }
        }

        public DateTime StartingDate
        {
            get
            {
                return startingDate;
            }

            set
            {
                startingDate = value;
            }
        }

        public DateTime EndDate
        {
            get
            {
                return endDate;
            }

            set
            {
                endDate = value;
            }
        }

        public string Phone
        {
            get
            {
                return phone;
            }

            set
            {
                phone = value;
            }
        }
    }
}
