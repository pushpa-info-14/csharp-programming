namespace CSharpProgramming.Study.DesignPatterns.Creational.FactoryMethod.Examples.ReportGenerator
{
    public class SummaryReportGeneratorFactory : ReportGeneratorFactory
    {
        public override IReportGenerator CreateReportGenerator()
        {
            return new SummaryReportGenerator();
        }
    }
}
