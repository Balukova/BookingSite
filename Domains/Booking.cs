using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Booking : IBase
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public ProductInShop ProductInShop { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public override string ToString()
        {
            return string.Format("Id: {0}\nUserId: {1}\nStartDate: {2}\nEndDate: {3}\n", Id, UserId, StartDate, EndDate);
        }
    }
}
