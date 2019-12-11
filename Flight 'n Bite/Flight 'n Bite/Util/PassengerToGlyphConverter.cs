using System;
using Windows.UI.Xaml.Data;

namespace Flight__n_Bite.Util
{
    class PassengerToGlyphConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, string language)
        {
            if (value == null) return "\uE77B";

            return "\uEA8C";
        }

        public object ConvertBack(object value, Type targetType, object parameter, string language)
        {
            throw new NotImplementedException();
        }
    }


}