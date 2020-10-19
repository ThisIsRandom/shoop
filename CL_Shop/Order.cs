using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CL_Shop
{
    public class Order: BaseItem
    {
        public User User;
        public List<Product> Products = new List<Product>();
        public DateTime CreatedAt;
       
        public Order(User User, List<Product> ProductsToBeAdded)
        {
            this.User = User;
            this.Products = ProductsToBeAdded;
            this.CreatedAt = DateTime.Now;
        }

        public override string GetStringRepl()
        {
            return $"ORDER ID: {this.Id} --- ORDERED BY: {this.User.Username} --- PRODUCT COUNT: {this.Products.Count} --- ORDER CREATED: {this.CreatedAt}";
        }

        public double GetOrderPrice()
        {
            return this.Products
                    .Select(item => item.Price)
                    .Sum();
        }
    }
}
