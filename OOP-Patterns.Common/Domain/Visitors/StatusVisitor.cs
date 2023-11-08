using OOP_Patterns.Common.Domain.Visitors.Components;
using OOP_Patterns.Common.Domain.Visitors.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Patterns.Common.Domain.Visitors
{
    public class StatusVisitor : IMicroserviceVisitor
    {
        public Task<string> Visit(ServiceComponent component)
        {
            return Task.FromResult("Running service status");
        }

        public Task<string> Visit(RepositoryComponent component)
        {
            return Task.FromResult("Running repository status");
        }
    }
}
