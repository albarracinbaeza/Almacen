using Identity.Domain;
using Identity.Persistence.Database;
using Identity.Service.EventHandlers.Commands;
using Identity.Service.EventHandlers.Responses;
using MediatR;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Identity.Service.EventHandlers
{
    public class UserLoginEventHandler : IRequestHandler<UserLoginCommand, IdentityAccess>
    {
        private readonly ILogger<UserLoginEventHandler> _logger;
        private readonly SignInManager<ApplicationUser> _signInManager;
        private readonly ApplicationDbContext _context;
        private readonly IConfiguration _configuration;

        public UserLoginEventHandler(SignInManager<ApplicationUser> signInManager, ApplicationDbContext context, IConfiguration configuration, ILogger<UserLoginEventHandler> logger)
        {
            _signInManager = signInManager;
            _logger = logger;
            _context = context;
            _configuration = configuration;
        }
        public async Task<IdentityAccess> Handle(UserLoginCommand command, CancellationToken cancellationToken)
        {
            var result = new IdentityAccess();

            var user = await _context.Users.Where(x => x.Email == command.Email).FirstOrDefaultAsync();
            if (user != null)
            {
                var response = await _signInManager.CheckPasswordSignInAsync(user, command.password, false);

                if (response.Succeeded)
                {
                    result.Succeeded = true;
                    await GenerateToken(user, result);
                }
                else {
                    result.errorMessage = "EL password no es valido vuelva a intentarlo!.";
                }
            }
            else {
                result.errorMessage = "EL correo electrónico no esta suscrito al sistema!";
            }
            return result;
        }

        private async Task GenerateToken(ApplicationUser user, IdentityAccess identity)
        {
            var secretKey = _configuration.GetSection("SecretKey").Value;
            var key = Encoding.ASCII.GetBytes(secretKey);

            var claims = new List<Claim>
            {
                new Claim(ClaimTypes.NameIdentifier, user.Id),
                new Claim(ClaimTypes.Email, user.Email),
                new Claim(ClaimTypes.Name, user.FirstName + " " + user.LastName),                
                new Claim(ClaimTypes.Surname, user.LastName)
            };

            var userRoles = await _context.UserRoles.Where(x => x.UserId == user.Id).ToListAsync();
            var roles = await _context.Roles.ToListAsync();
            
            foreach (var role in roles)
            {
                if (userRoles.Where(x => x.RoleId == role.Id).Count() > 0) {
                    claims.Add(new Claim(ClaimTypes.Role, role.Name));
                    claims.Add(new Claim("IdRole", role.Id));
                }                
            }

            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(claims),
                Expires = DateTime.UtcNow.AddMinutes(20),
                SigningCredentials = new SigningCredentials(
                    new SymmetricSecurityKey(key),
                    SecurityAlgorithms.HmacSha256Signature
                )
            };

            var tokenHandler = new JwtSecurityTokenHandler();
            var createdToken = tokenHandler.CreateToken(tokenDescriptor);

            identity.AccessToken = tokenHandler.WriteToken(createdToken);
            identity.UserName = user.FirstName + " " + user.LastName;

            var rol= roles.Select(x => new Role{ Id = x.Id, Name = x.Name }).ToList();
            identity.Roles = rol;
        }
    }
}
