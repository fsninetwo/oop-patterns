using OOP_Patterns.Common.Domain.Enums;
using OOP_Patterns.Services.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Patterns.Services.Providers
{
    public interface IUploadProvider
    {
        IBaseUploadService GetRequiredService(UploadEnum uploadType);
    }
}
