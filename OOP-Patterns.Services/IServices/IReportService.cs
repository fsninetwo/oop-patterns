using OOP_Patterns.Common.Domain.Enums;
using OOP_Patterns.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Patterns.Services.IServices
{
    public interface IReportService
    {
        public Task<ReportModel> GetShortReportAsync(DocumentEnum documentType);

        public Task<ReportModel> GetFullReportAsync(DocumentEnum documentType);
    }
}
