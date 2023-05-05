using Microsoft.Extensions.Logging;
using OOP_Patterns.Services.Observers.Interfaces;
using OOP_Patterns.Services.Observers.Subjects.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Patterns.Services.Observers
{
    public class Observer : IObserver
    {
        public string Username { get; set; }

        public Observer(string username)
        {
            Username = username;
        }

        public void AddSubscriber(ISubject subject)
        {
            subject.RegisterObserver(this);
        }

        public void RemoveSubscriber(ISubject subject)
        {
            subject.RemoveObserver(this);
        }

        public void Update(ISubject subject)
        {
            return;
        }
    }
}
