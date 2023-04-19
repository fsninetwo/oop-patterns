using OOP_Patterns.API.Commands;
using OOP_Patterns.API.Handlers.Interfaces;
using OOP_Patterns.Services.IServices;

namespace OOP_Patterns.API.Handlers
{
    public class MessageCommandHandler : IMessageCommandHandler
    {
        private readonly IMessageService _messageService;

        public MessageCommandHandler(IMessageService messageService)
        {
            _messageService = messageService;
        }

        public async Task<string> Handle(MessageCommand command)
        {
            return await _messageService.SendMessageAsync(command.Message);
        }
    }
}
