using Flight_n_Bite_API.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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
