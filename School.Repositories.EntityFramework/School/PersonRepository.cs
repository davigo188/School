using Microsoft.EntityFrameworkCore;
using School.Models;
using School.Repositories.School;

namespace School.Repositories.EntityFramework.School
{
    class PersonRepository : Repository<Person>, IPersonRepository
    {
        public PersonRepository(DbContext context) : base(context)
        {

        }
    }
}
