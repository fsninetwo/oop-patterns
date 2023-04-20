using Microsoft.AspNetCore.Mvc;
using OOP_Patterns.API.Mediators.Interfaces;

namespace OOP_Patterns.API.Controllers
{
    public class MediatorController : Controller
    {
        private readonly IMessageMediator _messageMediator;

        public MediatorController(IMessageMediator messageMediator)
        {
            _messageMediator = messageMediator;
        }

        [HttpPost]
        public async Task<IActionResult> Notify(string message)
        {
            return Ok(await _messageMediator.HandleAsync(message));
        }
    }
}
