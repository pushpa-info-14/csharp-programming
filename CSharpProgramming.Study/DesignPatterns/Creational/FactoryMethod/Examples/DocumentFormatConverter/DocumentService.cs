namespace CSharpProgramming.Study.DesignPatterns.Creational.FactoryMethod.Examples.DocumentFormatConverter
{
    public class DocumentService
    {
        public void ExportDocument(DocumentConverterFactory factory, string inputFile, string outputFile)
        {
            var converter = factory.CreateConverter();
            converter.Convert(inputFile, outputFile);
        }
    }
}
