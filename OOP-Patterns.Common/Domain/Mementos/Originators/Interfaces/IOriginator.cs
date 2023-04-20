using OOP_Patterns.Common.Domain.Mementos.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Patterns.Common.Domain.Mementos.Originators.Interfaces
{
    public interface IOriginator<T>
    {
        T State { get; }

        public IMemento<T> SaveState(string state);

        public void RestoreState(IMemento<T> memento);
    }
}
