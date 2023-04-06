using OOP_Patterns.Common.Domain.Enums;
using OOP_Patterns.Data.Models;
using OOP_Patterns.Services.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Patterns.Services.Services.Builder
{
    public class ReportService : IReportService
    {
        private readonly ReportBuilder _reportBuilder;

        public ReportService() 
        { 
            _reportBuilder = new ReportBuilder();
        }

        public async Task<ReportModel> GetFullReportAsync(DocumentEnum documentType)
        {
            var report = _reportBuilder
                .SetReportType(documentType.ToString())
                .SetReportHeader("Header")
                .SetReportContent("Content")
                .SetReportFooter("Footer")
                .BuildReport();

            return await Task.FromResult(report);
        }

        public async Task<ReportModel> GetShortReportAsync(DocumentEnum documentType)
        {
            var report = _reportBuilder
                .SetReportType(documentType.ToString())
                .SetReportContent("Content")
                .BuildReport();

            return await Task.FromResult(report);
        }

        public async Task<ReportModel> GetDeepCopyReportAsync(DocumentEnum documentType)
        {
            var report = await GetFullReportAsync(documentType);

            var clonedReport = new ReportBuilder(report.DeepCopy())
                .SetReportHeader("Cloned Header")
                .BuildReport();

            return clonedReport;
        }

        public async Task<ReportModel> GetShallowCopyReportAsync(DocumentEnum documentType)
        {
            var report = await GetShortReportAsync(documentType);

            var clonedReport = new ReportBuilder(report.DeepCopy())
                .SetReportHeader("Cloned Header")
                .BuildReport();

            return clonedReport;
        }
    }
}
