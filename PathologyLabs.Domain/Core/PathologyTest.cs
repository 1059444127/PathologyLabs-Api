namespace PathologyLabs.Domain.Core
{
    public class PathologyTest : Entity
    {
        public string Name { get; set; }

        public TestType Type { get; set; }

        public Patient Patient { get; set; }
        public int PatientId { get; set; }
    }

    public class TestType : Entity<short>
    {
        public string Value { get; set; }
    }
}
