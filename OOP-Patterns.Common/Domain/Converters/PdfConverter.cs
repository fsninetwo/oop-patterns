using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Patterns.Common.Domain.Converters
{
    public class PdfConverter : DocumentConverter
    {
        protected override async Task ConvertToTargetFormat()
        {
            await Task.CompletedTask;
        }

        protected override async Task ParseContent()
        {
            await Task.CompletedTask;
        }

        protected override async Task SaveConvertedDocument()
        {
            await Task.CompletedTask;
        }
    }
}
