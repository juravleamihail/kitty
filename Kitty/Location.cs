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

        public string ChooseCity()
        {
            string stringSwitch;
            int caseSwitch;
            string location = null;
            Console.WriteLine("Alegeti optiunea: 1 - SB, 2 - CJ, 3 -B , 4 - IS, 5 - TM");
            stringSwitch = Console.ReadLine();
            caseSwitch = Int32.Parse(stringSwitch);
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