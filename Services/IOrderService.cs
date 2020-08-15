using OrderMicroService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrderMicroService.Services
{
    public interface IOrderService
    {
        public List<Order> GetAll(int userId);
    }
}
