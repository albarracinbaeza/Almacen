using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using User.Domain;

namespace User.Persistence.Database.Configuration
{
    public class MenuRoleConfiguration
    {
        public MenuRoleConfiguration(EntityTypeBuilder<MenuRole> entityBuilder)
        {
            entityBuilder.HasKey(x => x.IdMenuRol);

            List<MenuRole> MenuRoleItems = new List<MenuRole>();

            string IdRol = "178cb4b8-f8a4-45a6-b0dc-0c4f93f8aadb";

            MenuRoleItems.Add(new MenuRole { IdMenuRol = 1, IdMenu = 1, IdRol = IdRol, Activo = true });
            MenuRoleItems.Add(new MenuRole { IdMenuRol = 2, IdMenu = 2, IdRol = IdRol, Activo = true });
            MenuRoleItems.Add(new MenuRole { IdMenuRol = 3, IdMenu = 3, IdRol = IdRol, Activo = true });
            MenuRoleItems.Add(new MenuRole { IdMenuRol = 4, IdMenu = 4, IdRol = IdRol, Activo = true });
            MenuRoleItems.Add(new MenuRole { IdMenuRol = 5, IdMenu = 5, IdRol = IdRol, Activo = true });
            MenuRoleItems.Add(new MenuRole { IdMenuRol = 6, IdMenu = 6, IdRol = IdRol, Activo = true });
            MenuRoleItems.Add(new MenuRole { IdMenuRol = 7, IdMenu = 7, IdRol = IdRol, Activo = true });
            MenuRoleItems.Add(new MenuRole { IdMenuRol = 8, IdMenu = 8, IdRol = IdRol, Activo = true });
            MenuRoleItems.Add(new MenuRole { IdMenuRol = 9, IdMenu = 9, IdRol = IdRol, Activo = true });
            MenuRoleItems.Add(new MenuRole { IdMenuRol = 10, IdMenu = 10, IdRol = IdRol, Activo = true });
            MenuRoleItems.Add(new MenuRole { IdMenuRol = 11, IdMenu = 11, IdRol = IdRol, Activo = true });
            MenuRoleItems.Add(new MenuRole { IdMenuRol = 12, IdMenu = 12, IdRol = IdRol, Activo = true });
            MenuRoleItems.Add(new MenuRole { IdMenuRol = 13, IdMenu = 13, IdRol = IdRol, Activo = true });
            MenuRoleItems.Add(new MenuRole { IdMenuRol = 14, IdMenu = 14, IdRol = IdRol, Activo = true });
            MenuRoleItems.Add(new MenuRole { IdMenuRol = 15, IdMenu = 15, IdRol = IdRol, Activo = true });
            MenuRoleItems.Add(new MenuRole { IdMenuRol = 16, IdMenu = 16, IdRol = IdRol, Activo = true });
            MenuRoleItems.Add(new MenuRole { IdMenuRol = 17, IdMenu = 17, IdRol = IdRol, Activo = true });
            MenuRoleItems.Add(new MenuRole { IdMenuRol = 18, IdMenu = 18, IdRol = IdRol, Activo = true });
            MenuRoleItems.Add(new MenuRole { IdMenuRol = 19, IdMenu = 19, IdRol = IdRol, Activo = true });
            MenuRoleItems.Add(new MenuRole { IdMenuRol = 20, IdMenu = 20, IdRol = IdRol, Activo = true });

            entityBuilder.HasData(MenuRoleItems);
        }
    }
}
