using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
namespace Data
{
    public class BookingDbContext : DbContext
    {

        public BookingDbContext():base("DbConnection")
        {
            Database.SetInitializer(new DbInitializer());
        }
        public DbSet<ProductEntity> Products { get; set; }
        public DbSet<ShopEntity> Shops { get; set; }
        public DbSet<UserEntity> Users { get; set; }
        public DbSet<BookingEntity> Bookings { get; set; }
        public DbSet<ProductInShopEntity> ProductInShopEntities { get; set; }

    }
}
