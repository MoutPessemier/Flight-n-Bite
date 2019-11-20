using System.Collections.Generic;

namespace Flight_n_Bite_API.Model
{
    public class Passenger
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string SeatIdentifier { get; set; }
    }
}
