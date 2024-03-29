﻿using OOP_Patterns.Common.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Patterns.Services.IServices
{
    public interface IFileConverterService
    {
        public Task<string> ConvertFileAsync(string fileName, FileTypeEnum fileTypeEnum);
    }
}
