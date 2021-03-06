﻿using Flight__n_Bite.Models;
using System;
using Windows.UI.Xaml.Data;

namespace Flight__n_Bite.Util
{
    public class ArtistConverter: IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, string language)
        {
            return ((Artist)value).Name;
        }

        public object ConvertBack(object value, Type targetType, object parameter, string language)
        {
            throw new NotImplementedException();
        }
    }
}
