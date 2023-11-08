using OOP_Patterns.Common.Domain.States;
using OOP_Patterns.Common.Domain.States.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Patterns.Common.Domain.Models.StateModels
{
    public class InvoiceStateModel
    {
        public long Number { get; set; }

        public decimal Amount { get; set; }

        public string Description { get; set; }

        private IInvoiceState State = new UnpaidInvoiceState();

        public async Task<string> PayInvoiceAsync()
        {
            var result = await State.Pay(this);
            State = new PaidInvoiceState();
            return result;
        }

        public async Task<string> CanceInvoiceAsync()
        {
            var result = await State.Cancel(this);
            State = new CanceledInvoiceState();
            return result;
        }

        public async Task<string> RefundInvoiceAsync()
        {
            var result = await State.Refund(this);
            State = new RefundedInvoiceState();
            return result;
        }
    }
}
