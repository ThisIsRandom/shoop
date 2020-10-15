using System;
using System.Collections.Generic;
using System.Text;

namespace CL_Shop
{
    public class Order
    {
        public User User;
        public Product Product;
        public int OrderId;

        public Order(User User, Product Product, int Id)
        {
            this.User = User;
            this.Product = Product;
            this.OrderId = Id;
        }

    }
}
