using System.Collections.Generic;

namespace Flight_n_Bite_API.Model
{
    public interface IPassengerRepository
    {
        List<Passenger> GetPassengers();
        Passenger GetPassenger(int passengerId);
        Passenger GetPassenger(string Firstname, string Lastname, string seatIdentifier);
        void Add(Passenger passenger);
        void Update(Passenger passenger);
        void SaveChanges();
    }
}
