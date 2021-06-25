using BL;
using Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controllers
{
    public class BookingSiteController
    {
        private IUserService<User> userService;
        private IProductInShopService<ProductInShop> productInShopService;
        private IBookingService<Booking> bookingService;
        public BookingSiteController(IUserService<User> userService, IProductInShopService<ProductInShop> productInShopService, IBookingService<Booking> bookingService)
        {
            this.userService = userService;
            this.productInShopService = productInShopService;
            this.bookingService = bookingService;
        }
        public User GetUserByLoginAndPassword(string login, string password)
        {
            return userService.GetUserByLoginAndPassword(login, password);
        }
        public IList<ProductInShop> GetProductInShopsByProductName(string productName)
        {
            return productInShopService.GetProductInShopsByProductName(productName);
        }

        public Booking MakeBooking(User user, ProductInShop productInShop, DateTime startDate, DateTime endDate)
        {
            return bookingService.MakeBooking(user, productInShop, startDate, endDate);
        }

    }
}
