using OOP_Patterns.Common.Domain.Models.StateModels;
using OOP_Patterns.Common.Domain.States.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Patterns.Common.Domain.States
{
    public class RefundedInvoiceState : IInvoiceState
    {
        public Task<string> Cancel(InvoiceStateModel invoice)
        {
            return Task.FromResult($"Invoice {invoice.Number} has aleady refunded cannot be paid");
        }

        public Task<string> Pay(InvoiceStateModel invoice)
        {
            return Task.FromResult($"Invoice {invoice.Number} has aleady refunded and cannot be cancelled");
        }

        public Task<string> Refund(InvoiceStateModel invoice)
        {
            return Task.FromResult($"Invoice {invoice.Number} has been aleady refunded");
        }
    }
}
