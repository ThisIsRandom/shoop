using System;
using System.Collections.Generic;
using System.Text;

namespace CL_Shop
{
    public abstract class BaseItem: IShopItem
    {
        private static int _PlaceHolderId = 1;
        public int Id { get; set; }

        public BaseItem()
        {
            this.Id = BaseItem._PlaceHolderId++;
        }

        public abstract string GetStringRepl();
        
    }
}
