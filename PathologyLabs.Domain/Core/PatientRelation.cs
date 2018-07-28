using System.Collections.Generic;

namespace PathologyLabs.Domain.Core
{
    public class PatientRelation : Person<long>
    {
        public IEnumerable<Patient> ChildrenOfParent { get; set; }

        public Patient PartnerOfSpouse { get; set; }
    }

    public abstract class Person<TPrimaryKey> : Entity<TPrimaryKey> where TPrimaryKey : struct
    {
        public virtual string FirstName { get; set; }

        public virtual string LastName { get; set; }

        public virtual string Address { get; set; }

        public virtual string PhoneNumber { get; set; }

        public virtual string Email { get; set; }

        public virtual Gender Gender { get; set; }
    }

    public enum Gender
    {
        None = 0,
        Female = 1,
        Male = 2,
        Other = 3
    }
}
