using System;

namespace SoftDesPhase2Engine.Classes
{
    public interface IReportGenerator
    {
        void GenerateReport();
    }

    public interface IReportExporter
    {
        void ExportReport();
    }

    public interface IReportSender
    {
        void SendReportByEmail(string recipientEmail);
    }

    public class Report : IReportGenerator, IReportExporter, IReportSender
    {
        public int Id { get; set; }
        public DateTime DateGenerated { get; set; }
        public string Type { get; set; }
        public string Content { get; set; }

        public Report(int id, DateTime dateGenerated, string type, string content)
        {
            Id = id;
            DateGenerated = dateGenerated;
            Type = type;
            Content = content;
        }

        public void GenerateReport()
        {
            // Code to generate the report
            Console.WriteLine("Report generated.");
        }

        public void ExportReport()
        {
            // Code to export the report to a file
            Console.WriteLine("Report exported to file.");
        }

        public void SendReportByEmail(string recipientEmail)
        {
            // Code to send the report via email
            Console.WriteLine($"Report sent to {recipientEmail}.");
        }
    }
}
