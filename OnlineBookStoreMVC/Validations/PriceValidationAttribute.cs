using System.ComponentModel.DataAnnotations;

namespace OnlineBookStore.Validations
{
    public class PriceValidationAttribute : ValidationAttribute
    {
        protected override ValidationResult IsValid(
            object value,
            ValidationContext validationContext)
        {
            decimal price = (decimal)value;

            if (price > 0 && price < 10000)
            {
                return ValidationResult.Success;
            }

            return new ValidationResult("Invalid price");
        }
    }
}