using System;
using System.Collections.Generic;
using System.Text;

namespace CL_Shop
{
    public abstract class BaseItem: IShopItem
    {
        public static int PlaceHolderId = 0;
        public int Id { get; set; }

        public BaseItem()
        {
            this.Id = BaseItem.PlaceHolderId++;
        }

        public abstract string GetStringRepl();
        
    }
}
