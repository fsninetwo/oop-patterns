using OOP_Patterns.Common.Domain.Converters;
using OOP_Patterns.Common.Domain.Enums;
using OOP_Patterns.Common.Domain.Strategies;
using OOP_Patterns.Services.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Patterns.Services.Services.Template
{
    public class FileConverterService: IFileConverterService
    {
        public Task<string> ConvertFileAsync(string fileName, FileTypeEnum fileTypeEnum)
        {
            var documentConverter = GetConverter(fileTypeEnum);

            return documentConverter.ConvertDocument(fileName);
        }

        private DocumentConverter GetConverter(FileTypeEnum fileTypeEnum)
        {
            switch(fileTypeEnum) {
                case FileTypeEnum.Pdf: 
                    return new PdfConverter();
                case FileTypeEnum.Txt:
                    return new TxtConverter();
                default:
                    throw new NotImplementedException();
            };
        }
    }
}
