using OOP_Patterns.Common.Enums;
using OOP_Patterns.Services.Factories.Interfaces;
using OOP_Patterns.Services.IServices;
using OOP_Patterns.Services.Services.Factory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Patterns.Common.Domain
{
    public class UploadFactoryService : IUploadFactory<BaseUploadService>, IUploadService
    {
        public async Task UploadItem(string message, UploadEnum uploadType)
        {
            var uploadService = GetRequiredService(uploadType);

            await uploadService.UploadItem(message);
        }

        public async Task DownloadItem(string message, UploadEnum uploadType)
        {
            var uploadService = GetRequiredService(uploadType);

            await uploadService.DownloadItem(message);
        }

        public BaseUploadService GetRequiredService(UploadEnum uploadType)
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
