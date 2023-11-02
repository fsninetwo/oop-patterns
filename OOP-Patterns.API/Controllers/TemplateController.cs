using Microsoft.AspNetCore.Mvc;
using OOP_Patterns.Common.Domain.Enums;
using OOP_Patterns.Services.IServices;

namespace OOP_Patterns.API.Controllers
{
    public class TemplateController : BaseController
    {
        private IFileConverterService _fileConverterService;

        public TemplateController(IFileConverterService fileConverterService) 
        {
            _fileConverterService = fileConverterService;
        }

        [HttpPost]
        public async Task<IActionResult> ConvertFileAsync(string fileName, FileTypeEnum fileTypeEnum)
        {
            return Ok(await _fileConverterService.ConvertFileAsync(fileName, fileTypeEnum));
        }
    }
}
