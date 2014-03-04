using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace SimpleWpfApp.Model
{
    public class Employee : INotifyPropertyChanged
    {
        private String firstName;
        private String secondName;

        public event PropertyChangedEventHandler PropertyChanged;

        public String SecondName
        {
            get
            {
                return this.secondName;
            }
            set
            {
                this.secondName = value;
                ChangedNotify("SecondName");
            }
        }

        public String FirstName
        {
            get
            {
                return firstName;
            }
            set
            {
                this.firstName = value;
                ChangedNotify("FirstName");
            }
        }

        protected void ChangedNotify(String propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
