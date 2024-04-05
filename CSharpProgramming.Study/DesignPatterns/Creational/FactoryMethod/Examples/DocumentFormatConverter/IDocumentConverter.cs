namespace CSharpProgramming.Study.DesignPatterns.Creational.FactoryMethod.Examples.DocumentFormatConverter
{
    public interface IDocumentConverter
    {
        void Convert(string inputFile, string outputFile);
    }
}
