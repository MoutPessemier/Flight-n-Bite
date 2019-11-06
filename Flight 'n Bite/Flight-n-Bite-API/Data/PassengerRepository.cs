using Flight_n_Bite_API.Model;
using System.Collections.Generic;
using System.Linq;

namespace Flight_n_Bite_API.Data
{
    public class PassengerRepository : IPassengerRepository
    {
        private readonly FlightDbContext _context;

        public PassengerRepository(FlightDbContext context)
        {
            _context = context;
        }

        public void Add(Passenger passenger)
        {
            _context.Passengers.Add(passenger);
        }

        public Passenger GetPassenger(int passengerId)
        {
            return _context.Passengers.FirstOrDefault(p => p.Id == passengerId);
        }

        public List<Passenger> GetPassengers()
        {
            return _context.Passengers.ToList();
        }

        public void SaveChanges()
        {
            _context.SaveChanges();
        }
    }
}
