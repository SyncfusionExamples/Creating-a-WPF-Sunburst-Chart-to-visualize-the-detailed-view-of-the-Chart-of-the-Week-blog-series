using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using System.Windows.Media;

namespace ChartOfTheWeekData
{
    public class PathColorConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if(value is ArticleModel model)
            {
                if (model.Platform == ".NET MAUI")
                    return new SolidColorBrush(Color.FromRgb(120, 77, 253));
                else if(model.Platform == "WPF")
                    return new SolidColorBrush(Color.FromRgb(251, 83, 155));
                else if(model.Platform == "WINUI")
                    return new SolidColorBrush(Color.FromRgb(74, 218, 236));
            }

            return Colors.Transparent;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
