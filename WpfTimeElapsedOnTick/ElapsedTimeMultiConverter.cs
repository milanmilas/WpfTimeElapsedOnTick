using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace WpfTimeElapsedOnTick
{
    public class ElapsedTimeMultiConverter : IMultiValueConverter
    {
        public object Convert(object[] values, Type targetType, object parameter, CultureInfo culture)
        {
            var archiveTime = (DateTime)values[0];
            var currentTime = (DateTime)values[1];
            var elapsedTime = currentTime.Subtract(archiveTime);
            return elapsedTime.ToString(@"hh\:mm\:ss");
        }

        public object[] ConvertBack(object value, Type[] targetTypes, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
