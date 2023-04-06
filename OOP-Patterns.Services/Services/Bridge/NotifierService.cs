using OOP_Patterns.Common.Domain.Enums;
using OOP_Patterns.Services.IServices;
using OOP_Patterns.Services.Services.AbstractFactory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Patterns.Services.Services.Bridge
{
    public class NotifierService : INotifierService
    {
        public IBaseUploadService _uploadService { get; private set; }

        public NotifierService(IBaseUploadService uploadService) 
        { 
            _uploadService = uploadService;
        }

        public void ChangeUploadService(IBaseUploadService uploadService)
        {
            _uploadService = uploadService;
        }

        public async Task<string> Notify(string message)
        {
            return await _uploadService.UploadItemAsync(message);
        }
    }
}
