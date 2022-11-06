using Identity.Domain;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Identity.Persistence.Database.Configuration
{
    public class ApplicationRoleConfiguration
    {
        public ApplicationRoleConfiguration(EntityTypeBuilder<ApplicationRole> entityBuilder) {
            entityBuilder.HasKey(x => x.Id);

            entityBuilder.HasData(new ApplicationRole
            {
                Id = Guid.NewGuid().ToString().ToLower(),
                Name = "admin",
                NormalizedName = "ADMIN"
            });
            entityBuilder.HasData(new ApplicationRole
            {
                Id = Guid.NewGuid().ToString().ToLower(),
                Name = "usuario",
                NormalizedName = "USUARIO"
            });
            entityBuilder.HasData(new ApplicationRole
            {
                Id = Guid.NewGuid().ToString().ToLower(),
                Name = "consulta",
                NormalizedName = "CONSULTA"
            });
            entityBuilder.HasData(new ApplicationRole
            {
                Id = Guid.NewGuid().ToString().ToLower(),
                Name = "almacen",
                NormalizedName = "ALMACEN"
            });
            entityBuilder.HasData(new ApplicationRole
            {
                Id = Guid.NewGuid().ToString().ToLower(),
                Name = "facturacion",
                NormalizedName = "FACTURACION"
            });
            entityBuilder.HasMany(e => e.UserRoles).WithOne(e => e.Role).HasForeignKey(e => e.RoleId).IsRequired();
        }
    }
}
