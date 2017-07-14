using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kitty
{
    class BusinessTrip
    {
        private int user_id;
        private string departure;
        private string destination;
        private string startingDate;
        private string endDate;
        private string phone;
        private string accommodation;
        enum STATES { STATE_CANCELED = 0,STATE_APPROVED =1,STATE_PENDING=2 }
    }
}
