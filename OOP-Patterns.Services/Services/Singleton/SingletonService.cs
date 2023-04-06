using OOP_Patterns.Services.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Patterns.Services.Services.Singleton
{
    public class SingletonService : ISingletonService
    {
        public async Task<string> GetSingletonMessageAsync(string message)
        {
            var singleton = Common.Domain.Singletons.Singleton.GetInstance();

            return await Task.FromResult(singleton.GetMessage(message));
        }
    }
}
