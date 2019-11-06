using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Flight_n_Bite_API.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Flight_n_Bite_API.Controllers
{
    [Route("api/[controller]")]
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
    }
}