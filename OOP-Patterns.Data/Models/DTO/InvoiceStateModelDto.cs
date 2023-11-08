using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Patterns.Data.Models.DTO
{
    public class InvoiceStateModelDto
    {
        public long Number { get; set; }

        public decimal Amount { get; set; }

        public string Description { get; set; }
    }
}
