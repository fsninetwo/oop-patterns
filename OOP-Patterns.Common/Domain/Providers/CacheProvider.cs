using Microsoft.Extensions.Caching.Memory;
using OOP_Patterns.Common.Domain.Interfaces;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Patterns.Common.Domain.Providers
{
    public class CacheProvider : ICacheProvider
    {
        private const int CacheExpirationinMinutes = 1;

        private readonly IMemoryCache _memoryCache;
        private readonly MemoryCacheEntryOptions _memoryCacheEntryOptions;

        private readonly ConcurrentDictionary<object, SemaphoreSlim> _locks;

        public CacheProvider(IMemoryCache memoryCache)
        {
            _memoryCache = memoryCache;

            _locks = new ConcurrentDictionary<object, SemaphoreSlim>();

            _memoryCacheEntryOptions = new MemoryCacheEntryOptions()
            {
                AbsoluteExpirationRelativeToNow = TimeSpan.FromMinutes(CacheExpirationinMinutes)
            };
        }

        public async ValueTask<T> GetOrGenerateAsync<T>(string key, Func<Task<T>> cacheFunc)
        {
            if (!_memoryCache.TryGetValue(key, out T response))
            {
                var locker = _locks.GetOrAdd(key, _ => new SemaphoreSlim(1, 1));

                await locker.WaitAsync();

                try
                {
                    if (!_memoryCache.TryGetValue(key, out response))
                    {
                        response = await cacheFunc();

                        _memoryCache.Set(key, response, _memoryCacheEntryOptions);
                    }
                }
                finally
                {
                    locker.Release();
                }
            }

            return response;
        }

        public T Get<T>(string key)
        {
            return _memoryCache.Get<T>(key);
        }

        public void Set<T>(string key, T data)
        {
            var locker = _locks.GetOrAdd(key, _ => new SemaphoreSlim(1, 1));

            locker.Wait();

            try
            {
                _memoryCache.Set(key, data, _memoryCacheEntryOptions);
            }
            finally
            {
                locker.Release();
            }
        }

        public string GenerateCachingKey(params object[] args)
        {
            return string.Join("_", args.Select(x => x.ToString()));
        }
    }
}
