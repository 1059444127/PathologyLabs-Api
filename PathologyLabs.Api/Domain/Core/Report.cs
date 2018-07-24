using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PathologyLabManagementSystemV2.Domain.Core
{
    public class Report
    {
        public int Id { get; set; }
        public Test Test { get; set; }
        public Patient Patient { get; set; }
        public string Comment { get; set; }
    }
}
