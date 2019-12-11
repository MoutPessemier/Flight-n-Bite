using Flight__n_Bite.Models;
using System;
using Windows.UI.Xaml.Data;

namespace Flight__n_Bite.Util
{
    class FlightToETAConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, string language)
        {
            var flight = (Flight)value;
            if(flight != null) { 
            var ETA = flight.DepartureTime + flight.Duration + flight.Delay;
            var ETAHOUR = Math.Floor(ETA);
            var ETAMINUTES = Math.Floor((ETA - ETAHOUR) * 60);
            return $"{ETAHOUR}u{ETAMINUTES}";
            }
            return "";

        }

        public object ConvertBack(object value, Type targetType, object parameter, string language)
        {
            throw new NotImplementedException();
        }
    }
}