using OOP_Patterns.Common.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Patterns.Services.IServices
{
    public interface INotifierService
    {
        public void ChangeUploadService(IBaseUploadService uploadService);

        public Task<string> Notify(string message);
    }
}
