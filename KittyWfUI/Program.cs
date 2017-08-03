using Kitty.Tools;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KittyWfUI
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            var btf = new Models.BusinessTripFormatter();            

            btf.ApproveAction = "";
            btf.CancelAction = "";
            BusinessTripFormatterServiceLocator.SetFormatter(btf);

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
