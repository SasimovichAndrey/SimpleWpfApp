using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace SimpleWpfApp.Model
{
    public class Employee
    {
        private String firstName;
        private String secondName;
        private EmployeePosition position = EmployeePosition.Developer;

        #region Getters/Setters
        public EmployeePosition Position
        {
            get
            {
                return position;
            }
            set
            {
                this.position = value;
            }
        }

        public String SecondName
        {
            get
            {
                return this.secondName;
            }
            set
            {
                this.secondName = value;
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
            }
        }
        #endregion
    }

    public enum EmployeePosition
    {
        Developer,
        Manager,
        Tester
    }
}
