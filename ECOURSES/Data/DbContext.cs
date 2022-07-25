using ECOURSES.Models;
using Microsoft.EntityFrameworkCore;



namespace ECOURSES.Data
{
    public class ApplicationDbContext :DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        public DbSet<Course> Courses { get; set; }

        public DbSet<Student> Students { get; set; }
    }
}
