namespace CSharpProgramming.Study.DesignPatterns.Creational.FactoryMethod.Examples.DocumentFormatConverter
{
    public class DocxConverter : IDocumentConverter
    {
        public void Convert(string inputFile, string outputFile)
        {
            Console.WriteLine($"Converting {inputFile} to DOCX and saving as {outputFile}.");
            // Actual DOCX conversion logic goes here...
        }
    }
}
