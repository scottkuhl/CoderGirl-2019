using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace UserSignup.ViewModels
{
    public class AddUserViewModel : IValidatableObject
    {
        [Required, MinLength(4), MaxLength(15), RegularExpression(@"^[a-zA-Z]+$")]
        public string Username { get; set; }

        [EmailAddress]
        public string Email { get; set; }

        [Required, MinLength(6), DataType(DataType.Password)]
        public string Password { get; set; }

        [Required, Compare(nameof(Password)), DataType(DataType.Password), Display(Name = "Verify Password")]
        public string Verify { get; set; }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            // Bonus: Here is a way to put in custom validation.
            if (Password.ToLower() == "password")
                yield return new ValidationResult("Seriously?", new[] { nameof(Password) });
        }
    }
}
