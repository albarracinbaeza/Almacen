using Identity.Domain;
using Identity.Persistence.Database;
using Identity.Service.EventHandlers.Commands;
using MediatR;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Identity.Service.EventHandlers
{
    public class UserCreateEventHandler : IRequestHandler<UserCreateCommand, IdentityResult>
    {
        private readonly ApplicationDbContext _context;
        private readonly UserManager<ApplicationUser> _userManager;
        public UserCreateEventHandler(UserManager<ApplicationUser> userManager, ApplicationDbContext context)
        {
            _context = context;
            _userManager = userManager;
        }

        public async Task<IdentityResult> Handle(UserCreateCommand command, CancellationToken cancellationToken)
        {
            var identityResult = new IdentityResult();
            var entry = new ApplicationUser
            {
                FirstName = command.FirstName,
                LastName = command.LastName,
                Email = command.Email,
                UserName = command.Email
            };

            using (var trx = await _context.Database.BeginTransactionAsync())
            {
                await _userManager.CreateAsync(entry, command.Password);
                identityResult = await _userManager.AddToRoleAsync(entry, command.Role);
                await trx.CommitAsync();
            }
            return identityResult;
        }
    }
}
