using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Patterns.Common.Domain.Converters
{
    public abstract class DocumentConverter
    {
        public async Task<string> ConvertDocument(string filePath)
        {
            await LoadDocument(filePath);
            await ParseContent();
            await ConvertToTargetFormat();
            await SaveConvertedDocument();
            return await Task.FromResult($"File {filePath} is converted");
        }

        private async Task LoadDocument(string filePath)
        {
            await Task.CompletedTask;
        }

        protected abstract Task ParseContent();
        protected abstract Task ConvertToTargetFormat();
        protected abstract Task SaveConvertedDocument();
    }
}
