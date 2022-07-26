namespace ECOURSES.Models
{
    public class Rating
    {
        public int Id { get; set; } = 0;
        public int CourseID { get; set; }
        public int StudentId { get; set; }
        public Decimal StudentRating { get; set; }
        public Boolean IsSubde { get; set; }
    }
}
