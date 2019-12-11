using Flight__n_Bite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using Windows.UI.Xaml.Data;

namespace Flight__n_Bite.Util
{
    public class ListConverter: IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, string language)
        {
            List<string> cast = ((List<Artist>)value).Select(c => c.Name).ToList();
            var singleString = string.Join(", ", cast.ToArray());
            return singleString;
        }

        public object ConvertBack(object value, Type targetType, object parameter, string language)
        {
            throw new NotImplementedException();
        }
    }
}
