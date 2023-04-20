using OOP_Patterns.Common.Domain.Aggregates.Interfaces;
using OOP_Patterns.Common.Domain.Iterators;
using OOP_Patterns.Common.Domain.Iterators.Interfaces;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Patterns.Common.Domain.Aggregates
{
    public class ArrayAggregate<T> : IAggregate<T>
    {
        private List<T> items = new();

        public IIterator<T> CreateIterator()
        {
            return new ArrayIterator<T>(this);
        }

        public int Count
        {
            get { return items.Count; }
        }

        public void Add(T item)
        {
            items.Add(item);
        }

        public T GetItem(int item)
        {
            return items[item];
        }

        public List<T> GetItems()
        {
            return items;
        }
    }
}
