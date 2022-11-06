using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Identity.Service.Queries.DTOs
{
    public class ApplicationUserDto: IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }        
        public ICollection<ApplicationUserRolDto> UserRoles { get; set; }
    }
}
