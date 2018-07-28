namespace PathologyLabs.Domain.Core
{
    public abstract class Entity : Entity<int>
    {
    }

    public abstract class Entity<TPrimaryKey> where TPrimaryKey : struct
    {
        public virtual TPrimaryKey Id { get; set; }
    }
}
