using Identity.Domain;
using Identity.Persistence.Database;
using Identity.Service.Queries.DTOs;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Service.Common.Collection;
using Service.Common.Mapping;
using Service.Common.Paging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Identity.Service.Queries
{
    public class UserIdentityQueryService : IUserIdentityQueryService
    {
        private readonly UserManager<ApplicationUser> _userManager;
        public UserIdentityQueryService(UserManager<ApplicationUser> userManager)
        {
            _userManager = userManager;
        }
        public async Task<DataCollection<ApplicationUserDto>> GetAllUsersAsync()
        {            
            var collection = await _userManager.Users.GetPagedAsync(1, _userManager.Users.ToList().Count());
            return collection.MapTo<DataCollection<ApplicationUserDto>>();
        }
    }
}
