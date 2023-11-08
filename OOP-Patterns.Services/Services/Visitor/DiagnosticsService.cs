using OOP_Patterns.Common.Domain.Visitors;
using OOP_Patterns.Common.Domain.Visitors.Components;
using OOP_Patterns.Common.Domain.Visitors.Components.Interfaces;
using OOP_Patterns.Common.Domain.Visitors.Interfaces;
using OOP_Patterns.Services.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Patterns.Services.Services.Visitor
{
    public class DiagnosticsService : IDiagnosticsService
    {
        private readonly IEnumerable<IMicroserviceComponent> _components = new List<IMicroserviceComponent>()
        {
            new RepositoryComponent(),
            new ServiceComponent()
        };

        public async Task<string> CheckComponentsStatusAsync()
        {
            IMicroserviceVisitor visitor = new StatusVisitor();

            var statusMessage = "";

            foreach(var component in _components)
            {
                statusMessage += await component.AcceptAsync(visitor);
            }

            return statusMessage;
        }

        public async Task<string> DiagnoseComponentsAsync()
        {
            IMicroserviceVisitor visitor = new DiagnosticVisitor();

            var statusMessage = "";

            foreach(var component in _components)
            {
                statusMessage += await component.AcceptAsync(visitor);
            }

            return statusMessage;
        }
    }
}
