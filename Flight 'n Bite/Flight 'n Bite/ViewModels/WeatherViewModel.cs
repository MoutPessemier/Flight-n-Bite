using Flight__n_Bite.data;
using Flight__n_Bite.Models;
using Newtonsoft.Json;
using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Flight__n_Bite.ViewModels
{
    public class WeatherViewModel : INotifyPropertyChanged
    {
        public Flight Flight { get; set; }
        private bool _weatherAvailable;
        public bool WeatherAvailable {
            get {
                return _weatherAvailable;
            }
            set {
                _weatherAvailable = value;
                OnPropertyChanged("WeatherAvailable");
            }
        }
        public ObservableCollection<Day> Dates { get; set; }
        private readonly HttpService httpService = HttpService.instance;

        public WeatherViewModel()
        {
            WeatherAvailable = true;
            Dates = new ObservableCollection<Day>();

            LoadWeather();
        }

        private async void LoadWeather()
        {
            try
            {
                string json = await httpService.GetStringAsync(new Uri("http://localhost:49527/api/flight"));
                Flight = JsonConvert.DeserializeObject<Flight>(json);
                string url = "http://api.meteomatics.com/nowP7D:P1D/t_2m:C,effective_cloud_cover:p,rain_water:kgm2/" + Flight.EndLatitude.ToString() + "," + Flight.EndLongitude.ToString() + "/json";
                string jsonWeather = await httpService.GetWeatherAsync(new Uri(url));

                RootObject obj = JsonConvert.DeserializeObject<RootObject>(jsonWeather);
                for (int i = 0; i < obj.Datas[0].Coordinates[0].Dates.Count; i++)
                {
                    Dates.Add(new Day()
                    {
                        Date = obj.Datas[0].Coordinates[0].Dates[i].Date,
                        Temperature = obj.Datas[0].Coordinates[0].Dates[i].Value,
                        RainWater = obj.Datas[1].Coordinates[0].Dates[i].Value,
                        CloudCover = obj.Datas[2].Coordinates[0].Dates[i].Value

                    });
                }
                WeatherAvailable = false;
            }
            catch
            {
                WeatherAvailable = true;
            }
        }
        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

    }
}
