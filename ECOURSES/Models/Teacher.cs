namespace ECOURSES.Models
{
    public class Teacher
    {

        public int TeacherId { get; set; } 
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Imag { get; set; }
        public string Subjects { get; set; }
        public string? Facebook { get; set; }
        public string? Linkedin { get; set; }
        public string? Twitter { get; set; }
    }
}
