using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Flight_n_Bite_API.Model
{
    public interface IPassengerRepository
    {
        List<Passenger> GetPassengers();
        Passenger GetPassenger(int passengerId);
        Passenger GetPassenger(string seatIdentifier);
        void Add(Passenger passenger);
        void SaveChanges();
    }
}
