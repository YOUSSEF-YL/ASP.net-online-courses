using Microsoft.EntityFrameworkCore;


namespace ECOURSES.Models
{
    [Keyless]
    public class CourseStudent
    {
        
        public  int StudentId { get; set; }
        
        public  int CourseID { get; set; }
    }
}
