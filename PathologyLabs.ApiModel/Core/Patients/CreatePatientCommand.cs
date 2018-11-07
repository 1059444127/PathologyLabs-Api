using AutoMapper.Attributes;
using PathologyLabs.Domain.Core;
using PathologyLabs.Model.Mediation;
using static PathologyLabs.Domain.Core.Enums;

namespace PathologyLabs.Model.Core.Patients
{
    [MapsTo(typeof(Patient))]
    public class CreatePatientCommand : IRequest
    {
        public string FirstName { get; set; }

        public string MiddleName { get; set; }

        public string LastName { get; set; }

        public string ParentName { get; set; }

        public string SpouseName { get; set; }

        public BloodGroup BloodGroup { get; set; }
    }
}
