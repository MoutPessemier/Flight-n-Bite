using System.Collections.Generic;

namespace Flight_n_Bite_API.Model
{
    public interface IOrderLineRepository
    {
        List<OrderLine> GetOrderLines();
        OrderLine GetOrderLineById(int id);
        void Add(OrderLine orderLine);
        void Delete(OrderLine orderline);
        void SaveChanges();
    }
}
