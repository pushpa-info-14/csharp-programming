namespace CSharpProgramming.Study.DesignPatterns.CreationalDesignPatterns.FactoryDesignPattern.Examples.DocumentConversionSystem
{
    public class DocumentConverterProgram
    {
        public void Test()
        {
            var content = "This is the content for conversion";
            var formats = new string[] { "DOCX", "PDF", "TXT" };
            var format = formats[new Random().Next(0, formats.Length)];
            try
            {
                IDocumentConverter converter = DocumentConverterFactory.CreateDocumentConverter(format);
                var convertedContent = converter.Convert(content);
                Console.WriteLine($"Converted content ({converter.TargetExtension}): {convertedContent}");
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
