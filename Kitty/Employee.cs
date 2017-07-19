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

        public Employee(string Name, string email):base(Name)
        {
            this.name = Name;
            this.mailAddress = email;
        }

        public BusinessTrip GetNewBT(String Departure)
        {
            var bt = new BusinessTrip(this, Manager);
            bt.Departure.Where = Departure;
            return bt;
        }

    }
}
