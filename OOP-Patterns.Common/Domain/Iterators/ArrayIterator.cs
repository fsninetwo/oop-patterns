using OOP_Patterns.Common.Domain.Aggregates;
using OOP_Patterns.Common.Domain.Iterators.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Patterns.Common.Domain.Iterators
{
    public class ArrayIterator<T> : IIterator<T>
    {
        private ArrayAggregate<T> _aggregate;
        private int Index = 0;

        public bool IsCompleted => Index >= _aggregate.Count;

        public ArrayIterator(ArrayAggregate<T> aggregate)
        {
            _aggregate = aggregate;
        }

        public bool MoveNext()
        {
            Index += 1;
            if (!IsCompleted)
            {
                return true;
            }
            
            return false;
        }

        public T Current()
        {
            if (IsCompleted)
            {
                throw new InvalidOperationException();
            }
                
            return _aggregate.GetItem(Index);
        }

        public void Reset()
        {
            Index = 0;
        }
    }
}
