using School.Repositories.School;

namespace School.UnitOfWork
{
    public interface IUnitOfWork
    {
        ICourseRepository Courses { get; }
        IDepartmentRepository Departments { get; }
        IPersonRepository Persons { get; }
        IStudentGradeRepository StudentGrades { get; }
    }
}
