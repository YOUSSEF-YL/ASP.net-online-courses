using Microsoft.EntityFrameworkCore;

namespace ECOURSES.Models
{
    [Keyless]
    public class UserLogin
    {
        public string Usernane { get; set; }
        public string Passwor { get; set; }
    }
}
