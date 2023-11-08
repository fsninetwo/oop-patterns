using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Patterns.Common.Domain.Strategies.Interfaces
{
    public interface ICompressionStrategy
    {
        public Task<string> CompressFile(string fileName);

        public Task<string> DeompressFile(string fileName);
    }
}
