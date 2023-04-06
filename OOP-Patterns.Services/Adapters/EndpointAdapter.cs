using OOP_Patterns.Common.Domain.Enums;
using OOP_Patterns.Services.Adapters.Interfaces;
using OOP_Patterns.Services.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Patterns.Services.Adapters
{
    public class EndpointAdapter : IEndpointAdapter
    {
        private readonly IUploadService _uploadService;

        public EndpointAdapter(IUploadService uploadService)
        {
            _uploadService = uploadService;
        }

        public async Task<string> SendMessageAsync(string message)
        {
            return await _uploadService.UploadItemAsync(message, UploadEnum.TCP);
        }
    }
}
