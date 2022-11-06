using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace User.Domain
{
    public class MenuRole
    {
        [Key]
        public int IdMenuRol { get; set; }
        public int IdMenu { get; set; }
        public string IdRol { get; set; }
        public bool Activo { get; set; }
    }
}
