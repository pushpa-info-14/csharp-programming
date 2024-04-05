namespace CSharpProgramming.Study.DesignPatterns.Creational.FactoryMethod.Examples.ReportGenerator
{
    public class ChartReportGenerator : IReportGenerator
    {
        public void GenerateReport(string data)
        {
            Console.WriteLine($"Generating Chart Report with data: {data}");
            // Actual logic to generate a chart report...
        }
    }
}
