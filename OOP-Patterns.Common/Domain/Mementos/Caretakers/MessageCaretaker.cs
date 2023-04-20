using OOP_Patterns.Common.Domain.Mementos.Caretakers.Interfaces;
using OOP_Patterns.Common.Domain.Mementos.Interfaces;
using OOP_Patterns.Common.Domain.Mementos.Originators.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Patterns.Common.Domain.Mementos.Caretakers
{
    public class MessageCaretaker : IMessageCaretaker
    {
        private List<IMessageMemento> _mementos = new List<IMessageMemento>();

        private readonly IMessageOriginator _messageOriginator;

        public MessageCaretaker(IMessageOriginator messageOriginator)
        {
            _messageOriginator = messageOriginator;
        }

        public void BackupState(string state)
        {
            _mementos.Add(_messageOriginator.SaveState(state) as IMessageMemento);
        }

        public void UndoState()
        {
            if (!_mementos.Any())
            {
                return;
            }

            var memento = _mementos.Last();
            _mementos.Remove(memento);

            try
            {
                _messageOriginator.RestoreState(memento);
            }
            catch (Exception)
            {
                UndoState();
            }
        }

        public List<string> GetHistory()
        {
            var history = _mementos.Select(x => x.Value);

            if (!history.Any())
            {
                return new List<string>();
            }

            return history.ToList();
        }
    }
}
