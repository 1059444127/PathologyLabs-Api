using System.Collections.Generic;
using static PathologyLabs.Domain.Core.Enums;

namespace PathologyLabs.Domain.Core
{
    public class Patient : Entity<long>
    {
        public Patient()
        {
            Reports = new HashSet<Report>();
            PathologyTests = new HashSet<PathologyTest>();
        }

        public string FirstName { get; set; }

        public string MiddleName { get; set; }

        public string LastName { get; set; }

        public string ParentName { get; set; }

        public string SpouseName { get; set; }

        public BloodGroup BloodGroup { get; set; }

        public IEnumerable<Report> Reports { get; private set; }

        public IEnumerable<PathologyTest> PathologyTests { get; private set; }
    }
}
