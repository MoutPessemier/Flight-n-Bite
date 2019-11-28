using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Flight_n_Bite_API.Model
{
    public class Flight
    {

        public int Id { get; set; }
        public string Number { get; set; }
        public string Departure { get; set; }
        public string Arrival { get; set; }
        public IList<Seat> Seats { get; set; }
        public double StartLatitude { get; set; }
        public double StartLongitude { get; set; }
        public double EndLatitude { get; set; }
        public double EndLongitude { get; set; }

        public Flight()
        {
            Seats = new List<Seat>();
        }

        public void AddSeat(Seat seat)
        {
            Seats.Add(seat);
        }

    }
    

        
}
