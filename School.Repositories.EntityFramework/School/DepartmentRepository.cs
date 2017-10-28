using Microsoft.EntityFrameworkCore;
using School.Models;
using School.Repositories.School;

namespace School.Repositories.EntityFramework.School
{
    class DepartmentRepository : Repository<Department>, IDepartmentRepository
    {
        public DepartmentRepository(DbContext context) : base(context)
        {

        }
    }
}
