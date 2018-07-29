namespace PathologyLabs.Model.Core
{
    public abstract class ApiModel : ApiModel<int>
    {
    }

    public abstract class ApiModel<TPrimaryKey> where TPrimaryKey : struct
    {
        public virtual TPrimaryKey Id { get; set; }
    }
}
