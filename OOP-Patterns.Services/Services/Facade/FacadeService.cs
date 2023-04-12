using OOP_Patterns.Common.Domain.Enums;
using OOP_Patterns.Services.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Patterns.Services.Services.Facade
{
    public class FacadeService : IFacadeService
    {
        private readonly IDocumentService _documentService;
        private readonly IMessageService _messageService;

        public FacadeService(
            IDocumentService documentService, 
            IMessageService notifierService)
        {
            _documentService = documentService;
            _messageService = notifierService;
        }

        public async Task<string> UploadDocumentAsync(string message, DocumentEnum documentType)
        {
            var response = await _documentService.UploadDocumentAsync(message, documentType);

            return await _messageService.SendMessageAsync(response);
        }
    }
}
