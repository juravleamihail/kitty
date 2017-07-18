using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kitty
{
    public class Employee : Person
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
        }

        public void ChooseCity(BusinessTrip New);
        {
            int caseSwitch = 0;

            switch (caseSwitch)
            {
                Console.Write("Alegeti optiunea: 1 - SB, 2 - CJ, 3 -B , 4 - IS, 5 - TM");
                case 1:
                    New.departure.Where= "Sibiu";
                    break;
                case 2:
                    New.departure.Where = "Cluj-Napoca";
                    break;
                case 3:
                    New.departure.Where = "Bucuresti";
                    break;
                case 5:
                    New.departure.Where = "Iasi";
                    break;
                case 6:
                    New.departure.Where = "Timisoara";
                    break;
          }
       }
}
