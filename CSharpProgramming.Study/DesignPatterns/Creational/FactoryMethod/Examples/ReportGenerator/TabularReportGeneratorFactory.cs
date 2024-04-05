namespace CSharpProgramming.Study.DesignPatterns.Creational.FactoryMethod.Examples.ReportGenerator
{
    public class TabularReportGeneratorFactory : ReportGeneratorFactory
    {
        public override IReportGenerator CreateReportGenerator()
        {
            return new TabularReportGenerator();
        }
    }
}
