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

namespace SimpleWpfApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Model.Unit unit = new Model.Grunt("Zag, zag!");
        public List<Model.Unit> unitList = new List<Model.Unit>();

        public MainWindow()
        {
            InitializeComponent();
            for(int i =0; i < 5; i++)
            {
                unitList.Add(new Model.Grunt());
            }
            this.DataContext = unitList;
        }
    }
}
