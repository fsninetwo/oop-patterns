using OOP_Patterns.Common.Domain.Visitors.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Patterns.Common.Domain.Visitors.Components.Interfaces
{
    public interface IMicroserviceComponent : IComponent
    {
        Task<string> AcceptAsync(IMicroserviceVisitor computerVisitor);
    }
}
