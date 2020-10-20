using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CL_Shop
{
    public class OrderRepo: BaseRepo<Order>
    {
        public OrderRepo() : base()
        {

        }

        public double GetIncome(int days)
        {
            DateTime date = DateTime.Now.AddDays(-days);

            return this.items.FindAll(x => x.CreatedAt > date)
                    .Select(x => x.GetOrderPrice())
                    .Sum();
        }
    }
}
