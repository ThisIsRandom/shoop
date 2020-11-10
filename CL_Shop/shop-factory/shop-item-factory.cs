
using CL_Shop.ShopItems;
using CL_Shop.ShopItems.order;
using CL_Shop.ShopItems.product;
using CL_Shop.ShopItems.user;

namespace CL_Shop.shop_factory
{
    public class ShopItemFactory : IItemFactory
    {
        public IUser create(IUserProps props)
        {
            return new User(props);
        }

        public IProduct create(IProductProps props)
        {
            return new Product(props);
        }

        public IOrder create(IOrderProps props)
        {
            return new Order(props);
        }
    }
}
