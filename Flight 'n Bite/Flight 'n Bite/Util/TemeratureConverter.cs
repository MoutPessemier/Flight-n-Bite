using System;
using Windows.UI.Xaml.Data;

namespace Flight__n_Bite.Util
{
    public class TemeratureConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, string language)
        {
            return value.ToString() + "°C";
        }

        public object ConvertBack(object value, Type targetType, object parameter, string language)
        {
            throw new NotImplementedException();
        }
    }
}
