using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingSite
{
    public class ConsoleDataGetter : IDataGetter
    {
        public DateTime GetBookingPeriod()
        {
            Console.WriteLine("Enter booking period (number of days)...");
            int result = 7;
            while (!int.TryParse(Console.ReadLine(), out result) || result <= 0)
            {
                Console.WriteLine("Valuse must be postive integer greater than zero...");
            }
            return DateTime.Now.AddDays(result);
        }

        public string GetProductName()
        {
            Console.WriteLine("Enter product name...");
            return Console.ReadLine();
        }

        public ProductInShop GetSelectedProductInShop(IList<ProductInShop> productInShop)
        {
            Console.WriteLine(string.Format("Choose shop where book {0} \n(Write the number of row)", productInShop.First().Product.Name));
            for (int i = 0; i < productInShop.Count; i++)
            {
                Console.WriteLine(string.Format("{0}. In shop {1} has a price {2}", i + 1, productInShop[i].Shop.Name, productInShop[i].Price));
            }
            int selectedIndex = int.Parse(Console.ReadLine());
            while( selectedIndex < 1 || selectedIndex > productInShop.Count)
            {
                Console.WriteLine($"Incorect number. Number must be in range [1, {productInShop.Count}]\n");
                selectedIndex = int.Parse(Console.ReadLine());
            }
            return productInShop[selectedIndex - 1];
        }

        public string GetUserLogin()
        {
            Console.WriteLine("Enter Login...");
            return Console.ReadLine();
        }

        public string GetUserPassword()
        {
            Console.WriteLine("Enter password...");
            return Console.ReadLine();
        }
    }
}
