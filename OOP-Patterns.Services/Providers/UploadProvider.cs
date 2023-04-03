using OOP_Patterns.Common.Domain.Enums;
using OOP_Patterns.Services.IServices;
using OOP_Patterns.Services.Services;
using OOP_Patterns.Services.Services.Factory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Patterns.Services.Providers
{
    public class UploadProvider : IUploadProvider
    {
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
