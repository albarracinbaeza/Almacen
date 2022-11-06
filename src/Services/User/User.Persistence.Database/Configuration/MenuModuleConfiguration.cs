using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using User.Domain;

namespace User.Persistence.Database.Configuration
{
    public class MenuModuleConfiguration
    {
        public MenuModuleConfiguration(EntityTypeBuilder<MenuModule> entityBuilder)
        {
            entityBuilder.HasKey(x => x.IdMenuModule);

            List<MenuModule> MenuModuleItems = new List<MenuModule>();

            MenuModuleItems.Add(new MenuModule { IdMenuModule = 1, IdMenu = 1, IdModule = 0, Activo = true });
            MenuModuleItems.Add(new MenuModule { IdMenuModule = 2, IdMenu = 2, IdModule = 1, Activo = true });
            MenuModuleItems.Add(new MenuModule { IdMenuModule = 3, IdMenu = 3, IdModule = 2, Activo = true });
            MenuModuleItems.Add(new MenuModule { IdMenuModule = 4, IdMenu = 4, IdModule = 2, Activo = true });
            MenuModuleItems.Add(new MenuModule { IdMenuModule = 5, IdMenu = 5, IdModule = 2, Activo = true });
            MenuModuleItems.Add(new MenuModule { IdMenuModule = 6, IdMenu = 6, IdModule = 3, Activo = true });
            MenuModuleItems.Add(new MenuModule { IdMenuModule = 7, IdMenu = 7, IdModule = 3, Activo = true });
            MenuModuleItems.Add(new MenuModule { IdMenuModule = 8, IdMenu = 8, IdModule = 3, Activo = true });
            MenuModuleItems.Add(new MenuModule { IdMenuModule = 9, IdMenu = 9, IdModule = 4, Activo = true });
            MenuModuleItems.Add(new MenuModule { IdMenuModule = 10, IdMenu = 10, IdModule = 5, Activo = true });
            MenuModuleItems.Add(new MenuModule { IdMenuModule = 11, IdMenu = 11, IdModule = 5, Activo = true });
            MenuModuleItems.Add(new MenuModule { IdMenuModule = 12, IdMenu = 12, IdModule = 5, Activo = true });
            MenuModuleItems.Add(new MenuModule { IdMenuModule = 13, IdMenu = 13, IdModule = 6, Activo = true });
            MenuModuleItems.Add(new MenuModule { IdMenuModule = 14, IdMenu = 14, IdModule = 6, Activo = true });
            MenuModuleItems.Add(new MenuModule { IdMenuModule = 15, IdMenu = 15, IdModule = 6, Activo = true });
            MenuModuleItems.Add(new MenuModule { IdMenuModule = 16, IdMenu = 16, IdModule = 7, Activo = true });
            MenuModuleItems.Add(new MenuModule { IdMenuModule = 17, IdMenu = 17, IdModule = 7, Activo = true });
            MenuModuleItems.Add(new MenuModule { IdMenuModule = 18, IdMenu = 18, IdModule = 8, Activo = true });
            MenuModuleItems.Add(new MenuModule { IdMenuModule = 19, IdMenu = 19, IdModule = 8, Activo = true });
            MenuModuleItems.Add(new MenuModule { IdMenuModule = 20, IdMenu = 20, IdModule = 8, Activo = true });

            entityBuilder.HasData(MenuModuleItems);
        }
    }
}
