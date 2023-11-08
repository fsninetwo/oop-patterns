
using OOP_Patterns.Common.Domain.Models.StateModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Patterns.Common.Domain.States.Interfaces
{
    public interface IInvoiceState : IState
    {
        Task<string> Pay(InvoiceStateModel invoice);

        Task<string> Cancel(InvoiceStateModel invoice);

        Task<string> Refund(InvoiceStateModel invoice);
    }
}
