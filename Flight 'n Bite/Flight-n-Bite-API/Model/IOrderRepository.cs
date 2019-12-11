using System.Collections.Generic;

namespace Flight_n_Bite_API.Model
{
    public interface IOrderRepository
    {
        List<Order> GetOrders();
        List<Order> GetOrdersByPassenger(int userId);
        List<OrderLine> GetOrderLinesByOrder(int id);
        void Add(Order order);
        void Handleorder(int id);
        void DeleteOrder(int id);
        void SaveChanges();
    }
}
