using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace User.Domain
{
    public class Module
    {
        [Key]
        public int IdModule { get; set; }
        public int IdModulePadre { get; set; }
        public string Name { get; set; }
        public bool Activo { get; set; }
    }
}
