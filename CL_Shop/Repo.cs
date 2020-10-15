using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;

namespace CL_Shop
{
    public class Repo
    {

        private List<User> _Users = new List<User> { };
        private List<Order> _Orders = new List<Order> { };
        private List<Product> _Products = new List<Product> { };

        public void AddItem<T>(T Item)
        {
            if (Item is User)
            {
                this._Users
                    .Add(Item as User);
            }
            
            if (Item is Order)
            {
                this._Orders
                    .Add(Item as Order);
            }
            
            if (Item is Product)
            {
                this._Products
                    .Add(Item as Product);
            }
        }

        public void DeleteItem<T>(T item)
        {
            if (item is User)
            {
                this._Users
                    .RemoveAll((User user) => user == item as User);
            }
            
            if (item is Order)
            {
                this._Orders
                    .RemoveAll((Order order) => order == item as Order);
            }
            
            if (item is Product)
            {
                this._Products
                    .RemoveAll((Product product) => product == item as Product);
            }
        }

        public double GetDailyIncome()
        {
            return this._Orders
                .Select((Order order) => order.Product.Price)
                .ToList()
                .Sum();
        }


        public T GetItemById<T>(int ItemId) where T: class
        {          

            if (typeof(T) == typeof(Order))
            {
                return this._Orders
                    .Find((Order order) => order.OrderId == ItemId) as T;
            }

            if (typeof(T) == typeof(Product))
            {
                return this._Products
                    .Find((Product product) => product.ProductId == ItemId) as T;
            }

            if (typeof(T) == typeof(User))
            {
                return this._Users
                    .Find((User user) => user.UserId == ItemId) as T;
            }

            return null;
    
        }

        public List<T> GetList<T>()
        {

            if(typeof(T) == typeof(Order))
            {
                return this._Orders as List<T>;
            }

            if (typeof(T) == typeof(Product))
            {
                return this._Products as List<T>;
            }

            if (typeof(T) == typeof(User))
            {
                return this._Users as List<T>;
            }

            return null;
        }
    }
}
