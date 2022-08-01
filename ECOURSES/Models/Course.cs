using ECOURSES.Data;
using StackExchange.Redis;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Collections.Generic;
using ECOURSES.Controllers;

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
        public int Subscribers { get; set; }
        // public virtual ICollection<Student> Students { get; set; }



        //public int Subscribers(int id,dynamic  courseStudents)
        //{
           
          

        //    // var count = db.CourseStudent.Count();

        //    // var cout = students.Where(CourseID == id).cou

        //    // int count = studentsc.Count(CourseStudent  => CourseStudent.CourseID == id);
            
        //    int count = 0;
            
        //    foreach (CourseStudent cs in courseStudents)
        //    {
        //        if (id == cs.CourseID)
        //        {
        //            count = count + 1;
        //        }
        //    }
        //        return count;

        //}
    }
}
