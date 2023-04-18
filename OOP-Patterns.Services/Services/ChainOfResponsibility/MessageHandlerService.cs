using OOP_Patterns.Services.Handlers.Interfaces;
using OOP_Patterns.Services.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Patterns.Services.Services.ChainOfResponsibility
{
    public class MessageHandlerService : IMessageHandlerService
    {
        IMessageHandler _messageHandler;

        public MessageHandlerService(IMessageHandler messageHandler) 
        { 
            _messageHandler = messageHandler;
        }

        public async Task<string> SendMessageAsync(string message)
        {
            return await _messageHandler.HandleMessageAsync("Upload", message);
        }
    }
}
