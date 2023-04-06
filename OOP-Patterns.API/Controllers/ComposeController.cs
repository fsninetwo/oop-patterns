using Microsoft.AspNetCore.Mvc;
using OOP_Patterns.Services.IServices;

namespace OOP_Patterns.API.Controllers
{
    public class ComposeController : BaseController
    {
        private readonly IFileSystemService _fileSystemService;

        public ComposeController(IFileSystemService fileSystemService)
        {
            _fileSystemService = fileSystemService;
        }

        [HttpGet]
        public IActionResult GetFolderWithFiles()
        {
            return Ok(_fileSystemService.GetFolderWithFiles());
        }

        [HttpGet]
        public IActionResult GetFolderWithSubFolders()
        {
            return Ok(_fileSystemService.GetFolderWithSubFolders());
        }
    }
}
