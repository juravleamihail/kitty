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

        public Employee():base()
        {

        }

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
    }
}
