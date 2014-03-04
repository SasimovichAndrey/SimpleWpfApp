using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace SimpleWpfApp.Model
{
    class EmployeeWrapper : INotifyPropertyChanged
    {
        private Employee employee;

        public event PropertyChangedEventHandler PropertyChanged;

        public Employee WrappedEmployee
        {
            get
            {
                return this.employee;
            }
            set
            {
                this.employee = value;
                NotifyPropertyChanged("WrappedEmployee");
            }
        }

        private void NotifyPropertyChanged(String propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
