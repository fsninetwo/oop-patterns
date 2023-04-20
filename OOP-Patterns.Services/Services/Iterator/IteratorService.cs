using OOP_Patterns.Common.Domain.Aggregates;
using OOP_Patterns.Services.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Patterns.Services.Services.Iterator
{
    public class IteratorService : IIteratorService
    {
        public async Task<string> GetItemAsync(string item)
        {
            var collection = GetItems();

            var iterator = collection.CreateIterator();
            
            while(iterator.MoveNext())
            {
                if(iterator.Current() == item)
                {
                    return await Task.FromResult(iterator.Current());
                }
            }

            return await Task.FromResult("No result");
        }

        public async Task<IList<string>> GetItemsAsync()
        {
            var collection = GetItems();

            return await Task.FromResult(collection.GetItems());
        }

        private ArrayAggregate<string> GetItems()
        {
            var array = new ArrayAggregate<string>();
            array.Add("First");
            array.Add("Second");
            array.Add("Third");
            array.Add("Fourth");
            array.Add("Fifth");
            array.Add("Sixth");
            array.Add("Seventh");
            array.Add("Eighth");
            array.Add("Nineth");
            array.Add("Tenth");
            return array;
        }
    }
}
