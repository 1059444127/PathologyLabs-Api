using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PathologyLabManagementSystemV2.Domain
{
    public class LoginDetail
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string Password { get; set; }
    }
}
