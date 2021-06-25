using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
namespace BL
{
    public interface IProductInShopService
    {
        IList<ProductInShop> GetProductInShopsByProductName(string name);
        void DecreaseQuantity(ProductInShop entity);
        void IncreaseQuantity(ProductInShop entity);
    }
}
