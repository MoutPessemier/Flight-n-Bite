using Flight_n_Bite_API.Model;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace Flight_n_Bite_API.Data
{
    public class OrderRepository : IOrderRepository
    {
        private readonly FlightDbContext _context;

        public OrderRepository(FlightDbContext context)
        {
            _context = context;
        }

        public void Add(Order order)
        {
            List<OrderLine> orderLinesList = new List<OrderLine>();
            foreach (var orderLine in order.OrderLines)
            {
                orderLinesList.Add(_context.OrderLines.Include(ol => ol.Product).FirstOrDefault(ol => ol.Id == orderLine.Id));
            } 
            foreach (var orderLine in orderLinesList)
            {
                orderLine.Product = _context.Products.FirstOrDefault(p => p.Id == orderLine.Product.Id);
            }
            order.OrderLines = orderLinesList;
            order.Passenger = _context.Passengers.FirstOrDefault(p => p.Id == order.Passenger.Id);
            _context.Add(order);
        }

        public List<OrderLine> GetOrderLinesByOrder(int id)
        {
            return _context.Orders.FirstOrDefault(o => o.Id == id).OrderLines;
        }

        public List<Order> GetOrders()
        {
            return _context.Orders.Include(o => o.OrderLines).ThenInclude(ol => ol.Product).ToList();
        }

        public List<Order> GetOrdersByPassenger(int passengerId)
        {
            return _context.Orders.Include(o => o.OrderLines).ThenInclude(ol => ol.Product).Where(o => o.Passenger.Id == passengerId).ToList();
        }

        public void SaveChanges()
        {
            _context.SaveChanges();
        }
    }
}
