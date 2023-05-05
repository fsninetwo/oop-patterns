using OOP_Patterns.Services.Observers.Subjects.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Patterns.Services.Observers.Interfaces
{
    public interface IObserver
    {
        public void Update(ISubject subject);

        public void AddSubscriber(ISubject subject);

        public void RemoveSubscriber(ISubject subject);
    }
}
