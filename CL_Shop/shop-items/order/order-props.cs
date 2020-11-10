using CL_Shop.ShopItems;
using CL_Shop.ShopItems.order;
using System;
using System.Collections.Generic;
using System.Text;

namespace CL_Shop.shop_items.order
{
    public class OrderProps : IOrderProps
    {
        public List<IProduct> products { get; set; }
        public IUser user { get; set; }

        public int id { get; set; }
    }
}
