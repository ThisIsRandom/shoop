using CL_Shop.ShopItems.user;
using System;
using System.Collections.Generic;
using System.Text;

namespace CL_Shop.shop_items.user
{
    public class UserProps : IUserProps
    {
        public string username { get; set; }
        public int id { get; set; }
    }
}
