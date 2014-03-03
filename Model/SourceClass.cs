using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SimpleWpfApp.Model
{
    class SourceClass
    {
        private static System.Windows.Media.Brush color = System.Windows.Media.Brushes.Red;
        private static Employee staticEmployee = new Employee() { FirstName = "Gerd", SecondName ="Muller"};

        public static Employee StaticEmployee
        {
            get
            {
                return staticEmployee;
            }
            set
            {
                staticEmployee = value;
            }
        }
        public static System.Windows.Media.Brush Color
        {
            get
            {
                return color;
            }
            set 
            {
                color = value;
                
            }
        }
    }
}
