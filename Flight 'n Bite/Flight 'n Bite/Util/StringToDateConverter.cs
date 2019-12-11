using System;
using Windows.UI.Xaml.Data;

namespace Flight__n_Bite.Util
{
    public class StringToDateConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, string language)
        {
            char[] sep = { '-'};
            var temp = ((string)value).Substring(0, 10).Split(sep);
            return temp[2] + "/" + temp[1];
        }

        public object ConvertBack(object value, Type targetType, object parameter, string language)
        {
            throw new NotImplementedException();
        }
    }
}
