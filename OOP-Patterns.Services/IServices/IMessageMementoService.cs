using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Patterns.Services.IServices
{
    public interface IMessageMementoService
    {
        public Task CreateStateAsync(string message);

        public Task BackupStateAsync(string message);

        public Task UndoStateAsync();

        public Task<List<string>> GetHistoryAsync();
    }
}
