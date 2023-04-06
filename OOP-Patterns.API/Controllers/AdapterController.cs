using Microsoft.AspNetCore.Mvc;
using OOP_Patterns.Services.IServices;

namespace OOP_Patterns.API.Controllers
{
    public class AdapterController : BaseController
    {
        private readonly IEndpointService _endpointService;

        public AdapterController(IEndpointService endpointService) 
        { 
            _endpointService = endpointService;
        }

        [HttpPost]
        public async Task<IActionResult> Send(string message)
        {
            return Ok(await _endpointService.SendAsync(message));
        }
    }
}
