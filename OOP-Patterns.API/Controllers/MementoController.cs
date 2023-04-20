using Microsoft.AspNetCore.Mvc;
using OOP_Patterns.Common.Domain.Enums;
using OOP_Patterns.Services.IServices;
using OOP_Patterns.Services.Services.Facade;

namespace OOP_Patterns.API.Controllers
{
    public class MementoController : BaseController
    {
        private readonly IMessageMementoService _messageMementoService;

        public MementoController(IMessageMementoService messageMementoService)
        {
            _messageMementoService = messageMementoService;
        }

        [HttpPost]
        public async Task<IActionResult> BackupMessage(string message)
        {
            await _messageMementoService.BackupStateAsync(message);

            return Ok();
        }

        [HttpDelete]
        public async Task<IActionResult> UndoMessage()
        {
            await _messageMementoService.UndoStateAsync();

            return Ok();
        }

        [HttpGet]
        public async Task<IActionResult> GetHistory()
        {
            return Ok(await _messageMementoService.GetHistoryAsync());
        }
    }
}
