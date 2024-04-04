namespace CSharpProgramming.Study.DesignPatterns.CreationalDesignPatterns.FactoryDesignPattern.Examples.DocumentConversionSystem
{
    public class DocumentConverterProgram
    {
        public void Test()
        {
            var content = "This is the content for conversion";

            IDocumentConverter converter = DocumentConverterFactory.CreateDocumentConverter("DOCX");
            var convertedContent = converter.Convert(content);
            Console.WriteLine($"Converted content ({converter.TargetExtension}): {convertedContent}");

            converter = DocumentConverterFactory.CreateDocumentConverter("PDF");
            convertedContent = converter.Convert(content);
            Console.WriteLine($"Converted content ({converter.TargetExtension}): {convertedContent}");

            converter = DocumentConverterFactory.CreateDocumentConverter("TXT");
            convertedContent = converter.Convert(content);
            Console.WriteLine($"Converted content ({converter.TargetExtension}): {convertedContent}");
        }
    }
}
