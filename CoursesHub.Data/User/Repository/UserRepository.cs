using CoursesHub.Data.User.Entity;
using CoursesHub.Data.User.Abstract;

namespace CoursesHub.Data.User.Repository
{
    public class UserRepository : IUserRepository
    {
        private static readonly List<UserEntity> _users = new();

        /// <summary>
        /// Add user to repository
        /// </summary>
        /// <param name="user">User model</param>
        public void Add(UserEntity user)
        {
            if(user == null)
                throw new ArgumentNullException(nameof(user), "Is null!");

            _users.Add(user);
        }

        /// <summary>
        /// Returns the user model in the repository by id
        /// </summary>
        /// <param name="id">User id</param>
        /// <returns>User model</returns>
        public UserEntity ReadById(string id)
        {
            UserEntity? userEntity = _users.FirstOrDefault(x => x.Id == id);

            if (userEntity == null)
                throw new ArgumentNullException(nameof(userEntity), "Is null!");

            return userEntity;
        }

        /// <summary>
        /// Updates the user model in the repository by id
        /// </summary>
        /// <param name="id">User id</param>
        /// <param name="user">User model</param>
        public void UpdateById(string id, UserEntity user)
        {
            int index = _users.FindIndex(x => x.Id == id);

            if (index < 0)
                throw new Exception("Not found!");

            _users[index] = user ?? throw new ArgumentNullException(nameof(user), "Is null!");
        }

        /// <summary>
        /// Delete the user model in the repository by id
        /// </summary>
        /// <param name="id">User id</param>
        public void DeleteById(string id)
        {
            int index = _users.FindIndex(x => x.Id == id);

            if (index < 0)
                throw new Exception("Not found!");

            _users.RemoveAt(index);
        }
    }
}