using System;
using Windows.UI.Xaml.Data;

namespace Flight__n_Bite.Util
{
    class BooleanToColorConvertor : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, string language)
        {
            if ((bool)value)
            {
                return "Green";
            }
            else
            {
                return "Orange";
            }
        }

        public object ConvertBack(object value, Type targetType, object parameter, string language)
        {
            throw new NotImplementedException();
        }
    }
}
