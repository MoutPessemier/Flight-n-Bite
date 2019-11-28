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

        [HttpPost("addOrder")]
        public ActionResult<Order> AddOrderLine(Order order)
        {
            _orderRepository.Add(order);
            _orderRepository.SaveChanges();
            return order;
        }

        [HttpGet("getByPassengerId/{id}")]
        public List<Order> GetOrdersByPassenger(int id)
        {
            return _orderRepository.GetOrdersByPassenger(id);
        }

        [HttpPost("handleOrder")]
        public void handleOrder(Order order)
        {
            _orderRepository.Handleorder(order.Id);
            _orderRepository.SaveChanges();
        }
    }
}