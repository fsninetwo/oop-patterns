using Microsoft.AspNetCore.Mvc;
using OOP_Patterns.Common.Domain.Enums;
using OOP_Patterns.Services.IServices;
using OOP_Patterns.Services.Services.Singleton;

namespace OOP_Patterns.API.Controllers
{
    public class StrategyController : BaseController
    {
        private ICompressionService _compressionServce;

        public StrategyController(ICompressionService compressionServce) 
        {
            _compressionServce = compressionServce;
        }

        [HttpPost]
        public async Task<IActionResult> CreateArchive(string fileName, CompressionEnum compressionEnum)
        {
            return Ok(await _compressionServce.CreateArchiveAsync(fileName, compressionEnum));
        }

        [HttpPost]
        public async Task<IActionResult> UnpackArchive(string fileName, CompressionEnum compressionEnum)
        {
            return Ok(await _compressionServce.UnpackArchiveAsync(fileName, compressionEnum));
        }
    }
}
