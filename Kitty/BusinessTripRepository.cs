using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kitty
{
    public class BusinessTripRepository
    {
        private static List<BusinessTrip> businessTrips;

        static BusinessTripRepository()
        {
            businessTrips = new List<BusinessTrip>();
        }

        public void CleanUp()
        {
            businessTrips = new List<BusinessTrip>();
        }

        public void Add(BusinessTrip bt)
        {
            businessTrips.Add(bt);
        }

        public IEnumerable<BusinessTrip> GetAllBts()
        {
            return businessTrips;
        }

        public BusinessTrip GetBtById(Guid ID)
        {
            return businessTrips.FirstOrDefault<BusinessTrip>(bt=>bt.ID == ID);
        }

        public List<BusinessTrip> GetPendingBTForManager(Manager manager)
        {
            return businessTrips
                .Where(b=>b.Manager.Name == manager.Name && b.Status==BusinessTrip.STATES.STATE_PENDING)
                .ToList();
        }

        public List<BusinessTrip> GetApprovedBTForEmployee(Employee employee)
        {
            return businessTrips
                .Where(b => b.Employee.Name == employee.Name && b.Status==BusinessTrip.STATES.STATE_APPROVED)
                .ToList();
        }

        public List<BusinessTrip> GetCanceldBTForEmployee(Employee employee)
        {
            return businessTrips
                .Where(b => b.Employee.Name == employee.Name && b.Status == BusinessTrip.STATES.STATE_CANCELED)
                .ToList();
        }
    }
}
