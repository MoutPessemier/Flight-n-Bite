using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Data;

namespace Flight__n_Bite.Util
{
    class WeatherDataToGlyphConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, string language)
        {
            switch (value.ToString())
            {
                case "Sunny":return "\uE706";
                case "Cloudy":return "\uE753";
                case "Rainy":return "\uEB42";
                default:return "\uE706";
            }
        }

        public object ConvertBack(object value, Type targetType, object parameter, string language)
        {
            throw new NotImplementedException();
        }
    }
}