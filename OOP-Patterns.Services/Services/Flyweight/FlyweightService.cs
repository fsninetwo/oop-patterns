using OOP_Patterns.Services.Adapters;
using OOP_Patterns.Services.Adapters.Interfaces;
using OOP_Patterns.Services.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Patterns.Services.Services.Flyweight
{
    public class FlyweightService : IFlyweightService
    {
        private readonly ICacheAdapter _cacheAdapter;

        public FlyweightService(ICacheAdapter cacheAdapter)
        {
            _cacheAdapter = cacheAdapter;
        }

        public async Task<string> SendAsync(string message)
        {
            return await _cacheAdapter.SendMessageAsync(message);
        }
    }
}
