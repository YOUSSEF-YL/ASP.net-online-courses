using Microsoft.EntityFrameworkCore;

namespace ECOURSES.Models
{
    [Keyless]
    public class UserLogin
    {
        public int Usernane { get; set; }
        public int Passwor { get; set; }
    }
}
