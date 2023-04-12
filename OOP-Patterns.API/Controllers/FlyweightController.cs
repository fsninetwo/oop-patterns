using Microsoft.AspNetCore.Mvc;
using OOP_Patterns.Services.IServices;

namespace OOP_Patterns.API.Controllers
{
    public class FlyweightController : BaseController
    {
        public readonly IFlyweightService _flyweightService;

        public FlyweightController(IFlyweightService flyweightService)
        {
            _flyweightService = flyweightService;
        }

        [HttpPost]
        public async Task<IActionResult> SendMessage(string message)
        {
            return Ok(await _flyweightService.SendAsync(message));
        }
    }
}
