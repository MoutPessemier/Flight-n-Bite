using Flight_n_Bite_API.Model;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace Flight_n_Bite_API.Data
{
    public class OrderLineRepository : IOrderLineRepository
    {
        private readonly FlightDbContext _context;

        public OrderLineRepository(FlightDbContext context)
        {
            _context = context;
        }

        public void Add(OrderLine orderLine)
        {
            _context.OrderLines.Add(orderLine);
        }

        public OrderLine GetOrderLineById(int id)
        {
            return _context.OrderLines.FirstOrDefault(ol => ol.Id == id);
        }

        public List<OrderLine> GetOrderLines()
        {
            return _context.OrderLines.Include(ol => ol.Product).ToList();
        }

        public void SaveChanges()
        {
            _context.SaveChanges();
        }
    }
}
