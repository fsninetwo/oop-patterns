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
        public override Task DownloadItem(string message)
        {
            throw new NotImplementedException();
        }

        public override Task UploadItem(string message)
        {
            throw new NotImplementedException();
        }
    }
}
