using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
using Entities;
namespace Mappers
{
    public class ProductMapper : IMapper<Product, ProductEntity>
    {
        public Product ToModel(ProductEntity entity)
        {
            if (entity == null) return null;
            return new Product { Id = entity.Id,  Name = entity.Name };
        }

        public ProductEntity ToEntity(Product model)
        {
            if (model == null) return null;
            return new ProductEntity { Id = model.Id, Name = model.Name };
        }
    }
}
