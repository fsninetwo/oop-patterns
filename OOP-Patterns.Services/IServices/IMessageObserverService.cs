using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Patterns.Services.IServices
{
    public interface IMessageObserverService
    {
        public Task<List<string>> GetSubjectsAsync();

        public Task<string> AddSubjectAsync(string message);

        public Task<string> AddSubscriberAsync(string message, string username);

        public Task<string> RemoveSubscriberAsync(string message, string username);

        public Task<string> NotifyObserversAsync(string message);
    }
}
