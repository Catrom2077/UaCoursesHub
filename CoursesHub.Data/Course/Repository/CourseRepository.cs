using CoursesHub.Data.Course.Entity;
using CoursesHub.Data.Course.Abstract;

namespace CoursesHub.Data.Course.Repository
{
    public class CourseRepository : ICourseRepository
    {
        public static readonly List<CourseEntity> _courses = new();

        public void Add(CourseEntity course)
        {
            if (course == null)
                throw new ArgumentNullException(nameof(course), "Is null!");

            _courses.Add(course);
        }

        public CourseEntity ReadById(string id)
        {
            CourseEntity? courseEntity = _courses.FirstOrDefault(x => x.Id == id);

            if (courseEntity == null)
                throw new ArgumentNullException(nameof(courseEntity), "Is null!");

            return courseEntity;
        }

        public void UpdateById(string id, CourseEntity course)
        {
            int index = _courses.FindIndex(x => x.Id == id);

            if (index < 0)
                throw new Exception("Not found!");

            _courses[index] = course ?? throw new ArgumentNullException(nameof(course), "Is null!");
        }

        public void DeleteById(string id)
        {
            int index = _courses.FindIndex(x => x.Id == id);

            if (index < 0)
                throw new Exception("Not found!");

            _courses.RemoveAt(index);
        }
    }
}