using ECOURSES.Controllers;
using ECOURSES.Models;
using Microsoft.EntityFrameworkCore;



namespace ECOURSES.Data
{
    public class ApplicationDbContext :DbContext
    {
        public ApplicationDbContext()
        {
        }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        public DbSet<Course> Courses { get; set; }

        public DbSet<Student> Students { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<Rating> Ratings { get; set; }

        public DbSet<Subject> Subjects { get; set; }
        public DbSet <CourseStudent> CourseStudent  { get; set; }
       
        public DbSet <User> user { get; set; }
        public DbSet<UserLogin> userLogin { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            var decimalProps = modelBuilder.Model
            .GetEntityTypes()
            .SelectMany(t => t.GetProperties())
            .Where(p => (System.Nullable.GetUnderlyingType(p.ClrType) ?? p.ClrType) == typeof(decimal));

            foreach (var property in decimalProps)
            {
                property.SetPrecision(18);
                property.SetScale(2);
            }
        }
    }
}
