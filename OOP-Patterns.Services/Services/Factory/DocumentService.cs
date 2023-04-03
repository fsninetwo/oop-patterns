using OOP_Patterns.Common.Domain.Enums;
using OOP_Patterns.Services.IServices;
using OOP_Patterns.Services.Services.AbstractFactory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Patterns.Services.Services.Factory
{
    public class DocumentService : IDocumentService
    {
        public async Task<string> DownloadDocumentAsync(string message, DocumentEnum documentType)
        {
            var documentService = GetRequiredService(documentType);

            return await documentService.DownloadDocumentAsync(message);
        }

        public async Task<string> UploadDocumentAsync(string message, DocumentEnum documentType)
        {
            var documentService = GetRequiredService(documentType);

            return await documentService.UploadDocumentAsync(message);
        }

        private BaseDocumentService GetRequiredService(DocumentEnum documentType)
        {
            return documentType switch
            {
                DocumentEnum.Excel => new ExcelDocumentService(),
                DocumentEnum.Word => new WordDocumentService(),
                DocumentEnum.PowerPoint => new PowerPointDocumentService(),
                _ => throw new NotImplementedException("Required service is not implemented")
            };
        }
    }
}
