using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOP_Patterns.Services.Observers.Interfaces;

namespace OOP_Patterns.Services.Observers.Subjects.Interfaces
{
    public interface ISubject
    {
        public void RegisterObserver(IObserver observer);

        public void RemoveObserver(IObserver observer);

        public void NotifyObservers();
    }
}
