using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
namespace Data
{
    public interface IUnitOfWork 
    {
        IProductRepository<ProductEntity> ProductRepository { get; }
        IShopRepository<ShopEntity> ShopRepository { get; }
        IProductInShopRepository<ProductInShopEntity> ProductInShopRepository { get; }
        IUserRepository<UserEntity> UserRepository { get; }
        IBookingRepository<BookingEntity> BookingRepository { get; }

        void Save();
        
    }
}
