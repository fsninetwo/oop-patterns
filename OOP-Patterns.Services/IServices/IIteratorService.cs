using OOP_Patterns.Common.Domain.Aggregates;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Patterns.Services.IServices
{
    public interface IIteratorService
    {
        public Task<IList<string>> GetItemsAsync();

        public Task<string> GetItemAsync(string item);
    }
}
