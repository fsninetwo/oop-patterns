using Microsoft.AspNetCore.Mvc;
using OOP_Patterns.Common.Domain.Enums;
using OOP_Patterns.Services.IServices;

namespace OOP_Patterns.API.Controllers
{
    public class BuilderController : BaseController
    {
        private readonly IReportService _reportService;

        public BuilderController(IReportService reportService) 
        { 
            _reportService = reportService;
        }

        [HttpGet]
        public async Task<IActionResult> GetFullReport(DocumentEnum documentType)
        {
            return Ok(await _reportService.GetFullReportAsync(documentType));
        }

        [HttpGet]
        public async Task<IActionResult> GetShortReport(DocumentEnum documentType)
        {
            return Ok(await _reportService.GetShortReportAsync(documentType));
        }
    }
}
