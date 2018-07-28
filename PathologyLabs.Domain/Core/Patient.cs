using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace PathologyLabs.Domain.Core
{
    public class Patient : Person<long>
    {
        public PatientRelation Parent { get; set; }
        public int ParentId { get; set; }

        public PatientRelation Spouse { get; set; }
        public int SpouseId { get; set; }

        public BloodGroup BloodGroup { get; set; }

        public IEnumerable<Report> Reports { get; set; }

        public IEnumerable<PathologyTestPatient> PathologyTestPatients { get; set; }
    }
    
    public enum BloodGroup
    {
        [Display(Name = "A+ve")]
        Ap = 0,
        [Display(Name = "A-ve")]
        An = 1,
        [Display(Name = "B+ve")]
        Bp = 2,
        [Display(Name = "B-ve")]
        Bn = 3,
        [Display(Name = "O+ve")]
        Op = 4,
        [Display(Name = "O-ve")]
        On = 5,
        [Display(Name = "AB+ve")]
        ABp = 6,
        [Display(Name = "AB-ve")]
        ABn = 7
    }
}
