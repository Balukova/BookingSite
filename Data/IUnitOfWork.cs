using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
namespace Data
{
    public interface IUnitOfWork : IDisposable
    {
        IProductRepository<ProductEntity, int> ProductRepository { get; }
        IShopRepository<ShopEntity, int> ShopRepository { get; }
        IProductInShopRepository<ProductInShopEntity, int> ProductInShopRepository { get; }
        IUserRepository<UserEntity, int> UserRepository { get; }
        IBookingRepository<BookingEntity, int> BookingRepository { get; }

        void Save();
        
    }
}
