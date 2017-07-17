using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kitty
{
    class Employee : Person
    { 
    
        public Employee(string Name, string email)
        {
            this.name = Name;
            this.mailAddress = email; 
        }

        public void createBT(BusinessTrip New)
        {
            New.Employee = new Employee(name, mailAddress);
            
            Console.WriteLine("Insert Business Trip data");
            Console.WriteLine("Choose departure city:");
            int caseSwitch = 1;

            switch (caseSwitch)
            {
                case 1:
                    New.departure = "Sibiu";
                    break;
                case 2:
                    Console.WriteLine("Case 2");
                    break;
                default:
                    Console.WriteLine("Default case");
                    break;
            }




        }

    }
}
