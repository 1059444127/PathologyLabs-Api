namespace PathologyLabs.Domain.Core
{
    public class PathologyTest : Entity
    {
        public string Name { get; set; }

        public TestType Type { get; set; }

        public short TestTypeId { get; set; }

        public long PatientId { get; set; }

        public Patient Patient { get; set; }
    }
}
