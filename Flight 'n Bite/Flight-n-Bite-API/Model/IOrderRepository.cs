using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Flight_n_Bite_API.Model
{
    public interface IOrderRepository
    {
        List<Order> GetOrders(int userId);
        void Add(Order order);
        void SaveChanges();
    }
}
