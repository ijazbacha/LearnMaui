using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnMaui.MVVM.ViewModel
{
    public class BoolConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            string married = value.ToString();
            if(married == "Married")
            {
                return true;
            }
            return false;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var isMarried = (bool)value;
            if (isMarried)
            {
                return "Married";
            }
            return "UnMarried";
        }
    }
}
