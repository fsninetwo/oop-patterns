using OOP_Patterns.Common.Domain.Enums;
using OOP_Patterns.Services.IServices;
using OOP_Patterns.Services.Providers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Patterns.Services.Services.Bridge
{
    public class MessageService : IMessageService
    {
        private readonly IUploadProvider _uploadProvider;
        private readonly INotifierService _notifierService;

        public MessageService(IUploadProvider uploadProvider, INotifierService notifierService)
        {
            _uploadProvider = uploadProvider;
            _notifierService = notifierService;
        }

        public async Task<string> SendMessageAsync(string message)
        {
            var uploadService = _uploadProvider.GetRequiredService(UploadEnum.TCP);

            _notifierService.ChangeUploadService(uploadService);

            return await _notifierService.Notify(message);
        }
    }
}
