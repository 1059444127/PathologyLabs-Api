using System.ComponentModel.DataAnnotations;
using AutoMapper.Attributes;
using PathologyLabs.Domain.Core;

namespace PathologyLabs.Model.Core
{
    [MapsTo(typeof(PathologyTest))]
    public class PathologyTestApiModel : ApiModel<long>
    {
        [Required]
        public string Name { get; set; }

        public TestTypeApiModel TestType { get; set; }

        public short TestTypeId { get; set; }
    }
}
