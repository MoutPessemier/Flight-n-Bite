using System.Collections.Generic;
using Flight_n_Bite_API.Model;
using Microsoft.AspNetCore.Mvc;

namespace Flight_n_Bite_API.Controllers
{
    [Route("api/[controller]")]
    [ApiConventionType(typeof(DefaultApiConventions))]
    [Produces("application/json")]
    [ApiController]
    public class OrderLineController : ControllerBase
    {
        private readonly IOrderLineRepository _orderLineRepository;

        public OrderLineController(IOrderLineRepository orderLineRepository)
        {
            _orderLineRepository = orderLineRepository;
        }

        [HttpGet]
        public List<OrderLine> GetOrderLines()
        {
            return _orderLineRepository.GetOrderLines();
        }

        [HttpGet("{id}")]
        public OrderLine GetOrderLine(int id)
        {
            return _orderLineRepository.GetOrderLineById(id);
        }

        [HttpPost("addOrderLine")]
        public ActionResult<OrderLine> AddOrderLine(OrderLine orderLine)
        {
            _orderLineRepository.Add(orderLine);
            _orderLineRepository.SaveChanges();
            return orderLine;
        }

        [HttpDelete("deleteOrderLine/{id}")]
        public void DeleteOrderLine(int id)
        {
            OrderLine orderLine = _orderLineRepository.GetOrderLineById(id);
            _orderLineRepository.Delete(orderLine);
            _orderLineRepository.SaveChanges();
        }
    }
}