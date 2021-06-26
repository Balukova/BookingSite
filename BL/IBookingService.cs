using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace BL
{
    public interface IBookingService
    {
        bool MakeBooking(User user, OrderingBLModel obm);
    }
}
