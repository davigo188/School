using Microsoft.EntityFrameworkCore;
using School.Models;
using School.Repositories.School;

namespace School.Repositories.EntityFramework.School
{
    class StudentGradeRepository : Repository<StudentGrade>, IStudentGradeRepository
    {
        public StudentGradeRepository(DbContext context) : base(context)
        {

        }
    }
}
