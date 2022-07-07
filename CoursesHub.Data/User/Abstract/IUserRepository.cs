using CoursesHub.Data.User.Entity;

namespace CoursesHub.Data.User.Abstract
{
    public interface IUserRepository
    {
        public void Add(UserEntity user);

        public UserEntity ReadById(string id);

        public void UpdateById(string id, UserEntity user);

        public void DeleteById(string id);
    }
}