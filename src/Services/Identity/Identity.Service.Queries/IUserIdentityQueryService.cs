using Identity.Service.Queries.DTOs;
using Service.Common.Collection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Identity.Service.Queries
{
    public interface IUserIdentityQueryService
    {
        Task<DataCollection<ApplicationUserDto>> GetAllUsersAsync();
    }
}
