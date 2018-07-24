namespace PathologyLabManagementSystemV2.Domain
{
    public class Test
    {
        public int Id { get; set; }
        public TestType Type { get; set; }
    }

    public enum TestType
    {
        Blood=1,
        Urine=2,
        Other=3
    }
}