using OOP_Patterns.Common.Domain.Enums;
using OOP_Patterns.Services.IServices;
using OOP_Patterns.Services.Providers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Patterns.Services.Services.AbstractFactory
{
    public class UploadService : IUploadService
    {
        private readonly IUploadProvider _uploadProvider;

        public UploadService(IUploadProvider uploadProvider)
        {
            _uploadProvider = uploadProvider;
        }

        public async Task<string> UploadItemAsync(string message, UploadEnum uploadType)
        {
            var uploadService = _uploadProvider.GetRequiredService(uploadType);

            return await uploadService.UploadItemAsync(message);
        }

        public async Task<string> DownloadItemAsync(string message, UploadEnum uploadType)
        {
            var uploadService = _uploadProvider.GetRequiredService(uploadType);

            return await uploadService.DownloadItemAsync(message);
        }
    }
}
