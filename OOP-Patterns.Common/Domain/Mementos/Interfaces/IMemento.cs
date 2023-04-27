using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Patterns.Common.Domain.Mementos.Interfaces
{
    public interface IMemento<T>
    {
        T Value { get; }

        DateTime Date { get; }
    }
}
