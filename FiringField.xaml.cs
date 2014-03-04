using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using SimpleWpfApp.Model;
using SimpleWpfApp.Converters;

namespace SimpleWpfApp
{
    /// <summary>
    /// Interaction logic for FiringField.xaml
    /// </summary>
    public partial class FiringField : Page
    {
        public FiringField()
        {
            InitializeComponent();
            try
            {
                Employee empl = new Employee() { FirstName = "Oleg", SecondName ="Atman"};
                Binding binding = new Binding();
                binding.Converter = new StringEmployeeConverter();
                binding.Source = empl;
                binding.Path = null;
                binding.Mode = BindingMode.TwoWay;
                BindingTextBox.SetBinding(TextBox.TextProperty, binding);
                BindingLabel.SetBinding(Label.ContentProperty, binding);
            }
            catch (Exception e)
            {

            }
        }

    }
}
