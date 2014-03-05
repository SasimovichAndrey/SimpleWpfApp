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
using System.ComponentModel;

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
            list.Add(new Employee() { FirstName = "AEvgeny", SecondName = "Solovyov", Position = EmployeePosition.Manager });
            list.Add(new Employee() { FirstName = "ZWasia", SecondName = "Ozboarne" });
            list.Add(new Employee() { FirstName = "CMichael", SecondName = "Smith" });
            list.Add(new Employee() { FirstName = "CMichael", SecondName = "Abboth", Position = EmployeePosition.Manager});
            list.Add(new Employee() { FirstName = "BWasia", SecondName = "Kovalev" });
            EmployeeList emplList = new EmployeeList(){List = list};

            this.DataContext = emplList;
        }

        private void AddSorting(object sender, RoutedEventArgs e)
        {
            ((CollectionViewSource)this.Resources["VSource"]).SortDescriptions.Add(new SortDescription("FirstName", ListSortDirection.Ascending));
            ((CollectionViewSource)this.Resources["VSource"]).SortDescriptions.Add(new SortDescription("SecondName", ListSortDirection.Ascending));
        }

        private void RemoveSorting(object sender, RoutedEventArgs e)
        {
            ((CollectionViewSource)this.Resources["VSource"]).SortDescriptions.Clear();
        }

        private void WasiaFilter(object sender, FilterEventArgs e)
        {
            Employee empl = (Employee)e.Item;
            if (empl.FirstName.Contains("Wasia"))
                e.Accepted = true;
            else
                e.Accepted = false;
        }

        private void AddFiltering(object sender, RoutedEventArgs e)
        {
            ((CollectionViewSource)this.Resources["VSource2"]).Filter += WasiaFilter;
        }

        private void RemoveFiltering(object sender, RoutedEventArgs e)
        {
            ((CollectionViewSource)this.Resources["VSource2"]).Filter -= WasiaFilter;
        }

        private void AddGrouping(object sender, RoutedEventArgs e)
        {
            ((CollectionViewSource)this.Resources["VSource"]).GroupDescriptions.Add(new PropertyGroupDescription() { PropertyName = "Position"});
        }

        private void RemoveGrouping(object sender, RoutedEventArgs e)
        {
            ((CollectionViewSource)this.Resources["VSource"]).GroupDescriptions.Clear();
        }


    }
}
