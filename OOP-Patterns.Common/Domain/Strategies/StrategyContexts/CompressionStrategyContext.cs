using OOP_Patterns.Common.Domain.Strategies.Interfaces;
using OOP_Patterns.Common.Domain.Strategies.StrategyContexts.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Patterns.Common.Domain.Strategies.StrategyContexts
{
    public class CompressionStrategyContext : ICompressionStrategyContext
    {
        private ICompressionStrategy _compressionStrategy;

        public CompressionStrategyContext()
        {
        }

        public void SetStrategy(ICompressionStrategy compressionStrategy)
        { 
            _compressionStrategy = compressionStrategy;
        }

        public async Task<string> CreateArchive(string fileName) 
        {
            return await _compressionStrategy.CompressFile(fileName);
        }

        public async Task<string> UnpackArchive(string fileName) 
        {
            return await _compressionStrategy.DeompressFile(fileName);
        }
    }
}
