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

        public Passenger GetPassenger(string firstname, string lastname, string seatIdentifier)
        {
            return _context.Passengers.FirstOrDefault(p => p.SeatIdentifier == seatIdentifier && p.LastName == lastname && p.FirstName == firstname);
        }

        public List<Passenger> GetPassengers()
        {
            return _context.Passengers.ToList();
        }

        public void SaveChanges()
        {
            _context.SaveChanges();
        }

        public void Update(Passenger passenger)
        {
            _context.Passengers.Update(passenger);
        }
    }
}
