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
        public Booking ToModel(BookingEntity entity)
        {
            if (entity == null) return null;
            return new Booking { Id = entity.Id, ProductInShop = productInShopMapper.ToModel(entity.ProductInShop), ProductInShopId = entity.ProductInShopId, UserId = entity.UserId, StartDate = entity.StartDate, EndDate = entity.EndDate };
        }

        public BookingEntity ToEntity(Booking model)
        {
            if (model == null) return null;
            return new BookingEntity { Id = model.Id, ProductInShop = productInShopMapper.ToEntity(model.ProductInShop), ProductInShopId = model.ProductInShopId, UserId = model.UserId, StartDate = model.StartDate, EndDate = model.EndDate };
        }
    }
}
