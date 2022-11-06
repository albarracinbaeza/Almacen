using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Identity.Domain
{
    public  class ApplicationUser: IdentityUser
    {        
        public string FirstName { get; set; }
        public string LastName { get; set; }      
        public ICollection<ApplicationUserRol> UserRoles { get; set; }
    }
}
