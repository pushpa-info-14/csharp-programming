namespace CSharpProgramming.Study.DesignPatterns.Creational.FactoryMethod.Examples.DocumentFormatConverter
{
    public class PdfConverterFactory : DocumentConverterFactory
    {
        public override IDocumentConverter CreateConverter()
        {
            return new PdfConverter();
        }
    }
}
