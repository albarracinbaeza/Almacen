using Identity.Domain;
using Identity.Persistence.Database.Configuration;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Identity.Persistence.Database
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser, ApplicationRole, string>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
       
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.HasDefaultSchema("Identity");

            ModelConfig(builder);
        }

        private void ModelConfig(ModelBuilder modelbuilder)
        {
            new ApplicationUserConfiguration(modelbuilder.Entity<ApplicationUser>());
            new ApplicationRoleConfiguration(modelbuilder.Entity<ApplicationRole>());
        }
    }
}
