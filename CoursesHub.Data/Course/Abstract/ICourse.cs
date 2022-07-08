namespace CoursesHub.Data.Course.Abstract
{
    public interface ICourse
    {
        public string Id { get; set; }

        public string AuthorId { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public DateTime CreatedDate { get; set; }

        public DateTime UpdatedDate { get; set; }
    }
}