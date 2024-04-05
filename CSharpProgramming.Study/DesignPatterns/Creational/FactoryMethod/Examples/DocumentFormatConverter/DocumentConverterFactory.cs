namespace CSharpProgramming.Study.DesignPatterns.Creational.FactoryMethod.Examples.DocumentFormatConverter
{
    public abstract class DocumentConverterFactory
    {
        public abstract IDocumentConverter CreateConverter();
    }
}
