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
        private bool disposedValue;

        public UnitOfWork(BookingDbContext context)
        {
            this.context = context;
            ProductRepository = new ProductRepository(context);
            ShopRepository = new ShopRepository(context);
            ProductInShopRepository = new ProductInShopRepository(context);
            UserRepository = new UserRepository(context);
            BookingRepository = new BookingRepository(context);
        }

        public IProductRepository<ProductEntity, int> ProductRepository { get; private set; }
        public IShopRepository<ShopEntity, int> ShopRepository { get; private set; }
        public IProductInShopRepository<ProductInShopEntity, int> ProductInShopRepository { get; private set; }
        public IUserRepository<UserEntity, int> UserRepository { get; private set; }
        public IBookingRepository<BookingEntity, int> BookingRepository { get; private set; }

        public void Save()
        {
            context.SaveChanges();
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    // TODO: освободить управляемое состояние (управляемые объекты)
                }

                // TODO: освободить неуправляемые ресурсы (неуправляемые объекты) и переопределить метод завершения
                // TODO: установить значение NULL для больших полей
                disposedValue = true;
            }
        }

        // // TODO: переопределить метод завершения, только если "Dispose(bool disposing)" содержит код для освобождения неуправляемых ресурсов
        // ~UnitOfWork()
        // {
        //     // Не изменяйте этот код. Разместите код очистки в методе "Dispose(bool disposing)".
        //     Dispose(disposing: false);
        // }

        public void Dispose()
        {
            // Не изменяйте этот код. Разместите код очистки в методе "Dispose(bool disposing)".
            Dispose(disposing: true);
            GC.SuppressFinalize(this);
        }
    }
}
