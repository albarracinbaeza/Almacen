using MediatR;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Service.Common.Collection;

using System.Security.Claims;
using User.Service.EventHandlers.Commands;
using User.Service.Queries;
using User.Service.Queries.DTOs;

namespace User.Api.Controllers
{
    [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
    [ApiController]
    [Route("v1/menus")]
    public class MenuController : Controller
    {
        private readonly ILogger<MenuController> _logger;
        private readonly IMenuQueryService _menuQueryService;
        private readonly IMediator _mediator;
        public MenuController(ILogger<MenuController> logger, IMenuQueryService menuQueryService, IMediator mediator)
        {
            _logger = logger;
            _menuQueryService = menuQueryService;
            _mediator = mediator;
        }
        //menus
        [HttpGet]
        public async Task<DataCollection<MenuDto>> GetAll()
        {
            var id = User.Claims.Single(x => x.Type.Equals(ClaimTypes.NameIdentifier)).Value;
            string IdRole = User.Claims.Single(x => x.Type.Equals("IdRole")).Value;
            var data = await _menuQueryService.GetAllMenuRolAsync(IdRole);
            return data;
        }
    }
}
