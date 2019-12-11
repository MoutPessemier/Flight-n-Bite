using System;
using Windows.UI.Xaml.Data;

namespace Flight__n_Bite.Util
{
    class BooleanToGlyphConvertor : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, string language)
        {
            if ((bool)value)
            {
                return "\uE73E";
            } else
            {
                return "\uF142";
            }
        }

        public object ConvertBack(object value, Type targetType, object parameter, string language)
        {
            throw new NotImplementedException();
        }
    }
}
