using OOP_Patterns.Common.Domain.Mementos.Caretakers;
using OOP_Patterns.Common.Domain.Mementos.Caretakers.Interfaces;
using OOP_Patterns.Common.Domain.Mementos.Originators;
using OOP_Patterns.Common.Domain.Mementos.Originators.Interfaces;
using OOP_Patterns.Services.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Patterns.Services.Services.Memento
{
    public class MessageMementoService : IMessageMementoService
    {
        private MessageCaretaker _caretaker;

        public async Task CreateStateAsync(string message)
        {
            CreateState(message);

            await Task.CompletedTask;
        }

        public async Task BackupStateAsync(string message)
        {
            if(_caretaker is null)
            {
                CreateState(message);
            }

            _caretaker.BackupState(message);

            await Task.CompletedTask;
        }

        public async Task<List<string>> GetHistoryAsync()
        {
            if(_caretaker is null)
            {
                throw new NullReferenceException("Caretaker is not defined");
            }

            var history = _caretaker.GetHistory();

            return await Task.FromResult(history);
        }

        public Task UndoStateAsync()
        {
            if(_caretaker is null)
            {
                throw new NullReferenceException("Caretaker is not defined");
            }

            _caretaker.UndoState();

            return Task.CompletedTask;
        }

        private void CreateState(string message)
        {
            var originator = new MessageOriginator(message);
            _caretaker = new MessageCaretaker(originator);
        }
    }
}
