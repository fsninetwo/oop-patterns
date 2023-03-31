using OOP_Patterns.Services.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Patterns.Services.Services.Factory
{
    public abstract class BaseUploadService : IBaseUploadService
    {
        public abstract Task<string> DownloadItemAsync(string message);

        public abstract Task<string> UploadItemAsync(string message);
    }
}
