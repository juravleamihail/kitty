using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kitty
{
    class Location
    {
        private string x;

        public string Where
        {
            get
            {
                return x;
            }

            set
            {
                x = value;
            }
        }
    }
}