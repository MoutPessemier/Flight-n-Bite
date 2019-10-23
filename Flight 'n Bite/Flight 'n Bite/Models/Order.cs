using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flight__n_Bite.Models
{
    public class Order
    {
        public int Id { get; set; }
        public int PassengerId { get; set; }
        public List<OrderLine> OrderLines { get; set; }
    }
}
