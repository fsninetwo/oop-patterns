using OOP_Patterns.Common.Domain.Models.StateModels;
using OOP_Patterns.Services.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Patterns.Services.Services.State
{
    internal class InvoiceStateService : IInvoiceStateService
    {
        public Task CancelInvoice(InvoiceStateModel invoice)
        {
            throw new NotImplementedException();
        }

        public Task GetInvoiceStatus()
        {
            throw new NotImplementedException();
        }

        public Task PayInvoice(InvoiceStateModel invoice)
        {
            throw new NotImplementedException();
        }

        public Task RefundInvoice(InvoiceStateModel invoice)
        {
            throw new NotImplementedException();
        }
    }
}
