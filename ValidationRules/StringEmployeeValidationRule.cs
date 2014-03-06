using System;
using System.Windows.Controls;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SimpleWpfApp.ValidationRules
{
    class StringEmployeeValidationRule : ValidationRule
    {
        public StringEmployeeValidationRule()
        {
            this.ValidationStep = System.Windows.Controls.ValidationStep.RawProposedValue;
        }

        public override ValidationResult Validate(object value, System.Globalization.CultureInfo cultureInfo)
        {
            String stringEmployee = (String)value;
            if (stringEmployee.Split(' ').Length != 2)
                return new ValidationResult(false, "You must input employee name in format 'FirstName LastName'");
            else
                return ValidationResult.ValidResult;
        }
    }
}
