using Acrelec.SCO.Server.Data;
using Acrelec.SCO.Server.Dto;
using Acrelec.SCO.Server.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Acrelec.SCO.Server.Controllers
{
    [ApiController]
    [Route("api-sco/v1")]
    public class OrderController : ControllerBase
    {

        private readonly ILogger<OrderController> _logger;
        private readonly DataContext _dc;
        private bool isAvailable = true;

        public OrderController(ILogger<OrderController> logger, DataContext dc)
        {
            _logger = logger;
            _dc = dc;
        }

        [HttpGet("availability")]
        public IActionResult GetAvailability()
        {
            var result = new { CanInjectOrders = isAvailable };
            return Ok(result);
        }

        [HttpPost("injectorder")]
        public IActionResult AddOrder(RequestOrderDto requestOrder)
        {
             Order order = new Order();
             List<OrderItem> orderItems = new List<OrderItem>(requestOrder.Order.OrderItems.Count());
             
             foreach (OrderItemDto orderItem in requestOrder.Order.OrderItems)
             {
                 orderItems.Add(new OrderItem()
                 {
                     ItemCode = orderItem.ItemCode,
                     Quantity = orderItem.Qty
                 });        
             }

             order.OrderItems = orderItems;
             order.Customer = new Customer()
             {
                Address = requestOrder.Customer.Address,
                Username = requestOrder.Customer.FirstName
             };

             _dc.Orders.Add(order);
             _dc.SaveChanges();

            return Ok(new { OrderNumber = order.Id });
        }
    }
}
