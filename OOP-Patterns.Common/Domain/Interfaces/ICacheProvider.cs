using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Patterns.Common.Domain.Interfaces
{
    public interface ICacheProvider
    {
        ValueTask<T> GetOrGenerateAsync<T>(string key, Func<Task<T>> cacheFunc);

        T Get<T>(string key);

        void Set<T>(string key, T data);

        string GenerateCachingKey(params object[] args);
    }
}
