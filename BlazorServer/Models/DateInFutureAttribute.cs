using System;
using System.ComponentModel.DataAnnotations;

public class DateInFutureAttribute : ValidationAttribute {
    protected override ValidationResult IsValid(object value, ValidationContext context) {
        var date = value as DateTime?;
        if(date.HasValue) {
            return date.Value > DateTime.Now
            ? ValidationResult.Success
            : new ValidationResult("Date can only be in the future");
        }
        return ValidationResult.Success;
    }
}