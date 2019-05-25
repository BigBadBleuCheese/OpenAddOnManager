using System;
using System.Globalization;
using System.Windows.Data;

namespace OpenAddOnManager.Windows.ValueConverters
{
    public class NegateValueConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture) => value is bool boolean ? !boolean : Binding.DoNothing;

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture) => value is bool boolean ? !boolean : Binding.DoNothing;
    }
}
