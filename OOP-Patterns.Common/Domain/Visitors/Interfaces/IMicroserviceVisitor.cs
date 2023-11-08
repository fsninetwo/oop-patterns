using OOP_Patterns.Common.Domain.Visitors.Components;
using OOP_Patterns.Common.Domain.Visitors.Components.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Patterns.Common.Domain.Visitors.Interfaces
{
    public interface IMicroserviceVisitor : IVisitor
    {
        Task<string> Visit(ServiceComponent component);

        Task<string> Visit(RepositoryComponent component);
    }
}
