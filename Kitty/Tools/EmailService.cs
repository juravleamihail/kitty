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
        

        string smtpAddress = "smtp.yahoo.com";
        int portNumber = 587;
        bool enableSSL = true;
        string password;

       


        public void Send(Email email, string password)
        {
            this.email = email;
            this.password = password;

            
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
                    smtp.Credentials = new NetworkCredential(email.From, email.password);
                    smtp.EnableSsl = enableSSL;
                    smtp.Send(mail);
                }


            }
        }
    }
}
    


        

