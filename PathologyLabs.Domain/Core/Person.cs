namespace PathologyLabs.Domain.Core
{
    public class Person : Person<int>
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Address { get; set; }

        public string PhoneNumber { get; set; }

        public string Email { get; set; }

        public Gender Gender { get; set; }
    }

    public abstract class Person<TPrimaryKey> : Entity<TPrimaryKey> where TPrimaryKey : struct
    {
    }

    public enum Gender
    {
        None = 0,
        Female = 1,
        Male = 2,
        Other = 3
    }
}
