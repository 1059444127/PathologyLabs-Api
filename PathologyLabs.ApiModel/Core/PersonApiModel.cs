using AutoMapper.Attributes;
using PathologyLabs.Domain.Core;

namespace PathologyLabs.Model.Core 
{
    public abstract class PersonApiModel : PersonApiModel<int>
    {
    }

    [MapsTo(typeof(Person))]
    public abstract class PersonApiModel<TPrimaryKey> : ApiModel<TPrimaryKey> where TPrimaryKey : struct
    {
        /// <summary>
        /// Gets or sets the first name of the person.
        /// </summary>
        public virtual string FirstName { get; set; }

        /// <summary>
        /// Gets or sets the last name of the person.
        /// </summary>
        public virtual string LastName { get; set; }

        public virtual string Address { get; set; }

        public virtual string PhoneNumber { get; set; }

        public virtual string Email { get; set; }

        public virtual Gender Gender { get; set; }
    }
}