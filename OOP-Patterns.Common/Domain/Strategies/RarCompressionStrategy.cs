using OOP_Patterns.Common.Domain.Strategies.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Patterns.Common.Domain.Strategies
{
    public class RarCompressionStrategy : ICompressionStrategy
    {
        public Task<string> CompressFile(string fileNmae)
        {
            throw new NotImplementedException();
        }

        public Task<string> DeompressFile(string fileNmae)
        {
            throw new NotImplementedException();
        }
    }
}
