namespace CSharpProgramming.Study.DesignPatterns.Creational.FactoryMethod.Examples
{
    public class AnalyticsServiceProgram
    {
        // Product(Interface)
        public interface IReportGenerator
        {
            void GenerateReport(string data);
        }

        // Concrete Products
        public class ChartReportGenerator : IReportGenerator
        {
            public void GenerateReport(string data)
            {
                Console.WriteLine($"Generating Chart Report with data: {data}");
                // Actual logic to generate a chart report...
            }
        }

        public class TabularReportGenerator : IReportGenerator
        {
            public void GenerateReport(string data)
            {
                Console.WriteLine($"Generating Tabular Report with data: {data}");
                // Actual logic to generate a tabular report...
            }
        }

        public class SummaryReportGenerator : IReportGenerator
        {
            public void GenerateReport(string data)
            {
                Console.WriteLine($"Generating Summary Report with data: {data}");
                // Actual logic to generate a summary report...
            }
        }

        // Creator(Abstract Class)
        public abstract class ReportGeneratorFactory
        {
            public abstract IReportGenerator CreateReportGenerator();
        }

        // Concrete Creators
        public class ChartReportGeneratorFactory : ReportGeneratorFactory
        {
            public override IReportGenerator CreateReportGenerator()
            {
                return new ChartReportGenerator();
            }
        }

        public class TabularReportGeneratorFactory : ReportGeneratorFactory
        {
            public override IReportGenerator CreateReportGenerator()
            {
                return new TabularReportGenerator();
            }
        }

        public class SummaryReportGeneratorFactory : ReportGeneratorFactory
        {
            public override IReportGenerator CreateReportGenerator()
            {
                return new SummaryReportGenerator();
            }
        }

        // Client Code
        public class AnalyticsService
        {
            public void CreateReport(ReportGeneratorFactory factory, string data)
            {
                IReportGenerator reportGenerator = factory.CreateReportGenerator();
                reportGenerator.GenerateReport(data);
            }
        }

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
