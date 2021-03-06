﻿using System;
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
    /// Interaction logic for ExpenseItReport.xaml
    /// </summary>
    public partial class ExpenseItReport : Page
    {
        public ExpenseItReport()
        {
            InitializeComponent();
        }
        public ExpenseItReport(object data) : this()
        {
            // Bind to expense report data.
            this.DataContext = data;
        }
    }
}
