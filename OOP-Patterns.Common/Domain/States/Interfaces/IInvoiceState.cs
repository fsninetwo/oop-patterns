
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
        Task Pay(InvoiceStateModel invoice);

        Task Cancel(InvoiceStateModel invoice);

        Task Refund(InvoiceStateModel invoice);
    }
}
