﻿using System;
using Windows.UI.Xaml.Data;

namespace Flight__n_Bite.Util
{
    public class RatingConverter: IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, string language)
        {
            return System.Convert.ToString(Math.Round((double)value, 1));
        }

        public object ConvertBack(object value, Type targetType, object parameter, string language)
        {
            throw new NotImplementedException();
        }
    }
}
