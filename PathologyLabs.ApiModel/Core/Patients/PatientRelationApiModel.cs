using System.Collections.Generic;
using AutoMapper.Attributes;
using PathologyLabs.Domain.Core;

namespace PathologyLabs.Model.Core.Patients
{
    [MapsTo(typeof(PatientRelation))]
    public class PatientRelationApiModel : ApiModel<long>
    {
        public IEnumerable<PatientApiModel> ChildrenOfParent { get; set; }

        public PatientApiModel PartnerOfSpouse { get; set; }
    }
}
