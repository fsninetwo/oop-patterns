using OOP_Patterns.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Patterns.Common.Domain.Builders
{
    public class ReportBuilder
    {
        private readonly ReportModel reportModel;

        public ReportBuilder()
        {
            reportModel = new ReportModel();
        }

        public ReportBuilder SetReportType(string message)
        {
            reportModel.Type = message;
            return this;
        }

        public ReportBuilder SetReportContent(string message)
        {
            reportModel.Content = message;
            return this;
        }

        public ReportBuilder SetReportFooter(string message)
        {
            reportModel.Footer = message;
            return this;
        }

        public ReportBuilder SetReportHeader(string message)
        {
            reportModel.Header = message;
            return this;
        }

        public ReportModel BuildReport()
        {
            return reportModel;
        }
    }
}
