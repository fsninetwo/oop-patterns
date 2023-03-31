using OOP_Patterns.Common.Enums;
using OOP_Patterns.Services.Factories.Interfaces;
using OOP_Patterns.Services.IServices;
using OOP_Patterns.Services.Services.Factory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Patterns.Services.Services
{
    public class UploadService : IUploadFactory<IBaseUploadService>, IUploadService
    {
        public async Task<string> UploadItemAsync(string message, UploadEnum uploadType)
        {
            var uploadService = GetRequiredService(uploadType);

            return await uploadService.UploadItemAsync(message);
        }

        public async Task<string> DownloadItemAsync(string message, UploadEnum uploadType)
        {
            var uploadService = GetRequiredService(uploadType);

            return await uploadService.DownloadItemAsync(message);
        }

        public IBaseUploadService GetRequiredService(UploadEnum uploadType)
        {
            return uploadType switch
            {
                UploadEnum.TCP => new TCPUploadService(),
                UploadEnum.UDP => new UDPUploadService(),
                _ => throw new NotImplementedException("Required service is not implemented"),
            };
        }
    }
}
