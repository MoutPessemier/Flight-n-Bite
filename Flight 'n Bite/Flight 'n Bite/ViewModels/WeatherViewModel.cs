using Flight__n_Bite.data;
using Flight__n_Bite.Models;
using Newtonsoft.Json;
using System;
using System.Collections;
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
            Dates = new ObservableCollection<Day>();
            LoadWeather();
        }

        private async void LoadWeather()
        {
            HttpService httpService = HttpService.instance;
           
           string json = await httpService.GetWeatherAsync(new Uri("http://api.meteomatics.com/nowP10D:P1D/t_2m:C/50,3/json")); //WORKS but needs username and password
           //string jsonFake = @"{ ""version"":""3.0"",""dateGenerated"":""2019-11-04T21:04:10Z"",""status"":""OK"",""data"":[{""parameter"":""t_2m:C"",""coordinates"":[{""lat"":50,""lon"":3,""dates"":[{""date"":""2019-11-04T21:04:10Z"",""value"":9.0},{""date"":""2019-11-05T21:04:10Z"",""value"":8.3},{""date"":""2019-11-06T21:04:10Z"",""value"":7.2},{""date"":""2019-11-07T21:04:10Z"",""value"":4.6},{""date"":""2019-11-08T21:04:10Z"",""value"":4.5},{""date"":""2019-11-09T21:04:10Z"",""value"":6.0},{""date"":""2019-11-10T21:04:10Z"",""value"":3.5},{""date"":""2019-11-11T21:04:10Z"",""value"":4.9},{""date"":""2019-11-12T21:04:10Z"",""value"":4.5},{""date"":""2019-11-13T21:04:10Z"",""value"":4.5},{""date"":""2019-11-14T21:04:10Z"",""value"":6.1}]}]}]}";


           RootObject obj = JsonConvert.DeserializeObject<RootObject>(json);

            foreach (var d in obj.Datas[0].Coordinates[0].Dates)
            {
                Dates.Add(d);
            }

        }

       }
}
