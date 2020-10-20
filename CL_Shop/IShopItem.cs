using System;
using System.Collections.Generic;
using System.Text;

namespace CL_Shop
{
    interface IShopItem
    {
        int Id { get; set; }

        string GetStringRepl();

    }
}
