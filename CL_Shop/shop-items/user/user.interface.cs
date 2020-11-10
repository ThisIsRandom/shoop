using System;
using System.Collections.Generic;
using System.Text;

namespace CL_Shop.ShopItems
{
    public interface IUser : IShopItem
    {   
        string username { get;}
    }
}
