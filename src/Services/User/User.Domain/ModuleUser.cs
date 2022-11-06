using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace User.Domain
{
    public class ModuleUser
    {
        [Key]
        public int IdModuleUser { get; set; }
        public int IdModule { get; set; }
        public string IdUser { get; set; }
        public bool AllowCreate { get; set; }
        public bool AllowModify { get; set; }
        public bool AllowEliminate { get; set; }
        public bool Activo { get; set; }
    }
}
