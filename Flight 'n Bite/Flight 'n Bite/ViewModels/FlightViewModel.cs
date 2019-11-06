using Flight__n_Bite.data;
using Flight__n_Bite.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Flight__n_Bite.ViewModels
{
    public class FlightViewModel : INotifyPropertyChanged
    {
        private Flight _flight;
        public Flight Flight {
            get {
                return _flight;
            }
            set {
                _flight = value;
                OnPropertyChanged("Flight");
            }
        }

        public FlightViewModel()
        {
            LoadFlight();
        }

        private async void LoadFlight()
        {
            HttpService httpService = HttpService.instance;
           
            string json = await httpService.GetStringAsync(new Uri("http://localhost:49527/api/flight"));
            Flight = JsonConvert.DeserializeObject<Flight>(json);
        }

        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            if (PropertyChanged != null)
            {
                this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
