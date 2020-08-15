using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using OrderMicroService.Models;
using OrderMicroService.Services;
using OrderMicroService.ViewModel;

namespace OrderMicroService.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class OrderController : ControllerBase
    {
        private readonly IOrderService _orderService;

        public OrderController(IOrderService orderService)
        {
            _orderService = orderService;
        }

        [HttpGet("{id:int}")]
        public ActionResult Get(int id)
        {

            var orderList= _orderService.GetAll(id);

            if (orderList == null)
            {
                return NotFound();
            }
            List<OrderViewModel> OrderList = orderList.Select(x => new OrderViewModel { OrderId = x.OrderId, OrderAmount = x.OrderAmount, OrderDate = x.OrderDate }).ToList();

            return Ok(OrderList);
        }
    }
}
