using OOP_Patterns.Common.Domain.Mementos.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Patterns.Common.Domain.Mementos
{
    public class MessageMemento : IMessageMemento
    {
        public string Value { get; private set; }

        public DateTime Date { get; private set; }

        public MessageMemento(string value) 
        {
            Value = value;
            Date = DateTime.Now;
        }
    }
}
