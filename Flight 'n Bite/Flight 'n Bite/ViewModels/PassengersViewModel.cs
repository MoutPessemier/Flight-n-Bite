using Flight__n_Bite.data;
using Flight__n_Bite.Models;
using Flight_n_Bite_API.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Flight__n_Bite.ViewModels
{
    class PassengersViewModel 
    {
        public ObservableCollection<PassengerSeat> Passengers { get; set; }

        public PassengersViewModel()
        {
            LoadFlightAndPassengers();
            Passengers = new ObservableCollection<PassengerSeat>();
        }

        private void LoadFlightAndPassengers()
        {
            refreshSeats();
        }
        public async void refreshSeats()
        {

            HttpService httpService = HttpService.instance;

            string jsonflight = await httpService.GetStringAsync(new Uri("http://localhost:49527/api/flight"));
            var seats = JsonConvert.DeserializeObject<Flight>(jsonflight).Seats;
            string jsonPassenger = await httpService.GetStringAsync(new Uri("http://localhost:49527/api/passenger"));
            var passengers = JsonConvert.DeserializeObject<List<Passenger>>(jsonPassenger);
            Passengers.Clear();
            foreach (var seat in seats)
            {
                var passenger = passengers.FirstOrDefault(p => p.SeatIdentifier == seat.Number);
                if (passenger != null)
                    Passengers.Add(new PassengerSeat() { Passenger = passenger, Seat = seat });
                else
                    Passengers.Add(new PassengerSeat() { Seat = seat });


            }
        }

       
    
    }
}
