using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Data;

namespace Flight__n_Bite.Util
{
    public class ListConverter: IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, string language)
        {
            var cast = ((IEnumerable<String>)value).Select(c => c + ", ").ToString();
            return cast.Substring(0, cast.Length - 2);
        }

        public object ConvertBack(object value, Type targetType, object parameter, string language)
        {
            throw new NotImplementedException();
        }
    }
}
