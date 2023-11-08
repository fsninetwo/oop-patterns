using Microsoft.AspNetCore.Mvc;
using OOP_Patterns.Common.Domain.Models.StateModels;
using OOP_Patterns.Data.Models.DTO;
using OOP_Patterns.Services.IServices;
using OOP_Patterns.Services.Services.State;

namespace OOP_Patterns.API.Controllers
{
    public class StateController : BaseController
    {
        private readonly IPaymentService _paymentService;

        public StateController(IPaymentService paymentService)
        {
            _paymentService = paymentService;
        }

        [HttpGet]
        public async Task<IActionResult> GetInvoicesAsync()
        {
            return Ok(await _paymentService.GetInvoicesAsync());
        }

        [HttpPost]
        public async Task<IActionResult> CreateInvoice(InvoiceStateModelDto invoice)
        {
            return Ok(await _paymentService.CreateInvoiceAsync(invoice));
        }
        
        [HttpPost]
        public async Task<IActionResult> PayInvoice(InvoiceStateModelDto invoice)
        {
            return Ok(await _paymentService.PayInvoiceAsync(invoice));
        }

        [HttpPost]
        public async Task<IActionResult> CancelInvoice(InvoiceStateModelDto invoice)
        {
            return Ok(await _paymentService.CancelInvoiceAsync(invoice));
        }

        [HttpPost]
        public async Task<IActionResult> RefundInvoice(InvoiceStateModelDto invoice)
        {
            return Ok(await _paymentService.RefundInvoiceAsync(invoice));
        }

        [HttpPut]
        public async Task<IActionResult> PayInvoiceByNumber(long invoiceNumber)
        {
            return Ok(await _paymentService.PayInvoiceByNumberAsync(invoiceNumber));
        }

        [HttpPut]
        public async Task<IActionResult> RefundInvoiceByNumber(long invoiceNumber)
        {
            return Ok(await _paymentService.RefundInvoiceByNumberAsync(invoiceNumber));
        }

        [HttpPut]
        public async Task<IActionResult> CancelInvoiceByNumber(long invoiceNumber)
        {
            return Ok(await _paymentService.CancelInvoiceByNumberAsync(invoiceNumber));
        }
        
    }
}
