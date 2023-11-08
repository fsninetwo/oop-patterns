using OOP_Patterns.Common.Domain.Models.StateModels;
using OOP_Patterns.Data.Models.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Patterns.Services.IServices
{
    public interface IPaymentService
    {
        Task<string> CreateInvoiceAsync(InvoiceStateModelDto invoice);

        Task<IEnumerable<InvoiceStateModel>> GetInvoicesAsync();

        Task<string> PayInvoiceAsync(InvoiceStateModelDto invoice);

        Task<string> CancelInvoiceAsync(InvoiceStateModelDto invoice);

        Task<string> RefundInvoiceAsync(InvoiceStateModelDto invoice);

        Task<string> PayInvoiceByNumberAsync(long invoiceNumber);

        Task<string> CancelInvoiceByNumberAsync(long invoiceNumber);

        Task<string> RefundInvoiceByNumberAsync(long invoiceNumber);
    }
}
