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
            Status = STATES.STATE_PENDING;

            BusinessTripRepository bs = new BusinessTripRepository();
            bs.Add(this);

            SendEmailToManager();
        }

        private void SendEmailToManager()
        {
            EmailService emailService = new EmailService();
            Email email = new Email();
            email.From = Employee.Email;
            email.To = Manager.Email;
            email.Subject = "Please aprove my request";
            email.Body = FormBody();
           


            emailService.Send(email, Employee.password);
        }

        public string FormBody()
        {
            var body = string.Format("Employee: {0}\n", Employee.Name);
            body += string.Format("Departure: {0}\n", Departure.Name);
            body += string.Format("Destination: {0}\n", Destination.Name);
            body += string.Format("Starting date: {0}\n", this.StartingDate);
            body += string.Format("End date: {0}\n", this.EndDate);
            body += string.Format("Phone: {0}\n", this.Phone);
            body += string.Format("Bank Card: {0}\n", this.BankCard);
            if (AccommodationIsNeeded)
                body += string.Format("Accomodation is needed\n");
            else
            {
                body += string.Format("Accomodation is not needed\n");
            }

            body += string.Format("Status: {0}\n", this.Status);
            return body;
        }

        public void Approve()
        {
            Status = STATES.STATE_APPROVED;
            EmailService emailService = new EmailService();
            Email email = new Email();
            email.From = Manager.Email;
            email.To = Employee.Email;
            email.Subject = "Your request is approved";
            email.Body = FormBody();
            emailService.Send(email, Employee.Manager.password);

        }

        public void Cancel()
        {
            Status = STATES.STATE_CANCELED;
            EmailService emailService = new EmailService();
            Email email = new Email();
            email.From = Manager.Email;
            email.To = Employee.Email;
            email.Subject = "Your request is canceled";
            email.Body = FormBody();
            emailService.Send(email, Employee.Manager.password);
        }
    }
}
