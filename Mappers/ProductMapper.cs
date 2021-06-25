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
        public Product ToDomain(ProductEntity entity)
        {
            return new Product { Id = entity.Id,  Name = entity.Name };
        }

        public ProductEntity ToEntity(Product domain)
        {
            if (domain == null) return null;
            return new ProductEntity { Id = domain.Id, Name = domain.Name };
        }
    }
}
