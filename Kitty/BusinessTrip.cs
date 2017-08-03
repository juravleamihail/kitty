using Kitty.Tools;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kitty
{
    public class BusinessTrip
    {
        [Key]
        public Guid ID { get; set; }
        public STATES Status  { get; set; }

        public Employee Employee { get; set; }
        public Location Departure { get; set; }
        public Location Destination { get; set; }
        public DateTime StartingDate { get; set; }
        public DateTime EndDate { get; set; }
        public string Phone { get; set; }
        public string BankCard { get; set; }
        public bool AccommodationIsNeeded { get; set; }

        public enum STATES { STATE_NEW=0, STATE_CANCELED = 1, STATE_APPROVED = 2, STATE_PENDING = 3 }
        public string MeanOfTransportation { get; set; }

        public Manager Manager { get; set; }
        //public string OtherNeeds;
        public BusinessTrip()
        {
            ID = Guid.NewGuid();
            Status = STATES.STATE_NEW;
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
            email.From = Employee.mailAddress;
            email.To = Manager.mailAddress;
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
            email.From = Manager.mailAddress;
            email.To = Employee.mailAddress;
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
            email.From = Manager.mailAddress;
            email.To = Employee.mailAddress;
            email.Subject = "Your request is canceled";
            IBusinessTripFormatter btf = BusinessTripFormatterServiceLocator.GetFormatter();
            email.Body = btf.GetBody(this);
            emailService.Send(email);
        }


    }
}
