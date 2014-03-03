using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SimpleWpfApp.Model;
using System.Windows.Data;

namespace SimpleWpfApp.Converters
{
    [ValueConversion(typeof(Employee), typeof(String))]
    class StringEmployeeConverter : IValueConverter
    {
        public object Convert(object value, System.Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            Employee empl = (Employee)value;
            return empl.FirstName + " " + empl.SecondName;
        }

        public object ConvertBack(object value, System.Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            String stringEmployee = (String)value;
            String[] splitedValue = stringEmployee.Split(' ');

            return new Employee() { FirstName = splitedValue[0], SecondName = splitedValue[1] };
        }
    }
}
