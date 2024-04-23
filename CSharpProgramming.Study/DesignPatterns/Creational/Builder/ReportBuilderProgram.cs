namespace CSharpProgramming.Study.DesignPatterns.Creational.Builder
{
    public class ReportBuilderProgram
    {
        // It makes sense to use the Builder Design Pattern only 
        // when your products are quite complex and require extensive configuration.
        // Using the following Report Product class, we can configure different types of Product
        public class Report
        {
            public string ReportType { get; set; }
            public string ReportHeader { get; set; }
            public string ReportFooter { get; set; }
            public string ReportContent { get; set; }
            public void DisplayReport()
            {
                Console.WriteLine("Report Type :" + ReportType);
                Console.WriteLine("Header :" + ReportHeader);
                Console.WriteLine("Content :" + ReportContent);
                Console.WriteLine("Footer :" + ReportFooter);
            }
        }

        // The Builder Abstract Class specifies methods for creating the different parts
        // of the Product objects.
        public abstract class ReportBuilder
        {
            protected Report ReportObject;

            public abstract void SetReportType();

            public abstract void SetReportHeader();

            public abstract void SetReportContent();

            public abstract void SetReportFooter();

            public void CreateNewReport()
            {
                ReportObject = new Report();
            }

            public Report GetReport()
            {
                return ReportObject;
            }
        }

        // The Following Concrete Builder Implemented the ReportBuilder Abstract Class and 
        // provide specific implementations of the steps for Creating ExcelReport. 
        public class ExcelReport : ReportBuilder
        {
            public override void SetReportContent()
            {
                ReportObject.ReportContent = "Excel Content Section";
            }

            public override void SetReportFooter()
            {
                ReportObject.ReportFooter = "Excel Footer";
            }

            public override void SetReportHeader()
            {
                ReportObject.ReportHeader = "Excel Header";
            }

            public override void SetReportType()
            {
                ReportObject.ReportType = "Excel";
            }
        }

        // The Following Concrete Builder Implemented the ReportBuilder Abstract Class and 
        // provide specific implementations of the steps for Creating PDFReport.
        public class PdfReport : ReportBuilder
        {
            public override void SetReportContent()
            {
                ReportObject.ReportContent = "PDF Content Section";
            }

            public override void SetReportFooter()
            {
                ReportObject.ReportFooter = "PDF Footer";
            }

            public override void SetReportHeader()
            {
                ReportObject.ReportHeader = "PDF Header";
            }

            public override void SetReportType()
            {
                ReportObject.ReportType = "PDF";
            }
        }

        // The Director is only responsible for executing the building steps in a particular order. 
        // It is helpful when producing products according to a specific order or configuration. 
        public class ReportDirector
        {
            public Report MakeReport(ReportBuilder reportBuilder)
            {
                reportBuilder.CreateNewReport();
                reportBuilder.SetReportType();
                reportBuilder.SetReportHeader();
                reportBuilder.SetReportContent();
                reportBuilder.SetReportFooter();
                return reportBuilder.GetReport();
            }
        }

        public void Test()
        {
            // Constructing the PDF Report
            // Step1: Create a Builder Object 
            // Creating PDFReport Builder Object
            var pdfReport = new PdfReport();

            // Step2: Pass the Builder Object to the Director
            // First Create an instance of ReportDirector
            var reportDirector = new ReportDirector();

            // Then Pass the pdfReport Builder Object to the MakeReport Method of ReportDirector
            // The ReportDirector will return one of the Representations of the Product
            var report = reportDirector.MakeReport(pdfReport);

            // Step3: Display the Report by calling the DisplayReport method of the Product
            report.DisplayReport();
            Console.WriteLine("-------------------");

            // Constructing the Excel Report
            // The Process is going to be the same
            var excelReport = new ExcelReport();
            report = reportDirector.MakeReport(excelReport);
            report.DisplayReport();
        }
    }
}
