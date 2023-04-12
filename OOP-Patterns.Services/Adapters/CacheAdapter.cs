using OOP_Patterns.Common.Domain.Enums;
using OOP_Patterns.Common.Domain.Extensions;
using OOP_Patterns.Common.Domain.Interfaces;
using OOP_Patterns.Services.Adapters.Interfaces;
using OOP_Patterns.Services.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Patterns.Services.Adapters
{
    public class CacheAdapter : ICacheAdapter
    {
        private readonly IUploadService _uploadService;
        private readonly ICacheProvider _cacheProvider;

        public CacheAdapter(IUploadService uploadService, ICacheProvider cacheProvider)
        {
            _uploadService = uploadService;
            _cacheProvider = cacheProvider;
        }

        public async Task<string> SendMessageAsync(string message)
        {
            var key = _cacheProvider.GenerateCachingKey(typeof(string).GetFullName(), message);

            return await _cacheProvider.GetOrGenerateAsync(key, () =>
                _uploadService.UploadItemAsync(message, UploadEnum.TCP));
        }
    }
}
