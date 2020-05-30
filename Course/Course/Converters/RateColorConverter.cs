using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using Xamarin.Forms;

namespace Course.Converters
{

    public class RateColorConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var rate = (double)value;

            switch (rate)
            {
                case var r when r >= 0.95:
                    return Color.Gold;
                case var r when r >= 0.65 && r < 0.95:
                    return Color.Green;
                case var r when r >= 0.45 && r < 0.65:
                    return Color.Yellow;
                default:
                    return Color.Red;
            }
        }



        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException("Not implemented.");
        }


    }
}
