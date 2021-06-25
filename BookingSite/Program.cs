using BL;
using Data;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingSite
{
    class Program
    {
        public static void Main(string[] args)
        {
            IDataGetter dataGetter = new ConsoleDataGetter();
            IUnitOfWork unitOfWork = new UnitOfWork(new BookingDbContext());
            IProductInShopService productInShopService = new ProductInShopService(unitOfWork);
            IUserService userService = new UserService(unitOfWork);
            IBookingService bookingService = new BookingService(productInShopService, unitOfWork);
            User currentUser = null;
            while (currentUser == null)
            {
              currentUser = userService.GetUserByLoginAndPassword(dataGetter.GetUserLogin(), dataGetter.GetUserPassword());
            }
            bool wantMore = true;
            while (wantMore)
            {
                IList<ProductInShop> productInShops = productInShopService.GetProductInShopsByProductName(dataGetter.GetProductName());
                while (productInShops.Count == 0)
                {
                    Console.WriteLine("No products were found. Try another product name...");
                    productInShops = productInShopService.GetProductInShopsByProductName(dataGetter.GetProductName());
                }
                ProductInShop selectedProduct = dataGetter.GetSelectedProductInShop(productInShops);
                DateTime endDate = dataGetter.GetBookingPeriod();
                bookingService.MakeBooking(currentUser, selectedProduct, DateTime.Now, endDate);
                Console.WriteLine("Thank you for booking");
                Console.WriteLine("Do you want to continue? (yes/no)");
                wantMore = Console.ReadLine().ToLower().Equals("yes");
            }
            
        }
    }
}
