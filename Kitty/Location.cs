using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kitty
{
    public class Location
    {
        private string where;
        private string departure;

        public string Where
        {
            get
            {
                return where;
            }

            set
            {
                where = value;
            }  
        }

        public string Departure
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

        public string ChooseCity()
        {
            string stringSwitch; 
            string location = null;
            Console.WriteLine("Alegeti orasul in care vrei sa calatoresti: 1 - SB, 2 - CJ, 3 -B , 4 - IS, 5 - TM");
            stringSwitch = Console.ReadLine();
            switch (stringSwitch)
            {
                case "1":
                    location = "Sibiu";
                    break;
                case "2":
                    location = "Cluj-Napoca";
                    break;
                case "3":
                    location = "Bucuresti";
                    break;
                case "4":
                    location = "Iasi";
                    break;
                case "5":
                    location = "Timisoara";
                    break;
            }
            return location;
        }

        public string ChangeDeparture()
        {
            string choose;
            bool chooseDestination;
            string destination;
            Console.WriteLine("You want to change your departure:y\n");
            choose= Console.ReadLine(); 
            switch (choose)
            {
                case "y":
                    chooseDestination = true;
                    break;

                default:
                    chooseDestination = false;
                    break;     
            }

            if (chooseDestination)
            {
                Console.WriteLine("Choose your departure:");
                destination = Console.ReadLine();
                Where = destination;
                return departure;
            }
            else
                return departure;

        }
    }
}