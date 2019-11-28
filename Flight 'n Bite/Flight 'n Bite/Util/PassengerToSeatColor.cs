using Flight__n_Bite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Media;

namespace Flight__n_Bite.Util
{
    class PassengerToSeatColor: IValueConverter
        {
            public object Convert(object value, Type targetType, object parameter, string language)
            {
                if (value == null) return new SolidColorBrush(Colors.Green);
            return new SolidColorBrush(Colors.Black);
        }

            public object ConvertBack(object value, Type targetType, object parameter, string language)
            {
                throw new NotImplementedException();
            }
        }


    }
