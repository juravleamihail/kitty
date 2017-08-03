using Kitty.Tools;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kitty
{
    public class BusinessTrip
    {
        public Guid ID;
        public STATES Status = STATES.STATE_NEW;

        public readonly Employee Employee;
        public Location Departure;
        public Location Destination;
        public DateTime StartingDate;
        public DateTime EndDate;
        public string Phone;
        public string BankCard;
        public bool AccommodationIsNeeded;

        public enum STATES { STATE_NEW=0, STATE_CANCELED = 1, STATE_APPROVED = 2, STATE_PENDING = 3 }
        public string MeanOfTransportation;

        public Manager Manager;
        //public string OtherNeeds;
        public BusinessTrip()
        {
            ID = Guid.NewGuid();
        }

        public BusinessTrip(Employee employee, Manager manager)
        {
            ID = Guid.NewGuid();
            Departure = employee.Office.Location;
            Employee = employee;
            Manager = manager;
        }

        public void Send()
        {
            Send("none", "none");
        }

        public void Send(string approveAction, string cancelAction)
        {
            Status = STATES.STATE_PENDING;

            BusinessTripRepository bs = new BusinessTripRepository();
            bs.Add(this);

            SendEmailToManager(approveAction, cancelAction);
        }

        private void SendEmailToManager(string approveAction, string cancelAction)
        {
            IEmailService emailService = EmailServiceLocator.GetEmailService();
            Email email = new Email();
            email.From = Employee.Email;
            email.To = Manager.Email;
            email.Subject = "Please aprove my request";
            IBusinessTripFormatter btf = BusinessTripFormatterServiceLocator.GetFormatter();
            email.Body = btf.GetBody(this); 
           


            emailService.Send(email);
        }

        

        public void Approve()
        {
            if (Status != STATES.STATE_PENDING)
            {
                return;
            }
            Status = STATES.STATE_APPROVED;
            IEmailService emailService = EmailServiceLocator.GetEmailService();
            Email email = new Email();
            email.From = Manager.Email;
            email.To = Employee.Email;
            email.Subject = "Your request is approved";
            IBusinessTripFormatter btf = BusinessTripFormatterServiceLocator.GetFormatter();
            email.Body = btf.GetBody(this);
            emailService.Send(email);

        }

        public void Cancel()
        {
            if (Status!=STATES.STATE_PENDING)
            {
                return;
            }
            Status = STATES.STATE_CANCELED;
            IEmailService emailService = EmailServiceLocator.GetEmailService();
            Email email = new Email();
            email.From = Manager.Email;
            email.To = Employee.Email;
            email.Subject = "Your request is canceled";
            IBusinessTripFormatter btf = BusinessTripFormatterServiceLocator.GetFormatter();
            email.Body = btf.GetBody(this);
            emailService.Send(email);
        }


    }
}
