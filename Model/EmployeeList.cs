using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SimpleWpfApp.Model
{
    class EmployeeList
    {
        private List<Employee> list;

        public List<Employee> List
        {
            get
            {
                return list;
            }
            set
            {
                this.list = value;
            }
        }
    }
}
