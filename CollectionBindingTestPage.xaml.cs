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

namespace SimpleWpfApp
{
    /// <summary>
    /// Interaction logic for CollectionBindingTestPage.xaml
    /// </summary>
    public partial class CollectionBindingTestPage : Page
    {
        public CollectionBindingTestPage()
        {
            InitializeComponent();
            List<Employee> list = new List<Employee>();
            list.Add(new Employee() { FirstName = "Wania", SecondName="Kovalev" });
            list.Add(new Employee() { FirstName = "Evgeny", SecondName = "Solovyov" });
            EmployeeList emplList = new EmployeeList(){List = list};

            PageGrid.DataContext = emplList;
        }
    }
}
