using Kitty;
using Kitty.Tools;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KittyConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            Setup();
            Console.WriteLine("Please choose an action:");
            Console.WriteLine("1. Create BT");
            Console.WriteLine("2. Exit");
            var key = Console.ReadKey();
            if (key.KeyChar == '1')
            {
                CreateBT();
            }
        }

        public static void Setup()
        {

            var btf = new Models.BusinessTripFormatter();

            btf.ApproveAction = "";
            btf.CancelAction = "";
            BusinessTripFormatterServiceLocator.SetFormatter(btf);
        }

        static void CreateBT()
        {
            var manager = new Manager("Mihail", "cristian.ursache96@yahoo.com");
            Location location = new Location("Sibiu");

            var office = new Office(manager, location);
            var emp = office.CreateEmployee("Valentin", "iquesttestemployee@gmail.com");
            var bt = emp.GetNewBT();
            bt.Destination = new Location("Brasov");
            bt.Send();
            Console.WriteLine(string.Format("A new BT was created with ID: {0}", bt.ID));
        }
    }
}
