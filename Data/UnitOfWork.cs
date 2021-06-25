using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
namespace Data
{
    public class UnitOfWork: IUnitOfWork
    {


        private BookingDbContext context;
        public UnitOfWork(BookingDbContext context)
        {
            this.context = context;
            ProductRepository = new ProductRepository(context);
            ShopRepository = new ShopRepository(context);
            ProductInShopRepository = new ProductInShopRepository(context);
            UserRepository = new UserRepository(context);
            BookingRepository = new BookingRepository(context);
        }

        public IProductRepository<ProductEntity> ProductRepository { get; private set; }
        public IShopRepository<ShopEntity> ShopRepository { get; private set; }
        public IProductInShopRepository<ProductInShopEntity> ProductInShopRepository { get; private set; }
        public IUserRepository<UserEntity> UserRepository { get; private set; }
        public IBookingRepository<BookingEntity> BookingRepository { get; private set; }

        public void Save()
        {
            context.SaveChanges();
        }
    }
}
