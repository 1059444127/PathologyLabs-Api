using System;
using Microsoft.AspNetCore.Identity;

namespace PathologyLabs.Domain.App
{
    public class PathologyLabsUser : IdentityUser<long>
    {
        public string FirstName { get; set; }

        public string MiddleName { get; set; }

        public string LastName { get; set; }

        public DateTime BirthDate { get; set; }
    }
}
