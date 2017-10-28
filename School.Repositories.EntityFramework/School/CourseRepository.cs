using Microsoft.EntityFrameworkCore;
using School.Models;
using School.Repositories.School;

namespace School.Repositories.EntityFramework.School
{
    class CourseRepository : Repository<Course>, ICourseRepository
    {
        public CourseRepository(DbContext context) : base(context)
        {

        }
    }
}
