using OOP_Patterns.Common.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Patterns.Services.Factories.Interfaces
{
    public interface IUploadFactory<TService>
    {
        TService GetRequiredService(UploadEnum uploadType);
    }
}
