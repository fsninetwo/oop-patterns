using OOP_Patterns.Common.Domain.Iterators.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Patterns.Common.Domain.Aggregates.Interfaces
{
    public interface IAggregate<T>
    {
        IIterator<T> CreateIterator();
    }
}
