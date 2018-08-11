using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using AutoMapper.Attributes;
using PathologyLabs.Domain.Core;

namespace PathologyLabs.Model.Core
{
    [MapsTo(typeof(TestType))]
    public class TestTypeApiModel : ApiModel<short> 
    {
        [Required]
        public string Name { get; set; }

        public IEnumerable<PathologyTestApiModel> Tests { get; set; }
    }
}