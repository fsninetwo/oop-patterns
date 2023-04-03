using OOP_Patterns.Common.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Patterns.Services.IServices
{
    public interface IDocumentService
    {
        public Task<string> UploadDocumentAsync(string message, DocumentEnum documentType);

        public Task<string> DownloadDocumentAsync(string message, DocumentEnum documentType);
    }
}
