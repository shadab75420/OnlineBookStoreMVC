using System.ComponentModel.DataAnnotations;

namespace OnlineBookStore.Validations
{
    public class ISBNValidationAttribute : ValidationAttribute
    {
        protected override ValidationResult IsValid(
            object value,
            ValidationContext validationContext)
        {
            string isbn = value?.ToString();

            if (isbn.Length == 13)
            {
                return ValidationResult.Success;
            }

            return new ValidationResult("ISBN must contain 13 digits");
        }
    }
}