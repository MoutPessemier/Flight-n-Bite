using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Flight_n_Bite_API.Model
{
    public class OrderLine
    {
        public int Id { get; set; }
        public Product Product { get; set; }
        public int Amount { get; set; }
    }
}
