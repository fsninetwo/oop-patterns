using Microsoft.AspNetCore.Mvc;
using OOP_Patterns.Common.Enums;
using OOP_Patterns.Services.IServices;

namespace OOP_Patterns.API.Controllers
{
    public class FactoryUploadController : BaseController
    {
        private readonly IUploadService _uploadService;

        public FactoryUploadController(IUploadService uploadService) 
        {
            _uploadService = uploadService;
        }

        [HttpGet]
        public async Task<IActionResult> DownloadItem(string message, UploadEnum uploadType)
        {
            return Ok(await _uploadService.DownloadItemAsync(message, uploadType));
        }

        [HttpPost]
        public async Task<IActionResult> UploadItem(string message, UploadEnum uploadType)
        {
            return Ok(await _uploadService.UploadItemAsync(message, uploadType));
        }
    }
}
