using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Mail;

namespace Kitty.Tools
{
    public class EmailService : IEmailService
    {
        BusinessTrip bt;
        Employee emp;
        Email email;
        

        string smtpAddress = "smtp.gmail.com";
        int portNumber = 587;
        bool enableSSL = true;

        string password = "123";


        public void Send(Email email)
        {
            this.email = email;


            using (MailMessage mail = new MailMessage())
            {
                mail.From = new MailAddress(email.From);
                mail.To.Add(email.To);
                mail.Subject = email.Subject;
                mail.Body = email.Body;
                mail.IsBodyHtml = false;
                // Can set to false, if you are sending pure text.

                using (SmtpClient smtp = new SmtpClient(smtpAddress, portNumber))
                {
                    smtp.Credentials = new NetworkCredential(email.From, password);
                    smtp.EnableSsl = enableSSL;
                    smtp.Send(mail);
                }


            }
        }
    }
}

        

