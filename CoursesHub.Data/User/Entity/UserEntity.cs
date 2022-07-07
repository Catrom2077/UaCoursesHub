using CoursesHub.Data.User.Abstract;

namespace CoursesHub.Data.User.Entity
{
    public class UserEntity : IUser
    {
        public UserEntity(string name, string lastName, string email)
        {
            Name = name;
            LastName = lastName;
            Email = email;
        }

        public string Id { get; set; } = string.Empty;

        public string Name { get; set; } = string.Empty;

        public string LastName { get; set; } = string.Empty;

        public string Email { get; set; } = string.Empty;

        public override string ToString() =>
            $"id({Id}) {Name} {LastName}";
    }
}