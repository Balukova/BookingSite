using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
namespace Data
{
    public class ProductInShopRepository: Repository<ProductInShopEntity>, IProductInShopRepository<ProductInShopEntity>
    {
        BookingDbContext context;
        public ProductInShopRepository(BookingDbContext context) : base(context)
        {
            this.context = context;
        }
        

        public IList<ProductInShopEntity> GetProductInShopsByProductName(string name)
        {
            return context.ProductInShopEntities.Include("Product").Include("Shop").Where(pis => pis.Product.Name.Equals(name)).ToList();
        }

        public void DecreaseQuantity(ProductInShopEntity entity)
        {
            if (entity.Quantity <= 1)
            {
                DeleteById(entity.Id);
            }
            else
            {
                entity.Quantity -= 1;
                Update(entity);
            }
        }

        public void IncreaseQuantity(ProductInShopEntity entity)
        {
            entity.Quantity += 1;
            Update(entity);
        }
      
    }
}
