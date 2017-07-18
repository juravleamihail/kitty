using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace Kitty
{
    public class Office
    {
        public  Manager Manager;
        private List<Employee> employees;

        public Office(Manager manager)
        {
            Manager = manager;
        }
    }
}
