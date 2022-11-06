using Service.Common.Collection;
using System;
using System.Collections.Generic;

using System.Linq;
using System.Text;
using System.Threading.Tasks;
using User.Service.EventHandlers.Commands;
using User.Service.Queries.DTOs;

namespace User.Service.Queries
{
    public interface IMenuQueryService
    {
        Task<DataCollection<MenuDto>> GetAllMenuRolAsync(string IdRol);        
    }
}
