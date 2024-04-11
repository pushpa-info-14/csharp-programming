namespace CSharpProgramming.Study.DesignPatterns.Creational.Builder.ReportBuilder;

// The Following Concrete Builder Implemented the ReportBuilder Abstract Class and 
// provide specific implementations of the steps for Creating PDFReport.
public class PdfReport : ReportBuilder
{
    public override void SetReportContent()
    {
        reportObject.ReportContent = "PDF Content Section";
    }
    public override void SetReportFooter()
    {
        reportObject.ReportFooter = "PDF Footer";
    }
    public override void SetReportHeader()
    {
        reportObject.ReportHeader = "PDF Header";
    }
    public override void SetReportType()
    {
        reportObject.ReportType = "PDF";
    }
}