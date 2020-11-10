using CL_Shop.ShopItems;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CL_Shop
{
    public class OrderRepo: BaseRepo<IOrder>
    {
        public OrderRepo() : base()
        {

        }

        public double GetIncome(int days)
        {
            DateTime date = DateTime.Now.AddDays(-days);

            return this.items.FindAll(x => x.createdAt > date)
                    .Select(x => x.getOrderPrice())
                    .Sum();
        }
    }
}
