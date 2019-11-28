using System.Collections.Generic;

namespace Flight_n_Bite_API.Model
{
    public class Order
    {
        public int Id { get; set; }
        public Passenger Passenger { get; set; }
        public bool IsHandled { get; set; }
        public List<OrderLine> OrderLines { get; set; }
    }
}
