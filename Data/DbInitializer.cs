using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
namespace Data
{
    public class DbInitializer: DropCreateDatabaseAlways<BookingDbContext>
    {
        protected override void Seed(BookingDbContext context)
        {
            context.Shops.Add(new ShopEntity { Name = "Rozetka" });
            context.Shops.Add(new ShopEntity { Name = "Eldorado" });
            context.Shops.Add(new ShopEntity { Name = "Comfy" });
            context.SaveChanges();
            context.Products.Add(new ProductEntity { Name = "xiaomi redmi note 9" });
            context.Products.Add(new ProductEntity { Name = "iPhone 7" });
            context.Products.Add(new ProductEntity { Name = "iPhone 11" });
            context.SaveChanges();
            context.ProductInShopEntities.Add(new ProductInShopEntity { ShopId = 1, ProductId=1, Quantity = 1, Price = 5000 });
            context.ProductInShopEntities.Add(new ProductInShopEntity { ShopId = 2, ProductId = 1, Quantity = 2, Price = 6754 });
            context.ProductInShopEntities.Add(new ProductInShopEntity { ShopId = 3, ProductId = 1, Quantity = 3, Price = 3555 });

            context.ProductInShopEntities.Add(new ProductInShopEntity { ShopId = 1, ProductId = 2, Quantity = 1, Price = 4555 });
            context.ProductInShopEntities.Add(new ProductInShopEntity { ShopId = 2, ProductId = 2, Quantity = 2, Price = 5434 });
            context.ProductInShopEntities.Add(new ProductInShopEntity { ShopId = 3, ProductId = 2, Quantity = 3, Price = 6000 });

            context.ProductInShopEntities.Add(new ProductInShopEntity { ShopId = 1, ProductId = 3, Quantity = 1, Price = 7000 });
            context.ProductInShopEntities.Add(new ProductInShopEntity { ShopId = 2, ProductId = 3, Quantity = 2, Price = 19000 });
            context.ProductInShopEntities.Add(new ProductInShopEntity { ShopId = 3, ProductId = 3, Quantity = 3, Price = 20000 });

            context.Users.Add(new UserEntity { Login = "Vika", Password = "12345" });
            context.Users.Add(new UserEntity { Login = "admin", Password = "123" });
            context.SaveChanges();
            base.Seed(context);
        }
    }
}
