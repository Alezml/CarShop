using Shop.Data.Interfaces;
using Shop.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Data.Repository
{
    public class OrderRepository : IAllOrders
    {
        private readonly AppDBContent appDBcontent;
        private readonly ShopCart shopCart;
        public OrderRepository(AppDBContent appDBcontent, ShopCart shopCart)
        {
            this.appDBcontent = appDBcontent;
            this.shopCart = shopCart;
        }
        public void createOrder(Order order)
        {
            order.orderTime = DateTime.Now;
            appDBcontent.Order.Add(order);
            appDBcontent.SaveChanges();

            var items = shopCart.listShopItems;

            foreach(var el in items)
            {
                var orderDetail = new OrderDetail()
                {
                    CarID = el.car.id,
                    orderid = order.id,
                    price = el.car.price
                };
                appDBcontent.OrderDetail.Add(orderDetail);
            }
            appDBcontent.SaveChanges();
        }
    }
}
