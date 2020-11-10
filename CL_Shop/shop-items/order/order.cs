using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CL_Shop.ShopItems.order
{
    public class Order : ShopItem, IOrder
    {
        public IUser _user { get; }

        public List<IProduct> _products { get; }

        public override string getStringRepl()
        {
            return $"ORDER ID: {this.id} --- ORDERED BY: {this._user.username} --- PRODUCT COUNT: {this._products.Count} --- ORDER CREATED: {this.createdAt}";
        }

        public double getOrderPrice()
        {
            return this._products
                    .Select(item => item.price)
                    .Sum();
        }

        public void addProduct(IProduct product)
        {
            this._products.Add(product);
        }

        public Order(IOrderProps props) : base(props.id)
        {
            this._products = props.products;
            this._user = props.user;
        }
    }
}
