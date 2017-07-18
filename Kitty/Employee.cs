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
            New.departure = ChooseCity(Location departure);

            Console.WriteLine("Choose destination city:");
            New.departure = ChooseCity(Location departure);

        }

       

        public Location ChooseCity(Location loc);
        {
           
            int caseSwitch = 0;

            switch (caseSwitch)
            {
                Console.Write("Alegeti optiunea: 1 - SB, 2 - CJ, 3 -B , 4 - IS, 5 - TM");
                case 1:
                    where= "Sibiu";
                    break;
                case 2:
                    where = "Cluj-Napoca";
                    break;
                case 3:
                   where = "Bucuresti";
                    break;
                case 5:
                    where = "Iasi";
                    break;
                case 6:
                    where = "Timisoara";
                    break;

                default:
                    return Write("Choose a city!");
       }
            return loc;
     }   
  
}
}
