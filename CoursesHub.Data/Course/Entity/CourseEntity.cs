using CoursesHub.Data.Course.Abstract;

namespace CoursesHub.Data.Course.Entity
{
    public class CourseEntity : ICourse
    {
        public CourseEntity(string title, string descriptionl)
        {
            Title = title;
            Description = descriptionl;
        }

        public string Id { get; set; } = string.Empty;

        public string AuthorId { get; set; } = string.Empty;

        public string Title { get; set; } = string.Empty;

        public string Description { get; set; } = string.Empty;

        public DateTime CreatedDate { get; set; } = DateTime.UtcNow;

        public DateTime UpdatedDate { get; set; } = DateTime.UtcNow;

        public override string ToString() => Title;
    }
}