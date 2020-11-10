using System;
using System.Collections.Generic;
using System.Text;

namespace CL_Shop.ShopItems.product
{
    class Product : ShopItem, IProduct
    {
        public string productName { get; }

        public string description { get; }

        public double price { get; }

        public override string getStringRepl()
        {
            return $"PRODUCT ID: {this.id} --- PRODUCT NAME: {this.productName} --- PRODUCT PRICE: {this.price}";
        }

        public Product(IProductProps props): base(props.id)
        {
            this.productName = props.name;
            this.description = props.description;
            this.price = props.price;

        }
    }
}
