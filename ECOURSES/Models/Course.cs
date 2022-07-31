using ECOURSES.Data;
using StackExchange.Redis;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Collections.Generic;

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
        public string? SubjectsID { get; set; }
       // public virtual ICollection<Student> Students { get; set; }



        public int Subscribers(int id)
        {
           // ApplicationDbContext db = new();
            List<CourseStudent> studentsc = new List<CourseStudent>();
          
           // var count = db.CourseStudent.Count();

            // var cout = students.Where(CourseID == id).cou

          int count = studentsc.Count(CourseStudent  => CourseStudent.StudentId == id);
                     return count;

        }
    }
}
