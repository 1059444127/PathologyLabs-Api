using System.Collections.Generic;

namespace PathologyLabs.Domain.Core
{
    public class TestType : Entity<short>
    {
        public TestType()
        {
            Tests = new HashSet<PathologyTest>();
        }

        public string Name { get; set; }

        public IEnumerable<PathologyTest> Tests { get; set; }
    }
}
