namespace CSharpProgramming.Study.DesignPatterns.CreationalDesignPatterns.FactoryDesignPattern.Examples.DocumentConversionSystem
{
    public interface IDocumentConverter
    {
        string Convert(string content);
        string TargetExtension { get; }
    }
}
