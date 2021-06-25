using Models;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mappers
{
    public class ShopMapper : IMapper<Shop, ShopEntity>
    {
        public Shop ToDomain(ShopEntity entity)
        {
            return new Shop { Id = entity.Id, Name = entity.Name };
        }

        public ShopEntity ToEntity(Shop domain)
        {
            return new ShopEntity { Id = domain.Id, Name = domain.Name };
        }
    }
}
