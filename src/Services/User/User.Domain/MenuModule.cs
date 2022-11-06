using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace User.Domain
{
    public class MenuModule
    {
        [Key]
        public int IdMenuModule { get; set; }
        public int IdMenu { get; set; }
        public int IdModule { get; set; }
        public bool Activo { get; set; }
    }
}
