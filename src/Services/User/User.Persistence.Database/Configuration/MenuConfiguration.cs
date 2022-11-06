using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using User.Domain;

namespace User.Persistence.Database.Configuration
{
    internal class MenuConfiguration
    {
        public MenuConfiguration(EntityTypeBuilder<Menu> entityBuilder)
        {
            entityBuilder.HasKey(x => x.IdMenu);
            entityBuilder.Property(x => x.Descripcion).IsRequired().HasMaxLength(250);
            entityBuilder.Property(x => x.NombreMenu).HasMaxLength(250);
            entityBuilder.Property(x => x.RutaImagen).HasMaxLength(250);
            entityBuilder.Property(x => x.DatoTarget).HasMaxLength(50);
            entityBuilder.Property(x => x.RutaArbol).HasMaxLength(250);
            entityBuilder.Property(x => x.TipoIcono).HasMaxLength(50);
            entityBuilder.Property(x => x.Icono).HasMaxLength(50);
            entityBuilder.Property(x => x.Clase).HasMaxLength(100);

            List<Menu> MenuItems = new List<Menu>();
            
            MenuItems.Add(new Menu { 
                IdMenu = 1,
                IdMenuPadre = 0,
                NombreMenu = "Nodo 0 - Menu Web Empresarial",
                Descripcion = "Menu de Usuarios Web Empresarial",
                RutaImagen = "",
                Clase="",
                RutaPagina="",
                Orden=0,
                DatoTarget="",
                RutaArbol="",
                TipoIcono="", 
                Icono="",
                Visible=false,
                Activo=true,
                FechaCreado= DateTime.Now,
                FechaModificado= DateTime.Now
            });
            MenuItems.Add(new Menu
            {
                IdMenu = 2,
                IdMenuPadre = 0,
                NombreMenu = "Tablero de control",
                Descripcion = "Tablero de control",
                RutaImagen = "",
                Clase = "glyphicon glyphicon-user position-left",
                RutaPagina = "main/dashboard",
                Orden = 1,
                DatoTarget = "",
                RutaArbol = "",
                TipoIcono = "father-icon",
                Icono = "layers",
                Visible = true,
                Activo = true,
                FechaCreado = DateTime.Now,
                FechaModificado = DateTime.Now
            });
            MenuItems.Add(new Menu
            {
                IdMenu = 3,
                IdMenuPadre = 0,
                NombreMenu = "Clientes",
                Descripcion = "Clientes",
                RutaImagen = "",
                Clase = "glyphicon glyphicon-user position-left",
                RutaPagina = "",
                Orden = 2,
                DatoTarget = "",
                RutaArbol = "",
                TipoIcono = "father-icon",
                Icono = "layers",
                Visible = true,
                Activo = true,
                FechaCreado = DateTime.Now,
                FechaModificado = DateTime.Now
            });
            MenuItems.Add(new Menu
            {
                IdMenu = 4,
                IdMenuPadre = 3,
                NombreMenu = "Nuevo",
                Descripcion = "Nuevo",
                RutaImagen = "",
                Clase = "glyphicon glyphicon-user position-left",
                RutaPagina = "main",
                Orden = 1,
                DatoTarget = "",
                RutaArbol = "",
                TipoIcono = "father-icon",
                Icono = "add",
                Visible = true,
                Activo = true,
                FechaCreado = DateTime.Now,
                FechaModificado = DateTime.Now
            });
            MenuItems.Add(new Menu
            {
                IdMenu = 5,
                IdMenuPadre = 3,
                NombreMenu = "Lista",
                Descripcion = "Lista",
                RutaImagen = "",
                Clase = "glyphicon glyphicon-user position-left",
                RutaPagina = "main",
                Orden = 2,
                DatoTarget = "",
                RutaArbol = "",
                TipoIcono = "father-icon",
                Icono = "list",
                Visible = true,
                Activo = true,
                FechaCreado = DateTime.Now,
                FechaModificado = DateTime.Now
            });
            MenuItems.Add(new Menu
            {
                IdMenu = 6,
                IdMenuPadre = 0,
                NombreMenu = "Productos",
                Descripcion = "Productos",
                RutaImagen = "",
                Clase = "glyphicon glyphicon-user position-left",
                RutaPagina = "",
                Orden = 3,
                DatoTarget = "",
                RutaArbol = "",
                TipoIcono = "father-icon",
                Icono = "layers",
                Visible = true,
                Activo = true,
                FechaCreado = DateTime.Now,
                FechaModificado = DateTime.Now
            });
            MenuItems.Add(new Menu
            {
                IdMenu = 7,
                IdMenuPadre = 6,
                NombreMenu = "Nuevo",
                Descripcion = "Nuevo",
                RutaImagen = "",
                Clase = "glyphicon glyphicon-user position-left",
                RutaPagina = "main",
                Orden = 1,
                DatoTarget = "",
                RutaArbol = "",
                TipoIcono = "father-icon",
                Icono = "add",
                Visible = true,
                Activo = true,
                FechaCreado = DateTime.Now,
                FechaModificado = DateTime.Now
            });
            MenuItems.Add(new Menu
            {
                IdMenu = 8,
                IdMenuPadre = 6,
                NombreMenu = "Lista",
                Descripcion = "Lista",
                RutaImagen = "",
                Clase = "glyphicon glyphicon-user position-left",
                RutaPagina = "main",
                Orden = 2,
                DatoTarget = "",
                RutaArbol = "",
                TipoIcono = "father-icon",
                Icono = "list",
                Visible = true,
                Activo = true,
                FechaCreado = DateTime.Now,
                FechaModificado = DateTime.Now
            });
            MenuItems.Add(new Menu
            {
                IdMenu = 9,
                IdMenuPadre = 0,
                NombreMenu = "Seguridad",
                Descripcion = "Seguridad",
                RutaImagen = "",
                Clase = "glyphicon glyphicon-user position-left",
                RutaPagina = "main",
                Orden = 4,
                DatoTarget = "",
                RutaArbol = "",
                TipoIcono = "father-icon",
                Icono = "layers",
                Visible = true,
                Activo = true,
                FechaCreado = DateTime.Now,
                FechaModificado = DateTime.Now
            });
            MenuItems.Add(new Menu
            {
                IdMenu = 10,
                IdMenuPadre = 9,
                NombreMenu = "Usuarios",
                Descripcion = "Usuarios",
                RutaImagen = "",
                Clase = "glyphicon glyphicon-user position-left",
                RutaPagina = "main",
                Orden = 1,
                DatoTarget = "",
                RutaArbol = "",
                TipoIcono = "father-icon",
                Icono = "layers",
                Visible = true,
                Activo = true,
                FechaCreado = DateTime.Now,
                FechaModificado = DateTime.Now
            });
            MenuItems.Add(new Menu
            {
                IdMenu = 11,
                IdMenuPadre = 10,
                NombreMenu = "Nuevo",
                Descripcion = "Nuevo",
                RutaImagen = "",
                Clase = "glyphicon glyphicon-user position-left",
                RutaPagina = "main/security/user/create",
                Orden = 1,
                DatoTarget = "",
                RutaArbol = "",
                TipoIcono = "father-icon",
                Icono = "add",
                Visible = true,
                Activo = true,
                FechaCreado = DateTime.Now,
                FechaModificado = DateTime.Now
            });
            MenuItems.Add(new Menu
            {
                IdMenu = 12,
                IdMenuPadre = 10,
                NombreMenu = "Lista",
                Descripcion = "Lista",
                RutaImagen = "",
                Clase = "glyphicon glyphicon-user position-left",
                RutaPagina = "main/security/user/list",
                Orden = 2,
                DatoTarget = "",
                RutaArbol = "",
                TipoIcono = "father-icon",
                Icono = "add",
                Visible = true,
                Activo = true,
                FechaCreado = DateTime.Now,
                FechaModificado = DateTime.Now
            });
            MenuItems.Add(new Menu
            {
                IdMenu = 13,
                IdMenuPadre = 9,
                NombreMenu = "Menus",
                Descripcion = "Menus",
                RutaImagen = "",
                Clase = "glyphicon glyphicon-user position-left",
                RutaPagina = "main",
                Orden = 2,
                DatoTarget = "",
                RutaArbol = "",
                TipoIcono = "father-icon",
                Icono = "layers",
                Visible = true,
                Activo = true,
                FechaCreado = DateTime.Now,
                FechaModificado = DateTime.Now
            });
            MenuItems.Add(new Menu
            {
                IdMenu = 14,
                IdMenuPadre = 13,
                NombreMenu = "Nuevo",
                Descripcion = "Nuevo",
                RutaImagen = "",
                Clase = "glyphicon glyphicon-user position-left",
                RutaPagina = "main",
                Orden = 1,
                DatoTarget = "",
                RutaArbol = "",
                TipoIcono = "father-icon",
                Icono = "add",
                Visible = true,
                Activo = true,
                FechaCreado = DateTime.Now,
                FechaModificado = DateTime.Now
            });
            MenuItems.Add(new Menu
            {
                IdMenu = 15,
                IdMenuPadre = 13,
                NombreMenu = "Lista",
                Descripcion = "Lista",
                RutaImagen = "",
                Clase = "glyphicon glyphicon-user position-left",
                RutaPagina = "main",
                Orden = 1,
                DatoTarget = "",
                RutaArbol = "",
                TipoIcono = "father-icon",
                Icono = "list",
                Visible = true,
                Activo = true,
                FechaCreado = DateTime.Now,
                FechaModificado = DateTime.Now
            });
            MenuItems.Add(new Menu
            {
                IdMenu = 16,
                IdMenuPadre = 13,
                NombreMenu = "Menus por rol",
                Descripcion = "Menus por rol",
                RutaImagen = "",
                Clase = "glyphicon glyphicon-user position-left",
                RutaPagina = "main",
                Orden = 1,
                DatoTarget = "",
                RutaArbol = "",
                TipoIcono = "father-icon",
                Icono = "layers",
                Visible = true,
                Activo = true,
                FechaCreado = DateTime.Now,
                FechaModificado = DateTime.Now
            });
            MenuItems.Add(new Menu
            {
                IdMenu = 17,
                IdMenuPadre = 16,
                NombreMenu = "Lista",
                Descripcion = "Lista",
                RutaImagen = "",
                Clase = "glyphicon glyphicon-user position-left",
                RutaPagina = "main",
                Orden = 1,
                DatoTarget = "",
                RutaArbol = "",
                TipoIcono = "father-icon",
                Icono = "list",
                Visible = true,
                Activo = true,
                FechaCreado = DateTime.Now,
                FechaModificado = DateTime.Now
            });
            MenuItems.Add(new Menu
            {
                IdMenu = 18,
                IdMenuPadre = 9,
                NombreMenu = "Roles",
                Descripcion = "Roles",
                RutaImagen = "",
                Clase = "glyphicon glyphicon-user position-left",
                RutaPagina = "main",
                Orden = 3,
                DatoTarget = "",
                RutaArbol = "",
                TipoIcono = "father-icon",
                Icono = "layers",
                Visible = true,
                Activo = true,
                FechaCreado = DateTime.Now,
                FechaModificado = DateTime.Now
            });
            MenuItems.Add(new Menu
            {
                IdMenu = 19,
                IdMenuPadre = 18,
                NombreMenu = "Nuevo",
                Descripcion = "Nuevo",
                RutaImagen = "",
                Clase = "glyphicon glyphicon-user position-left",
                RutaPagina = "main",
                Orden = 1,
                DatoTarget = "",
                RutaArbol = "",
                TipoIcono = "father-icon",
                Icono = "add",
                Visible = true,
                Activo = true,
                FechaCreado = DateTime.Now,
                FechaModificado = DateTime.Now
            });
            MenuItems.Add(new Menu
            {
                IdMenu = 20,
                IdMenuPadre = 18,
                NombreMenu = "Lista",
                Descripcion = "Lista",
                RutaImagen = "",
                Clase = "glyphicon glyphicon-user position-left",
                RutaPagina = "main",
                Orden = 2,
                DatoTarget = "",
                RutaArbol = "",
                TipoIcono = "father-icon",
                Icono = "list",
                Visible = true,
                Activo = true,
                FechaCreado = DateTime.Now,
                FechaModificado = DateTime.Now
            });
            entityBuilder.HasData(MenuItems);
        }
    }
}
