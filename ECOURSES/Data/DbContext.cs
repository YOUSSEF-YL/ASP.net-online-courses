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
    }
}
