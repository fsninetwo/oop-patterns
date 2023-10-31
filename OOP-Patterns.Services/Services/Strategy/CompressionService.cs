using OOP_Patterns.Common.Domain.Enums;
using OOP_Patterns.Common.Domain.Strategies;
using OOP_Patterns.Common.Domain.Strategies.StrategyContexts;
using OOP_Patterns.Common.Domain.Strategies.StrategyContexts.Interfaces;
using OOP_Patterns.Services.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Patterns.Services.Services.Strategy
{
    public class CompressionService : ICompressionService
    {
        private ICompressionStrategyContext _compressionStrategyContext;

        public CompressionService(ICompressionStrategyContext compressionStrategyContext) 
        {
            _compressionStrategyContext = compressionStrategyContext;
        }

        public Task<string> CreateArchiveAsync(string fileName, CompressionEnum compression)
        {
            SetStrategyContext(compression);
            return _compressionStrategyContext.CreateArchive(fileName);
        }

        public Task<string> UnpackArchiveAsync(string fileName, CompressionEnum compression)
        {
            SetStrategyContext(compression);
            return _compressionStrategyContext.UnpackArchive(fileName);
        }

        private void SetStrategyContext(CompressionEnum compression)
        {
            switch(compression) {
                case CompressionEnum.Zip: 
                    _compressionStrategyContext.SetStrategy(new ZipCompressionStrategy());
                    break;
                case CompressionEnum.Rar:
                    _compressionStrategyContext.SetStrategy(new RarCompressionStrategy());
                    break;
            };
        }
    }
}
