namespace PathologyLabManagementSystemV2.Domain
{
    public class User
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        //public string Password { get; set; }
        public UserTypes UserType { get; set; }
        public bool IsActive { get; set; }

    }

    public enum UserTypes{
       LabAdmin =0,
       LabUser=1
    }
}