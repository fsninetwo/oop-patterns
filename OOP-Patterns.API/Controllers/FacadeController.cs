using Microsoft.AspNetCore.Mvc;
using OOP_Patterns.Common.Domain.Enums;
using OOP_Patterns.Services.IServices;

namespace OOP_Patterns.API.Controllers
{
    public class FacadeController : BaseController
    {
        private readonly IFacadeService _facadeService;

        public FacadeController(IFacadeService facadeService)
        {
            _facadeService = facadeService;
        }

        [HttpPost]
        public async Task<IActionResult> UploadDocumentAsync(string message, DocumentEnum documentEnum)
        {
            return Ok(await _facadeService.UploadDocumentAsync(message, documentEnum));
        }
    }
}
