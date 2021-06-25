using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingSite
{
    public interface IDataGetter
    {
        string GetUserLogin();
        string GetUserPassword();
        string GetProductName();
        ProductInShop GetSelectedProductInShop(IList<ProductInShop> productInShop);
        DateTime GetBookingPeriod();
    }
}
