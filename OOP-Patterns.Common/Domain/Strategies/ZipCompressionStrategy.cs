using OOP_Patterns.Common.Domain.Strategies.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Patterns.Common.Domain.Strategies
{
    public class ZipCompressionStrategy : ICompressionStrategy
    {
        public Task<string> CompressFile(string fileName)
        {
            return Task.FromResult($"{fileName} file was compressed by using Zip compression");
        }

        public Task<string> DeompressFile(string fileName)
        {
            return Task.FromResult($"{fileName} file was decompressed by using Zip compression");
        }
    }
}
