using Microsoft.AspNetCore.Mvc;
using OOP_Patterns.Common.Domain.Enums;

namespace OOP_Patterns.API.Controllers
{
    public class AbstractFactoryController : Controller
    {
        [HttpGet]
        public async Task<IActionResult> UploadDocument(string message, UploadEnum uploadType)
        {
            return Ok();
        }

        [HttpPost]
        public async Task<IActionResult> DownloadDocument(string message, UploadEnum uploadType)
        {
            return Ok();
        }
    }
}
