using Flight__n_Bite.data;
using Flight__n_Bite.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Flight__n_Bite.ViewModels
{
    public class WeatherViewModel
    {
        public ObservableCollection<Day> Dates { get; set; }

        public WeatherViewModel()
        {
            LoadWeather();
        }

        private async void LoadWeather()
        {
            HttpService httpService = HttpService.instance;
           
            string json = await httpService.GetWeatherAsync(new Uri("http://api.meteomatics.com/nowP10D:P1D/t_2m:C/50,3/json"));
                       
            RootObject obj = JsonConvert.DeserializeObject<RootObject>(json);

            Dates = obj.Datas[0].Coordinates[0].Dates;
            Debug.Write("STAAAAAAAAAAAAAAAAAART" + Dates[0].Date + "HIERZOOOO");

        }

       }
}
