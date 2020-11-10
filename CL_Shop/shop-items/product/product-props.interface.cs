using System;
using System.Collections.Generic;
using System.Text;

namespace CL_Shop.ShopItems.product
{
    public interface IProductProps: IShopItemProps
    {
        string name { get; set; }
        string description { get; set; }

        double price { get; set; }
    }
}
