using CoursesHub.Data.Course.Entity;

namespace CoursesHub.Data.Course.Abstract
{
    public interface ICourseRepository
    {
        public void Add(CourseEntity course);

        public CourseEntity ReadById(string id);

        public void UpdateById(string id, CourseEntity course);

        public void DeleteById(string id);
    }
}