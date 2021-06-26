using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class BookingEntity: IBaseEntity
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public ProductInShopEntity ProductInShop { get; set; }
        public int ProductInShopId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
    }
}
