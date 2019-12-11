namespace Flight_n_Bite_API.Model
{
    public interface IFlightRepository
    {
        Flight GetFlight();
        void Add(Flight flight);
        void SaveChanges();
    }
}
