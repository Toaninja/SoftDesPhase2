using SoftDesPhase2Engine.Classes;
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


//Responsibility Principle (SRP): The Report class has a single responsibility, which is to generate, export, and send reports. Each of these tasks is separated into its own interface,
//and the Report class implements all of them.

//Interface Segregation Principle (ISP): The Report class implements multiple interfaces, each of which has a single responsibility. This means that the Report class only needs to implement
//the methods relevant to its purpose, and it does not need to implement methods that are not used.

//Dependency Inversion Principle (DIP): The interfaces(IReportGenerator, IReportExporter, and IReportSender) are abstractions that the Report class depends on, rather than depending on
//concrete implementations. This allows the Report class to be flexible and easily maintainable, as the specific implementation of each interface can be changed without affecting the Report class.