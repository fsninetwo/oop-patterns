using Microsoft.AspNetCore.Mvc;
using OOP_Patterns.Services.IServices;

namespace OOP_Patterns.API.Controllers
{
    public class BridgeController : BaseController
    {
        private readonly IMessageService _messageService;

        public BridgeController(IMessageService messageService)
        {
            _messageService = messageService;
        }

        [HttpPost]
        public async Task<IActionResult> SendMessage(string message)
        {
            return Ok(await _messageService.SendMessageAsync(message));
        }
    }
}
