using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Mail;

using System.Web;
using System.Net.Mail;


namespace Kitty.Tools
{
    public class EmailService : IEmailService
    {
       


        public void Send(Email email)
        {
            MailMessage mail = new MailMessage("the_mihail@yahoo.com", "the_mihail@yahoo.com", "sal", "plm");
            SmtpClient client = new SmtpClient("smtp.gmail.com");
            client.Port = 465;
            client.Credentials = new System.Net.NetworkCredential("the_mihail@yahoo.com", "");
            client.EnableSsl = true;
            client.Send(mail);
        }
    }
}

        

