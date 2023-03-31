using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Patterns.Services.IServices
{
    public interface IBaseUploadService
    {
        Task<string> DownloadItemAsync(string message);

        Task<string> UploadItemAsync(string message);
    }
}
