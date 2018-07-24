using System.ComponentModel.DataAnnotations;

namespace PathologyLabManagementSystemV2.Domain
{
    public class Patient
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public ContactInfo Contact { get; set; }
        public BloodGroup BloodGroup { get; set; }

    }

    public class ContactInfo
    {
        public string Address { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
    }

    public class ParentSpouseInfo
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Relation Relation { get; set; }
    }
    public enum Relation
    {
        Father = 0,
        Mother = 1,
        Sister = 2,
        Brother = 3,
        [Display(Name = "Husband/Wife")]
        HusbandWife = 4
    }
    public enum BloodGroup
    {
        [Display(Name="A+ve")]
        Ap =0,
        [Display(Name = "A-ve")]
        An =1,
        [Display(Name = "B+ve")]
        Bp =2,
        [Display(Name = "B-ve")]
        Bn =3,
        [Display(Name = "O+ve")]
        Op =4,
        [Display(Name = "O-ve")]
        On =5,
        [Display(Name = "AB+ve")]
        ABp =6,
        [Display(Name = "AB-ve")]
        ABn =7
    }
}

