using System.Collections.Generic;

namespace PathologyLabs.Domain.Core
{
    public class PatientRelation : Person<long>
    {
        public IEnumerable<Patient> ChildrenOfParent { get; set; }

        public Patient PartnerOfSpouse { get; set; }
    }
}
