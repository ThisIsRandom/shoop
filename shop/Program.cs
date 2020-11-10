using CL_Shop.shop_factory;
using System;

namespace shop
{
    class Program
    {
        static void Main(string[] args)
        {
            new Shop(
                new ShopItemFactory()
                );
        }
    }
}
