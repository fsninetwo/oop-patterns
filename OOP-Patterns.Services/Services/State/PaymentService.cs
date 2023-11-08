using OOP_Patterns.Common.Domain.Models.StateModels;
using OOP_Patterns.Data.Models.DTO;
using OOP_Patterns.Services.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Patterns.Services.Services.State
{
    public class PaymentService : IPaymentService
    {
        private readonly Dictionary<long, InvoiceStateModel> _invoiceDictionary = new Dictionary<long, InvoiceStateModel>();

        public async Task<string> PayInvoiceAsync(InvoiceStateModelDto invoice)
        {
            var invoiceModel = AddInvoiceToDictionary(invoice);

            return await invoiceModel.PayInvoiceAsync();
        }

        public async Task<string> CancelInvoiceAsync(InvoiceStateModelDto invoice)
        {
            var invoiceModel = AddInvoiceToDictionary(invoice);

            return await invoiceModel.CanceInvoiceAsync();
        }

        public async Task<string> RefundInvoiceAsync(InvoiceStateModelDto invoice)
        {
            var invoiceModel = AddInvoiceToDictionary(invoice);

            return await invoiceModel.RefundInvoiceAsync();
        }

        public async Task<string> PayInvoiceByNumberAsync(long invoiceNumber)
        {
            var invoice = GetInvoiceFromDictionary(invoiceNumber);

            return await invoice.PayInvoiceAsync();
        }

        public async Task<string> RefundInvoiceByNumberAsync(long invoiceNumber)
        {
            var invoice = GetInvoiceFromDictionary(invoiceNumber);

            return await invoice.RefundInvoiceAsync();
        }

        public async Task<string> CancelInvoiceByNumberAsync(long invoiceNumber)
        {
            var invoice = GetInvoiceFromDictionary(invoiceNumber);

            return await invoice.CanceInvoiceAsync();
        }

        public Task<string> CreateInvoiceAsync(InvoiceStateModelDto invoice)
        {
            AddInvoiceToDictionary(invoice);

            return Task.FromResult("Invoice is created");
        }

        public async Task<IEnumerable<InvoiceStateModel>> GetInvoicesAsync()
        {
            return await Task.FromResult(_invoiceDictionary.Values);
        }

        private InvoiceStateModel AddInvoiceToDictionary(InvoiceStateModelDto invoice)
        {
            if(invoice is null)
            {
                throw new ArgumentNullException("invoice is null");
            }

            if(_invoiceDictionary.TryGetValue(invoice.Number, out var _))
            {
                throw new ArgumentNullException("invoice alreay exists");
            }

            var invoiceModel = new InvoiceStateModel
            {
                Number = invoice.Number,
                Amount = invoice.Amount,
                Description = invoice.Description
            };

            _invoiceDictionary.Add(invoice.Number, invoiceModel);

            return invoiceModel;
        }

        private InvoiceStateModel GetInvoiceFromDictionary(long invoiceNumber)
        {
            if(!_invoiceDictionary.TryGetValue(invoiceNumber, out var _))
            {
                throw new ArgumentNullException($"invoice by number {invoiceNumber} does not exist");
            }

            return _invoiceDictionary[invoiceNumber];
        }
    }
}
