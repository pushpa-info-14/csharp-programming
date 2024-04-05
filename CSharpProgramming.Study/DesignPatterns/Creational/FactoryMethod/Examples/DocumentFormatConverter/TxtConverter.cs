namespace CSharpProgramming.Study.DesignPatterns.Creational.FactoryMethod.Examples.DocumentFormatConverter
{
    public class TxtConverter : IDocumentConverter
    {
        public void Convert(string inputFile, string outputFile)
        {
            Console.WriteLine($"Converting {inputFile} to TXT and saving as {outputFile}.");
            // Actual TXT conversion logic goes here...
        }
    }
}
