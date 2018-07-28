namespace PathologyLabs.Domain.Core
{
    public class Report : Entity<long>
    {
        public PathologyTest Test { get; set; }

        public Patient Patient { get; set; }
        public long PatientId { get; set; }

        public string Comment { get; set; }
    }
}
