using Flight_n_Bite_API.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;

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

            var flight = _flightDbContext.Flights.Include(f => f.Seats).FirstOrDefault();
            flight.Seats = flight.Seats.OrderBy(s => Int32.Parse(s.Number.Substring(1))).ToList();
            return flight;
        }

        public void SaveChanges()
        {
            _flightDbContext.SaveChanges();
        }
    }
}
