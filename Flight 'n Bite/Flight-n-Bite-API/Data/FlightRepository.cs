using Flight_n_Bite_API.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Flight_n_Bite_API.Data
{
    public class FlightRepository : IFlightRepository
    {
        private readonly FlightDbContext _flightDbContext;

        public FlightRepository(FlightDbContext flightDbContext)
        {
            _flightDbContext = flightDbContext;
        }

        public void Add(Flight flight)
        {
            _flightDbContext.Add(flight);
        }

        public Flight GetFlight()
        {
            return _flightDbContext.Flights.FirstOrDefault();
        }

        public void SaveChanges()
        {
            _flightDbContext.SaveChanges();
        }
    }
}
