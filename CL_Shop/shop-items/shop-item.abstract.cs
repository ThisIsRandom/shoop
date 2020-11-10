using System;
using System.Collections.Generic;
using System.Text;

namespace CL_Shop.ShopItems
{
    public abstract class ShopItem : IShopItem
    {
        
        public DateTime createdAt { get; }

        public int id { get;  }

        public ShopItem(int id)
        {
            this.id = id;
            this.createdAt = DateTime.Now;
        }

        abstract public string getStringRepl();
        
    }
}
