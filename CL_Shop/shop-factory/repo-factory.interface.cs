using CL_Shop.ShopItems;
using System;
using System.Collections.Generic;
using System.Text;

namespace CL_Shop.shop_factory
{
    interface IRepoFactory
    {
        BaseRepo<IShopItem> create(string type);
    }
}
