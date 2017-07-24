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
        

        string smtpAddress = "smtp.gmail.com";
        int portNumber = 587;
        string password;

       


        public void Send(Email email, string password)
        {
            this.password = password;


            MailMessage mail = new MailMessage();
               
                    mail.From = new MailAddress(email.From);
                    mail.To.Add(email.To);
                    mail.Subject = email.Subject;
                    mail.Body = email.Body;
         // Can set to false, if you are sending pure text.

            SmtpClient smtp = new SmtpClient(smtpAddress, portNumber);
                
                    smtp.Credentials = new NetworkCredential(email.From, password);
                    smtp.EnableSsl = true;
                    smtp.Send(mail);
               


            }
        }
    }

    


        

