using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class ProductInShopEntity: IBaseEntity
    {
        public int Id { get; set; }

        public int ShopId { get; set; }

        public int ProductId { get; set; }

        public ShopEntity Shop { get; set; }

        public ProductEntity Product { get; set; }

        public int Quantity { get; set; }

        public decimal Price { get; set; }
    }
}
