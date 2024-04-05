namespace CSharpProgramming.Study.DesignPatterns.Creational.FactoryMethod.Examples.ReportGenerator
{
    public class TabularReportGenerator : IReportGenerator
    {
        public void GenerateReport(string data)
        {
            Console.WriteLine($"Generating Tabular Report with data: {data}");
            // Actual logic to generate a tabular report...
        }
    }
}
