namespace CSharpProgramming.Study.DesignPatterns.Creational.FactoryMethod.Examples.ReportGenerator
{
    public class AnalyticsService
    {
        public void CreateReport(ReportGeneratorFactory factory, string data)
        {
            IReportGenerator reportGenerator = factory.CreateReportGenerator();
            reportGenerator.GenerateReport(data);
        }
    }
}
