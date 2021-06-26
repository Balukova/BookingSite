using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class ShopRepository : Repository<ShopEntity, int>, IShopRepository<ShopEntity, int>
    {

        BookingDbContext context;
        public ShopRepository(BookingDbContext context) : base(context)
        {
            this.context = context;
        }
      


    }
}
