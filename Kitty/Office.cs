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
            employees = new List<Employee>();
        }

        public Employee CreateEmployee(string name, string email)
        {
            var employee = new Employee(name, email);
            employee.Manager = Manager;
            employees.Add(employee);
            return employee;
        }

        public Employee GetEmployee(string name)
        {   
            return employees.FirstOrDefault<Employee>(e => e.Name == name);
        }
    }
}
