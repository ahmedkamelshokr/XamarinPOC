using System;
using System.ComponentModel.DataAnnotations;

namespace Course.Models
{
    public class CourseModel
    {
        public string Id { get; set; }
        [Required]
        public string Name { get; set; }
        public string Summary { get; set; }
        [EmailAddress]
        public CourseLevel? Level { get; set; }
        public TimeSpan Duration { get; set; }

        public double Rate { get { return (double)RateCount / ViewsCount; } }
        public string AuthorEmail { get; set; }
        public string ImageUrl { get; set; }

        public int ViewsCount { get; set; }

        public int RateCount { get; set; }
    }
    public enum CourseLevel
    {
        Beginner,
        Medium,
        Advanced

    }

}
