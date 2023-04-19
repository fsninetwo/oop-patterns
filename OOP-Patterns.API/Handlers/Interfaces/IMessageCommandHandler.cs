using OOP_Patterns.API.Commands;
using OOP_Patterns.Common.Domain.Interfaces;

namespace OOP_Patterns.API.Handlers.Interfaces
{
    public interface IMessageCommandHandler : ICommandHandler<MessageCommand, string>
    {
    }
}
