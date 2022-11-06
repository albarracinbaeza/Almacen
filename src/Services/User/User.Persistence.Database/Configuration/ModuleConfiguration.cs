using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using User.Domain;

namespace User.Persistence.Database.Configuration
{
    public class ModuleConfiguration
    {
        public ModuleConfiguration(EntityTypeBuilder<Module> entityBuilder)
        {
            entityBuilder.HasKey(x => x.IdModule);

            List<Module> ModuleItems = new List<Module>();

            ModuleItems.Add(new Module { IdModule = 1, IdModulePadre = 1, Name = "tablero_control", Activo = true });

            ModuleItems.Add(new Module { IdModule = 2, IdModulePadre = 2, Name = "clientes", Activo = true });
            ModuleItems.Add(new Module { IdModule = 3, IdModulePadre = 2, Name = "clientes:nuevo", Activo = true });
            ModuleItems.Add(new Module { IdModule = 4, IdModulePadre = 2, Name = "clientes:lista", Activo = true });

            ModuleItems.Add(new Module { IdModule = 5, IdModulePadre = 5, Name = "productos", Activo = true });
            ModuleItems.Add(new Module { IdModule = 6, IdModulePadre = 5, Name = "productos:nuevo", Activo = true });
            ModuleItems.Add(new Module { IdModule = 7, IdModulePadre = 5, Name = "productos:lista", Activo = true });

            ModuleItems.Add(new Module { IdModule = 8, IdModulePadre = 8, Name = "seguridad", Activo = true });

            ModuleItems.Add(new Module { IdModule = 9, IdModulePadre = 8, Name = "seguridad:usuarios", Activo = true });
            ModuleItems.Add(new Module { IdModule = 10, IdModulePadre = 9, Name = "seguridad:usuarios:nuevo", Activo = true });
            ModuleItems.Add(new Module { IdModule = 11, IdModulePadre = 9, Name = "seguridad:usuarios:lista", Activo = true });

            ModuleItems.Add(new Module { IdModule = 12, IdModulePadre = 8, Name = "seguridad:menus", Activo = true });
            ModuleItems.Add(new Module { IdModule = 13, IdModulePadre = 12, Name = "seguridad:menus:nuevo", Activo = true });
            ModuleItems.Add(new Module { IdModule = 14, IdModulePadre = 12, Name = "seguridad:menus:lista", Activo = true });

            ModuleItems.Add(new Module { IdModule = 15, IdModulePadre = 12, Name = "seguridad:menus:menus_rol", Activo = true });
            ModuleItems.Add(new Module { IdModule = 16, IdModulePadre = 15, Name = "seguridad:menus:menus_rol:lista", Activo = true });

            ModuleItems.Add(new Module { IdModule = 17, IdModulePadre = 8, Name = "seguridad:roles", Activo = true });
            ModuleItems.Add(new Module { IdModule = 18, IdModulePadre = 17, Name = "seguridad:roles:nuevo", Activo = true });
            ModuleItems.Add(new Module { IdModule = 19, IdModulePadre = 17, Name = "seguridad:roles:lista", Activo = true });

            entityBuilder.HasData(ModuleItems);
        }
    }
}
