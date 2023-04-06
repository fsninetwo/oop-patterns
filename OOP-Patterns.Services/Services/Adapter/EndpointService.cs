using OOP_Patterns.Services.Adapters.Interfaces;
using OOP_Patterns.Services.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Patterns.Services.Services.Adapter
{
    public class EndpointService : IEndpointService
    {
        private readonly IEndpointAdapter _endpointAdapter;

        public EndpointService(IEndpointAdapter endpointAdapter) 
        {
            _endpointAdapter = endpointAdapter;
        }

        public async Task<string> SendAsync(string message)
        {
            return await _endpointAdapter.SendMessageAsync(message);
        }
    }
}
