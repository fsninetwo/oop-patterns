using Microsoft.AspNetCore.Mvc;
using OOP_Patterns.Common.Enums;
using OOP_Patterns.Services.IServices;
using OOP_Patterns.Services.Providers;

namespace OOP_Patterns.API.Controllers
{
    public class FactoryUploadController : BaseController
    {
        private readonly IUploadProvider _uploadProvider;

        public FactoryUploadController(IUploadProvider uploadProvider) 
        {
            _uploadProvider = uploadProvider;
        }

        [HttpGet]
        public async Task<IActionResult> DownloadItem(string message, UploadEnum uploadType)
        {
            var uploadService = _uploadProvider.GetRequiredService(uploadType);

            return Ok(await uploadService.DownloadItemAsync(message));
        }

        [HttpPost]
        public async Task<IActionResult> UploadItem(string message, UploadEnum uploadType)
        {
            var uploadService = _uploadProvider.GetRequiredService(uploadType);

            return Ok(await uploadService.UploadItemAsync(message));
        }
    }
}
