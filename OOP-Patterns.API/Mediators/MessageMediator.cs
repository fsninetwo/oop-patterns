using OOP_Patterns.API.Mediators.Interfaces;
using OOP_Patterns.Services.IServices;

namespace OOP_Patterns.API.Mediators
{
    public class MessageMediator : IMessageMediator
    {
         private readonly IMessageService _messageService;

        public MessageMediator(IMessageService messageService)
        {
            _messageService = messageService;
        }

        public async Task<string> HandleAsync(string message)
        {
            return await _messageService.SendMessageAsync(message);
        }
    }
}
