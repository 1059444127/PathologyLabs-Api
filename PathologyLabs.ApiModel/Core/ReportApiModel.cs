using AutoMapper.Attributes;
using PathologyLabs.Domain.Core;

namespace PathologyLabs.Model.Core
{
    [MapsTo(typeof(Report))]
    public class ReportApiModel : ApiModel<long>
    {
        public PathologyTestApiModel Test { get; set; }

        public long PatientId { get; set; }

        public string Comment { get; set; }
    }
}
