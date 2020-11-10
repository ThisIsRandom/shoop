using System;
using System.Collections.Generic;
using System.Text;

namespace CL_Shop.ShopItems
{
   public interface IOrder : IShopItem
    {

        IUser _user { get; }
        List<IProduct> _products { get; }
        double getOrderPrice();
        void addProduct(IProduct product);

    }
}
