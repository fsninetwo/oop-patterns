using OOP_Patterns.Services.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Patterns.Services.Services.Factory
{
    public class UDPUploadService : IBaseUploadService
    {
        public Task<string> DownloadItemAsync(string message)
        {
            return Task.FromResult(message);
        }

        public Task<string> UploadItemAsync(string message)
        {
            return Task.FromResult(message);
        }
    }
}
