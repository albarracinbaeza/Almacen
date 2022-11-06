using Identity.Domain;
using Identity.Service.EventHandlers.Commands;
using Identity.Service.Queries;
using Identity.Service.Queries.DTOs;
using MediatR;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Service.Common.Collection;
using System.Security.Claims;

namespace Identity.Api.Controllers
{
    [ApiController]
    [Route("v1/identity")]
    public class IdentityUserController : Controller
    {
        private readonly ILogger<IdentityUserController> _logger;
        private readonly SignInManager<ApplicationUser> _signInManager;
        private readonly IMediator _mediator;
        private readonly IUserIdentityQueryService _userIdentityQuery;

        public IdentityUserController(ILogger<IdentityUserController> logger, SignInManager<ApplicationUser> signInManager, IMediator mediator, IUserIdentityQueryService userIdentityQuery)
        {
            _logger = logger;
            _signInManager = signInManager;
            _mediator = mediator;
            _userIdentityQuery = userIdentityQuery;
        }

        [HttpPost]
        public async Task<IActionResult> Create(UserCreateCommand command)
        {
            if (ModelState.IsValid)
            {
                var result = await _mediator.Send(command);

                if (!result.Succeeded)
                {
                    return BadRequest(result.Errors);
                }
                return Ok(result);
            }
            return BadRequest();
        }

        [HttpPost("authentication")]
        public async Task<IActionResult> Authentication(UserLoginCommand command)
        {            
            if (ModelState.IsValid)
            {
                var result = await _mediator.Send(command);
                return Ok(result);
            }
            return BadRequest();
        }

        [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
        [HttpGet("getallusers")]
        public async Task<DataCollection<ApplicationUserDto>> GetAllUsers()
        {
            var id = User.Claims.Single(x => x.Type.Equals(ClaimTypes.NameIdentifier)).Value;
            string IdRole = User.Claims.Single(x => x.Type.Equals("IdRole")).Value;
            
            var data = await _userIdentityQuery.GetAllUsersAsync();
            return data;
        }
    }
}