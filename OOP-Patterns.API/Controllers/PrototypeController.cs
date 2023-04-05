using Microsoft.AspNetCore.Mvc;
using OOP_Patterns.Common.Domain.Enums;
using OOP_Patterns.Services.IServices;

namespace OOP_Patterns.API.Controllers
{
    public class PrototypeController : BaseController
    {
        private readonly IReportService _reportService;

        public PrototypeController(IReportService reportService) 
        { 
            _reportService = reportService;
        }

        [HttpGet]
        public async Task<IActionResult> GetDeepCopy(DocumentEnum documentType)
        {
            return Ok(await _reportService.GetDeepCopyReportAsync(documentType));
        }

        [HttpGet]
        public async Task<IActionResult> GetShallowCopy(DocumentEnum documentType)
        {
            return Ok(await _reportService.GetShallowCopyReportAsync(documentType));
        }
    }
}
