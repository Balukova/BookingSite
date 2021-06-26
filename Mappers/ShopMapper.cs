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
        public Shop ToModel(ShopEntity entity)
        {
            if (entity == null) return null;
            return new Shop { Id = entity.Id, Name = entity.Name };
        }

        public ShopEntity ToEntity(Shop model)
        {
            if (model == null) return null;
            return new ShopEntity { Id = model.Id, Name = model.Name };
        }
    }
}
