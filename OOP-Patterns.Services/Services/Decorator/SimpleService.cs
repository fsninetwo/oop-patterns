using OOP_Patterns.Services.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Patterns.Services.Services.Decorator
{
    public class SimpleService : ISimpleService
    {
        public SimpleService() 
        {

        }

        public Task<string> DoSomethingAsync(string line)
        {
            return Task.FromResult(line);
        }
    }
}
