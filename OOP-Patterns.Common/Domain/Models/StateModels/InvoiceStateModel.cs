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
        public int Number { get; }

        public decimal Amount { get; }

        public string Description { get; }

        public IInvoiceState State { get; set; }
    }
}
