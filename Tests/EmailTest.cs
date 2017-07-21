using Kitty.Tools;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests
{
    [TestClass]
    class EmailTest
    {
        


        [TestInitialize]
        public void EmailIsSending()
        {
            Email email = new Email();
            Employee
            EmailService emailService = new EmailService();
            email.From = "the_mihail@yahoo.com";
            email.To = "juravleamihail@yahoo.com";
            email.Subject = "Sal koae";
            email.Body = "Cmf???Am imeilu meu";

            emailService.Send(email);

            
        }
    }
}
