using OOP_Patterns.Common.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Patterns.Services.IServices
{
    public interface ICompressionService
    {
        Task<string> CreateArchiveAsync(string fileName, CompressionEnum compression);

        Task<string> UnpackArchiveAsync(string fileName, CompressionEnum compression);
    }
}
