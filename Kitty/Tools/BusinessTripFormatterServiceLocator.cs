using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kitty.Tools
{
    public static class BusinessTripFormatterServiceLocator
    {
        private static IBusinessTripFormatter BusinessTripFormatter;

        public static IBusinessTripFormatter GetFormatter()
        {
            return BusinessTripFormatter;
        }

        public static void SetFormatter(IBusinessTripFormatter businessTripFormatter)
        {
            BusinessTripFormatter = businessTripFormatter;
        }
    }
}
