using Flight__n_Bite.data;
using Flight__n_Bite.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Flight__n_Bite.ViewModels
{
    public class FlightViewModel
    {
        public Flight Flight { get; set; }

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
    }
}
