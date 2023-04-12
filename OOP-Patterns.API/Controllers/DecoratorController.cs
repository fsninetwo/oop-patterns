using Microsoft.AspNetCore.Mvc;
using OOP_Patterns.Services.IServices;

namespace OOP_Patterns.API.Controllers
{
    public class DecoratorController : BaseController
    {
        private readonly ISimpleService _simpleService;

        public DecoratorController(ISimpleService notifierService)
        {
            _simpleService = notifierService;
        }

        [HttpGet]
        public async Task<IActionResult> SendMessage(string message)
        {
            return Ok(await _simpleService.DoSomethingAsync(message));
        }
    }
}
