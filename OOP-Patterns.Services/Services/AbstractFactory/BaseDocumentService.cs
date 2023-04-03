using OOP_Patterns.Common.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Patterns.Services.Services.AbstractFactory
{
    public abstract class BaseDocumentService
    {
        public abstract Task<string> UploadDocumentAsync(string message);

        public abstract Task<string> DownloadDocumentAsync(string message);
    }
}
