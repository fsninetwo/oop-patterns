using Microsoft.AspNetCore.Mvc;
using OOP_Patterns.API.Commands;
using OOP_Patterns.API.Handlers.Interfaces;

namespace OOP_Patterns.API.Controllers
{
    public class CommandController : BaseController
    {
        private readonly IMessageCommandHandler _messageCommand;

        public CommandController(IMessageCommandHandler messageCommand)
        {
            _messageCommand = messageCommand;
        }

        [HttpPost]
        public async Task<IActionResult> SendMessageAsync(string message)
        {
            return Ok(await _messageCommand.Handle(new MessageCommand(message)));
        }
    }
}
