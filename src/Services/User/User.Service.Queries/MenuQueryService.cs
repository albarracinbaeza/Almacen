using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using Service.Common.Collection;
using Service.Common.Mapping;
using Service.Common.Paging;
using System;
using System.Collections.Generic;

using System.Linq;
using System.Text;
using System.Threading.Tasks;
using User.Persistence.Database;
using User.Service.EventHandlers.Commands;
using User.Service.Queries.DTOs;

namespace User.Service.Queries
{
    public class MenuQueryService : IMenuQueryService
    {
        private readonly ApplicationDbContext _context;
        
        public MenuQueryService(ApplicationDbContext context)
        {
            _context = context;        
        }

        public async Task<DataCollection<MenuDto>> GetAllMenuRolAsync(string IdRol)
        {
            //List<MenuDto> lista = new List<MenuDto>();
            ////var xparams = new SqlParameter("@IdRol", IdRol);
            ////object[] xparams = { new SqlParameter("@IdRol", IdRol) };
            ////new SqlParameter("@In_Parameter", "Value"),
            ////new SqlParameter("@Out_Parameter", SqlDbType.Int) {Direction = ParameterDirection.Output}};
            //try {
            //    var param = new SqlParameter[] {
            //            new SqlParameter() {
            //                ParameterName = "@IdRol",
            //                SqlDbType =  System.Data.SqlDbType.VarChar,
            //                Size= 500,
            //                Direction = System.Data.ParameterDirection.Input,
            //                Value = IdRol
            //            }};

            //    using (var cnn = new ApplicationDbContext(_options).Database.GetDbConnection())
            //    {
            //        var cmm = cnn.CreateCommand();
            //        cmm.CommandType = System.Data.CommandType.StoredProcedure;
            //        cmm.CommandText = "[User].[Usp_Get_MenusRol_ByIdRol]";
            //        cmm.Parameters.AddRange(param);
            //        cmm.Connection = cnn;
            //        cnn.Open();
            //        var reader = cmm.ExecuteReader();

            //        while (reader.Read())
            //        {
            //            // name from Menus table 
            //            lista.Add(new MenuDto() { 
            //                IdMenu = Convert.ToInt32(reader["IdMenu"]),
            //                IdMenuPadre = Convert.ToInt32(reader["IdMenuPadre"]),
            //                NombreMenu = Convert.ToString(reader["NombreMenu"]),
            //                Descripcion = Convert.ToString(reader["Descripcion"]),
            //                RutaImagen = Convert.ToString(reader["RutaImagen"]),
            //                Clase = Convert.ToString(reader["Clase"]),
            //                RutaPagina = Convert.ToString(reader["RutaPagina"]),
            //                Orden = Convert.ToInt32(reader["orden"]),
            //                DatoTarget = Convert.ToString(reader["DatoTarget"]),
            //                RutaArbol = Convert.ToString(reader["RutaArbol"]),
            //                TipoIcono = Convert.ToString(reader["TipoIcono"]),
            //                Icono = Convert.ToString(reader["Icono"]),
            //                Visible = Convert.ToBoolean(reader["Visible"]),
            //                FechaCreado = Convert.ToDateTime(reader["FechaCreado"]),
            //                FechaModificado = Convert.ToDateTime(reader["FechaModificado"]),
            //                AllowCreate = Convert.ToBoolean(reader["AllowCreate"]),
            //                AllowModify = Convert.ToBoolean(reader["AllowModify"]),
            //                AllowEliminate = Convert.ToBoolean(reader["AllowEliminate"])
            //            });
            //        }
            //        //reader.NextResult(); //move the next record set
            //        //while (reader.Read())
            //        //{
            //        //    // city from student address table
            //        //    string city = Convert.ToString(reader["City"]);
            //        //}
            //    }

            //} catch(Exception ex) { 
            //}


            //var ReturnValue = ((SqlParameter)params[2]).Value;
            
            var collectionModuleRoles = await _context.ModuleRoles.Where(x => x.IdRol == IdRol && x.Activo == true).Select(x => x.IdModule).ToListAsync();
            var collectionMenuModules = await _context.MenuModules.Where(x => collectionModuleRoles.Contains(x.IdModule) && x.Activo == true).Select(x => x.IdMenu).ToListAsync();
            var collectionMenuRol = await _context.MenuRoles.Where(x => x.IdRol == IdRol && x.IdMenu > 1 && collectionMenuModules.Contains(x.IdMenu) && x.Activo == true).Select(x => x.IdMenu).ToListAsync();
            var collection = await _context.Menus.Where(x => collectionMenuRol.Contains(x.IdMenu) && x.Activo == true).OrderBy(x => x.Orden).GetPagedAsync(1, collectionMenuRol.Count());

            return collection.MapTo<DataCollection<MenuDto>>();
        }
    }
}
