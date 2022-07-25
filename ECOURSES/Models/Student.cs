namespace ECOURSES.Models
{
    public class Student
    {
        public int StudentId { get; set; } 
        public string Name { get; set; }
        public string Email { get; set; }

        public List<Course> Courses { get; set; }

    }
}
