using System.ComponentModel.DataAnnotations;

namespace ECOURSES.Models
{
    public class Course
    {
        [Key]
        public int CourseID { get; set; }
        public string? CourseName { get; set; }

        public Decimal Price { get; set; }
        public int  Duration{ get; set; }
        public int TeacherID { get; set; }

        public List<Student>? subdeStudent { get; set; } 
    }
}
