using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Patterns.Common.Domain.Interfaces
{
    public interface ICommandHandler<TCommand> where TCommand : ICommand
    {
        public Task Handle(TCommand command);
    }

    public interface ICommandHandler<TCommand, TResult> where TCommand : ICommand
    {
        public Task<TResult> Handle(TCommand command);
    }
}
