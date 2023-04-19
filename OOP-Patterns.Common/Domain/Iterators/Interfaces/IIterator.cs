using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Patterns.Common.Domain.Iterators.Interfaces
{
    public interface IIterator<T>
    {
        bool IsCompleted { get; }

        bool MoveNext();

        T Current();

        void Reset();
    }
}
