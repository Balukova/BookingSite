using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using Entities;
using BL;
using Data;
using Mappers;
using Models;
namespace WpfApp
{
    /// <summary>
    /// Логика взаимодействия для App.xaml
    /// </summary>
    public partial class App : Application
    {
        private IServiceProvider serviceProvider;
        public App()
        {
            ServiceCollection services = new ServiceCollection();
            OnConfigure(services);
            serviceProvider = services.BuildServiceProvider();
        }
        private void OnConfigure(ServiceCollection services)
        {
            services.AddSingleton<IProductRepository<ProductEntity, int>, ProductRepository>();
            services.AddSingleton<IShopRepository<ShopEntity, int>, ShopRepository>();
            services.AddSingleton<IProductInShopRepository<ProductInShopEntity, int>, ProductInShopRepository>();
            services.AddSingleton<IUserRepository<UserEntity, int>, UserRepository>();
            services.AddSingleton<IBookingRepository<BookingEntity, int>, BookingRepository>();

            services.AddSingleton<IMapper<User, UserEntity>, UserMapper>();
            services.AddSingleton<IMapper<Product, ProductEntity>, ProductMapper>();
            services.AddSingleton<IMapper<Shop, ShopEntity>, ShopMapper>();
            services.AddSingleton<IMapper<ProductInShop, ProductInShopEntity>, ProductInShopMapper>();
            services.AddSingleton<IMapper<Booking, BookingEntity>, BookingMapper>();

            services.AddSingleton<BookingDbContext>();
            services.AddSingleton<IUnitOfWork, UnitOfWork>();
            services.AddSingleton<IUserService, UserService>();
            services.AddSingleton<IProductInShopService, ProductInShopService>();
            services.AddSingleton<IBookingService, BookingService>();
            services.AddSingleton<NavigationService>();
            services.AddSingleton<MainViewModel>();
            services.AddSingleton<MainWindow>();
        }
        protected override void OnStartup(StartupEventArgs e)
        {
            MainWindow mv = serviceProvider.GetRequiredService<MainWindow>();
            mv.Show();
            base.OnStartup(e);
        }
    }
}
