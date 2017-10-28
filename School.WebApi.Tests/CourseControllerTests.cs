using Microsoft.EntityFrameworkCore;
using School.Repositories.EntityFramework.School;
using School.WebApi.Controllers;
using System.Data.SqlClient;

namespace School.WebApi.Tests
{
    public class CourseControllerTests : DbContext
    {
        private readonly CourseController _courseController;

        public CourseControllerTests()
        {

            DbContextOptionsBuilder optionsBuilder = new DbContextOptionsBuilder();
            optionsBuilder.UseSqlServer(ConfigSettings.SchoolConnectionString);
            
            //_courseController = new CourseController(
            //    new SchoolUnitOfWork()
            //    );
        }

    }
}
