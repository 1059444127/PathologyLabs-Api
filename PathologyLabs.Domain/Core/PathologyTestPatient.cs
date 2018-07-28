namespace PathologyLabs.Domain.Core
{
    /// <summary>
    /// This is a join entity for m-t-m relationship between patients and tests.
    /// One test can be done for many patients and one patient can undergo many tests.
    /// </summary>
    public class PathologyTestPatient
    {
        public Patient Patient { get; set; }
        public long PatientId { get; set; }

        public PathologyTest Test { get; set; }
        public long PathologyTestId { get; set; }
    }
}
