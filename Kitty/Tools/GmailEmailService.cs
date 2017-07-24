using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace Kitty.Tools
{
    public class GmailEmailService : IEmailService
    {
        private string smtpAddress = "smtp.gmail.com";
        private int portNumber = 587;
        private string passwordSyst = "testiq123";
        private string SystEmail = "testiq9999@gmail.com";

        public void Send(Email email)
        {
            MailMessage mail = new MailMessage();

            mail.From = new MailAddress(SystEmail);
            mail.To.Add(email.To);
            mail.Subject = email.Subject;
            mail.IsBodyHtml = true;
            mail.Body = email.Body;
            // Can set to false, if you are sending pure text.

            SmtpClient smtp = new SmtpClient(smtpAddress, portNumber);

            smtp.Credentials = new NetworkCredential(SystEmail, passwordSyst);
            smtp.EnableSsl = true;
            smtp.Send(mail);
        }
    }
}
