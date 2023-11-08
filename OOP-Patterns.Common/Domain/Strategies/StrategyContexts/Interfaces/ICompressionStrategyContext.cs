using OOP_Patterns.Common.Domain.Strategies.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Patterns.Common.Domain.Strategies.StrategyContexts.Interfaces
{
    public interface ICompressionStrategyContext
    {
        void SetStrategy(ICompressionStrategy compressionStrategy);

        Task<string> CreateArchive(string fileName);

        Task<string> UnpackArchive(string fileName);
    }
}
