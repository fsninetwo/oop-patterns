using OOP_Patterns.Services.Handlers.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Patterns.Services.Handlers
{
    public abstract class BaseMessageHandler : IMessageHandler
    {
        protected IMessageHandler _nextHandler;

        public void SetNext(IMessageHandler handler)
        {
            _nextHandler = handler;
        }

        public virtual async Task<string> HandleMessageAsync(string request, string message)
        {
            if (_nextHandler != null)
            {
                return await _nextHandler.HandleMessageAsync(request, message);
            }

            return null;
        }
    }
}
