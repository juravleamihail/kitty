using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kitty
{
    abstract public class Person
    {
        protected string name { get; set; }

        [Key]
        public string mailAddress { get; set; }

        public Person()
        {

        }

        public Person(string name)
        {
            this.name = name;
        }
        //aa
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
