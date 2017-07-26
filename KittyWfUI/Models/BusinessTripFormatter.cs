using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Kitty;
using Kitty.Tools;

namespace KittyWfUI.Models
{
    public class BusinessTripFormatter : IBusinessTripFormatter
    {
        public string ApproveAction;
        public string CancelAction;
        public string GetBody(BusinessTrip bt)
        {
            return FormBody(bt) + "&nbsp;&nbsp;&nbsp;&nbsp;" + ActionButtons(bt);
        }

        private string ActionButtons(BusinessTrip bt)
        {
            var approve = "";
            var cancel = "";

            return approve + "&nbsp;&nbsp;&nbsp;&nbsp;" + cancel;
        }

        public string FormBody(BusinessTrip bt)
        {
            var body = string.Format("FROM DESKTOP APP<BR></BR>", bt.Employee.Name);
            body += string.Format("Employee: {0}<BR></BR>", bt.Employee.Name);
            body += string.Format("Departure: {0}<BR></BR>", bt.Departure.Name);
            body += string.Format("Destination: {0}<BR></BR>", bt.Destination.Name);
            body += string.Format("Starting date: {0}<BR></BR>", bt.StartingDate);
            body += string.Format("End date: {0}<BR></BR>", bt.EndDate);
            body += string.Format("Phone: {0}<BR></BR>", bt.Phone);
            body += string.Format("Bank Card: {0}<BR></BR>", bt.BankCard);
            if (bt.AccommodationIsNeeded)
                body += string.Format("Accomodation is needed<BR></BR>");
            else
            {
                body += string.Format("Accomodation is not needed<BR></BR>");
            }

            body += string.Format("Status: {0}<BR></BR>", bt.Status);
            return body;
        }
    }
}