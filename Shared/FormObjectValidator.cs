using System.ComponentModel.DataAnnotations;

namespace RepairHistory.Shared
{
    public class FormObjectValidator
    {
        public bool Result { get; set; }
        public string ErrorMessages { get; set; }

        public static FormObjectValidator ValidateObject(object obj)
        {
            var validationResults = new List<ValidationResult>();
            var validationContext = new ValidationContext(obj);

            var result = Validator.TryValidateObject(obj, validationContext, validationResults, true);

            if (result)
                return new FormObjectValidator { Result = true };

            var errorMessages = string.Join(Environment.NewLine, validationResults.Select(vr => vr.ErrorMessage));
            return new FormObjectValidator { ErrorMessages = errorMessages, Result = false };
        }
    }
}
