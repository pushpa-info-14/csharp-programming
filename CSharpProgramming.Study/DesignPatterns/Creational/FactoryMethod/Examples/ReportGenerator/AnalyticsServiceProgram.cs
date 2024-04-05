namespace CSharpProgramming.Study.DesignPatterns.Creational.FactoryMethod.Examples.ReportGenerator
{
    public class AnalyticsServiceProgram
    {
        public void Test()
        {
            var analyticsService = new AnalyticsService();

            // User wants a Chart report:
            analyticsService.CreateReport(new ChartReportGeneratorFactory(), "ChartData123");

            // User wants a Tabular report:
            analyticsService.CreateReport(new TabularReportGeneratorFactory(), "TabularData456");

            // User wants a Summary report:
            analyticsService.CreateReport(new SummaryReportGeneratorFactory(), "SummaryData789");
        }
    }
}
