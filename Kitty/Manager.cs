using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kitty
{
    public class Manager : Person
    {

        public Manager(string name) : base (name)
        { }
        

        public override BusinessTrip GetNewBT()
        {
            throw new NotImplementedException();
        }

        private void aproveBT()
        { }
                
        }
    }

