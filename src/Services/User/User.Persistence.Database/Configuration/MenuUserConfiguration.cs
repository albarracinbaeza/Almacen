using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using User.Domain;

namespace User.Persistence.Database.Configuration
{
    public class MenuUserConfiguration
    {
        public MenuUserConfiguration(EntityTypeBuilder<MenuUser> entityBuilder)
        {
            entityBuilder.HasKey(x => x.IdMenuUser);
        }
    }
}
