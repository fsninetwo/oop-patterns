using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Patterns.Data.Models
{
    public class ReportModel
    {
        public string Type { get; set; }
        public string Header { get; set; }
        public string Content { get; set; }
        public string Footer { get; set; }

        public ReportModel ShallowCopy()
        {
            return (ReportModel) MemberwiseClone();
        }

        public ReportModel DeepCopy()
        {
            var report = (ReportModel) MemberwiseClone();
            report.Type = new string(Type);
            report.Header = new string(Header);
            report.Content = new string(Content);
            report.Footer = new string(Footer);
            return report;
        }
    }
}
