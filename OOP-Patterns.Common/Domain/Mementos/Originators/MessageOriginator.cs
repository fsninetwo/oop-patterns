using OOP_Patterns.Common.Domain.Mementos.Interfaces;
using OOP_Patterns.Common.Domain.Mementos.Originators.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Patterns.Common.Domain.Mementos.Originators
{
    public class MessageOriginator : IMessageOriginator
    {
        public string State { get; private set; }

        public MessageOriginator(string state)
        {
            State = state;
        }

        public IMemento<string> SaveState(string state)
        {
            return new MessageMemento(State);
        }

        public void RestoreState(IMemento<string> memento)
        {
            if (memento is not MessageMemento)
            {
                throw new ArgumentException("Unknown memento object ", memento.ToString());
            }

            State = memento.Value;
        }
    }
}
