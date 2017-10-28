using FluentValidation;
using School.Models;

namespace School.WebApi.Validators
{
    public class StudentGradeValidator : AbstractValidator<StudentGrade>
    {
        public StudentGradeValidator()
        {
            RuleFor(x => x.CourseID).NotNull().NotEmpty().WithMessage("This Field is required");
            RuleFor(x => x.StudentID).NotNull().NotEmpty().WithMessage("This Field is required");
        }
    }
}
