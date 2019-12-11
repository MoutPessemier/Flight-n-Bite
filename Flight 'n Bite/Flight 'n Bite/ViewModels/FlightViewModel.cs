using Flight__n_Bite.data;
using Flight__n_Bite.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using Windows.Devices.Geolocation;
using Windows.Foundation;
using Windows.UI;
using Windows.UI.Xaml.Controls.Maps;

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

        public MapControl Map { get; internal set; }

        public FlightViewModel()
        {
            LoadFlight();
        }

        private async void LoadFlight()
        {
            HttpService httpService = HttpService.instance;

            string json = await httpService.GetStringAsync(new Uri("http://localhost:49527/api/flight"));
            Flight = JsonConvert.DeserializeObject<Flight>(json);
            LoadPOI();
        }

        private void LoadPOI()
        {
            BasicGeoposition departureLocation = new BasicGeoposition() { Latitude = Flight.StartLatitude, Longitude = Flight.StartLongitude };
            Geopoint departure = new Geopoint(departureLocation);

            MapIcon departurePoint = new MapIcon();
            departurePoint.Location = departure;
            departurePoint.NormalizedAnchorPoint = new Point(0.5, 1.0);
            departurePoint.Title = Flight.Departure;
            departurePoint.ZIndex = 0;

            Map.MapElements.Add(departurePoint);

            BasicGeoposition arrivalLocation = new BasicGeoposition() { Latitude = Flight.EndLatitude, Longitude = Flight.EndLongitude };
            Geopoint arrival = new Geopoint(arrivalLocation);

            MapIcon arrivalPoint = new MapIcon();
            arrivalPoint.Location = arrival;
            arrivalPoint.NormalizedAnchorPoint = new Point(0.5, 1.0);
            arrivalPoint.Title = Flight.Arrival;
            arrivalPoint.ZIndex = 0;

            Map.MapElements.Add(arrivalPoint);

            List<BasicGeoposition> positions = new List<BasicGeoposition>();
            positions.Add(departureLocation);
            positions.Add(arrivalLocation);

            Geopath geopath = new Geopath(positions);
            MapPolyline path = new MapPolyline() { Visible = true, Path = geopath, StrokeColor = Color.FromArgb(255, 50, 75, 50), StrokeThickness = 3 };
            Map.MapElements.Add(path);

            Map.Center = departure;
            Map.ZoomLevel = 4;
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
