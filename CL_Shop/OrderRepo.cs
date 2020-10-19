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

        public double GetIncome()
        {
            return items.Select(item => item.GetOrderPrice())
                .Sum();
        }
    }
}
