using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
using Entities;

namespace Mappers
{
    public class BookingMapper : IMapper<Booking, BookingEntity>
    {
        private IMapper<ProductInShop, ProductInShopEntity> productInShopMapper;
        public BookingMapper(IMapper<ProductInShop, ProductInShopEntity> productInShopMapper)
        {
            this.productInShopMapper = productInShopMapper;
        }
        public Booking ToDomain(BookingEntity entity)
        {
            return new Booking { Id = entity.Id, ProductInShop = productInShopMapper.ToDomain(entity.ProductInShop), UserId = entity.UserId, StartDate = entity.StartDate, EndDate = entity.EndDate };
        }

        public BookingEntity ToEntity(Booking domain)
        {
            return new BookingEntity { Id = domain.Id, ProductInShop = productInShopMapper.ToEntity(domain.ProductInShop), UserId = domain.UserId, StartDate = domain.StartDate, EndDate = domain.EndDate };
        }
    }
}
