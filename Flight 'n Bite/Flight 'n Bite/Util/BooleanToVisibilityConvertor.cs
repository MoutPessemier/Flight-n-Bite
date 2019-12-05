using System;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Data;

namespace Flight__n_Bite.Util
{
    class BooleanToVisibilityConvertor : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, string language)
        {
            if (!(bool)value)
            {
                return Visibility.Visible;
            }
            else
            {
                return Visibility.Collapsed;
            }
        }

        object IValueConverter.ConvertBack(object value, Type targetType, object parameter, string language)
        {
            throw new NotImplementedException();
        }
    }
}
