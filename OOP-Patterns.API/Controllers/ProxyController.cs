using Microsoft.AspNetCore.Mvc;
using OOP_Patterns.Services.IServices;

namespace OOP_Patterns.API.Controllers
{
    public class ProxyController : BaseController
    {
        private readonly IMessageProxyService _messageProxyService;

        public ProxyController(IMessageProxyService messageProxyService)
        {
            _messageProxyService = messageProxyService;
        }

        [HttpPost]
        public async Task<IActionResult> Send(string message)
        {
            return Ok(await _messageProxyService.SendMessageAsync(message));
        }
    }
}
