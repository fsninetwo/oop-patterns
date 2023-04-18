using Microsoft.AspNetCore.Mvc;
using OOP_Patterns.Services.IServices;

namespace OOP_Patterns.API.Controllers
{
    public class ChainController : BaseController
    {
        private readonly IMessageHandlerService _messageHandlerService;

        public ChainController(IMessageHandlerService messageHandlerService)
        {
            _messageHandlerService = messageHandlerService;
        }

        [HttpPost]
        public async Task<IActionResult> SendMessage(string message)
        {
            return Ok(await _messageHandlerService.SendMessageAsync(message));
        }
    }
}
