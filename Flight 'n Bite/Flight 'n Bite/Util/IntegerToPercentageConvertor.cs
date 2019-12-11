using System;
using Windows.UI.Xaml.Data;

namespace Flight__n_Bite.Util
{
    public class IntegerToPercentageConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, string language)
        {
            return value == null? null : string.Format("{0}%", value);
        }

        public object ConvertBack(object value, Type targetType, object parameter, string language)
        {
            throw new NotImplementedException();
        }
    }
}
