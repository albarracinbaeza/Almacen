using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace User.Persistence.Database.Migrations
{
    public partial class Initializer : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "User");

            migrationBuilder.CreateTable(
                name: "MenuModules",
                schema: "User",
                columns: table => new
                {
                    IdMenuModule = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdMenu = table.Column<int>(type: "int", nullable: false),
                    IdModule = table.Column<int>(type: "int", nullable: false),
                    Activo = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MenuModules", x => x.IdMenuModule);
                });

            migrationBuilder.CreateTable(
                name: "MenuRoles",
                schema: "User",
                columns: table => new
                {
                    IdMenuRol = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdMenu = table.Column<int>(type: "int", nullable: false),
                    IdRol = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Activo = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MenuRoles", x => x.IdMenuRol);
                });

            migrationBuilder.CreateTable(
                name: "Menus",
                schema: "User",
                columns: table => new
                {
                    IdMenu = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdMenuPadre = table.Column<int>(type: "int", nullable: false),
                    NombreMenu = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    Descripcion = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    RutaImagen = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    Clase = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    RutaPagina = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Orden = table.Column<int>(type: "int", nullable: false),
                    DatoTarget = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    RutaArbol = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    TipoIcono = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Icono = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Visible = table.Column<bool>(type: "bit", nullable: false),
                    Activo = table.Column<bool>(type: "bit", nullable: false),
                    FechaCreado = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FechaModificado = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Menus", x => x.IdMenu);
                });

            migrationBuilder.CreateTable(
                name: "MenuUsers",
                schema: "User",
                columns: table => new
                {
                    IdMenuUser = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdMenu = table.Column<int>(type: "int", nullable: false),
                    IdUser = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Activo = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MenuUsers", x => x.IdMenuUser);
                });

            migrationBuilder.CreateTable(
                name: "ModuleRoles",
                schema: "User",
                columns: table => new
                {
                    IdModuleRol = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdModule = table.Column<int>(type: "int", nullable: false),
                    IdRol = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AllowCreate = table.Column<bool>(type: "bit", nullable: false),
                    AllowModify = table.Column<bool>(type: "bit", nullable: false),
                    AllowEliminate = table.Column<bool>(type: "bit", nullable: false),
                    Activo = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ModuleRoles", x => x.IdModuleRol);
                });

            migrationBuilder.CreateTable(
                name: "Modules",
                schema: "User",
                columns: table => new
                {
                    IdModule = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdModulePadre = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Activo = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Modules", x => x.IdModule);
                });

            migrationBuilder.CreateTable(
                name: "ModuleUsers",
                schema: "User",
                columns: table => new
                {
                    IdModuleUser = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdModule = table.Column<int>(type: "int", nullable: false),
                    IdUser = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AllowCreate = table.Column<bool>(type: "bit", nullable: false),
                    AllowModify = table.Column<bool>(type: "bit", nullable: false),
                    AllowEliminate = table.Column<bool>(type: "bit", nullable: false),
                    Activo = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ModuleUsers", x => x.IdModuleUser);
                });

            migrationBuilder.InsertData(
                schema: "User",
                table: "MenuModules",
                columns: new[] { "IdMenuModule", "Activo", "IdMenu", "IdModule" },
                values: new object[,]
                {
                    { 1, true, 1, 0 },
                    { 2, true, 2, 1 },
                    { 3, true, 3, 2 },
                    { 4, true, 4, 2 },
                    { 5, true, 5, 2 },
                    { 6, true, 6, 3 },
                    { 7, true, 7, 3 },
                    { 8, true, 8, 3 },
                    { 9, true, 9, 4 },
                    { 10, true, 10, 5 },
                    { 11, true, 11, 5 },
                    { 12, true, 12, 5 },
                    { 13, true, 13, 6 },
                    { 14, true, 14, 6 },
                    { 15, true, 15, 6 },
                    { 16, true, 16, 7 },
                    { 17, true, 17, 7 },
                    { 18, true, 18, 8 },
                    { 19, true, 19, 8 },
                    { 20, true, 20, 8 }
                });

            migrationBuilder.InsertData(
                schema: "User",
                table: "MenuRoles",
                columns: new[] { "IdMenuRol", "Activo", "IdMenu", "IdRol" },
                values: new object[,]
                {
                    { 1, true, 1, "178cb4b8-f8a4-45a6-b0dc-0c4f93f8aadb" },
                    { 2, true, 2, "178cb4b8-f8a4-45a6-b0dc-0c4f93f8aadb" },
                    { 3, true, 3, "178cb4b8-f8a4-45a6-b0dc-0c4f93f8aadb" },
                    { 4, true, 4, "178cb4b8-f8a4-45a6-b0dc-0c4f93f8aadb" },
                    { 5, true, 5, "178cb4b8-f8a4-45a6-b0dc-0c4f93f8aadb" },
                    { 6, true, 6, "178cb4b8-f8a4-45a6-b0dc-0c4f93f8aadb" },
                    { 7, true, 7, "178cb4b8-f8a4-45a6-b0dc-0c4f93f8aadb" },
                    { 8, true, 8, "178cb4b8-f8a4-45a6-b0dc-0c4f93f8aadb" },
                    { 9, true, 9, "178cb4b8-f8a4-45a6-b0dc-0c4f93f8aadb" },
                    { 10, true, 10, "178cb4b8-f8a4-45a6-b0dc-0c4f93f8aadb" },
                    { 11, true, 11, "178cb4b8-f8a4-45a6-b0dc-0c4f93f8aadb" },
                    { 12, true, 12, "178cb4b8-f8a4-45a6-b0dc-0c4f93f8aadb" },
                    { 13, true, 13, "178cb4b8-f8a4-45a6-b0dc-0c4f93f8aadb" },
                    { 14, true, 14, "178cb4b8-f8a4-45a6-b0dc-0c4f93f8aadb" },
                    { 15, true, 15, "178cb4b8-f8a4-45a6-b0dc-0c4f93f8aadb" },
                    { 16, true, 16, "178cb4b8-f8a4-45a6-b0dc-0c4f93f8aadb" },
                    { 17, true, 17, "178cb4b8-f8a4-45a6-b0dc-0c4f93f8aadb" },
                    { 18, true, 18, "178cb4b8-f8a4-45a6-b0dc-0c4f93f8aadb" },
                    { 19, true, 19, "178cb4b8-f8a4-45a6-b0dc-0c4f93f8aadb" },
                    { 20, true, 20, "178cb4b8-f8a4-45a6-b0dc-0c4f93f8aadb" }
                });

            migrationBuilder.InsertData(
                schema: "User",
                table: "Menus",
                columns: new[] { "IdMenu", "Activo", "Clase", "DatoTarget", "Descripcion", "FechaCreado", "FechaModificado", "Icono", "IdMenuPadre", "NombreMenu", "Orden", "RutaArbol", "RutaImagen", "RutaPagina", "TipoIcono", "Visible" },
                values: new object[,]
                {
                    { 1, true, "", "", "Menu de Usuarios Web Empresarial", new DateTime(2022, 11, 3, 16, 29, 43, 354, DateTimeKind.Local).AddTicks(1145), new DateTime(2022, 11, 3, 16, 29, 43, 354, DateTimeKind.Local).AddTicks(1156), "", 0, "Nodo 0 - Menu Web Empresarial", 0, "", "", "", "", false },
                    { 2, true, "glyphicon glyphicon-user position-left", "", "Tablero de control", new DateTime(2022, 11, 3, 16, 29, 43, 354, DateTimeKind.Local).AddTicks(1161), new DateTime(2022, 11, 3, 16, 29, 43, 354, DateTimeKind.Local).AddTicks(1161), "layers", 0, "Tablero de control", 1, "", "", "main/dashboard", "father-icon", true }
                });

            migrationBuilder.InsertData(
                schema: "User",
                table: "Menus",
                columns: new[] { "IdMenu", "Activo", "Clase", "DatoTarget", "Descripcion", "FechaCreado", "FechaModificado", "Icono", "IdMenuPadre", "NombreMenu", "Orden", "RutaArbol", "RutaImagen", "RutaPagina", "TipoIcono", "Visible" },
                values: new object[,]
                {
                    { 3, true, "glyphicon glyphicon-user position-left", "", "Clientes", new DateTime(2022, 11, 3, 16, 29, 43, 354, DateTimeKind.Local).AddTicks(1164), new DateTime(2022, 11, 3, 16, 29, 43, 354, DateTimeKind.Local).AddTicks(1164), "layers", 0, "Clientes", 2, "", "", "", "father-icon", true },
                    { 4, true, "glyphicon glyphicon-user position-left", "", "Nuevo", new DateTime(2022, 11, 3, 16, 29, 43, 354, DateTimeKind.Local).AddTicks(1166), new DateTime(2022, 11, 3, 16, 29, 43, 354, DateTimeKind.Local).AddTicks(1167), "add", 3, "Nuevo", 1, "", "", "main", "father-icon", true },
                    { 5, true, "glyphicon glyphicon-user position-left", "", "Lista", new DateTime(2022, 11, 3, 16, 29, 43, 354, DateTimeKind.Local).AddTicks(1169), new DateTime(2022, 11, 3, 16, 29, 43, 354, DateTimeKind.Local).AddTicks(1169), "list", 3, "Lista", 2, "", "", "main", "father-icon", true },
                    { 6, true, "glyphicon glyphicon-user position-left", "", "Productos", new DateTime(2022, 11, 3, 16, 29, 43, 354, DateTimeKind.Local).AddTicks(1173), new DateTime(2022, 11, 3, 16, 29, 43, 354, DateTimeKind.Local).AddTicks(1173), "layers", 0, "Productos", 3, "", "", "", "father-icon", true },
                    { 7, true, "glyphicon glyphicon-user position-left", "", "Nuevo", new DateTime(2022, 11, 3, 16, 29, 43, 354, DateTimeKind.Local).AddTicks(1175), new DateTime(2022, 11, 3, 16, 29, 43, 354, DateTimeKind.Local).AddTicks(1175), "add", 6, "Nuevo", 1, "", "", "main", "father-icon", true },
                    { 8, true, "glyphicon glyphicon-user position-left", "", "Lista", new DateTime(2022, 11, 3, 16, 29, 43, 354, DateTimeKind.Local).AddTicks(1177), new DateTime(2022, 11, 3, 16, 29, 43, 354, DateTimeKind.Local).AddTicks(1177), "list", 6, "Lista", 2, "", "", "main", "father-icon", true },
                    { 9, true, "glyphicon glyphicon-user position-left", "", "Seguridad", new DateTime(2022, 11, 3, 16, 29, 43, 354, DateTimeKind.Local).AddTicks(1179), new DateTime(2022, 11, 3, 16, 29, 43, 354, DateTimeKind.Local).AddTicks(1179), "layers", 0, "Seguridad", 4, "", "", "main", "father-icon", true },
                    { 10, true, "glyphicon glyphicon-user position-left", "", "Usuarios", new DateTime(2022, 11, 3, 16, 29, 43, 354, DateTimeKind.Local).AddTicks(1181), new DateTime(2022, 11, 3, 16, 29, 43, 354, DateTimeKind.Local).AddTicks(1182), "layers", 9, "Usuarios", 1, "", "", "main", "father-icon", true },
                    { 11, true, "glyphicon glyphicon-user position-left", "", "Nuevo", new DateTime(2022, 11, 3, 16, 29, 43, 354, DateTimeKind.Local).AddTicks(1184), new DateTime(2022, 11, 3, 16, 29, 43, 354, DateTimeKind.Local).AddTicks(1184), "add", 10, "Nuevo", 1, "", "", "main", "father-icon", true },
                    { 12, true, "glyphicon glyphicon-user position-left", "", "Lista", new DateTime(2022, 11, 3, 16, 29, 43, 354, DateTimeKind.Local).AddTicks(1186), new DateTime(2022, 11, 3, 16, 29, 43, 354, DateTimeKind.Local).AddTicks(1186), "add", 10, "Lista", 2, "", "", "main", "father-icon", true },
                    { 13, true, "glyphicon glyphicon-user position-left", "", "Menus", new DateTime(2022, 11, 3, 16, 29, 43, 354, DateTimeKind.Local).AddTicks(1188), new DateTime(2022, 11, 3, 16, 29, 43, 354, DateTimeKind.Local).AddTicks(1188), "layers", 9, "Menus", 2, "", "", "main", "father-icon", true },
                    { 14, true, "glyphicon glyphicon-user position-left", "", "Nuevo", new DateTime(2022, 11, 3, 16, 29, 43, 354, DateTimeKind.Local).AddTicks(1189), new DateTime(2022, 11, 3, 16, 29, 43, 354, DateTimeKind.Local).AddTicks(1190), "add", 13, "Nuevo", 1, "", "", "main", "father-icon", true },
                    { 15, true, "glyphicon glyphicon-user position-left", "", "Lista", new DateTime(2022, 11, 3, 16, 29, 43, 354, DateTimeKind.Local).AddTicks(1191), new DateTime(2022, 11, 3, 16, 29, 43, 354, DateTimeKind.Local).AddTicks(1192), "list", 13, "Lista", 1, "", "", "main", "father-icon", true },
                    { 16, true, "glyphicon glyphicon-user position-left", "", "Menus por rol", new DateTime(2022, 11, 3, 16, 29, 43, 354, DateTimeKind.Local).AddTicks(1193), new DateTime(2022, 11, 3, 16, 29, 43, 354, DateTimeKind.Local).AddTicks(1193), "layers", 13, "Menus por rol", 1, "", "", "main", "father-icon", true },
                    { 17, true, "glyphicon glyphicon-user position-left", "", "Lista", new DateTime(2022, 11, 3, 16, 29, 43, 354, DateTimeKind.Local).AddTicks(1196), new DateTime(2022, 11, 3, 16, 29, 43, 354, DateTimeKind.Local).AddTicks(1196), "list", 16, "Lista", 1, "", "", "main", "father-icon", true },
                    { 18, true, "glyphicon glyphicon-user position-left", "", "Roles", new DateTime(2022, 11, 3, 16, 29, 43, 354, DateTimeKind.Local).AddTicks(1199), new DateTime(2022, 11, 3, 16, 29, 43, 354, DateTimeKind.Local).AddTicks(1199), "layers", 9, "Roles", 3, "", "", "main", "father-icon", true },
                    { 19, true, "glyphicon glyphicon-user position-left", "", "Nuevo", new DateTime(2022, 11, 3, 16, 29, 43, 354, DateTimeKind.Local).AddTicks(1201), new DateTime(2022, 11, 3, 16, 29, 43, 354, DateTimeKind.Local).AddTicks(1201), "add", 18, "Nuevo", 1, "", "", "main", "father-icon", true },
                    { 20, true, "glyphicon glyphicon-user position-left", "", "Lista", new DateTime(2022, 11, 3, 16, 29, 43, 354, DateTimeKind.Local).AddTicks(1203), new DateTime(2022, 11, 3, 16, 29, 43, 354, DateTimeKind.Local).AddTicks(1203), "list", 18, "Lista", 2, "", "", "main", "father-icon", true }
                });

            migrationBuilder.InsertData(
                schema: "User",
                table: "ModuleRoles",
                columns: new[] { "IdModuleRol", "Activo", "AllowCreate", "AllowEliminate", "AllowModify", "IdModule", "IdRol" },
                values: new object[,]
                {
                    { 1, true, true, true, true, 1, "178cb4b8-f8a4-45a6-b0dc-0c4f93f8aadb" },
                    { 2, true, true, true, true, 2, "178cb4b8-f8a4-45a6-b0dc-0c4f93f8aadb" },
                    { 3, true, true, true, true, 3, "178cb4b8-f8a4-45a6-b0dc-0c4f93f8aadb" },
                    { 4, true, true, true, true, 4, "178cb4b8-f8a4-45a6-b0dc-0c4f93f8aadb" },
                    { 5, true, true, true, true, 5, "178cb4b8-f8a4-45a6-b0dc-0c4f93f8aadb" },
                    { 6, true, true, true, true, 6, "178cb4b8-f8a4-45a6-b0dc-0c4f93f8aadb" },
                    { 7, true, true, true, true, 7, "178cb4b8-f8a4-45a6-b0dc-0c4f93f8aadb" },
                    { 8, true, true, true, true, 8, "178cb4b8-f8a4-45a6-b0dc-0c4f93f8aadb" }
                });

            migrationBuilder.InsertData(
                schema: "User",
                table: "Modules",
                columns: new[] { "IdModule", "Activo", "IdModulePadre", "Name" },
                values: new object[,]
                {
                    { 1, true, 1, "tablero_control" },
                    { 2, true, 2, "clientes" },
                    { 3, true, 2, "clientes:nuevo" },
                    { 4, true, 2, "clientes:lista" },
                    { 5, true, 5, "productos" },
                    { 6, true, 5, "productos:nuevo" },
                    { 7, true, 5, "productos:lista" },
                    { 8, true, 8, "seguridad" },
                    { 9, true, 8, "seguridad:usuarios" },
                    { 10, true, 9, "seguridad:usuarios:nuevo" },
                    { 11, true, 9, "seguridad:usuarios:lista" },
                    { 12, true, 8, "seguridad:menus" },
                    { 13, true, 12, "seguridad:menus:nuevo" },
                    { 14, true, 12, "seguridad:menus:lista" },
                    { 15, true, 12, "seguridad:menus:menus_rol" },
                    { 16, true, 15, "seguridad:menus:menus_rol:lista" }
                });

            migrationBuilder.InsertData(
                schema: "User",
                table: "Modules",
                columns: new[] { "IdModule", "Activo", "IdModulePadre", "Name" },
                values: new object[] { 17, true, 8, "seguridad:roles" });

            migrationBuilder.InsertData(
                schema: "User",
                table: "Modules",
                columns: new[] { "IdModule", "Activo", "IdModulePadre", "Name" },
                values: new object[] { 18, true, 17, "seguridad:roles:nuevo" });

            migrationBuilder.InsertData(
                schema: "User",
                table: "Modules",
                columns: new[] { "IdModule", "Activo", "IdModulePadre", "Name" },
                values: new object[] { 19, true, 17, "seguridad:roles:lista" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MenuModules",
                schema: "User");

            migrationBuilder.DropTable(
                name: "MenuRoles",
                schema: "User");

            migrationBuilder.DropTable(
                name: "Menus",
                schema: "User");

            migrationBuilder.DropTable(
                name: "MenuUsers",
                schema: "User");

            migrationBuilder.DropTable(
                name: "ModuleRoles",
                schema: "User");

            migrationBuilder.DropTable(
                name: "Modules",
                schema: "User");

            migrationBuilder.DropTable(
                name: "ModuleUsers",
                schema: "User");
        }
    }
}
