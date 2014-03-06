using System;
using System.Windows.Controls;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SimpleWpfApp.ValidationRules
{
    class EmployeeValidationRule : ValidationRule
    {
        public EmployeeValidationRule()
        {
            this.ValidationStep = System.Windows.Controls.ValidationStep.ConvertedProposedValue;
        }

        public override ValidationResult Validate(object value, System.Globalization.CultureInfo cultureInfo)
        {
            // Validate converted value. (Employee in this case)
            return ValidationResult.ValidResult;
        }
    }
}
