using System;
using Windows.UI.Xaml.Data;

namespace Flight__n_Bite.Util
{
    class RainWaterConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, string language)
        {
            return value.ToString() + " %";
        }

        public object ConvertBack(object value, Type targetType, object parameter, string language)
        {
            throw new NotImplementedException();
        }
    }
}
