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


            Console.WriteLine("Insert Business Trip data");

            Console.WriteLine("Choose departure city:");
            New.departure.where = ChooseCity();

            Console.WriteLine("Choose destination city:");
            New.departure.where = ChooseCity();


            Console.WriteLine("Insert starting date:");
            Console.WriteLine("Day:{0}", New.startingDate.Day);
            Console.WriteLine("Month:{0}", New.startingDate.Month);
            Console.WriteLine("Year:{0}", New.startingDate.Year);

            Console.WriteLine("Insert end date:");
            Console.WriteLine("Day:{0}", New.endDate.Day);
            Console.WriteLine("Month:{0}", New.endDate.Month);
            Console.WriteLine("Year:{0}", New.endDate.Year);

            Console.WriteLine("Insert your phone:");
            string input = Console.ReadLine();
            New.phone = input;

        }



        public string ChooseCity()
        {

            int caseSwitch = 0;
            string location = null;
            Console.Write("Alegeti optiunea: 1 - SB, 2 - CJ, 3 -B , 4 - IS, 5 - TM");
            switch (caseSwitch)
            {
                case 1:
                    location = "Sibiu";
                    break;
                case 2:
                    location = "Cluj-Napoca";
                    break;
                case 3:
                    location = "Bucuresti";
                    break;
                case 4:
                    location = "Iasi";
                    break;
                case 5:
                    location = "Timisoara";
                    break;
            }
            return location;
        }
    }
}
