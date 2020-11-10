using System;
using System.Collections.Generic;
using System.Text;

namespace CL_Shop.ShopItems
{
    public interface IProduct: IShopItem
    {
        string productName { get; }
        string description { get; }
        double price { get;  }
        
    }
}
