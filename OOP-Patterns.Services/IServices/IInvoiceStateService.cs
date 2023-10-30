using OOP_Patterns.Common.Domain.Models.StateModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Patterns.Services.IServices
{
    public interface IInvoiceStateService
    {
        Task PayInvoice(InvoiceStateModel invoice);

        Task CancelInvoice(InvoiceStateModel invoice);

        Task RefundInvoice(InvoiceStateModel invoice);

        Task GetInvoiceStatus();
    }
}
