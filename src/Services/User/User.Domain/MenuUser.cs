using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace User.Domain
{
    public class MenuUser
    {
        [Key]
        public int IdMenuUser { get; set; }
        public int IdMenu { get; set; }
        public string IdUser { get; set; }
        public bool Activo { get; set; }
    }
}
