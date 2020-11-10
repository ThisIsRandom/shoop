using CL_Shop.ShopItems;
using CL_Shop.ShopItems.order;
using CL_Shop.ShopItems.product;
using CL_Shop.ShopItems.user;
using System;
using System.Collections.Generic;
using System.Text;

namespace CL_Shop.shop_factory
{
    public interface IItemFactory
    {
        IUser create(IUserProps props);
        IProduct create(IProductProps props);
        IOrder create(IOrderProps props);
    }
}
