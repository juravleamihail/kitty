using Kitty.Tools;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests
{
    public class EmailServiceTest: IEmailService
    {
        public static List<Email> Emails = new List<Email>();

        public void Send(Email email, string password)
        {
            Emails.Add(email);
        }
    }
}
