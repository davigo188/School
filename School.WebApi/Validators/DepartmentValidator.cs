using FluentValidation;
using School.Models;

namespace School.WebApi.Validators
{
    public class DepartmentValidator : AbstractValidator<Department>
    {
        public DepartmentValidator()
        {
            RuleFor(x => x.Name).NotNull().NotEmpty().WithMessage("This Field is required");
            RuleFor(x => x.Budget).NotNull().NotEmpty().WithMessage("This Field is required");
            RuleFor(x => x.StartDate).NotNull().NotEmpty().WithMessage("This Field is required");
        }
    }
}
