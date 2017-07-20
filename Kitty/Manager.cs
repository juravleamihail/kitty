using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kitty
{
    public class Manager : Employee
    {
        public List<BusinessTrip> BTs;
       
        public Manager(string Name, string email) : base(Name, email)
        {
        }

        private void aproveBT()
        { }
                
        }
    }

