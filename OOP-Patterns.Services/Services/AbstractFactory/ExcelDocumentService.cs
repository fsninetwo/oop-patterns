using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Patterns.Services.Services.AbstractFactory
{
    public class ExcelDocumentService : BaseDocumentService
    {
        public override Task<string> DownloadDocumentAsync(string message)
        {
            return Task.FromResult($"Downloaded Excel File: {message}");
        }

        public override Task<string> UploadDocumentAsync(string message)
        {
            return Task.FromResult($"Uploaded Excel File: {message}");
        }
    }
}
