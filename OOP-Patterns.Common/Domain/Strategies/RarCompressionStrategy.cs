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
        public Task<string> CompressFile(string fileName)
        {
            return Task.FromResult($"{fileName} file was compressed by using Rar compression");
        }

        public Task<string> DeompressFile(string fileName)
        {
            return Task.FromResult($"{fileName} file was decompressed by using Rar compression");
        }
    }
}
