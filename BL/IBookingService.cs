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
        void MakeBooking(User user, ProductInShop productInShop, DateTime startDate, DateTime endDate);
    }
}
