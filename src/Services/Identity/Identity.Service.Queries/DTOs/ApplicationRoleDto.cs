using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Identity.Service.Queries.DTOs
{
    internal class ApplicationRoleDto:IdentityRole
    {        
        public ICollection<ApplicationUserRolDto> UserRoles { get; set; }
    }
}
