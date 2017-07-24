using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kitty.Tools
{
    public static class EmailServiceLocator
    {
        private static IEmailService EmailService;

        static EmailServiceLocator()
        {
            EmailService = new EmailService();
        }

        public static void SetEmailService(IEmailService emailService)
        {
            EmailService = emailService;
        }

        public static IEmailService GetEmailService()
        {
            return EmailService;
        }
    }
}
