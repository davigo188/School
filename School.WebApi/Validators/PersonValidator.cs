using FluentValidation;
using School.Models;

namespace School.WebApi.Validators
{
    public class PersonValidator : AbstractValidator<Person>
    {
        public PersonValidator()
        {
            RuleFor(x => x.LastName).NotNull().NotEmpty().WithMessage("This Field is required");
            RuleFor(x => x.FirstName).NotNull().NotEmpty().WithMessage("This Field is required");
        }
    }
}
