namespace ECOURSES.Models

{
    using System.ComponentModel.DataAnnotations.Schema;

    public class Rating
    {
        public int Id { get; set; } = 0;
        public int CourseID { get; set; }
        public int StudentId { get; set; }
     
        [Column(TypeName = "decimal(0,0)")]
        public decimal? StudentRating { get; set; }
        public Boolean IsSubde { get; set; }
    }
}
