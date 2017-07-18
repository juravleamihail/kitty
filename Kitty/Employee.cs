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

        public void createBTRequest(BusinessTrip New)
        {


            Console.WriteLine("Insert Business Trip data");

            Console.WriteLine("Choose departure city:");
            New.Departure.Where = ChooseCity();

            Console.WriteLine("Choose destination city:");
            New.Destination.Where = ChooseCity();


            Console.WriteLine("Insert starting date:");
            Console.WriteLine("Day:{0}", New.StartingDate.Day);
            Console.WriteLine("Month:{0}", New.StartingDate.Month);
            Console.WriteLine("Year:{0}", New.StartingDate.Year);

            Console.WriteLine("Insert end date:");
            Console.WriteLine("Day:{0}", New.EndDate.Day);
            Console.WriteLine("Month:{0}", New.EndDate.Month);
            Console.WriteLine("Year:{0}", New.EndDate.Year);

            Console.WriteLine("Insert your phone:");
            string input = Console.ReadLine();
            New.Phone = input;





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
