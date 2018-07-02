using System;
using System.Linq;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using TravelLine.Kitchen.WebApi.Models.Entity;
using TravelLine.Kitchen.WebApi.Models.Dto;
using TravelLine.Kitchen.WebApi.Core;

namespace TravelLine.Kitchen.WebApi.Controllers
{
    [Route("api")]
    [ApiController]
    public class OrdersController : ControllerBase
    {
        private readonly OrderContext dbOrder;

        public OrdersController(OrderContext context)
        {
            dbOrder = context;
        }

        [Route("orders")]
        public IActionResult Orders()
        {
            List<Order> orders = dbOrder.Orders.ToList();

            return Ok(orders.ConvertAll(
            new Converter<Order, OrderDto>(Converter.ConvertOrders)));
        }

        [Route("orders/{id:int}")]
        public IActionResult OrderItem(int? id = 0)
        {
            var OrderId = dbOrder.Orders.Find(id);

            if (OrderId == null)
                return NotFound();
            else
                return Ok(Converter.ConvertOrders(OrderId));
        }
    }
}
