using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using User.Domain;

namespace User.Persistence.Database.Configuration
{
    internal class ModuleRoleConfiguration
    {
        public ModuleRoleConfiguration(EntityTypeBuilder<ModuleRole> entityBuilder)
        {
            entityBuilder.HasKey(x => x.IdModuleRol);

            List<ModuleRole> ModuleRolItems = new List<ModuleRole>();

            ModuleRolItems.Add(new ModuleRole { IdModuleRol = 1, IdModule = 1, IdRol = "178cb4b8-f8a4-45a6-b0dc-0c4f93f8aadb", AllowCreate = true, AllowModify = true, AllowEliminate = true, Activo = true });
            ModuleRolItems.Add(new ModuleRole { IdModuleRol = 2, IdModule = 2, IdRol = "178cb4b8-f8a4-45a6-b0dc-0c4f93f8aadb", AllowCreate = true, AllowModify = true, AllowEliminate = true, Activo = true });
            ModuleRolItems.Add(new ModuleRole { IdModuleRol = 3, IdModule = 3, IdRol = "178cb4b8-f8a4-45a6-b0dc-0c4f93f8aadb", AllowCreate = true, AllowModify = true, AllowEliminate = true, Activo = true });
            ModuleRolItems.Add(new ModuleRole { IdModuleRol = 4, IdModule = 4, IdRol = "178cb4b8-f8a4-45a6-b0dc-0c4f93f8aadb", AllowCreate = true, AllowModify = true, AllowEliminate = true, Activo = true });
            ModuleRolItems.Add(new ModuleRole { IdModuleRol = 5, IdModule = 5, IdRol = "178cb4b8-f8a4-45a6-b0dc-0c4f93f8aadb", AllowCreate = true, AllowModify = true, AllowEliminate = true, Activo = true });
            ModuleRolItems.Add(new ModuleRole { IdModuleRol = 6, IdModule = 6, IdRol = "178cb4b8-f8a4-45a6-b0dc-0c4f93f8aadb", AllowCreate = true, AllowModify = true, AllowEliminate = true, Activo = true });
            ModuleRolItems.Add(new ModuleRole { IdModuleRol = 7, IdModule = 7, IdRol = "178cb4b8-f8a4-45a6-b0dc-0c4f93f8aadb", AllowCreate = true, AllowModify = true, AllowEliminate = true, Activo = true });
            ModuleRolItems.Add(new ModuleRole { IdModuleRol = 8, IdModule = 8, IdRol = "178cb4b8-f8a4-45a6-b0dc-0c4f93f8aadb", AllowCreate = true, AllowModify = true, AllowEliminate = true, Activo = true });

            entityBuilder.HasData(ModuleRolItems);

        }
    }
}
