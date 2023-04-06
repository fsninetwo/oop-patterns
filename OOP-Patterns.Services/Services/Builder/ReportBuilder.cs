using OOP_Patterns.Data.Models;
using OOP_Patterns.Services.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Patterns.Services.Services.Builder
{
    public class ReportBuilder
    {
        private readonly ReportModel _reportModel;

        public ReportBuilder()
        {
            _reportModel = new ReportModel();
        }

        public ReportBuilder(ReportModel reportModel)
        {
            _reportModel = reportModel;
        }

        public ReportBuilder SetReportType(string message)
        {
            _reportModel.Type = message;
            return this;
        }

        public ReportBuilder SetReportContent(string message)
        {
            _reportModel.Content = message;
            return this;
        }

        public ReportBuilder SetReportFooter(string message)
        {
            _reportModel.Footer = message;
            return this;
        }

        public ReportBuilder SetReportHeader(string message)
        {
            _reportModel.Header = message;
            return this;
        }

        public ReportModel BuildReport()
        {
            return _reportModel;
        }
    }
}
