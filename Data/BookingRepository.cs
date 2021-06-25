using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class BookingRepository: Repository<BookingEntity>, IBookingRepository<BookingEntity>
    {
        BookingDbContext context;
        public BookingRepository(BookingDbContext context) : base(context)
        {
            this.context = context;
        }
    }
}
