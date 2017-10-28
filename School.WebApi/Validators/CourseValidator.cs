using FluentValidation;
using School.Models;

namespace School.WebApi.Validators
{
    public class CourseValidator : AbstractValidator<Course>
    {
        public CourseValidator()
        {
            RuleFor(x => x.Title).NotNull().NotEmpty().WithMessage("This Field is required");
            RuleFor(x => x.Credits).NotNull().NotEmpty().WithMessage("This Field is required");
            RuleFor(x => x.DepartmentID).NotNull().NotEmpty().WithMessage("This Field is required");
        }
    }
}
