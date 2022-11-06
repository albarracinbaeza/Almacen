using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE = User.Domain;
using User.Persistence.Database.Configuration;

namespace User.Persistence.Database
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<BE.Menu> Menus { get; set; }
        public DbSet<BE.MenuUser> MenuUsers { get; set; }
        public DbSet<BE.MenuRole> MenuRoles { get; set; }
        public DbSet<BE.Module> Modules { get; set; }
        public DbSet<BE.MenuModule> MenuModules { get; set; }
        public DbSet<BE.ModuleRole> ModuleRoles { get; set; }
        public DbSet<BE.ModuleUser> ModuleUsers { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.HasDefaultSchema("User");

            ModelConfig(builder);
        }

        private void ModelConfig(ModelBuilder modelbuilder)
        {
            new MenuConfiguration(modelbuilder.Entity<BE.Menu>());
            new MenuRoleConfiguration(modelbuilder.Entity<BE.MenuRole>());
            new MenuUserConfiguration(modelbuilder.Entity<BE.MenuUser>());
            new ModuleConfiguration(modelbuilder.Entity<BE.Module>());
            new MenuModuleConfiguration(modelbuilder.Entity<BE.MenuModule>());
            new ModuleRoleConfiguration(modelbuilder.Entity<BE.ModuleRole>());
            new ModuleUserConfiguration(modelbuilder.Entity<BE.ModuleUser>());
        }
    }
}
