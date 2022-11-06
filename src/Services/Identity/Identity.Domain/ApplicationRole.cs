using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Identity.Domain
{
    public class ApplicationRole:IdentityRole
    {        
        public ICollection<ApplicationUserRol> UserRoles { get; set; }
    }
}
