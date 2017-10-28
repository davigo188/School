using School.Models;
using Microsoft.EntityFrameworkCore;

namespace Cibertec.Repositories.EntityFrameworkTests
{
    public class SchoolDBContext : DbContext
    {
        public DbSet<Course> Courses { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Person> Persons { get; set; }
        public DbSet<StudentGrade> StudentGrades { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.;Database=School; Trusted_Connection=True;MultipleActiveResultSets=True");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Course>().ToTable("Course");
            modelBuilder.Entity<Department>().ToTable("Department");
            modelBuilder.Entity<Person>().ToTable("Person");
            modelBuilder.Entity<StudentGrade>().ToTable("StudentGrade");
  
        }
    }
}
