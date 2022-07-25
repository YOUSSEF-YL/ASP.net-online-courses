using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ECOURSES.Models
{
    public class Course
    {
        [Key]
        public int CourseID { get; set; }
        public string? CourseName { get; set; }
        public Decimal Price { get; set; }
        public int  Duration{ get; set; }
        public int TeacherId { get; set; }
        public string? Imag { get; set; }
        public string? Subjects { get; set; }
  
        [NotMapped]
        public List<Student>? StudentId { get; set; } 
    }
}
