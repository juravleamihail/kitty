using Kitty.Tools;
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
            EmailService imeil = new EmailService();
            Email email = new Email();
            imeil.Send(email);
           

           

        }
    }
}
