using System.ComponentModel.DataAnnotations;

namespace PathologyLabs.Domain.Core
{
    public class Patient : Person
    {
        public Person Parent { get; set; }

        public Person Spouse { get; set; }

        public BloodGroup BloodGroup { get; set; }
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
