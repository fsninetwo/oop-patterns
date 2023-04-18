using OOP_Patterns.Services.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Patterns.Services.Handlers
{
    public class UploadMessageHandler : BaseMessageHandler
    {
        private readonly IMessageService messageService;

        public UploadMessageHandler(IMessageService messageService)
        {
            this.messageService = messageService;
        }

        public override async Task<string> HandleMessageAsync(string request, string message)
        {
            if (request == "Upload")
            {
                return await messageService.SendMessageAsync(message);
            }

            return await base.HandleMessageAsync(request, message);
        }
    }
}
