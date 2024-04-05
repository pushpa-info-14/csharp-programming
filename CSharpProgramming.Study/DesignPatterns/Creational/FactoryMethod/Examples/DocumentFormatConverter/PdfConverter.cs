namespace CSharpProgramming.Study.DesignPatterns.Creational.FactoryMethod.Examples.DocumentFormatConverter
{
    public class PdfConverter : IDocumentConverter
    {
        public void Convert(string inputFile, string outputFile)
        {
            Console.WriteLine($"Converting {inputFile} to PDF and saving as {outputFile}.");
            // Actual PDF conversion logic goes here...
        }
    }
}
