using OOP_Patterns.Common.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Patterns.Services.IServices
{
    public interface IUploadService
    {
        Task DownloadItem(string message, UploadEnum uploadType);

        Task UploadItem(string message, UploadEnum uploadType);
    }
}
