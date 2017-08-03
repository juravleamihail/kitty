using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kitty.Tools
{
    public interface IBusinessTripFormatter
    {
        string GetBody(BusinessTrip bt);
    }
}
