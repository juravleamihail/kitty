using Kitty;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KittyWfUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var manager = new Manager("Mihail", "cristian.ursache96@yahoo.com");
            Location location = new Location("Sibiu");

            var office = new Office(manager, location);
            var emp = office.CreateEmployee("Valentin", "iquesttestemployee@gmail.com");
            var bt = emp.GetNewBT();
            bt.Destination = new Location("Brasov");
            MessageBox.Show(string.Format("A new BT was created with ID: {0}", bt.ID));
            bt.Send();
        }
    }
}
