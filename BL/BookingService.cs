using Models;
using Data;
using Mappers;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class BookingService : IBookingService
    {
        private IUnitOfWork unitOfWork;
        private IProductInShopService productInShopService;
        private IMapper<Booking, BookingEntity> bookingMapper;
        public BookingService(IProductInShopService productInShopService, IUnitOfWork unitOfWork, IMapper<Booking, BookingEntity> bookingMapper)
        {
            this.productInShopService = productInShopService;
            this.unitOfWork = unitOfWork;
            this.bookingMapper = bookingMapper;
        }

        public bool MakeBooking(User user, OrderingBLModel obm)
        {
            if (obm.ProductInShop.Quantity != 0)
            {
                Booking booking = new Booking { UserId = user.Id, ProductInShopId = obm.ProductInShop.Id, StartDate = obm.StartDate, EndDate = obm.EndDate };
                unitOfWork.BookingRepository.Create(bookingMapper.ToEntity(booking));
                productInShopService.DecreaseQuantity(obm.ProductInShop);
                unitOfWork.Save();
                return true;
            }
            return false;
        }
    }
}
