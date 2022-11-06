using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace User.Persistence.Database.Migrations
{

    public partial class UspGetMenusByIdRol_prueba : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            string procedureGetMenusByIdRol = @"CREATE PROCEDURE [User].[Usp_Get_MenusRol_ByIdRol](
                                                @IdRol VARCHAR(500)
                                                )
                                                AS
                                                BEGIN
	                                                SELECT DISTINCT M.*,NR.IdRol,MR.IdModule, MD.IdModulePadre, AllowCreate, AllowModify, AllowEliminate 
	                                                FROM [User].MenuS M	
	                                                INNER JOIN [User].MenuRoles NR (NOLOCK) ON NR.IdMenu = M.IdMenu
	                                                INNER JOIN [User].MenuModules NM (NOLOCK) ON NM.IdMenu = NR.IdMenu
	                                                INNER JOIN [User].ModuleRoles MR (NOLOCK) ON MR.IdRol = NR.IdRol AND MR.IdModule = NM.IdModule
	                                                INNER JOIN [User].Modules MD (NOLOCK) ON MD.IdModule = MR.IdModule
	                                                WHERE NR.IdRol = @IdRol
                                                END";
            migrationBuilder.Sql(procedureGetMenusByIdRol);            
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            string procedureGetMenusByIdRol = @"DROP PROCEDURE [User].[Usp_Get_MenusRol_ByIdRol]";
            migrationBuilder.Sql(procedureGetMenusByIdRol);           
        }
    }

}
