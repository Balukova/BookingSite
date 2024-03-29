﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class ProductInShop: IBase
    {
        public int Id { get; set; }
        public int ShopId { get; set; }

        public int ProductId { get; set; }

        public Shop Shop { get; set; }

        public Product Product { get; set; }

        public int Quantity { get; set; }

        public decimal Price { get; set; }
    }
}
