using System;
using System.Collections.Generic;
using System.Text;

namespace CL_Shop
{
    public class Product : BaseItem
    {
        public string ProductName;
        public string Description;
        public double Price;

        public Product(string Name, string Description, double Price): base()
        {

            this.ProductName = Name;
            this.Description = Description;
            this.Price = Price;

        }

        public override string GetStringRepl()
        {
            return $"PRODUCT ID: {this.Id} --- PRODUCT NAME: {this.ProductName} --- PRODUCT PRICE: {this.Price}";
        }
    }
}
