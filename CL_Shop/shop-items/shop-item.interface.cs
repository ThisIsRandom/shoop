using System;
using System.Collections.Generic;
using System.Text;

namespace CL_Shop.ShopItems
{
    public interface IShopItem
    {
        int id { get; }

        DateTime createdAt { get; }
        
        string getStringRepl();

    }
}
