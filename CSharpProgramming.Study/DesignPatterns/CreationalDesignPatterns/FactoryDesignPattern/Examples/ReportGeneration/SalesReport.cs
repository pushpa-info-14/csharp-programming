namespace CSharpProgramming.Study.DesignPatterns.CreationalDesignPatterns.FactoryDesignPattern.Examples.ReportGeneration
{
    public class SalesReport : IReportGenerator
    {
        public void GenerateReport()
        {
            Console.WriteLine("Generating Sales Report...");
            // Logic for generating sales report
        }
    }
}
