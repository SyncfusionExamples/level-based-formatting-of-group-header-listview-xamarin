using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using Xamarin.Forms;

namespace SfListViewSample
{
    public class GroupHeaderConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (targetType.Name == "Color")
            {
                if ((int)value == 1)
                    return Color.Aqua;
                else
                    return Color.AntiqueWhite;
            }
            else
            {
                if ((int)value == 1)
                    return new Thickness(5, 5, 5, 0);
                else
                    return new Thickness((int)value * 15, 5, 5, 0);
            }
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return value;
        }
    }
}
