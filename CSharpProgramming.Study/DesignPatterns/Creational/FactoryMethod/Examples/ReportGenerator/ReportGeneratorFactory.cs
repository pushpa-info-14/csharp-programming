namespace CSharpProgramming.Study.DesignPatterns.Creational.FactoryMethod.Examples.ReportGenerator
{
    public abstract class ReportGeneratorFactory
    {
        public abstract IReportGenerator CreateReportGenerator();
    }
}
