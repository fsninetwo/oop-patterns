using Microsoft.AspNetCore.Mvc;
using OOP_Patterns.Services.IServices;

namespace OOP_Patterns.API.Controllers
{
    public class IteratorController : BaseController
    {
        private readonly IIteratorService _iteratorService;

        public IteratorController(IIteratorService iteratorService)
        {
            _iteratorService = iteratorService;
        }

        [HttpGet]
        public async Task<IActionResult> GetItems()
        {
            return Ok(await _iteratorService.GetItemsAsync());
        }

        [HttpGet]
        public async Task<IActionResult> GetItem(string item)
        {
            return Ok(await _iteratorService.GetItemAsync(item));
        }
    }
}
