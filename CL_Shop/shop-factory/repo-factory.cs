using CL_Shop.ShopItems;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Text;

namespace CL_Shop.shop_factory
{
    public class RepoFactory
    {
        public static OrderRepo createOrderRepo()
        {
            return new OrderRepo();
        }

        public static UserRepo createUserRepo()
        {
            return new UserRepo();
        }
        public static ProductRepo createProductRepo()
        {
            return new ProductRepo();
        }
    }
}

