using Microsoft.AspNetCore.Mvc;
using OOP_Patterns.Common.Domain.Enums;
using OOP_Patterns.Services.IServices;
using OOP_Patterns.Services.Providers;

namespace OOP_Patterns.API.Controllers
{
    public class FactoryController : BaseController
    {
        private readonly IDocumentService _documentService;

        public FactoryController(IDocumentService documentService)
        {
            _documentService = documentService;
        }

        [HttpGet]
        public async Task<IActionResult> UploadDocument(string message, DocumentEnum uploadType)
        {
            return Ok(await _documentService.UploadDocumentAsync(message, uploadType));
        }

        [HttpPost]
        public async Task<IActionResult> DownloadDocument(string message, DocumentEnum uploadType)
        {
            return Ok(await _documentService.DownloadDocumentAsync(message, uploadType));
        }
    }
}
