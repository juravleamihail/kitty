using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kitty
{
    public class Manager : Employee
    {
        public Manager() : base()
        {

        }
        public Manager(string Name, string email) : base(Name, email)
        {
        }
    }
}

