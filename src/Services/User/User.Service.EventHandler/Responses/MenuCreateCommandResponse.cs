using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using User.Service.EventHandlers.Commands;

namespace User.Service.EventHandlers.Responses
{
    public class MenuCreateCommandResponse
    {
        public record Response(MenuCreateCommand command);
    }
}
