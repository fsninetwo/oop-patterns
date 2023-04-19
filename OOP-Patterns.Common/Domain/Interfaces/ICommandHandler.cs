using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Patterns.Common.Domain.Interfaces
{
    public interface ICommandHandler<TCommand, T> where TCommand : ICommand
    {
        public Task<T> Handle(TCommand command);
    }
}
