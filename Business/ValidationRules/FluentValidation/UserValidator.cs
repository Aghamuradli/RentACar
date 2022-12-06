using Entities.DTOs;
using FluentValidation;
using System.Text.RegularExpressions;

namespace Business.ValidationRules.FluentValidation
{
    public class UserValidator : AbstractValidator<UserForRegisterDto>
    {
        public UserValidator()
        {
            RuleFor(u => u.FirstName).NotEmpty();
            RuleFor(u => u.FirstName).MinimumLength(2);
            RuleFor(u => u.LastName).NotEmpty();
            RuleFor(u => u.LastName).MinimumLength(2);
            RuleFor(u => u.Email).NotEmpty();
            RuleFor(u => u.Email).EmailAddress();
            RuleFor(u => u.Password).NotEmpty();
            RuleFor(u => u.Password).MinimumLength(8);
            RuleFor(u => u.Password).Must(AtLeastOneUppercase).WithMessage("Must have at least one capital letter .");
            RuleFor(u => u.Password).Must(AtLeastOneLowercase).WithMessage("Must have at least one lowercase letter ."); ;
            RuleFor(u => u.Password).Must(AtLeastOneDigit).WithMessage("There must be at least one digit ."); ;
        }

        private bool AtLeastOneDigit(string arg)
        {
            return Regex.IsMatch(arg, "(?=.*?[0-9])");
        }

        private bool AtLeastOneLowercase(string arg)
        {
            return Regex.IsMatch(arg, "(?=.*?[a-z])");
        }

        private bool AtLeastOneUppercase(string arg)
        {
            return Regex.IsMatch(arg, "(?=.*?[A-Z])");
        }
    }
}
