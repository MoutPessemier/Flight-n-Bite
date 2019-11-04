using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Flight_n_Bite_API.Model
{
    public class Order
    {
        public int Id { get; set; }
        public Passenger Passenger { get; set; }
        public List<OrderLine> OrderLines { get; set; }
    }
}
