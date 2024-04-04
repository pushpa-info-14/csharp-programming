namespace CSharpProgramming.Study.DesignPatterns.CreationalDesignPatterns.FactoryDesignPattern.Examples.ReportGeneration
{
    public class HrReport : IReportGenerator
    {
        public void GenerateReport()
        {
            Console.WriteLine("Generating HR Report...");
            // Logic for generating HR report
        }
    }
}
