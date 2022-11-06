using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using User.Domain;

namespace User.Persistence.Database.Configuration
{
    public class ModuleUserConfiguration
    {
        public ModuleUserConfiguration(EntityTypeBuilder<ModuleUser> entityBuilder)
        {
            entityBuilder.HasKey(x => x.IdModuleUser);
        }
    }
}
