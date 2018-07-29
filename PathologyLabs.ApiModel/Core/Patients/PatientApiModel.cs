using AutoMapper.Attributes;
using PathologyLabs.Domain.Core;

namespace PathologyLabs.Model.Core.Patients
{
    [MapsTo(typeof(Patient))]
    public class PatientApiModel : ApiModel<long>
    {
        public PatientRelationApiModel Parent { get; set; }

        public PatientRelationApiModel Spouse { get; set; }

        public BloodGroup BloodGroup { get; set; }
    }
}
