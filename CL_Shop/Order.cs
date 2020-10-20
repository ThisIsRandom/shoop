using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CL_Shop
{
    public class Order: BaseItem
    {
        private User _User;
        private List<Product> _Products = new List<Product>();
        public DateTime CreatedAt { get; private set; }
       
        public Order(User User, List<Product> ProductsToBeAdded)
        {
            this._User = User;
            this._Products = ProductsToBeAdded;
            this.CreatedAt = DateTime.Now;
        }

        public override string GetStringRepl()
        {
            return $"ORDER ID: {this.Id} --- ORDERED BY: {this._User.Username} --- PRODUCT COUNT: {this._Products.Count} --- ORDER CREATED: {this.CreatedAt}";
        }

        public double GetOrderPrice()
        {
            return this._Products
                    .Select(item => item.Price)
                    .Sum();
        }

        public void AddProduct(Product product)
        {
            this._Products.Add(product);
        }

        public List<Product> GetProducts()
        {
            return this._Products.Select(x => x).ToList();
        }
    }
}
