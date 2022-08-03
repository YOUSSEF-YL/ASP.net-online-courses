using Microsoft.EntityFrameworkCore;

namespace ECOURSES.Models
{
    [Keyless]
    public class User
    {
      
        public string? Password { get; set; }
        public string Role { get; set; } = "Student";
        public string? Usename { get; set; }
    }
}
