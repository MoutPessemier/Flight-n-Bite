using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Flight_n_Bite_API.Model
{
    public interface IFlightRepository
    {
        Flight GetFlight();
        void Add(Flight flight);
        void SaveChanges();
    }
}
