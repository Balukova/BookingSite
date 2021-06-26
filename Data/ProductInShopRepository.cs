using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
namespace Data
{
    public class ProductInShopRepository: Repository<ProductInShopEntity, int>, IProductInShopRepository<ProductInShopEntity, int>
    {
        BookingDbContext context;
        public ProductInShopRepository(BookingDbContext context) : base(context)
        {
            this.context = context;
        }
        

        public IList<ProductInShopEntity> GetAvailableProductInShopsByProductName(string name)
        {
            return context.ProductInShopEntities.Include("Product").Include("Shop").Where(pis => pis.Product.Name.Equals(name) && pis.Quantity > 0).ToList();
        }

      
    }
}
