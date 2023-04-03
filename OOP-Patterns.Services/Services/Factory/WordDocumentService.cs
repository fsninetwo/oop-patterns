using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Patterns.Services.Services.Factory
{
    public class WordDocumentService : BaseDocumentService
    {
        public override Task<string> DownloadDocumentAsync(string message)
        {
            return Task.FromResult($"Downloaded Word File: {message}");
        }
        public override Task<string> UploadDocumentAsync(string message)
        {
            return Task.FromResult($"Uploaded Word File: {message}");
        }
    }
}
