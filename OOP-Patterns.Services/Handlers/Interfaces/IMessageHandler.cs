using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Patterns.Services.Handlers.Interfaces
{
    public interface IMessageHandler
    {
        public void SetNext(IMessageHandler handler);

        public Task<string> HandleMessageAsync(string request, string message);
    }
}
