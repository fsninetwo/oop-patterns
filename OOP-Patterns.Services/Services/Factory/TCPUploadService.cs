using OOP_Patterns.Services.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Patterns.Services.Services.Factory
{
    public class TCPUploadService : BaseUploadService
    {
        public override Task<string> DownloadItemAsync(string message)
        {
            return Task.FromResult(message);
        }

        public override Task<string> UploadItemAsync(string message)
        {
            return Task.FromResult(message);
        }
    }
}
