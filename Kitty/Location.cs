using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kitty
{
    public class Location
    {
        [Key]
        public string Name;

        public Location()
        {

        }

        public Location(String name)
        {
            Name = name;
        }

       

    }
}