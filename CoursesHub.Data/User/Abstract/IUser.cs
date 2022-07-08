namespace CoursesHub.Data.User.Abstract
{
    public interface IUser
    {
        public string Id { get; set; }

        public string Name { get; set; }

        public string LastName { get; set; }

        public string Email { get; set; }

        public DateTime CreatedDate { get; set; }
    }
}