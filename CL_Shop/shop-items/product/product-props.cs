using CL_Shop.ShopItems.product;
using System;
using System.Collections.Generic;
using System.Text;

namespace CL_Shop.shop_items.product
{
    public class ProductProps : IProductProps
    {
        public string name { get; set; }
        public string description { get; set; }
        public double price { get; set; }
        public int id { get; set; }
    }
}
