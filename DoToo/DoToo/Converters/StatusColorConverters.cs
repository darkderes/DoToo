using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;
using Xamarin.Forms;

namespace DoToo.Converters
{
    public class StatusColorConverters : IValueConverter
    {
  

        object IValueConverter.Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
           return (bool)value ? (Color) Application.Current.Resources["CompletedColor"] : (Color)Application.Current.Resources["ActiveColor"];
        }

        object IValueConverter.ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return null;
        }
    }
}
