using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MIS.Services.CustomValidation
{
    public sealed class PastDateValidationAttribute : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var dt = (DateTime)value;
            if (dt.Year <= DateTime.UtcNow.Year)
            {
                if (dt.Month <= DateTime.UtcNow.Month)
                {
                    return ValidationResult.Success;
                }
            }

            return new ValidationResult(ErrorMessage ?? "No Invoices yet for this month, please check previous months");
        }
    }
}