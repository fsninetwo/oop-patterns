using Microsoft.Extensions.Logging;
using OOP_Patterns.Services.Observers.Interfaces;
using OOP_Patterns.Services.Observers.Subjects.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Patterns.Services.Observers.Subjects
{
    public class MessageSubject : IMessageSubject
    {
        private List<IObserver> _observers = new List<IObserver>();

        public string Message { get; private set; }

        public MessageSubject(string message) 
        {
            Message = message;
        }

        public void RegisterObserver(IObserver observer)
        {
            _observers.Add(observer);
        }

        public void RemoveObserver(IObserver observer)
        {
            _observers.Remove(observer);
        }

        public void NotifyObservers()
        {
            foreach (IObserver observer in _observers)
            {
                observer.Update(this);
            }
        }
    }
}
