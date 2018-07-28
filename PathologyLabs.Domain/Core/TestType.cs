using System.Collections.Generic;

namespace PathologyLabs.Domain.Core
{
    public class TestType : Entity<short>
    {
        public string Name { get; set; }

        public IEnumerable<PathologyTest> Tests { get; set; }
    }
}
