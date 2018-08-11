namespace PathologyLabs.Domain.Core
{
    public abstract class Person : Person<int> 
    {
    }

    public abstract class Person<TPrimaryKey> : Entity<TPrimaryKey> where TPrimaryKey : struct
    {
        public virtual string FirstName { get; set; }

        public virtual string LastName { get; set; }

        public virtual string Address { get; set; }

        public virtual string PhoneNumber { get; set; }

        public virtual string Email { get; set; }

        public virtual Gender Gender { get; set; }
    }

    public enum Gender
    {
        None = 0,
        Female = 1,
        Male = 2,
        Other = 3
    }
}
