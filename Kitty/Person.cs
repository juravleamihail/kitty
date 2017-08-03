using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kitty
{
    abstract public class Person
    {
        [Column("Name")]
        protected string name { get; set; }

        [Key]
        public int Id { get; set;}
    
        public string mailAddress { get; set; }

        public Person()
        {

        }

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

       
    }
}
