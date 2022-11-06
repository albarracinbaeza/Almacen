using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace User.Service.Queries.DTOs
{
    public class MenuDto
    {
        public int IdMenu { get; set; }
        public int IdMenuPadre { get; set; }
        public string NombreMenu { get; set; }
        public string Descripcion { get; set; }
        public string RutaImagen { get; set; }
        public string Clase { get; set; }
        public string RutaPagina { get; set; }
        public int Orden { get; set; }
        public string DatoTarget { get; set; }
        public string RutaArbol { get; set; }
        public string TipoIcono { get; set; }
        public string Icono { get; set; }
        public bool Visible { get; set; }
        public bool Activo { get; set; }
        public DateTime FechaCreado { get; set; }
        public DateTime FechaModificado { get; set; }
        public int IdModulo { get; set; }
        public int IdModuloPadre { get; set; }
        public bool AllowCreate { get; set; }
        public bool AllowModify { get; set; }
        public bool AllowEliminate { get; set; }
    }
}
