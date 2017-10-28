using School.UnitOfWork;
using School.Repositories.School;
using Microsoft.EntityFrameworkCore;

namespace School.Repositories.EntityFramework.School
{
    public class SchoolUnitOfWork : IUnitOfWork
    {
        public SchoolUnitOfWork(DbContext context)
        {
            Courses = new CourseRepository(context);
            Departments = new DepartmentRepository(context);
            Persons = new PersonRepository(context);
            StudentGrades = new StudentGradeRepository(context);
        }

        public ICourseRepository Courses { get; private set; }

        public IDepartmentRepository Departments { get; private set; }

        public IPersonRepository Persons { get; private set; }

        public IStudentGradeRepository StudentGrades { get; private set; }
    }
}
