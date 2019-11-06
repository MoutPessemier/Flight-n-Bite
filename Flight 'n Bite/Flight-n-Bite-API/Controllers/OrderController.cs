using System.Collections.Generic;
using System.Linq;
using Flight_n_Bite_API.Model;
using Microsoft.AspNetCore.Mvc;

namespace Flight_n_Bite_API.Controllers
{
    [Route("api/[controller]")]
    [ApiConventionType(typeof(DefaultApiConventions))]
    [Produces("application/json")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        private readonly IOrderRepository _orderRepository;

        public OrderController(IOrderRepository orderRepository)
        {
            _orderRepository = orderRepository;
        }

        [HttpGet]
        public List<Order> GetOrders()
        {
            return _orderRepository.GetOrders();
        }

        [HttpGet("{id}")]
        public Order GetOrderById(int id)
        {
            return _orderRepository.GetOrders().FirstOrDefault(p => p.Id == id);
        }

        [HttpGet("/passenger/{id}")]
        public List<Order> GetOrdersByPassenger(int id)
        {
            return _orderRepository.GetOrdersByPassenger(id);
        }
    }
}