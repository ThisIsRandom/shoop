using System;
using System.Collections.Generic;
using System.Text;

namespace CL_Shop
{
    public class Product
    {
        public int ProductId;
        public string Description;
        public double Price;

        public Product(int Id, string Description, double Price)
        {
            this.ProductId = Id;
            this.Description = Description;
            this.Price = Price;

        }
    }
}
