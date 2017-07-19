using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kitty
{
    abstract public class Person
    {
        protected string name;
        protected string mailAddress;

        public Person(string name)
        {
            this.name = name;
        }

        public string Name
        {
            get {
                return name;
            }
        }

        public string Email
        {
            get
            {
                return mailAddress;
            }
            set
            {
                mailAddress = value;
            }
        }
        
    }
}
