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

        public Flight GetFlight()
        {
            return _flightDbContext.Flights.FirstOrDefault();
        }
    }
}
