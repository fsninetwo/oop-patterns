using Microsoft.AspNetCore.Mvc;
using OOP_Patterns.Services.IServices;

namespace OOP_Patterns.API.Controllers
{
    public class VisitorController : BaseController
    {
        private readonly IDiagnosticsService _diagnosticsService;

        public VisitorController(IDiagnosticsService diagnosticsService) 
        { 
            _diagnosticsService = diagnosticsService;
        }

        [HttpGet]
        public async Task<IActionResult> DiagnioseComponentAsync()
        {
            return Ok(await _diagnosticsService.DiagnoseComponentsAsync());
        }

        [HttpGet]
        public async Task<IActionResult> CheckComponentStatus()
        {
            return Ok(await _diagnosticsService.CheckComponentsStatusAsync());
        }
    }
}
