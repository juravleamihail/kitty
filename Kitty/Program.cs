using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kitty
{
    class Program
    {
        static void Main(string[] args)
        {
            Location location = new Location("Sibiu");
            Employee emp = new Employee("iobagg","daca stii cum zac@metin2");
            Manager manager = new Manager("vasilica","vasi69@brazzers.com");
            //Office office = new Office(manager);
           // office.CreateEmployee("sclav", "fara mail");
            BusinessTrip bt = new BusinessTrip(emp, manager);
            emp.GetNewBT();     
           // Console.WriteLine(location.ChooseCity());
            //Console.WriteLine(bt.Departure.Where);
           // Console.WriteLine(bt.Departure.ChangeDeparture());

            Console.ReadLine();

        }
    }
}
