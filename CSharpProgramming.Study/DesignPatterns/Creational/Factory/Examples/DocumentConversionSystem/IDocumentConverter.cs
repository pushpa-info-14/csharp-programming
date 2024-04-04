namespace CSharpProgramming.Study.DesignPatterns.Creational.Factory.Examples.DocumentConversionSystem
{
    public interface IDocumentConverter
    {
        string Convert(string content);
        string TargetExtension { get; }
    }
}
