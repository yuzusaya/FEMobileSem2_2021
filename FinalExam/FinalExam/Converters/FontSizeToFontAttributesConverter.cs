using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using Xamarin.Forms;

namespace FinalExam.Converters
{
    public class FontSizeToFontAttributesConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var fontSize = (double)value;
            if (fontSize < 24)
                return FontAttributes.None;
            if (fontSize > 28)
                return FontAttributes.Bold;
            return FontAttributes.Italic;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
