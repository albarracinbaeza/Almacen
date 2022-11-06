using MediatR;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using User.Persistence.Database;
using User.Service.EventHandlers.Commands;
using static User.Service.EventHandlers.Responses.MenuCreateCommandResponse;

namespace User.Service.EventHandlers
{
    public class MenuCreateEventHandler : IRequestHandler<MenuCreateCommand, Response>
    {
        public readonly ApplicationDbContext _context;
        public readonly ILogger<MenuCreateEventHandler> _logger;

        public MenuCreateEventHandler(ILogger<MenuCreateEventHandler> logger, ApplicationDbContext context)
        {
            _context = context;
            _logger = logger;
        }

        public async Task<Response> Handle(MenuCreateCommand command, CancellationToken cancellationToken)
        {
            //Client client = new Client { Name = command.Name };
            //await _context.AddAsync(client);

            //await _context.SaveChangesAsync();

            //command.ClientId = client.ClientId;
            //command.Name = client.Name;

            return new Response(command);
        }
    }
}
