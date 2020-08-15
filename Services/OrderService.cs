using OrderMicroService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrderMicroService.Services
{
    public class OrderService : IOrderService
    {
        private List<Order> _orders = new List<Order>
        {
            new Order { UserId = 1, OrderId = 1, OrderAmount = 10000, OrderDate = DateTime.Now.Date  },
            new Order { UserId = 1, OrderId = 2, OrderAmount = 24000, OrderDate = DateTime.Now.AddDays(-1).Date  },
            new Order { UserId = 1, OrderId = 3, OrderAmount = 4000, OrderDate = DateTime.Now.AddDays(-2).Date  },
        };

        public OrderService()
        {

        }

        public List<Order> GetAll(int userId)
        {
            return _orders.Where(x => x.UserId == userId).ToList();
        }
    }
}
