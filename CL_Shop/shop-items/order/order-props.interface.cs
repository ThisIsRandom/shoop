using System;
using System.Collections.Generic;
using System.Text;

namespace CL_Shop.ShopItems.order
{
    public interface IOrderProps : IShopItemProps
    {
        
        List<IProduct> products { get; set; }
        IUser user { get; set; }
    }
}
