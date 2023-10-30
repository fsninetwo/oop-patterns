using OOP_Patterns.Common.Domain.Models.StateModels;
using OOP_Patterns.Common.Domain.States.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Patterns.Common.Domain.States
{
    internal class CancelledInvoiceState : IInvoiceState
    {
        public Task Cancel(InvoiceStateModel invoice)
        {
            return Task.CompletedTask;
        }

        public Task Pay(InvoiceStateModel invoice)
        {
            return Task.CompletedTask;
        }

        public Task Refund(InvoiceStateModel invoice)
        {
            return Task.CompletedTask;
        }
    }
}
