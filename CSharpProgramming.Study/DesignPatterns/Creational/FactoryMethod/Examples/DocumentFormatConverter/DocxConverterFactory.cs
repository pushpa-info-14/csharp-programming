namespace CSharpProgramming.Study.DesignPatterns.Creational.FactoryMethod.Examples.DocumentFormatConverter
{
    public class DocxConverterFactory : DocumentConverterFactory
    {
        public override IDocumentConverter CreateConverter()
        {
            return new DocxConverter();
        }
    }
}
